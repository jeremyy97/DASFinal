<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Mesero.aspx.cs" Inherits="InterfazGrafica.Mesero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Mesero</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <h3>Atender Cliente</h3>
                    <p>Espacio para cuantas personas</p>
                    <input id="CantidadPersonas" type="text" class="form-control"/>
                </div>
                <div class="col-md-6">
                    <h3>Ver Ordenes</h3>
                    <div class="alert alert-primary" role="alert">
                        Orden 1: Hamburguesa Especial 
                    </div>
                    <div class="alert alert-primary" role="alert">
                        Orden 2: Arroz Especial 
                    </div>
                    <div class="alert alert-primary" role="alert">
                        Orden 3: Pescado de la casa 
                    </div>
                </div>
            </div>
    </div>
</asp:Content>
