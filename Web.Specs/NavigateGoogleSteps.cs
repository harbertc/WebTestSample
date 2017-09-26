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

        [Given("I navigate to '(.*)'")]
        public void GivenINavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [Then("the page title is [\"'](.*)[\"']")]
        public void ThePageTitleIs(string title)
        {
            Assert.That(driver.Title, Is.EqualTo(title));
        }

        [When("I search for '(.*)'")]
        public void WhenISearchFor(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then("I see search results")]
        public void ThenISeeSearchResults()
        {
            ScenarioContext.Current.Pending();
        }

        [Then("the environment is '(.*)'")]
        public void TheEnvironmentIs(string expectedEnvironment)
        {
            Assert.That(Environment.GetEnvironmentVariable("ENVIRONMENT"), Is.EqualTo(expectedEnvironment));
        }

        [BeforeFeature("web")]
        public static void BeforeFeature()
        {
            FeatureContext.Current.Add("driver", new ChromeDriver());
            ((IWebDriver) FeatureContext.Current["driver"]).Manage().Window.Maximize();
        }

        [BeforeFeature]
        public static void LoadEnvironment()
        {
            string environment = Environment.GetEnvironmentVariable("ENVIRONMENT");
            FeatureContext.Current.Add("ENVIRONMENT", environment);
        }

        [AfterFeature("web")]
        public static void AfterFeature()
        {
            ((IWebDriver)FeatureContext.Current["driver"]).Quit();
        }

        public IWebDriver driver
        {
            get { return ((IWebDriver)FeatureContext.Current["driver"]); }
        }

        
    }
}
