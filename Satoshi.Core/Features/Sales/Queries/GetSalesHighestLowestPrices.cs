using Satoshi.Core.Interfaces;
using Satoshi.Shared.Common.DTO.Response;
using Sotashi.Core.Infastructure.Contract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Satoshi.Core.Features.Sales.Queries
{
    public class GetSalesHighestLowestPrices : IGetSalesHighestLowestPrices
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetSalesHighestLowestPrices(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public async Task<List<SalesResponse>> Handle()
        {
            var response = new List<SalesResponse>();
            var products = await _unitOfWork.ProductReader.FindAllAsync();
            if(products.Any())
            {
                var sales = await _unitOfWork.SalesReader.FindAllAsync();
                if (!sales.Any()) return response;
                foreach (var product in products)
                {
                    var result = sales.Where(p => p.Product.Name == product.Name);
                    response.Add(new SalesResponse
                    {
                        Product = product.Name,
                        HighestPrice = result.Max(r => r.Price),
                        LowestPrice = result.Min(r => r.Price)
                    });
                }
            }
            return response;
        }
    }
}
