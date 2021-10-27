using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ProgLibrary.Core.DAL;
using ProgLibrary.Core.Repositories;

namespace ProgLibrary.Core.Domain
{
    public class Book : Entity
    {
      
        private readonly LibraryDbContext _context;
        public Book(LibraryDbContext context)
        {
            _context = context;
        }

        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }
        public string Description { get; protected set; }
        public DateTime UpdatedAt { get; set; }
        [NotMapped]
        public  IEnumerable<Reservation> Reservations => _context?.Reservations?.AsEnumerable();
        //[NotMapped]
        //public IEnumerable<Reservation> UsingReservations => _context?.Reservations?.Where(b => b.Active);
        //[NotMapped]
        //public IEnumerable<Reservation>? AvailibleReservations => _context.Reservations.Except(UsingReservations); // wykluaczając aktywne


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

        public void SetReleasedDate(DateTime releasedDate)
        {
            if (releasedDate > DateTime.UtcNow)
            {
                throw new Exception($"Książka z id '{Id}' nie może mieć przyszłej daty");
            }

            ReleaseDate = releasedDate;
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

      


        public Book(Guid id, string title, string author, DateTime releaseDate, string description)
        {
            Id = id;
            SetTitle(title);
            SetAuthor(author);
            SetDescription(description);
            SetReleasedDate(releaseDate);
            

        }

    }
}
