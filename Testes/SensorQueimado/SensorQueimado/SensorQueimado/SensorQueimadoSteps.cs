using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SensorQueimado
{
    [Binding]
    public class SensorQueimadoSteps
    {

        SensorQueimadoPage sensor = new SensorQueimadoPage();
        public int contador = 0; 

        [Given(@"que o usuario já está logado")]
        public void GivenQueOUsuarioJaEstaLogado()
        {
            sensor.abrirWeb();
            //sensor.logarUsuario()
        }
        
        [Given(@"esta em sua página de dashboards")]
        public void GivenEstaEmSuaPaginaDeDashboards()
        {
            sensor.logarUsuario();
        }
        
        [Given(@"que os dashboards do silo (.*) estejam com temperatura (.*)")]
        public void GivenQueOsDashboardsDoSiloEstejamComTemperatura(int silo, int p1)
        {
            contador = sensor.VerificarControle(); ;
            Console.WriteLine("VALOR DO CONTADOR = " + contador);
        }
        
        [Given(@"o silo (.*) também acusa umidade (.*)")]
        public void GivenOSiloTambemAcusaUmidade(int p0, int p1)
        {
          //Verificado no Steo Acima
        }
        
        [When(@"(.*) segundos se passam")]
        public void WhenSegundosSePassam(int p0)
        {
           //Verificado no Steo Acima
        }
        
        [Then(@"um alerta aparece na tela")]
        public void ThenUmAlertaApareceNaTela()
        {
            Assert.AreEqual(5, contador);
            String aviso = sensor.verificarAlerta(contador);
            Assert.AreEqual("Verifique seus sensores, algum pode estar queimado !", aviso);
            Console.WriteLine(aviso);
            sensor.fecharDrive();
        }
    }
}
