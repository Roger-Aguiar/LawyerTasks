using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.ComponentModel;


namespace LawyerTasks.Classes
{
    public class EmailSent
    {
        private string userName = "rogervisualstudio@gmail.com";
        private string password = "nqqtywrupjpkgpew";
        private string host = "smtp.gmail.com";
        private string emailAddress = "rogervisualstudio@gmail.com";
        private int port = 587;
        private string location = "";

        public EmailSent(string location) 
        {
            this.location = location;
        }
        public void SendEmail()
        {
            try
            {
                using(SmtpClient smtp = new SmtpClient()) 
                {
                    using(MailMessage email = new MailMessage()) 
                    {
                        smtp.Host = host;                        
                        smtp.Credentials = new NetworkCredential(userName, password);
                        smtp.Port = port;
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        email.From = new MailAddress(emailAddress);
                        email.To.Add("rogerdaviola@yahoo.com.br");
                        email.Subject = "Test";
                        email.Body = "Test body";
                        email.IsBodyHtml = false;
                        email.Attachments.Add(new Attachment(this.location));
                        smtp.Send(email);

                        MessageBox.Show("Email enviado com sucesso!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
            
        }        
    }
}
