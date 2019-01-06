<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="Consumidores.aspx.cs" Inherits="DulceCor_final_.Consumidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
    


    <script type="text/javascript">
      function validarLargoDni(objSource, objArgs) {

          var num = objArgs.Value;
          if (num.length < 8) {
              objArgs.IsValid = false;
              return;
          }
          else {
              objArgs.IsValid = true;
              return;
          }

      }
    </script>
       <script type="text/javascript">
           function validarLargoTel(objSource, objArgs) {

               var num = objArgs.Value;
               if (num.length === 7 || num.length === 10) {
                   objArgs.IsValid = true;
                   return;
               }
               else {
                   objArgs.IsValid = false;
                   return;
               }

           }
    </script>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">

     <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1 class="titulo" >Consumidores<span class="label label-default"><asp:Label ID="lblAccion" runat="server" Text="Label" Visible="false" ></asp:Label></span></h1>      
            </div>
        </div>
    </div>
   
    <div class="container">
        <div class="row ">
            <div class="col-sm-12 ">
                <div class="panel fondo  ">
                    <div class="panel-body ">
                        <div class="form-group ">
                            <asp:Panel ID="pnConsulta" runat="server"  >
                                <div class="form-horizontal " role="form">
                                    <div class="form-group">                                                               
                                             <asp:Label ID="lblNombreBuscar" runat="server" Text="Nombre a Buscar:" AssociatedControlID="txtNombreBuscar" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD"  ></asp:Label>
                                        <div class="col-sm-8">
                                             <asp:TextBox ID="txtNombreBuscar" runat="server" CssClass="form-control" placeholder="Nombre" ></asp:TextBox>     
                                             <asp:RegularExpressionValidator ID="valNombreBuscarValido" runat="server" ErrorMessage="Debe ingresar solo letras" ControlToValidate="txtNombreBuscar" CssClass="text-danger" ValidationExpression="^[a-zA-Z]*$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Buscar"></asp:RegularExpressionValidator>
                                        </div>
                                        <div class="col-sm-2">
                                             <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" ValidationGroup="Buscar" />    
                                        </div>
                                    </div>
                                </div>                                   
                                 <br/>  
                                                                                                                  
                                 <asp:GridView ID="gvDatos" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="idConsumidor" CssClass="table table-bordered bs-table fondo1" OnPageIndexChanging="gvDatos_PageIndexChanging" OnSelectedIndexChanged="gvDatos_SelectedIndexChanged" OnSorting="gvDatos_Sorting" PageSize="7"  >
                                    <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                                    <SelectedRowStyle BackColor="#ffffcc" />
                                    <PagerStyle HorizontalAlign="Center" />
                                   
                                    <Columns>
                                        <asp:BoundField DataField="idConsumidor" HeaderText="IdConsumidor" SortExpression="idConsumidor" ReadOnly="true"  />
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" HeaderStyle-CssClass="visible-lg-md-sm-xs" ItemStyle-CssClass="visible-lg-md-sm-xs"  >
                                        <HeaderStyle CssClass="visible-lg-md-sm-xs" />
                                        <ItemStyle CssClass="visible-lg-md-sm-xs" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="apellido" HeaderText="Apellido" SortExpression="apellido" HeaderStyle-CssClass="hidden-xs" ItemStyle-CssClass="hidden-xs" >
                                        <HeaderStyle CssClass="hidden-xs" />
                                        <ItemStyle CssClass="hidden-xs" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="numeroDoc" HeaderText="Nro. Doc" SortExpression="numeroDoc" HeaderStyle-CssClass="hidden-xs" ItemStyle-CssClass="hidden-xs"  >
                                        <HeaderStyle CssClass="hidden-xs" />
                                        <ItemStyle CssClass="hidden-xs" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="correo" HeaderText="Email" HeaderStyle-CssClass="hidden-xs" ItemStyle-CssClass="hidden-xs" >
                                        <HeaderStyle CssClass="hidden-xs" />
                                        <ItemStyle CssClass="hidden-xs" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="telefono" HeaderText="Telefono" HeaderStyle-CssClass="hidden-xs" ItemStyle-CssClass="hidden-xs" >
                                        <HeaderStyle CssClass="hidden-xs" />
                                        <ItemStyle CssClass="hidden-xs" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="direccion" HeaderText="Direccion" ItemStyle-CssClass="visible-lg" HeaderStyle-CssClass="visible-lg" >
                                        <HeaderStyle CssClass="visible-lg" />
                                        <ItemStyle CssClass="visible-lg" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="nombreBarrio" HeaderText="Barrio" ItemStyle-CssClass="visible-lg" HeaderStyle-CssClass="visible-lg" >
                                        <HeaderStyle CssClass="visible-lg" />
                                        <ItemStyle CssClass="visible-lg" />
                                        </asp:BoundField>
                                        <asp:CommandField ShowSelectButton="True" SelectText="Selec." />
                                    </Columns>
                                </asp:GridView>
                               
                                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click"  />
                                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn btn-info" OnClick="btnConsultar_Click"  />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click"  />
                                <asp:Label ID="lblMensaje" runat="server" CssClass="Mensaje" Enabled="false"></asp:Label>
                            </asp:Panel>
                        </div>
                        <div class="form-group">
                            <asp:Panel ID="pnRegistro" runat="server" Visible="false">
                                 <div class="container">
                                     <div class="row">
                                         <div class="col-sm-6 col-sm-offset-3">
                                             <div class="panel panel-primary">
                                                 <div class="panel-heading">
                                                    <h3 class="panel-title">Consumidor</h3>
                                                </div>
                                                <div class="panel-body">
                                                      <div class="form-group">
                                                         <asp:Label ID="lblIdConsumidor" runat="server" Text="Id Consumidor:" AssociatedControlID="txtIdConsumidor" ></asp:Label>
                                                        <asp:TextBox ID="txtIdConsumidor" runat="server" CssClass="form-control" placeholder="Id" Enabled="false"></asp:TextBox>
                                                        
                                                    </div>  
                                                    <div class="form-group">
                                                        <asp:Label ID="lblNombre" runat="server" Text="Nombre: " AssociatedControlID="txtNombre"></asp:Label>
                                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre"  MaxLength="30"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="valNombreRequerido" runat="server" ErrorMessage="Debe Ingresar Nombre con un max de 30 caracteres" ControlToValidate="txtNombre" CssClass="text-danger" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"  ></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="valNombreValido" runat="server" ErrorMessage="Debe ingresar solo letras" ControlToValidate="txtNombre" CssClass="text-danger" ValidationExpression="^[a-zA-Z]*$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                    </div>
                                                    <div class="form-group">
                                                         <asp:Label ID="lblApellido" runat="server" Text="Apellido: " AssociatedControlID="txtApellido"></asp:Label>
                                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido" MaxLength="30"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="reqApellidoVal" runat="server" ErrorMessage="Debe Ingresar Apellido con un max de 30 caracteres" ControlToValidate="txtApellido" CssClass="text-danger" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="valApellidoValido" runat="server" ErrorMessage="Debe ingresar solo letras" ControlToValidate="txtApellido" CssClass="text-danger" ValidationExpression="^[a-zA-Z]*$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>

                                                    </div>
                                                    <div class="form-group">
                                                        <asp:Label ID="lblFechaNac" runat="server" Text="Fecha de Nacimiento: " AssociatedControlID="txtFechaNac"></asp:Label>
                                                        <asp:TextBox ID="txtFechaNac" runat="server" CssClass="form-control datepicker" placeholder="Fecha dd/mm/aaaa" ></asp:TextBox>
                                                         <asp:RegularExpressionValidator ID="regFechaNac" runat="server" ErrorMessage="Debe ingresar fecha dd/mm/aaaa" ControlToValidate="txtFechaNac" CssClass="text-danger" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:Label ID="lblNumDoc" runat="server" Text="Numero de Doc:" AssociatedControlID="txtNumDoc"></asp:Label>
                                                        <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control"  placeholder="Nro. Doc" MaxLength="8"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="valNumDocRequerido" runat="server" ErrorMessage="Debe Ingresar Numero de Doc." ControlToValidate="txtNumDoc" CssClass="text-danger" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>
                                                        <asp:CustomValidator ID="numDocValido" runat="server" ErrorMessage="Debe tener 8 digitos" ControlToValidate="txtNumDoc" ClientValidationFunction="validarLargoDni" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:CustomValidator>
                                                        <asp:RegularExpressionValidator ID="valNumDocVal" runat="server" ErrorMessage="Debe ingresar solo numeros" ControlToValidate="txtNumDoc" CssClass="text-danger" ValidationExpression="^[0-9]*$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                    </div>                                                 
                                                    <div class="form-group">
                                                        <asp:Label ID="lblBarrio" runat="server" Text="Barrio: " AssociatedControlID="ddlBarrio"></asp:Label>
                                                        <asp:DropDownList ID="ddlBarrio" runat="server" CssClass="form-control"></asp:DropDownList>
                                                    </div>
                                                     <div class="form-group">
                                                        <asp:Label ID="lblDireccion" runat="server" Text="Direccion: " AssociatedControlID="txtDireccion"></asp:Label>
                                                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"  placeholder="Direccion"></asp:TextBox>     
                                                    </div>   
                                                    <div class="form-group">
                                                        <asp:Label ID="lblTelefono" runat="server" Text="Numero de Tel:" AssociatedControlID="txtTelefono"></asp:Label>
                                                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"  placeholder="Nro. Tel"  MaxLength="10"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="valTelefonoRequerido" runat="server" ErrorMessage="Debe Ingresar Numero de Telefono" ControlToValidate="txtTelefono" CssClass="text-danger" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RequiredFieldValidator>  
                                                        <asp:RegularExpressionValidator ID="valTelefonoValido" runat="server" ErrorMessage="Debe ingresar solo numeros" ControlToValidate="txtTelefono" CssClass="text-danger" ValidationExpression="^[0-9]*$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                        <asp:CustomValidator ID="valTelefonoLargo" runat="server" ErrorMessage="Debe tener 7 o 10 digitos" ControlToValidate="txtTelefono" ClientValidationFunction="validarLargoTel" CssClass="text-danger" Display="Dynamic" ValidationGroup="Aceptar"></asp:CustomValidator>
                                                     </div>
                                                     <div class="form-group">
                                                        <asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail"></asp:Label>
                                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"  placeholder="Email"></asp:TextBox>
                                                        <asp:RegularExpressionValidator ID="valEmailValido" runat="server" ErrorMessage="Debe Ingresar un Email Valido" ControlToValidate="txtEmail" CssClass="text-danger" ValidationExpression="^((?>[a-zA-Z\d!#$%&'*+\-/=?^_`{|}~]+\x20*|&quot;((?=[\x01-\x7f])[^&quot;\\]|\\[\x01-\x7f])*&quot;\x20*)*(?<angle><))?((?!\.)(?>\.?[a-zA-Z\d!#$%&'*+\-/=?^_`{|}~]+)+|&quot;((?=[\x01-\x7f])[^&quot;\\]|\\[\x01-\x7f])*&quot;)@(((?!-)[a-zA-Z\d\-]+(?<!-)\.)+[a-zA-Z]{2,}|\[(((?(?<!\[)\.)(25[0-5]|2[0-4]\d|[01]?\d?\d)){4}|[a-zA-Z\d\-]*[a-zA-Z\d]:((?=[\x01-\x7f])[^\\\[\]]|\\[\x01-\x7f])+)\])(?(angle)>)$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>                                                      
                                                     </div>    
                                                    <div class="form-group">
                                                        <asp:Label ID="lblRazonSocial" runat="server" Text="Razon Social:" AssociatedControlID="txtRazonSocial"></asp:Label>
                                                        <asp:TextBox ID="txtRazonSocial" runat="server" CssClass="form-control"  placeholder="Razon Social" MaxLength="30"></asp:TextBox>
                                                        <asp:RegularExpressionValidator ID="valRazonSocialValida" runat="server" ErrorMessage="Debe ingresar solo letras" ControlToValidate="txtRazonSocial" CssClass="text-danger" ValidationExpression="^[a-zA-Z.]*$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Aceptar"></asp:RegularExpressionValidator>
                                                    </div>   
                                                    <div class="form-group">
                                                        <asp:Label ID="lblCuit" runat="server" Text="Cuit:" AssociatedControlID="txtCuit"></asp:Label>
                                                        <asp:TextBox ID="txtCuit" runat="server" CssClass="form-control"  placeholder="Cuit"></asp:TextBox>                                                        
                                                    </div>
                                                    <div class="form-group">
                                                        <asp:Label ID="lblPuntaje" runat="server" Text="Puntaje:" AssociatedControlID="txtPuntaje"></asp:Label>
                                                        <asp:TextBox ID="txtPuntaje" runat="server" CssClass="form-control"  placeholder="Puntaje"  TextMode="Number"></asp:TextBox>
                                                       
                                                    </div> 
                                                    <div class="form-group">
                                                        <asp:Label ID="lblHabilitado" runat="server" Text="Habilitado:" AssociatedControlID="chbHabilitado" ></asp:Label>
                                                        <asp:CheckBox ID="chbHabilitado" runat="server"  />
                                                    </div>        
                                                    
                                                   <%-- <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Han ocurrido los siguientes errores: " CssClass="alert-danger" ValidationGroup="Aceptar"  />             --%>
                                                    <asp:Label ID="lblUnico" runat="server" Text="" CssClass="text-danger" Visible="False" ></asp:Label>
                                                    <div>
                                                        <asp:Button ID="btnGrabar" runat="server" Text="Grabar" Cssclass="btn btn-success" OnClick="btnGrabar_Click" ValidationGroup="Aceptar" />
                                                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-success" OnClick="btnModificar_Click"  />
                                                        <asp:Button ID="btnBorrar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnBorrar_Click" />
                                                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-info"  OnClick="btnCancelar_Click" />
                                                    </div>
                                                   
                        
                                                </div>
                                            </div>
               

                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
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
                   changeMonth: true, changeYear: true, yearRange: '1916:1999', dateFormat: "dd-mm-yy", dayNamesMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa"], 
                   monthNamesShort: [ "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" ]
               });

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
