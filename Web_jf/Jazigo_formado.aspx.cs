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

namespace Web_jf
{
    public partial class Jazigo_formado : System.Web.UI.Page
    {
        string Usuario;
        protected void Page_Load(object sender, EventArgs e)
        {

            Usuario = Request.QueryString["ID"];

            DAO.Juizofinal_jazigo obj = DAO.Juizofinal_jazigo.Nome_jazigo_cadastro(Convert.ToInt16(Usuario));
            DAO.Juizofinal_nivel_parentesco obj_nivel = DAO.Juizofinal_nivel_parentesco.Get_nivel_cadastro(Convert.ToInt16(obj.Nivel_parentesco));

            lbl_nome_jazigo.Text = obj.Nome_jazigo;

            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void BindData()
        {
            try
            {
                var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
                SqlConnection sqlcon = null;
                sqlcon = new SqlConnection(strConn);
                sqlcon.Open();

                DataSet tbl = new DataSet();

                SqlCommand cmd = new SqlCommand("Select * from Juizofinal_jazigo where ID_cliente = @ID_cliente order by Nivel_parentesco asc", sqlcon);
                cmd.Parameters.AddWithValue("@ID_cliente", Usuario);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tbl);
                DataList1.DataSource = tbl.Tables[0];
                DataList1.DataBind();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected void Item_Bound(Object sender, DataListItemEventArgs e)
        {
            try
            {
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {

                    DAO.Juizofinal_falecido obj_falecido = DAO.Juizofinal_falecido.Get_falecido_busca(Convert.ToInt16(((DataRowView)e.Item.DataItem).Row.ItemArray[1].ToString()));

                    DAO.Juizofinal_jazigo obj = DAO.Juizofinal_jazigo.Nome_jazigo_dados(Convert.ToInt16(Usuario), ((DataRowView)e.Item.DataItem).Row.ItemArray[4].ToString());
                    DAO.Juizofinal_nivel_parentesco obj_nivel = DAO.Juizofinal_nivel_parentesco.Get_nivel_cadastro(Convert.ToInt16(obj.Nivel_parentesco));

                    DAO.Juizofinal_nivel_corporacao obj_nivel_corporacao = DAO.Juizofinal_nivel_corporacao.Get_nivel_cadastro_corporacao(Convert.ToInt16(obj.Nivel_parentesco));

                    if (obj.Corporativo == true)
                    {
                        Label parentesco = e.Item.FindControl("lbl_parentesco") as Label;
                        parentesco.Text = obj_nivel_corporacao.Nivel_corporacao;
                    }
                    else
                    {
                        Label parentesco = e.Item.FindControl("lbl_parentesco") as Label;
                        parentesco.Text = obj_nivel.Nivel_parentesco;
                    }
                    
                    Image foto = (Image)e.Item.FindControl("Image1");
                    foto.ImageUrl = "~/Fotos/" + obj_falecido.foto_1;

                    Label nome_falecido = e.Item.FindControl("lbl_nome_falecido") as Label;
                    nome_falecido.Text = obj_falecido.Nome_falecido;

                    if (nome_falecido.Text.Count() >= 18)
                    {
                        nome_falecido.Text = obj_falecido.Nome_falecido.ToString().Substring(0,18) + "...";
                    }
                    else
                    {
                        nome_falecido.Text = obj_falecido.Nome_falecido.ToString();
                    }

                    //Label nome_pai = e.Item.FindControl("lbl_nome_pai") as Label;
                    //nome_pai.Text = obj_falecido.Nome_pai;

                    //Label nome_mae = e.Item.FindControl("lbl_nome_mae") as Label;
                    //nome_mae.Text = obj_falecido.Nome_mae;

                    //Label cidade_nascimento = e.Item.FindControl("lbl_cidade_nascimento") as Label;
                    //cidade_nascimento.Text = obj_falecido.cidade_nascimento;

                    Label dt_nascimento = e.Item.FindControl("lbl_dt_nascimento") as Label;
                    dt_nascimento.Text = obj_falecido.data_nasceimento.Value.ToShortDateString().Substring(6,4);

                    //Label local_morte = e.Item.FindControl("lbl_local_morte") as Label;
                    //local_morte.Text = obj_falecido.cidade_morte;

                    Label dt_morte = e.Item.FindControl("lbl_dt_morte") as Label;
                    dt_morte.Text = obj_falecido.data_morte.Value.ToShortDateString().Substring(6, 4);

                    Label causa_morte = e.Item.FindControl("lbl_causa_morte") as Label;
                    causa_morte.Text = obj_falecido.causa_morte;

                    //Label profissao = e.Item.FindControl("lbl_profissao") as Label;
                    //profissao.Text = obj_falecido.profissao;


                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu algum erro em sua busca. Por favor entre em contato com o suporte.');", true);
                //throw;
            }
        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.memoriafamiliar.online/Jazigo.aspx");
        }
    }
}