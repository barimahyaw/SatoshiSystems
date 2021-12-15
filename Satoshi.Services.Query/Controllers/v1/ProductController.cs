using Microsoft.AspNetCore.Mvc;
using Satoshi.Core.Interfaces;
using System.Threading.Tasks;

namespace Satoshi.Services.Query.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGetProducts _gePproducts;

        public ProductController(IGetProducts gePproducts) => _gePproducts = gePproducts;
        // GET: api/<SalesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _gePproducts.Handle();
            return Ok(result);
        }
    }
}
