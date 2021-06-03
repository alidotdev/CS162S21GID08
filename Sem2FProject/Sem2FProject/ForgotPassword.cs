using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Sem2FProject
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            label4.Hide();
            label5.Hide();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            String mail = EmailBox.Text;
            String Fname = FNameBox.Text;
            List<User> list = UserData.GetInstance().userList;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName == Fname && list[i].Email == mail)
                {
                    Email em = new Email(list[i]);
                    if (em.SendPwdRecoveryEmail())
                    {
                        flag = true;
                        this.Hide();
                        new Login().Show();
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show("Error! Try Again, Check your provided details");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
