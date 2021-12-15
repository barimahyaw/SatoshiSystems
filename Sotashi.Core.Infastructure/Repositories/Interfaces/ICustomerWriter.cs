using Sotashi.Core.Infastructure.Entities;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Repositories.Interfaces
{
    public interface ICustomerWriter
    {
        /// <summary>
        /// Attaches a new customer's record into repository
        /// </summary>
        /// <param name="customer"></param>
        Task AddAsync(Customer customer);
    }
}
