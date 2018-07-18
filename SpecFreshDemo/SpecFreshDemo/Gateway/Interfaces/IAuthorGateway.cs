using SpecFreshDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFreshDemo.Gateway
{
    public interface IAuthorGateway
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetAuthorByID(string id);
        Author GetAuthorByName(string first, string last);
        Author GetAuthorByPhoneNumber(string phoneNumber);
        Author GetAuthorByEmailAddress(string emailAddress);
    }
}
