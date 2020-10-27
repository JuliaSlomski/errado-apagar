<%@ Page Title="" Language="C#" MasterPageFile="~/Web_Juizo.Master" AutoEventWireup="true" CodeBehind="Jazigo.aspx.cs" Inherits="Web_jf.Jazigo" %>

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
    <link href='http://localhost:1797/fonts.googleapis.com/css?family=Roboto+Condensed:400,700italic,700,400italic,300italic,300' rel='stylesheet' type='text/css' />
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
                            <h3>MONUMENTOS FUNERÁRIOS</h3>
                        </div>
                        <br />
                        <div class="song-grid-right">
                            <asp:Panel ID="pnl_jazigo" runat="server" Visible="true">
                                <div style="margin-left: -20px;">
                                    <asp:DataList ID="jazigos" runat="server" Font-Size="Small" CellPadding="10" CellSpacing="10" RepeatColumns="3" RepeatLayout="Table" RepeatDirection="Horizontal" OnItemDataBound="jazigos_ItemDataBound">
                                        <ItemTemplate>
                                            <ul>
                                                <li class="li">
                                                    <%--<asp:Image ID="Image1" ImageUrl="~/Images/jazigo_2.png" CssClass="divtdImg" runat="server" />--%>
                                                    <%--<asp:ImageButton ID="Image1" ImageUrl="~/Images/jazigo_2.png" CssClass="divtdImg" runat="server"/>--%>
                                                    Jazigo da Família de<br />
                                                    <asp:HyperLink ID="HyperLink1" class="hyp_" runat="server"></asp:HyperLink>
                                                </li>
                                            </ul>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </div>
                            </asp:Panel>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="col-md-4 single-right">
                        <h3>ESPAÇO PARA PUBLICIDADE</h3>
                        <div class="single-grid-right">
                            <div class="single-right-grids">
                                <table style="border: solid 1px black; text-align: center; width: 90%; height: 60px; font-size: 13px;">
                                    <tr>
                                        <td style="padding-top: 5px; padding-bottom: 5px;">Este espaço está livre para publicidade ou patrocinadores.
                                            <br />
                                            Se você tiver interesse entre em contato com nossa equipe.</td>
                                    </tr>
                                </table>
                                <div class="clearfix"></div>
                            </div>
                            <%--<div class="single-right-grids">
                               
                                <div class="clearfix"></div>
                            </div>
                            <div class="single-right-grids">
                              
                                <div class="clearfix"></div>
                            </div>
                            <div class="single-right-grids">
                                
                                <div class="clearfix"></div>
                            </div>
                            <div class="single-right-grids">
                                
                                <div class="clearfix"></div>
                            </div>
                            <div class="single-right-grids">
                                
                                <div class="clearfix"></div>
                            </div>
                            <div class="single-right-grids">
                                
                                <div class="clearfix"></div>
                            </div>
                            <div class="single-right-grids">
                                
                                <div class="clearfix"></div>
                            </div>--%>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
