<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes/Web_juizo_Logado.Master" AutoEventWireup="true" CodeBehind="Licenca.aspx.cs" Inherits="Web_jf.Clientes.Licenca" %>

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
                    <li class="active">Contrate o serviço</li>
                </ol>
            </div>
            <div class="single-page-agile-info">
                <!-- /movie-browse-agile -->
                <div class="show-top-grids-w3lagile">
                    <div class="col-sm-8 single-left">
                        <div class="clearfix"></div>
                        <div class="all-comments">
                            <div class="all-comments-info">
                                Selecione o que deseja assinar
                                <div class="agile-info-wthree-box">
                                    <div class="responsive-textbox">
                                        <select id="cboLicenca" class="responsive-textbox" style="width: 100%">
                                            <option value="9.29">Licença de Uso, por dois anos, de uma página para cadastro de 01 (um) ente querido : R$ 9,29</option>
                                            <option value="12.29">Licença de Uso, por dois anos, de duas páginas para cadastro de 02 (dois) entes queridos: R$ 12,29</option>
                                            <option value="15.29">Licença de Uso, por dois anos, de três páginas para cadastro de 03 (três) entes queridos: R$ 15,29</option>
                                            <option value="18.29">Licença de Uso, por dois anos, de quatro páginas para cadastro de 04 (quatro) entes queridos: R$ 18,29</option>
                                            <option value="21.29">Licença de Uso, por dois anos, de cinco páginas para cadastro de 05 (cinco) entes queridos: R$ 21,29</option>
                                            <%--<option value="10">Licença de Uso, por dois anos, de uma página para cadastro de (01) um Jazigo da Família: R$ 10,00</option>
                                            <option value="19.29">Licença de Uso, por dois anos, de duas páginas para cadastros: de 01 (um) ente querido e de 01 (um) Jazigo da Família: R$ 19,29</option>
                                            <option value="22.29">Licença de Uso, por dois anos, três páginas para cadastros: de 02 (dois) entes queridos e de 01 (um) Jazigo da Família: R$ 22,29</option>
                                            <option value="25.29">Licença de Uso, por dois anos, quatro páginas para cadastro: de 03 (três) entes queridos e de 01 (um) Jazigo da Família: R$ 25,29</option>
                                            <option value="28.29">Licença de Uso, por dois anos, cinco páginas para cadastro: de 04 (quatro) entes queridos e de 01 (um) Jazigo da Família: R$ 28,29</option>
                                            <option value="31.29">Licença de Uso, por dois anos, seis páginas para cadastro: de 05 (cinco) entes queridos e de 01 (um) Jazigo da Família: R$ 31,29</option>
                                            <option value="41.29">Licença de Uso, por dois anos, onze páginas para cadastro: de 10 (dez) entes queridos e de 01 (um) Jazigo da Família: R$ 41,29</option>
                                            <option value="100">Licença de Uso, por dois anos, de uma página para cadastro de (01) um Jazigo Corporativo: R$ 100,00</option>--%>
                                        </select>
                                        <br />
                                        <p style="margin-top: 30px; text-align: right">
                                            <!-- INICIO FORMULARIO BOTAO PAGSEGURO -->
                                            <a href="#" onclick="Pagar()">
                                                <img src="https://stc.pagseguro.uol.com.br/public/img/botoes/assinaturas/209x48-contratar-azul-assina.gif" alt="Pague com PagSeguro - é rápido, grátis e seguro!" /></a>
                                            <!-- FINAL FORMULARIO BOTAO PAGSEGURO -->
                                        </p>
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

    <%--Inicio Pagseguro--%>

    <!--<script type="text/javascript" src="https://stc.sandbox.pagseguro.uol.com.br/pagseguro/api/v2/checkout/pagseguro.lightbox.js"></script>-->
    <script type="text/javascript" src="https://stc.pagseguro.uol.com.br/pagseguro/api/v2/checkout/pagseguro.lightbox.js"></script>
    <script src="../js/vendor/jquery-1.10.1.min.js"></script>
    <script src="../js/jquery.easing-1.3.js"></script>
    <script src="../js/bootstrap.js"></script>
    <script src="../js/plugins.js"></script>
    <script src="../js/main.js"></script>
    <script type="text/javascript">
        function localJsonpCallback(json) {
            var aaa = 0;
        }

        function Pagar() {
            var errorCallBack = null;
            var lic = document.getElementById("cboLicenca").value;
            var jsonString = "{\"value\":" + lic + "}"

            $.ajax({
                type: "POST",
                url: location.pathname + "/ProcessaCheckoutPagSeguro",
                data: jsonString,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (value) {
                    //PagSeguroLightbox(value.d);
                    PagSeguroLightbox({
                        code: value.d
                    }, {
                        success: function (transactionCode) {
                            window.location.href = "/Clientes/retornopagamento.aspx?id_pagseguro=" + transactionCode;
                        },
                        abort: function () {
                            //alert("abort");
                            // do nothing
                        }
                    });
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    if (errorCallBack != null) {
                        errorCallBack("error: " + xhr.status + "\n" + xhr.statusText + "\n" + thrownError);
                    }
                    else {
                        alert("error: " + xhr.status + "\n" + xhr.statusText + "\n" + thrownError);
                    }
                }
            });
        }

    </script>

    <%--//fim pagSeguro--%>
</asp:Content>
