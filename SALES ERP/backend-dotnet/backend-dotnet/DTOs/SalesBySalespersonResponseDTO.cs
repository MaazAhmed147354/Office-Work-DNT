namespace backend_dotnet.DTOs
{
    public class SalesBySalespersonResponseDTO
    {
        public int? SalesPersonId { get; set; }   // nullable
        public string SalesPersonName { get; set; }
        public string? FirstOrderDate { get; set; }
        public string? LastOrderDate { get; set; }
        public string? FirstAcceptedDate { get; set; }

        public string MonthName { get; set; }
        //public string? createdAt { get; set; }
        public string? LastAcceptedDate { get; set; }
        public decimal? TotalSales { get; set; }   // nullable
        public int TotalOrders { get; set; }
    }
}
