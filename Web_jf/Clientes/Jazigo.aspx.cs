using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Globalization;
using DAO;
using System.Web.Security;

namespace Web_jf.Clientes
{
    public partial class Jazigo : System.Web.UI.Page
    {
        int ID_cliente;

        protected void Page_Load(object sender, EventArgs e)
        {
            MembershipUser Cliente = Membership.GetUser();
            string ID = Cliente.ProviderUserKey.ToString();

            DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente(ID);
            ID_cliente = obj_cliente.ID_cliente;

            if (obj_cliente.Corporacao == true)
            {
                txt_nome_jazigo.Enabled = false;
                txt_nome_jazigo.Text = obj_cliente.Nome_jazigo_corporacao;
            }
            else
            {
                txt_nome_jazigo.Enabled = false;
                txt_nome_jazigo.Text = obj_cliente.Nome_completo;
            }

            if (obj_cliente.Jazigo_comprado == null || obj_cliente.Jazigo_comprado == 0)
            {
                pnl_jazigo.Visible = false;
                pnl_usuario.Visible = true;
            }
            else
            {
                pnl_jazigo.Visible = true;
                pnl_usuario.Visible = false;

                if (obj_cliente.Corporacao == true)
                {
                    drop_parentesco.Visible = false;
                    drop_corporacao.Visible = true;
                }
                else
                {
                    drop_parentesco.Visible = true;
                    drop_corporacao.Visible = false;
                }
            }

            Load_falecidos();

            if (!IsPostBack)
            {
                Carrega_falecidos();
                Carrega_nivel_parentesco();
                Carrega_nivel_corporacao();
            }
        }

        public void Carrega_falecidos()
        {
            drop_falecido.DataSource = DAO.Juizofinal_falecido.Lista_falecidos();
            drop_falecido.DataValueField = "ID_falecido";
            drop_falecido.DataTextField = "Nome_falecido";
            drop_falecido.DataBind();

            drop_falecido.Items.Insert(0, new ListItem(" .: selecione :. ", "0"));
        }

        public void Carrega_nivel_parentesco()
        {
            drop_parentesco.DataSource = DAO.Juizofinal_nivel_parentesco.Lista_falecidos();
            drop_parentesco.DataValueField = "ID";
            drop_parentesco.DataTextField = "Nivel_parentesco";
            drop_parentesco.DataBind();

            drop_parentesco.Items.Insert(0, new ListItem(" .: selecione :. ", "0"));
        }

        public void Carrega_nivel_corporacao()
        {
            drop_corporacao.DataSource = DAO.Juizofinal_nivel_corporacao.Lista_();
            drop_corporacao.DataValueField = "ID";
            drop_corporacao.DataTextField = "Nivel_corporacao";
            drop_corporacao.DataBind();

            drop_corporacao.Items.Insert(0, new ListItem(" .: selecione :. ", "0"));
        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nome_jazigo.Text != String.Empty)
                {
                    if(drop_parentesco.SelectedValue != "0" && drop_corporacao.SelectedValue == "0")
                    {
                        DAO.Juizofinal_jazigo obj_jazigo = new DAO.Juizofinal_jazigo();
                        DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente_ID(ID_cliente);

                        obj_cliente.Nome_jazigo = txt_nome_jazigo.Text;
                        obj_cliente.UpdateRegistro();

                        obj_jazigo.ID_cliente = ID_cliente;
                        obj_jazigo.ID_falecido = Convert.ToInt16(drop_falecido.SelectedValue);
                        obj_jazigo.Nome_falecido = drop_falecido.SelectedItem.ToString();
                        obj_jazigo.Nivel_parentesco = drop_parentesco.SelectedValue;
                        obj_jazigo.Nome_jazigo = obj_cliente.Nome_jazigo;
                        obj_jazigo.DT_Inclusao = DateTime.Now;
                        obj_jazigo.Ativo = true;

                        obj_jazigo.Insert();
                        Load_falecidos();
                        limpa();

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Membro da família cadastrado com sucesso.');", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('É necessário informar o nível de parentesco com o falecido, caso não seja de sua família classifique como amigo(a)');", true);
                    }

                    if (drop_parentesco.SelectedValue == "0" && drop_corporacao.SelectedValue != "0")
                    {
                        DAO.Juizofinal_jazigo obj_jazigo = new DAO.Juizofinal_jazigo();
                        DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente_ID(ID_cliente);

                        obj_cliente.Nome_jazigo = txt_nome_jazigo.Text;
                        obj_cliente.UpdateRegistro();

                        obj_jazigo.ID_cliente = ID_cliente;
                        obj_jazigo.ID_falecido = Convert.ToInt16(drop_falecido.SelectedValue);
                        obj_jazigo.Nome_falecido = drop_falecido.SelectedItem.ToString();
                        obj_jazigo.Nivel_parentesco = drop_corporacao.SelectedValue;
                        obj_jazigo.Nome_jazigo = obj_cliente.Nome_jazigo;
                        obj_jazigo.DT_Inclusao = DateTime.Now;
                        obj_jazigo.Ativo = true;
                        obj_jazigo.Corporativo = true;

                        obj_jazigo.Insert();
                        Load_falecidos();
                        limpa();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('É necessário informar o cargo exercido na corporação.');", true);
                    }
                }
                else
                {
                    string mensagem = "Antes de criar seu Jazigo você deve informar seus dados(Nome completo, email e CPF) na página inicial.";
                    string url = "Default.aspx";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "alert('" + mensagem + "'); location='" + url + "';", true);
                    return;
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu um erro ao cadastrar o membro da família. Favor entre em contato com o suporte.');", true);
                //throw;
            }
        }

        public void Load_falecidos()
        {
            rptDados.DataSource = DAO.Juizofinal_jazigo.Lista_falecidos_jazigo(ID_cliente);
            rptDados.DataBind();
        }

        protected void rptDados_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DAO.Juizofinal_jazigo obj = (DAO.Juizofinal_jazigo)e.Item.DataItem;

                MembershipUser Cliente = Membership.GetUser();
                string ID = Cliente.ProviderUserKey.ToString();

                DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente(ID);
                ID_cliente = obj_cliente.ID_cliente;

                DAO.Juizofinal_nivel_parentesco obj_nivel = DAO.Juizofinal_nivel_parentesco.Get_nivel_cadastro(Convert.ToInt16(obj.Nivel_parentesco));
                DAO.Juizofinal_nivel_corporacao obj_nivel_corpo = DAO.Juizofinal_nivel_corporacao.Get_nivel_cadastro_corporacao(Convert.ToInt16(obj.Nivel_parentesco));


                DAO.Juizofinal_falecido obj_falecido = DAO.Juizofinal_falecido.Get_falecido_busca(obj.ID_falecido);

                if (obj_cliente.Corporacao == true)
                {
                    ((Label)e.Item.FindControl("lbl_parentesco")).Text = obj_nivel_corpo.Nivel_corporacao;
                }
                else
                {
                    ((Label)e.Item.FindControl("lbl_parentesco")).Text = obj_nivel.Nivel_parentesco;
                }

                ((Label)e.Item.FindControl("lbl_falecido_cadastrado")).Text = obj_falecido.Nome_falecido;
            }
        }

        protected void limpa()
        {
            drop_falecido.SelectedValue = "0";
            drop_parentesco.SelectedValue = "0";
        }


    }
}