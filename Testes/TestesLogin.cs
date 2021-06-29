using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjetoDesafioUsandoXUnit.Fixtures;
using ProjetoDesafioUsandoXUnit.PageObject;
using Xunit;

namespace ProjetoDesafioUsandoXUnit
{
    [Collection("Fixtures")]
    public class TestesLogin
    {
        private IWebDriver navegador;

        public TestesLogin(FixtureDeTeste fix)
        {
            navegador = fix.Driver;
        }

        [Fact]
        public void RealizarLoginComUsuarioBloqueadoDeveApresentarMensagemDeBloqueio()
        {
            var paginaLogin = new Login(navegador);
            paginaLogin.RealizarLoginUsuarioBloqueado();

            Assert.Contains("Epic sadface: Sorry, this user has been locked out.", navegador.PageSource);
        }

        [Fact]
        public void RealizarLoginComUsuarioValidoDeveApresentarTelaDeProdutos()
        {

            var paginaLogin = new Login(navegador);

            paginaLogin.RealizarLoginValido();
            Assert.Contains("Products", navegador.PageSource);
        }

    }



}
