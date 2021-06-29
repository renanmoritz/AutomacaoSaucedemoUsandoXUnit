using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ProjetoDesafioUsandoXUnit.Helpers
{
    public static class AuxiliaresDosTestes
    {
        public static string PastaDoExecutavel => Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().Location);
    }
}
