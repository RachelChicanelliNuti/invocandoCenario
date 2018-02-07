using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace chamandoCenarios
{
    [Binding]
    public class AutenticacaoNoSistemaSteps
    {
        private ChromeOptions options;
        private IWebDriver driver;

        public AutenticacaoNoSistemaSteps()
        {
            options = new ChromeOptions();
            options.AddArgument("--lang=pt");
            driver = new ChromeDriver(options);
        }

        [Given(@"que estou na página de autenticacao")]
        public void GivenQueEstouNaPaginaDeAutenticacao()
        {
            driver.Navigate().GoToUrl("http://localhost:49403/Login");
        }

        [When(@"eu preencho o campo CPF com o valor (.*)")]
        public void WhenEuPreenchoOCampoCPFComOValor(string cpf)
        {
            IWebElement cpfTxt = driver.FindElement(By.Id("CPF"));
            cpfTxt.SendKeys(cpf);
        }

        [When(@"preencha o campo Senha com o valor (.*)")]
        public void WhenPreenchaOCampoSenhaComOValor(string senha)
        {
            IWebElement senhaTxt = driver.FindElement(By.Id("Senha"));
            senhaTxt.SendKeys(senha);
        }

        [When(@"clico no botão Entrar")]
        public void WhenClicoNoBotaoEntrar()
        {
            driver.FindElement(By.XPath("//*[@value='Entrar']")).Click();
        }

        [Then(@"vejo na tela (.*)")]
        public void ThenVejoNaTela(string mensagem)
        {
            bool achouTexto = driver.PageSource.Contains(mensagem);
        }
        //[AfterScenario]
        //public void FechaBrowser()
        //{
        //    driver.Dispose();
        //}
    }
}
