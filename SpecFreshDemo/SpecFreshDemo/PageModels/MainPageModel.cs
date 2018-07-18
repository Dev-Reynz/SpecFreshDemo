using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using FreshMvvm;
using PropertyChanged;

namespace SpecFreshDemo.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageModel : BasePageModel
    {
        public List<string> MenuItems { get; set; } = new List<string>();
        public MainPageModel()
        {
           
        }

        public override void Init(object initData)
        {
            MenuItems.Add("Settings");
            MenuItems.Add("Notifications");
            MenuItems.Add("Logout");
            MenuItems.Add("About");
        }
    }
}
