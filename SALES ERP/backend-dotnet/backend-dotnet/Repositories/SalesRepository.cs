using backend_dotnet.Data;
using backend_dotnet.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq;
namespace backend_dotnet.Repositories
{
    public class SalesRepository : ISalesRepository
    {
        private readonly ApplicationDbContext _context;
        public SalesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SalesSummaryResponseDTO> GetSalesSummary(int roleId, int userId)
        {
            // 1️⃣ Check role
            var role = await _context.UserRoles
                .FirstOrDefaultAsync(r => r.UserRoleId == roleId);

            if (role == null || !string.Equals(role.Name, "Administrator", StringComparison.OrdinalIgnoreCase))
                throw new UnauthorizedAccessException("Access denied");

            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var startOfWeek = now.AddDays(-(int)now.DayOfWeek);
            var yesterday = now.Date.AddDays(-1);
            var dateFormat = "dd/MM/yyyy hh:mm:ss tt";

            // 2️⃣ Reuse existing methods for product/salesperson
            var salesByProduct = await GetSalesByProduct(roleId, userId);
            var salesBySalesperson = await GetSalesBySalesperson(roleId, userId);

            // 3️⃣ Fetch orders into memory
            var ordersFromDb = await _context.Orders
                .Where(o => !o.Deleted && !string.IsNullOrEmpty(o.OrderDate))
                .ToListAsync();

            var ordersInMemory = ordersFromDb
                .Select(o =>
                {
                    bool valid = DateTime.TryParseExact(
                        o.OrderDate, dateFormat,
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime parsedDate);

                    return new { Order = o, OrderDateParsed = valid ? parsedDate : (DateTime?)null };
                })
                .Where(x => x.OrderDateParsed.HasValue)
                .ToList();

            // 4️⃣ Fetch order items into memory
            var orderIds = ordersInMemory.Select(x => x.Order.Id).ToList();
            var orderItems = await _context.OrderItems
                .Where(oi => orderIds.Contains(oi.OrderId))
                .ToListAsync();

            // 5️⃣ Compute totals per order
            var orderTotals = orderItems
                .GroupBy(oi => oi.OrderId)
                .ToDictionary(g => g.Key, g => g.Sum(oi => oi.Price * oi.Quantity));

            // 6️⃣ Helper function to calculate totals safely
            decimal GetSales(DateTime startDate, DateTime? endDate = null)
            {
                return ordersInMemory
                    .Where(x => x.OrderDateParsed.HasValue &&
                                x.OrderDateParsed.Value >= startDate &&
                                (!endDate.HasValue || x.OrderDateParsed.Value < endDate.Value))
                    .Sum(x =>
                    {
                        // Use nullable decimal if your dictionary is Dictionary<int, decimal?>
                        if (orderTotals.TryGetValue(x.Order.Id, out decimal? total))
                        {
                            return total ?? 0m; // handle null safely
                        }
                        return 0m;
                    });
            }


            // 7️⃣ Calculate all required totals
            decimal todaySales = GetSales(now.Date, now.Date.AddDays(1));
            decimal yesterdaySales = GetSales(yesterday, now.Date);
            decimal weekSales = GetSales(startOfWeek);
            decimal lastWeekSales = GetSales(startOfWeek.AddDays(-7), startOfWeek);
            decimal monthSales = GetSales(startOfMonth);
            decimal lastMonthSales = GetSales(startOfMonth.AddMonths(-1), startOfMonth);

            // 8️⃣ Return the summary DTO
            return new SalesSummaryResponseDTO
            {
                SalesByProduct = salesByProduct,
                SalesBySalesperson = salesBySalesperson,
                TodayVsYesterday = new ComparisonDTO { Current = todaySales, Previous = yesterdaySales },
                ThisWeekVsLastWeek = new ComparisonDTO { Current = weekSales, Previous = lastWeekSales },
                ThisMonthVsLastMonth = new ComparisonDTO { Current = monthSales, Previous = lastMonthSales }
            };
        }




