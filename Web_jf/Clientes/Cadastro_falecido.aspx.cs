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
    public partial class Cadastro_falecido : System.Web.UI.Page
    {
        int Cliente;
        int bValido = 0;
        int id_cliente;
        string extensao_arquivo;
        public string falecido;

        protected void Page_Load(object sender, EventArgs e)
        {
            MembershipUser Cliente = Membership.GetUser();
            string ID = Cliente.ProviderUserKey.ToString();

            DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente(ID);
            id_cliente = obj_cliente.ID_cliente;

            if (obj_cliente.Licenca_comprada == null || obj_cliente.Licenca_comprada == 0)
            {
                PnlOk.Visible = true;
                pnl_nook.Visible = false;
            }
            else
            {
                PnlOk.Visible = false;
                pnl_nook.Visible = true;
            }

            if (!IsPostBack)
            {
                if (Request.Cookies["navegacao"] != null && Request.Cookies["navegacao"].Value == "1")
                {
                    falecido = Request.Cookies["cod_falecido"].Value;
                    pnl_nook.Visible = true;

                    DAO.Juizofinal_falecido obj_falecido = DAO.Juizofinal_falecido.Get_falecido_busca(Convert.ToInt16(falecido));

                    txt_nome_falecido.Text = obj_falecido.Nome_falecido;
                    txt_nome_falecido.Enabled = false;

                    txt_nome_pai_falecido.Text = obj_falecido.Nome_pai;
                    txt_nome_mae_falecido.Text = obj_falecido.Nome_mae;

                    txt_dt_nascimento.Text = obj_falecido.data_nasceimento.Value.ToShortDateString();
                    txt_local_nascimento.Text = obj_falecido.cidade_nascimento;
                    txt_dt_morte.Text = obj_falecido.data_morte.Value.ToShortDateString();
                    txt_local_morte.Text = obj_falecido.cidade_morte;
                    txt_causa_morte.Text = obj_falecido.causa_morte;
                    txt_profissao.Text = obj_falecido.profissao;
                    txt_epitafio.Text = obj_falecido.epitafio;

                    File_Upload_foto.Visible = false;
                    lbl_texto.Visible = false;
                    btn_enviar.Visible = false;
                    btn_alterar.Visible = true;
                }
            }
        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            if (check_concordo.Checked == true)
            {
                try
                {
                    if (txt_nome_falecido.Text != String.Empty && txt_dt_nascimento.Text != String.Empty && txt_dt_morte.Text != String.Empty && txt_local_nascimento.Text != String.Empty && txt_local_morte.Text != String.Empty)
                    {
                        DAO.Juizofinal_falecido obj_falecido = new DAO.Juizofinal_falecido();
                        obj_falecido.Nome_falecido_busca = txt_nome_falecido.Text.Replace(" ", "_");
                        obj_falecido.Nome_falecido = txt_nome_falecido.Text;
                        obj_falecido.data_nasceimento = Convert.ToDateTime(txt_dt_nascimento.Text);
                        obj_falecido.data_morte = Convert.ToDateTime(txt_dt_morte.Text);
                        obj_falecido.epitafio = txt_epitafio.Text;
                        obj_falecido.Ativo = true;
                        obj_falecido.Nome_mae = txt_nome_mae_falecido.Text;
                        obj_falecido.Nome_pai = txt_nome_pai_falecido.Text;
                        obj_falecido.cidade_nascimento = txt_local_nascimento.Text;
                        obj_falecido.cidade_morte = txt_local_morte.Text;
                        obj_falecido.causa_morte = txt_causa_morte.Text;
                        obj_falecido.profissao = txt_profissao.Text;
                        obj_falecido.DT_Inclusao = DateTime.Now.Date;
                        //obj_falecido.ID_falecido_Pai = id_cliente;

                        if (File_Upload_foto.HasFile)
                        {
                            string fileExtension = System.IO.Path.GetExtension(File_Upload_foto.FileName).ToLower();

                            extensao_arquivo = fileExtension;
                            UploadArquivo();
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('É necessário adicionar uma foto ao cadastro.');", true);
                            return;
                        }

                        if (extensao_arquivo == ".png")
                        {
                            obj_falecido.foto_1 = txt_nome_falecido.Text.Replace(" ", "_") + ".png";
                        }
                        else if (extensao_arquivo == ".jpeg")
                        {
                            obj_falecido.foto_1 = txt_nome_falecido.Text.Replace(" ", "_") + ".jpeg";
                        }
                        else if (extensao_arquivo == ".jpg")
                        {
                            obj_falecido.foto_1 = txt_nome_falecido.Text.Replace(" ", "_") + ".jpg";
                        }

                        obj_falecido.Insert();

                        DAO.Juizofinal_cliente_falecido obj_cliente_falecido = new Juizofinal_cliente_falecido();

                        MembershipUser Cliente = Membership.GetUser();
                        string ID = Cliente.ProviderUserKey.ToString();

                        DAO.Juizofinal_cliente obj_cliente = DAO.Juizofinal_cliente.GetCliente(ID);

                        obj_cliente_falecido.ID_cliente = obj_cliente.ID_cliente;
                        obj_cliente_falecido.ID_falecido = obj_falecido.ID_falecido;
                        obj_cliente_falecido.Ativo = true;
                        obj_cliente_falecido.DT_Inclusao = DateTime.Now.Date;

                        obj_cliente_falecido.Insert();

                        DAO.Juizofinal_cliente obj_cliente_upd = DAO.Juizofinal_cliente.GetCliente_ID(obj_cliente.ID_cliente);

                        obj_cliente_upd.Licenca_comprada = obj_cliente.Licenca_comprada - 1;
                        obj_cliente_upd.UpdateRegistro();

                        Limpa_campos();

                        //ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('O cadastro de seu ente querido foi realizado com sucesso.');", true);
                        //Response.Redirect("/Default.aspx");

                        string mensagem = "O cadastro de seu ente querido foi realizado com sucesso.";
                        string url = "Default.aspx";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "alert('" + mensagem + "'); location='" + url + "';", true);
                        return;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Os campos Nome do Falecido, data de nascimento, data de falecimento, local do nascimento e local do falecimento precisam estar preenchidos');", true);
                        return;
                    }
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu um erro no cadastro do Ente querido. Por favor tente novamente ou entre em contato com o suporte.');", true);
                    //throw;
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Para continuar seu cadastro você deve aceitar o TERMO DE RESPONSABILIDADE CIVIL E PENAL.');", true);
                return;
            }
        }

        public void Limpa_campos()
        {
            txt_nome_falecido.Text = String.Empty;
            txt_nome_falecido.Text = String.Empty;
            txt_dt_nascimento.Text = String.Empty;
            txt_dt_morte.Text = String.Empty;
            txt_epitafio.Text = String.Empty;
            txt_nome_mae_falecido.Text = String.Empty;
            txt_nome_pai_falecido.Text = String.Empty;
            txt_local_nascimento.Text = String.Empty;
            txt_local_morte.Text = String.Empty;
            txt_causa_morte.Text = String.Empty;
            txt_profissao.Text = String.Empty;
            check_concordo.Checked = false;

        }

        private bool UploadArquivo()
        {
            string path_save = HttpContext.Current.Server.MapPath("/Fotos/");
            string path = HttpContext.Current.Server.MapPath("/Fotos/");

            if (extensao_arquivo == ".png")
            {
                File_Upload_foto.SaveAs(path_save + txt_nome_falecido.Text.Replace(" ", "_") + ".png");
            }
            else if (extensao_arquivo == ".jpeg")
            {
                File_Upload_foto.SaveAs(path_save + txt_nome_falecido.Text.Replace(" ", "_") + ".jpeg");
            }
            else if (extensao_arquivo == ".jpg")
            {
                File_Upload_foto.SaveAs(path_save + txt_nome_falecido.Text.Replace(" ", "_") + ".jpg");
            }

            return true;
        }

        protected void btn_alterar_Click(object sender, EventArgs e)
        {
            if (check_concordo.Checked == true)
            {
                try
                {
                    falecido = Request.Cookies["cod_falecido"].Value;
                    DAO.Juizofinal_falecido obj_falecido = DAO.Juizofinal_falecido.Get_falecido_busca(Convert.ToInt16(falecido));

                    obj_falecido.Nome_falecido = txt_nome_falecido.Text;
                    obj_falecido.data_nasceimento = Convert.ToDateTime(txt_dt_nascimento.Text);
                    obj_falecido.data_morte = Convert.ToDateTime(txt_dt_morte.Text);
                    obj_falecido.epitafio = txt_epitafio.Text;
                    obj_falecido.Nome_mae = txt_nome_mae_falecido.Text;
                    obj_falecido.Nome_pai = txt_nome_pai_falecido.Text;
                    obj_falecido.cidade_nascimento = txt_local_nascimento.Text;
                    obj_falecido.cidade_morte = txt_local_morte.Text;
                    obj_falecido.causa_morte = txt_causa_morte.Text;
                    obj_falecido.profissao = txt_profissao.Text;
                    obj_falecido.DT_Alteracao = DateTime.Now.Date;

                    obj_falecido.UpdateRegistro_falecido();

                    Response.Cookies["navegacao"].Expires = DateTime.Now.AddMinutes(1);

                    string mensagem = "Dados alterados com sucesso!";
                    string url = "Default.aspx";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "alert('" + mensagem + "'); location='" + url + "';", true);
                    return;

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Ocorreu um erro ao solicitar a alteração. Por favor entre em contato com o suporte.');", true);
                    //throw;
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Para continuar seu cadastro você deve aceitar o TERMO DE RESPONSABILIDADE CIVIL E PENAL.');", true);
                return;
            }
        }
    }
}