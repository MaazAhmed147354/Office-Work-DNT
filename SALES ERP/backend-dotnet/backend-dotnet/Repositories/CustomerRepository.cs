using backend_dotnet.Models;
using backend_dotnet.Data;
using System;

namespace backend_dotnet.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer GetByUsernameAndPassword(string username, string password)
        {
            return _context.Customers.FirstOrDefault(c => c.Username == username && c.Password == password);
        }
    }


}
