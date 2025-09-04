namespace backend_dotnet.DTOs
{
    public class ProductWarrantyResponseDTO
    {
        public string WarrantyStartDate { get; set; }
        public string WarrantyEndDate { get; set; }
        public string WarrantyDuration { get; set; }
        public int RemainingDays { get; set; }
        public string Invoice { get; set; }
        public string CustomerName { get; set; }
        public string Company { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
    }
}
