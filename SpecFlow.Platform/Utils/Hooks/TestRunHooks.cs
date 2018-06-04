using SpecFlow.Platform.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.Platform.Utils.Hooks
{
    [Binding]
    public class TestRunHooks
    {

        [AfterScenario]
        internal static void AFterTestRun()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Debug"))
                DriverController.Instance.StopWebDriver();
        } 
    }
}
