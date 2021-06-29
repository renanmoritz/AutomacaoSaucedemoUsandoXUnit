using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafioUsandoXUnit.PageObject
{
    public class Carrinho
    {
        private IWebDriver navegador;
        private By btnCheckout;
        private By btnContinuarComprando;
        private By btnRemoverProdutoCarrinho;


        public Carrinho(IWebDriver navegador)
        {
            this.navegador = navegador;
            btnCheckout = By.Id("checkout");
            btnContinuarComprando = By.Id("continue-shopping");
        }

        public void IrParaCheckout()
        {
            navegador.FindElement(btnCheckout).Click();
        }

        public void VoltarParaInventario()
        {
            navegador.FindElement(btnContinuarComprando).Click();
        }

        public void RemoverProdutoDoCarrinho(string produto)
        {

            switch (produto)
            {

                case "Sauce Labs Backpack":
                    btnRemoverProdutoCarrinho = By.Id("remove-sauce-labs-backpack");
                    break;

                case "Sauce Labs Bike Light":
                    btnRemoverProdutoCarrinho = By.Id("remove-sauce-labs-bike-light");
                    break;

                case "Sauce Labs Bolt T-Shirt":
                    btnRemoverProdutoCarrinho = By.Id("remove-sauce-labs-bolt-t-shirt");
                    break;

                case "Sauce Labs Fleece Jacket":
                    btnRemoverProdutoCarrinho = By.Id("remove-sauce-labs-fleece-jacket");
                    break;

                case "Sauce Labs Onesie":
                    btnRemoverProdutoCarrinho = By.Id("remove-sauce-labs-onesie");
                    break;

                case "Test.allTheThings() T-Shirt (Red)":
                    btnRemoverProdutoCarrinho = By.Id("remove-test.allthethings()-t-shirt-(red)");
                    break;
                default:
                    break;
            }

            navegador.FindElement(btnRemoverProdutoCarrinho).Click();
        }

        public void RemoverTodosProdutosDoCarrinho()
        {
            RemoverProdutoDoCarrinho("Sauce Labs Backpack");
            RemoverProdutoDoCarrinho("Sauce Labs Bike Light");
            RemoverProdutoDoCarrinho("Sauce Labs Bolt T-Shirt");
            RemoverProdutoDoCarrinho("Sauce Labs Fleece Jacket");
            RemoverProdutoDoCarrinho("Sauce Labs Onesie");
            RemoverProdutoDoCarrinho("Test.allTheThings() T-Shirt (Red)");
        }

    }
}
