using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Web_jf.Clientes
{
    public partial class retornopagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.QueryString["id_pagseguro"];
            SalvarPagSeguroTransCode(a);
        }

        private void SalvarPagSeguroTransCode(string value)
        {
            MembershipUser Cliente = Membership.GetUser();
            string ID = Cliente.ProviderUserKey.ToString();
            DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente(ID);

            DAO.Juizofinal_dados_pagseguro obj = new DAO.Juizofinal_dados_pagseguro();
            obj.Data_Insercao = DateTime.Now;
            obj.ID_Usuario = obj_cliente.ID_cliente;
            obj.codigo_pagto_transacao = value;
            obj.Insert();
        }
    }
}