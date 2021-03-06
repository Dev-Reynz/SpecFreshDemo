﻿using SpecFreshDemo.Gateway;
using SpecFreshDemo.PageModels;

using Xamarin.Forms;

namespace SpecFreshDemo
{
    public partial class App : Application
	{
		public App ()
		{
            RegisterServices();
			InitializeComponent();
            
            var page = FreshMvvm.FreshPageModelResolver.ResolvePageModel<BookListPageModel>();
            var navigationPage = new FreshMvvm.FreshNavigationContainer(page);
            MainPage = navigationPage;
		}

        private void RegisterServices()
        {
            FreshMvvm.FreshIOC.Container.Register<IBookGateway, BookGateway>();
            FreshMvvm.FreshIOC.Container.Register<IAuthorGateway, AuthorGateway>();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
