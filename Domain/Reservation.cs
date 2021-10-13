using System;

namespace ProgLibrary.Core.Domain
{
    public class Reservation : Entity
    {

        public Guid? User { get; protected set; }
        public Guid? Book { get; protected set; }
        public DateTime ReservationTimeFrom { get; set; }
        public DateTime ReservationTimeTo { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool Reserved => User.HasValue; // Sprwadzic

        protected Reservation()
        {

        }
        public Reservation(Guid id, Guid userId, Guid bookId)
        {
            Id = id;
            User = userId;
            Book = bookId;

        }
    }
}