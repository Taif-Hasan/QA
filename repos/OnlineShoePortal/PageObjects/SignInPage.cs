using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoePortal.PageObjects
{
    internal class SignInPage
    {
        public static int textuserlength = PropertiesCollections.driver.FindElements(By.Id("usr")).Count;
        public static int textpdwlength = PropertiesCollections.driver.FindElements(By.Id("pwd")).Count;
        public static int btnLogin = PropertiesCollections.driver.FindElements(By.XPath("//input[@value='Login']")).Count;
        public static int btnRegistration = PropertiesCollections.driver.FindElements(By.Id("NewRegistration")).Count;
        public static string txtUsrPwdErrorMsg => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"second_form\"]/div[2]/span")).Text;
        public static IWebElement btnNewRegistration => PropertiesCollections.driver.FindElement(By.Id("NewRegistration"));
        public static IWebElement btnLgn => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"second_form\"]/input"));
        public static IWebElement txtUserName => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"usr\"]"));
        public static IWebElement txtPassword => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"pwd\"]"));

        public static void clickNewRegistration()
        {
            btnNewRegistration.Click();
        }

        public static void clickLogin()
        {
            btnLgn.Click();
        }

        public static void enterUserName()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtUserName.SendKeys(configuration["Username"]);
            
        }
        public static void enterPassword()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtPassword.SendKeys(configuration["Password"]);
            
        }
    }
}


    
