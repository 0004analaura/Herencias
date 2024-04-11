using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            INotificable email = new NotificacionEmail("analauracr2004@gmail.com");
            INotificable Whatsapp = new NotificacionWhatsapp("56321236");
            INotificable Sms = new NotificacionSMS("87563216");

            email.Notifica();
            Whatsapp.Notifica();
            Sms.Notifica();


            Console.ReadKey(true);
        }

        public interface INotificable
        {
            void Notifica();
        }

        public class NotificacionEmail : INotificable
        {
            public string DireccionCorreo { get; set; }
            public NotificacionEmail(string direccionCorreo)
            {
                DireccionCorreo = direccionCorreo;
            }

            public void Notifica()
            {
                Console.WriteLine($"Eviando correo electronico a {DireccionCorreo}...");
            }

        }
        public class NotificacionWhatsapp : INotificable
        {
            public string NumeroTelefono { get; set; }

            public NotificacionWhatsapp(string numeroTelefono)
            {
                NumeroTelefono = numeroTelefono;


            }

            public  void Notifica()
            {
                Console.Write($"Enviado mensaje de Whatsapp al {NumeroTelefono}...");
            }
        }

        public class NotificacionSMS : INotificable
        {
            public string NumeroTelefono { get; set; }

            public NotificacionSMS (string numeroTelefono)
            {
                NumeroTelefono = numeroTelefono;
            }

            public void Notifica()
            {
                Console.WriteLine($"Eviando SMS al {NumeroTelefono}...");
            }

        }

    }
}
