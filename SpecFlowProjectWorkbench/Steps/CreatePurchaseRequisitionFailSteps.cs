using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectWorkbench.Steps
{
    [Binding]
    public class CreatePurchaseRequisitionFailSteps
    {
        [Given(@"I input item")]
        public void GivenIInputItem()
        {
            Pages.PageInit.Create.CreatePurchaseRequsition();
            Pages.PageInit.Create.additem();
        }
        
        [Then(@"I see the failure messages")]
        public void ThenISeeTheFailureMessages()
        {
            Pages.PageInit.Create.failuremessagedisplay();
        }
    }
}
