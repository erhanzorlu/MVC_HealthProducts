using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project.COMMON.Tools
{
   public class MailService
    {
        public static void Send(string receiver,string password="sifre_yazilacak_yer",string body="Şifre için eposta kodları",string subject="Email testi",string sender="Senin_epostan")
        {
            MailAddress senderEmail = new MailAddress(sender); //Gönderen
            MailAddress receiverEmail = new MailAddress(receiver);//Alıcı
            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)

            };

            MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body,
            };
            smtp.Send(message);


        }
    }
}
