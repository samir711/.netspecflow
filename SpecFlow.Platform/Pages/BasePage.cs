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
using SpecFlow.Platform.Utils.Extensions;


namespace SpecFlow.Platform.Pages
{
    public class BasePage : Page
    {

        public IWebDriver Driver { get; internal set; }
        public string GetTitle() { return Driver.Title; }
        public string GetUrl() { return Driver.Title; }
        public string GetPageSource() { return Driver.PageSource; }

        internal void LanguageListIsVisible()
        {
            var ValLanguageList = Driver.FindElement(By.ClassName("lang-list-active"));
            ValLanguageList.WebElementIsDisplayed(15);
            Console.WriteLine(":: The element ValLanguagaeList is displayed");

            //if (ValLanguageList.Displayed == true)
            //{
            //    Console.WriteLine(":: The class is displayed");
            //}
            //else
            //{
            //    Console.WriteLine(":: The class is not displayed");
            //}
        }

        public void OpenLanguageList()
        {
            var LinkLangList = Driver.FindElement(By.Id("js-lang-list-button"));
            LinkLangList.Click();
        }

        // lang-list-button-text js110n
        public EnglishHomePage NavEnglishHomePage()
        {
            var LinkEnglish = Driver.FindElement(By.Id("js-link-box-en"));
            LinkEnglish.Click();
            return InstanceOf<EnglishHomePage>();

        }

        internal void ValidateMultipleTextInPageSource(Table table)
        {
            foreach (var row in table.Rows)
            {
                var textToValidate = row["expectedText"];
                Assert.IsTrue(GetPageSource().Contains(textToValidate), textToValidate + " is not in the PageSource! ");
                Console.WriteLine(":: The text {0} is in the PageSource " , textToValidate);

            }
        }

        internal void ValidateTextInPageSource(string expectedText)
        {
            var textToValidate = GetPageSource().Contains(expectedText);
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
            var titleToValidate = GetTitle().Contains(expectedTitle);
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
