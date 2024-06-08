using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_Management_testing.PageObjects
{
    internal class LoginPageiAuth
    {
        public static int txtuserlength = PropertiesCollections.driver.FindElements(By.XPath("//input[@name='userName']")).Count;
        public static int txtpwdlength = PropertiesCollections.driver.FindElements(By.XPath("//input[@name='password']")).Count;
        public static int btnlogin = PropertiesCollections.driver.FindElements(By.XPath("/html/body/app-root/app-login/div/div/div[2]/form/button")).Count;
        public static string txtErrorMsg => PropertiesCollections.driver.FindElement(By.XPath("/html/body/app-root/app-login/div/div/div[2]/form/div[1]/span")).Text;

        public static string txtErrorMsg2 => PropertiesCollections.driver.FindElement(By.XPath("/html/body/app-root/app-login/div/div/div[2]/form/div[2]/span")).Text;
        public static IWebElement btnLogin => PropertiesCollections.driver.FindElement(By.XPath("//button[@type='submit']"));

        public static IWebElement txtFirstName => PropertiesCollections.driver.FindElement(By.Name("userName"));
        public static IWebElement txtpassword => PropertiesCollections.driver.FindElement(By.Name("password"));

        public static void clickForLogin()
        {
            btnLogin.Click();
        }

        public static void userName()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtFirstName.SendKeys(configuration["user"]);
        }

        public static void Password()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtpassword.SendKeys(configuration["pass"]);
        }
    }
}
