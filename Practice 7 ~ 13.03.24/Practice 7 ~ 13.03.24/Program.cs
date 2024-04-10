using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7___13._03._24
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public Dictionary<string, Auto> AutoDict = new Dictionary<string, Auto>(){
            {"Газель", new Gazel()},
            {"ЗИЛ", new ZIL() },
            {"МАЗ", new MAZ() },
            {"Scania", new Scania() },
            {"Volvo", new Volvo() }
        };
    }
    
}
