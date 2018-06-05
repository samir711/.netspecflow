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

       [Given(@"I navigate to the homepage")]
       public void GivenINavigateToTheHomepage()
       {
           var url = "http://www.wikipedia.org";
           Driver.Browser().Navigate().GoToUrl(url);

       }


    }
}
