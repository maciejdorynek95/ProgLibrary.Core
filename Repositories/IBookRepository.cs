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
        Task<bool> AddAsync(Book book);
        Task<bool> UpdateAsync(Book book);
        Task<bool> DeleteAsync(Book book);
    }
}
