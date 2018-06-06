using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.Platform.Steps
{
    [Binding]
    public sealed class DynamicTableSteps :BaseSteps
    {

        [Then(@"I see")]
        public void ThenISee(Table table)
        {
            InstanceOf<SpecFlow.Platform.Pages.BasePage>().ValidateMultipleTextInPageSource(table);
        }

    }
}
