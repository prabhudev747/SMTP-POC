using System.Net.Mail;
using System.Net;

try
{
    var body = "hi";
    MailMessage MyMail = new MailMessage();
    MyMail.From = new MailAddress("EmailID");
    MyMail.To.Add("EmailID");
    MyMail.Subject = "New Feedback Submission: Website Improvements";
    // Construct the body of the email with newlines for formatting
    MyMail.Body = body.ToString();
    // Specify other mail settings
    MyMail.IsBodyHtml = false;  // Set to true if you are using HTML in your message

    SmtpClient smtp = new SmtpClient();
    smtp.Host = "HostName";
    smtp.Port = 25;
    smtp.EnableSsl = true;
    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
    smtp.UseDefaultCredentials = false;
    smtp.Credentials = new NetworkCredential("Email", "Password");
    //Send Email
    smtp.Send(MyMail);
}
catch (Exception ex)
{

	throw;
}
