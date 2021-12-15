using Satoshi.Shared.Common.DTO.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Satoshi.Core.Interfaces
{
    public interface IGetSalesHighestLowestPrices
    {
        Task<List<SalesResponse>> Handle();
    }
}
