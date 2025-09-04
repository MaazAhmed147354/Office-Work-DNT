using backend_dotnet.Models;

namespace backend_dotnet.Repositories
{
    public interface ICustomerRepository
{
        Customer GetByUsernameAndPassword(string username, string password);
}

}
