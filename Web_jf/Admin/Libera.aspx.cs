using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_jf.Admin
{
    public partial class Libera : System.Web.UI.Page
    {

        public string sCliente;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["navegacao"] != null && Request.Cookies["navegacao"].Value == "1")
            {
                sCliente = Request.Cookies["Cliente_Id"].Value;

                DAO.Juizofinal_cliente obj = DAO.Juizofinal_cliente.GetCliente_ID(Convert.ToInt16(sCliente));

                Label lbl_nome = (Label)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("lbl_Nome");
                lbl_nome.Text = obj.Nome_cliente;

                Label lbl_licencas = (Label)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("lbl_licencas");
                lbl_licencas.Text = obj.Licenca_comprada.ToString();

                Label lbl_jazigo = (Label)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("lbl_jazigo");
                lbl_jazigo.Text = obj.Jazigo_comprado.ToString();

                if (!IsPostBack)
                {

                }
            }
        }

        protected void btn_atualiza_Click(object sender, EventArgs e)
        {
            DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente_ID(Convert.ToInt16(sCliente));

            if (txt_libera_licenca.Text != String.Empty && txt_libera_jazigo.Text == String.Empty)
            {
                obj_cliente.Licenca_comprada = Convert.ToInt16(txt_libera_licenca.Text);
            }
            else if (txt_libera_jazigo.Text != String.Empty && txt_libera_licenca.Text == String.Empty)
            {
                obj_cliente.Jazigo_comprado = Convert.ToInt16(txt_libera_jazigo.Text);
            }
            else if (txt_libera_jazigo.Text != String.Empty && txt_libera_licenca.Text != String.Empty)
            {
                obj_cliente.Licenca_comprada = Convert.ToInt16(txt_libera_licenca.Text);
                obj_cliente.Jazigo_comprado = Convert.ToInt16(txt_libera_jazigo.Text);
            }

            obj_cliente.UpdateRegistro();

            limpaCampos();

            string mensagem = "Liberação de licennça de uso e de Jazigo atualizados com sucesso!";
            string url = "Default.aspx";
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "alert('" + mensagem + "'); location='" + url + "';", true);
            return;
        }

        public void limpaCampos()
        {
            txt_libera_licenca.Text = String.Empty;
            txt_libera_jazigo.Text = String.Empty;
        }
    }
}