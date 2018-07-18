using SpecFreshDemo.Gateway;
using SpecFreshDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpecFreshDemo.PageModels
{
    public class BookListPageModel : BasePageModel
    {
        private readonly IBookGateway _bookGateway;
        public List<Book> Books { get; set; } = new List<Book>();
        public BookListPageModel(IBookGateway bookGateway)
        {
            _bookGateway = bookGateway;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            Books = _bookGateway.GetBooks().ToList();
        }
    }
    
}
