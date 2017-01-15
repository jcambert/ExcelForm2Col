using System;
using System.Windows.Forms;
using Ninject;
namespace ExcelForm2Col
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var ikernel=Kernel.Load();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ikernel.Get<Main>());
        }

        
    }
}
