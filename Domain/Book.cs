using ProgLibrary.Core.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

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


        public void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception($"Książka z id '{Id}' nie może miec pustego tytułu");
            }
            Title = title;

        }

        public void SetAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
            {
                throw new Exception($"Książka z id '{Id}' nie może miec pustego autora");
            }
            Author = author;

        }

        public void SetReleasedDate(DateTime releasedDate)
        {
            if (releasedDate > DateTime.UtcNow)
            {
                throw new Exception($"Książka z id '{Id}' nie może mieć przyszłej daty");
            }

            ReleaseDate = releasedDate;

        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new Exception($"Książka z id '{Id}' nie może miec pustego opisu");
            }
            Description = description;

        }




        public Book(Guid id, string title, string author, DateTime releaseDate, string description)
        {
            Id = id;
            SetTitle(title);
            SetAuthor(author);
            SetDescription(description);
            SetReleasedDate(releaseDate);
            UpdatedAt = DateTime.UtcNow;

        }

    }
}
