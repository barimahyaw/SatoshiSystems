﻿using Satoshi.Shared.Common.Enums;
using System.Threading.Tasks;

namespace Satoshi.Shared.Common.Helpers
{
    public interface IRestHelper
    {
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
        Task<object> ApiServiceAsync(BaseUrl baseUrl, string url, string token, object requestBodyObject,
            string param, HttpVerb method);
    }
}
