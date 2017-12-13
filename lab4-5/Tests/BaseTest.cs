using Framework;
using NUnit.Framework;

namespace Tests
{
    [SetUpFixture]
    public class BaseTest
    {
        [OneTimeTearDown]
        public void TearDownMethods()
        {
            Selenium.Driver.Close();
        }
    }
}
