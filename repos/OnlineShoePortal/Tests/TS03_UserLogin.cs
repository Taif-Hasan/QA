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
    public class TS03_UserLogin
    {


        [TestMethod]
        public void TC03_UserLogin_ErrValidation()
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

            SignInPage.clickLogin();
            Assert.AreEqual("Both Username and Password field are required", SignInPage.txtUsrPwdErrorMsg);

            SignInPage.enterUserName();
            SignInPage.clickLogin();
            Assert.AreEqual("Both Username and Password field are required", SignInPage.txtUsrPwdErrorMsg);

            
        }
    }
}