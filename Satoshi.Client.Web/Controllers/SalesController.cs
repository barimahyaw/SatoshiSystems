using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Satoshi.Shared.Common.DTO.Request;
using Satoshi.Shared.Common.DTO.Response;
using Satoshi.Shared.Common.Enums;
using Satoshi.Shared.Common.Extentions;
using Satoshi.Shared.Common.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Satoshi.Client.Web.Controllers
{
    public class SalesController : Controller
    {
        private readonly IRestHelper _restHelper;
        public SalesController(IRestHelper restHelper) => _restHelper = restHelper;
        public async Task<IActionResult> Index()
        {
            var response = await _restHelper.ApiServiceAsync(BaseUrl.QueryService, "Sales", null, null, null, HttpVerb.Get);
            var result = JsonConvert.DeserializeObject<List<SalesResponse>>(response.ToString());
            return View(result);
        }

        public async Task<IActionResult> SaleOrder()
        {
            var response = await _restHelper.ApiServiceAsync(BaseUrl.QueryService, "Product", null, null, null, HttpVerb.Get);
            var result = JsonConvert.DeserializeObject<List<ProductResponse>>(response.ToString());
            var model = new SalesOrderRequest{ Products = result.GetProduct(System.Guid.Empty) };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SaleOrder(SalesOrderRequest request) 
        {
            var response = await _restHelper.ApiServiceAsync(BaseUrl.CommandService, "Sales", null, request, null, HttpVerb.Post);
            var result = JsonConvert.DeserializeObject<int>(response.ToString());
            return RedirectToAction("Index");
        }
    }
}
