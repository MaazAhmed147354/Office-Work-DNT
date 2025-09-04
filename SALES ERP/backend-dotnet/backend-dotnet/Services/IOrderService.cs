namespace backend_dotnet.Services
{
    public interface IOrderService
    {
        Task<Object> GetProductContributionInOrder(DateTime startingDate, DateTime endingDate);
    }
}
