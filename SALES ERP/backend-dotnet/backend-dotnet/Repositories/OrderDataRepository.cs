using backend_dotnet.Data;
using backend_dotnet.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace backend_dotnet.Repositories
{
    public class OrderDataRepository : IOrderDataRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderDataRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<object> GetOrderDetailsByRange(DateTime? startingDate = null, DateTime? endingDate = null)
        {
            DateTime _startingdate = startingDate ?? DateTime.UtcNow; 
            DateTime _endingdate = endingDate ?? DateTime.UtcNow; 
            var orders = _context.Orders
             .Where(o => o.CreatedOnUtc.Date >= _startingdate.Date && o.CreatedOnUtc.Date <= _endingdate.Date)
             .ToList();
            return new
            {
                ordersList = orders,
                count = orders.Count
            };
        }
        public async Task<object> GetSalespersonOrderDetails(int? salespersonId = 17973886, DateTime? startingRange = null, DateTime? endingRange = null)
        {
            DateTime _startingRange = startingRange ?? DateTime.UtcNow.AddMonths(-2);
            DateTime _endingRange = endingRange ?? DateTime.UtcNow;
            var orderDetails = _context.Orders.Where(o => o.SalespersonId == salespersonId && o.CreatedOnUtc.Date >= _startingRange.Date && o.CreatedOnUtc.Date <= _endingRange.Date).ToList();
            return new {
                orders = orderDetails,
                count = orderDetails.Count
            };
        }
        public async Task<object> GetProductContributionInOrder(DateTime startingRange, DateTime endingRange)
        {
            //DateTime _startingRange = startingRange ?? DateTime.UtcNow.AddMonths(-2);
            //DateTime _endingRange = endingRange ?? DateTime.UtcNow;

            var data = _context.OrderItems
                .Join(_context.Orders,
                      oi => oi.OrderId,
                      o => o.Id,
                      (oi, o) => new { oi, o })
                .Where(joined => joined.o.CreatedOnUtc.Date >= startingRange.Date &&
                                 joined.o.CreatedOnUtc.Date <= endingRange.Date)
                .Join(_context.Products,
                      joined => joined.oi.ProductId,
                      p => p.Id,
                      (joined, p) => new
                      {
                          ProductName = p.Name,
                          Quantity = joined.oi.Quantity,
                          UnitPrice = joined.oi.Price,
                          TotalRevenue = joined.oi.Quantity * joined.oi.Price
                      })
                .GroupBy(x => x.ProductName)
                .Select(g => new
                {
                    ProductName = g.Key,
                    TotalQuantity = g.Sum(x => x.Quantity),
                    TotalRevenue = g.Sum(x => x.TotalRevenue)
                })
                .OrderByDescending(x => x.TotalRevenue)
                .ToList();

            var ranked = data
                .Select((x, index) => new
                {
                    Rank = index + 1,
                    x.ProductName,
                    x.TotalQuantity,
                    x.TotalRevenue
                })
                .ToList();

            return ranked;
        }

    }
}