        public async Task<List<SalesByProductResponseDTO>> GetSalesByProduct(int roleId, int userId)
        {
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var dateFormat = "dd/MM/yyyy hh:mm:ss tt";

            // Step 1: Resolve role name from roleId
            var roleName = await _context.UserRoles
                .Where(r => r.UserRoleId == roleId)
                .Select(r => r.Name)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(roleName))
            {
                // Role not found → no data
                return new List<SalesByProductResponseDTO>();
            }

            // Step 2: Build base query
            var rawQuery =
                from o in _context.Orders
                join oi in _context.OrderItems on o.Id equals oi.OrderId
                join s in _context.Customers on o.SalespersonId equals s.Id into salespersonJoin
                from salesperson in salespersonJoin.DefaultIfEmpty()
                join p in _context.VwProducts on oi.ProductId equals p.ProductId into productJoin
                from product in productJoin.DefaultIfEmpty()
                where o.Deleted == false
                select new { o, oi, salesperson, product };

            // Step 3: Apply role filter
            if (!string.Equals(roleName, "Administrator", StringComparison.OrdinalIgnoreCase))
            {
                rawQuery = rawQuery.Where(x => x.o.SalespersonId == userId);
            }

            // Step 4: Filter by current month using in-memory date parsing
            var query = rawQuery
                .AsEnumerable() // bring data into memory
                .Where(x =>
                {
                    DateTime orderDate;
                    return DateTime.TryParseExact(x.o.OrderDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out orderDate)
                        && orderDate >= startOfMonth;
                });

            // Step 5: Group and select data
            var salesByProducts =
                (from item in query
                 group item by new
                 {
                     item.o.SalespersonId,
                     SalesPersonName = item.salesperson?.Username ?? "No Name",
                     item.product?.ProductId,
                     item.product?.ProductName,
                     item.product?.ProductCode
                 } into g
                 orderby g.Sum(x => x.oi.Price * x.oi.Quantity) descending
                 select new SalesByProductResponseDTO
                 {
                     SalesPersonId = g.Key.SalespersonId,
                     SalesPersonName = g.Key.SalesPersonName,
                     ProductId = g.Key.ProductId ?? 0,
                     ProductName = g.Key.ProductName ?? "Unknown Product",
                     ProductCode = g.Key.ProductCode ?? "N/A",
                     FirstOrderDate = g.Min(x => x.o.OrderDate),
                     LastOrderDate = g.Max(x => x.o.OrderDate),
                     FirstAcceptedDate = g.Min(x => x.o.AcceptedDate),
                     LastAcceptedDate = g.Max(x => x.o.AcceptedDate),
                     TotalSales = g.Sum(x => x.oi.Price * x.oi.Quantity),
                     TotalQuantity = g.Sum(x => x.oi.Quantity),
                     TotalOrders = g.Select(x => x.o.Id).Distinct().Count()
                 })
                .ToList();

            return salesByProducts;
        }


