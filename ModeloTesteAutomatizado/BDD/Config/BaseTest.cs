using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ModeloTesteAutomatizado.BDD.Config
{
    public abstract class BaseTest
    {
        public static IWebDriver Driver { get; private set; }

        [BeforeScenario]
        public void BeforeTest()
        {
            if (BaseTest.Driver == null)
            {
                Driver = new ChromeDriver();
            }

            /*Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().ImplicitWait.Seconds;
                SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));
            */
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterTest()
        {
            try
            {
                Driver.Quit();
                Driver = null;
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static IWebDriver GetDriver()
        {
            return Driver;
        }
    }
}
