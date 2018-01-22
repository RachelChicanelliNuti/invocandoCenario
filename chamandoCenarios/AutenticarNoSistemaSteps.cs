using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace chamandoCenarios
{
    

    [Binding]
    public class AutenticarNoSistemaSteps
    {
        private IWebDriver driver = new ChromeDriver();

        [Given(@"que estou na página de autenticacao")]
        public void GivenQueEstouNaPaginaDeAutenticacao()
        {
            driver.Navigate().GoToUrl("http://localhost:49403");
        }

        [When(@"eu preencho o campo CPF com o valor '(.*)'")]
        public void WhenEuPreenchoOCampoCPFComOValor(string cpf)
        {
            IWebElement cpfTxt = driver.FindElement(By.Id("CPF"));
            cpfTxt.SendKeys(cpf);
        }

        [When(@"preencha o campo Senha com o valor '(.*)'")]
        public void WhenPreenchaOCampoSenhaComOValor(string senha)
        {
            IWebElement senhaTxt = driver.FindElement(By.Id("Senha"));
            senhaTxt.SendKeys(senha);
        }

        [When(@"clico no botão entrar")]
        public void WhenClicoNoBotaoEntrar()
        {
            driver.FindElement(By.XPath("//*[@value='Entrar']")).Click();
        }

        [Then(@"tvejo na tela '(.*)'")]
        public void ThenTvejoNaTela(string mensagem)
        {
            bool achouTexto = driver.PageSource.Contains(mensagem);
            if (!achouTexto)
            {
                TestPostMessage("Erro encontrado: \n" +
                    "CLASSE: AutenticacaoNoSistemaSteps\n" +
                    "MÉTODO: EntaoVejoNaTela.\n" +
                    "DESCRIÇÃO: Mensagem não exibida na tela: '" + mensagem + "'");
                throw new Exception("Erro encontrado: \n" +
                    "CLASSE: AutenticacaoNoSistemaSteps\n" +
                    "MÉTODO: EntaoVejoNaTela.\n" +
                    "DESCRIÇÃO: Mensagem não exibida na tela: '" + mensagem + "'");

            }
        }

        private void TestPostMessage(string v)
        {
            throw new NotImplementedException();
        }

        [AfterScenario]
        public void FechaBrowser()
        {
            driver.Dispose();
        }
    }
}
