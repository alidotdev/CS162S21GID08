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

        private void ProfileNotification()
        {
            DialogResult res = MessageBox.Show("Please complete your Profile details to use this System!", "First Time Loading", MessageBoxButtons.OK);
            if (res == DialogResult.OK)
            {
                this.Hide();
                new AdminProfile().Show();
            }
        }

        private void ProfileLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            new AdminProfile().Show();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            ProfileLabel_Click(sender, e);
        }

        private void AddFlightLabel_Click(object sender, EventArgs e)
        {
            if (Admin.GetInstance().Age != 0)
            {
                this.Hide();
                new AddFlight().Show();
            }
            else
            {
                ProfileNotification();
            }
        }

        private void UpdateFlightLabel_Click(object sender, EventArgs e)
        {
            if (Admin.GetInstance().Age != 0)
            {
                this.Hide();
                new UpdateFlight().Show();
            }
            else
            {
                ProfileNotification();
            }
        }

        private void CancelFlightLabel_Click(object sender, EventArgs e)
        {
            if (Admin.GetInstance().Age != 0)
            {
                this.Hide();
                new CancelFlight().Show();
            }
            else
            {
                ProfileNotification();
            }
        }

        private void ViewFlightLabel_Click(object sender, EventArgs e)
        {
            if (Admin.GetInstance().Age != 0)
            {
                this.Hide();
                new AllFlights().Show();
            }
            else
            {
                ProfileNotification();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (Admin.GetInstance().Age != 0)
            {
                this.Hide();
                new CreatNewAccount("Admin").Show();
            }
            else
            {
                ProfileNotification();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (Admin.GetInstance().Age != 0)
            {
            }
            else
            {
                ProfileNotification();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (Admin.GetInstance().Age != 0)
            {
            }
            else
            {
                ProfileNotification();
            }
        }

        private void BodyPanel_Click(object sender, EventArgs e)
        {
            if (Admin.GetInstance().Age == 0)
            {
                ProfileNotification();
            }
        }

        private void SignOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}