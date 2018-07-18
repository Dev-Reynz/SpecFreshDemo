using SpecFreshDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpecFreshDemo.Gateway
{
    public class AuthorGateway : IAuthorGateway
    {
        public IEnumerable<Author> GetAllAuthors()
        {
            return FakeData.FakeAuthors.Authors;  
        }

        public Author GetAuthorByEmailAddress(string emailAddress)
        {
            return FakeData.FakeAuthors.Authors.FirstOrDefault(a => a.EmailAddresses.Any(e => e.Address == emailAddress));
        }

        public Author GetAuthorByID(string id)
        {
            return FakeData.FakeAuthors.Authors.FirstOrDefault(a => a.ID == id);
        }

        public Author GetAuthorByName(string first, string last)
        {
            return FakeData.FakeAuthors.Authors.FirstOrDefault(a => a.Name.First == first && a.Name.Last == last);
        }

        public Author GetAuthorByPhoneNumber(string phoneNumber)
        {
            return FakeData.FakeAuthors.Authors.FirstOrDefault(a => a.PhoneNumbers.Any(p => p.Number == phoneNumber));
        }
    }
}
