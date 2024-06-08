using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace OnlineShoePortal.PageObjects
{
    internal class RegistrationPage
    {

        public static IWebElement btnSubmit => PropertiesCollections.driver.FindElement(By.XPath("//input[@value='Submit']"));
        public static IWebElement txtFirstName => PropertiesCollections.driver.FindElement(By.Id("firstname"));
        public static IWebElement txtLastName => PropertiesCollections.driver.FindElement(By.Id("lastname"));
        public static IWebElement txtEmailid => PropertiesCollections.driver.FindElement(By.Id("emailId"));
        public static IWebElement txtUsername => PropertiesCollections.driver.FindElement(By.Id("usr"));
        public static IWebElement txtpassword => PropertiesCollections.driver.FindElement(By.Id("pwd"));
        public static string txtErrorMsg => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"first_form\"]/div/span")).Text;
        public static string txterrorMsg2 => PropertiesCollections.driver.FindElement(By.XPath("//*[@id=\"first_form\"]/div/span")).Text;



        public static void select_Salutation()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            SelectElement drpSalutation = new SelectElement(PropertiesCollections.driver.FindElement(By.Id("Salutation")));
            drpSalutation.SelectByText(configuration["Salutation"]);
        }

        public static void click_Submit()
        {
            btnSubmit.Click();
        }

        public static void enter_FirstName()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtFirstName.SendKeys(configuration["Firstname"]);
        }
        public static void enter_LastName()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtLastName.SendKeys(configuration["Lastname"]);
        }
        public static void enter_InvalidEmail()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtEmailid.SendKeys(configuration["InvalidEmailAddress"]);
        }
        public static void enter_ValidEmail()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtEmailid.SendKeys(configuration["ValidEmailAddress"]);
        }
        public static void enter_UsrName()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtUsername.SendKeys(configuration["Username"]);
        }
        public static void enter_Password()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            txtpassword.SendKeys(configuration["Password"]);
        }





    }
}
