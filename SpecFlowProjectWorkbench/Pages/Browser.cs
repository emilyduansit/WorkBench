using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectWorkbench.Pages
{
    class Browser
    {
        public static ChromeDriver driver = new ChromeDriver(@"C:\Users\Emily\Source\Repos\SpecFlowProjectWorkbench\SpecFlowProjectWorkbench\Drivers\");

        public static void gotoLogin()
        {

            driver.Navigate().GoToUrl("https://web.workbench.co.nz/WorkbenchTestV4/Public.aspx/Login");
        }

        public static void gotoCreate()
        {

            driver.Navigate().GoToUrl("https://web.workbench.co.nz/WorkbenchTestV4/Workbench.aspx#/PurchaseRequisitions/DetailMobi.aspx/Create");
        }
        

        public static void gotoReview()
        {

            driver.Navigate().GoToUrl("https://web.workbench.co.nz/WorkbenchTestV4/Workbench.aspx#/Approvals/ReviewList.aspx");
        }


        public static void back()
        {
            driver.Navigate().Back();
        }



        public static void close()
        {
            driver.Close();
        }
    }
}
