﻿using NUnit.Framework;
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
            driver.Quit();
        }

        public void logarUsuario()
        {
            driver.FindElement(By.Id("email")).SendKeys("TesteTeste");
            driver.FindElement(By.Id("senha")).SendKeys("123456");
            driver.FindElement(By.Id("btn_login")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[5]/div/div[3]/button[1]")).Click();
            Thread.Sleep(8000);
        }

        public string GetTemperatura()
        {
            string temp = driver.FindElement(By.Id("silo3_temp1")).GetAttribute("innerText");
            return temp;
        }

        public string GetUmidade()
        {
            string umid = driver.FindElement(By.Id("silo3_umid1")).GetAttribute("innerText");
            return umid;
        }
       

        internal void verificarAlerta(int contador)
        {
            Thread.Sleep(3000);
            if(contador == 5)
            {
                IWebElement aviso = driver.FindElement(By.Id("swal2-content"));
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(ExpectedConditions.TextToBePresentInElement(
                    aviso, "Verifique seu sensor de nível 1 do sylo 2, pois pode estar queimado!"));
                Assert.Pass("Alerta encontrado!");
                
            }
            else
            {
                Assert.Fail("Não há indícios de que o sensor quemiou!");
            }

        }

        public string getUrl()
        {
            string url = driver.Url;
            return url;
        }

        static List<Medidor> medidores;
        public int VerificarControle()
        {
            var contador = 0;
            medidores = new List<Medidor>();

            for(int i = 0; i<5; i++)
            {
                string temperatura = GetTemperatura();
                string umidade = GetUmidade();
                medidores.Add(new Medidor(temperatura, umidade));
                Thread.Sleep(5000);
            }

            foreach(Medidor item in medidores)
            {
                Console.WriteLine(item.Umidade + " " + item.Temperatura);
                if(item.Temperatura == "0ºC" && item.Umidade == "0%")
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





    }
}
