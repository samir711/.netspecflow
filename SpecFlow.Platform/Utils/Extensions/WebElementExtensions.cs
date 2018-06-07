using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SpecFlow.Platform.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Platform.Utils.Extensions
{
    public static class WebElementExtensions
    {

        public static void WeHighlightElement(this IWebElement element)
        {
            var js = (IJavaScriptExecutor)Driver.Browser();
            js.ExecuteScript("arguments[0].style.border = '4px solid blue'", element);
        }

        public static bool WebElementIsDisplayed(this IWebElement element, int sec = 10)
        {
            element.WeHighlightElement();
            var wait = new WebDriverWait(Driver.Browser(), TimeSpan.FromSeconds(sec));
            return wait.Until(d =>
            {
                try
                {
                    return element.Displayed;

                }
                catch (ElementNotVisibleException)
                {

                    return false;
                }
            }
            );
        }
    }
}
