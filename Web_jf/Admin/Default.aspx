<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Web_juizo_logado.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_jf.Admin.Default1" %>

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
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <!-- single -->
    <div class="single-page-agile-main">
        <div class="container">
            <!-- /w3l-medile-movies-grids -->
            <div class="agileits-single-top">
                <ol class="breadcrumb">
                    <li><a href="index.html">Home</a></li>
                    <li class="active">Adimin</li>
                </ol>
            </div>
            <div class="single-page-agile-info">
                <!-- /movie-browse-agile -->
                <div class="show-top-grids-w3lagile">
                    <div class="col-sm-8 single-left">
                        <div class="clearfix"></div>
                        <div class="all-comments">
                            <div class="all-comments-info">
                                Bem vindo a área Admin
                                <div class="agile-info-wthree-box">
                                    <div class="responsive-textbox">
                                        <asp:UpdatePanel ID="upd_informacoes" runat="server" Visible="true">
                                            <ContentTemplate>
                                                <div id="dialog" class="responsive-textbox" style="width: 100%; min-height: 250px;">
                                                    <table class="table table-hover table-nomargin">
                                                        <thead>
                                                            <tr>
                                                                <th>Nome Cliente</th>
                                                                <th>Licenças compradas</th>
                                                                <th>Jazigo comprado</th>
                                                                <th></th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <asp:Repeater ID="rptDados" runat="server" OnItemDataBound="rptDados_ItemDataBound">
                                                                <ItemTemplate>
                                                                    <tr class="odd">
                                                                        <td>
                                                                            <asp:Label ID="lbl_nome_cliente" runat="server"></asp:Label></td>
                                                                        <td>
                                                                            <asp:Label ID="lbl_licenca" runat="server"></asp:Label></td>
                                                                        <td>
                                                                            <asp:Label ID="lbl_jazigo" runat="server"></asp:Label></td>
                                                                        <td>
                                                                            <asp:ImageButton ID="btn_atualizar" runat="server" OnCommand="btn_atualizar_Command" /></td>
                                                                    </tr>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
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
    </div>
    <!-- //w3l-medile-movies-grids -->
</asp:Content>
