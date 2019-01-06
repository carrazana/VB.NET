<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="NuevaPromocion.aspx.cs" Inherits="DulceCor_final_.NuevaPromocion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
       <script type="text/javascript">
           function validarDescuento(src, args) {
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
                <h1 class="titulo" >Nueva Promocion<span class="label label-default"><asp:Label ID="lblAccion" runat="server" Text="Label" Visible="false" ></asp:Label></span></h1>      
            </div>
        </div>
    </div>
   
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <div class="panel fondo ">
                    <div class="panel-body">
                        <div class="form-group">
                            <asp:Panel ID="pnPromocion" runat="server" >
                              <div class="container">
                                     <div class="row">
                                         <div class="col-sm-6 col-sm-offset-3">
                                             <div class="panel panel-primary">
                                                 <div class="panel-heading">
                                                    <h3 class="panel-title">Nueva Promocion</h3>
                                                </div>
                                                <div class="panel-body">
                                                    <div class="form-group">
                                                        <asp:Label ID="lblNombrePromocion" runat="server" Text="Nombre Promocion: " AssociatedControlID="txtNombrePromocion"></asp:Label>
                                                        <asp:TextBox ID="txtNombrePromocion" runat="server" CssClass="form-control" placeholder="Nombre Promocion"  MaxLength="50"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="valNomReq" runat="server" ErrorMessage="Debe Ingresar Nombre con un max de 30 caracteres" ControlToValidate="txtNombrePromocion" CssClass="text-danger" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="AceptarNP"  ></asp:RequiredFieldValidator>
                                                    </div>

                                                    <div class="form-group">
                                                        <asp:Label ID="lblFechaVigencia" runat="server" Text="Fecha Vigencia: " AssociatedControlID="txtVigencia"></asp:Label>
                                                        <asp:TextBox ID="txtVigencia" runat="server" CssClass="form-control datepicker" placeholder="Fecha dd/mm/aaaa" ></asp:TextBox>
                                                        <asp:RegularExpressionValidator ID="valVigenciaVal" runat="server" ErrorMessage="Debe ingresar fecha dd/mm/aaaa" ControlToValidate="txtVigencia" CssClass="text-danger" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                       <asp:RequiredFieldValidator ID="valVigenciaReq" runat="server" ErrorMessage="Debe Ingresar Vigencia" ControlToValidate="txtVigencia" CssClass="text-danger" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="AceptarNP"  ></asp:RequiredFieldValidator>
                                                       <asp:CompareValidator ID="valVigenciaComp" runat="server" ErrorMessage="Fecha Mayor a Hoy" Operator="GreaterThan" Type="Date" ControlToCompare="txtFechaComparar" ControlToValidate="txtVigencia" Display="Dynamic" CssClass="text-danger" SetFocusOnError="true" ValidationGroup="AceptarNP"   ></asp:CompareValidator>
                                                       <asp:TextBox ID="txtFechaComparar" runat="server" Visible="false"></asp:TextBox>
                                                    </div>
                                                    <div>
                                                        <asp:Button ID="btnAceptarNP" runat="server" Text="Aceptar" Cssclass="btn btn-success"  ValidationGroup="AceptarNP" OnClick="btnAceptarNP_Click" />
                                                   </div>
                                                   
                        
                                                </div>
                                            </div>
               

                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                        </div>
                         <div class="form-group">
                            <asp:Panel ID="pnGolosinaElegir" runat="server" Visible="false" >
                                <div class="form-horizontal" role="form">
                                    <div class="form-group">                                                               
                                             <asp:Label ID="lblNombreGolosinaPromBuscar" runat="server" Text="Nombre de Buscar:" AssociatedControlID="txtNombreGolosinaPromBuscar" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD" ></asp:Label>
                                        <div class="col-sm-8">
                                             <asp:TextBox ID="txtNombreGolosinaPromBuscar" runat="server" CssClass="form-control" placeholder="Nombre Golosina" ></asp:TextBox>     
                                             <asp:RegularExpressionValidator ID="valNombreBuscarValido" runat="server" ErrorMessage="Debe ingresar solo letras" ControlToValidate="txtNombreGolosinaPromBuscar" CssClass="text-danger" ValidationExpression="^[a-zA-Z]*$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Buscar"></asp:RegularExpressionValidator>
                                        </div>
                                        <div class="col-sm-2">
                                             <asp:Button ID="btnBuscarGolosinaProm" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="btnBuscarGolosinaProm_Click" ValidationGroup="Buscar" />    
                                        </div>
                                    </div>
                                </div>                                   
                                 <br/>  
                                                                                                                  
                                 <asp:GridView ID="gvDatosGolosinasProm" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="idGolosina" CssClass="table table-bordered bs-table fondo1" OnPageIndexChanging="gvDatos_PageIndexChanging" OnSelectedIndexChanged="gvDatos_SelectedIndexChanged" OnSorting="gvDatos_Sorting" PageSize="7"  >
                                    <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                                    <SelectedRowStyle BackColor="#ffffcc" />
                                    <PagerStyle HorizontalAlign="Center" />
                                   
                                    <Columns>
                                        <asp:BoundField DataField="idGolosina" HeaderText="IdGolosina"  Visible="False" />
                                        <asp:BoundField DataField="nombre" HeaderText="Golosina" SortExpression="nombre" />
                                        <asp:BoundField DataField="precio" HeaderText="Precio"  />
                                        <asp:CommandField ShowSelectButton="True" />
                                    </Columns>
                                </asp:GridView>
                               
                                <asp:Button ID="btnElegirGolosina" runat="server" Text="Elegir" CssClass="btn btn-success" OnClick="btnElegirGolosina_Click"  />
                                <asp:Button ID="btnVerPromocion" runat="server" Text="Ver Agregados" CssClass="btn btn-info" OnClick="btnVerPromocion_Click" />
                                <asp:Button ID="btnCancelarGolosina" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelarGolosina_Click"  />
                                
                            </asp:Panel>
                        </div>
                        <div class="form-group">
                            <asp:Panel ID="pnDetalleProm" runat="server" Visible="false">
                                 <div class="container">
                                     <div class="row">
                                         <div class="col-sm-6 col-sm-offset-3">
                                             <div class="panel panel-primary">
                                                 <div class="panel-heading">
                                                    <h3 class="panel-title">Promocion</h3>
                                                </div>
                                                <div class="panel-body">
                                                     <asp:Label ID="lblIdGolosinaP" runat="server" Text="" visible="false" ></asp:Label>
                                                    <asp:Label ID="lblPrecioGolosinaP" runat="server" Text="" Visible="false"></asp:Label>   
                                                    <div class="form-group">
                                                        <asp:Label ID="lblNombreGolosinaP" runat="server" Text="Nombre: " AssociatedControlID="txtNombreGolosinaP"></asp:Label>
                                                        <asp:TextBox ID="txtNombreGolosinaP" runat="server" CssClass="form-control" placeholder="Nombre"  MaxLength="50" Enabled="false"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                         <asp:Label ID="lblNombreTP" runat="server" Text="Nombre Promocion: " AssociatedControlID="txtNombreTP"></asp:Label>
                                                        <asp:TextBox ID="txtNombreTP" runat="server" CssClass="form-control" placeholder="Promocion" MaxLength="30"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="reqNombrePVal" runat="server" ErrorMessage="Debe Ingresar un Nombre de Promocion " ControlToValidate="txtNombreTP" CssClass="text-danger" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:Label ID="lblDescuento" runat="server" Text="Descuento: " AssociatedControlID="ddlDescuento"></asp:Label>
                                                        <asp:DropDownList ID="ddlDescuento" runat="server" CssClass="form-control"></asp:DropDownList>
                                                        <asp:CustomValidator ID="valListaDescuento" runat="server" ErrorMessage="Debe Elegir Un Descuento" ControlToValidate="ddlDescuento" OnServerValidate="valListaDescuento_ServerValidate" ClientValidationFunction="validarDescuento" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:CustomValidator>
                                                    </div>                                                 
                                                    <div class="form-group">
                                                        <asp:Label ID="lblCantPaqueteP" runat="server" Text="Paquetes con Prom.:" AssociatedControlID="txtCantPaqueteP"></asp:Label>
                                                        <asp:TextBox ID="txtCantPaqueteP" runat="server" CssClass="form-control"  placeholder="Cant. Paquetes Prom." TextMode="Number"></asp:TextBox>
                                                        <asp:CompareValidator ID="cantPValido" runat="server" ErrorMessage="Ingrese Numeros"  Type="Integer" Operator="GreaterThan" ValueToCompare="0" Display="Dynamic"  ControlToValidate="txtCantPaqueteP" CssClass="text-danger" SetFocusOnError="true" ValidationGroup="Aceptar"></asp:CompareValidator>
                                                        <asp:RequiredFieldValidator ID="cantReq" runat="server" ErrorMessage="Debe ingresar una cantidad" ControlToValidate="txtCantPaqueteP" CssClass="text-danger" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>
                                                    </div>
                           
                                                    <div>
                                                        <asp:Button ID="btnAgregarOtro" runat="server" Text="Agregar" Cssclass="btn btn-success"  ValidationGroup="Aceptar" OnClick="btnAgregarOtro_Click" />
                                                      
                                                        <asp:Button ID="btnModificar" runat="server" Text="Modificar Anterior" CssClass="btn btn-info" OnClick="btnVolver_Click"  />
                                                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger"  OnClick="btnCancelar_Click" />                                                        
                                                    </div>
                                                   
                        
                                                </div>
                                            </div>
               

                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                         <asp:Label ID="lblMensaje" runat="server" CssClass="Mensaje" Enabled="false"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphFooter" runat="server">
    <script type="text/javascript">
       $(document).ready(
           function () {
               $(".datepicker").datepicker({
                   changeMonth: true, dateFormat: "dd-mm-yy", dayNamesMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa"], 
                   monthNamesShort: ["Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"], minDate: 2
               });
               $('.datepicker').datepicker('setDate', 'today');

               });

          

   </script>
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

    </script>
</asp:Content>
