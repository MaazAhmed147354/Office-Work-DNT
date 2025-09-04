using backend_dotnet.DTOs;
using backend_dotnet.Repositories;

namespace backend_dotnet.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<ProductDetailsResponseDTO>> GetProductsList()
        {
            return await _productRepository.GetProductsList();
        }
    }
}
