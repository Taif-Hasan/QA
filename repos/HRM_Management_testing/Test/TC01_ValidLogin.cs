using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Support.UI;
using HRM_Management_testing.PageObjects;

namespace HRM_Management_testing.Test
{
    [TestClass]
    public class TC01_ValidLogin
    {
        [TestMethod]
        public void TestMethod1()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("-no-sandbox");
            PropertiesCollections.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            //Thread.Sleep(2000);
            //driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);

            PropertiesCollections.driver.Navigate().GoToUrl(configuration["url"]);

            PropertiesCollections.driver.Manage().Window.Maximize();


            //Assert.AreEqual(1, LoginPage.txtuserlength);
            //Assert.AreEqual(1, LoginPage.txtpwdlength);
            //Assert.AreEqual(1, LoginPage.btnlogin);

            //LoginPage.clickForLogin();

            //Assert.AreEqual("This field is required.", LoginPage.txtErrorMsg);

            LoginPageiAuth.userName();
            //LoginPage.clickForLogin();

            //Assert.AreEqual("This field is required.", LoginPage.txtErrorMsg2);

            LoginPageiAuth.Password();
            LoginPageiAuth.clickForLogin();

            Thread.Sleep(4000);

            iAuthPage.clickHrm();



        }
    }
}