using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace test
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = "Buen dia Jose Luis, " + txtNombre.Text
             + " quiere contactarte, su correo es: " + TextEmail.Text + ", la razón princpial de su correo es el siguiente: "
             + TxtMensaje.Text;
            string remitente = TextEmail.Text;  // Al que se le va envíar...

            System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();

            correo.From = new MailAddress(remitente);// el correo recibido

            correo.To.Add("joseluisrivera716@gmail.com"); //el correo enviado
            correo.Subject = "Tiene un nuevo cliente";
            correo.Body = mensaje;

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25; //465 o 587  Puertos que pueden servir...
            smtp.Credentials = new NetworkCredential("joseluisrivera716@gmail.com", "Tu y cachalote");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(correo);
            }
            catch (Exception ex)
            {
                throw new Exception("No se ha podido enviar el email", ex.InnerException);
            }
            finally
            {
                smtp.Dispose();
            }
        }
    }
}
