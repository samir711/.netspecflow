using SpecFlow.Platform.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.Platform.Steps
{
    [Binding]
    public sealed class ReturnClickSteps : BaseSteps
    {
        [When(@"I click the English link")]
        public void WhenIClickTheEnglishLink()
        {
            InstanceOf<BasePage>().NavEnglishHomePage();
        }

    }
}
