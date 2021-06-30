using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafioUsandoXUnit.PageObject
{
    public class Checkout
    {
        private IWebDriver navegador;
        private By btnCancelarCheckout;
        private By btnContinuarCheckout;
        private By btnFinalizarCheckout;
        private By inserirNome;
        private By inserirSobrenome;
        private By inserirCodigoPostal;
        private By valorTotal;

        public Checkout(IWebDriver navegador)
        {
            this.navegador = navegador;
            btnCancelarCheckout = By.Id("Cancel");
            btnContinuarCheckout = By.Id("continue");
            btnFinalizarCheckout = By.Id("finish");

            inserirNome = By.Id("first-name");
            inserirSobrenome = By.Id("last-name");
            inserirCodigoPostal = By.Id("postal-code");

            valorTotal = By.ClassName("summary_total_label");

        }

        public void PreencherFormularioCheckout(string nome, string sobrenome, string codigoPostal)
        {
            navegador.FindElement(inserirNome).SendKeys(nome);
            navegador.FindElement(inserirSobrenome).SendKeys(sobrenome);
            navegador.FindElement(inserirCodigoPostal).SendKeys(codigoPostal);

        }

        public void EnviarFormularioCheckout()
        {
            navegador.FindElement(btnContinuarCheckout).Click();
        }

        public void FinalizarCheckout()
        {
            navegador.FindElement(btnFinalizarCheckout).Click();
        }

        public void CancelarCheckout()
        {
            navegador.FindElement(btnCancelarCheckout).Click();
        }

        public void ValorTotal()
        {
            navegador.FindElement(valorTotal);
        }

    }
}
