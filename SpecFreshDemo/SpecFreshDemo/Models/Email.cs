using PropertyChanged;

namespace SpecFreshDemo.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Email
    {
        public string Address { get; set; }
        public string Domain { get; set; }
        public EmailType Type { get; set; }
    }
}
