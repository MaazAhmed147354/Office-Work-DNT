using backend_dotnet.DTOs;

namespace backend_dotnet.Services
{
    public interface ISalesService
    {
        public Task<List<SalesBySalespersonResponseDTO>> GetSalesBySalesperson(int roleId, int userId);

        public Task<List<SalesBySalespersonResponseDTO>> GetSalesBySalespersonMonthWise(int roleId, int userId);
        public Task<List<SalesByProductResponseDTO>> GetSalesByProduct(int roleId, int userId);

        public Task<SalesSummaryResponseDTO> GetSalesSummary(int roleId, int userId);

        public Task<List<SalesAnalysisDTO>> GetSalesAnalysisPerSalesperson(
   int roleId,
   List<int> salesIds,
   string rangeType,
   DateTime referenceDate);
    }
}
