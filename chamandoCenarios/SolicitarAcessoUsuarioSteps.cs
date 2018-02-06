using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace chamandoCenarios
{
    [Binding]
    public sealed class SolicitarAcessoUsuarioSteps
    {

        private ChromeOptions options;
        private IWebDriver driver;

        public SolicitarAcessoUsuarioSteps()
        {
            options = new ChromeOptions();
            options.AddArgument("--lang=pt");
            driver = new ChromeDriver(options);
        }

        [Given(@"que estou na página de solicitacao de cadastro")]
        public void GivenQueEstouNaPaginaDeSolicitacaoDeCadastro()
        {
            driver.Navigate().GoToUrl("http://localhost:49403/Login/Blank");
        }

        [Given(@"clico no botao de acesso")]
        public void GivenClicoNoBotaoDeAcesso()
        {
            driver.FindElement(By.Id("btnMenuAcesso")).Click();
        }

        [Given(@"clico em Solicitacao de acesso")]
        public void GivenClicoEmSolicitacaoDeAcesso()
        {
            driver.FindElement(By.Id("btnMenuSolicitacaoAcesso")).Click();
        }

        [Given(@"preenchi o mesmo com dados válidos (.*)")]
        public void GivenPreenchiOMesmoComDadosValidos(string matriculaSoli)
        {
            var selectEstatutario = new SelectElement(driver.FindElement(By.Name("-- Selecione --")));
            selectEstatutario.SelectByText("Estatuário");
            Thread.Sleep(2000);

            driver.FindElement(By.Name("Sim")).Click();

            var selectCBO = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectCBO.SelectByText("223505 - Enfermeiro");
            Thread.Sleep(2000);

            var selectOrgao = new SelectElement(driver.FindElement(By.ClassName("dropdown - menu open")));
            selectOrgao.SelectByText("SECRETARIA DE ESTADO DE SAÚDE");
            Thread.Sleep(2000);

            var selectSetor = new SelectElement(driver.FindElement(By.Id("SetorId")));
            selectSetor.SelectByText("Vigilância Sanitária");
            Thread.Sleep(2000);

            var matriculaSoliTxt = driver.FindElement(By.Id("Matricula"));
            matriculaSoliTxt.SendKeys(matriculaSoli);

            var selectSistema = new SelectElement(driver.FindElement(By.ClassName("filter - option pull - left")));
            selectSistema.SelectByText("SVS - Vigilância Sanitária");
            Thread.Sleep(2000);

            var selectNivelAbrangencia = new SelectElement(driver.FindElement(By.ClassName("dropdown-menu open")));
            selectNivelAbrangencia.SelectByText("Estadual");
            Thread.Sleep(2000);

            var justfivativaSoliTxt = driver.FindElement(By.Id("Matricula"));
            justfivativaSoliTxt.SendKeys("Para efeito de teste");

        }

        [Then(@"clico no botao salvar")]
        public void ThenClicoNoBotaoSalvar()
        {
            driver.FindElement(By.ClassName("btn btn-primary")).Click();
        }

        [AfterScenario]
        public void FechaBrowser()
        {
            driver.Dispose();
        }

    }
}
