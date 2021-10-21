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

        Task<List<Reservation>> GetAsyncReservations(Guid userId);
        Task<Reservation> GetAsyncReservation(Guid bookId);
        Task<Reservation> GetAsyncReservationByUser(Guid userId);
        Task<IEnumerable<Reservation>> BrowseAsync(string bookTitle = "");
        Task AddAsync(Reservation reservation);
        Task UpdateAsync(Reservation reservation);
        Task DeleteAsync(Reservation reservation);
    }
}
