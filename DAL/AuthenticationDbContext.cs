
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProgLibrary.Core.Domain;
using System;

namespace ProgLibrary.Core.DAL
{
    public class AuthenticationDbContext : IdentityDbContext<User,IdentityRole<Guid>,Guid>
    {

  

        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options)
        {
          
        }
       
    }
}
