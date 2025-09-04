    using backend_dotnet.Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    namespace backend_dotnet.Controllers
    {
        [ApiController]
        [Route("/api/[controller]")]
        public class SalesController : ControllerBase
        {
            private readonly ISalesService _salesService;

            public SalesController(ISalesService salesService)
            {
                _salesService = salesService;
            }

            [Authorize]
            [HttpGet("GetSalesBySalesperson")]
            public async Task<IActionResult> GetSalesBySalesperson(int roleId, int userId)
            {
                var result = await _salesService.GetSalesBySalesperson(roleId, userId);
                if (result == null || !result.Any())
                    return NotFound(new { message = "No data found!" });

                return Ok(result);
            }

            [Authorize]
            [HttpGet("GetSalesBySalespersonMonthWise")]
            public async Task<IActionResult> GetSalesBySalespersonMonthWise(int roleId, int userId)
            {
                var result = await _salesService.GetSalesBySalespersonMonthWise(roleId, userId);
                if (result == null || !result.Any())
                    return NotFound(new { message = "No data found!" });

                return Ok(result);
            }


            [Authorize]
            [HttpGet("GetSalesByProduct")]
            public async Task<IActionResult> GetSalesByProduct(int roleId, int userId)
            {
                var result = await _salesService.GetSalesByProduct(roleId,userId);
                if (result == null)
                    return NotFound(new { message = "No data found!" });

                return Ok(result);
            }

            [HttpGet("GetSalesSummary")]
            public async Task<IActionResult> GetSalesSummary(int roleId, int userId)
            {
                try
                {
                    var result = await _salesService.GetSalesSummary(roleId, userId);
                    return Ok(result);
                }
                catch (UnauthorizedAccessException ex)
                {
                    return Forbid(ex.Message);
                }
            }

            [Authorize]
            [HttpGet("GetSalesAnalysisPerSalesperson")]
            public async Task<IActionResult> GetSalesAnalysisPerSalesperson(int roleId,
        List<int> salesIds,
        string rangeType,
        DateTime referenceDate)
            {
                try
                {
                    var result = await _salesService.GetSalesAnalysisPerSalesperson(roleId, salesIds,rangeType,referenceDate);
                    return Ok(result);
                }
                catch (UnauthorizedAccessException ex)
                {
                    return Forbid(ex.Message);
                }
            }
        }
    }
