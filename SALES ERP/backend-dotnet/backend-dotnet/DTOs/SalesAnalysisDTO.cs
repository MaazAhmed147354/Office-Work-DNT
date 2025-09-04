namespace backend_dotnet.DTOs
{
    public class SalesAnalysisDTO
    {
        public int SalesPersonId { get; set; }
        public string SalesPersonName { get; set; }
        public decimal TotalSales { get; set; }
        public decimal PercentOfTotal { get; set; }
    }

}
