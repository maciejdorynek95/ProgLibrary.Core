using ProgLibrary.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProgLibrary.Core.Repositories
{
    public interface IReservationRepository
    {

        Task<Reservation> GetAsync(Guid reservationId);
        Task<Reservation> GetAsyncByBook(Guid bookId);
        [Obsolete]Task<Reservation> GetAsyncByUser(Guid bookId); // Obsolete
        Task<IEnumerable<Reservation>> GetAsyncListOfReservationsByBook(Guid bookId);
        Task<IEnumerable<Reservation>> BrowseAsync(string filter = "");
        Task<bool> AddAsync(Reservation reservation);
        Task<bool> UpdateAsync(Reservation reservation);
        Task<bool> DeleteAsync(Reservation reservation);
    }
}
