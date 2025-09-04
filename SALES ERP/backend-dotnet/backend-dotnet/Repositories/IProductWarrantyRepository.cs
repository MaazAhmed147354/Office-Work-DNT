using backend_dotnet.DTOs;
namespace backend_dotnet.Repositories
{
    public interface IProductWarrantyRepository
    {
        public Task<ProductWarrantyResponseDTO> GetProductWarrantyByMac(string macAddress);
    }
}
