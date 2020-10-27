<%@ Page Title="" Language="C#" MasterPageFile="~/Web_Juizo.Master" AutoEventWireup="true" CodeBehind="Falecido.aspx.cs" Inherits="Web_jf.Falecido" %>

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
    <link href='http://localhost:1797/fonts.googleapis.com/css?family=Roboto+Condensed:400,700italic,700,400italic,300italic,300' rel='stylesheet' type='text/css' />
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
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="single-page-agile-main">
                <div class="container">
                    <div class="single-page-agile-info">
                        <!-- /movie-browse-agile -->
                        <div class="show-top-grids-w3lagile">
                            <div class="col-sm-8 single-left" style="margin-left:-9px;">
                                <div class="song">
                                    <div class="video-grid-single-page-agileits">
                                        <div style="margin-left: 5px; margin-right: 5px; margin-top: 5px; margin-bottom: 5px;">
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:ImageButton ID="image_buton" CssClass="divtdImg_2" ImageUrl="~/Fotos/" runat="server" />
                                                    </td>
                                                    <td style="padding-left: 15px">
                                                        <h4>
                                                            <asp:Label runat="server" ID="lblNome"></asp:Label></h4>
                                                        <br />
                                                        <p style="margin-left: -5px">
                                                            <asp:ImageButton ID="img_estrela" runat="server" ImageUrl="~/Images/estrela.png" />
                                                        </p>
                                                        <p style="margin-top: -27px; margin-left: 20px">
                                                            <asp:Label ID="lbl_dt_nascimento" runat="server" CssClass="texto"></asp:Label>
                                                        </p>
                                                        <p style="margin-left: 100px; margin-top: -20px;">
                                                            <asp:ImageButton ID="img_cruz" runat="server" ImageUrl="~/Images/cruz.png" />
                                                        </p>
                                                        <p style="margin-left: 120px; margin-top: -28px">
                                                            <asp:Label ID="lbl_dt_morte" runat="server" CssClass="texto"></asp:Label>
                                                        </p>
                                                    </td>
                                                </tr>
                                            </table>

                                        </div>
                                    </div>
                                </div>
                                <br />
                                <div class="song-grid-right">
                                    <div class="song-info">
                                        <h3>DADOS PESSOAIS</h3>
                                        <br />
                                        Viveu por:
                                <asp:Label ID="lbl_anos" runat="server"></asp:Label>
                                        anos.
                                <br />
                                        Nome do pai:
                                <asp:Label ID="lbl_nome_pai" runat="server"></asp:Label>
                                        .
                                <br />
                                        Nome da mãe:
                                <asp:Label ID="lbl_nome_mae" runat="server"></asp:Label>
                                        .
                                <br />
                                        Cidade onde nasceu:
                                <asp:Label ID="lbl_cidade_nascimento" runat="server"></asp:Label>
                                        .
                                <br />
                                        Profissão:
                                <asp:Label ID="lbl_prefissao" runat="server"></asp:Label>
                                        .
                                    </div>
                                    <br />
                                    <div class="song-info">
                                        <h3>DADOS DO FALECIMENTO</h3>
                                        <br />
                                        Cidade onde faleceu:
                                <asp:Label ID="lbl_local_morte" runat="server"></asp:Label>
                                        .
                                <br />
                                        Causa de sua morte:
                                <asp:Label ID="lbl_causa_morte" runat="server"></asp:Label>
                                        .
                                    </div>
                                    <br />
                                    <div class="song-info" style="text-align: justify">
                                        <h3>SUA HISTÓRIA</h3>
                                        <br />
                                        <asp:Label ID="lbl_epitafio" runat="server"></asp:Label>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </div>
                            <div class="col-md-4 single-right">
                                <h4>Marque sua visita</h4>
                                <div class="single-grid-right">
                                    <div class="single-right-grids">
                                        <asp:ImageButton ID="image_vela" CssClass="redondo" OnClick="image_voto_vela_Click" ImageUrl="~/Images/vela.png" runat="server" />
                                        <p>Acender uma vela.</p>
                                        <br />
                                        <asp:ImageButton ID="img_flores" CssClass="redondo_" OnClick="img_flores_Click" ImageUrl="~/Images/flores.png" runat="server" />
                                        <p>Depositar uma flor.</p>
                                        <div class="clearfix"></div>
                                    </div>
                                </div>
                                <div class="single-grid-right">
                                    <div class="single-right-grids">
                                        Velas acesas:
                                                        <asp:Label ID="num_visitas" runat="server"></asp:Label>
                                        <br />
                                        Flores depositadas:
                                                        <asp:Label ID="lbl_num_flores" runat="server"></asp:Label>
                                        <div class="clearfix"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
                <!-- //w3l-latest-movies-grids -->
            </div>
            <div style="text-align: center;">
                <asp:Button ID="btn_voltar" CssClass="main-btn_" runat="server" Text="Voltar" OnClick="btn_voltar_Click" Width="200px" />
            </div>
            <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
