using Microsoft.AspNetCore.Identity;
using ProgLibrary.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProgLibrary.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task<IEnumerable<User>> BrowseAsync(string role);
        Task<IEnumerable<Reservation>> GetUserReservations(Guid userId);
        Task<IdentityResult>AddAsync(User user,string password, string role);
        Task<IdentityResult> UpdateAsync(User user);
        Task<IdentityResult> DeleteAsync(User user);
    }
}
