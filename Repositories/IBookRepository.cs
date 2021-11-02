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
        Task<int> AddAsync(Book book);
        Task<int> UpdateAsync(Book book);
        Task<int> DeleteAsync(Book book);
    }
}
