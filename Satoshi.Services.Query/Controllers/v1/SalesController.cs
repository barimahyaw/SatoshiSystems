using Microsoft.AspNetCore.Mvc;
using Satoshi.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Satoshi.Services.Query.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly IGetSalesHighestLowestPrices _sales;

        public SalesController(IGetSalesHighestLowestPrices sales) => _sales = sales;

        // GET: api/<SalesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _sales.Handle();
            return Ok(result);
        }
    }
}
