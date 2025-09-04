using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend_dotnet.Controllers
{
    [ApiController]
    [Route("api/pages")]
    public class PagesController : ControllerBase
    {
        // Accessible to ALL authenticated users (Admin and others)
        [Authorize]
        [HttpGet("dashboard")]
        public IActionResult DashboardPageAccess()
        {
            var user = User.Identity;
            return Ok($"Access granted to Dashboard {user.Name}");
        }
        [Authorize]
        [HttpGet("analytics")]
        public IActionResult AnalyticsPageAccess()
        {
            var user = User.Identity;
            return Ok($"Access granted to Analytics {user.Name}");
        }
        [Authorize]
        [HttpGet("warranty")]
        public IActionResult TasksPageAccess()
        {
            var user = User.Identity;
            return Ok($"Access granted to Task {user.Name}");
        }
        [Authorize]
        [HttpGet("employees")]
        public IActionResult EmployeesPageAccess()
        {
            var user = User.Identity;
            return Ok($"Access granted to Dashboard {user.Name}");
        }
        [Authorize]
        [HttpGet("products")]
        public IActionResult GroupsPageAccess()
        {
            var user = User.Identity;
            return Ok($"Access granted to Groups {user.Name}");
        }

        // Accessible to Admins only (role == "1")
        [Authorize(Roles = "1")]
        [HttpGet("settings")]
        public IActionResult SettingsPageAccess()
        {
            return Ok("Access granted to Settings Page");
        }
    }
}
