using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CONTROLADORA
{
    public class cFunciones_Compartidas
    {
        public static string ClaveAleatoria()
        {
            char[] ValueAfanumeric = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random random = new Random();
            int longitud = 6;
            string ClaveAleat = String.Empty;
            for (int i = 0; i < longitud; i++)
            {
                int rm = random.Next(0, 2);
                if (rm == 0)
                {
                    ClaveAleat += random.Next(0, 10);
                }
                else
                {
                    ClaveAleat += ValueAfanumeric[random.Next(0, 59)];
                }
            }
            return ClaveAleat;
        }

        public static bool ValidarEmail(string mail)
        {
            string expresion;
            expresion = @"\A(\w+\.?\w*\@\w+\.)(com)\Z";
            System.Text.RegularExpressions.Regex automata = new Regex(expresion);
            return automata.IsMatch(mail);
        }

        public static string EncriparClave(string clave)
        {
            byte[] passBytes = Encoding.Unicode.GetBytes(clave);
            SHA1 sha = SHA1.Create();
            byte[] hash = sha.ComputeHash(passBytes);
            string hashString = Encoding.Unicode.GetString(hash);
            return hashString;
        }

        public static bool Enviar_Email(string Dest, string Asunto, string Mensaje)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(Dest);
            msg.From = new MailAddress("sistema@gmail.com", "MODULO SEGURIDAD", System.Text.Encoding.UTF8);
            msg.Subject = Asunto;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = Mensaje;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new
            System.Net.NetworkCredential("manuelboginoc@gmail.com", "medesmayo");
            cliente.Port = 587;
            cliente.Host = "smtp.gmail.com";
            cliente.EnableSsl = true;
            try
            {
                cliente.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
