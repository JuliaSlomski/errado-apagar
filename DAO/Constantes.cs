using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAO
{
    public partial class Constantes
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;

        //ENVIO DE E-MAIL
        public static string SERVIDOR_SMTP = ConfigurationManager.AppSettings["Servidor_SMTP"].ToString();
        public static string SMTP_USER = ConfigurationManager.AppSettings["SMTP_User"].ToString();
        public static string SMTP_PASS = ConfigurationManager.AppSettings["SMTP_Pass"].ToString();
    }
}
