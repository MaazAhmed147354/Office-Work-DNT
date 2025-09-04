namespace backend_dotnet.DTOs
{
    public class ProductDetailsResponseDTO
    {
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
