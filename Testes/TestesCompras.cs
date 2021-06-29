using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjetoDesafioUsandoXUnit.Fixtures;
using ProjetoDesafioUsandoXUnit.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetoDesafioUsandoXUnit.Tests

{
    [Collection("Fixtures")]
    public class TestesCompras
    {
        private IWebDriver navegador;

        public TestesCompras(FixtureDeTeste fix)
        {
            navegador = fix.Driver;
        }

        [Fact]
        public void RealizarCompraCompletaComDoisProdutosDeveMostrarTelaAgradecimento()
        {
            var paginaLogin = new Login(navegador);
            paginaLogin.RealizarLoginValido();

            var paginaInventario = new Inventario(navegador);

            paginaInventario.AdicionarProdutoAoCarrinho("Sauce Labs Backpack");
            paginaInventario.AdicionarProdutoAoCarrinho("Sauce Labs Bike Light");
            paginaInventario.AcessarCarrinho();

            var paginaCarrinho = new Carrinho(navegador);
            paginaCarrinho.IrParaCheckout();

            var paginaCheckout = new Checkout(navegador);
            paginaCheckout.PreencherFormularioCheckout("Renan", "Moritz", "00000-000");
            paginaCheckout.EnviarFormularioCheckout();
            paginaCheckout.FinalizarCheckout();

            Assert.Contains("THANK YOU FOR YOUR ORDER", navegador.PageSource);
        }

        [Fact]
        public void RealizarCompraCompletaComTodosOsProdutosDeveValidarValorFinal()
        {
            var paginaLogin = new Login(navegador);
            paginaLogin.RealizarLoginValido();

            var paginaInventario = new Inventario(navegador);

            paginaInventario.AdicionarTodosOsProdutosAoCarrinho();
            paginaInventario.AcessarCarrinho();

            var paginaCarrinho = new Carrinho(navegador);
            paginaCarrinho.IrParaCheckout();

            var paginaCheckout = new Checkout(navegador);
            paginaCheckout.PreencherFormularioCheckout("Renan", "Moritz", "00000-000");
            paginaCheckout.EnviarFormularioCheckout();


            string valor = navegador.FindElement(By.ClassName("summary_total_label")).Text;
            Assert.Equal("Total: $140.34", valor);

            paginaCheckout.FinalizarCheckout();

        }
    }
}
