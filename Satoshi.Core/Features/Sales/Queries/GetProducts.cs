using Satoshi.Core.Interfaces;
using Satoshi.Shared.Common.DTO.Response;
using Sotashi.Core.Infastructure.Contract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Satoshi.Core.Features.Sales.Queries
{
    public class GetProducts : IGetProducts
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProducts(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public async Task<List<ProductResponse>> Handle()
        {
            var response = new List<ProductResponse>();
            var products = await _unitOfWork.ProductReader.FindAllAsync();
            if (products.Any())
            {
                foreach(var entity in products)
                {
                    var product = new ProductResponse
                    {
                        Id = entity.Id,
                        Product = entity.Name
                    };
                    response.Add(product);
                }
            }

            return response;
        }
    }
}
