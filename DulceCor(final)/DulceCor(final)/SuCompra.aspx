<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="SuCompra.aspx.cs" Inherits="DulceCor_final_.SuCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <h1 class="titulo" >Su Compra</h1>
    
    <div class="row">
        <div class="col-xs-10 col-xs-offset-1 fondo">
           

                <asp:GridView ID="grdCompra" runat="server" AllowPaging="True" CellPadding="4" CssClass="table table-bordered bs-table fondo1" PageSize="7" DataKeyNames="IdGolosina" OnSelectedIndexChanged="grdCompra_SelectedIndexChanged" AutoGenerateColumns="False">
                    <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                    <SelectedRowStyle BackColor="#ffffcc" />
                    <PagerStyle HorizontalAlign="Center" />
                    <Columns>
                        <asp:BoundField DataField="idGolosina" HeaderText="Id Golosina"/>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                        <asp:BoundField DataField="precio" DataFormatString="${0:###,###,###.00}" HeaderText="Precio" />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad"/>
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion"/>
                        <asp:BoundField DataField="subtotal" DataFormatString="${0:###,###,###.00}" HeaderText="Subtotal" />
                        <asp:CommandField SelectText="Eliminar" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:Label ID="lblTotal" runat="server" Text="Total: "  CssClass="col-sm-2 control-label" ForeColor="#BDBDBD" AssociatedControlID="txtTotal" Width="80px"></asp:Label><asp:TextBox ID="txtTotal" runat="server" CssClass="form-control-static" Enabled="false" Width="100" ></asp:TextBox>
                <br />
                <br />
                <a href="Venta.aspx" class="btn btn-primary">Seguir Comprando</a>
                <asp:Button ID="btnConfirmar" runat="server" class="btn btn-success" Text="Confirmar Compra" OnClick="btnConfirmar_Click" />
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
