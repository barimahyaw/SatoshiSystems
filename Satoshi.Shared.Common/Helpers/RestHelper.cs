using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Satoshi.Shared.Common.Enums;
using Satoshi.Shared.Common.Settings;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Satoshi.Shared.Common.Helpers
{
    public class RestHelper : IRestHelper
    {
        private readonly ApiBaseUrlSettings _apiBaseUrlSettings;

        public RestHelper(IOptions<ApiBaseUrlSettings> apiBaseUrlSettings) => _apiBaseUrlSettings = apiBaseUrlSettings.Value;

        /// <summary>
        /// Generic wrapper class to make Rest API Calls
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <param name="requestBodyObject"></param>
        /// <param name="param"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public async Task<object> ApiServiceAsync(BaseUrl baseUrl, string url, string token, object requestBodyObject,
            string param, HttpVerb method)
        {
            var apiUrl = baseUrl switch
            {
                BaseUrl.AuthenticationService => _apiBaseUrlSettings.AuthenticationService,
                BaseUrl.QueryService => _apiBaseUrlSettings.QueryService,
                BaseUrl.CommandService => _apiBaseUrlSettings.CommandService,
                _ => _apiBaseUrlSettings.QueryService
            };

            if (string.IsNullOrWhiteSpace(apiUrl)) apiUrl = _apiBaseUrlSettings.QueryService;

            apiUrl += url;

            return await BlazorClientHandler(apiUrl, token, requestBodyObject, param, method);
        }

        /// <summary>
        /// A generic wrapper class for blazor client project REST API calls 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="authToken"></param>
        /// <param name="requestBodyObject"></param>
        /// <param name="param"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private static async Task<object> BlazorClientHandler(string url, string authToken, object requestBodyObject,
            string param, HttpVerb method)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(param)) url += param;

                var client = new HttpClient();

                if (!string.IsNullOrWhiteSpace(authToken))
                    client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(authToken);

                var content = new StringContent(string.Empty);

                if (requestBodyObject != null)
                {
                    var request = JsonConvert.SerializeObject(requestBodyObject);
                    content = new StringContent(request, Encoding.UTF8, "application/json");
                }

                object response;
                switch (method)
                {
                    case HttpVerb.Get:
                        response = await client.GetAsync(url);
                        break;
                    case HttpVerb.Post:
                        response = await client.PostAsync(url, content);
                        break;
                    case HttpVerb.Put:
                        response = await client.PutAsync(url, content);
                        break;
                    case HttpVerb.Delete:
                        response = await client.DeleteAsync(url);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(method), method, null);
                }

                //if (method == Verb.Get) return response;

                var httpResponse = (HttpResponseMessage)response;
                response = await httpResponse.Content.ReadAsStringAsync();

                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
