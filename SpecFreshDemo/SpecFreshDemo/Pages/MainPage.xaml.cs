using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFreshDemo.PageModels;
using Xamarin.Forms;

namespace SpecFreshDemo.Pages
{
	public partial class MainPage : ContentPage
	{
	   // public List<string> MenuItems { get; set; } = new List<string>();
        public MainPage()
		{
			InitializeComponent();

		    //MenuItems.Add("Settings");
		    //MenuItems.Add("Notifications");
		    //MenuItems.Add("Logout");
		    //MenuItems.Add("About");

		    //MenuList.ItemsSource = MenuItems;
		}

	    protected override void OnBindingContextChanged()
	    {
	        base.OnBindingContextChanged();

	        BindingContext = BindingContext as MainPageModel;
	    }
	}
}
