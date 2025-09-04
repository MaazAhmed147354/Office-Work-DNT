using backend_dotnet.DTOs;
namespace backend_dotnet.Repositories
{
    public interface IProductRepository
    {
        public Task<List<ProductDetailsResponseDTO>> GetProductsList();
    }
}
