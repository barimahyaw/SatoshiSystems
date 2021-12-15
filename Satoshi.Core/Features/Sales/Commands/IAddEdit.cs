using Satoshi.Shared.Common.DTO.Request;
using System.Threading.Tasks;

namespace Satoshi.Core.Features.Sales.Commands
{
    public interface IAddEdit
    {
        Task<int> Handle(SalesOrderRequest request);
    }
}
