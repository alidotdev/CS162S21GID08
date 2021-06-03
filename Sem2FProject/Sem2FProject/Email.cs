using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2FProject
{
    class Email
    {
        MailAddress FromAddress = new MailAddress("muneebydrgzm@gmail.com", "Ydrgzm & Ali");
        const string fromPassword = "Muneeb258";
        MailAddress ToMailAddress
        {
            get; set;
        }
        private User ReqUser { get; set; }
        private String PwdBody { get; set; }
        private readonly String PwdSubject = "Password Recovery";
        public Email(User user)
        {
            ReqUser = user;
            ToMailAddress = new MailAddress(ReqUser.Email, ReqUser.FirstName+" "+ReqUser.LastName);
            PwdBody = String.Format("Hi {0}!\nWe recently received a request to recover your Account {1}.\nYour password is {2}.\nThank you for your patience.", ReqUser.FirstName + " " + ReqUser.LastName,ReqUser.Email,ReqUser.Password);
        }

        public bool SendPwdRecoveryEmail()
        {
            var smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(FromAddress.Address, fromPassword)
            };
            MailMessage message = new MailMessage(FromAddress, ToMailAddress);
            message.Subject = PwdSubject;
            message.Body = PwdBody;
            try
            {
                smtp.Send(message);
            }
            catch (System.Net.Mail.SmtpException)
            {
                return false;
            }
            MessageBox.Show("Email has been Sent Successfully!");
            return true;
        }
    }
}

