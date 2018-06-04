﻿using SpecFlow.Platform.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.Platform.Utils.Hooks
{
    [Binding]
    public static class ScenarioHooks
    {

        [BeforeScenario]
        internal static void StartWebDriver()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("PhantomJs"))
            {
                DriverController.Instance.StartPhatomJs();
            }
            else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Chrome"))
            {
                DriverController.Instance.StartChrome();
            }
            else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Debug"))
            {
                DriverController.Instance.StartChrome();
            }

            else 
            {
                DriverController.Instance.StartChrome();
            }


        }

        [AfterScenario]
        internal static void StopWebDriver()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Debug"))
                DriverController.Instance.StopWebDriver();
        }    

    }
}
