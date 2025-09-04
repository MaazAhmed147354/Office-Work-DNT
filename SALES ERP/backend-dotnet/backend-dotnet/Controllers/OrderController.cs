using backend_dotnet.Repositories;
using backend_dotnet.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend_dotnet.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderDataRepository _orderDataRepository;
        private readonly IOrderService _orderService;
        public OrderController(IOrderDataRepository orderDataRepository, IOrderService orderService)
        {
            _orderDataRepository = orderDataRepository;
            _orderService = orderService;
        }
        [HttpGet("OrderDataByRange")]
        public async Task<object> GetOrderByRange(DateTime? startingDate = null, DateTime? endingDate = null)
        {
            var orders = _orderDataRepository.GetOrderDetailsByRange(startingDate, endingDate);
            
            return orders;
        }
        [HttpGet("SalespersonOrderDataByRange")]
        public async Task<object> GetSalespersonOrderByRange(int? salespersonId, DateTime? startingDate = null, DateTime? endingDate = null)
        {
            var orders = _orderDataRepository.GetSalespersonOrderDetails(salespersonId, startingDate, endingDate);

            return orders;
        }
        [HttpGet("GetProductContributionInOrder")]
        public async Task<object> GetProductContributionInOrder(DateTime startingDate , DateTime endingDate)
        {
            var orders = _orderService.GetProductContributionInOrder(startingDate, endingDate);

            return orders;
        }
    }
}
