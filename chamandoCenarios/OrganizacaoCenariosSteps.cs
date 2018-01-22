using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace chamandoCenarios
{
    [Binding]
    public class OrganizacaoCenariosSteps
    {
        private IWebDriver driver = new ChromeDriver();

        [Given(@"eu vou cadastrar")]
        public void EuVouCadastrar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"eu vou autenticar")]
        public void GivenEuVouAutenticar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"os testes são finalizados")]
        public void ThenOsTestesSãoFinalizados()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
