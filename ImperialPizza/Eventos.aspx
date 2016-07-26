<%@ Page Title="Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="ImperialPizza.Eventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1><asp:Label ID="Label1" runat="server" Text="LISTA DE EVENTOS"></asp:Label></h1>
    </div>        
    <div>
        <asp:Button ID="btnAgregarEvento" runat="server" BorderStyle="None" CssClass="btn-primary pull-right" Text="Agregar" OnClick="Button1_Click" />
    </div>
    <div>

    </div>
</asp:Content>
