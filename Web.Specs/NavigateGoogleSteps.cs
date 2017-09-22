using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Web.Specs
{
    [Binding]
    public class NavigateGoogleSteps
    {

        IWebDriver driver;

        NavigateGoogleSteps()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Given(@"I navigate to '(.*)'")]
        public void GivenINavigateTo(string url)
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Then(@"the page title is '(.*)'")]
        public void ThePageTitleIs(string title)
        {
            Assert.That(driver.Title, Is.EqualTo(title));
        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see search results")]
        public void ThenISeeSearchResults()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
