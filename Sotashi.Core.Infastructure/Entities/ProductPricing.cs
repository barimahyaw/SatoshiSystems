using Sotashi.Core.Infastructure.Contract;
using System;

namespace Sotashi.Core.Infastructure.Entities
{
    public class ProductPricing : AuditableEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
    }
}
