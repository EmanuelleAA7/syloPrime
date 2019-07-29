using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrimeSyloTeste.Page
{
    class SimuladorPage
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\Lenovo\Downloads\");

        public void abrirSite()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("localhost:3000");
        }

        public void fecharSite()
        {
            driver.Close();
        }


        public void clicarMenuSimulacao()
        {
            
            IWebElement menu_simulacao = driver.FindElement(By.Id("id_simula_index"));
            menu_simulacao.Click();
        }

        public void clicarBtnPropriedade()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("btnPropriedade")).Click();
           
        }

        public void clicarBtnTerceiros()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("btnTerceiros")).Click();


        }

        internal void preencherCamposPropriedade()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("valor_saca_p_id")).SendKeys("500");
            driver.FindElement(By.Id("qt_sacas_p_id")).SendKeys("1000");
            driver.FindElement(By.Id("desperdicio_porcentagem_id")).SendKeys("20");
            driver.FindElement(By.Id("preco_mao_de_obra_p_id")).SendKeys("5000");
            
        }

        public void btnPropriedade()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='propriedade']/form/div[9]/button")).Click();
        }


        internal void deixarCampoNulo(string campo_nulo)
        {
            driver.FindElement(By.Id(campo_nulo)).Clear();
        }

        public void btnTerceiros()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='terceiros']/form/div[7]/button")).Click();
        }

        internal void preencherCamposTerceiros()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("qt_sacas_c_id")).SendKeys("1000");
            driver.FindElement(By.Id("preco_frete_id")).SendKeys("25");
            driver.FindElement(By.Id("preco_mao_de_obra_c_id")).SendKeys("4000");
            
        }


        public string verResultado(string id_resultado)
        {
            //Resultado diferente do que o esperado!!!
            Thread.Sleep(1000);
            IWebElement elemento = driver.FindElement(By.Id(id_resultado));
            String resultado = elemento.Text;
            return resultado;
        }


        public void verificarAlerta()
        {
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            
        }
    }
}
