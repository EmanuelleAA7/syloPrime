using System;
using TechTalk.SpecFlow;

namespace ProjetoTesteCad
{
    [Binding]
    public class InteracaoTelasSteps
    {

        InteracaoTelasPage interacaoPage = new InteracaoTelasPage();




        [Given(@"que estou na página inicial do site institucional")]
        public void GivenQueEstouNaPaginaInicialDoSiteInstitucional()
        {

            interacaoPage.AbrirSite();
        }



        [Given(@"que efetuei o login no sistema")]
        public void GivenQueEfetueiOLoginNoSistema()
        {
            interacaoPage.AbrirLogin();
            interacaoPage.Logar();
            interacaoPage.TirarMensagem();
        }

        [When(@"entao clico (.*)")]
        public void WhenEntaoClico(string opcao)
        {
            interacaoPage.ClicarOp(opcao);
        }

        [Given(@"entao clico (.*)")]
        public void GivenEntaoClico(string pagina)
        {
            interacaoPage.ClicarPaginas(pagina);
        }


        [When(@"Acesso a pagina de cadastro")]
        public void WhenAcessoAPaginaDeCadastro()
        {
            interacaoPage.ClicarCadastro();
        }


        [When(@"sou direcionado para a página de cadastro")]
        public void WhenSouDirecionadoParaAPaginaDeCadastro()
        {
            string pag = "http://localhost:3000/register.html";
            interacaoPage.VerificarPagina(pag);
        }

        [When(@"clico que ja possuo uma conta")]
        public void WhenClicoQueJaPossuoUmaConta()
        {
            interacaoPage.ClicarJaPossuiConta();
        }

        [When(@"sou redirecionado para a página de login")]
        public void WhenSouRedirecionadoParaAPaginaDeLogin()
        {
            string pagina = "http://localhost:3000/login.html";
            interacaoPage.VerificarPagina(pagina);
        }

        [Then(@"devo ser direcionado para página (.*)")]
        public void ThenDevoSerDirecionadoParaPagina(string pagina)
        {

            var parte = pagina.Substring(3);
            Console.WriteLine(parte);
            string pagVerif = "http://localhost:3000/" + parte + ".html";
            interacaoPage.VerificarPagina(pagVerif); ;
        }


        [Then(@"a tela deve ir até a parte da (.*)")]
        public void ThenATelaDeveIrAteAParteDa(string opcao)
        {
            interacaoPage.VerificarTela(opcao);
            interacaoPage.Fechar();
        }


        [Then(@"Faço o login com um usuário existente")]
        public void ThenFacoOLoginComUmUsuarioExistente()
        {
            interacaoPage.Logar();
        }

        [Then(@"sou direcionado para a dashboard")]
        public void ThenSouDirecionadoParaADashboard()
        {

            interacaoPage.TirarMensagem();
            string pagina = "http://localhost:3000/dashboard.html";
            interacaoPage.VerificarPagina(pagina);
            interacaoPage.Fechar();

        }
        [Then(@"saio do sistema")]
        public void ThenSaioDoSistema()
        {
            interacaoPage.Deslogar();
            interacaoPage.Fechar();

        }

    }
}
