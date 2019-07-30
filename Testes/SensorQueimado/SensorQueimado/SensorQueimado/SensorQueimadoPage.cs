using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SensorQueimado
{
    class SensorQueimadoPage
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\giuli\Desktop\");

        public void abrirWeb()
        {
            driver.Navigate().GoToUrl("localhost:3000/login.html");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        public void fecharDrive()
        {
            driver.Close();
        }

        public void logarUsuario()
        {
            driver.FindElement(By.Id("email")).SendKeys("TesteTeste");
            driver.FindElement(By.Id("senha")).SendKeys("123456");
            driver.FindElement(By.Id("btn_login")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[5]/div/div[3]/button[1]")).Click();
            Thread.Sleep(10000);
        }

        internal int verificarTemperatura(int silo, int indicador_queimado)

        {
            var cont = 0;
            for (int i = 0; i < 5; i++)
            {
                var temp_atual = driver.FindElement(By.Id("silo3_temp4")).GetAttribute("innerText");
                var umid_atual = driver.FindElement(By.Id("silo3_umid4")).GetAttribute("innerText");

                Console.WriteLine("A TEMPERATURA ATUAL É: " + temp_atual);
                Console.WriteLine("A UMIDADE ATUAL É: " + umid_atual);

                if (temp_atual == "0ºC" && umid_atual == "0%")
                {
                    Console.WriteLine("Contador" + i);
                    cont++;
                }
                else
                {
                    cont = 800;
                    //os dados estão =! 0
                }
                Thread.Sleep(5000);
            }
            return cont;

        }

        internal String verificarAlerta(int contador)
        {
            Thread.Sleep(3000);
            if(contador == 5)
            {
                string aviso = driver.FindElement(By.Id("swal2-content")).GetAttribute("innerText");
                return aviso;
                
            }
            else
            {
                Console.WriteLine("Não foi identificado nenhum sensor queimado!");
                return null;
            }

        }

        public string getUrl()
        {
            string url = driver.Url;
            return url;
        }
    }
}
