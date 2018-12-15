<%@ Page Language="C#"  MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Cajero.aspx.cs" Inherits="InterfazGrafica.Cajero" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Cajero</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <h1>Buenas: </h1>
                <br />
            </div>
            <div class="col-md-6">
                <p>Pagar cuenta de mesa número:</p>

                <input id="Text1" type="text" class="form-control" />
                <button class="btn btn-lg btn-primary">Pagar</button>
            </div>
            <div class="col-md-6">
                <p>Mesas disponibles:</p>
                <div class="alert alert-primary" role="alert">
                    Mesa 1
                </div>
                <div class="alert alert-primary" role="alert">
                    Mesa 2
                </div>
                <div class="alert alert-primary" role="alert">
                    Mesa 3
                </div>
                
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <p>Mesas ocupadas:</p>
                <div class="alert alert-primary" role="alert">
                    Mesa 4
                </div>
                <div class="alert alert-primary" role="alert">
                    Mesa 5
                </div>
                <div class="alert alert-primary" role="alert">
                    Mesa 6
                </div>
            </div>
        </div>
    </div>

</asp:Content>