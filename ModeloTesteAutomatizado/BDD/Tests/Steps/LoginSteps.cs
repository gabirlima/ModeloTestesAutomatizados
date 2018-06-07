using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModeloTesteAutomatizado.BDD.Config;
using ModeloTesteAutomatizado.BDD.Pages;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ModeloTesteAutomatizado.BDD.Steps
{
    [Binding]
    public class LoginSteps : BaseTest
    {

        [Then(@"devo visualizar a tela de login")]
        [Given(@"que acessei a tela de login")]
        public void EntaoDevoVisualizarATelaDeLogin()
        {
            LoginPage loginPage = new LoginPage();
            Assert.IsTrue(loginPage.AcesseiTelaLogin());
        }

        [When(@"preencher o campo Login")]
        public void QuandoPreencherOCampoLogin()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.PreencherCampoEmail();
        }

        [When(@"preencher o campo Senha")]
        public void QuandoPreencherOCampoSenha()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.PreencherCampoSenha();
        }

        [When(@"selecionar o botão Submit")]
        public void QuandoSelecionarOBotaoSubmit()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.ClicarNoBotaoSubmit();
        }
    }
}
