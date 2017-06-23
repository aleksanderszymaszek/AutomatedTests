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

        [TestCase("http://wwww.wp.pl", "Wiadomości")]
        [TestCase("http://wwww.onet.pl", "Pogoda")]
        [Category("UI")]
        public void FirstSeleniumTest(string url, string textinlink)
        {
            string xpath = $"//a[contains(., '{textinlink}')]"; 
            Browser.Navigate().GoToUrl(url);
            IWebElement link = Browser.FindElement(By.XPath(xpath));
            link.Click();
            

        }

        [OneTimeTearDown]
        public void TernDown()
        {
            Browser.Quit();
        }
    }
}
