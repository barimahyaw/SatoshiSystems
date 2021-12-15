using Sotashi.Core.Infastructure.Contract;
using System.ComponentModel.DataAnnotations;

namespace Sotashi.Core.Infastructure.Entities
{
    public class Product : AuditableEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
