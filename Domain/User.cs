using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgLibrary.Core.Domain
{
    public class User : IdentityUser<Guid>
    {
        public Guid Id { get; protected set; }
        public string Role { get; protected set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }

        public DateTime CreatedAt { get; protected set; }
       
        protected User()
        {
            Id = Guid.NewGuid();
        }

    

        public User(Guid id, string role, string name, string email, string password)
        {
            Id = id;
            Role = role;
            Name = name;
            Email = email;
            Password = password;
            CreatedAt = DateTime.UtcNow;
                

        }

    }
}
