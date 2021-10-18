using Microsoft.AspNetCore.Identity;
using System;

namespace ProgLibrary.Core.Domain
{
    public class Role : IdentityRole<Guid>
    {


        protected Role()
        {
            Id = Guid.NewGuid();

        }


        public Role(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }

}
