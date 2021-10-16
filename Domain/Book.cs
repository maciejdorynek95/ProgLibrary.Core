using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ProgLibrary.Core.Repositories;

namespace ProgLibrary.Core.Domain
{
    public class Book : Entity
    {
        private ISet<Reservation> _reservations = new HashSet<Reservation>(); // aby kolekcja IEnumerable była tylko dla odczytu
        

        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }
        public string Description { get; set; }
        public DateTime UpdatedAt { get; set; }

        public IEnumerable<Reservation> Reservations => _reservations; // dodać available books
        [NotMapped]
        public IEnumerable<Reservation> UsingReservations => _reservations.Where(b=>b.Active);
        [NotMapped]
        public IEnumerable<Reservation> AvailibleReservations => _reservations.Except(UsingReservations); // wykluaczając aktywne
        protected Book()
        {

        }

        public void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception($"Książka z id '{Id}' nie może miec pustego tytułu");
            }
            Title = title;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
            {
                throw new Exception($"Książka z id '{Id}' nie może miec pustego autora");
            }
            Author = author;
            UpdatedAt = DateTime.UtcNow;
        }


        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new Exception($"Książka z id '{Id}' nie może miec pustego opisu");
            }
            Description = description;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetReleasedDate(DateTime releasedDate)
        { 
            if (releasedDate > DateTime.UtcNow  )
            {
                throw new Exception($"Książka z id '{Id}' nie może mieć przyszłej daty");
            }

            ReleaseDate = releasedDate;
            UpdatedAt = DateTime.UtcNow;
        }


        public Book(Guid id, string title, string author, DateTime releaseDate, string description)
        {
            Id = id;
            SetTitle(title);
            SetAuthor(author);
            SetDescription(description);
            SetReleasedDate(releaseDate);
            

        }

        //public async void AddReservation(Guid id,Guid userId,Guid bookId)
        //{
        //    var reservation = new Reservation(id, userId, bookId);
        //    _reservations.Add(reservation);
        //}
    }
}
