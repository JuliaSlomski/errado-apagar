<%@ Page Title="" Language="C#" MasterPageFile="~/Web_Juizo.Master" AutoEventWireup="true" CodeBehind="Cadastro_falecido.aspx.cs" Inherits="Web_jf.Cadastro_falecido" %>

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
                    <li class="active">Cadastro de Ente Querido</li>
                </ol>
            </div>
            <div class="single-page-agile-info">
                <!-- /movie-browse-agile -->
                <div class="show-top-grids-w3lagile">
                    <div class="col-sm-8 single-left">
                        <div class="song">
                            <div class="song-info">
                                <h5>Cadastro de Cliente</h5>
                            </div>
                            <div class="video-grid-single-page-agileits">
                            </div>
                        </div>
                        <div class="song-grid-right">
                            <p>
                                • Para cadastrar seu ente querido ou adquirir um jazigo você precisa ter o seu cadastro. <a href="Cadastro.aspx">CADASTRE-SE</a>
                            </p>
                            <br />
                            <h5 style="width: auto">Custo para cadastro de seu ente querido e/ou construção do Jazigo de sua família</h5>
                            <br />
                            <p style="width: auto; text-align: justify;">
                                • A Licença de Uso, por dois anos, de uma página para cadastro de 01 ente querido : R$ 9,29
                                                    <br />
                                • A Licença de Uso, por dois anos, de duas páginas para cadastro de 02 entes queridos: R$ 12,29
                                                    <br />
                                • A Licença de Uso, por dois anos, de três páginas para cadastro de 03 entes queridos: R$ 15,29
                                                    <br />
                                • A Licença de Uso, por dois anos, de quatro páginas para cadastro de 04 entes queridos: R$ 18,29
                                                    <br />
                                • A Licença de Uso, por dois anos, de cinco páginas para cadastro de 05 entes queridos: R$ 21,29
                                                    <br />
                                • A Licença de Uso, por dois anos, de uma página para cadastro de um Jazigo da Família: <b>Cadastre-se e ganhe !!</b>
                                <br />
                                <%--• A Licença de Uso, por dois anos, de duas páginas para cadastros: de 01 ente querido e de 01 Jazigo da Família: R$ 19,29
                                                    <br />
                                    • A Licença de Uso, por dois anos, três páginas para cadastros: de 02 entes queridos e de 01 Jazigo da Família: R$ 22,29
                                                    <br />
                                    • A Licença de Uso, por dois anos, quatro páginas para cadastro: de 03 entes queridos e de 01 Jazigo da Família: R$ 25,29
                                                    <br />
                                    • A Licença de Uso, por dois anos, cinco páginas para cadastro: de 04 entes queridos e de 01 Jazigo da Família: R$ 28,29
                                                    <br />
                                    • A Licença de Uso, por dois anos, seis páginas para cadastro: de 05 entes queridos e de 01 Jazigo da Família: R$ 31,29
                                                    <br />
                                    • A Licença de Uso, por dois anos, onze páginas para cadastro: de 10 entes queridos e de 01 Jazigo da Família: R$ 41,29
                                                    <br />
                                    • A Licença de Uso, por dois anos, de uma página para cadastro de um Jazigo Corporativo: R$ 100,00--%>
                            </p>
                            <br />
                            <h5>Forma de Pagamento</h5>
                            <br />
                            <p style="width: auto; text-align: justify">
                                • Cartão de crédito ou Cartão de débito, via PagSeguro da UOL.
                            </p>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="col-md-4 single-right">
                        <h3>Espaço para publicidade</h3>
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
