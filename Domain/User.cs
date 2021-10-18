using Microsoft.AspNetCore.Identity;
using System;

namespace ProgLibrary.Core.Domain
{
    public class User : IdentityUser<Guid>
    {
        protected User()
        {
            Id = Guid.NewGuid();
        }
        public User(Guid id, string name, string email)
        {
            Id = id;          
            UserName = name;
            Email = email;

        }

    }
}
