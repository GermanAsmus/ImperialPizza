<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImperialPizza._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><span style="font-size: larger">SUPER PIZZA 
            <%--<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="720px">
                <asp:ListItem>CONCEPCION DEL URUGUAY</asp:ListItem>
                <asp:ListItem>COLON</asp:ListItem>
                <asp:ListItem>SAN JOSE</asp:ListItem>
            </asp:DropDownList>--%>
            <select Height="16px" Width="720px">
                <optgroup>
                    <option selected="selected">CONCEPCION DEL URUGUAY</option>
                    <option>COLON</option>
                    <option>SAN JOSE</option>
                </optgroup>
            </select>

        </span>

        </h1>

        <p><a href="~/" class="btn btn-primary btn-lg pull-right">Haga Su Pedido Ahora &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Más Recomendadas</h2>
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
