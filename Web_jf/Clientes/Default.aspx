<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Web_juizo_Logado.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_jf.Clientes.Default" %>

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
    <script type="text/javascript" src="../js/Mascaras.js"></script>
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


    <style type="text/css">
        .ui-datalist-data {
            border: none !important;
            list-style-type: none;
        }

        .li_3 {
            width: auto;
            height: auto;
            list-style-type: none;
            overflow: hidden;
            border: none !important;
            margin-left: 10px;
            margin-right: 10px;
            margin-top: 10px;
            margin-bottom: 10px;
        }

        .float {
            margin-top: -10px;
            margin-left: 50%;
        }
    </style>


    <!-- Juliana inicio -->


    <!-- Juliana FIM -->

    <!-- start-smoth-scrolling -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <!-- faq-banner -->
            <div class="faq">
                <div class="container">
                    <div class="agileits-news-top">
                        <ol class="breadcrumb">
                            <li><a href="Default.aspx">Home</a></li>
                        </ol>
                    </div>
                    <div class="agileinfo-news-top-grids">
                        <div class="col-md-8 wthree-top-news-left">
                            <div class="wthree-news-left">
                                <div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
                                    <div id="myTabContent" class="tab-content">
                                        <div role="tabpanel" class="tab-pane fade in active" id="home1" aria-labelledby="home1-tab">
                                            <div class="wthree-news-top-left">
                                                <div class="col-md-6 w3-agileits-news-left">
                                                    <div class="">
                                                        <asp:UpdatePanel ID="upd_informacoes" runat="server" Visible="true">
                                                            <ContentTemplate>
                                                                <asp:Panel ID="pnl_modal" runat="server" Visible="false" class="responsive-textbox" Style="width: 100%; min-height: 250px;">
                                                                    <div id="dialog" title="Mensagem importante">
                                                                        <p>Para lhe enviar a Nota Fiscal caso você compre nossos serviços precisamos destas informações.</p>
                                                                        <br />
                                                                        <asp:TextBox ID="txt_jazigo_corporacao" runat="server" Visible="false" CssClass="popup" placeholder="Nome do Jazigo corporativo"></asp:TextBox>
                                                                        <br />
                                                                        <asp:TextBox ID="txt_nome_completo" runat="server" CssClass="popup" placeholder="Nome completo"></asp:TextBox>
                                                                        <br />
                                                                        <asp:TextBox ID="txt_email_cliente" runat="server" CssClass="popup" placeholder="Informe seu e-mail"></asp:TextBox>
                                                                        <br />
                                                                        <asp:TextBox ID="txt_cpf" runat="server" CssClass="popup" onkeyup="formataCPF(this, event);" MaxLength="14" placeholder="CPF"></asp:TextBox>
                                                                        <p style="text-align: left">
                                                                            <asp:Button ID="btn_modal" runat="server" CssClass="popup_btn" Text="Cadastrar" OnClick="btn_modal_Click" Visible="true" />
                                                                        </p>
                                                                        <script type="text/javascript">Sys.Application.add_load(BindEvents);</script>
                                                                    </div>
                                                                </asp:Panel>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>

                                                        <asp:Panel ID="pnl_usuario_compra" runat="server" Visible="false" class="responsive-textbox" Style="width: 100%; min-height: 250px;">
                                                            <h5>Ente Querido(s) Cadastrado(s)</h5>
                                                            <p>
                                                                Você ainda possui
                            <asp:Label ID="lbl_licencas" runat="server"></asp:Label>
                                                                espaço(s) para cadastro(s).
                                                            </p>
                                                            <br />
                                                            <div class="responsive-textbox" style="width: 100%; min-height: 250px;">
                                                                <asp:DataList ID="rptDados" runat="server" Font-Size="Small" GridLines="Both" BorderStyle="None" BorderWidth="0px" RepeatColumns="1" RepeatDirection="vertical" OnItemDataBound="rptDados_ItemDataBound1">
                                                                    <ItemTemplate>
                                                                        <tr class="ui-datalist-data">
                                                                            <td class="li_3" style="text-align: center">
                                                                                <asp:Label ID="lbl_nome_falecido" runat="server"></asp:Label>
                                                                            </td>
                                                                            <td class="li_3">
                                                                                <p>
                                                                                    <asp:ImageButton ID="id_falecido" CssClass="float" runat="server" OnCommand="id_falecido_Command" />
                                                                                </p>
                                                                            </td>
                                                                        </tr>
                                                                    </ItemTemplate>
                                                                </asp:DataList>
                                                            </div>
                                                        </asp:Panel>

                                                        <asp:Panel ID="pnl_usuario" runat="server" Visible="false">
                                                            <div class="responsive-textbox" style="width: 100%; min-height: 250px;">
                                                                <p style="width: 100%; text-align: center; font-size: 14px;">
                                                                    <h5>Realize uma compra para fazer o <b>cadastro de um falecido</b>.</h5>
                                                                    <br />
                                                                    <h5>Você possui um <b>jazigo gratuito</b>.</h5>
                                                                    <br />
                                                                    <h5>Clique em <b>cadastro Jazigo</b> e cadastre seus familiares.</h5>
                                                                </p>
                                                            </div>
                                                        </asp:Panel>

                                                        <asp:Panel ID="pnl_usuario_ok" runat="server" Visible="false">
                                                            <div class="responsive-textbox" style="width: 100%; min-height: 250px;">
                                                                <p style="width: 100%; text-align: center; font-size: 14px;">
                                                                    Você possui
                            <asp:Label ID="lbl_licencas_2" runat="server"></asp:Label>
                                                                    espaço(s) para cadastro(s).
                                                                </p>
                                                                <h5>Você ainda não cadastrou nenhum Ente Querido.</h5>
                                                            </div>
                                                        </asp:Panel>

                                                    </div>
                                                    <div class="clearfix"></div>
                                                </div>

                                                <div class="clearfix"></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
            <!-- //faq-banner -->
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
