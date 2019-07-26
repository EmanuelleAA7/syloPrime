using System;
using TechTalk.SpecFlow;

namespace Teste_Relatorios...
{
    [Binding]
    public class RelatorioSteps
    {
        [Given(@"que o usuario ja logou com seu login (.*) e sua senha (.*)")]
        public void GivenQueOUsuarioJaLogouComSeuLoginESuaSenha(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"já se encontra na pagina inicial")]
        public void GivenJaSeEncontraNaPaginaInicial(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu clico em relatório - vendas")]
        public void WhenEuClicoEmRelatorio_Vendas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"clico em Gerar Relatorio PDF")]
        public void WhenClicoEmGerarRelatorioPDF()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"clico em Gerar Relatorio Excel")]
        public void WhenClicoEmGerarRelatorioExcel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"eu clico em relatório - qualidade")]
        public void WhenEuClicoEmRelatorio_Qualidade()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"um dowload é feito pela página web")]
        public void ThenUmDowloadEFeitoPelaPaginaWeb()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"uma nova aba se abre com um documento em PDF")]
        public void ThenUmaNovaAbaSeAbreComUmDocumentoEmPDF()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
