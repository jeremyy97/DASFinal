<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Mesero.aspx.cs" Inherits="InterfazGrafica.Mesero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Mesero</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Menu" runat="server">
    <li class="nav-item">
    <a class="nav-link" href="Mesero.aspx">
      <i class="material-icons">dashboard</i>
      <p>Dashboard</p>
    </a>
    </li>
    <li class="nav-item">
            <a class="nav-link" href="Usuario.aspx">
                <i class="material-icons">account_circle</i>
                <p>Usuario</p>
            </a>
          </li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <h3>Atender Mesa:</h3>
                    <asp:TextBox class="form-control" ID="numero_mesa" runat="server"></asp:TextBox>
                    
                </div>
                <div class="col-md-6">
                    <h3>Agregar a la orden:</h3>
                    <%-- Lista productos --%>

                    <asp:Button class="btn btn-primary" ID="anadir_orden" runat="server" Text="Button" OnClick="anadir_orden_Click" />

                    <%--<h3>Ver Ordenes</h3>
                    <div class="alert alert-primary" role="alert">
                        Orden 1: Hamburguesa Especial 
                    </div>
                    <div class="alert alert-primary" role="alert">
                        Orden 2: Arroz Especial 
                    </div>
                    <div class="alert alert-primary" role="alert">
                        Orden 3: Pescado de la casa 
                    </div>--%>
                </div>
            </div>
    </div>
</asp:Content>
