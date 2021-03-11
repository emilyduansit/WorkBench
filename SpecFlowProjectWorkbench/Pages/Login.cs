using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace SpecFlowProjectWorkbench.Pages
{
    class Login
    {
        [FindsBy(How = How.CssSelector, Using = "input[name='UserName']")]
        private IWebElement username;

        [FindsBy(How = How.CssSelector, Using = "input[name='Password']")]
        private IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "Button[id='loginButton']")]
        private IWebElement loginbtn;


        public void gotologin()
        {
            Browser.gotoLogin();
            Browser.driver.Manage().Window.Maximize();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            username.SendKeys("demo1");
            password.SendKeys("test");
            loginbtn.Click();

            Assert.AreEqual(true, Browser.driver.FindElementByXPath("//*[@id='breadcrumbs']/ul/li/span").Displayed);
        }

    
    }
}
