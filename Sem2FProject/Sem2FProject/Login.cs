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
            label5.Hide();
            label6.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CreatNewAccount("User").Show();
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
            if (Validator.GetInstance().isValidEmail(email) && Validator.GetInstance().isValidPassword(pwd))
            {

                if (email == Admin.GetInstance().Email && pwd == Admin.GetInstance().Password)
                {
                    this.Hide();
                    new AdminHome().Show();
                }
                else
                {
                    List<User> list = UserData.GetInstance().userList;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (email == list[i].Email && pwd == list[i].Password)
                        {
                            this.Hide();
                            new UserHome().Show();
                            break;
                        }
                    }
                    MessageBox.Show("Wrong Credentials!\n       Try again");
                }
            }
            else
            {
                if(!(Validator.GetInstance().isValidEmail(email)))
                {
                    label5.Show();
                }
                if(!(Validator.GetInstance().isValidPassword(pwd)))
                {
                    label6.Show();
                }

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

       
       

        private void emailBox_ControlRemoved(object sender, ControlEventArgs e)
        {
            string email = emailBox.Text;
            if (Validator.GetInstance().isValidEmail(email))
            {
                label5.Hide();
            }
            else
            {
                label5.Show();
            }
        }

        private void passwordBox_ControlRemoved(object sender, ControlEventArgs e)
        {
            string pass = passwordBox.Text;
            if (Validator.GetInstance().isValidPassword(pass))
            {
                label6.Hide();
            }
            else
            {
                label6.Show();
            }
        }

       
       

        private void emailBox_Click(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            label6.Hide();
        }
    }
}
