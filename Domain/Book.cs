using System;
using System.Collections.Generic;

namespace ProgLibrary.Core.Domain
{
    public class Book : Entity
    {
        private ISet<Reservation> _reservations = new HashSet<Reservation>(); // aby kolekcja IEnumerable była tylko dla odczytu

        //public Guid Id { get; protected set; } // Niepotrzebne?
        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }
        public string Description { get; set; }

        public IEnumerable<Reservation> Reservations => _reservations;

        protected Book()
        {

        }

        public Book(Guid id, string title, string author, DateTime releaseDate, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
            Description = description;

        }

        public void AddReservations(Guid id, User user,Book book)
        {
            
         _reservations.Add(new Reservation(id, user.Id, book.Id)); // EntityFramework ?
            
        }
    }
}
