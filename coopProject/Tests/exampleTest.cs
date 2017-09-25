using NUnit.Framework;
using System.Threading;
using Selenium_Automation.PageObjects;
using Selenium_Automation.Selenium;

namespace Selenium_Automation.Tests
{
    [TestFixture]
    public class CoopTest : SeleniumDriver
    {
        [SetUp]
        public void TestSetUp()
        {
            Visit("http://www.co-opinsurance.co.uk/?cid=ppc-google&search=paid&salias=43700001729643741&gclid=Cj0KCQjw0ejNBRCYARIsACEBhDORmCkqCiy3gr9KJXjmandyIHeCqtDXFZXw7Kg1ge_MZJVd7WCdUrQaAmiiEALw_wcB");
        }

        [Test]
        public void CoopPageTitle()
        {
            /*  The first task is to create the HomePage Object.  This
             * allows us to reference the Homepage and all of the defined elements
        ma     * as shown in the examples below
             */
            HomePage homepage = new HomePage(WebDriver);

            /* Here is an example of using the new Elements to validate information
             * within the webpage using the pagefactory
             */
            Assert.AreEqual("Co-op Insurance | Car, Home & Pet Insurance", homepage.Title.Text);
            Assert.IsTrue(homepage.Title.Text == ("Co-op Insurance"));

            /* The following sleep statement has only been placed in this code to demostrate
             * the button push as there is no validation of the search results in place
             * so its not possible to actually see the result of the button click.
             */
            Thread.Sleep(5000);
        }

        }
    }
