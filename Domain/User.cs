using Microsoft.AspNetCore.Identity;
using ProgLibrary.Core.DAL;
using ProgLibrary.Core.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProgLibrary.Core.Domain
{
    public class User : IdentityUser<Guid>
    {

        private readonly AuthenticationDbContext _authContext;

        public User(AuthenticationDbContext authContext)
        {
            _authContext = authContext;
        }
        [NotMapped]
        public virtual string[] Roles { get; protected set; }
        public virtual IEnumerable<Reservation> Reservations { get; protected set; }
        public User(Guid id, string name, string email)
        {
            Id = id;          
            UserName = name;
            Email = email;         
        }
        public User(Guid id, string email, LibraryDbContext context)
        {
            Id = id;
            Email = email;
            GetReservations(context);
        }
        
        public void GetRoles(params string[] roles)
        {
            Roles = new string[roles.Length];
            for (int i = 0; i < Roles.Length; i++)
            {
                Roles[i] = roles[i];
            }
        }
        public void GetReservations(LibraryDbContext context)
        {
            Reservations = context.Reservations.Where(x => x.UserId == Id).AsQueryable();
        }


    }
}
