using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace HRM_LOGIN.Test
{
    public class TS01_UserLogin
    {
        public void TS01_UserLogin_ErrValidation()
        {
            var properties = new PropertiesCollections(); // Create an instance of PropertiesCollections
            var configuration = properties.GetConfiguration();

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("-no-sandbox");
            PropertiesCollections.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            //Thread.Sleep(2000);
            //driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);

            PropertiesCollections.driver.Navigate().GoToUrl(configuration["url"]);
        }

    }
}
