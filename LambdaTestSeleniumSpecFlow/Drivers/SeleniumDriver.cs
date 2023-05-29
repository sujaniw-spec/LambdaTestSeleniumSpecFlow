using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace LambdaTestSeleniumSpecFlow.Drivers
{
    public class SeleniumDriver
    {

        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        public IWebDriver Setup(string browserName)
        {
           // var chromeOptions = new ChromeOptions();

            dynamic capability = GetBrowserOptions(browserName);
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability.ToCapabilities());

         //   driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions.ToCapabilities());

            //Set the driver
            _scenarioContext.Set(driver, "WebDriver");

            driver.Manage().Window.Maximize();
            return driver;
        }

        private dynamic GetBrowserOptions(string browserName)
        {
            if (browserName.ToLower() == "chrome")
                return new ChromeOptions();
            if (browserName == "MicrosoftEdge")
                return new EdgeOptions();

            //if non return ChromeOptions
            return new ChromeOptions();
        }
        
    }
}
