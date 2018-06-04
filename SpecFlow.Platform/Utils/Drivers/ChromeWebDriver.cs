using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Platform.Utils.Drivers
{
    public static class ChromeWebDriver
    {
        internal static IWebDriver LoadChromeDriver()
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            options.AddArgument("--disable-extension");
            return new ChromeDriver(driverService, options);
        }
    }
}
