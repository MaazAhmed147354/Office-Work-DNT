using backend_dotnet.DTOs;
using backend_dotnet.Repositories;
namespace backend_dotnet.Services
{
    public class ProductWarrantyService : IProductWarrantyService
    {
        private readonly IProductWarrantyRepository _productwarrantyRepository;

        public ProductWarrantyService(IProductWarrantyRepository productwarrantyRepository)
        {
            _productwarrantyRepository = productwarrantyRepository;
        }

        public async Task<ProductWarrantyResponseDTO> GetProductWarrantyByMac(ProductWarrantyRequestDTO productwarrantyDto)
        {
            return await _productwarrantyRepository.GetProductWarrantyByMac(productwarrantyDto.MacAddress);
        }
    }
}
