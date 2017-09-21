using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebTestSample
{
    [TestClass]
    public class WebsiteTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("hello world\n");

            Assert.IsTrue(driver.FindElement(By.Id("resultStats")).Displayed);

            driver.Quit();
        }
    }
}