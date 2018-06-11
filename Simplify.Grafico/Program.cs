using Simplify.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplify.Grafico
{
    public static class Program
    {
        public static Gerenciador Gerenciador = new Gerenciador();

        [STAThread]
        static void Main()
        {
            /*Abrindo tela de login*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaLogin());
        }
    }
}
