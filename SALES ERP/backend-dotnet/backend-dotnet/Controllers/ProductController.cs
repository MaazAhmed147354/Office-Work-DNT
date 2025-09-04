using backend_dotnet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [Authorize]
        [HttpGet("GetProductsList")]
        public async Task<IActionResult> GetProductsList()
        {
            var result = await _productService.GetProductsList();
            if (result == null)
                return NotFound(new { message = "No products found!" });

            return Ok(result);
        }
    }
}
