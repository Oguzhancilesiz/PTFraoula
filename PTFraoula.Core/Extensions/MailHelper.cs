using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PTFraoula.Core.Extensions
{
    public static class MailHelper
    {
        //ridvan.aksoy@bilgeadam.com;zafer.boz@bilgeadamboost.com;
        public static MailMessage MailCreate(string to, string subject, string body, string cc = "")
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("hs19boost@gmail.com");
            message.Subject = subject;
            message.Body = body;
            message.To.Add(to);
            if (!string.IsNullOrWhiteSpace(cc))
            {
                message.CC.Add(cc);
            }

            message.IsBodyHtml = true;

            return message;
        }

        public static void SendMail(MailMessage message, string host, int portNumber, string username, string password)
        {
            SmtpClient smtpClient = new SmtpClient(host, portNumber);

            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Credentials = new NetworkCredential(username, password);

                smtpClient.Send(message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void SendMail(MailMessage message)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Credentials = new NetworkCredential("hs19boost@gmail.com", "REDACTED");

                smtpClient.Send(message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
