using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace chamandoCenarios
{
    [Binding]
    public class CadastrarSteps : Steps
    {
        private IWebDriver driver = new ChromeDriver();
        private string _cpf;
        private string _senha;

        [Given(@"que estou na pagina de cadastro")]
        public void GivenQueEstouNaPaginaDeCadastro()
        {
            //driver.Navigate().GoToUrl("http://192.168.207.157/Usuario/Adicionar/");
            //driver.Navigate().GoToUrl("http://200.129.242.3:50080/Usuario/Adicionar/");
            driver.Navigate().GoToUrl("http://localhost:49403/Usuario/Adicionar/");
        }

        [Given(@"eu preencho o campo nome (.*)")]
        public void GivenEuPreenchoOCampoNome(string nome)
        {
            IWebElement nomeTxt = driver.FindElement(By.Id("Nome"));
            nomeTxt.SendKeys(nome);
        }

        [Given(@"eu preencho o campo email (.*)")]
        public void GivenEuPreenchoOCampoEmail(string email)
        {
            IWebElement emailTxt = driver.FindElement(By.Id("EmailPrincipal"));
            emailTxt.SendKeys(email);
        }

        [Given(@"eu preencho o campo nascimento (.*)")]
        public void GivenEuPreenchoOCampoNascimento(string nascimento)
        {
            IWebElement nascimentoTxt = driver.FindElement(By.Id("DataNascimento"));
            nascimentoTxt.SendKeys(nascimento);
        }

        [Given(@"eu preencho o campo rg (.*)")]
        public void GivenEuPreenchoOCampoRg(string rg)
        {
            IWebElement rgTxt = driver.FindElement(By.Id("RG"));
            rgTxt.SendKeys(rg);
        }

        [Given(@"eu preencho o campo celular(.*)")]
        public void GivenEuPreenchoOCampoCelular(string celular)
        {
            IWebElement celularTxt = driver.FindElement(By.Id("TelefoneCelular"));
            celularTxt.SendKeys(celular);
        }
        //aqui
        [Given(@"eu preencho o campo logradouro(.*)")]
        public void GivenEuPreenchoOCampoLogradouro(string logradouro)
        {
            IWebElement logradouroTxt = driver.FindElement(By.Id("Logradouro"));
            logradouroTxt.SendKeys(logradouro);
        }

        [Given(@"eu preencho o campo numero(.*)")]
        public void GivenEuPreenchoOCampoNumero(string numero)
        {
            IWebElement numeroTxt = driver.FindElement(By.Id("Numero"));
            numeroTxt.SendKeys(numero);
        }

        [Given(@"eu preencho o campo bairro(.*)")]
        public void GivenEuPreenchoOCampoBairro(string bairro)
        {
            IWebElement bairroTxt = driver.FindElement(By.Id("Bairro"));
            bairroTxt.SendKeys(bairro);
        }

        [Given(@"eu preencho o campo complemento(.*)")]
        public void GivenEuPreenchoOCampoComplemento(string complemento)
        {
            IWebElement complementoTxt = driver.FindElement(By.Id("Complemento"));
            complementoTxt.SendKeys(complemento);
        }

        [Given(@"eu preencho o campo cep(.*)")]
        public void GivenEuPreenchoOCampoCep(string cep)
        {
            IWebElement cepTxt = driver.FindElement(By.Id("CEP"));
            cepTxt.SendKeys(cep);
            Thread.Sleep(2000);
        }

        [Given(@"eu preencho o campo uf (.*)")]
        public void GivenEuPreenchoOCampoUf(string uf)
        {
            var selectElement = new SelectElement(driver.FindElement(By.Name("estado")));
            selectElement.SelectByText("Mato Grosso do Sul");
            Thread.Sleep(2000);
        }

        [Given(@"eu preencho o campo municipio (.*)")]
        public void GivenEuPreenchoOCampoMunicipio(string municipio)
        {

            //IWebElement municipioTxt = driver.FindElement(By.Name("LocalidadeId"));
            //municipioTxt.Click();

            // var municipio = driver.FindElement(By.Name("LocalidadeId"));




            var selectElement = new SelectElement(driver.FindElement(By.Name("LocalidadeId")));
            selectElement.SelectByText("Água Clara");

            Thread.Sleep(2000);


        }

        [Given(@"eu preencho o campo cpf(.*)")]
        public void GivenEuPreenchoOCampoCpf(string cpf)
        {
            IWebElement cpfTxt = driver.FindElement(By.Id("CPF"));
            cpfTxt.SendKeys(cpf);
            _cpf = cpf;
        }

        [Given(@"eu preencho o campo senha (.*)")]
        public void GivenEuPreenchoOCampoSenha(string senha)
        {
            IWebElement senhaTxt = driver.FindElement(By.Id("Senha"));
            senhaTxt.SendKeys(senha);
            _senha = senha;
        }

        [Given(@"eu preencho o campo repetir (.*)")]
        public void GivenEuPreenchoOCampoRepetir(string repetir)
        {
            IWebElement repetirTxt = driver.FindElement(By.Id("ConfirmarSenha"));
            repetirTxt.SendKeys(repetir);
        }

        [Given(@"eu aceito o Termo de uso")]
        public void EuClicoNoTermoDeUso()
        {
            Console.Out.WriteLine("Termo deuso%¨%*(&*(¨%¨#$%¨&%¨$&*%¨¨&*%");
            driver.FindElement(By.Name("TermoCompromisso")).Click();
        }

        [Then(@"eu clico no botao Entrar")]
        public void WhenEuClicoNoBotaoEntrar()
        {


            // Console.Out.WriteLine("%¨%*(&*(¨%¨#$%¨&%¨$&*%¨¨&*%");
            //driver.FindElement(By.XPath("//*[@value='Cadastrar']")).Click();
            driver.FindElement(By.Id("btnAdicionar")).Click();
        }

        [Given(@"que estou na tela de login")]
        public void GivenQueEstouNaTelaDeLogin()
        {
            Given(@"que estou na página de autenticacao");
            When(string.Format("eu preencho o campo CPF com o valor {0}", _cpf));
            When(string.Format("preencha o campo Senha com o valor {0}", _senha));
            When(@"clico no botão Entrar");
            Then(@"vejo na tela (.*)");
        }

        [Given(@"que estou na tela de solicitação de acesso")]
        public void GivenQueEstouNaTelaDeSolicitacaoDeAcesso()
        {
            Given(@"que estou na página de solicitacao de acesso");
            Given(@"clico no botao de acesso");
            Given(@"clico em Solicitacao de acesso");
            Given(string.Format("preenchi o mesmo com dados válidos {0}", _cpf));
            Then(@"clico no botao salvar");
        }


    }


}
