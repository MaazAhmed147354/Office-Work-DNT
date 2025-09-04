using backend_dotnet.DTOs;
namespace backend_dotnet.Services
{
    public interface IProductWarrantyService
    {
        Task<ProductWarrantyResponseDTO> GetProductWarrantyByMac(ProductWarrantyRequestDTO productwarrantyDto);
    }
}
