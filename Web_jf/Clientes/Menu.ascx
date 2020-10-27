<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="Web_jf.Clientes.Menu" %>



<div class="collapse navbar-collapse navbar-right" id="bs-example-navbar-collapse-1">
    <nav>
        <ul class="nav navbar-nav">
            <asp:Menu ID="NavigationMenu" runat="server" CssClass="nav navbar-nav" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">

                <Items>
                    <asp:MenuItem NavigateUrl="Default.aspx" Text="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="Licenca.aspx" Text="Contrate espaço"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="Cadastro_falecido.aspx" Text="Cadastro Falecido"></asp:MenuItem>
                    <%--<asp:MenuItem NavigateUrl="Cadastro_jazigo.aspx" Text="Jazigo"></asp:MenuItem>--%>
                </Items>
            </asp:Menu>
        </ul>
    </nav>
</div>


