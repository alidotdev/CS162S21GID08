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
    public partial class CreatNewAccount : Form
    {
        public CreatNewAccount()
        {
            InitializeComponent();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label15.Hide();
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
            Validator v = Validator.GetInstance();
            String firstN = fNameBox.Text;
            String LastN = lNameBox.Text;
            String cnic = maskedTextBox1.Text;
            String email = emailBox.Text;
            String contact = maskedTextBox2.Text;
            String pwd = passwordBox.Text;
            int age = (int)numericUpDown1.Value;
            
            String gender="";
            if (maleBtn.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (v.isValidAlphaStr(firstN) && v.isValidAlphaStr(LastN) && v.isValidEmail(email)
                 && v.isValidPassword(pwd))
            {
                User user = new User();
                user.FirstName = firstN;
                user.LastName = LastN;
                user.CNIC = cnic;
                user.Email = email;
                user.Gender = gender;
                user.Age = age;
                user.Password = pwd;
                UserData.GetInstance().AddUser(user);

                this.Hide();
                new Login().Show();
            }
            else
            {
                if (!(v.isValidAlphaStr(firstN)))
                {
                    label10.Show();
                }
                if (!(v.isValidAlphaStr(LastN)))
                {
                    label11.Show();
                }
                if (!(v.isValidEmail(email)))
                {
                    label12.Show();
                }

                if (!(v.isValidPassword(pwd)))
                {
                    label15.Show();
                }

            }
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            fNameBox.Text = "";
            lNameBox.Text = "";
            emailBox.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox1.Text = "";
            maleBtn.Checked = false;
            femaleBtn.Checked = false;
            passwordBox.Text = "";
        }

        private void fNameBox_Click(object sender, EventArgs e)
        {
            label10.Hide();
        }

        private void lNameBox_Click(object sender, EventArgs e)
        {
            label11.Hide();
        }

        private void emailBox_Click(object sender, EventArgs e)
        {
            label12.Hide();
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            label15.Hide();
        }
    }
}
