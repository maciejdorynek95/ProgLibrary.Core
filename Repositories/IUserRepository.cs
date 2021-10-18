using Microsoft.AspNetCore.Identity;
using ProgLibrary.Core.Domain;
using System;
using System.Threading.Tasks;

namespace ProgLibrary.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
    }
}
