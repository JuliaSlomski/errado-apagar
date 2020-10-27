<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Web_juizo_Logado.Master" AutoEventWireup="true" CodeBehind="Jazigo.aspx.cs" Inherits="Web_jf.Clientes.Jazigo" %>

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

    <style type="text/css">
        .col_1 {
            min-width: 150px;
            text-align: left;
        }

        .col_2 {
            width: auto;
            text-align: left;
        }

        .responsive-textbox {
            text-align: left;
        }
    </style>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- single -->
    <div class="single-page-agile-main">
        <div class="container">
            <!-- /w3l-medile-movies-grids -->
            <div class="agileits-single-top">
                <ol class="breadcrumb">
                    <li><a href="Default.aspx">Home</a></li>
                    <li class="active">Construção do Jazigo de sua família</li>
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
                                    <asp:Panel ID="pnl_jazigo" runat="server" Visible="false">
                                        <div class="responsive-textbox">
                                            <p style="font-size: 14px; margin-top: -20px;">
                                                <b>Jazigo de: </b>
                                                <asp:TextBox ID="txt_nome_jazigo" runat="server" Enabled="true"></asp:TextBox>
                                            </p>
                                            Selecione os dados corretos
                                        <br />
                                            <br />
                                            <p style="text-align: left; margin-bottom: 10px;">
                                                <asp:DropDownList ID="drop_falecido" Width="100%" runat="server"></asp:DropDownList>
                                            </p>
                                            <p style="text-align: left; margin-bottom: 5px;">
                                                <asp:DropDownList ID="drop_parentesco" Width="100%" runat="server" Visible="false"></asp:DropDownList>
                                            </p>
                                            <p style="text-align: left; margin-bottom: 5px;">
                                                <asp:DropDownList ID="drop_corporacao" Width="100%" runat="server" Visible="false"></asp:DropDownList>
                                            </p>
                                            <br />
                                            <p style="width: 100%;">
                                                <asp:Button ID="btn_enviar" runat="server" Text="Cadastrar" OnClick="btn_enviar_Click" />
                                            </p>
                                            <br />
                                            <div>
                                                <table style="text-align: left">
                                                    <thead>
                                                        <tr>
                                                            <th class="col_1">Parentesco</th>
                                                            <th class="col_2">Nome do falecido</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <asp:Repeater ID="rptDados" runat="server" OnItemDataBound="rptDados_ItemDataBound">
                                                            <ItemTemplate>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="lbl_parentesco" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lbl_falecido_cadastrado" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                        </asp:Repeater>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                    <div class="clearfix"></div>
                                    <asp:Panel ID="pnl_usuario" runat="server" Visible="false">
                                        <div class="responsive-textbox">
                                            <p style="width: 100%; text-align: center; font-size: 14px;">
                                                <b>OPS! </b>
                                                <br />
                                                Para realizar o cadastro de um Jazigo você deve comprar o espaço.
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
