using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecFreshDemo.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookListPage : ContentPage
	{
		public BookListPage ()
		{
			InitializeComponent ();
		}
	}
}