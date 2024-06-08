using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OnlineShoePortal.PageObjects;

namespace OnlineShoePortal
{
    [TestClass]
    public class TS02_UserRegistration
    {


        [TestMethod]
        public void TC02_UserReg_SuccessfulValidation()
        {

            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();
            HomePage homePage = new HomePage();

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("-no-sandbox");
            PropertiesCollections.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            //Thread.Sleep(2000);
            //driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);

            PropertiesCollections.driver.Navigate().GoToUrl(configuration["url"]);

            
            homePage.click_SignInPortal();

            SignInPage.clickNewRegistration();
            RegistrationPage.select_Salutation();
            RegistrationPage.enter_FirstName();
            RegistrationPage.enter_LastName();
            RegistrationPage.enter_ValidEmail();
            RegistrationPage.enter_UsrName();
            RegistrationPage.enter_Password();
            RegistrationPage.click_Submit();
            Assert.AreEqual("User Registered Successfully !!!", SuccessRegistrationPage.SuccessMsg);

            PropertiesCollections.driver.Close();
            PropertiesCollections.driver.Quit();

        }
    }
}