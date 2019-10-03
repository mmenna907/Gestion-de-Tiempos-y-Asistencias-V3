using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EmailService
{
    public class ServidorDeCorreo
    {
        SmtpClient SmtpServer;
        
        public ServidorDeCorreo()
        {
            SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("mmenna907@gmail.com","123456");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
        }        
        public void EnviarCorreo(Correo pCorreo)
        {
            SmtpServer.Send(pCorreo);
        }

    }
}
