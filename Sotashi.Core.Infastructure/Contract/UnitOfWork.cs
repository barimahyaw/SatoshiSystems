using Microsoft.EntityFrameworkCore.Storage;
using Sotashi.Core.Infastructure.DbContexts;
using Sotashi.Core.Infastructure.Repositories;
using Sotashi.Core.Infastructure.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Contract
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public ISalesReader SalesReader { get; }
        public ISalesWriter SalesWriter { get; }
        public IProductReader ProductReader { get; }
        public ICustomerWriter CustomerWriter { get; }

        /// <summary>
        /// Constructor for DBContext/Repositories injection
        /// </summary>
        /// <param name="dbContext"></param>
        public UnitOfWork(AppDbContext dbContext)
        {
            SalesReader = new SaleRepository(dbContext);
            SalesWriter = new SaleRepository(dbContext);
            ProductReader = new ProductRepository(dbContext);
            CustomerWriter = new CustomerRepository(dbContext);
            _dbContext = dbContext;
        }

        /// <summary>
        /// Saves all changes in the repository (memory) to database
        /// </summary>
        /// <returns>number of rows affected</returns>
        public async Task<int> SaveChangesAsync() => await _dbContext.SaveChangesAsync();

        /// <summary>
        /// Performs db transactions on a two or more db write jobs
        /// </summary>
        /// <returns></returns>
        public async Task<IDbContextTransaction> TransactionAsync() => await _dbContext.Database.BeginTransactionAsync();
    }
}
