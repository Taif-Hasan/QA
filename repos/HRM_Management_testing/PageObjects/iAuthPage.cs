using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_Management_testing.PageObjects
{
    internal class iAuthPage
    {

        public static IWebElement clickiHrm = PropertiesCollections.driver.FindElement(By.CssSelector("#page-content-wrapper > div > app-user-dashboard > div > div > div > div:nth-child(1) > div > p"));


        public static void clickHrm()
        {
            clickiHrm.Click();
        }
    }


}
