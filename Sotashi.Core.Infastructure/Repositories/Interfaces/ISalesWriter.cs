using Sotashi.Core.Infastructure.Entities;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Repositories.Interfaces
{
    public interface ISalesWriter
    {
        /// <summary>
        /// Attaches a new sale's record into repository
        /// </summary>
        /// <param name="sale"></param>
        Task AddAsync(Sale sale);
    }
}
