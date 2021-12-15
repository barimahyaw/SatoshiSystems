using System.ComponentModel.DataAnnotations;

namespace Satoshi.Shared.Common.DTO.Response
{
    public class SalesResponse
    {
        public string Product { get; set; }
        [Display(Name = "Highest Price")]
        public double HighestPrice { get; set; }
        [Display(Name = "Lowest Price")]
        public double LowestPrice { get; set; }
    }
}
