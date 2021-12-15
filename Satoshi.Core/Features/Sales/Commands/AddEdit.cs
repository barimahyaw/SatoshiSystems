using Satoshi.Shared.Common.DTO.Request;
using Sotashi.Core.Infastructure.Contract;
using Sotashi.Core.Infastructure.Entities;
using System;
using System.Threading.Tasks;

namespace Satoshi.Core.Features.Sales.Commands
{
    public class AddEdit : IAddEdit
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddEdit(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        public async Task<int> Handle(SalesOrderRequest request)
        {
            var customerGuid = Guid.NewGuid();
            var customer = new Customer
            {
                Id = customerGuid,
                Name = request.CustomerName
            };
            await _unitOfWork.CustomerWriter.AddAsync(customer);

            var saleRequest = new Sale
            {
                Id = Guid.NewGuid(),
                Price = request.Price,
                ProductId = request.Product,
                CustomerId = customerGuid
            };
            await _unitOfWork.SalesWriter.AddAsync(saleRequest);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
