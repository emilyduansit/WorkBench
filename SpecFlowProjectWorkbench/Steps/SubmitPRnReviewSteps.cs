using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectWorkbench.Steps
{
    [Binding]
    public class SubmitPRnReviewSteps
    {
        [Given(@"I create PR successfully")]
        public void GivenICreatePRSuccessfully()
        {
            Pages.PageInit.Login.gotologin();
            Pages.Browser.gotoCreate();
            Pages.PageInit.Create.CreatePurchaseRequsition();
            Pages.PageInit.Create.clicksavebtn();
            Pages.PageInit.Create.requisitionsaved();
        }
        
        [Given(@"I submit the PR")]
        public void GivenISubmitThePR()
        {
            Pages.PageInit.Create.clicksubmitbtn();
        }
        
        [When(@"I go to the Review Page")]
        public void WhenIGoToTheReviewPage()
        {
            Pages.Browser.gotoReview();
        }
        
        [Then(@"I see the PR")]
        public void ThenISeeThePR()
        {
            Pages.PageInit.Review.reviewlistpagedisplay();
            Pages.Browser.close();
        }
    }
}
