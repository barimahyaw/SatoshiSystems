using System.ComponentModel.DataAnnotations;

namespace Satoshi.Shared.Common.CustomValidation
{
    public class PriceAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var isNumeric = decimal.TryParse(value.ToString(), out var val);
                if (!isNumeric || val <=0) return new ValidationResult("Price must be figures");
            }
            return ValidationResult.Success;
        }
    }
}
