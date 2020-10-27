using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace Web_jf
{
    public partial class Web_Juizo : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn_acessar_Click(object sender, EventArgs e)
        {

            if (Membership.ValidateUser(txt_login.Text, txt_senha.Text) == true)
            {
                var userRoles = System.Web.Security.Roles.GetRolesForUser(txt_login.Text);

                if (Roles.IsUserInRole(txt_login.Text, "Clientes") == true)
                {

                    FormsAuthentication.RedirectFromLoginPage(txt_login.Text, false);

                }
                else if (Roles.IsUserInRole(txt_login.Text, "Admin"))
                {

                    //FormsAuthentication.RedirectFromLoginPage(txt_login.Text, false);
                    FormsAuthentication.SetAuthCookie(txt_login.Text, false);
                    Response.Redirect("~/Admin/Default.aspx");

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ixi, tem algo errado! Já verificou o nome de usuário, aquele que você cadastrou anteriormente, está correto? Não é seu e-mail!');", true);
                    return;
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ixi, tem algo errado! Já verificou o nome de usuário, aquele que você cadastrou anteriormente, está correto? Não é seu e-mail!');", true);
                return;
            }
        }
    }
}