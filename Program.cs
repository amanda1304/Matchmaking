using System;
using System.Windows.Forms;

namespace Matchmaking
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pnlbase()); // Substitua LoginForm pelo nome correto do seu formulário
        }
    }
}
