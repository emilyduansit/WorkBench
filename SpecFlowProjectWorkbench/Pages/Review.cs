using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SpecFlowProjectWorkbench.Pages
{
    class Review
    {
        [FindsBy(How = How.XPath, Using = "//*[text()='Review List']")]
        private IWebElement reviewlabel;


        public void reviewlistpagedisplay()
        {
            Assert.AreEqual(true, reviewlabel.Displayed);
        }

    }
}
