namespace backend_dotnet.DTOs
{
    // Comparison DTO
    public class SalesSummaryResponseDTO
    {
        public List<SalesByProductResponseDTO> SalesByProduct { get; set; }
        public List<SalesBySalespersonResponseDTO> SalesBySalesperson { get; set; }
        public ComparisonDTO TodayVsYesterday { get; set; }
        public ComparisonDTO ThisWeekVsLastWeek { get; set; }
        public ComparisonDTO ThisMonthVsLastMonth { get; set; }
    }

    public class ComparisonDTO
    {
        public decimal Current { get; set; }
        public decimal Previous { get; set; }
    }

}
