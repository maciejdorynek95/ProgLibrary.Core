using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgLibrary.Core.Domain
{
    public class Reservation : Entity
    {


        public Guid UserId { get; protected set; }
        public Guid BookId { get; protected set; }
       
        public DateTime ReservationTimeFrom { get; set; }
        public DateTime ReservationTimeTo { get; set; }
        public DateTime ReservationDate { get; set; }
        //public bool? Active => ReservationTimeFrom <= ReservationTimeTo; // Sprwadzic


        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }


        public Reservation(Guid id, Guid userId, Guid bookId, DateTime reservationTimeFrom, DateTime reservationTimeTo)
        {
            Id = id;
            UserId = userId;
            BookId = bookId;
            ReservationTimeFrom = reservationTimeFrom;
            ReservationTimeTo = reservationTimeTo;
        }
       
    }
}