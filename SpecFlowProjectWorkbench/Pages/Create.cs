using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;


namespace SpecFlowProjectWorkbench.Pages
{
    class Create
    {
        [FindsBy(How = How.Id, Using = "GeneralFields_Job")]
        private IWebElement job;

        [FindsBy(How = How.Id, Using = "GeneralFields_Description")]
        private IWebElement description;

        [FindsBy(How = How.Id, Using = "GeneralFields_RequestedFor")]
        private IWebElement requestedfor;

        [FindsBy(How = How.Id, Using = "itemActivity")]
        private IWebElement itemactivity;

        [FindsBy(How = How.Id, Using = "itemDescription")]
        private IWebElement itemdescription; 

        [FindsBy(How = How.Id, Using = "itemQuantity")]
        private IWebElement itemquantity;

        [FindsBy(How = How.Id, Using = "itemUnitCost")]
        private IWebElement itemunitcost;

        [FindsBy(How = How.Id, Using = "AddressesFields_DeliveryAddress")]
        private IWebElement deliveryaddress;

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='addItem(item, purchaseRequisitionEntry_Form)']")]
        private IWebElement savebtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='purchaseRequisitionEntry_Form']/div[7]/div[2]/div/button")]
        private IWebElement submitbtn;

        [FindsBy(How = How.CssSelector, Using = "button[ng-click='removeItem(repeatItem)'")]
        private IWebElement removebtn;

        
        [FindsBy(How = How.Id, Using = "validationSummaryErrorList")]
        private IWebElement validationerror;


        public void CreatePurchaseRequsition()
        {          
           
            job.SendKeys("4112 : Pipeline Construction Contract");
            description.SendKeys("123");           

            itemactivity.SendKeys("ACCOM : Accomodation");
            itemdescription.SendKeys("123123");
            itemquantity.SendKeys("2");
            itemunitcost.SendKeys("100");
            deliveryaddress.SendKeys("123");           

        }

        public void additem()
        {
            requestedfor.SendKeys("Bill Maloney");
        }

        public void clicksavebtn()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            savebtn.Click();
        }

        public void clicksubmitbtn()
        {
            submitbtn.Click();
            IAlert submitAlert = Browser.driver.SwitchTo().Alert();
            submitAlert.Accept();

        }

        public void requisitionsaved()
        {
            Assert.AreEqual(true, Browser.driver.FindElementByXPath("//*[text()='Summary']").Displayed);
            Assert.AreEqual(true, removebtn.Displayed);
        }

        public void failuremessagedisplay()
        {              
               Assert.AreEqual(true,validationerror.Displayed);
        }
    }
}
