<%@ Page Title="" Language="C#" MasterPageFile="~/Web_Juizo.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Web_jf.Cadastro" %>

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
    <!-- single -->
    <div class="single-page-agile-main">
        <div class="container">
            <!-- /w3l-medile-movies-grids -->
            <div class="agileits-single-top">
                <ol class="breadcrumb">
                    <li><a href="Default.aspx">Home</a></li>
                    <li class="active">Cadastre-se</li>
                </ol>
            </div>
            <div class="single-page-agile-info">
                <!-- /movie-browse-agile -->
                <div class="show-top-grids-w3lagile">
                    <div class="col-sm-8 single-left">
                        <div class="song">
                            <div class="song-info">
                                <h3>Preencha os dados e crie sua conta</h3>
                            </div>
                        </div>
                        <br />
                        <div class="song-grid-right">
                            <p style="text-align: left">
                                <asp:CheckBox ID="check_clientes" runat="server" /><asp:Label ID="Label1" runat="server" Text=" Cadastro para Jazigo de minha família"></asp:Label>
                                <br />
                                <asp:CheckBox ID="check_corporacoes" runat="server" /><asp:Label ID="lbl" runat="server" Text=" Cadastro para Jazigo corporativo"></asp:Label>
                            </p>
                            <br />
                            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" OnCreatedUser="CreateUserWizard1_CreatedUser" Visible="true">
                                <WizardSteps>
                                    <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="UserName" CssClass="responsive-textbox" runat="server" placeholder="Crie seu login" Width="100%"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="Password" runat="server" CssClass="responsive-textbox" TextMode="Password" Width="100%" placeholder="Senha"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="responsive-textbox" TextMode="Password" Width="100%" placeholder="Confirmar senha"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="Email" runat="server" CssClass="responsive-textbox" placeholder="Email" Width="100%"></asp:TextBox>
                                            <br />
                                            <%--<asp:TextBox ID="Question" runat="server" CssClass="responsive-textbox" Width="100%" placeholder="Pergunta de segurança"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="Answer" runat="server" CssClass="responsive-textbox" Width="100%" placeholder="Resposta"></asp:TextBox>
                                            <br />--%>
                                            <%--<asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                            <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                            <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ErrorMessage="E-mail is required." ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                            <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question" ErrorMessage="Security question is required." ToolTip="Security question is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                            <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer" ErrorMessage="Security answer is required." ToolTip="Security answer is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                                            <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>--%>
                                        </ContentTemplate>
                                        <CustomNavigationTemplate>
                                            <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Cadastre-se" ValidationGroup="CreateUserWizard1" />
                                        </CustomNavigationTemplate>
                                    </asp:CreateUserWizardStep>
                                    <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                                        <ContentTemplate>
                                            <p style="text-align: center; width: 100%">Conta criada com sucesso!</p>
                                            <p style="text-align: center; width: 100%">Para acessar sua área de cliente você deve utilizar o <b>LOGIN</b> e <b>SENHA</b> cadastrados.</p>
                                        </ContentTemplate>
                                    </asp:CompleteWizardStep>
                                </WizardSteps>
                                <FinishNavigationTemplate>
                                    <%--  <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                                                <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finish" />--%>
                                </FinishNavigationTemplate>
                            </asp:CreateUserWizard>

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
            <!-- //w3l-latest-movies-grids -->
        </div>
    </div>
    <!-- //w3l-medile-movies-grids -->
</asp:Content>
