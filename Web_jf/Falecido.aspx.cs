using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Web_jf
{
    public partial class Falecido : System.Web.UI.Page
    {

        int anos;
        int meses;
        //int con;

        double ianos;
        double imeses;
        double diferenca;
        double anos_utilizar;

        int estrelas_azuis;
        int estrelas_brancas;
        int estrelas_vermelhas;

        int soma_julgamentos;

        public string _falecido = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                this.Master.FindControl("pnl_menu").Visible = false;
                UpdatePanel1.Update();
            }

            // apenas colocando o valor da coluna nome_falecido_busca no label na página de routing
            //lblNome.Text = Page.RouteData.Values["nome"].ToString();
            DAO.Juizofinal_falecido obj = DAO.Juizofinal_falecido.Get_falecido(Page.RouteData.Values["nome"].ToString());

            ImageButton foto = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("image_buton");
            foto.ImageUrl = "~/Fotos/" + obj.foto_1;

            //ImageButton foto_ = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("imgb_azul");
            //foto_.ImageUrl = "~/Images/target_3.png";

            //ImageButton foto_1 = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("imgb_branca");
            //foto_1.ImageUrl = "~/Images/target_3.png";

            //ImageButton foto_2 = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("imgb_vermelha");
            //foto_2.ImageUrl = "~/Images/target_3.png";

            ImageButton vela = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("image_vela");
            vela.ImageUrl = "~/Images/vela.png";

            //ImageButton voto_vela = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("image_voto_vela");
            //voto_vela.ImageUrl = "~/Images/target_3.png";


            //ImageButton deixar_flor = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("img_flor");
            //deixar_flor.ImageUrl = "~/Images/target_3.png";

            ImageButton flor = (ImageButton)((MasterPage)((Page)sender).Controls[0]).FindControl("ContentPlaceholder1").FindControl("img_flores");
            flor.ImageUrl = "~/Images/flores.png";

          
            lblNome.Text = obj.Nome_falecido;
            //lblNome_2.Text = obj.Nome_falecido;
            //lbl_nome_capa.Text = obj.Nome_falecido;
            lbl_epitafio.Text = obj.epitafio;
            lbl_dt_nascimento.Text = obj.data_nasceimento.Value.ToShortDateString();
            lbl_dt_morte.Text = obj.data_morte.Value.ToShortDateString();

            calcula();
            lbl_anos.Text = Session["anos"].ToString();
            //lbl_meses.Text = Session["meses"].ToString();

            lbl_nome_mae.Text = obj.Nome_mae;
            lbl_nome_pai.Text = obj.Nome_pai;
            lbl_cidade_nascimento.Text = obj.cidade_nascimento;
            lbl_local_morte.Text = obj.cidade_morte;
            lbl_causa_morte.Text = obj.causa_morte;
            lbl_prefissao.Text = obj.profissao;

            if (obj.vela == null)
            {
                num_visitas.Text = "0";
            }
            else
            {
                num_visitas.Text = obj.vela.Value.ToString();
            }

            if (obj.estrelas_azuis == null)
            {
                lbl_num_flores.Text = "0";
            }
            else
            {
                lbl_num_flores.Text = obj.estrelas_azuis.Value.ToString();
            }

            estrelas_azuis = Convert.ToInt16(obj.estrelas_azuis);
            estrelas_brancas = Convert.ToInt16(obj.estrelas_brancas);
            estrelas_vermelhas = Convert.ToInt16(obj.estrelas_vermelhas);

            soma_julgamentos = estrelas_azuis + estrelas_brancas + estrelas_vermelhas;
            //lbl_num_julgadores.Text = soma_julgamentos.ToString();


            //if (estrelas_azuis > estrelas_brancas && estrelas_azuis >= estrelas_brancas && estrelas_azuis > estrelas_vermelhas)
            //{
            //    lbl_julgamento.Text = "CÉU";
            //}
            //else if (estrelas_brancas > estrelas_azuis && estrelas_brancas > estrelas_vermelhas)
            //{
            //    lbl_julgamento.Text = "PURGATÓRIO";
            //}
            //else if (estrelas_azuis == 0 && estrelas_brancas == 0 && estrelas_vermelhas == 0)
            //{
            //    lbl_julgamento.Text = "PURGATÓRIO";
            //}
            //else if (estrelas_vermelhas >= estrelas_azuis && estrelas_vermelhas > estrelas_brancas)
            //{
            //    lbl_julgamento.Text = "INFERNO";
            //}

            UpdatePanel1.Update();
        }

        public void calcula()
        {
            DateTime datanascimento = Convert.ToDateTime(lbl_dt_nascimento.Text);
            DateTime datamorte = Convert.ToDateTime(lbl_dt_morte.Text);

            TimeSpan Intervalo = datamorte - datanascimento;

            int NumeroDeAnos = Intervalo.Days / 365;

            diferenca = Convert.ToDouble(NumeroDeAnos);

            ianos = diferenca / 365.25;
            anos = Convert.ToInt16(ianos);
            imeses = (ianos - anos) * 12;
            meses = Convert.ToInt16(imeses);
            //dias = 0;

            anos_utilizar = diferenca;

            Session["anos"] = diferenca;
            Session["meses"] = meses;
        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.memoriafamiliar.online/Default.aspx");
        }

        //protected void imgb_azul_Click(object sender, ImageClickEventArgs e)
        //{
        //    DAO.Juizofinal_falecido obj_estrela = DAO.Juizofinal_falecido.Get_falecido(Page.RouteData.Values["nome"].ToString());

        //    if (obj_estrela.estrelas_azuis == null)
        //    {
        //        obj_estrela.estrelas_azuis = 1;

        //    }
        //    else
        //    {
        //        obj_estrela.estrelas_azuis = obj_estrela.estrelas_azuis + 1;
        //    }
        //    obj_estrela.UpdateRegistro();

        //    soma_julgamentos = Convert.ToInt16(obj_estrela.estrelas_azuis) + estrelas_brancas + estrelas_vermelhas;
        //    lbl_num_julgadores.Text = soma_julgamentos.ToString();

        //    UpdatePanel1.Update();
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Obrigado por seu julgamento.');", true);
        //}

        //protected void imgb_branca_Click(object sender, ImageClickEventArgs e)
        //{
        //    DAO.Juizofinal_falecido obj_estrela = DAO.Juizofinal_falecido.Get_falecido(Page.RouteData.Values["nome"].ToString());

        //    if (obj_estrela.estrelas_brancas == null)
        //    {
        //        obj_estrela.estrelas_brancas = 1;

        //    }
        //    else
        //    {
        //        obj_estrela.estrelas_brancas = obj_estrela.estrelas_brancas + 1;
        //    }

        //    obj_estrela.UpdateRegistro();

        //    soma_julgamentos = estrelas_azuis + Convert.ToInt16(obj_estrela.estrelas_brancas) + estrelas_vermelhas;
        //    lbl_num_julgadores.Text = soma_julgamentos.ToString();

        //    UpdatePanel1.Update();
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Obrigado por seu julgamento.');", true);

        //}

        //protected void imgb_vermelha_Click(object sender, ImageClickEventArgs e)
        //{
        //    DAO.Juizofinal_falecido obj_estrela = DAO.Juizofinal_falecido.Get_falecido(Page.RouteData.Values["nome"].ToString());

        //    if (obj_estrela.estrelas_vermelhas == null)
        //    {
        //        obj_estrela.estrelas_vermelhas = 1;

        //    }
        //    else
        //    {
        //        obj_estrela.estrelas_vermelhas = obj_estrela.estrelas_vermelhas + 1;
        //    }
        //    obj_estrela.UpdateRegistro();


        //    soma_julgamentos = estrelas_azuis + estrelas_brancas + Convert.ToInt16(obj_estrela.estrelas_vermelhas);
        //    lbl_num_julgadores.Text = soma_julgamentos.ToString();
        //    UpdatePanel1.Update();

        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Obrigado por seu julgamento.');", true);
        //}

        protected void image_voto_vela_Click(object sender, ImageClickEventArgs e)
        {
            DAO.Juizofinal_falecido obj_vela = DAO.Juizofinal_falecido.Get_falecido(Page.RouteData.Values["nome"].ToString());

            if (obj_vela.vela == null)
            {
                obj_vela.vela = 1;
            }
            else
            {
                obj_vela.vela = obj_vela.vela + 1;
            }

            obj_vela.UpdateRegistro();

            num_visitas.Text = obj_vela.vela.Value.ToString();
            UpdatePanel1.Update();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Vela acendida. Obrigado pela visita.');", true);
        }

        protected void img_flores_Click(object sender, ImageClickEventArgs e)
        {
            DAO.Juizofinal_falecido obj_vela = DAO.Juizofinal_falecido.Get_falecido(Page.RouteData.Values["nome"].ToString());

            if (obj_vela.estrelas_azuis == null)
            {
                obj_vela.estrelas_azuis = 1;
            }
            else
            {
                obj_vela.estrelas_azuis = obj_vela.estrelas_azuis + 1;
            }

            obj_vela.UpdateRegistro();

            lbl_num_flores.Text = obj_vela.estrelas_azuis.Value.ToString();
            UpdatePanel1.Update();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "Ok", "alert('Flor depositada no túmulo. Obrigado pela visita.');", true);
        }


    }
}