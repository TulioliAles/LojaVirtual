using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("desmecad@gmail.com", "**** Inserir a senha do e-mail ****");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
            "<b>Nome: </b> {0} <br/>" +
            "<b>E-mail: </b> {1} <br/>" +
            "<b>Texto: </b> {2} <br/>" +
            "<br/> E-mail enviado automaticamente do Site LojaVirtual.",
            contato.Nome,
            contato.Email,
            contato.Texto
            );

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("desmecad@gmail.com");
            mensagem.To.Add("desmecad@gmail.com");
            mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            smtp.Send(mensagem);
        }
    }
}
