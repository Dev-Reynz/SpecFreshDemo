using SpecFreshDemo.Models;
using System.Collections.Generic;

namespace SpecFreshDemo.FakeData
{
    public static class FakeBooks
    {
        public static IEnumerable<Book> Books { get; set; }

        static FakeBooks() => Init();

        private static void Init()
        {
            Books = new List<Book>
            {
                new Book { Title = "C# Programming", AuthorIDs = new List<string>{ "AU001" }, ID = "00001", ISBN = "942090215-X-O" },
                new Book { Title = "Native Mobile Development using Xamarin" },
                new Book { Title = "Cross-Platform Mobile Development with Xamarin.Forms" },
                new Book { Title = "Restful Services in Xamarin.Forms" },
                new Book { Title = "Design Patterns in C#" },
                new Book { Title = "Introduction to Microsoft Azure" }
            };
        }
    }
}
