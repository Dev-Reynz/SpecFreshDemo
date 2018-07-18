using PropertyChanged;
using System.Collections.Generic;

namespace SpecFreshDemo.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public List<string> AuthorIDs { get; set; }
    }
}
