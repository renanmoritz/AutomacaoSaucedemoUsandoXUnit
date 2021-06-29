using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafioUsandoXUnit.PageObject
{
    public class Inventario
    {

        private IWebDriver navegador;
        private By btnAdicionarAoCarrinho;
        private By btnAcessarCarrinho;

        public Inventario(IWebDriver navegador)
        {
            this.navegador = navegador;
            btnAcessarCarrinho = By.Id("shopping_cart_container");
        }

        public void AdicionarProdutoAoCarrinho(string produto)
        {

            switch (produto)
            {

                case "Sauce Labs Backpack":
                    btnAdicionarAoCarrinho = By.Id("add-to-cart-sauce-labs-backpack");
                    break;

                case "Sauce Labs Bike Light":
                    btnAdicionarAoCarrinho = By.Id("add-to-cart-sauce-labs-bike-light");
                    break;

                case "Sauce Labs Bolt T-Shirt":
                    btnAdicionarAoCarrinho = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");
                    break;

                case "Sauce Labs Fleece Jacket":
                    btnAdicionarAoCarrinho = By.Id("add-to-cart-sauce-labs-fleece-jacket");
                    break;

                case "Sauce Labs Onesie":
                    btnAdicionarAoCarrinho = By.Id("add-to-cart-sauce-labs-onesie");
                    break;

                case "Test.allTheThings() T-Shirt (Red)":
                    btnAdicionarAoCarrinho = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");
                    break;
                default:
                    System.Console.WriteLine("Produto Inexistente.");
                    break;
            }

            navegador.FindElement(btnAdicionarAoCarrinho).Click();
        }

        public void AdicionarTodosOsProdutosAoCarrinho()
        {
            AdicionarProdutoAoCarrinho("Sauce Labs Backpack");
            AdicionarProdutoAoCarrinho("Sauce Labs Bike Light");
            AdicionarProdutoAoCarrinho("Sauce Labs Bolt T-Shirt");
            AdicionarProdutoAoCarrinho("Sauce Labs Fleece Jacket");
            AdicionarProdutoAoCarrinho("Sauce Labs Onesie");
            AdicionarProdutoAoCarrinho("Test.allTheThings() T-Shirt (Red)");
        }

        public void AcessarCarrinho()
        {
            navegador.FindElement(btnAcessarCarrinho).Click();
        }

    }
}
