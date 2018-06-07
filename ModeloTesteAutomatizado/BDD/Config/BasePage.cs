using ModeloTesteAutomatizado.BDD.Config;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloTesteAutomatizado.BDD.Pages
{
    class BasePage
    {
        protected IWebDriver Driver
        {
            get
            {
                return BaseTest.Driver;
            }
        }

        protected string baseURL { get; set; }

        public BasePage()
        {
            PageFactory.InitElements(BaseTest.Driver, this);

            baseURL = "http://automationpractice.com/";
        }

        protected internal void ExecuteScript(string jsScript)
        {
            ((IJavaScriptExecutor)BaseTest.Driver).ExecuteScript(jsScript);
        }

    }
}
