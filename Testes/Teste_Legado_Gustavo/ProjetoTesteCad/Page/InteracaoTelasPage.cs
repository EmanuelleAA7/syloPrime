using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class InteracaoTelasPage
{
    
        IWebDriver driver = new ChromeDriver(@"C:/Users/Lenovo/Downloads/");

    public void AbrirSite()
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("localhost:3000/");

    }

    public void ClicarOp(string opcao)
    {
        Thread.Sleep(2000);
        driver.FindElement(By.Id(opcao)).Click();
        
       
    }

    public void AbrirLogin()
    {
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("localhost:3000/login.html");
    }

    public void ClicarPaginas(string pagina)
    {
        driver.FindElement(By.Id(pagina)).Click();
    }

    public void VerificarTela(string opcao)
    {
        Thread.Sleep(3000);
        string classe = driver.FindElement(By.Id(opcao)).GetAttribute("class");
        Console.WriteLine(classe);
        Assert.AreEqual("nav-link js-scroll-trigger active", classe);
        
    }

    public void ClicarRegistrar()
    {
        driver.FindElement(By.Id("id_registrar")).Click();
    }

    public void ClicarCadastro()
    {
        driver.FindElement(By.Id("id_cadastro_index")).Click();
    }

    public Boolean VerificarPagina(string pagina)
    {
        Thread.Sleep(3000);
        if (pagina == driver.Url)
        {
            return true;
        }
        else
        {
            Assert.Fail("Não está na pagina certa");
            Fechar();
            return false;

        }
    }
    public void Fechar()
    {
        driver.Close();
        
    }

    public void ClicarJaPossuiConta()
    {
        driver.FindElement(By.Id("id_conta_existente")).Click();
    }

    public void Logar()
    {
        Thread.Sleep(2000);
        driver.FindElement(By.Id("email")).SendKeys("teste@gmail.com");
        driver.FindElement(By.Id("senha")).SendKeys("123456");
        driver.FindElement(By.Id("btn_login")).Click();
        
  
    }


   

    public void TirarMensagem()
    {
        Thread.Sleep(6000);
        Actions action = new Actions(driver);
        action.SendKeys(Keys.Enter).Click().Perform();
    }

    public void Deslogar()
    {
        //driver.FindElement(By.Id("userDropdown")).Click();
        //driver.FindElement(By.Id("userDropdown")).Click();

    }
}