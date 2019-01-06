<%@ Page Title="" Language="C#" MasterPageFile="~/DulceCor.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DulceCor_final_.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">

    <div class="container">
        
      <div class="row">
          <div class="col-sm-4 col-sm-offset-4">
       
               <asp:Login ID="Login1" runat="server"  TextBoxStyle-CssClass="form-control" LoginButtonStyle-CssClass="btn btn-primary center-block " OnAuthenticate="Login1_Authenticate" LabelStyle-Font-Size="Medium" LabelStyle-VerticalAlign="Middle" TitleTextStyle-Font-Size="XX-Large" LoginButtonStyle-Font-Size="Medium" LoginButtonStyle-Width="50%" FailureText="Usuario o contraseña incorrecta" >  </asp:Login>
             
          </div>
      </div>

    </div>

</asp:Content>
