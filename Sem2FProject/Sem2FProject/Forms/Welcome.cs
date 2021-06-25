using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading;

namespace Sem2FProject
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            //MessageBox.Show("I am in Welcome form");
            //new Login().Show();
        }
        public void next()
        {
            progressBar2.Value = 70;
            Thread.Sleep(2000);
            progressBar2.Value = 80;
            Thread.Sleep(1000);
            progressBar2.Value = 95;
            Thread.Sleep(2000);
            progressBar2.Value = 100;
            Thread.Sleep(1000);
            this.Hide();
            new Login().Show();
        }
        private void Welcome_MouseMove(object sender, MouseEventArgs e)
        {
            next();
        }

       
    }
}
