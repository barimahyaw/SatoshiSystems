using Microsoft.AspNetCore.Identity;
using Sotashi.Core.Authentication.Infrastructure.Contract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sotashi.Core.Authentication.Infrastructure.Entities
{
    public class IdentityAuthenticationUser : IdentityUser, IAuditableEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(50)]
        public string OtherNames { get; set; }
        public int Gender { get; set; }
        public bool IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
