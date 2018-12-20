<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="InterfazGrafica.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Menu" runat="server">
    <li class="nav-item  ">
    <a class="nav-link" href="Cajero.aspx">
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
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <h1>Bienvenido </h1>
                <br />
            </div>
            <div class="col-md-6">
                <h4>Manejo de usuarios</h4>
                <asp:Button class="btn btn-md btn-primary" ID="crear_usuario" runat="server" Text="Crear usuario" OnClick="crear_usuario_Click" />
                <asp:Button class="btn btn-md btn-info" ID="agregar_usuario" runat="server" Text="Agregar usuario" OnClick="modificar_usuario_Click" />
                <asp:Button class="btn btn-md btn-danger" ID="eliminar_usuario" runat="server" Text="Eliminar usuario" OnClick="eliminar_usuario_Click" />
                
            </div>
            <div class="col-md-6">
                
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <p></p>
                
            </div>
            <div class="col-md-6">
                
            </div>
        </div>
    </div>
</asp:Content>
