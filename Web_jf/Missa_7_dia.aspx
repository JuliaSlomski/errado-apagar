<%@ Page Title="" Language="C#" MasterPageFile="~/Web_Juizo.Master" AutoEventWireup="true" CodeBehind="Missa_7_dia.aspx.cs" Inherits="Web_jf.Missa_7_dia" %>

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
    <!-- faq-banner -->
    <div class="faq">
        <div class="container">
            <div class="agileits-news-top">
                <ol class="breadcrumb">
                    <li><a href="Default.html">Home</a></li>
                    <li class="active">Missa de 7° dia</li>
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
                                                <h5>Missa de 7° dia</h5>
                                                <br />
                                                <p style="width: 700px; text-align: justify">
                                                    • Página em construção, Aguarde!
                                                </p>

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
                <div class="col-md-4 wthree-news-right">
                    <!-- news-right-top -->
                    <div class="news-right-top">
                        <div class="wthree-news-right-heading">
                            <h3>Ultimas notícias</h3>
                        </div>
                        <div class="wthree-news-right-top">
                            <div class="news-grids-bottom">
                                <!-- date -->
                                <div id="design" class="date">
                                    <div id="cycler">
                                        <div class="date-text">
                                            <a href="news-single.html">Março 30,2017</a>
                                            <p>Nada para mostrar</p>
                                        </div>
                                    </div>
                                    <script>
                                        function blinker() {
                                            $('.blinking').fadeOut(500);
                                            $('.blinking').fadeIn(500);
                                        }
                                        setInterval(blinker, 1000);
                                    </script>
                                    <script>
                                        function cycle($item, $cycler) {
                                            setTimeout(cycle, 2000, $item.next(), $cycler);

                                            $item.slideUp(1000, function () {
                                                $item.appendTo($cycler).show();
                                            });
                                        }
                                        cycle($('#cycler div:first'), $('#cycler'));
                                    </script>
                                </div>
                                <!-- //date -->
                            </div>
                        </div>
                    </div>
                    <!-- //news-right-top -->

                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //faq-banner -->
</asp:Content>
