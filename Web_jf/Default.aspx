<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_jf.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>YouForever - Virtual Cemitery</title>
    <!-- Meta -->
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="Virtual Cemitery - You Forever - COVID-19 Mortes" />
    <meta name="author" content="JWT Sistemas" />
    <link rel="shortcut icon" href="favicon.ico" />
    <link href='http://fonts.googleapis.com/css?family=Lato:300,400,300italic,400italic' rel="stylesheet" type="text/css" />
    <link href='http://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css' />
    <!-- Global CSS -->
    <link rel="stylesheet" href="assets/plugins/bootstrap/css/bootstrap.min.css" />
    <!-- Plugins CSS -->
    <link rel="stylesheet" href="assets/plugins/font-awesome/css/font-awesome.css" />
    <!-- Theme CSS -->
    <link rel="stylesheet" href="assets/css/styles.css" />
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

    <script type="text/javascript">
        $('a.btn').on('click', function (e) {
            e.preventDefault();
            var url = $(this).attr('href');
            $(".modal-body").html('<iframe width="100%" height="100%" frameborder="0" scrolling="yes" allowtransparency="true" src="' + url + '"></iframe>');
        });
    </script>


</head>
<body>
    <form id="Form1" runat="server">
        <!-- ******HEADER****** -->
        <header class="header">
            <div class="container">
                <img class="profile-image img-responsive pull-left" src="assets/images/profile_you.png" alt="James Lee" />
                <div class="profile-content pull-left">
                    <h1 class="name">You Forever</h1>
                    <h2 class="desc">Virtual Cemitery</h2>
                    <ul class="social list-inline">
                        <li><a href="https://www.facebook.com/You-Forever-424532214578402" target="_blank"><i class="fa fa-facebook"></i></a></li>
                        <li class="last-item"><a href="#"><i class="fa fa-instagram"></i></a></li>
                    </ul>
                </div>
                <!--//profile-->
                <%--<asp:Button ID="btn_web" class="btn btn-cta-primary pull-right" runat="server" OnClick="btn_web_Click" Text="Acesse versão web" />--%>
                <a data-toggle="modal" class="btn" href="http://www.bing.com" data-target="#myModal">click me</a>



            </div>
            <!--//container-->
        </header>
        <!--//header-->

        <div class="container sections-wrapper">
            <div class="row">
                <div class="primary col-md-8 col-sm-12 col-xs-12">
                    <section class="about section">
                        <div class="section-inner">
                            <h2 class="heading">Sobre o APP</h2>
                            <div class="content">
                                <p>
                                    Aplicativo desenvolvido para “sepultar e velar” virtualmente familiares falecidos. Local em que as famílias, amigos e fãs podem participar do velório de pessoas queridas.
                                E ainda, criar o Meu Jazigo, onde podem ser incluídos familiares, amigos e ídolos, como forma de criar laços entre gerações.
                                </p>

                                <p>
                                    Nossa filosofia tem como precursor o Faraó Egípcio – Ramsés III, que gravou o seu nome em um templo memorial, o templo de milhões de anos, para que ele pudesse viver por milhões de anos, acreditando que ao lerem seu nome - Usermaat-re-meryamun - sua alma (seu K Divino) receberia uma energia e, assim, ele viveria para sempre.
                               Essa crença fez com que ele esteja entre nós por mais de 3.175 anos, pois ele viveu em Tebas/Luxor, no Egito, entre 1.218 a.C e 1.155 a.C.
                                </p>

                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </section>
                    <!--//section-->

                    <section class="latest section">
                        <div class="section-inner">
                            <%--<h2 class="heading">Conheça o APP</h2>--%>
                            <div class="content">

                                <div class="item featured text-center">
                                    <%--<h3 class="title"><a href="https://wrapbootstrap.com/theme/delta-promote-mobile-app-effectively-WB09R23P8?ref=3wm" target="_blank">You Forever App</a></h3>--%>
                                    <p class="summary">Virtual Cemitery</p>
                                    <div class="featured-image">
                                        <a href="https://wrapbootstrap.com/theme/delta-promote-mobile-app-effectively-WB09R23P8?ref=3wm" target="_blank">
                                            <img class="img-responsive project-image" src="assets/images/youforever_app_site.png" alt="project name" />
                                        </a>
                                        <div class="ribbon">
                                            <div class="text">App</div>
                                        </div>
                                    </div>

                                    <div class="desc text-left">
                                        <p>Cadastre , <b>GRATUITAMENTE</b>, seus familiares mortos no Cemitério Virtual, para que milhares de pessoas o visite. E, assim, leiam os nomes de seus familiares para que eles vivam para sempre. E, sejam lembrados por suas obras e ações, enquanto estiveram entre nós.</p>
                                    </div>
                                    <!--//desc-->
                                    <a class="btn btn-cta-secondary" href="https://play.google.com/store/apps/details?id=com.jwtsistemas.youforever" target="_blank"><i class="fa fa-android"></i>Dowload APP</a>
                                </div>
                                <!--//item-->
                                <hr class="divider" />
                                <div class="item row">

                                    <a class="col-md-4 col-sm-4 col-xs-12">
                                        <img class="img-responsive project-image" src="assets/images/vela_roxa.png" alt="acenda velas" />
                                    </a>
                                    <div class="desc col-md-8 col-sm-8 col-xs-12">
                                        <h3 class="title">Acenda Velas</h3>
                                        <p>Acenda velas no túmulo no túmulo  de seus ente queridos, de seus amigos, de seus  ídolos já falecidos para confortar seus familiares e ou dos familiares de seus amigos e/ou da família de seus ídolos. Como forma de demonstrar o seu carinho.</p>
                                    </div>
                                    <!--//desc-->
                                </div>
                                <!--//item-->

                                <div class="item row">
                                    <a class="col-md-4 col-sm-4 col-xs-12">
                                        <img class="img-responsive project-image" src="image/oracao_roxa.png" alt="deixe mensagens" />
                                    </a>
                                    <div class="desc col-md-8 col-sm-8 col-xs-12">
                                        <h3 class="title">Deixe Mensagens/Oraçôes</h3>
                                        <p>Escreva mensagens  no túmulo  de seus ente queridos, de seus amigos, de seus  ídolos já falecidos para confortar seus familiares e ou dos familiares de seus amigos e/ou da família de seus ídolos. Como forma de demonstrar o seu carinho.</p>
                                    </div>
                                    <!--//desc-->
                                </div>
                                <!--//item-->

                                <div class="item row">
                                    <a class="col-md-4 col-sm-4 col-xs-12">
                                        <img class="img-responsive project-image" src="assets/images/flor_roxa.png" alt="project name" />
                                    </a>
                                    <div class="desc col-md-8 col-sm-8 col-xs-12">
                                        <h3 class="title">Deposite Flores</h3>
                                        <p>Deposite flores no túmulo  de seus ente queridos, de seus amigos, de seus  ídolos já falecidos para confortar seus familiares e ou dos familiares de seus amigos e/ou da família de seus ídolos. Como forma de demonstrar o seu carinho.</p>
                                        <%--<p><a class="more-link" href="#" target="_blank"><i class="fa fa-external-link"></i>Find out more</a></p>--%>
                                    </div>
                                    <!--//desc-->
                                </div>
                                <!--//item-->

                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </section>
                    <!--//section-->


                </div>
                <!--//primary-->
                <div class="secondary col-md-4 col-sm-12 col-xs-12">
                    <aside class="info aside section">
                        <div class="section-inner">
                            <h2 class="heading sr-only">Basic Information</h2>
                            <div class="content">
                                <ul class="list-unstyled">
                                    <li><i class="fa fa-map-marker"></i><span class="sr-only">Location:</span>São Paulo, BR</li>
                                    <li><i class="fa fa-envelope-o"></i><span class="sr-only">Email:</span><a href="mailto:contato@jwtsistemas.com?subject='Contato site You Forever'">contato@jwtsistemas.com</a></li>
                                    <%-- <li><i class="fa fa-link"></i><span class="sr-only">Website:</span><a href="https://www.jwtsistemas.com">www.jwtsistemas.com</a></li>--%>
                                </ul>
                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </aside>
                    <!--//aside-->
                    <aside class="education aside section">
                        <div class="section-inner">
                            <%-- <h2 class="heading">Espaço de Propagandas</h2>--%>
                            <div class="content">
                                <iframe width="360" height="200" src="https://www.youtube.com/embed/JGvGOQrERnI" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </aside>
                    <!--//section-->

                    <aside class="education aside section">
                        <div class="section-inner">
                            <%-- <h2 class="heading">Espaço de Propagandas</h2>--%>
                            <div class="content">
                                <iframe width="360" height="200" src="https://www.youtube.com/embed/Ny7fNYHtkec" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </aside>
                    <!--//section-->


                    <aside class="education aside section">
                        <div class="section-inner">
                            <%-- <h2 class="heading">Espaço de Propagandas</h2>--%>
                            <div class="content">
                                <iframe width="360" height="200" src="https://www.youtube.com/embed/T1Gg1jy63Ds" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </aside>
                    <!--//section-->

                    <aside class="education aside section">
                        <div class="section-inner">
                            <%-- <h2 class="heading">Espaço de Propagandas</h2>--%>
                            <div class="content">
                                <iframe width="360" height="200" src="https://www.youtube.com/embed/KHVZqijN94g" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </aside>
                    <!--//section-->

                    <aside class="education aside section">
                        <div class="section-inner">
                            <%-- <h2 class="heading">Espaço de Propagandas</h2>--%>
                            <div class="content">
                                <iframe width="360" height="200" src="https://www.youtube.com/embed/JGvGOQrERnI" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </aside>
                    <!--//section-->

                    <aside class="blog aside section">
                        <div class="section-inner">
                            <p>Você pode anunciar aqui também <a href="mailto:contato@jwtsistemas.com?subject='Contato para proganda'" target="_blank">contate-nos</a>.</p>
                            <div id="rss-feeds" class="content">
                            </div>
                            <!--//content-->
                        </div>
                        <!--//section-inner-->
                    </aside>
                    <!--//section-->

                </div>
                <!--//secondary-->
            </div>
            <!--//row-->
        </div>
        <!--//masonry-->

        <!-- ******FOOTER****** -->
        <footer class="footer">
            <div class="container text-center">
                <small class="copyright">Created by <a href="https://jwtsistemas.com" target="_blank">JWT Sistemas</a> for developers</small>
            </div>
            <!--//container-->
        </footer>
        <!--//footer-->






        <!-- Javascript -->
        <script type="text/javascript" src="assets/plugins/jquery-1.11.1.min.js"></script>
        <script type="text/javascript" src="assets/plugins/jquery-migrate-1.2.1.min.js"></script>
        <script type="text/javascript" src="assets/plugins/bootstrap/js/bootstrap.min.js"></script>
        <script type="text/javascript" src="assets/plugins/jquery-rss/dist/jquery.rss.min.js"></script>
        <!-- github activity plugin -->
        <script type="text/javascript" src="http://cdnjs.cloudflare.com/ajax/libs/mustache.js/0.7.2/mustache.min.js"></script>
        <script type="text/javascript" src="http://caseyscarborough.github.io/github-activity/github-activity-0.1.0.min.js"></script>
        <!-- custom js -->
        <script type="text/javascript" src="assets/js/main.js"></script>
    </form>


    <div class="modal hide fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
            <h3 id="myModalLabel">Modal header</h3>
        </div>
        <div class="modal-body">
        </div>
    </div>
</body>
</html>
