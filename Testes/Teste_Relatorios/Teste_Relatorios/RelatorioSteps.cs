using System;
using TechTalk.SpecFlow;

namespace Teste_Relatorios
{
    [Binding]
    public class RelatorioSteps
    {
        RelatorioPage relatoriopage = new RelatorioPage();

        [BeforeScenario]
        public void BeforeScenario()
        {
            relatoriopage.openBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            relatoriopage.closeBrowser();
        }



        [Given(@"que o usuario ja logou com seu login e sua senha")]
        public void GivenQueOUsuarioJaLogouComSeuLoginESuaSenha()
        {
            relatoriopage.logarUsuario();
        }
        
        [Given(@"já se encontra na pagina inicial")]
        public void GivenJaSeEncontraNaPaginaInicial()
        {
            relatoriopage.validarPagina();
        }
        
        [When(@"eu clico em relatório - vendas")]
        public void WhenEuClicoEmRelatorio_Vendas()
        {
            relatoriopage.clicarVendas();
        }
        
        [When(@"clico em Gerar Relatorio PDF")]
        public void WhenClicoEmGerarRelatorioPDF()
        {
            relatoriopage.gerarPdfVendas();
        }
        
        [When(@"clico em Gerar Relatorio Excel")]
        public void WhenClicoEmGerarRelatorioExcel()
        {
            relatoriopage.gerarExcelVendas();
        }

        [When(@"eu clico em relatório - qualidade")]
        public void WhenEuClicoEmRelatorio_Qualidade()
        {
            relatoriopage.clicarQualidade();
        }

        [When(@"clico em Gerar Relatorio PDF qualidade")]
        public void WhenClicoEmGerarRelatorioPDFQualidade()
        {
            relatoriopage.gerarPdfQualidade();
        }

        [When(@"clico em Gerar Relatorio Excel qualidade")]
        public void WhenClicoEmGerarRelatorioExcelQualidade()
        {
            relatoriopage.gerarExcelQualidade();
        }

        [Then(@"um dowload é feito pela página web")]
        public void ThenUmDowloadEFeitoPelaPaginaWeb()
        {
            string name = @"C:\Users\giuli\Downloads\RelatorioVendas.xlsx";
            relatoriopage.verificarDowload(name);
        }

        [Then(@"um dowload é feito pela página")]
        public void ThenUmDowloadEFeitoPelaPagina()
        {
            string name = @"C:\Users\giuli\Downloads\RelatorioQualidade.xlsx";
            relatoriopage.verificarDowload(name);
        }

        [Then(@"uma nova aba se abre com um documento em PDF")]
        public void ThenUmaNovaAbaSeAbreComUmDocumentoEmPDF()
        {
            //O selenium não tem ferramentas que possam identificar uma página 
            //de impressora aberta
        }
    }
}
