using backend_dotnet.DTOs;
using backend_dotnet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductWarrantyController : ControllerBase
    {
        private readonly IProductWarrantyService _productwarrantyService;

        public ProductWarrantyController(IProductWarrantyService productwarrantyService)
        {
            _productwarrantyService = productwarrantyService;
        }

        [Authorize]
        [HttpGet("GetProductWarrantyByMac")]
        public async Task<Object> GetByMac([FromQuery] ProductWarrantyRequestDTO productwarrantyDto)
        {
            var result = await _productwarrantyService.GetProductWarrantyByMac(productwarrantyDto);

            if (result == null)
                return NotFound(new { message = "No product found for the given MAC address" });

            return Ok(result);
        }
    }
}
