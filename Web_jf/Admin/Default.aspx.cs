using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Globalization;
using DAO;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;

namespace Web_jf.Admin
{
    public partial class Default1 : System.Web.UI.Page
    {
        int Usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadClientes();
            }
        }

        public void LoadClientes()
        {
            LoadData();

            rptDados.DataSource = DAO.Juizofinal_cliente.Lista_clientes();
            rptDados.DataBind();
        }

        public void LoadData()
        {
            MembershipUser usuario = Membership.GetUser();
            string ID = usuario.ProviderUserKey.ToString();

            DAO.Juizofinal_cliente objUsuario = DAO.Juizofinal_cliente.GetCliente(ID);

            Usuario = objUsuario.ID_cliente;
        }

        protected void rptDados_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DAO.Juizofinal_cliente obj = (DAO.Juizofinal_cliente)e.Item.DataItem;


                ((Label)e.Item.FindControl("lbl_nome_cliente")).Text = obj.Nome_cliente;

                if (obj.Licenca_comprada == null || obj.Licenca_comprada == 0)
                {
                    ((Label)e.Item.FindControl("lbl_licenca")).Text = "0";
                }
                else
                {
                    ((Label)e.Item.FindControl("lbl_licenca")).Text = obj.Licenca_comprada.ToString();
                }

                if (obj.Jazigo_comprado == null || obj.Jazigo_comprado == 0)
                {
                    ((Label)e.Item.FindControl("lbl_jazigo")).Text = "0";
                }
                else
                {
                    ((Label)e.Item.FindControl("lbl_jazigo")).Text = obj.Jazigo_comprado.ToString();
                }

                ((ImageButton)e.Item.FindControl("btn_atualizar")).ImageUrl = "~/Images/target_2.png";
                ((ImageButton)e.Item.FindControl("btn_atualizar")).CommandArgument = obj.ID_cliente.ToString();

            }
        }

        protected void btn_atualizar_Command(object sender, CommandEventArgs e)
        {
            try
            {
                string cod_cliente = e.CommandArgument.ToString();

                Response.Cookies.Add(new HttpCookie("navegacao", "1"));
                Response.Cookies.Add(new HttpCookie("Cliente_Id", Convert.ToString(cod_cliente)));

                Response.Redirect("Libera.aspx");

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu algum erro ao selecionar o usuário.');", true);
                //throw;
            }
        }
    }
}