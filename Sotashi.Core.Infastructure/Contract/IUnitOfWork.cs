using Microsoft.EntityFrameworkCore.Storage;
using Sotashi.Core.Infastructure.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Contract
{
    public interface IUnitOfWork
    {
        public ISalesReader SalesReader { get; }
        public ISalesWriter SalesWriter { get; }
        public IProductReader ProductReader { get; }
        public ICustomerWriter CustomerWriter { get; }
        /// <summary>
        /// Saves all changes in the repository (memory) to database
        /// </summary>
        /// <returns>number of rows affected</returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// Performs db transactions on a two or more db write jobs
        /// </summary>
        /// <returns></returns>
        Task<IDbContextTransaction> TransactionAsync();
    }
}
