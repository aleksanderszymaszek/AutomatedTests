using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectAT.UITests
{
    [TestFixture]
    public class SeleniumTest
    {
        public IWebDriver Browser { get; set; }

        [OneTimeSetUp]
        public void SetUp()
        {
            Browser = new ChromeDriver();
            Browser.Manage().Window.Maximize();
        }

        [TestCase("http://wwww.wp.pl")]
        [TestCase("http://wwww.onet.pl")]
        [Category("UI")]
        public void FirstSeleniumTest(string url)
        {
            Browser.Navigate().GoToUrl(url);
        }

        [OneTimeTearDown]
        public void TernDown()
        {
            Browser.Quit();
        }
    }
}
