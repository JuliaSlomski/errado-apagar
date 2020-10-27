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
    public partial class Jazigo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            BindData_jazigo();

        }

        protected void BindData_jazigo()
        {
            try
            {
                var strConn = System.Configuration.ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString;
                SqlConnection sqlcon = null;
                sqlcon = new SqlConnection(strConn);
                sqlcon.Open();

                DataSet tbl = new DataSet();

                SqlCommand cmd = new SqlCommand("Select distinct ID_cliente, Nome_jazigo from Juizofinal_jazigo order by Nome_jazigo asc", sqlcon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tbl);
                jazigos.DataSource = tbl.Tables[0];
                jazigos.DataBind();
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu um erro.');", true);
                //throw;
            }
        }

        protected void jazigos_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            try
            {
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    //ImageButton foto = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceHolder1").FindControl("Image1");
                    //foto.ImageUrl = "~/Images/jazigo_2.png";

                    HyperLink PriceLabel = (HyperLink)e.Item.FindControl("HyperLink1");

                    PriceLabel.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[01].ToString();
                    PriceLabel.ID = ((DataRowView)e.Item.DataItem).Row.ItemArray[0].ToString();
                    PriceLabel.NavigateUrl = "Jazigo_formado.aspx?ID=" + ((DataRowView)e.Item.DataItem).Row.ItemArray[0].ToString();

                    if (PriceLabel.Text.Count() >= 13)
                    {
                        PriceLabel.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[01].ToString().Substring(0, 13) + "...";
                    }
                    else
                    {
                        PriceLabel.Text = ((DataRowView)e.Item.DataItem).Row.ItemArray[01].ToString();
                    }
                    
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu algum erro em sua busca. Por favor entre em contato com o suporte.');", true);
                //throw;
            }
        }
    }
}