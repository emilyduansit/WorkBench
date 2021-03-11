using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SpecFlowProjectWorkbench.Pages
{
    class PageInit
    {
        public static Login Login
        {
            get
            {
                var Login = new Login();
                PageFactory.InitElements(Browser.driver, Login);
                return Login;
            }
        }

        public static Create Create
        {
            get
            {
                var Create = new Create();
                PageFactory.InitElements(Browser.driver, Create);
                return Create;
            }
        }

        public static Review Review
        {
            get
            {
                var Review = new Review();
                PageFactory.InitElements(Browser.driver, Review);
                return Review;
            }
        }
    }
}
