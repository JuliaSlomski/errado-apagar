using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Linq;
using System.Web.Security;

namespace Web_jf.Clientes
{
    public partial class Licenca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        private static string CriaXMLCheckOut(double valor)
        {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.CloseOutput = false;

            StringBuilder st = new StringBuilder();
            XmlWriter tw = XmlWriter.Create(st, settings);

            tw.WriteStartElement("checkout");

            tw.WriteStartElement("currency");
            tw.WriteValue("BRL");
            tw.WriteEndElement();

            tw.WriteStartElement("items"); // items

            tw.WriteStartElement("item"); // item
            tw.WriteStartElement("id");
            tw.WriteValue("0001");
            tw.WriteEndElement();

            tw.WriteStartElement("description");
            tw.WriteValue("Juizo"); // precisa ser alterado para algo mais simples de reconhecer
            tw.WriteEndElement();

            tw.WriteStartElement("amount");
            tw.WriteValue(valor.ToString("n2"));
            tw.WriteEndElement();

            tw.WriteStartElement("quantity");
            tw.WriteValue(1);
            tw.WriteEndElement();

            tw.WriteStartElement("weight");
            tw.WriteValue(1);
            tw.WriteEndElement();

            //tw.WriteStartElement("shippingCost");
            //tw.WriteValue(0);
            //tw.WriteEndElement();

            tw.WriteEndElement(); // item
            tw.WriteEndElement(); // items

            tw.WriteStartElement("reference"); // precisa ser alterado para algo mais simples de reconhecer
            tw.WriteValue("Juizo Teste 0001");
            tw.WriteEndElement();

            tw.WriteStartElement("shipping"); // shipping

            tw.WriteStartElement("addressRequired"); // addressRequired
            tw.WriteValue(false);
            tw.WriteEndElement();

            tw.WriteEndElement();// shipping

            //tw.WriteStartElement("receiver"); // receiver
            //tw.WriteStartElement("email"); // email
            //tw.WriteValue("juliana@jwtsistemas.com");
            //tw.WriteEndElement();
            //tw.WriteEndElement(); // receiver


            tw.WriteStartElement("timeout"); // addressRequired
            tw.WriteValue(25);
            tw.WriteEndElement();


            tw.WriteEndElement(); // checkout

            tw.Close();
            tw.Dispose();

            return st.ToString();

        }

        [System.Web.Services.WebMethod(EnableSession = false)]
        public static string ProcessaCheckoutPagSeguro(double value)
        {

            /*
              <?xml version="1.0"?>
                 <checkout>
                   <currency>BRL</currency>
                   <items>
                     <item>
                       <id>0001</id>
                       <description>Produto PagSeguroI</description>
                       <amount>99999.99</amount>
                       <quantity>1</quantity>
                       <weight>10</weight>
                       <shippingCost>1.00</shippingCost>
                     </item>
                   </items>
                   <reference>REF1234</reference>
                   <shipping>
                     <addressRequired>false</addressRequired>
                   </shipping>
                   <receiver>
                     <email>suporte@lojamodelo.com.br</email>
                   </receiver>
                 </checkout>
              */

            string strURI = "https://ws.pagseguro.uol.com.br/v2/checkout/?email=juliana@jwtsistemas.com&token=093CFBD990154AC9A60388E5A9766D81";
            var wrequest = (HttpWebRequest)WebRequest.Create(strURI);
            wrequest.ContentType = "application/xml;charset=ISO-8859-1";
            wrequest.Method = "POST";
            wrequest.Host = "ws.pagseguro.uol.com.br";

            //wrequest.Headers.Add("token", "71D37CD78D8F4FA3AB1BED38419995CB");

            string dados = CriaXMLCheckOut(value);

            dados = "<?xml version='1.0'?>" + dados;
            dados = dados.Replace(",", "."); // não sei porque mas o valor aqui voltou a ter vírgula. Pode ser por causa do Globalization do servidor

            var byteArray = System.Text.Encoding.UTF8.GetBytes(dados);
            wrequest.ContentLength = byteArray.Length;
            Stream datastream = wrequest.GetRequestStream();
            datastream.Write(byteArray, 0, byteArray.Length);
            datastream.Close();


            //string a = HttpContext.Current.Server.MapPath("/Fotos");

            //return a;

            WebResponse wresponse = null;

            try
            {
                wresponse = wrequest.GetResponse();
                HttpWebResponse wresponse1 = wresponse as HttpWebResponse;
                Stream streamresponse = wresponse1.GetResponseStream();
                String sResponse = new StreamReader(streamresponse).ReadToEnd();

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(sResponse);

                // salve o retorno em algum lugar para que seja gerado um relatório
                var code = ((xml.ChildNodes[1] as XmlElement).ChildNodes[0] as XmlElement).InnerText;
                var data = ((xml.ChildNodes[1] as XmlElement).ChildNodes[1] as XmlElement).InnerText;

                return code;
            }
            catch (Exception)
            {
                throw;
            }

            return string.Empty;
        }
    }
}