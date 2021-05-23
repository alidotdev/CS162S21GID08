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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            fNameBox.Text = "";
            lNameBox.Text = "";
            emailBox.Text = "";
            contactNoBox.Text = "";
            maleBtn.Checked = false;
            femaleBtn.Checked = false;
            passwordBox.Text = "";
        }
    }
}
