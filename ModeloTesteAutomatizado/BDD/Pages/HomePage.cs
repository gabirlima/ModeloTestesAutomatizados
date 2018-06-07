using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloTesteAutomatizado.BDD.Pages
{
    class HomePage : BasePage
    {

        [FindsBy(How = How.Id, Using = "header_logo")]
        [CacheLookup]
        private IWebElement Logo { get; set; }

        [FindsBy(How = How.ClassName, Using = "login")]
        [CacheLookup]
        private IWebElement LinkLogin { get; set; }


        public void ClicarNoLinkLogin()
        {
            LinkLogin.Click();
        }

        public void AcesseiHomePage()
        {
            Driver.Navigate().GoToUrl(baseURL);
        }
    }
}
