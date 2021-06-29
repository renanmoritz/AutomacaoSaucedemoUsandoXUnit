using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjetoDesafioUsandoXUnit.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafioUsandoXUnit.Fixtures
{
    public class FixtureDeTeste : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        //Setup
        public FixtureDeTeste()
        {
            Driver = new ChromeDriver(AuxiliaresDosTestes.PastaDoExecutavel);

        }

        //TearDown
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