        public async Task<List<SalesAnalysisDTO>> GetSalesAnalysisPerSalesperson(
    int roleId,
    List<int> salesIds,
    string rangeType,
    DateTime referenceDate)
        {
            // 1️⃣ Check role
            var role = await _context.UserRoles
                .FirstOrDefaultAsync(r => r.UserRoleId == roleId);

            bool isAdmin = role != null && string.Equals(role.Name, "Administrator", StringComparison.OrdinalIgnoreCase);
            if (role == null)
                throw new UnauthorizedAccessException("Role not found");

            // 2️⃣ Base orders query
            var ordersQuery = _context.Orders
                .Where(o => !o.Deleted && !string.IsNullOrEmpty(o.OrderDate));

            // 3️⃣ Filter sales IDs
            if (!isAdmin)
            {
                // non-admin can only see their own data
                salesIds = salesIds?.Where(id => id == roleId).ToList() ?? new List<int> { roleId };
            }

            if (salesIds != null && salesIds.Any())
                ordersQuery = ordersQuery.Where(o => salesIds.Contains(o.SalespersonId.Value));

            // 4️⃣ Fetch orders
            var orders = await ordersQuery.ToListAsync();

            var dateFormat = "dd/MM/yyyy hh:mm:ss tt";
            var ordersInMemory = orders
                .Select(o =>
                {
                    bool valid = DateTime.TryParseExact(
                        o.OrderDate, dateFormat,
                        CultureInfo.InvariantCulture, DateTimeStyles.None,
                        out DateTime parsedDate);

                    return new { Order = o, OrderDateParsed = valid ? parsedDate : (DateTime?)null };
                })
                .Where(x => x.OrderDateParsed.HasValue)
                .ToList();

            // 5️⃣ Determine range start/end
            DateTime start, end;
            switch (rangeType.ToLower())
            {
                case "week":
                    start = referenceDate.AddDays(-(int)referenceDate.DayOfWeek);
                    end = start.AddDays(7);
                    break;
                case "month":
                    start = new DateTime(referenceDate.Year, referenceDate.Month, 1);
                    end = start.AddMonths(1);
                    break;
                case "year":
                    start = new DateTime(referenceDate.Year, 1, 1);
                    end = start.AddYears(1);
                    break;
                case "quarter":
                    int currentQuarter = (referenceDate.Month - 1) / 3 + 1;
                    start = new DateTime(referenceDate.Year, (currentQuarter - 1) * 3 + 1, 1);
                    end = start.AddMonths(3);
                    break;
                default:
                    throw new ArgumentException("Invalid range type");
            }

            // 6️⃣ Fetch order items
            var orderIds = ordersInMemory.Select(x => x.Order.Id).ToList();
            var orderItems = await _context.OrderItems
                .Where(oi => orderIds.Contains(oi.OrderId))
                .ToListAsync();

            var orderTotals = orderItems
                .GroupBy(oi => oi.OrderId)
                .ToDictionary(g => g.Key, g => g.Sum(oi => oi.Price * oi.Quantity));

            // 7️⃣ Group by salesperson
            var salesByPerson = ordersInMemory
                .Where(x => x.OrderDateParsed.Value >= start && x.OrderDateParsed.Value < end)
                .GroupBy(x => x.Order.SalespersonId)
                .Select(g =>
                {
                    var total = g.Sum(x => orderTotals.TryGetValue(x.Order.Id, out decimal? t) ? t ?? 0m : 0m);
                    var name = _context.Customers.FirstOrDefault(c => c.Id == g.Key)?.Username ?? "No Name";
                    return new SalesAnalysisDTO
                    {
                        SalesPersonId = g.Key.Value,
                        SalesPersonName = name,
                        TotalSales = total
                    };
                })
                .ToList();

            // 8️⃣ Calculate percent
            var grandTotal = salesByPerson.Sum(s => s.TotalSales);
            foreach (var s in salesByPerson)
            {
                s.PercentOfTotal = grandTotal > 0 ? Math.Round((s.TotalSales / grandTotal) * 100, 2) : 0;
            }

            return salesByPerson;
        }




        public async Task<List<SalesBySalespersonResponseDTO>> GetSalesBySalesperson(int roleId, int userId)
        {
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var dateFormat = "dd/MM/yyyy hh:mm:ss tt";

            // Step 1: Resolve role name from roleId
            var roleName = await _context.UserRoles
                .Where(r => r.UserRoleId == roleId)
                .Select(r => r.Name)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(roleName))
            {
                // Role not found → no data
                return new List<SalesBySalespersonResponseDTO>();
            }

            // Step 2: Build base query
            var rawQuery =
            from o in _context.Orders
            join oi in _context.OrderItems on o.Id equals oi.OrderId
            join s in _context.Customers on o.SalespersonId equals s.Id into salespersonJoin
            from salesperson in salespersonJoin.DefaultIfEmpty()
            where o.Deleted == false
            select new { o, oi, salesperson };

