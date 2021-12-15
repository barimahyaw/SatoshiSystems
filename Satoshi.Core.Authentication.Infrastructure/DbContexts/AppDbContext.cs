using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sotashi.Core.Authentication.Infrastructure.Entities;

namespace Sotashi.Core.Authentication.Infrastructure.DbContexts
{
    public class AppDbContext : IdentityDbContext<IdentityAuthenticationUser>
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
