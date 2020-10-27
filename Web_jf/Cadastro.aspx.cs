using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Web_jf
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CreateUserWizard1.CssClass = "responsive-textbox";
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

            try
            {
                Roles.AddUserToRole((sender as CreateUserWizard).UserName, "Clientes");

                DAO.Juizofinal_cliente.RodaProc();

                DAO.Juizofinal_cliente obj = DAO.Juizofinal_cliente.busca_cliente(CreateUserWizard1.UserName);
                obj.Jazigo_comprado = 1;
                if (check_corporacoes.Checked == true)
                {
                    obj.Corporacao = true;
                }
                obj.UpdateRegistro();

                DAO.Email.Pessoa_cadastrada("contato@juizofinal.online", CreateUserWizard1.UserName);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Cadastro realizado com sucesso!');", true);
                
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu um erro em seu cadastro. Favor mande um e-mail para nosso contato.');", true);
                //throw;
            }
        }
    }
}