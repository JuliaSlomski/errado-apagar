<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Web_juizo_Logado.Master" AutoEventWireup="true" CodeBehind="Cadastro_falecido.aspx.cs" Inherits="Web_jf.Clientes.Cadastro_falecido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <!-- for-mobile-apps -->
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="One Movies Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
		function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //for-mobile-apps -->
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="../css/contactstyle.css" type="text/css" media="all" />
    <link rel="stylesheet" href="../css/faqstyle.css" type="text/css" media="all" />
    <link href="../css/single.css" rel='stylesheet' type='text/css' />
    <link href="../css/medile.css" rel='stylesheet' type='text/css' />
    <!-- banner-slider -->
    <link href="../css/jquery.slidey.min.css" rel="stylesheet" />
    <!-- //banner-slider -->
    <!-- pop-up -->
    <link href="../css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
    <!-- //pop-up -->
    <!-- font-awesome icons -->
    <link rel="stylesheet" href="../css/font-awesome.min.css" />
    <!-- //font-awesome icons -->
    <!-- js -->
    <script type="text/javascript" src="../js/jquery-2.1.4.min.js"></script>
    <!-- //js -->
    <!-- banner-bottom-plugin -->
    <link href="../css/owl.carousel.css" rel="stylesheet" type="text/css" media="all" />
    <script src="../js/owl.carousel.js"></script>
    <script>
        $(document).ready(function () {
            $("#owl-demo").owlCarousel({

                autoPlay: 3000, //Set AutoPlay to 3 seconds

                items: 5,
                itemsDesktop: [640, 4],
                itemsDesktopSmall: [414, 3]

            });

        });
    </script>
    <!-- //banner-bottom-plugin -->
    <link href='//fonts.googleapis.com/css?family=Roboto+Condensed:400,700italic,700,400italic,300italic,300' rel='stylesheet' type='text/css' />
    <!-- start-smoth-scrolling -->
    <script type="text/javascript" src="../js/move-top.js"></script>
    <script type="text/javascript" src="../js/easing.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {
            $(".scroll").click(function (event) {
                event.preventDefault();
                $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
            });
        });
    </script>
    <!-- start-smoth-scrolling -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- single -->
    <div class="single-page-agile-main">
        <div class="container">
            <!-- /w3l-medile-movies-grids -->
            <div class="agileits-single-top">
                <ol class="breadcrumb">
                    <li><a href="Default.aspx">Home</a></li>
                    <li class="active">Castro de Ente Querido</li>
                </ol>
            </div>
            <div class="single-page-agile-info">
                <!-- /movie-browse-agile -->
                <div class="show-top-grids-w3lagile">
                    <div class="col-sm-8 single-left">
                        <div class="clearfix"></div>
                        <div class="all-comments">
                            <div class="all-comments-info">                               
                                <div class="agile-info-wthree-box">
                                    <asp:Panel ID="pnl_nook" runat="server" Visible="false">
                                        <div class="responsive-textbox">
                                             <p>Preencha os dados de seu Ente Querido</p>
                                            <br />
                                            <p><asp:Label ID="lbl_texto" runat="server" Text="Selecione o arquivo da FOTO:"></asp:Label><asp:FileUpload ID="File_Upload_foto" runat="server"/></p>
                                            <br />
                                            <asp:TextBox ID="txt_nome_falecido" runat="server" CssClass="responsive-textbox" MaxLength="100" Width="100%" placeholder="Nome Completo"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_nome_mae_falecido" runat="server" CssClass="responsive-textbox" MaxLength="50" Width="100%" placeholder="Nome da mãe"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_nome_pai_falecido" runat="server" CssClass="responsive-textbox" MaxLength="50" Width="100%" placeholder="Nome do pai"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_dt_nascimento" runat="server" CssClass="responsive-textbox" MaxLength="10" Width="100%" onkeyup="formataData(this, event);" placeholder="Data de nascimento"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_dt_morte" runat="server" CssClass="responsive-textbox" MaxLength="10" Width="100%" onkeyup="formataData(this, event);" placeholder="Data da morte"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_local_nascimento" runat="server" CssClass="responsive-textbox" MaxLength="50" Width="100%" placeholder="Cidade de seu nascimento"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_local_morte" runat="server" CssClass="responsive-textbox" MaxLength="50" Width="100%" placeholder="Cidade de sua morte"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_causa_morte" runat="server" CssClass="responsive-textbox" MaxLength="50" Width="100%" placeholder="Causa de sua morte"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_profissao" runat="server" CssClass="responsive-textbox" MaxLength="200" Width="100%" placeholder="Profissão exercida"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txt_epitafio" runat="server" CssClass="responsive-textbox" TextMode="MultiLine" MaxLength="500" Width="100%" placeholder="Escreva sobre seu ente querido"></asp:TextBox>
                                            <br />
                                            <p class="responsive-textbox" style="width: auto; text-align: justify">
                                                <asp:CheckBox ID="check_concordo" runat="server" />
                                                <b>Responsabilidade Civil e Penal</b><br />
                                                Declaro aceitar os termos de uso do Portal Memória Familiar e tenho ciência , dos termos da Lei 12.965,
                                        de 23 de abril de 2014 e da Lei 12.137, de 30 de novembro de 2012. Desse modo, responsabilizo-me
                                        pelas informações sobre a pessoa falecida, por mim cadastrada no Portal Juízo Final.
                                            </p>
                                            <br />
                                           <asp:Button ID="btn_enviar" runat="server" Text="Cadastrar" OnClick="btn_enviar_Click" />
                                           <asp:Button ID="btn_alterar" runat="server" Text="Alterar dados" OnClick="btn_alterar_Click" Visible="false" />
                                        </div>
                                    </asp:Panel>
                                    <div class="clearfix"></div>
                                    <asp:Panel ID="PnlOk" runat="server" Visible="false">
                                        <div class="responsive-textbox">
                                            <p style="width: 100%; text-align: center; font-size: 14px;">
                                                <b>OPS! Seus cadastros acabaram.</b>
                                                <br />
                                                Para realizar novos cadastros você deve realizar nova compra.
                                            </p>
                                        </div>
                                    </asp:Panel>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
            <!-- //w3l-latest-movies-grids -->
        </div>
    </div>
    <!-- //w3l-medile-movies-grids -->
</asp:Content>
