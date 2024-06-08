using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Support.UI;
using OnlineShoePortal.PageObjects;

namespace OnlineShoePortal.Tests
{
    [TestClass]
    public class TS01_UserRegistration
    {
        /**
        private readonly IConfiguration _configuration;
        public TS01_UserRegistration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();
        }**/
        [TestMethod]
        public void TC01_UserRegistration_ErrValidation()
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
            
            Assert.AreEqual(1, SignInPage.textuserlength);
            Assert.AreEqual(1, SignInPage.textpdwlength);
            Assert.AreEqual(1, SignInPage.btnLogin);
            Assert.AreEqual(1, SignInPage.btnRegistration);

            SignInPage.clickNewRegistration();
            RegistrationPage.select_Salutation();
            RegistrationPage.click_Submit();

            Assert.AreEqual("This field is required", RegistrationPage.txtErrorMsg);

            RegistrationPage.enter_FirstName();
            RegistrationPage.click_Submit();

            Assert.AreEqual("This field is required", RegistrationPage.txtErrorMsg);

            RegistrationPage.enter_LastName();
            RegistrationPage.click_Submit();

            Assert.AreEqual("This field is required", RegistrationPage.txtErrorMsg);

            RegistrationPage.enter_InvalidEmail();
            RegistrationPage.click_Submit();

            Assert.AreEqual("Enter a valid email", RegistrationPage.txterrorMsg2);

            RegistrationPage.enter_ValidEmail();
            RegistrationPage.click_Submit();

            Assert.AreEqual("This field is required", RegistrationPage.txtErrorMsg);

            RegistrationPage.enter_UsrName();
            RegistrationPage.click_Submit();

            Assert.AreEqual("This field is required", RegistrationPage.txtErrorMsg);

            RegistrationPage.enter_Password();
            RegistrationPage.click_Submit();

            PropertiesCollections.driver.Close();
            PropertiesCollections.driver.Quit();







        }
    }
}