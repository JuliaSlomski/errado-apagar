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

namespace Web_jf.Clientes
{
    public partial class Default : System.Web.UI.Page
    {

        int Usuario;
        string CPF;
        string Email;
        string Nome_completo;
        string nome_jazigo_corpo;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Clear();

            LoadData();

            if (!IsPostBack)
            {
                LoadData();
                Session.Clear();

                var teste = DAO.Juizofinal_cliente_falecido.Get_falecido(Usuario);
                List<DAO.ID_Falecidos> ID = new List<DAO.ID_Falecidos>();

                int numero = teste.Count;

                foreach (var item in teste)
                {
                    DAO.Juizofinal_falecido obj_busca = DAO.Juizofinal_falecido.Get_falecido_busca(item.ID_falecido);
                    var items = new DAO.ID_Falecidos();

                    items.idfalecido = obj_busca.ID_falecido;

                    ID.Add(items);

                    Session.Add("id_falecido", ID);
                }

                DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente_ID(Usuario);

                DAO.Juizofinal_cliente obj_modal = DAO.Juizofinal_cliente.GetCliente_ID(Usuario);
                
                if (obj_modal.Documento == null || obj_modal.Documento == String.Empty)
                {
                    pnl_modal.Visible = true;

                    if (obj_cliente.Corporacao == true)
                    {
                        txt_jazigo_corporacao.Visible = true;
                    }
                    else
                    {
                        txt_jazigo_corporacao.Visible = false;
                    }
                    return;
                }

                if (Session["id_falecido"] == null && obj_cliente.Licenca_comprada == null)
                {
                    pnl_usuario.Visible = true;
                    pnl_usuario_compra.Visible = false;
                    pnl_usuario_ok.Visible = false;
                }
                else if (Session["id_falecido"] == null && obj_cliente.Licenca_comprada > 0)
                {
                    pnl_usuario.Visible = false;
                    pnl_usuario_compra.Visible = false;
                    pnl_usuario_ok.Visible = true;
                }
                else if (Session["id_falecido"] != null)
                {
                    pnl_usuario.Visible = false;
                    pnl_usuario_compra.Visible = true;
                    pnl_usuario_ok.Visible = false;
                }

                rptDados.DataSource = Session["id_falecido"];
                rptDados.DataBind();
            }
        }

        public void LoadData()
        {
            MembershipUser usuario = Membership.GetUser();
            string ID = usuario.ProviderUserKey.ToString();

            DAO.Juizofinal_cliente objUsuario = DAO.Juizofinal_cliente.GetCliente(ID);
            DAO.Juizofinal_cliente_falecido obj_ = DAO.Juizofinal_cliente_falecido.Get_cliente_busca(objUsuario.ID_cliente);

            Usuario = objUsuario.ID_cliente;

            if (obj_ == null && objUsuario.Licenca_comprada != null)
            {
                Usuario = objUsuario.ID_cliente;
                lbl_licencas.Text = "0";
                lbl_licencas_2.Text = objUsuario.Licenca_comprada.ToString();
            }
            else if (obj_ != null && objUsuario.Licenca_comprada != null)
            {
                Usuario = obj_.ID_cliente;
                lbl_licencas.Text = objUsuario.Licenca_comprada.ToString();
                lbl_licencas_2.Text = objUsuario.Licenca_comprada.ToString();
            }
            else if (obj_ == null && objUsuario.Licenca_comprada == null)
            {
                Usuario = objUsuario.ID_cliente;
                lbl_licencas.Text = "0";
                lbl_licencas_2.Text = "0";
            }
            else if (obj_ != null && objUsuario.Licenca_comprada == null)
            {
                Usuario = objUsuario.ID_cliente;
                lbl_licencas.Text = "0";
                lbl_licencas_2.Text = "0";
            }

            nome_jazigo_corpo = txt_jazigo_corporacao.Text;
            CPF = txt_cpf.Text;
            Email = txt_email_cliente.Text;
            Nome_completo = txt_nome_completo.Text;
        }

        protected void rptDados_ItemDataBound1(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DAO.ID_Falecidos obj = (DAO.ID_Falecidos)e.Item.DataItem;

                DAO.Juizofinal_falecido obj_fa = DAO.Juizofinal_falecido.Get_falecido_busca(Convert.ToInt16(obj.idfalecido));

                ((Label)e.Item.FindControl("lbl_nome_falecido")).Text = obj_fa.Nome_falecido;

                ((ImageButton)e.Item.FindControl("id_falecido")).ImageUrl = "~/Images/target_3.png";
                ((ImageButton)e.Item.FindControl("id_falecido")).CommandArgument = obj_fa.ID_falecido.ToString();
                ((ImageButton)e.Item.FindControl("id_falecido")).ToolTip = "Alterar";
                
            }
        }


        protected void btn_modal_Click(object sender, EventArgs e)
        {
            try
            {
                DAO.Juizofinal_cliente obj_atualiza = DAO.Juizofinal_cliente.GetCliente_ID(Usuario);

                obj_atualiza.Nome_jazigo_corporacao = nome_jazigo_corpo;
                obj_atualiza.Documento = CPF;
                obj_atualiza.Email = Email;
                obj_atualiza.Nome_completo = Nome_completo;

                obj_atualiza.UpdateRegistro();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Dados atualizados com sucesso. Obrigado!');", true);

                pnl_modal.Visible = false;

                Response.Redirect("Default.aspx");

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Algum erro ocorreu.');", true);
                return;
                //throw;
            }
        }

        protected void id_falecido_Command(object sender, CommandEventArgs e)
        {
            try
            {
                string cod_falecido = e.CommandArgument.ToString();
                  
                    Response.Cookies.Add(new HttpCookie("navegacao", "1"));
                    Response.Cookies.Add(new HttpCookie("cod_falecido", cod_falecido));

                    Response.Redirect("Cadastro_falecido.aspx");
            }
            catch (Exception)
            {
                 ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Algum erro ocorreu.');", true);
                //throw;
            }
        }
    }
}