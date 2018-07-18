using TechTalk.SpecFlow;

namespace SpecFreshDemo.Test.Barrack
{
    [Binding]
    public class Main
    {
        public static UnitTestApp App { get; private set; }

        [BeforeScenario]
        public void BeforeScenario()
        {
            App = new UnitTestApp();
        }
    }
}
