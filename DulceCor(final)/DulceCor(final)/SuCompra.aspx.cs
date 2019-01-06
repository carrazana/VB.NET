using DulceCorEnt;
using DulceCorNeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DulceCor_final_
{
    public partial class SuCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                cargarGrilla();
            }
            List<ItemCarrito> MiCarrito = (List<ItemCarrito>)Session["Carrito"];
            
            if(MiCarrito!=null)
                txtTotal.Text = MiCarrito.Sum(x => x.SubTotal).ToString("0.00");
            
         }

        private void cargarGrilla()
        {
            grdCompra.DataSource = (List<ItemCarrito>)Session["Carrito"];
            grdCompra.DataBind();   
        }

        protected void grdCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            //eliminar
            lblMensaje.Visible = false;
            List<ItemCarrito> MiCarrito = (List<ItemCarrito>)Session["Carrito"];

            int id = int.Parse(grdCompra.SelectedValue.ToString());
            for(int i=0; i < MiCarrito.Count ;i++)
            {
                if(MiCarrito[i].IdGolosina==id)
                {
                    MiCarrito.RemoveAt(i);
                    break;
                }
            }
            cargarGrilla();
            txtTotal.Text = MiCarrito.Sum(x => x.SubTotal).ToString("0.00");
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Session["IdUsuario"] = GestorUsuarios.ObtenerIdUsuario(Session["Usuario"].ToString());
                int IdUsuario = int.Parse(Session["IdUsuario"].ToString());
                List<ItemCarrito> MiCarrito = (List<ItemCarrito>)Session["Carrito"];
                GestorVenta.grabar(MiCarrito,IdUsuario);
                lblMensaje.Visible = true;
                lblMensaje.Text = "Se Grabo Con Exito!!";
                Session["Carrito"] = null;
                cargarGrilla();
                txtTotal.Text = "0";
            }
            catch(Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = ex.Message;
            }
            

        }

        private void MostrarMensaje(string msj)
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "msjServidor",
            @" 
        <script type='text/javascript'>
            $( function () {
                $('#dialogo').html('" + msj + @"');   // escribo el msj
                $('#dialogo').dialog(); //muestro el msj
            });
        </script>
        ");
        }

        
    }
}
