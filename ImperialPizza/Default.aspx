<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImperialPizza._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" id="banner1">
        <h1>SUPER PIZZA</h1>
        <p>
            <label>El sabor de lo perfecto</label>
        </p>
        <p><a href="~/" class="btn btn-primary btn-lg pull-right" media="screen">Haga Su Pedido Ahora &raquo;</a></p>

    </div>

    <div class="row">
        <div class="col-md-0">
            <h2>No hacemos solo pizza y empanadas...</h2>
            <p>
                Durante 25 años venimos trabajando, día a día, haciendo felices a nuestros clientes, satisfaciendo sus necesidades gastronómicas con nuestras delicias.
                Hoy, con más de 53 tipos de pizza y mas de 15 tipos de empanadas, estámos seguros que tenemos todo para ofrecer, en lo que respecta al paladar de nuestros clientes, los mejores sabores que puedan degustarse.
            </p>
            <a href="~/">Sobre Nosotros</a>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Más Recomendadas</h2>
        </div>
        <div id="lista1">
            <ul>
                <li>
                    <h2>¡Made in Mexico!
                    </h2>
                    <p>
                        <img class="imagen1" src="Content/Pictures/pizza-3.jpg" height="256" width="256" />
                    </p>
                    <p>
                        <label>
                            La mejor pizza con jalapeños bien chingones!
                        </label>
                    </p>
                    <a href="~/">¡COMPRAR!</a>
                </li>
                <li>
                    <h2>BARA BARA BATMAN
                    </h2>
                    <p>
                        <img class="imagen1" src="Content/Pictures/pizza-4.jpg" height="256" width="256"/>
                    </p>
                    <p>
                        <label>
                            ¡COMAN CHICOS COMAN!
                        </label>
                    </p>
                    <a href="~/">¡COMPRAR!</a>
                </li>
                <li>
                    <h2>TNT
                    </h2>
                    <p>
                        <img class="imagen1" src="Content/Pictures/pizza-5.jpg" height="256" width="256" />
                    </p>
                    <p>
                        <label>
                            Todo lo que puede llevar una pizza, y mas!
                        </label>
                    </p>
                    <a href="~/">¡COMPRAR!</a>
                </li>
            </ul>
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
