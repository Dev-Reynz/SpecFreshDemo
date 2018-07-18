using SpecFreshDemo.Models;
using System.Collections.Generic;

namespace SpecFreshDemo.Gateway
{
    public interface IBookGateway
    {
        IEnumerable<Book> GetBooks();
        Book GetBookByTitle(string title);
    }
}
