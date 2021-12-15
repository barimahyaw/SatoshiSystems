using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Satoshi.Shared.Common.CustomValidation;

namespace Satoshi.Shared.Common.DTO.Request
{
    public class SalesOrderRequest
    {
        [Required(ErrorMessage ="Customer's name is missing. Kindly provide!")]
        [Display(Name ="Customer's name")]
        public string CustomerName { get; set; }
        [Required()]
        public Guid Product { get; set; }
        [Price]
        public double Price { get; set; }

        public IEnumerable<SelectListItem> Products { get; set; }
    }
}
