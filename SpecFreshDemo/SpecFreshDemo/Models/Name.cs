using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFreshDemo.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Name 
    {
        public string First { get; set; }
        public string FullMiddle { get; set; }
        public string MiddleInitial { get; set; }
        public string Last { get; set; }
    }
}
