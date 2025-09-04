using Microsoft.AspNetCore.Mvc;
using backend_dotnet.DTOs;
using backend_dotnet.Services;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequestDTO loginDto)
    {
        var result = _authService.Login(loginDto);

        if (result == null)
        {
            return Unauthorized(new { message = "Invalid username or password" });
        }

        return Ok(new { message = "Login successful", data = result });
    }
}
