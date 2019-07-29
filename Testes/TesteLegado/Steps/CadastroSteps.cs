using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ProjetoTesteCad
{
    [Binding]
    public class cadastroSteps
    {

        cadastroPage cadastroPage = new cadastroPage();
        

        [Given(@"Que estou no site institucional")]
        public void GivenQueEstouNoSiteInstitucional()
        {
            
            cadastroPage.AbrirSite();

        }

        [Given(@"acesso a página de cadastro")]
        public void GivenAcessoAPaginaDeCadastro()
        {
            cadastroPage.IrCadastro();
        }

        [Given(@"que estou na página de cadastro")]
        public void GivenQueEstouNaPaginaDeCadastro()
        {
            var paginaC = "http://localhost:3000/register.html";
            cadastroPage.VerificarPagina(paginaC);

        }

        [When(@"preencho todos os campos obrigatórios")]
        public void WhenPreenchoTodosOsCamposObrigatorios()
        {
            cadastroPage.PreencherDados();
        }

        [When(@"clico para registrar cadastro")]
        public void WhenClicoParaRegistrarCadastro()
        {
            cadastroPage.ClicarRegistrar();
        }





        [Then(@"o sistema deve mostrar uma mensagem de cadastro feito com sucesso")]
        public void ThenOSistemaDeveMostrarUmaMensagemDeCadastroFeitoComSucesso()
        {
            var paginaLogin = "http://localhost:3000/login.html";
           cadastroPage.TirarMensagem();
           cadastroPage.VerificarPagina(paginaLogin);
           cadastroPage.Fechar();

        }

        [When(@"Não preenchoo campo (.*)")]
        public void WhenNaoPreenchooCampoCNPJ(string campo)
        {
            cadastroPage.TirarCampo(campo);
        }


        [Then(@"o sistema deve mostrar uma mensagem de aviso invalido")]
        public void ThenOSistemaDeveMostrarUmaMensagemDeAvisoInvalido()
        {
            var mesmaPagina = "http://localhost:3000/register.html";
            cadastroPage.TirarMensagem();
            cadastroPage.VerificarPagina(mesmaPagina);
            cadastroPage.Fechar();
        }

    }
}
