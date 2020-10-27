using System.Net;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Net.Mail;

namespace DAO
{
    public partial class Email
    {
        public static bool EnviarContato(string emailRementente, string assunto, string nome, string sobrenome, string email, string mensagem)
        {

            //Cria o objeto que envia o e-mail
            SmtpClient _Client = new SmtpClient();

            //Cria o endereço de email do remetente
            MailAddress de = new MailAddress(ConfigurationSettings.AppSettings["emailRemetente"]);

            //Cria o endereço de email do destinatário -->
            MailAddress para = new MailAddress(emailRementente);
            MailMessage _Email = new MailMessage(de, para);

            _Email.IsBodyHtml = true;
            //Assunto do email
            _Email.Subject = assunto;
            //Conteúdo do email

            _Email.Body += "Contato do site Memória Familiar enviado no dia:" + " " + DateTime.Now + "<br/>";
            _Email.Body += "Assunto:" + assunto + "<br/>";
            _Email.Body += "Nome:" + nome + "<br/>";
            _Email.Body += "Sobrenome:" + sobrenome + "<br/>";
            _Email.Body += "Email:" + " " + email + "<br/>";
            _Email.Body += "Mensagem:" + " " + mensagem;

            _Client.Host = DAO.Constantes.SERVIDOR_SMTP;
            _Client.Port = 587;
            _Client.DeliveryMethod = SmtpDeliveryMethod.Network;
            _Client.UseDefaultCredentials = false;
            NetworkCredential user = new NetworkCredential(DAO.Constantes.SMTP_USER, DAO.Constantes.SMTP_PASS);

            _Client.Credentials = user;

            try
            {
                _Client.Send(_Email);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public static bool Pessoa_cadastrada(string emailRementente, string nome)
        {

            //Cria o objeto que envia o e-mail
            SmtpClient _Client = new SmtpClient();

            //Cria o endereço de email do remetente
            MailAddress de = new MailAddress(ConfigurationSettings.AppSettings["emailRemetente"]);

            //Cria o endereço de email do destinatário -->
            MailAddress para = new MailAddress(emailRementente);
            MailMessage _Email = new MailMessage(de, para);

            _Email.IsBodyHtml = true;
            //Assunto do email
            _Email.Subject = "Nova pessoa Cadastrada Juízo Final";
            //Conteúdo do email

            _Email.Body += "Nova pessoa cadastrada no site." + " " + DateTime.Now + "<br/>";
            _Email.Body += "Nome: " + nome;

            _Client.Host = DAO.Constantes.SERVIDOR_SMTP;
            _Client.Port = 587;
            _Client.DeliveryMethod = SmtpDeliveryMethod.Network;
            _Client.UseDefaultCredentials = false;
            NetworkCredential user = new NetworkCredential(DAO.Constantes.SMTP_USER, DAO.Constantes.SMTP_PASS);

            _Client.Credentials = user;

            try
            {
                _Client.Send(_Email);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
