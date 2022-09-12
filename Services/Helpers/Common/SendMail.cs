using iTextSharp.text.pdf.qrcode;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;
using PLANTILLA_API_ODATA.Models;

namespace PLANTILLA_API_ODATA.Services.Helpers.Common
{
    public class SendMail
    {
        public static bool mail(string Destinatario, string Cabecera, string Mensaje)
        {

            try
            {
                IDbConnection dbII = new SqlConnection(Global.ConnectionStrings);
                FromMailerConfig result = dbII.QuerySingleOrDefault<FromMailerConfig>("select REFERENCIA1 AS Servidor, REFERENCIA2 AS Puerto, REFERENCIA3 AS Correo, REFERENCIA4 AS PasswordMail,\r\nREFERENCIA5 AS SLL  from OPE_PARAMETRO where CODIGO = 'SENDEMAIL'");

                if(String.IsNullOrEmpty(result.Correo) || String.IsNullOrEmpty(result.Correo) )
                {
                    return false;
                }

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(result.Correo);
                message.To.Add(new MailAddress(Destinatario));
                message.Subject = Cabecera;
                message.Body = Mensaje;
                message.IsBodyHtml = true;
                smtp.Port = Int32.Parse(result.Puerto);
                smtp.Host = result.Servidor;
                if (result.Sll=="S")
                {
                    smtp.EnableSsl = true;
                }
                else
                {
                    smtp.EnableSsl = false;
                }
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(result.Correo, result.PasswordMail);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

    }
}
