using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModeloTesteAutomatizado.BDD.Config;
using ModeloTesteAutomatizado.BDD.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ModeloTesteAutomatizado.BDD.Tests.Steps
{
    [Binding]
    class MyAccountSteps : BaseTest
    {

        [Then(@"devo visualizar a tela do usuário")]
        public void EntaoDevoVisualizarATelaDoUsuario()
        {
            MyAccountPage accountPage = new MyAccountPage();
            Assert.IsTrue(accountPage.VerificarSeEstaNaTelaAccount());
        }


    }
}
