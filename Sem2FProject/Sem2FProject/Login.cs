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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ForgotPassword().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email = emailBox.Text;
            String pwd = passwordBox.Text;
            if (email== Admin.GetInstance().Email &&pwd==Admin.GetInstance().Password)
            {
                this.Hide();
                new AdminHome().Show();
            }
            else
            {
                UserData userData ;
                
                this.Hide();
                new UserHome().Show();
            }
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                button1_Click(sender,e);
            }
        }

        private void emailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

    }
}
