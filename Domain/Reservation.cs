using ProgLibrary.Core.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProgLibrary.Core.Domain
{
    public class Reservation : Entity
    {
        private readonly LibraryDbContext _booksContext;
        private readonly AuthenticationDbContext _usersContext;
        public Reservation(LibraryDbContext booksContext, AuthenticationDbContext usersContext)
        {
            _booksContext = booksContext;
            _usersContext = usersContext;
        }

        public Guid UserId { get; protected set; }
        public Guid BookId { get; protected set; }

        public DateTime ReservationTimeFrom { get; protected set; }
        public DateTime ReservationTimeTo { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        //[ForeignKey("UserId")]
        public  User User { get; set; }

        //[ForeignKey("BookId")]
        public  Book Book { get; set; }


        public Reservation(Guid id, Guid userId, Guid bookId, DateTime reservationTimeFrom, DateTime reservationTimeTo )
        {
            Id = id;
            SetUserId(userId);
            SetBookId(bookId);
            SetReservationTimeFrom(reservationTimeFrom);
            SetReservationTimeTo(reservationTimeTo);
            CreatedAt = DateTime.UtcNow;
        }



        private  void SetUserId(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                throw new Exception("Błąd Guid dla userId");
            }
            UserId = userId;
        }




        private  void SetBookId(Guid bookId)
        {
            if (bookId == Guid.Empty)
            {
                throw new Exception("Błąd Guid dla bookId");
            }
            BookId = bookId;
        }

        private void SetReservationTimeFrom(DateTime reservationTimeFrom)
        {

            if (reservationTimeFrom == DateTime.MinValue || reservationTimeFrom == DateTime.MaxValue)
            {
                throw new Exception($"Błędnie wprowadzona data : {reservationTimeFrom}");
            }
            ReservationTimeFrom = reservationTimeFrom;

        }
        private void SetReservationTimeTo(DateTime reservationTimeTo)
        {
            if (reservationTimeTo == DateTime.MinValue || reservationTimeTo == DateTime.MaxValue)
            {
                throw new Exception($"Błędnie wprowadzona data : {reservationTimeTo}");
            }
            ReservationTimeTo = reservationTimeTo;

        }

    }
}