using System.Configuration;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string? url = ConfigurationManager.AppSettings["URL"];
        }
    }
}