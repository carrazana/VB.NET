<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="InformePromocion.aspx.cs" Inherits="DulceCor_final_.InformePromocion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
         <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1 class="titulo" >Informe de Promociones<span class="label label-default"><asp:Label ID="lblAccion" runat="server" Text="Label" Visible="false" ></asp:Label></span></h1>      
            </div>
        </div>
    </div>
   
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <div class="panel fondo ">
                    <div class="panel-body">
                        <div class="form-group">
                            <asp:Panel ID="pnInforme" runat="server" >
                                <div class="form-horizontal" role="form">
                                    <div class="form-group">                                                               
                                             <asp:Label ID="lblNombreBuscar" runat="server" Text="Nombre Promocion a Buscar:" AssociatedControlID="txtNombreBuscar" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD"  ></asp:Label>
                                        <div class="col-sm-8">
                                             <asp:TextBox ID="txtNombreBuscar" runat="server" CssClass="form-control" placeholder="Nombre" ></asp:TextBox>     
                                             <asp:RegularExpressionValidator ID="valNombreBuscarValido" runat="server" ErrorMessage="Debe ingresar solo letras" ControlToValidate="txtNombreBuscar" CssClass="text-danger" ValidationExpression="^[a-zA-Zñ]*$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Buscar"></asp:RegularExpressionValidator>
                                        </div>                                       
                                    </div>
                                    <div class="form-group">                                                               
                                             <asp:Label ID="lblFechaMax" runat="server" Text="Hasta Fecha:" AssociatedControlID="txtFechaMax" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD" ></asp:Label>
                                        <div class="col-sm-8">
                                             <asp:TextBox ID="txtFechaMax" runat="server" CssClass="form-control datepicker" placeholder="Fecha dd/mm/aaaa" ></asp:TextBox>   
                                             <asp:RegularExpressionValidator ID="regFechaMax" runat="server" ErrorMessage="Debe ingresar fecha dd/mm/aaaa" ControlToValidate="txtFechaMax" CssClass="text-danger" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$" Display="Dynamic"  SetFocusOnError="true" ValidationGroup="Buscar"></asp:RegularExpressionValidator>
                                        
                                        </div> 
                                     </div>
                                    <div class="form-group">                                                               
                                             <asp:Label ID="lblPromocion" runat="server" Text="Seleccione tipo de promocion:" AssociatedControlID="cblPromociones" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD"  ></asp:Label>
                                        <div class=" col-sm-8 ">
                                            <asp:CheckBoxList ID="cblPromociones" runat="server"   RepeatLayout="Flow" RepeatDirection="Vertical"  TextAlign="Right" RepeatColumns="2" CellSpacing="10"    >
                                                                             
                                            </asp:CheckBoxList>
                                        </div>                                        
                                    </div>
                                    <div class="form-group">                                                               
                                         <div class="col-sm-2 col-sm-offset-5 ">
                                             <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" ValidationGroup="Buscar" Height="50%"  OnClick="btnBuscar_Click" />    
                                        </div> 
                                    </div>
                                </div>                                   
                                 <br/>  
                                                                                                                  
                                 <asp:GridView ID="gvDatosInfoProm" runat="server" AllowPaging="True" CellPadding="4"  CssClass="table table-bordered bs-table fondo1" OnPageIndexChanging="gvDatos_PageIndexChanging"  OnSorting="gvDatos_Sorting" PageSize="7" AutoGenerateColumns="False"  >
                                    <Columns>
                                         <asp:BoundField DataField="golosina" HeaderText="Golosina" SortExpression="golosina"/>
                                         <asp:BoundField DataField="precio" DataFormatString="${0:###,###,###.00}" HeaderText="Precio" SortExpression="precio" />
                                         <asp:BoundField DataField="promocion" HeaderText="Promocion" SortExpression="promocion"/>
                                         <asp:BoundField DataField="vigencia" HeaderText="Vigencia" DataFormatString="{0:d}" SortExpression="vigencia"/>
                                        <asp:BoundField DataField="descuento" HeaderText="Descuento" DataFormatString="{0:###,###,###}%" SortExpression="descuento"/>
                                        <asp:BoundField DataField="cantidadPaquete" HeaderText="Cantidad" SortExpression="cantidadPaquete"/>
                                        <asp:BoundField DataField="tProm" HeaderText="Nombre Promocion" SortExpression="tProm"/>

                                     </Columns>
                                     <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                                    <SelectedRowStyle BackColor="#ffffcc" />
                                    <PagerStyle HorizontalAlign="Center" />
                                   
                                </asp:GridView>
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
                   changeMonth: true, changeYear: true, yearRange: '2016:2035', dateFormat: "dd-mm-yy", dayNamesMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa"], 
                   monthNamesShort: [ "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" ]
               });

               });

          

   </script>
</asp:Content>
