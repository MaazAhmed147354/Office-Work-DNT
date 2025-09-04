namespace backend_dotnet.DTOs
{
    public class SalesByProductResponseDTO
    {
        public int? SalesPersonId { get; set; }
        public string SalesPersonName { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string? FirstOrderDate { get; set; }
        public string? LastOrderDate { get; set; }
        public string? FirstAcceptedDate { get; set; }
        public string? LastAcceptedDate { get; set; }
        public decimal? TotalSales { get; set; }
        public int TotalQuantity { get; set; }
        public int TotalOrders { get; set; }
    }
}
