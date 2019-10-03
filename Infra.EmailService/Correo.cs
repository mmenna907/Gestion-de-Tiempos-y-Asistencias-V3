using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;
using System.Net.Mail;

namespace Infra.EmailService
{
    public class Correo: MailMessage
    {
        public Correo()
        { 
            this.From = new MailAddress("sistemas@coniferalsacif.com.ar", "SistemaGestionDeTiemposyAsistencias", System.Text.Encoding.UTF8);            
            this.To.Add("MaximilianoMenna@coniferalsacif.com.ar");
            this.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        }
        public void SetAsunto(string pAsunto)
        {
            this.Subject = pAsunto;
        }
        public void SetMensaje(string pMensaje)
        {
            this.Body = pMensaje;            
        }       
        
    }
}
