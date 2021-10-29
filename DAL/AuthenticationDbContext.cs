using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProgLibrary.Core.Domain;
using System;

namespace ProgLibrary.Core.DAL
{
    public class AuthenticationDbContext : IdentityDbContext<User, Role,Guid,IdentityUserClaim<Guid>,IdentityUserRole<Guid>,IdentityUserLogin<Guid>,IdentityRoleClaim<Guid>,IdentityUserToken<Guid>>
    {

  

        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options)
        {
          
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
