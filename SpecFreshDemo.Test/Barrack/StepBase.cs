using TechTalk.SpecFlow;

namespace SpecFreshDemo.Test.Barrack
{
    public class StepBase
    {
        protected readonly ScenarioContext _scenarioContext;
        public UnitTestApp App => Main.App;

        public StepBase(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
        }
    }
}
