using backend_dotnet.DTOs;
using backend_dotnet.Helpers;
using backend_dotnet.Repositories;

namespace backend_dotnet.Services
{
    public class AuthService : IAuthService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly JwtTokenHelper _jwtTokenHelper;

        public AuthService(ICustomerRepository customerRepository, JwtTokenHelper jwtTokenHelper)
        {
            _customerRepository = customerRepository;
            _jwtTokenHelper = jwtTokenHelper;
        }

        public LoginResponseDTO Login(LoginRequestDTO loginDto)
        {
            var customer = _customerRepository.GetByUsernameAndPassword(loginDto.Username, loginDto.Password);

            if (customer == null) return null;

            var token = _jwtTokenHelper.GenerateToken(customer);

            return new LoginResponseDTO
            {
                Id = customer.Id,
                Username = customer.Username,
                Role = (int)customer.UserRole,
                Token = token
            };
        }
    }
}
