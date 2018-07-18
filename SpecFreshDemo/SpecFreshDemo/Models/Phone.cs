using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFreshDemo.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Phone
    {
        public string Number { get; set; }
        public ContactType Type { get; set; }
    }
}
