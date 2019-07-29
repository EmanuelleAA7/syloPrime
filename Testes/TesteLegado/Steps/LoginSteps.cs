using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using PrimeSyloTeste.Page;
using System;
using TechTalk.SpecFlow;

namespace PrimeSyloTeste.Steps
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginpage = new LoginPage();
        

        //[BeforeScenario]
        public void Before()
        {
            loginpage.abrirSite();
        }

        [AfterScenario]
        public void After()
        {
            loginpage.fecharSite();
        }


        [Given(@"que estou no site institucional")]
        public void GivenQueEstouNoSiteInstitucional()
        {
            loginpage.abrirSite();
        }
        
        [Given(@"acessei o site >> Login")]
        public void GivenAcesseiOSiteLogin()
        {
            loginpage.clicarMenuLogin();
        }
        
        [When(@"inseri meu login")]
        public void WhenInseriMeu()
        {
            loginpage.inserirLogin();
        }
        
        [When(@"inseri minha senha")]
        public void WhenInseriMinha()
        {
            loginpage.inserirSenha();
        }
        
        [When(@"clico em Login")]
        public void WhenClicoEmLogin()
        {
            loginpage.clicarlogin();        
        }
        
        [When(@"inseri meu login incorreto")]
        public void WhenInseriMeuLoginIncorreto()
        {
            loginpage.inserirLoginErrado();
        }
        
        [When(@"inseri minha senha incorreta")]
        public void WhenInseriMinhaSenhaIncorreta()
        {
            loginpage.inserirSenhaErrada();
        }
        
        [Then(@"a mensagem de sucesso aparece na tela")]
        public void ThenAMensagemDeApareceNaTela()
        {
            //problemas para confirmar!!
            loginpage.verificarPerfil();
        }
        
        [Then(@"o site alerta e-mail inválido")]
        public void ThenOSiteAlertaE_MailInvalido()
        {
            loginpage.verificarAviso();
        }
        
        [Then(@"o site alerta senha inválida")]
        public void ThenOSiteAlertaSenhaInvalida()
        {
            loginpage.verificarAviso();
        }
    }
}
