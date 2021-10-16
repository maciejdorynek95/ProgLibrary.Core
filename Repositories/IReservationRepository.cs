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
        Task<Reservation> GetAsync(Guid id);
        Task<Reservation> GetASync(User email);
        Task<IEnumerable<Reservation>> BrowseAsync(Book book);
        Task AddAsync(Reservation reservation);
        Task UpdateAsync(Reservation reservation);
        Task DeleteAsync(Reservation reservation);
    }
}
