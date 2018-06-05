using SpecFlow.Platform.Pages;
using SpecFlow.Platform.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.Platform.Steps
{
   [Binding]
   public sealed class BaseScenariosSteps : BaseSteps
    {
       [Then(@"I see")]
       public void ThenISee(Table table)
       {
           InstanceOf<BasePage>().ValidateMultipleTextInPageSource(table);
       }

       [Then(@"I see ""(.*)"" in the PageSource")]
       public void ThenISeeInThePageSource(string expectedText)
       {
           InstanceOf<BasePage>().ValidateTextInPageSource(expectedText);
       }

       [Then(@"I see the page Url contains ""(.*)""")]
       public void ThenISeeThePageUrlContains(string expectedUrl)
       {
           InstanceOf<BasePage>().ValidatePageUrl(expectedUrl);
       }


       [Then(@"I see the page title contains ""(.*)""")]
       public void ThenISeeThePageTitleContains(string expectedTitle)
       {
           InstanceOf<BasePage>().ValidatePageTitle(expectedTitle);
       }


       [Given(@"I navigate to the homepage")]
       public void GivenINavigateToTheHomepage()
       {
           InstanceOf<BasePage>().NavigateMainEnterPoint();

       }


    }
}
