using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrimeSyloTeste.Page
{
    class LoginPage
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\Lenovo\Downloads\");

        public void abrirSite()
        {
            driver.Navigate().GoToUrl("localhost:3000");
        }

        public void fecharSite()
        {
            driver.Close();
        }

        public void clicarMenuLogin()
        {
            IWebElement menu_login = driver.FindElement(By.Id("id_login_index"));
            menu_login.Click();
        }

        public void inserirLogin()
        {
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("TesteTeste");
        }

        public void inserirSenha()
        {
            IWebElement senha = driver.FindElement(By.Id("senha"));
            senha.SendKeys("123456");
        }

        public void clicarlogin()
        {
            IWebElement btn_login = driver.FindElement(By.Id("btn_login"));
            btn_login.Click();
        }


        public void inserirLoginErrado()
        {
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("TesteErrado");
        }

        public void inserirSenhaErrada()
        {
            IWebElement senha = driver.FindElement(By.Id("senha"));
            senha.SendKeys("123");
        }

        public void clickEnter()
        {
            Actions enter = new Actions(driver);
            enter.SendKeys(Keys.Enter).Build().Perform();
        }

        public void verificarPerfil()
        {
            Thread.Sleep(8000);
            IWebElement ok_button = driver.FindElement(By.XPath("/html/body/div[5]/div/div[3]/button[1]"));
            Actions action = new Actions(driver);
            action.MoveToElement(ok_button).Click().Perform();
            Thread.Sleep(5000);
            String nomepag = driver.Url;
            Assert.AreEqual("http://localhost:3000/dashboard.html", nomepag);
        }

        public void verificarAviso()
        {
            Thread.Sleep(8000);
            IWebElement aviso = driver.FindElement(By.XPath("/html/body/div[5]/div/div[3]/button[1]"));
            Actions action = new Actions(driver);
            action.MoveToElement(aviso).Click().Perform();
            String nomepag = driver.Url;
            Assert.AreEqual("http://localhost:3000/login.html", nomepag);
        }




    }
}
