using SpecFreshDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpecFreshDemo.Gateway
{
    public class BookGateway : IBookGateway
    {
        public Book GetBookByTitle(string title)
        {
            return FakeData.FakeBooks.Books.FirstOrDefault(b => b.Title == title);
        }

        public IEnumerable<Book> GetBooks()
        {
            return FakeData.FakeBooks.Books;
        }
    }
}
