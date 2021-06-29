using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafioUsandoXUnit.PageObject
{
    public class Login
    {
        private IWebDriver navegador;
        private By byInserirLogin;
        private By byInserirSenha;
        private By byBotaoLogin;

        public Login(IWebDriver navegador)
        {
            this.navegador = navegador;
            byInserirLogin = By.Id("user-name");
            byInserirSenha = By.Id("password");
            byBotaoLogin = By.Id("login-button");
        }

        public void Visitar()
        {
            navegador.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void PreencherFormularioLogin(string usuario, string senha)
        {
            navegador.FindElement(byInserirLogin).SendKeys(usuario);
            navegador.FindElement(byInserirSenha).SendKeys(senha);
        }

        public void SubmeterFormulariologin()
        {
            navegador.FindElement(byBotaoLogin).Submit();
        }

        public void RealizarLoginValido()
        {
            Visitar();
            PreencherFormularioLogin("standard_user", "secret_sauce");
            SubmeterFormulariologin();
        }

        public void RealizarLoginUsuarioBloqueado()
        {
            Visitar();
            PreencherFormularioLogin("locked_out_user", "secret_sauce");
            SubmeterFormulariologin();
        }
        public void RealizarLoginUsuarioComProblema()
        {
            Visitar();
            PreencherFormularioLogin("problem_user", "secret_sauce");
            SubmeterFormulariologin();
        }
        public void RealizarLoginUsuarioComProblemaPerformance()
        {
            Visitar();
            PreencherFormularioLogin("performance_glitch_user", "secret_sauce");
            SubmeterFormulariologin();
        }


    }
}
