<%@ Page Title="" Language="C#" MasterPageFile="~/Web_Juizo.Master" AutoEventWireup="true" CodeBehind="Jazigo_formado.aspx.cs" Inherits="Web_jf.Jazigo_formado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- for-mobile-apps -->
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="One Movies Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
		function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //for-mobile-apps -->
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link rel="stylesheet" href="css/faqstyle.css" type="text/css" media="all" />
    <link href="css/medile.css" rel='stylesheet' type='text/css' />
    <link href="css/single.css" rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="css/contactstyle.css" type="text/css" media="all" />
    <!-- news-css -->
    <link rel="stylesheet" href="news-css/news.css" type="text/css" media="all" />
    <!-- //news-css -->
    <!-- list-css -->
    <link rel="stylesheet" href="list-css/list.css" type="text/css" media="all" />
    <!-- //list-css -->
    <!-- font-awesome icons -->
    <link rel="stylesheet" href="css/font-awesome.min.css" />
    <!-- //font-awesome icons -->
    <!-- js -->
    <script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
    <!-- //js -->
    <link href='//fonts.googleapis.com/css?family=Roboto+Condensed:400,700italic,700,400italic,300italic,300' rel='stylesheet' type='text/css' />
    <!-- start-smoth-scrolling -->
    <script type="text/javascript" src="js/move-top.js"></script>
    <script type="text/javascript" src="js/easing.js"></script>
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
                    <li class="active">Jazigos</li>
                </ol>
            </div>
            <div class="single-page-agile-info">
                <!-- /movie-browse-agile -->
                <div class="show-top-grids-w3lagile">
                    <div class="col-sm-8 single-left">
                        <div class="song">
                            <h4 style="text-align: left; color: black;">Jazigo da Família de
                                <asp:Label ID="lbl_nome_jazigo" runat="server"></asp:Label></h4>
                            <br />
                        </div>
                        <%--<div class="song-grid-right">--%>
                        <%--<div class="responsive-textbox" style="text-align: center;">--%>
                        <div style="margin-left: -20px;">
                            <asp:DataList ID="DataList1" runat="server" Font-Size="Small" CellPadding="10" CellSpacing="10" RepeatColumns="3" RepeatLayout="Table" RepeatDirection="Horizontal" OnItemDataBound="Item_Bound">
                                <ItemTemplate>
                                    <ul>
                                        <li class="li">
                                            <b>
                                                <asp:Label ID="lbl_parentesco" CssClass="hyp_" runat="server" Text=""></asp:Label></b>
                                            <br />
                                            <asp:Label ID="lbl_nome_falecido" CssClass="hyp_" runat="server" Text=""></asp:Label>
                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Fotos/" CssClass="divtdImg" />
                                            <br />
                                            <p style="margin-left: -78px; margin-bottom: -40px; padding-top: 10px;">
                                                <asp:ImageButton ID="img_estrela" runat="server" ImageUrl="~/Images/estrela.png" />
                                            </p>
                                            <p style="margin-left: -35px; margin-top: 13px; margin-bottom: -5px;">
                                                <asp:Label ID="lbl_dt_nascimento" CssClass="hyp_" runat="server"></asp:Label>
                                            </p>
                                            <p style="margin-left: 20px; margin-top: -20px">
                                                <asp:ImageButton ID="img_cruz" runat="server" ImageUrl="~/Images/cruz.png" />
                                            </p>
                                            <p style="margin-left: 70px; margin-bottom: 4px; margin-top: -27px;">
                                                <asp:Label ID="lbl_dt_morte" CssClass="hyp_" runat="server"></asp:Label>
                                            </p>
                                            <p class="hyp_">
                                                <asp:Label ID="lbl_causa_morte" CssClass="hyp_" runat="server"></asp:Label>.
                                            </p>
                                        </li>
                                    </ul>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                        <div class="clearfix"></div>
                        <%-- </div>--%>
                        <%-- </div>--%>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <div style="text-align: center;">
        <asp:Button ID="btn_voltar" CssClass="main-btn_" runat="server" Text="Voltar" OnClick="btn_voltar_Click" Width="200px" />
    </div>
    <br />
</asp:Content>
