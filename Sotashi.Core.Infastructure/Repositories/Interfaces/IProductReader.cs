using Sotashi.Core.Infastructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Repositories.Interfaces
{
    public interface IProductReader
    {
        /// <summary>
        /// Select all records of sales category 
        /// </summary>
        /// <returns>a list of sale records</returns>
        Task<List<Product>> FindAllAsync();
    }
}
