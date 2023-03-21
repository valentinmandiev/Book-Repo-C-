using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.StepDefinitions
{
    public class WalletSteps
    {

        [Given(@"I have visa card with the following data")]
        public void GivenIHaveAVisaCardWithNumberExpirationDateCVV(Table table)
        {
            var myCard = table.CreateInstance<Card>();

            
        }
    }
}
