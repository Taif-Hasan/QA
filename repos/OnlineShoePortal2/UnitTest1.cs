using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;


namespace OnlineShoePortal
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver driver { get; set; }
        [TestMethod]
        public void TestMethod1()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("-no-sandbox");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            driver.Navigate().GoToUrl("https://anupdamoda.github.io/AceOnlineShoePortal/index.html");
        }
    }
}