            // Step 3: Apply role filter
            if (!string.Equals(roleName, "Administrator", StringComparison.OrdinalIgnoreCase))
            {
                rawQuery = rawQuery.Where(x => x.o.SalespersonId == userId);
            }

            var query = rawQuery
    .AsEnumerable() // bring data into memory
    .Where(x =>
    {
        DateTime orderDate;
        return DateTime.TryParseExact(x.o.OrderDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out orderDate)
            && orderDate >= startOfMonth;
    });

            // Step 4: Group and select data
            var salesbysalesperson =
        (from item in query
         group item by new
         {
             item.o.SalespersonId,
             SalesPersonName = item.salesperson?.Username ?? "No Name"
         } into g
         orderby g.Sum(x => x.oi.Price * x.oi.Quantity) descending
         select new SalesBySalespersonResponseDTO
         {
             SalesPersonId = g.Key.SalespersonId,
             SalesPersonName = g.Key.SalesPersonName,
             FirstOrderDate = g.Min(x => x.o.OrderDate),
             LastOrderDate = g.Max(x => x.o.OrderDate),
             FirstAcceptedDate = g.Min(x => x.o.AcceptedDate),
             LastAcceptedDate = g.Max(x => x.o.AcceptedDate),
             TotalSales = g.Sum(x => x.oi.Price * x.oi.Quantity),
             TotalOrders = g.Select(x => x.o.Id).Distinct().Count()
         })
        .ToList();

