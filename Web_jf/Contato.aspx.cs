using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_jf
{
    public partial class Contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
             if (txt_nome.Text != String.Empty && txt_sobrenome.Text != String.Empty && txt_email.Text != String.Empty && txt_mensagem.Text != String.Empty)
            {
                DAO.Email.EnviarContato("contato@memoriafamiliar.online", txt_assunto.Text, txt_nome.Text, txt_sobrenome.Text, txt_email.Text, txt_mensagem.Text);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Mensagem enviada com sucesso, logo retornaremos.');", true);
                
                LimpaCampos();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Preencha corretamente os dados para nos enviar uma mensagem.');", true);
            }
        }

        private void LimpaCampos()
        {
            txt_nome.Text = String.Empty;
            txt_email.Text = String.Empty;
            txt_assunto.Text = String.Empty;
            txt_mensagem.Text = String.Empty;
            txt_sobrenome.Text = String.Empty;
        }
    }
}