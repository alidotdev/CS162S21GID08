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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BookFlight().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CancelFlightTicket().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateFlightTicket().Show();
        }
    }
}
