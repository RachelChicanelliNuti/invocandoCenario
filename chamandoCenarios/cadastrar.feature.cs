﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace chamandoCenarios
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("cadastrar")]
    public partial class CadastrarFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "cadastrar.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "cadastrar", "\tComo usuario do sistema\r\n\tEu quero me registrar\r\n\tPara que eu possa acessar o si" +
                    "stema", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cadastrar Ususario")]
        [NUnit.Framework.CategoryAttribute("cadastroUsuario")]
        [NUnit.Framework.TestCaseAttribute("MAQ", "maqw45@mailinator.com", "06/12/1977", "27532063-7", "65999666917", "Av.Florais", "875", "Ribeirão", "Q.05", "78048-135", "Mato Grosso do Sul", "Água Clara", "231.842.588-40", "123456", "123456", null)]
        public virtual void CadastrarUsusario(
                    string nome, 
                    string email, 
                    string nascimento, 
                    string rg, 
                    string celular, 
                    string logradouro, 
                    string numero, 
                    string bairro, 
                    string complemento, 
                    string cep, 
                    string uf, 
                    string municipio, 
                    string cpf, 
                    string senha, 
                    string repetir, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "cadastroUsuario"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastrar Ususario", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("que estou na pagina de cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And(string.Format("eu preencho o campo nome {0}", nome), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And(string.Format("eu preencho o campo email {0}", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("eu preencho o campo nascimento {0}", nascimento), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And(string.Format("eu preencho o campo rg {0}", rg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And(string.Format("eu preencho o campo celular{0}", celular), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And(string.Format("eu preencho o campo logradouro{0}", logradouro), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And(string.Format("eu preencho o campo numero{0}", numero), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And(string.Format("eu preencho o campo bairro{0}", bairro), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And(string.Format("eu preencho o campo complemento{0}", complemento), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And(string.Format("eu preencho o campo cep{0}", cep), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And(string.Format("eu preencho o campo uf {0}", uf), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And(string.Format("eu preencho o campo municipio {0}", municipio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And(string.Format("eu preencho o campo cpf{0}", cpf), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And(string.Format("eu preencho o campo senha {0}", senha), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And(string.Format("eu preencho o campo repetir {0}", repetir), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("eu aceito o Termo de uso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("eu clico no botao Entrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.Given("que estou na tela de login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
