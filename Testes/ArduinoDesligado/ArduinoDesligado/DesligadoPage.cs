using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;

namespace ArduinoDesligado
{
    class DesligadoPage
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\giuli\Desktop");

        internal void LogarUsuario()
        {
            driver.Navigate().GoToUrl("localhost:3000/login.html");
            driver.Manage().Window.Maximize();
            //Continuar login do Usuário.
        }

        public int CompararTempo()
        {
            string horario = GetTime();
            var contador = 0;
            for(int i = 0; i<3; i++)
            {
                //Aguarda a leitura mudar
                Thread.Sleep(5000);
                string horario_comparar = GetTime();
                if(horario == horario_comparar)
                {
                    contador++;
                }
                else
                {
                    contador--;
                }
            }
            return contador;
        }

        internal void VerificarConexao()
        {
            var cont = CompararTempo();
            if(cont == 3)
            {
                Console.WriteLine("Alerta deve Aparecer!");
            }
            else
            {
                Console.WriteLine("Alerta não deve aparecer!");
            }
        }

        internal string VerificarAlerta()
        {
            String alerta = driver.FindElement(By.Id("")).GetAttribute("innerText");
            return alerta;
        }



        public String GetTime()
        {
            var json = new WebClient().DownloadString("http://syloprime.azurewebsites.net/leituras/temporealmedia");
            Convert.ToString(json);
            string horario = json.Substring(42, 8);
            return horario;
        }
    }
}
