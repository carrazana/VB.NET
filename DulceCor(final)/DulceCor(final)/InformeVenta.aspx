<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="InformeVenta.aspx.cs" Inherits="DulceCor_final_.InformeVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
         <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1 class="titulo" >Informe de Ventas<span class="label label-default"><asp:Label ID="lblAccion" runat="server" Text="Label" Visible="false" ></asp:Label></span></h1>      
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
                                             <asp:Label ID="lblNombreBuscar" runat="server" Text="Nombre Golosina a Buscar:" AssociatedControlID="txtNombreBuscar" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD"  ></asp:Label>
                                        <div class="col-sm-8">
                                             <asp:TextBox ID="txtNombreBuscar" runat="server" CssClass="form-control" placeholder="Nombre" ></asp:TextBox>     
                 
                                        </div>                                       
                                    </div>
                                    <div class="form-group">                                                               
                                             <asp:Label ID="lblTotal" runat="server" Text="Total Mayor a:" AssociatedControlID="txtTotal" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD"  ></asp:Label>
                                        <div class="col-sm-8">
                                             <asp:TextBox ID="txtTotal" runat="server" CssClass="form-control" placeholder="Precio" ></asp:TextBox>     
                                            <asp:CompareValidator ID="valTotal" CssClass="text-danger" runat="server" ErrorMessage="Debe Ingresar Solo Numeros" ControlToValidate="txtTotal" Operator="DataTypeCheck" Type="Integer" Display="Dynamic"></asp:CompareValidator>
                                        </div>                                       
                                    </div>
                                    <div class="form-group">                                                               
                                             <asp:Label ID="lblFechaMax" runat="server" Text="Hasta Fecha:" AssociatedControlID="txtFechaMax" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD" ></asp:Label>
                                        <div class="col-sm-8">
                                             <asp:TextBox ID="txtFechaMax" runat="server" CssClass="form-control datepicker" placeholder="Fecha dd/mm/aaaa" ></asp:TextBox>   
                                            <asp:CompareValidator ID="valFecha" runat="server" ErrorMessage="Ingrese Una Fecha Correcta" Display="Dynamic" ControlToValidate="txtFechaMax" CssClass="text-danger" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                                        
                                        </div> 
                                     </div>
                                    <div class="form-group">
                                        <asp:Label ID="lblTipoGolosina" runat="server" Text="Seleccione Tipo de Golosina:" AssociatedControlID="ddlTipoGolosina" CssClass="col-sm-2 control-label" ForeColor="#BDBDBD"></asp:Label>
                                        <div class=" col-sm-8 ">
                                            <asp:DropDownList ID="ddlTipoGolosina" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="form-group">                                                               
                                         <div class="col-sm-2 col-sm-offset-5 ">
                                             <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-success" ValidationGroup="Buscar" Height="50%"  OnClick="btnBuscar_Click" />    
                                        </div> 
                                    </div>
                                </div>                                   
                                 <br/>  
                                                                                                                  
                                 <asp:GridView ID="gvDatosInfoVen" runat="server" AllowPaging="True" CellPadding="4"  CssClass="table table-bordered bs-table fondo1" OnSorting="gvDatos_Sorting"  PageSize="7" OnPageIndexChanging="gvDatosInfoVen_PageIndexChanging" AutoGenerateColumns="False"  >
                                     <Columns>
                                         <asp:BoundField DataField="Golosina" HeaderText="Golosina" SortExpression="Golosina"/>
                                         <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad"/>
                                         <asp:BoundField DataField="Total" DataFormatString="${0:###,###,###.00}" HeaderText="Total" SortExpression="Total" />
                                         <asp:BoundField DataField="Tipo_Golosina" HeaderText="Tipo Golosina" SortExpression="Tipo_Golosina"/>
                                         <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:d}" SortExpression="Fecha"/>
                                         <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario"/>
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