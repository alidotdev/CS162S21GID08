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

        private void button1_Click(object sender, EventArgs e)
        {
            

            var fromAddress = new MailAddress("muhammadalimurtaza@gmail.com", "Muhammad Ali Murtaza");
            var toAddress = new MailAddress("hafizmuhammadalimurtaza997@gmail.com", "Ali");
            const string fromPassword = "fromPassword";
            const string subject = "Testing email";
            const string body = "This isthe first email send by program to test the " +
                "validity of sendng emails though c#";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            MessageBox.Show("Mail sent");
            this.Hide();
            new Login().Show();
        }
    }
}
