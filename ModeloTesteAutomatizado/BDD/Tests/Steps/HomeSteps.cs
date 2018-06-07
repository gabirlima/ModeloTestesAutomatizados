using ModeloTesteAutomatizado.BDD.Config;
using ModeloTesteAutomatizado.BDD.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ModeloTesteAutomatizado.BDD.Tests.Steps
{
    [Binding]
    class HomeSteps : BaseTest
    {

        [Given(@"que acessei o site")]
        public void DadoQueAcesseiOSite()
        {
            HomePage homepage = new HomePage();
            homepage.AcesseiHomePage();
        }


        [Given(@"cliquei o link Login")]
        [When(@"cliquei o link Login")]
        public void QuandoCliqueiOLinkLogin()
        {
            HomePage homePage = new HomePage();
            homePage.ClicarNoLinkLogin();
            Thread.Sleep(3000);
        }

    }
}
