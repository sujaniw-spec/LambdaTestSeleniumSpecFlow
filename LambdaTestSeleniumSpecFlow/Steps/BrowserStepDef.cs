using LambdaTestSeleniumSpecFlow.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

[assembly:Parallelizable(ParallelScope.Fixtures)]
namespace LambdaTestSeleniumSpecFlow.Steps
{
    [Binding]
 
    public sealed class BrowserStepDef
    {

        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public BrowserStepDef(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

       
        [Given(@"I navigate to LambdaTest App on following environment")]
        public void GivenINavigateToLambdaTestAppOnFollowingEnvironment(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            //for local
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup((string)data.Browser);
            driver.Url = "https://lambdatest.github.io/sample-todo-app/";

        }

     //   [Test]
     //   [Parallelizable]
        [Given(@"I select the first item")]
        public void GivenISelectTheFirstItem()
        {
            driver.FindElement(By.Name("li1")).Click();
        }

     //   [Test]
     //   [Parallelizable]
        [Given(@"I select the secod item")]
        public void GivenISelectTheSecodItem()
        {
            driver.FindElement(By.Name("li2")).Click();
        }

     //   [Test]
     //   [Parallelizable]
        [Given(@"I enter the new value in textbox")]
        public void GivenIEnterTheNewValueInTextbox()
        {
            driver.FindElement(By.Id("sampletodotext")).SendKeys("sampletodotext");
        }

     //   [Test]
     //   [Parallelizable]
        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            driver.FindElement(By.Id("addbutton")).Click();
        }

     //   [Test]
      //  [Parallelizable]
        [Then(@"I verify whether the item is added to the list")]
        public void ThenIVerifyWhetherTheItemIsAddedToTheList()
        {
           // driver.Quit();
           NUnit.Framework.Assert.That(driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span")).Text, Is.EqualTo("sampletodotext"));
        }

    }
}
