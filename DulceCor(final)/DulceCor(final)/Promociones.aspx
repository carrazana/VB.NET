<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="Promociones.aspx.cs" Inherits="DulceCor_final_.Promociones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="container">

        <div class="row">

            <div class="col-md-3">
                <p class="lead">Tipos de Golosina</p>
                <div class="list-group">
                    <asp:Repeater ID="rptTipoGolosina" runat="server">
                        <ItemTemplate>
                            <a href='Promociones.aspx?idTipoGolosina=<%# Eval("idTipoGolosina") %>' class="list-group-item"><%# Eval("nombre") %></a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>              
                
            </div>
        
        <div class="col-md-9">

            <div class="row carousel-holder">

                    <div class="col-md-12">
                        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                            <ol class="carousel-indicators">
                                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                            </ol>
                            <div class="carousel-inner">
                                <div class="item active">
                                    <img class="slide-image" src="img/golosinas1.jpg" alt=""/>
                                </div>
                                <div class="item">
                                    <img class="slide-image" src="img/golosinas2.jpg" alt=""/>
                                </div>
                                <div class="item">
                                    <img class="slide-image" src="img/golosinas3.jpg" alt=""/>
                                </div>
                            </div>
                            <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                                <span class="glyphicon glyphicon-chevron-left"></span>
                            </a>
                            <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                                <span class="glyphicon glyphicon-chevron-right"></span>
                            </a>
                        </div>
                    </div>

                </div>

            <div class="row">
                    <asp:Repeater ID="rptGolosinas" runat="server" OnItemCommand="rptGolosinas_ItemCommand">
                        <ItemTemplate>
                            <div class="col-sm-4 col-lg-4 col-md-4">
                                <div class="thumbnail">
                                    <img src="<%# Eval("imagen") %>" alt="">
                                    <div class="caption">
                                        
                                        <h4><a href="#"><%# Eval("golosina") %></a></h4>     
                                        <h4>Promocion: <%# Eval("prom") %> <%# Eval("tpNom") %></a></h4>
                                        <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-primary" CommandArgument='<%#Eval("idTipoPromocion") %>' CommandName="Comprar" />                                                                        
                                  <!--                 <asp:Button ID="btnDetalle" runat="server" Text="Detalle" CssClass="btn btn-info" CommandName="ver" CommandArgument='<%#Eval("idGolosina") %>'/>      -->
                                        <asp:TextBox ID="txtCantidad" runat="server" Width="40" placeHolder="Cant." Text="1"></asp:TextBox> 
                                        <h4 class="pull-right"><%# Eval("precioProm","${0:###,###,###.00}") %></h4>
                                    </div>                               
                                </div>
                                 
                            </div>

                           
                        </ItemTemplate>
                    </asp:Repeater>
                <asp:Label ID="lblMensaje" runat="server" CssClass="Mensaje" Visible="false"></asp:Label>
            </div>
        </div>
    </div>

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
