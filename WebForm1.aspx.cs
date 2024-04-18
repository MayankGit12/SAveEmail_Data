using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web.UI.WebControls;

namespace testr
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string smtpServer = "smtp.gmail.com";
        int smtpPort = 587;
        string smtpUsername = "shimanshu0507@gmail.com";
        string smtpPassword = "qhyf xduc mqon vqoc";

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string tb1 = TextBox5.Text;
            string tb2 = TextBox2.Text;
            string tb3 = TextBox3.Text;
            string tb4 = TextBox4.Text;

           
            if (string.IsNullOrWhiteSpace(tb1) || string.IsNullOrWhiteSpace(tb2) || string.IsNullOrWhiteSpace(tb3) || string.IsNullOrWhiteSpace(tb4))
            {
                Response.Write("Please fill out all required fields.");
                return;
            }

        
            MailMessage message = new MailMessage();
            message.From = new MailAddress(smtpUsername);
            message.To.Add(new MailAddress("lalbabu.shukla.145@gmail.com"));
            message.Subject = "System generated mail and need to repl y";
            message.Body = $"Name: {tb1}\nPhone: {tb2}\nCurrent Location: {tb3}\nAddress: {tb4}";

            
            if (FileUpload1.HasFile)
            {
                try
                {
                   
                    string fileName = Path.GetFileName(FileUpload1.FileName);
                    string folderPath = Server.MapPath("~/uploads/");
                    string filePath = Path.Combine(folderPath, fileName); 

                   
                    FileUpload1.SaveAs(filePath);

                   
                    Attachment attachment = new Attachment(filePath);
                    message.Attachments.Add(attachment);
                }
                catch (Exception ex)
                {
                   
                    Response.Write("Error uploading file: " + ex.Message);
                    return; 
                }
            }

            // Send email
            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(message);
                Response.Write("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Response.Write("Error sending email: " + ex.Message);
            }
        }
    }
}
