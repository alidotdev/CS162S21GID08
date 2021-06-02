using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2FProject
{
    public partial class CancelFlight : Form
    {
        public CancelFlight()
        {
            InitializeComponent();
            label3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label3.Hide();
        }
    }
}
