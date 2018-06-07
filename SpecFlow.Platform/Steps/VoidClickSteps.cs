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
    public sealed class VoidClickSteps : BaseSteps
    {
        [When(@"I Open the language list")]
        public void WhenIOpenTheLanguageList()
        {
            InstanceOf<BasePage>().OpenLanguageList();
        }



    }
}
