<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="InterfazGrafica.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Nueva seccion de inicio</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Menu" runat="server">
    <a class="nav-link" href="Cliente.aspx">
      <i class="material-icons">dashboard</i>
      <p>Dashboard</p>
    </a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                <h1>Bienvenido </h1>
                    <br />
                </div>
                <div class="col-md-6">
                    <p>Añadir a la orden:</p>

                    <input id="numero_orden" type="text" class="form-control"/>
                    <%-- Jalar los productos a mostrar  --%>

                    <asp:Button class="btn btn-lg btn-primary" ID="anadir_orden" runat="server" Text="Añadir" OnClick="anadir_orden_Click" />
                                
                </div>
                <div class="col-md-6">
                    <%--<p>Su orden:</p>
                    <div class="alert alert-primary" role="alert">
                        Orden 1: Hamburguesa Especial 
                    </div>
                    <div class="alert alert-primary" role="alert">
                        Orden 2: Arroz Especial 
                    </div>
                    <div class="alert alert-primary" role="alert">
                        Orden 3: Pescado de la casa 
                    </div>
                    <button class="btn btn-lg btn-primary">Pagar orden</button>--%>
                </div>
            </div>
    </div>
</asp:Content>
