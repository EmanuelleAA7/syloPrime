using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ArduinoDesligado
{
    [Binding]
    public class SensorDesligadoSteps
    {
        DesligadoPage des = new DesligadoPage();

        [Given(@"o usuario já está logado")]
        public void GivenOUsuarioJaEstaLogado()
        {
            des.LogarUsuario();
        }
        
        [Given(@"seu arduíno é desonectado")]
        public void GivenSeuArduinoEDesonectado()
        {
            des.VerificarConexao();
        }
        
        [Then(@"Um alerta aparece na tela")]
        public void ThenUmAlertaApareceNaTela()
        {
            string alerta = des.VerificarAlerta();
            Assert.AreEqual("", alerta);
        }
    }
}
