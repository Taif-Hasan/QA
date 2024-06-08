using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoePortal.PageObjects
{
    class HomePage
    {
        private IWebElement menu_input => PropertiesCollections.driver.FindElement(By.CssSelector("#menuToggle > input[type=checkbox]"));
        private IWebElement lnkSignInPortal => PropertiesCollections.driver.FindElement(By.LinkText("Sign In Portal"));
        public void click_SignInPortal()
        {
            menu_input.Click();
            PropertiesCollections.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            //Thread.Sleep(2000);
            lnkSignInPortal.Click();
        }

    }
}
