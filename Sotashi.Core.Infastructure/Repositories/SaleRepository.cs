using Microsoft.EntityFrameworkCore;
using Sotashi.Core.Infastructure.DbContexts;
using Sotashi.Core.Infastructure.Entities;
using Sotashi.Core.Infastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Repositories
{
    public class SaleRepository : ISalesWriter, ISalesReader
    {
        private readonly AppDbContext _dbContext;
        /// <summary>
        /// Constructor for DI
        /// </summary>
        /// <param name="dbContext"></param>
        public SaleRepository(AppDbContext dbContext) => _dbContext = dbContext;

        /// <summary>
        ///  Gets Product Categories as queryable with no tracking of changes
        /// </summary>
        /// <returns></returns>
        private IQueryable<Sale> GetQueryable()
            => _dbContext.Sales.AsNoTrackingWithIdentityResolution();

        /// <summary>
        /// Attaches a new sale's record into repository
        /// </summary>
        /// <param name="sale"></param>
        public async Task AddAsync(Sale sale) => await _dbContext.Sales.AddAsync(sale);

        /// <summary>
        /// Select all records of sales 
        /// </summary>
        /// <returns>a list of sale records</returns>
        public async Task<IList<Sale>> FindAllAsync() => await GetQueryable()
            .Include(s=>s.Product)
            .ToListAsync();

        /// <summary>
        /// Select a record of sales by it's guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a record of sale</returns>
        public async Task<Sale> FindByIdAsync(Guid id) => await GetQueryable().FirstOrDefaultAsync(s => s.Id == id);
    }
}
