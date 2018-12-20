<%@ Page Language="C#"  MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Cajero.aspx.cs" Inherits="InterfazGrafica.Cajero" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Cajero</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Menu" runat="server">
    <li class="nav-item">
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
                <h1>Bienvenido: </h1>
                <br />
            </div>
            <div class="col-md-6">
                <p>Pagar cuenta de mesa número:</p>

                <input id="Text1" type="text" class="form-control" />
                <asp:Button class="btn btn-lg btn-primary" ID="pagar_cuenta" runat="server" Text="Pagar" OnClick="pagar_cuenta_Click" />
                
            </div>
            <div class="col-md-6">
                <%-- Resumen de factura --%>
                <asp:TextBox ID="total_pagar" runat="server"></asp:TextBox>




                <%--<p>Mesas disponibles:</p>
                <div class="alert alert-primary" role="alert">
                    Mesa 1
                </div>
                <div class="alert alert-primary" role="alert">
                    Mesa 2
                </div>
                <div class="alert alert-primary" role="alert">
                    Mesa 3
                </div>
                --%>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <%--<p>Mesas ocupadas:</p>
                <div class="alert alert-primary" role="alert">
                    Mesa 4
                </div>
                <div class="alert alert-primary" role="alert">
                    Mesa 5
                </div>
                <div class="alert alert-primary" role="alert">
                    Mesa 6
                </div>--%>
            </div>
        </div>
    </div>

</asp:Content>