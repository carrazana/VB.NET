using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DulceCorEnt;
using DulceCorNeg;

namespace DulceCor_final_
{
    public partial class SuPromocion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }
        }

        private void cargarGrilla()
        {
            grdPromocion.DataSource = (List<TipoPromocion>)Session["DetProm"];
            grdPromocion.DataBind();
        }

        protected void grdPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            List<TipoPromocion> MiProm = (List<TipoPromocion>)Session["DetProm"];

            int id = int.Parse(grdPromocion.SelectedValue.ToString());
            for (int i = 0; i < MiProm.Count; i++)
            {
                if (MiProm[i].idTipoPromocion == id)
                {
                    MiProm.RemoveAt(i);
                    break;
                }
            }
            cargarGrilla();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {   List<TipoPromocion> MiProm = (List<TipoPromocion>)Session["DetProm"];
            Promocion prom = (Promocion)Session["Prom"];
            if(MiProm!=null)
            {
            try
            {

                
                GestorPromociones.grabar( MiProm,prom);
                lblMensaje.Visible = true;
                lblMensaje.Text = "Se Grabo Con Exito!!";
                Session["Prom"] = null;
                Session["DetProm"] = null;
                cargarGrilla();

            }
            catch (Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = ex.Message;
            }
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "No hay Promocion!";
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