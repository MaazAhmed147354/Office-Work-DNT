
namespace backend_dotnet.Repositories
{
    public interface IOrderDataRepository
    {
        public Task<object> GetOrderDetailsByRange(DateTime? startingDate = null, DateTime? endingDate = null);
        public Task<object> GetSalespersonOrderDetails(int? salespersonId = 12, DateTime? startingRange = null, DateTime? endingRange = null);
        public Task<object> GetProductContributionInOrder(DateTime startingRange, DateTime endingRange);
    }
}
