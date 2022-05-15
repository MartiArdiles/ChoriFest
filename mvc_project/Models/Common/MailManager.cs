using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;

namespace mvc_project.Models.Common
{
    public class AttachedFile
    {
        public string FileName { get; set; }

        public byte[] File { get; set; }
    }

    public class MailManager
    {
        public static bool SendEmail(
            string[] destinations, 
            string origin, 
            string subject, 
            string textBody, 
            string htmlBody, 
            string host, 
            int port, 
            string userName, 
            string password,
            bool useSsl,
            List<AttachedFile> attachedFiles)
        {
            MailMessage mail = createMail(
                destinations,
                origin,
                subject);

            addBody(textBody, htmlBody, mail);

            attachFiles(attachedFiles, mail);
            
            return sendMail(
                host, 
                port, 
                userName, 
                password, 
                useSsl, 
                mail);
        }

        private static MailMessage createMail(
            string[] destinations, 
            string origin, 
            string subject)
        {
            var mail = new System.Net.Mail.MailMessage
            {
                From = new System.Net.Mail.MailAddress(origin),
                Subject = subject
            };

            foreach (string destination in destinations)
            {
                mail.To.Add(destination);
            }

            return mail;
        }

        private static void addBody(
            string textBody, 
            string htmlBody, 
            MailMessage mail)
        {
            mail.AlternateViews.Add(
                            System.Net.Mail.AlternateView.CreateAlternateViewFromString(
                                htmlBody,
                                null,
                                "text/html"));

            mail.AlternateViews.Add(
                System.Net.Mail.AlternateView.CreateAlternateViewFromString(
                    textBody,
                    null,
                    "text/plain"));
        }

        private static void attachFiles(
            List<AttachedFile> attachedFiles, 
            MailMessage mail)
        {
            if (attachedFiles != null && attachedFiles.Count > 0)
            {
                foreach (AttachedFile attachedFile in attachedFiles)
                {
                    MemoryStream memoryStream = new MemoryStream(attachedFile.File);

                    mail.Attachments.Add(
                        new System.Net.Mail.Attachment(
                            memoryStream,
                            attachedFile.FileName));
                }
            }
        }

        private static bool sendMail(
            string host, 
            int port, 
            string userName, 
            string password, 
            bool useSsl, 
            MailMessage mail)
        {
            try
            {
                using (var smtp = new System.Net.Mail.SmtpClient(host, port))
                {
                    if (useSsl)
                    {
                        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                    }

                    smtp.Credentials = new System.Net.NetworkCredential(userName, password);

                    smtp.Send(mail);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
