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
       
    }
}
