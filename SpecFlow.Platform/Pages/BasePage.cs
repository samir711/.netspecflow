using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlow.Platform.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow.Platform.Pages
{
    public class BasePage : Page
    {

        public IWebDriver Driver { get; internal set; }
        public string GetTitle() { return Driver.Title; }
        public string GetUrl() { return Driver.Title; }
        public string GetText() { return Driver.PageSource; }

        internal void ValidateMultipleTextInPageSource(Table table)
        {
            foreach (var row in table.Rows)
            {
                var textToValidate = row["expectedText"];
                Assert.IsTrue(Driver.PageSource.Contains(textToValidate), "This is not the expected text!");
                Console.WriteLine(":: The text {0} is in the PageSource " , textToValidate);

            }
        }

        internal void ValidateTextInPageSource(string expectedText)
        {
            var textToValidate = Driver.PageSource.Contains(expectedText);
            Assert.IsTrue(textToValidate, ":: This is not the expected title");
            Console.WriteLine(":: The text {0} in the PageSource is  " , expectedText);
        }


        public void ValidatePageUrl(string expectedUrl)
        {
            var urlToValidate = Driver.Url.Contains(expectedUrl);
            Assert.IsTrue(urlToValidate, ":: This is not the expected title");
            Console.WriteLine("::  The  Url of the site is " + GetUrl());
        }

       
        public void ValidatePageTitle(string expectedTitle)
        {
            var titleToValidate = Driver.Title.Contains(expectedTitle);
            Assert.IsTrue(titleToValidate, ":: This is not the expected title");
            Console.WriteLine(":: the title of the site is " + GetTitle());
        }

        public void NavigateMainEnterPoint()
        {

            var baseUrl = Settings.BaseUrl;
            SpecFlow.Platform.Utils.Selenium.Driver.Browser().Navigate().GoToUrl(baseUrl);
            SpecFlow.Platform.Utils.Selenium.Driver.Browser().Manage().Window.Maximize();
            Console.WriteLine(Settings.WelcomeMessage);
        }




     
    }
}
