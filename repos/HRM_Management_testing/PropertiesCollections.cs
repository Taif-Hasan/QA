using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_Management_testing
{
    internal class PropertiesCollections
    {
        public static IWebDriver driver { set; get; }
        public readonly IConfiguration _configuration;

        public PropertiesCollections()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();
        }
        public IConfiguration GetConfiguration()
        {
            return _configuration;
        }
    }
}
