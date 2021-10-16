using System;

namespace ProgLibrary.Core.Domain
{
    public class Reservation : Entity
    {

        public Guid? UserId { get; protected set; }
        public Guid? BookId { get; protected set; }
        public DateTime ReservationTimeFrom { get; set; }
        public DateTime ReservationTimeTo { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool Active => ReservationTimeFrom <= ReservationTimeTo; // Sprwadzic

        protected Reservation()
        {

        }
        public Reservation(Guid id, Guid userId, Guid bookId)
        {
            Id = id;
            UserId = userId;
            BookId = bookId;

        }
    }
}