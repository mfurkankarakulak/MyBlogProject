using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Business
{
    public static class SendMail
    {
        public static void SendMailUser(string message,string eMail,string subject)
        {
            try
            {
                var senderEmail = new MailAddress("mail@gmail.com","MfK Blog Site");
                var receiverEmail = new MailAddress(eMail, "Receiver");
                var password = "şifremail";
                var sub = subject;
                var body = message+eMail;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var mess = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(mess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
