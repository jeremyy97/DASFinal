<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="InterfazGrafica.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <h1>Buenas: </h1>
                <br />
            </div>
            <div class="col-md-6">
                <h4>Datos del usuario</h4>
                <p>Nombre: </p><input id="Nombre_usuario" type="text" class="form-control" />
                <p>Apellido: </p><input id="Apellido_usuario" type="text" class="form-control" />
                <p>Cambiar contraseña: </p><input id="Contrasena_nueva" type="text" class="form-control" />
                <p>Confirmar contraseña: </p><input id="Contrasena_nueva_repetir" type="text" class="form-control" />
                
                <button class="btn btn-lg btn-primary">Actualizar Datos</button>
            </div>
            <div class="col-md-6">
                <h4>Manejo de usuarios</h4>
                <button class="btn btn-sm btn-primary">Crear usuario</button>
                <button class="btn btn-sm btn-info">Modificar usuario</button>
                <button class="btn btn-sm btn-danger">Eliminar usuario</button>
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
