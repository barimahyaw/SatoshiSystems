using Sotashi.Core.Infastructure.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Repositories.Interfaces
{
    public interface ISalesReader
    {
        /// <summary>
        /// Select a record of sales by it's guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a record of sale</returns>
        Task<Sale> FindByIdAsync(Guid id);

        /// <summary>
        /// Select all records of sales 
        /// </summary>
        /// <returns>a list of sale records</returns>
        Task<IList<Sale>> FindAllAsync();
    }
}
