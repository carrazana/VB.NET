<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="SuPromocion.aspx.cs" Inherits="DulceCor_final_.SuPromocion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
        <h1 class="titulo">Su Promocion</h1>
    
    <div class="row">
        <div class="col-xs-10 col-xs-offset-1 fondo">
           

                <asp:GridView ID="grdPromocion" runat="server" AllowPaging="True" CellPadding="4" CssClass="table table-bordered bs-table fondo1" PageSize="7" DataKeyNames="idTipoPromocion" OnSelectedIndexChanged="grdPromocion_SelectedIndexChanged" AutoGenerateColumns="False">
                    <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                    <SelectedRowStyle BackColor="#ffffcc" />
                    <PagerStyle HorizontalAlign="Center" />
                    <Columns>
                        <asp:CommandField SelectText="Eliminar" ShowSelectButton="True" />
                        <asp:BoundField DataField="tipoProm" HeaderText="Nombre" />
                        <asp:BoundField DataField="golosinaN" HeaderText="Golosina" />
                        <asp:BoundField DataField="cantidadPaquetes" HeaderText="Cantidad" />
                        <asp:BoundField DataField="precioProm" HeaderText="Precio" />
                    </Columns>
                </asp:GridView>                
                <br />
                <br />
                <a href="NuevaPromocion.aspx?G=1" class="btn btn-primary">Seguir Gestionando Promocion</a>
                <asp:Button ID="btnConfirmar" runat="server" class="btn btn-success" Text="Confirmar Promocion" OnClick="btnConfirmar_Click" />
        </div>
        <asp:Label ID="lblMensaje" runat="server" CssClass="Mensaje" Visible="false"></asp:Label>
        
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphFooter" runat="server">
        <script type="text/javascript">

        $(function () {
            $(".Mensaje").dialog({
                title: 'Mensaje',
                draggable: false,
                resizable: false,
                closeOnEscape: false,
                modal: true,
                //autoOpen: false,
                buttons:
                [{
                    text: 'Aceptar',
                    click: function () {
                        $(this).dialog("close");
                    }
                }]
            })
        });

    </script>
</asp:Content>
