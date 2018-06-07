using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloTesteAutomatizado.BDD.Pages
{
    class MyAccountPage : BasePage
    {

        [FindsBy(How = How.ClassName, Using = "info-account")]
        public IWebElement InfoAcount;
        
        public Boolean VerificarSeEstaNaTelaAccount()
        {
            return InfoAcount.Displayed;
        }

    }
}
