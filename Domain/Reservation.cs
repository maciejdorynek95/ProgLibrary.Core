using Microsoft.AspNetCore.Mvc;
using ProgLibrary.Core.Repositories;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ProgLibrary.Core.Domain
{
    public class Reservation : Entity
    {

        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private  IReservationRepository _reservationRepository;

        public Reservation(IUserRepository userRepository, IBookRepository bookRepository, IReservationRepository reservationRepository)
        {
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            _reservationRepository = reservationRepository;
        }


        public Guid UserId { get; protected set; }
        public Guid BookId { get; protected set; }

        public DateTime ReservationTimeFrom { get; protected set; }
        public DateTime ReservationTimeTo { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        [ForeignKey("UserId")]
        public virtual User User { get;  set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get;  set; }


        public Reservation(Guid id, Guid userId, Guid bookId, DateTime reservationTimeFrom, DateTime reservationTimeTo, DateTime createdAt)
        {

            SetUserId(userId);
            SetBookId(bookId);
            SetReservationTimeFrom(reservationTimeFrom);
            SetReservationTimeTo(reservationTimeTo);
            SetCreatedAt(createdAt);
        }



        private  void SetUserId(Guid userId)
        => UserId = (_reservationRepository.GetAsyncReservation(userId)).Result.UserId; ///kurwa brak czasu...

        private  void SetBookId(Guid bookId)
       => BookId = _reservationRepository.GetAsyncReservation(bookId).Result.BookId;

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

        private void SetCreatedAt(DateTime createdAt)
        {
            if (createdAt == DateTime.MinValue || createdAt == DateTime.MaxValue)
            {
                throw new Exception($"Błędnie wprowadzona data : {createdAt}");
            }
            CreatedAt = DateTime.UtcNow;



        }
    }
}