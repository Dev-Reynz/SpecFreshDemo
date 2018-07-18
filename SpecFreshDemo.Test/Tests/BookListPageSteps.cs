using SpecFreshDemo.Test.Barrack;
using TechTalk.SpecFlow;

namespace SpecFreshDemo.Test.Tests
{
    [Binding]
    public class BookListPageSteps : StepBase
    {
        public BookListPageSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [Given(@"the app started without error")]
        public void GivenTheAppStartedWithoutError()
        {
            
        }

    }
}
