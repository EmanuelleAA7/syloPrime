using Nest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Teste_Relatorios
{
    class RelatorioPage
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\giuli\Desktop\");

        public void openBrowser()
        {
            driver.Navigate().GoToUrl("localhost:3000");
            driver.Manage().Window.Maximize();
        }

        public void closeBrowser()
        {
            driver.Close();
        }

        internal void logarUsuario()
        {
            driver.FindElement(By.Id("id_login_index")).Click();
            driver.FindElement(By.Id("email")).SendKeys("TesteTeste");
            driver.FindElement(By.Id("senha")).SendKeys("123456");
            driver.FindElement(By.Id("btn_login")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[5]/div/div[3]/button[1]")).Click();
        }

        internal void validarPagina()
        {
            var perfil = driver.Url;
            Assert.AreEqual("http://localhost:3000/dashboard.html", perfil);
        }

        internal void gerarPdfVendas()
        {
            driver.FindElement(By.Id("id_print_pdf2"));
        }

        internal void gerarPdfQualidade()
        {
            driver.FindElement(By.Id("id_print_pdf"));
        }

        internal void clicarVendas()
        {
            driver.FindElement(By.XPath("//*[@id='accordionSidebar']/li[3]/a")).Click();
        }

        internal void gerarExcelVendas()
        {
            driver.FindElement(By.Id("button-b")).Click();
            Thread.Sleep(3000);
        }

        internal void gerarExcelQualidade()
        {
            driver.FindElement(By.Id("button-a")).Click();
            Thread.Sleep(3000);
        }


        internal void clicarQualidade()
        {
            driver.FindElement(By.XPath("//*[@id='accordionSidebar']/li[4]/a")).Click();
        }

        internal void verificarDowload(string name)
        {
            Thread.Sleep(2000);
            string path = @"C:\Users\giuli\Downloads";
            if(Directory.Exists(path))
            {
                bool result = (File.Exists(name));
                if(result == true)
                {
                    Assert.Pass("Arquivo baixado e existente!");
                }
                else
                {
                    Assert.Fail("O arquivo não foi baixado");
                }
            }
           else
           {
                Assert.Fail("O diretório não existe");
           }
        }


    }
}

