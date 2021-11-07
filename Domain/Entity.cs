using System;
using System.ComponentModel.DataAnnotations;

namespace ProgLibrary.Core.Domain
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; protected set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}