using backend_dotnet.DTOs;
namespace backend_dotnet.Services
{
    public interface IProductService
    {
        public Task<List<ProductDetailsResponseDTO>> GetProductsList();
    }
}
