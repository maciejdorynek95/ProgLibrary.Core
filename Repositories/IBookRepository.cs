using ProgLibrary.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProgLibrary.Core.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetAsync(Guid id);
        Task<Book> GetAsync(string name);
        Task<IEnumerable<Book>> BrowseAsync(string title = "");
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Book book);
    }
}
