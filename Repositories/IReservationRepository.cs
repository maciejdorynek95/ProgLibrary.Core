using ProgLibrary.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLibrary.Core.Repositories
{
    public interface IReservationRepository
    {

        Task<Reservation> GetAsync(Guid reservationId);
        Task<Reservation> GetAsyncByBook(Guid bookId);
        [Obsolete]Task<Reservation> GetAsyncByUser(Guid bookId); // Obsolete
        Task<IEnumerable<Reservation>> GetAsyncListOfReservationsByBook(Guid bookId);
        Task<IEnumerable<Reservation>> BrowseAsync(string bookTitle = "");
        Task AddAsync(Reservation reservation);
        Task UpdateAsync(Reservation reservation);
        Task DeleteAsync(Reservation reservation);
    }
}
