using Satoshi.Shared.Common.DTO.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Satoshi.Core.Interfaces
{
    public interface IGetProducts
    {
        Task<List<ProductResponse>> Handle();
    }
}
