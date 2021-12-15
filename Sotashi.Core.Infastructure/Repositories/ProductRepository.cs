using Microsoft.EntityFrameworkCore;
using Sotashi.Core.Infastructure.DbContexts;
using Sotashi.Core.Infastructure.Entities;
using Sotashi.Core.Infastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sotashi.Core.Infastructure.Repositories
{
    public class ProductRepository : IProductReader
    {
        private readonly AppDbContext _dbContext;
        /// <summary>
        /// Constructor for DI
        /// </summary>
        /// <param name="dbContext"></param>
        public ProductRepository(AppDbContext dbContext) => _dbContext = dbContext;

        /// <summary>
        ///  Gets Product Categories as queryable with no tracking of changes
        /// </summary>
        /// <returns></returns>
        private IQueryable<Product> GetQueryable()
            => _dbContext.Products.AsNoTrackingWithIdentityResolution();

        /// <summary>
        /// Select all records of product 
        /// </summary>
        /// <returns>a list of sale records</returns>
        public async Task<List<Product>> FindAllAsync() => await GetQueryable().ToListAsync();
    }
}
