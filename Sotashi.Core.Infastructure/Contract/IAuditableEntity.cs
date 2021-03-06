using System;

namespace Sotashi.Core.Infastructure.Contract
{
    public interface IAuditableEntity
    {
        Guid CreatedBy { get; set; }

        DateTime CreatedOn { get; set; }

        Guid LastModifiedBy { get; set; }

        DateTime? LastModifiedOn { get; set; }
    }
}
