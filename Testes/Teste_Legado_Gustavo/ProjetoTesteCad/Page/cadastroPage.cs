
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class cadastroPage
{
   
    IWebDriver driver = new ChromeDriver(@"C:\Users\Lenovo\Downloads\");

    public void AbrirSite()
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("localhost:3000/");
    }

    public void IrCadastro()
    {
        driver.FindElement(By.Id("id_cadastro_index")).Click();
        
    }
    public void PreencherDados()
    {
        driver.FindElement(By.Id("nome")).SendKeys("Teste2");
        driver.FindElement(By.Id("sobrenome")).SendKeys("Teste2");
        driver.FindElement(By.Id("data")).SendKeys("29/07/2019");
        driver.FindElement(By.Id("cnpj")).SendKeys("222222222222");
        driver.FindElement(By.Id("telefone")).SendKeys("99999999999");
        driver.FindElement(By.Id("cidade")).SendKeys("São Paulo");
        driver.FindElement(By.Id("cep")).SendKeys("9988777");
        driver.FindElement(By.Id("email")).SendKeys("Teste2@teste.com");
        driver.FindElement(By.Id("nome_U")).SendKeys("Teste2");
        driver.FindElement(By.Id("senha")).SendKeys("12345");
        driver.FindElement(By.Id("conf_senha")).SendKeys("12345");

        var selectElement = new SelectElement(driver.FindElement(By.Id("estado")));
        selectElement.SelectByText("São Paulo");

    }

    public void ClicarRegistrar()
    {
        driver.FindElement(By.Id("id_registrar")).Click();
    }

    public Boolean VerificarPagina(string pagina)
    {
        Thread.Sleep(3000);
        string paginaEsta = driver.Url;
        if(pagina == paginaEsta)
        {
            return true;
        }
        else
        {
            Fechar();
            return false;

        }
    }
    public void TirarMensagem()
    {
        Thread.Sleep(5000);
        Actions action = new Actions(driver);
        action.SendKeys(Keys.Enter).Click().Perform();
        
    }

    public void TirarCampo(string campoTirar)
    {

        driver.FindElement(By.Id(campoTirar)).Clear();
            
    }

    public void Fechar()
    {
        driver.Close();
    }
}