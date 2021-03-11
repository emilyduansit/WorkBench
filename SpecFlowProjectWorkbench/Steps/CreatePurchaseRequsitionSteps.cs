using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectWorkbench.Steps
{
    [Binding]
    public class CreatePurchaseRequsitionSteps
    {
        [Given(@"I login correctly")]
        public void GivenILoginCorrectly()
        {
            Pages.PageInit.Login.gotologin();
            Pages.Browser.gotoCreate();
           
        }
        
        [Given(@"I input items")]
        public void GivenIInputItems()
        {
            Pages.PageInit.Create.CreatePurchaseRequsition();
        }
        
        [When(@"I click save")]
        public void WhenIClickSave()
        {
            Pages.PageInit.Create.clicksavebtn();
        }
        
        [Then(@"I save the PR")]
        public void ThenISaveThePR()
        {
            Pages.PageInit.Create.requisitionsaved();
        }
    }
}
