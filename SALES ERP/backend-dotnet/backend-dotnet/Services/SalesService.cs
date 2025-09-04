using backend_dotnet.DTOs;
using backend_dotnet.Repositories;

namespace backend_dotnet.Services
{
    public class SalesService : ISalesService
    {
        private readonly ISalesRepository _salesRepository;

        public SalesService(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }

        public async Task<List<SalesByProductResponseDTO>> GetSalesByProduct(int roleId, int userId)
        {
            return await _salesRepository.GetSalesByProduct(roleId,userId);
        }


        public async Task<List<SalesBySalespersonResponseDTO>> GetSalesBySalesperson(int roleId, int userId)
        {
            return await _salesRepository.GetSalesBySalesperson(roleId,userId);
        }

        public async Task<List<SalesBySalespersonResponseDTO>> GetSalesBySalespersonMonthWise(int roleId, int userId)
        {
            return await _salesRepository.GetSalesBySalespersonMonthWise(roleId, userId);
        }

        public async Task<SalesSummaryResponseDTO> GetSalesSummary(int roleId, int userId)
        {
            return await _salesRepository.GetSalesSummary(roleId, userId);
        }

        public async Task<List<SalesAnalysisDTO>> GetSalesAnalysisPerSalesperson(
   int roleId,
   List<int> salesIds,
   string rangeType,
   DateTime referenceDate)
        {
            return await _salesRepository.GetSalesAnalysisPerSalesperson(roleId, salesIds, rangeType, referenceDate);
        }
    }
}
