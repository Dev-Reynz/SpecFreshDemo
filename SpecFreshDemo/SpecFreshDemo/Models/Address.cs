using PropertyChanged;

namespace SpecFreshDemo.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Address
    {
        public string ID { get; set; }
        public AddressType Type { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
    }
}
