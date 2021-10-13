using ProgLibrary.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLibrary.Core.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetAsync(Guid id);
        Task<Book> GetAsync(string name);
        Task<IEnumerable<Book>> BrowseAsync(string name = "");
        Task AddASync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Book book);
    }
}
