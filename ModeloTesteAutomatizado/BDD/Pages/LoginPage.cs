using ModeloTesteAutomatizado.BDD.Steps;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloTesteAutomatizado.BDD.Pages
{
    class LoginPage : BasePage
    {
        
        [FindsBy(How = How.Id, Using = "login_form")]
        public IWebElement DivFormularioLogin { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement CampoEmail { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement CampoSenha { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement BotaoSubmit { get; set; }

        public Boolean AcesseiTelaLogin()
        {
            return DivFormularioLogin.Displayed;
        }

        public void PreencherCampoEmail()
        {
            CampoEmail.SendKeys("testegabirlima@teste.com");
        }

        public void PreencherCampoSenha()
        {
            CampoSenha.SendKeys("123456");
        }

        public void ClicarNoBotaoSubmit()
        {
            BotaoSubmit.Click();
        }
    }
}
