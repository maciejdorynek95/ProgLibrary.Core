﻿using Microsoft.AspNetCore.Identity;
using ProgLibrary.Core.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProgLibrary.Core.Domain
{
    public class User : IdentityUser<Guid>
    {
        private readonly LibraryDbContext _context;
        public User(LibraryDbContext context)
        {
            _context = context;
        }
        [NotMapped]
        public virtual string[] Roles { get; protected set; } 
        public virtual IEnumerable<Reservation> Reservations => _context?.Reservations?.AsEnumerable();

         
        public User()
        {
            Id = Guid.NewGuid();
        }
        public User(Guid id, string name, string email)
        {
            Id = id;          
            UserName = name;
            Email = email;
           
        }
        public void GetRoles(params string[] roles)
        {
            Roles = new string[roles.Length];
            for (int i = 0; i < Roles.Length; i++)
            {
                Roles[i] = roles[i];
            }
        }

    }
}
