using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

using System;
using TechTalk.SpecFlow;

namespace PrimeSyloTeste.Steps
{
    [Binding]
    public class SimuladorSteps
    {
        Pages.SimuladorPage simuladorpage = new Pages.SimuladorPage();

        [BeforeScenario]
        public void Before()
        {
            simuladorpage.abrirSite();
        }

        [AfterScenario]
        public void After()
        {
            simuladorpage.fecharSite();
        }


        [Given(@"clico em menu >> simulação")]
        public void GivenClicoNoMenuSimulacao()
        {
            simuladorpage.clicarMenuSimulacao();
            Console.WriteLine("Menu >> Simulacão sucesso");
        }
        
        [Given(@"clico em propriedade")]
        public void GivenClicoEmEmPropriedade()
        {
            simuladorpage.clicarBtnPropriedade();
            Console.WriteLine("Clicado em 'Propriedade'");
        }
        
        [Given(@"clico em através de terceiros")]
        public void GivenClicoEmAtravesDeTerceiros()
        {
            simuladorpage.clicarBtnTerceiros();
        }

        [When(@"preencho os campos requeridos")]
        public void WhwnPreenchoOsCampos()
        {
            simuladorpage.preencherCamposPropriedade();
        }
                 
        
        [When(@"clico em calcular propriedade")]
        public void WhenClicoEm()
        {
            simuladorpage.btnPropriedade();
        }

        [When(@"clico em calcular terceiros")]
        public void WhenClicoEmTerceiros()
        {
            simuladorpage.btnTerceiros();
        }

        [When(@"preencho o campo (.*) com um valor nulo")]
        public void WhenPreenchoOCampoComUmValorNulo(string campo)
        {
            simuladorpage.deixarCampoNulo(campo);
        }

        [When(@"preencho os campos dos terceiros")]
        public void WhenPreenchoOsCamposDosTerceiros()
        {
            simuladorpage.preencherCamposTerceiros();
        }



        [Then(@"os resultados terceiros aparecem na tela")]
        public void ThenOsResultadosAparecemNaTela()
        {
            var id_resultado = "tag_lucro_atual_c";
            var resultado = simuladorpage.verResultado(id_resultado);
            Assert.AreEqual("R$8475", resultado);
            Console.WriteLine(" * O resultao é: " + resultado);
        }

        [Then(@"os resultados propriedade aparecem na tela")]
        public void ThenOsResultadosAparecemNaTela2()
        {
            var id_resultado = "tag_lucro_atual_p";
            var resultado = simuladorpage.verResultado(id_resultado);
            Assert.AreEqual("R$395000", resultado);
            Console.WriteLine(" * O resultao é: " + resultado);
        }


        [Then(@"o sistema avisa que estão faltando dados")]
        public void ThenOSistemaAvisaQueEstaoFaltandoDados()
        {
            simuladorpage.verificarAlerta();
        }
    }
}
