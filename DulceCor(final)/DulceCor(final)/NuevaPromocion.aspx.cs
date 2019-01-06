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
    public partial class NuevaPromocion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            
            if (!IsPostBack)
            {

                ddlDescuento.DataTextField = "descuento";
                ddlDescuento.DataValueField = "idDescuento";
                ddlDescuento.DataSource = GestorDescuento.ObtenerTodosDescuentos();
                ddlDescuento.DataBind();
                ddlDescuento.Items.Insert(0, new ListItem("Elija un Descuento", "0"));
                
                ViewState["GvDatosOrden"] = "nombre";
                
                gvDatosGolosinasProm.AllowPaging = true;
                gvDatosGolosinasProm.AllowSorting = true;
                gvDatosGolosinasProm.PageSize = 2;
                gvDatosGolosinasProm.AutoGenerateColumns = false;
                
                pnGolosinaElegir.Visible = false;
                pnPromocion.Visible = true;
                pnDetalleProm.Visible = false;
                lblIdGolosinaP.Visible = false;
                lblPrecioGolosinaP.Visible = false;
                txtFechaComparar.Visible = false;
                btnModificar.Visible = false;
                btnVerPromocion.Visible = false;

                txtFechaComparar.Text = (DateTime.Today).ToShortDateString();

                btnElegirGolosina.Text = "Elegir"; 
                if(Request.QueryString["G"]!=null)
                {
                if(int.Parse(Request.QueryString["G"])==1)
                {
                    pnGolosinaElegir.Visible = true;
                    pnPromocion.Visible = false;
                    pnDetalleProm.Visible = false;
                    btnElegirGolosina.Text = "Elegir Otro"; 
                    btnModificar.Visible = true;
                    btnVerPromocion.Visible = true;
                    cargar();
                }
                }
                
            }
                
        }

        private void cargar()
        {
            string orden = ViewState["GvDatosOrden"].ToString();
            gvDatosGolosinasProm.DataSource = GestorGolosina.buscarPorNombre(txtNombreGolosinaPromBuscar.Text, orden);
            gvDatosGolosinasProm.DataBind();
            pnGolosinaElegir.Visible = true;
            pnPromocion.Visible = false;
            pnDetalleProm.Visible = false;
        }

        protected void btnAceptarNP_Click(object sender, EventArgs e)
        {
            pnGolosinaElegir.Visible = true;
            pnPromocion.Visible = false;
            pnDetalleProm.Visible = false;
            cargar();
            Promocion prom = new Promocion();
            prom.nombre = txtNombrePromocion.Text;
            prom.vigencia = DateTime.Parse(txtVigencia.Text);
            Session["Prom"] = prom;
        }

        protected void btnCancelarGolosina_Click(object sender, EventArgs e)
        {
            pnGolosinaElegir.Visible = false;
            pnPromocion.Visible = true;
            pnDetalleProm.Visible = false;
            
            lblAccion.Visible = false;
           
            txtNombreGolosinaPromBuscar.Text = "";
            Session["DetProm"] = null;
            btnAgregarOtro.Text = "Agregar";
        }

        protected void btnElegirGolosina_Click(object sender, EventArgs e)
        {
            if (gvDatosGolosinasProm.SelectedRow != null)
            {

                lblAccion.Visible = true;
                lblAccion.Text = "Agregando...";
               

                pnGolosinaElegir.Visible = false;
                pnPromocion.Visible = false;
                pnDetalleProm.Visible = true;
                
                consultar();
                bloquear();

            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Enabled = true;
                lblMensaje.Text = "Seleccione una golosina";
            }
        }

        private void consultar()
        {

            int idGolosina = (int)gvDatosGolosinasProm.SelectedValue;
            try
            {
                Golosina go = GestorGolosina.buscarPorID(idGolosina);
                lblIdGolosinaP.Text = go.IdGolosina.ToString();
                txtNombreGolosinaP.Text = go.Nombre;
                lblPrecioGolosinaP.Text = go.Precio.ToString();


            }
            catch (Exception ex)
            {
                lblAccion.Text = ex.Message;
            }
        }

        private void bloquear()
        {
            
            txtNombreGolosinaP.Enabled = false;
           
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            pnGolosinaElegir.Visible = true;
            pnPromocion.Visible = false;
            pnDetalleProm.Visible = false;

            lblAccion.Visible = false;
            
        }

        protected void btnBuscarGolosinaProm_Click(object sender, EventArgs e)
        {
            string orden = ViewState["GvDatosOrden"].ToString();
            gvDatosGolosinasProm.DataSource = GestorGolosina.buscarPorNombre(txtNombreGolosinaPromBuscar.Text, orden);
            gvDatosGolosinasProm.DataBind();
        }

        protected void gvDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDatosGolosinasProm.PageIndex = e.NewPageIndex;
            cargar();
        }
        protected void gvDatos_Sorting(object sender, GridViewSortEventArgs e)
        {
            ViewState["GvDatosOrden"] = e.SortExpression;
            cargar();
        }

        protected void gvDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idGolosina = (int)gvDatosGolosinasProm.SelectedValue;
        }

        protected void valListaDescuento_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "0")
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }

         
        }

        protected void btnVerPromocion_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuPromocion.aspx",false);
            
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            List<TipoPromocion> MiProm = (List<TipoPromocion>)Session["DetProm"];
            if (MiProm.Count != 0)
            {
           
            var ultimo = MiProm.Last();
            Golosina gol = GestorGolosina.buscarPorID(ultimo.golosinaId);
            txtNombreGolosinaP.Text = gol.Nombre;
            lblPrecioGolosinaP.Text = gol.Precio.ToString();
            txtNombreTP.Text = ultimo.tipoProm;
            ddlDescuento.SelectedValue = (ultimo.descuento).ToString();
            txtCantPaqueteP.Text = (ultimo.cantidadPaquetes).ToString();
            MiProm.RemoveAt(MiProm.Count - 1);
            Session["DetProm"] = MiProm;
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Enabled = true;
                lblMensaje.Text = "No hay anteriores";
       
            }
            
        }

        protected void btnAgregarOtro_Click(object sender, EventArgs e)
        {
            int descuento = GestorDescuento.ObtenerDescuento(int.Parse(ddlDescuento.SelectedValue));
            
            TipoPromocion tp = new TipoPromocion();
            {
                tp.tipoProm = txtNombreTP.Text;
                tp.cantidadPaquetes = int.Parse(txtCantPaqueteP.Text);
                tp.descuento = int.Parse(ddlDescuento.SelectedValue);
                tp.golosinaId = int.Parse(lblIdGolosinaP.Text);
                tp.golosinaN = txtNombreGolosinaP.Text;
                tp.precioProm = precioP(descuento, tp.cantidadPaquetes, decimal.Parse(lblPrecioGolosinaP.Text));
            };
            List<TipoPromocion> MiProm = new List<TipoPromocion>();

            if (Session["DetProm"] != null)
            {
                MiProm = (List<TipoPromocion>)Session["DetProm"];
            }
           
            MiProm.Add(tp);

            Session["DetProm"] = MiProm;

            pnGolosinaElegir.Visible = true;
            pnPromocion.Visible = false;
            pnDetalleProm.Visible = false;

            btnElegirGolosina.Text = "Elegir Otro"; 
            btnModificar.Visible = true;
            btnVerPromocion.Visible = true;
            limpiar();
            
            
        }

        private void limpiar()
        {
            lblIdGolosinaP.Text = "";
            lblPrecioGolosinaP.Text = "";
            txtNombrePromocion.Text = "";
            txtNombreGolosinaP.Text = "";
            txtCantPaqueteP.Text = "";
            txtNombreTP.Text = "";
            ddlDescuento.SelectedIndex =-1;
            
        }

        private decimal precioP(int descuento, int cantidad, decimal precio)
        {
            decimal p;
            decimal r = (precio * (100 - descuento))/100;
          return p =cantidad * r; 
        }


        
    }
}