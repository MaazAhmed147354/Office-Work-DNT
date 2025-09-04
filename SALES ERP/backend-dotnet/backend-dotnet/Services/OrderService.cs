using backend_dotnet.Repositories;

namespace backend_dotnet.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderDataRepository _orderDataRepository;
        public OrderService(IOrderDataRepository orderDataRepository)
        {
            _orderDataRepository = orderDataRepository;
        }

        public async Task<object> GetProductContributionInOrder(DateTime startingDate, DateTime endingDate)
        {
            var orders = _orderDataRepository.GetProductContributionInOrder(startingDate, endingDate);

            return orders;
        }
    }
}
