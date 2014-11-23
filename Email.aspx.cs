using System;
using System.Net.Mail;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.Mail;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Net;



public partial class Email : System.Web.UI.Page
{
    
	
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }



    protected void SendEmail(object sender, EventArgs e)
    {
        using (System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage(txtEmail.Text, txtTo.Text))
        {
            mm.Subject = txtSubject.Text;
            mm.Body = txtBody.Text;
            if (fuAttachment.HasFile)
            {
                string FileName = Path.GetFileName(fuAttachment.PostedFile.FileName);
                mm.Attachments.Add(new Attachment(fuAttachment.PostedFile.InputStream, FileName));
            }
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential(txtEmail.Text, txtPassword.Text);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = NetworkCred;

            smtp.Port = 587;
            smtp.Send(mm);
            ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
            txtTo.Text = "";
            txtSubject.Text = "";
            txtBody.Text = " ";
            


        }
    }
}