using Microsoft.AspNetCore.Mvc;
using Satoshi.Core.Features.Sales.Commands;
using Satoshi.Shared.Common.DTO.Request;
using System.Threading.Tasks;

namespace Satoshi.Services.Command.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly IAddEdit _addEdit;
        public SalesController(IAddEdit addEdit) => _addEdit = addEdit;

        // POST api/<SalesController>
        [HttpPost]
        public async Task<IActionResult> Post(SalesOrderRequest request)
        {
           await _addEdit.Handle(request);
           return Ok(request);
        }
    }
}
