using backend_dotnet.DTOs;

namespace backend_dotnet.Services
{
    public interface IAuthService
    {
        LoginResponseDTO Login(LoginRequestDTO loginDto);
    }
}
