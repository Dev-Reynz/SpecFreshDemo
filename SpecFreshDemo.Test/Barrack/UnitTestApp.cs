using SpecFreshDemo.Gateway;
using SpecFreshDemo.PageModels;
using Xamarin.Forms;

namespace SpecFreshDemo.Test.Barrack
{
    public class UnitTestApp : Application
    {
        public static Page CurrentPage { get; set; }
        public UnitTestApp()
        {
            RegisterServices();

            var page = FreshMvvm.FreshPageModelResolver.ResolvePageModel<BookListPageModel>();
            var navigationPage = new FreshMvvm.FreshNavigationContainer(page);
            MainPage = navigationPage;
        }

        private void RegisterServices()
        {
            FreshMvvm.FreshIOC.Container.Register<IBookGateway, BookGateway>();
            FreshMvvm.FreshIOC.Container.Register<IAuthorGateway, AuthorGateway>();
        }
    }
}
