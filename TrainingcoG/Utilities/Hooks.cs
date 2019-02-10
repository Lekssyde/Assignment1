using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TrainingcoG.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver driver;
        //public FirefoxDriver driverFirefox;
        //public InternetExplorerDriver driverIE;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            //driverFirefox = new FirefoxDriver();
            //driverIE = new InternetExplorerDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
