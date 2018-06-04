using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Platform.Pages
{
    public class BasePage : Page
    {

        public IWebDriver Driver { get; internal set; }

    }
}
