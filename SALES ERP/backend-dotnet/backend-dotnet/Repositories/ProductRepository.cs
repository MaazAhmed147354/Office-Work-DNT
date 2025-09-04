using backend_dotnet.Data;
using backend_dotnet.DTOs;
using Microsoft.EntityFrameworkCore;

namespace backend_dotnet.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDetailsResponseDTO>> GetProductsList()
        {
            var products = (
                from d in _context.TblProductDetails
                join p in _context.VwProducts
                    on d.ProductId equals p.ProductId
                join b in _context.VwBranches
                    on d.BranchId equals b.BranchId into branchGroup
                from b in branchGroup.DefaultIfEmpty() // LEFT JOIN
                where d.OrderId == 0
                      && (d.MissingItems ?? 0) == 0
                      && d.Active == 1
                      && p.Active == true
                group new { d, b, p } by new
                {
                    p.ProductId,
                    p.ProductName,
                    p.Price,
                    BranchId = d.BranchId, // use from TblProductDetails
                    BranchName = (b != null ? b.Name : null) ?? "Head Office"
                } into g
                orderby g.Key.ProductName
                select new ProductDetailsResponseDTO
                {
                    ProductId = g.Key.ProductId,
                    BranchId = g.Key.BranchId,
                    ProductName = g.Key.ProductName,
                    ProductQuantity = g.Count(),
                    ProductPrice = g.Key.Price,
                    BranchName = g.Key.BranchName
                }
            ).ToList();

            return products;
        }
    }
}