            return salesbysalesperson;
        }



        public async Task<List<SalesBySalespersonResponseDTO>> GetSalesBySalespersonMonthWise(int roleId, int userId)
        {
            var dateFormat = "dd/MM/yyyy hh:mm:ss tt"; // your DB format
            var now = DateTime.Now;
            var currentYear = now.Year;

            // Step 1: Resolve role name
            var roleName = await _context.UserRoles
                .Where(r => r.UserRoleId == roleId)
                .Select(r => r.Name)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(roleName))
                return new List<SalesBySalespersonResponseDTO>();

            // Step 2: Base query (no date parsing yet)
            var rawQuery =
                from o in _context.Orders
                join oi in _context.OrderItems on o.Id equals oi.OrderId
                join s in _context.Customers on o.SalespersonId equals s.Id into salespersonJoin
                from salesperson in salespersonJoin.DefaultIfEmpty()
                where o.Deleted == false
                select new { o, oi, salesperson };

            // Step 3: Apply role filter
            bool isAdmin = string.Equals(roleName, "Administrator", StringComparison.OrdinalIgnoreCase);
            if (!isAdmin)
            {
                rawQuery = rawQuery.Where(x => x.o.SalespersonId == userId);
            }

            // Step 4: Parse AcceptedDate in memory
            var parsedData = rawQuery
                .AsEnumerable()
                .Select(x =>
                {
                    DateTime acceptedDate;
                    DateTime? parsed = DateTime.TryParseExact(
                        x.o.AcceptedDate,
                        dateFormat,
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out acceptedDate
                    ) ? acceptedDate : (DateTime?)null;

                    return new
                    {
                        x.o,
                        x.oi,
                        x.salesperson,
                        AcceptedDateParsed = parsed
                    };
                })
                .Where(x => x.AcceptedDateParsed.HasValue
                            && x.AcceptedDateParsed.Value.Year == currentYear
                            && x.AcceptedDateParsed.Value.Month <= now.Month);

            // Step 5: Do grouping as before
            List<SalesBySalespersonResponseDTO> groupedResults;

            if (isAdmin)
            {
                groupedResults =
                    (from item in parsedData
                     group item by new
                     {
                         Year = item.AcceptedDateParsed.Value.Year,
                         Month = item.AcceptedDateParsed.Value.Month
                     } into g
                     orderby g.Key.Year, g.Key.Month
                     select new SalesBySalespersonResponseDTO
                     {
                         SalesPersonId = 0,
                         SalesPersonName = "All Salespersons",
                         MonthName = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MMM yyyy"),
                         FirstOrderDate = g.Min(x => x.o.OrderDate),
                         LastOrderDate = g.Max(x => x.o.OrderDate),
                         FirstAcceptedDate = g.Min(x => x.o.AcceptedDate),
                         LastAcceptedDate = g.Max(x => x.o.AcceptedDate),
                         TotalSales = g.Sum(x => x.oi.Price * x.oi.Quantity),
                         TotalOrders = g.Select(x => x.o.Id).Distinct().Count()
                     })
                    .ToList();
            }
            else
            {
                groupedResults =
                    (from item in parsedData
                     group item by new
                     {
                         item.o.SalespersonId,
                         SalesPersonName = item.salesperson?.Username ?? "No Name",
                         Year = item.AcceptedDateParsed.Value.Year,
                         Month = item.AcceptedDateParsed.Value.Month
                     } into g
                     orderby g.Key.Year, g.Key.Month
                     select new SalesBySalespersonResponseDTO
                     {
                         SalesPersonId = g.Key.SalespersonId,
                         SalesPersonName = g.Key.SalesPersonName,
                         MonthName = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MMM yyyy"),
                         FirstOrderDate = g.Min(x => x.o.OrderDate),
                         LastOrderDate = g.Max(x => x.o.OrderDate),
                         FirstAcceptedDate = g.Min(x => x.o.AcceptedDate),
                         LastAcceptedDate = g.Max(x => x.o.AcceptedDate),
                         TotalSales = g.Sum(x => x.oi.Price * x.oi.Quantity),
                         TotalOrders = g.Select(x => x.o.Id).Distinct().Count()
                     })
                    .ToList();
            }

            // Step 6: Generate all months up to current month
            var fullMonthList = Enumerable.Range(1, now.Month)
                .Select(m => new { Year = currentYear, Month = m })
                .ToList();

            // Step 7: Left join groupedResults onto fullMonthList
            var finalResults = new List<SalesBySalespersonResponseDTO>();

            foreach (var month in fullMonthList)
            {
                var monthName = new DateTime(month.Year, month.Month, 1).ToString("MMM yyyy");

                if (isAdmin)
                {
                    var existing = groupedResults.FirstOrDefault(r => r.MonthName == monthName);
                    finalResults.Add(existing ?? new SalesBySalespersonResponseDTO
                    {
                        SalesPersonId = 0,
                        SalesPersonName = "All Salespersons",
                        MonthName = monthName,
                        FirstOrderDate = null,
                        LastOrderDate = null,
                        FirstAcceptedDate = null,
                        LastAcceptedDate = null,
                        TotalSales = 0,
                        TotalOrders = 0
                    });
                }
                else
                {
                    // Might have multiple salespeople → collect all relevant rows
                    var matchingRows = groupedResults.Where(r => r.MonthName == monthName).ToList();

                    if (matchingRows.Any())
                    {
                        finalResults.AddRange(matchingRows);
                    }
                    else
                    {
                        // If salesperson has no sales this month → single zero row
                        finalResults.Add(new SalesBySalespersonResponseDTO
                        {
                            SalesPersonId = userId,
                            SalesPersonName = groupedResults.FirstOrDefault()?.SalesPersonName ?? "No Name",
                            MonthName = monthName,
                            FirstOrderDate = null,
                            LastOrderDate = null,
                            FirstAcceptedDate = null,
                            LastAcceptedDate = null,
                            TotalSales = 0,
                            TotalOrders = 0
                        });
                    }
                }
            }

            return finalResults.OrderBy(r => DateTime.ParseExact("01 " + r.MonthName, "dd MMM yyyy", CultureInfo.InvariantCulture)).ToList();
        }




    }
}
