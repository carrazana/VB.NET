<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="Golosina.aspx.cs" Inherits="DulceCor_final_.GolosinaWf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
       <script type="text/javascript">
        function validarTipoGolosina(src, args) {
            if (args.Value === "0") {
                args.IsValid = false;
            }
            else {
                args.IsValid = true;
            }
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
      
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1 class="titulo" >Golosinas<span class="label label-default"><asp:Label ID="lblAccion" runat="server" Visible="false" ></asp:Label></span></h1>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <div class="panel fondo  " >
                    <div class="panel-body ">
                        <div class="form-group">
                            <asp:Panel ID="pnlConsulta" runat="server">
                                <div class="form-horizontal" role="form">
                                    <div class="form-group">
                                        <asp:Label ID="lblNombreBuscar" runat="server" Text="Nombre a Buscar:" AssociatedControlID="txtNombreBuscar" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD"></asp:Label>
                                        <div class="col-sm-8">
                                            <asp:TextBox ID="txtNombreBuscar" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
                                        </div>
                                        <div class="col-sm-2">
                                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" />
                                        </div>
                                    </div>
                                </div>
                                <br />
                                <asp:GridView ID="gvDatos" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdGolosina" CssClass="table table-bordered bs-table fondo1" OnPageIndexChanging="gvDatos_PageIndexChanging" OnSorting="gvDatos_Sorting" PageSize="7">
                                    <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                                    <SelectedRowStyle BackColor="#ffffcc" />
                                    <PagerStyle HorizontalAlign="Center" />

                                    <Columns>

                                        <asp:BoundField DataField="idGolosina" HeaderText="IdGolosina" SortExpression="idGolosina" />
                                        <asp:BoundField DataField="nombre" HeaderText="Golosina" SortExpression="nombre" />
                                        <asp:BoundField DataField="precio" DataFormatString="${0:###,###,###.00}" HeaderText="Precio" SortExpression="precio" />
                                        <asp:BoundField DataField="cantidadPaquete" HeaderText="CantidadPaquete" SortExpression="cantidadPaquete" />
                                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" SortExpression="descripcion" />
                                        <asp:BoundField DataField="TipoGolosinaNombre" HeaderText="TipoGolosina" SortExpression="TipoGolosinaNombre" />
                                        <asp:BoundField DataField="marca" HeaderText="Marca" SortExpression="marca" />
                                        <asp:CheckBoxField DataField="disponibilidad" HeaderText="Disponibilidad" SortExpression="disponibilidad" />
                                        <asp:BoundField DataField="codigo" HeaderText="Codigo" SortExpression="codigo" />
                                        <asp:CommandField ShowSelectButton="True" />

                                    </Columns>
                                </asp:GridView>
                                <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" CssClass="btn btn-success" />
                                &nbsp;
        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" CssClass="btn btn-info" />
                                &nbsp;
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" CssClass="btn btn-danger" />
                                &nbsp;
        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" CssClass="btn btn-warning" />
                            </asp:Panel>
                        </div>
                        <div class="form-group">
                            <asp:Panel ID="pnlRegistro" runat="server" Visible="false">
                                <div class="container">
                                    <div class="row">
                                        <div class="col-sm-6 col-sm-offset-3">
                                            <div class="panel panel-primary">
                                                <div class="panel-heading">
                                                    <h3 class="panel-title">Golosina</h3>
                                                </div>
                                                <div class="panel-body">

                                                    <table class="auto-style1" style="height: 354px">
                                                        <tr>
                                                            <td class="auto-style4">GolosinaId:<br />
                                                            </td>
                                                            <td class="auto-style5">
                                                                <asp:TextBox ID="txtIdGolosina" runat="server" Enabled="False" CssClass="form-control" placeholder="Id Golosina"></asp:TextBox>
                                                                <br />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style6">Nombre:<br />
                                                            </td>
                                                            <td class="auto-style5">
                                                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre" MaxLength="50"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="valNombreRequerido" runat="server" ErrorMessage="Debe Ingresar Un Nombre" ControlToValidate="txtNombre" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>
                                                                <!--
                                        <asp:RegularExpressionValidator ID="valNombreValido" runat="server" ErrorMessage="Debe Ingresar Solo Letras" CssClass="text-danger" ControlToValidate="txtNombre" ValidationExpression="^\s*[a-zA-Z,\s]+\s*$" Display="Dynamic" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                        -->
                                                                <br />

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style3">Precio:<br />
                                                            </td>
                                                            <td class="auto-style5">
                                                                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" placeholder="Precio" MaxLength="7"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="valPrecioRequerido" runat="server" ErrorMessage="Debe Ingresar Un Precio" ControlToValidate="txtPrecio" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>
                                                                <!--
                                        <asp:RegularExpressionValidator ID="valPrecioValido" runat="server" ErrorMessage="Debe Ingresar Solo Numeros" CssClass="text-danger" ControlToValidate="txtPrecio" ValidationExpression="([0-9]+\.[0-9]*)|([0-9]*\.[0-9]+)|([0-9]+)" Display="Dynamic" ValidationGroup="Aceptar" ></asp:RegularExpressionValidator>
                                        -->
                                                                <asp:RegularExpressionValidator ID="valPrecioValido2" runat="server" ErrorMessage="Debe Ingresar Solo Numeros" CssClass="text-danger" ControlToValidate="txtPrecio" ValidationExpression="^([0-9]*\,?[0-9]+|[0-9]+\,?[0-9]*)?$" Display="Dynamic" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                                <br />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style4">Cantidad:<br />
                                                            </td>
                                                            <td class="auto-style5">
                                                                <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" placeholder="Cantidad" MaxLength="6"></asp:TextBox>

                                                                <asp:RegularExpressionValidator ID="valCantidadValido" runat="server" ErrorMessage="Debe Ingresar Solo Numeros" CssClass="text-danger" ControlToValidate="txtCantidad" ValidationExpression="([0-9]+\.[0-9]*)|([0-9]*\.[0-9]+)|([0-9]+)" Display="Dynamic" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                                <br />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style4">Descripcion:<br />
                                                            </td>
                                                            <td class="auto-style5">
                                                                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" placeholder="Descripcion" MaxLength="50"></asp:TextBox>
                                                                <br />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style4">Tipo Golosina:</td>
                                                            <td class="auto-style5">
                                                                <asp:DropDownList ID="ddlTipoGolosina" runat="server" CssClass="form-control">
                                                                </asp:DropDownList>
                                                                <!--
                                                                <asp:RequiredFieldValidator ID="valTipoGolosinaRequerida" runat="server" ErrorMessage="Debe Elegir Un Tipo Golosina" ControlToValidate="ddlTipoGolosina" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>
                                                                -->
                                                                <!-- -->
                                        <asp:CustomValidator ID="valListaTipoGolosina" runat="server" ErrorMessage="Debe Elegir Un Tipo Golosina" ControlToValidate="ddlTipoGolosina" OnServerValidate="valListaTipoGolosina_ServerValidate" ClientValidationFunction="validarTipoGolosina" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:CustomValidator>
                                       
                                                                
                                                                <br />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style4">Marca:<br />
                                                            </td>
                                                            <td class="auto-style5">
                                                                <asp:DropDownList ID="ddlMarca" runat="server" CssClass="form-control">
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="valMarcaRequerida" runat="server" ErrorMessage="Debe Elegir Una Marca" ControlToValidate="ddlMarca" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>

                                                                <br />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style7">Disponibilidad:<br />
                                                            </td>
                                                            <td class="auto-style8">
                                                                <asp:CheckBox ID="ckDisponibilidad" runat="server" />
                                                                <br />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style4">Codigo:<br />
                                                            </td>
                                                            <td class="auto-style5">
                                                                <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" placeholder="Codigo" MaxLength="8"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="valCodigoRequerido" runat="server" ErrorMessage="Debe Ingresar Un Codigo" ControlToValidate="txtCodigo" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>
                                                                <asp:RegularExpressionValidator ID="valCodigoValido" runat="server" ErrorMessage="Debe Ingresar Solo Numeros" CssClass="text-danger" ControlToValidate="txtCodigo" ValidationExpression="([0-9]+\.[0-9]*)|([0-9]*\.[0-9]+)|([0-9]+)" Display="Dynamic" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                                <br />

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style4">Imagen:</td>
                                                            <td class="auto-style5">
                                                                <asp:FileUpload ID="FileUpload" runat="server" />
                                                                <asp:RegularExpressionValidator ID="valFileUploadValido" runat="server" ErrorMessage="Debe Seleccionar Solo Imagenes" CssClass="text-danger" ControlToValidate="FileUpload" ValidationExpression= "(.*).(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$" Display="Dynamic" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                                <asp:Image ID="Image" runat="server" />
                                                                <br />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style4"></td>
                                                            <td class="auto-style5">
                                                                <!--
                                       <asp:ValidationSummary ID="ValidationSummary2" runat="server" HeaderText="Han ocurrido los siguientes errores:" cssClass="alert-danger" ValidationGroup="Aceptar"/>
                                        -->
                                                                <asp:Button ID="btnGrabar" runat="server" CssClass="btn btn-success" OnClick="btnGrabar_Click" Text="Grabar" ValidationGroup="Aceptar" />
                                                                &nbsp;
                                                                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-warning" OnClick="btnCancelar_Click" Text="Cancelar" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="auto-style4">&nbsp;</td>
                                                            <td class="auto-style5">
                                                                <asp:Label ID="lblMensaje2" runat="server" CssClass="Mensaje2" Visible="false"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>



                                                </div>
                                            </div>


                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                            <asp:Label ID="lblMensaje" runat="server" CssClass="Mensaje"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphFooter" runat="server">


    <script type="text/javascript">

        $(function () {
            $(".Mensaje").dialog({
                title: 'Advertencia',
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

        $(function () {
            $(".Mensaje2").dialog({
                title: 'Advertencia',
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
