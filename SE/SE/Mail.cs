using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace SE
{
    class Mail
    {
        public Mail()
        {
            CreateTestMessage4("Smtp.gmail.com");
        }
        public static void CreateTestMessage4(string server)
        {
            MailAddress from = new MailAddress("ben@contoso.com");
            MailAddress to = new MailAddress("yogevheskia@se.shenkar.ac.il");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the SmtpClient class.";
            message.Body = @"Using this feature, you can send an e-mail message from an application very easily.";
            SmtpClient client = new SmtpClient(server);
            Console.WriteLine("Sending an e-mail message to {0} by using SMTP host {1} port {2}.",to.ToString(), client.Host, client.Port);
            //MessageBox.Show("try");
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage4(): {0}",ex.ToString());
            }
        }
    }
}
