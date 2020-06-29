  public bool SendEmail(string emailAddress)
        {
            try
            {
                MailMessage mail = new MailMessage();

                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("senderEmail@gmail.com");
                mail.To.Add(emailAddress);
                mail.Subject = "Email Test";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("senderEmail@gmail.com", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }