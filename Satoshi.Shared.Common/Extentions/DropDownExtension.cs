using Satoshi.Shared.Common.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Satoshi.Shared.Common.Extentions
{
    public static class DropDownExtension
    {
        /// <summary>
        /// Dropdown extension method for product which has productId as value 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="selected"></param>
        /// <returns></returns>
        public static IEnumerable<SelectListItem> GetProduct(
            this IEnumerable<ProductResponse> product, Guid selected)
        {
            var items = product.OrderBy(p => p.Id)
                .Select(p => new SelectListItem
                {
                    Selected = p.Id == selected,
                    Text = p.Product,
                    Value = p.Id.ToString()
                })
                .ToList();

            items.Insert(0, new SelectListItem { Text = "-- Select Product --", Value = "", Selected = true });

            return items;
        }
    }
}
