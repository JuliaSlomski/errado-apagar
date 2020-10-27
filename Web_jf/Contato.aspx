<%@ Page Title="" Language="C#" MasterPageFile="~/Web_Juizo.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="Web_jf.Contato" %>

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
    <link rel="stylesheet" href="css/contactstyle.css" type="text/css" media="all" />
    <link rel="stylesheet" href="css/faqstyle.css" type="text/css" media="all" />
    <link href="css/single.css" rel='stylesheet' type='text/css' />
    <link href="css/medile.css" rel='stylesheet' type='text/css' />
    <!-- banner-slider -->
    <link href="css/jquery.slidey.min.css" rel="stylesheet" />
    <!-- //banner-slider -->
    <!-- pop-up -->
    <link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
    <!-- //pop-up -->
    <!-- font-awesome icons -->
    <link rel="stylesheet" href="css/font-awesome.min.css" />
    <!-- //font-awesome icons -->
    <!-- js -->
    <script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
    <!-- //js -->
    <!-- banner-bottom-plugin -->
    <link href="css/owl.carousel.css" rel="stylesheet" type="text/css" media="all" />
    <script src="js/owl.carousel.js"></script>
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
    <!-- contact -->
    <div class="contact-agile">
        <div id="map" style="text-align:center;">
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d467692.0488940745!2d-46.8754993631553!3d-23.68153144207375!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce448183a461d1%3A0x9ba94b08ff335bae!2zU8OjbyBQYXVsbywgU1A!5e0!3m2!1spt-BR!2sbr!4v1490893595247" width="1300" height="350" frameborder="0" style="border: 0" allowfullscreen></iframe>
        </div>
        <div class="faq">
            <h4 class="latest-text w3_latest_text">Entre em Contato</h4>
            <div class="container">
                <div class="col-md-3 location-agileinfo">
                    <div class="icon-w3">
                        <span class="glyphicon glyphicon-map-marker" aria-hidden="true"></span>
                    </div>
                    <h3>Atendimento</h3>
                    <h4>Segunda à Sexta</h4>
                    <h4>das 9:30hrs às 16:30.</h4>
                </div>
                <div class="col-md-3 call-agileits">
                    <div class="icon-w3">
                        <span class="glyphicon glyphicon-earphone" aria-hidden="true"></span>
                    </div>
                    <h3>Telefone</h3>
                    <h4>+55(11) 3125.5682 </h4>
                </div>
                <div class="col-md-3 mail-wthree">
                    <div class="icon-w3">
                        <span class="glyphicon glyphicon-envelope" aria-hidden="true"></span>
                    </div>
                    <h3>Email</h3>
                    <h4><a href="mailto:contato@memoriafamiliar.online">memoriafamiliar.online</a></h4>
                    <%--<h4><a href="mailto:juliana@jwtsistemas.com">juliana@jwtsistemas.com</a></h4>--%>
                </div>
                <div class="col-md-3 social-w3l">
                    <div class="icon-w3">
                        <span class="glyphicon glyphicon-user" aria-hidden="true"></span>
                    </div>
                    <h3>Mídias Sociais</h3>
                    <ul>
                        <li><a href="https://www.facebook.com/Ju%C3%ADzo-Final-1700276746937902/?ref=aymt_homepage_panel"><i class="fa fa-facebook" aria-hidden="true"></i><span class="text">Facebook</span></a></li>
                    </ul>
                </div>
                <div class="clearfix"></div>
                <div class="contato">
                    <asp:TextBox ID="txt_nome" runat="server" placeholder="Nome"></asp:TextBox>
                    <asp:TextBox ID="txt_sobrenome" runat="server" placeholder="Sobrenome"></asp:TextBox>
                    <asp:TextBox ID="txt_email" runat="server" placeholder="Email"></asp:TextBox>
                    <asp:TextBox ID="txt_assunto" runat="server" placeholder="Assunto"></asp:TextBox>
                    <asp:TextBox ID="txt_mensagem" runat="server" TextMode="MultiLine" placeholder="Mensagem"></asp:TextBox>
                    <asp:Button ID="btn_enviar" runat="server" Text="Enviar Mensagem" OnClick="btn_enviar_Click" />
                </div>
            </div>
        </div>
    </div>

    <!-- //contact -->
</asp:Content>
