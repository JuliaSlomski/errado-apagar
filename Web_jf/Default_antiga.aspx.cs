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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                //SqlCommand cmd = new SqlCommand("Select top 12 ID_falecido, ID_falecido_Pai, Nome_falecido, data_nasceimento, data_morte, epitafio, Ativo, DT_Inclusao, DT_Alteracao, DT_Exclusao, Nome_falecido_busca, Nome_mae, Nome_pai, cidade_nascimento, cidade_morte, causa_morte, foto_1  from Juizofinal_falecido order by DT_Inclusao desc", sqlcon);
                SqlCommand cmd = new SqlCommand("SELECT TOP 12 ID_falecido, ID_falecido_Pai, Nome_falecido, data_nasceimento, data_morte, epitafio, Ativo, DT_Inclusao, DT_Alteracao, DT_Exclusao, Nome_falecido_busca, Nome_mae, Nome_pai, cidade_nascimento, cidade_morte, causa_morte, foto_1 FROM juizofinal_falecido ORDER BY NEWID()", sqlcon);
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
                    HyperLink PriceLabel = (HyperLink)e.Item.FindControl("HyperLink1");
                    PriceLabel.NavigateUrl = "~/Falecido/" + ((DataRowView)e.Item.DataItem).Row.ItemArray[10].ToString(); // .Row.ItemArray[10] tem o valor da coluna nome_falecido_busca
                    //PriceLabel.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[3].ToString().Substring(0,10);

                    Label nome = (Label)e.Item.FindControl("lblCName");
                    nome.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[2].ToString();

                    if (nome.Text.Count() >= 20)
                    {
                        nome.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[2].ToString().Substring(0, 20) + "...";
                    }
                    else
                    {
                        nome.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[2].ToString();
                    }

                    Label dt_nas = (Label)e.Item.FindControl("dt_nascimento");
                    dt_nas.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[03].ToString().Substring(6,4);

                    Label dt_mor = (Label)e.Item.FindControl("dt_morte");
                    dt_mor.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[04].ToString().Substring(6, 4);


                    Image foto = (Image)e.Item.FindControl("Image1");
                    foto.ImageUrl = "~/Fotos/" + ((DataRowView)e.Item.DataItem).Row.ItemArray[16].ToString();// .Row.ItemArray[17] tem o valor da coluna foto_1
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu algum erro em sua busca. Por favor entre em contato com o suporte.');", true);
                //throw;
            }
        }

        protected void A_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'a%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void B_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'b%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void C_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'c%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void D_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'd%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void E_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'e%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void F_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'f%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void G_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'g%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void H_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'h%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void I_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'i%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void J_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'j%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void K_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'k%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void L_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'l%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void M_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'm%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void N_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'n%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void O_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'o%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void P_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'p%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void Q_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'q%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void R_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'r%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void S_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 's%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void T_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 't%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void U_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'u%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void V_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'v%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void X_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'x%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void Z_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'z%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void W_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'w%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }

        protected void Y_Click(object sender, EventArgs e)
        {
            var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
            SqlConnection sqlcon = null;
            sqlcon = new SqlConnection(strConn);
            sqlcon.Open();

            DataSet tbl = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Juizofinal_falecido where Nome_falecido_busca LIKE 'y%' order by Nome_falecido_busca", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tbl);
            DataList1.DataSource = tbl.Tables[0];
            DataList1.DataBind();
        }
    }
}