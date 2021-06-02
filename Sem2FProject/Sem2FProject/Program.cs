using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2FProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            MessageBox.Show("I am working");
            MyWallet m = new MyWallet();
            MessageBox.Show(m.WalletIDGen());
            MyWallet n = new MyWallet();
            //n.DepositMoney(1000000);
            MessageBox.Show(""+n.WalletIDGen());
            MessageBox.Show("Code is ending");
            Application.Run();
        }
    }
}
