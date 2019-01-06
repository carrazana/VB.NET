using DulceCorNeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace DulceCor_final_
{
    public partial class InformeVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlTipoGolosina.DataTextField = "nombre";
                ddlTipoGolosina.DataValueField = "idTipoGolosina";
                ddlTipoGolosina.DataSource = GestorTipoGolosina.obtenerTodas();
                ddlTipoGolosina.DataBind();
                ddlTipoGolosina.Items.Insert(0, new ListItem("Todos", ""));

                ViewState["GvDatosOrden"] = "Fecha";

                gvDatosInfoVen.AllowPaging = true;
                gvDatosInfoVen.AllowSorting = true;
                gvDatosInfoVen.PageSize = 2;


            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarGrilla();


        }

        private void cargarGrilla()
        {
            string nombre = null;
            nombre = txtNombreBuscar.Text;

            decimal? total = null;
            if (!string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                total = decimal.Parse(txtTotal.Text);
            }
            DateTime? fecha = null;
            if (!string.IsNullOrWhiteSpace(txtFechaMax.Text))
            {
                fecha = DateTime.Parse(txtFechaMax.Text);
            }
            int tipoGolosina = 0;
            if (ddlTipoGolosina.SelectedIndex != 0)
            {
                tipoGolosina = int.Parse(ddlTipoGolosina.SelectedValue);
            }
            string orden = ViewState["GvDatosOrden"].ToString();

            gvDatosInfoVen.DataSource = GestorVenta.buscarInfoVenta(nombre, fecha, total, tipoGolosina, orden);
            gvDatosInfoVen.DataBind();
        }

        protected void gvDatos_Sorting(object sender, GridViewSortEventArgs e)
        {
            ViewState["GvDatosOrden"] = e.SortExpression;
            cargarGrilla();
        }

       protected void gvDatosInfoVen_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDatosInfoVen.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }

        
    }
}