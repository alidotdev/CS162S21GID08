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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelFlightLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
