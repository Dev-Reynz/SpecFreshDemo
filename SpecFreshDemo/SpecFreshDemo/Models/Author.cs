using PropertyChanged;
using System.Collections.Generic;

namespace SpecFreshDemo.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Author
    {
        public string ID { get; set; }
        public Name Name { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Email> EmailAddresses { get; set; }
        public List<Phone> PhoneNumbers { get; set; }
    }
}
