using backend_dotnet.Data;
using backend_dotnet.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace backend_dotnet.Repositories
{
    public class ProductWarrantyRepository : IProductWarrantyRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductWarrantyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ProductWarrantyResponseDTO> GetProductWarrantyByMac(string macAddress)
        {
            var data =
                (from pd in _context.VwProductDetails
                 where pd.MacAddress == macAddress
                 join wm in _context.TblWarrantyModes
                     on pd.WarrantyModeId ?? 0 equals wm.Id
                 join o in _context.VwOrders
                     on pd.OrderId ?? 0 equals o.Id
                 join od in _context.VwOrderDetails
                     on new { OrderId = o.Id, ProductId = pd.ProductId ?? 0 }
                     equals new { od.OrderId, od.ProductId }
                 join p in _context.VwProducts
                     on pd.ProductId ?? 0 equals p.ProductId
                 join c in _context.VwCustomers
                     on o.CustomerId equals c.Id
                 select new ProductWarrantyResponseDTO
                 {
                     WarrantyStartDate = pd.WarrantyStartDate2.HasValue
                         ? pd.WarrantyStartDate2.Value.ToString("yyyy-MM-dd")
                         : null,

                     WarrantyEndDate = pd.WarrantyStartDate2.HasValue
                         ? pd.WarrantyStartDate2.Value.AddDays(wm.Days ?? 0).ToString("dd/MM/yyyy")
                         : null,

                     WarrantyDuration = wm.Days >= 365
                         ? (wm.Days / 365) + " Year"
                         : wm.Days >= 30
                             ? (wm.Days / 30) + " Month"
                             : (wm.Days ?? 0) + " Days",

                     RemainingDays = pd.WarrantyStartDate2.HasValue
                        ? (int)(pd.WarrantyStartDate2.Value.ToDateTime(TimeOnly.MinValue)
                        .AddDays(wm.Days ?? 0) - DateTime.UtcNow.Date).TotalDays
    :                   0,

                     Invoice = "INV-" + o.BranchId + "-" + o.Id,
                     CustomerName = c.Name,
                     Company = c.Company,
                     Product = p.ProductName,
                     Price = od.Price ?? 0m
                 })
                .FirstOrDefault();

            return data;
        }
    }
}
