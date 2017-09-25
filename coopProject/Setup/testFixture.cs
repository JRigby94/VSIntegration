using NUnit.Framework;
using Selenium_Automation.Selenium;

namespace Selenium_Automation
{
    [SetUpFixture]
    public class TestConfiguration : SeleniumDriver
    {
        [SetUp]
        public void FixtureSetup()
        {
        }

        [TearDown]
        public void FixtureTearDown()
        {
            if (WebDriver != null) WebDriver.Quit();
        }
    }
}