using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebTestSample
{
    [TestClass]
    public class WebsiteTests
    {
        [TestMethod]
        public void QueryGoogle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("hello world\n");

            Console.WriteLine("Website title is: " + driver.Title);

            Assert.IsTrue(driver.FindElement(By.Id("resultStats")).Displayed);

            Assert.AreEqual(driver.Title, "Googlish");

            driver.Quit();
        }
    }
}