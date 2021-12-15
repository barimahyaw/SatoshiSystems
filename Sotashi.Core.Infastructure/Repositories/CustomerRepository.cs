using Sotashi.Core.Infastructure.DbContexts;
using Sotashi.Core.Infastructure.Entities;
using Sotashi.Core.Infastructure.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Repositories
{
    public class CustomerRepository : ICustomerWriter
    {
        private readonly AppDbContext _dbContext;
        /// <summary>
        /// Constructor for DI
        /// </summary>
        /// <param name="dbContext"></param>
        public CustomerRepository(AppDbContext dbContext) => _dbContext = dbContext;

        /// <summary>
        /// Attaches a new customer's record into repository
        /// </summary>
        /// <param name="customer"></param>
        public async Task AddAsync(Customer customer) => await _dbContext.Customers.AddAsync(customer);
    }
}
