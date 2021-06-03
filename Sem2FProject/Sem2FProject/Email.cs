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
        MailAddress FromAddress = new MailAddress("muneebydrgzm@gmail.com", "UET AirLine Reservation System");
        const string fromPassword = "Muneeb258";
        MailAddress ToMailAddress { get; set;}
        private User ReqUser { get; set; }
        private String Body { get; set; }
        private String Subject { get; set; }
        private static Email email { get; set; }
        private Email() { }

        public static Email GetInstance()
        {
            if (email == null)
            {
                email = new Email();
                return email;
            }
            else 
            {
                return email;
            }

        } 

        public bool SendPwdRecoveryEmail(User user)
        {
            ReqUser = user;
            ToMailAddress = new MailAddress(ReqUser.Email,(user.FirstName+" "+ ReqUser.LastName));
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
            message.Subject = "Password Recovery Mail";
            message.Body = "Hi " + ReqUser.FirstName + " " + ReqUser.LastName
                + "!\n\n" + "We recently recieved a request to recover your Account " + ReqUser.Email
                + ".\n" + "Your password is : " + ReqUser.Password
                + "\n" + "Thanks for your patience.";
            try 
            {
                smtp.Send(message);
            }
            catch (System.Net.Mail.SmtpException)
            {
                return false;
            }
            MessageBox.Show("Email Sent Successfully!");
            return true;
        }

        public bool AccountBalance(User user)
        {
            ReqUser = user;
            MyWallet wallet = user.wallet;
            ToMailAddress = new MailAddress(ReqUser.Email, (ReqUser.FirstName + " " + ReqUser.LastName));
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
            message.Subject = "Balance Checking Mail";
            message.Body = "Hi " + ReqUser.FirstName + " " + ReqUser.LastName
                + "!\n\n" + "We recently recieved a request to check your Balance " + wallet.MyBalance()
                + ".\nThanks for your response";
            try
            {
                smtp.Send(message);
            }
            catch (System.Net.Mail.SmtpException)
            {
                return false;
            }
            MessageBox.Show("Email Sent Successfully!");
            return true;
        }

        public bool UserLogin(User user)
        {

            ReqUser = user;
            ToMailAddress = new MailAddress(ReqUser.Email, (ReqUser.FirstName + " " + ReqUser.LastName));
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
            message.Subject = "Account Login Alert";
            message.Body = "Hi " + ReqUser.FirstName + " " + ReqUser.LastName
                + "!\n\n" + "Your account is recently logined. " 
                + ".\nThis is mail is only for security purpose. "
                + "\nNo need to reply"
                + "\n\nContact to security staff for any security issue"
                + "\n\nThanks.";
            try
            {
                smtp.Send(message);
            }
            catch (System.Net.Mail.SmtpException)
            {
                return false;
            }
            MessageBox.Show("Email Sent Successfully!");
            return true;
        }

        public bool TransactionMail(User user)
        {
            ReqUser = user;
            ToMailAddress = new MailAddress(ReqUser.Email, (ReqUser.FirstName + " " + ReqUser.LastName));
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
            message.Subject = "Transaction Mail";
            message.Body = "Hi " + ReqUser.FirstName + " " + ReqUser.LastName
                + "!\n\nThis is inform to you that transaction of money is performed from your account"
                + "\n\nThanks.";
            try
            {
                smtp.Send(message);
            }
            catch (System.Net.Mail.SmtpException)
            {
                return false;
            }
            MessageBox.Show("Email Sent Successfully!");
            return true;
        } 
    }
}

