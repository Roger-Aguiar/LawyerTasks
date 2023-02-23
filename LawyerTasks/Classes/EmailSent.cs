using System.Net.Mail;
using System.Net;

namespace LawyerTasks.Classes
{
    public class EmailSent
    {
        private readonly string userName = "rogervisualstudio@gmail.com";
        private readonly string password = "nqqtywrupjpkgpew";
        private readonly string host = "smtp.gmail.com";
        private readonly int port = 587;
        private readonly string location = "";
        private readonly string to = "rogerdaviola@yahoo.com.br";

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
                        email.From = new MailAddress(userName);
                        email.To.Add(to);
                        email.Subject = "Documentos para assinatura";
                        email.Body = SetBody();
                        email.IsBodyHtml = true;
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

        private string SetBody() => @"<p>Prezado(a), segue em anexo a procuração para fins de análise e assinatura.<p>Qualquer dúvida me coloco à disposição!</p> <p><b>Atenciosamente</b>,</p> <p><i>Dra. Vana Assis.<i>";
    }
}
