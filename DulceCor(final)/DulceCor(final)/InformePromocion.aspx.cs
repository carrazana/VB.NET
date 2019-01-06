using DulceCorNeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DulceCor_final_
{
    public partial class InformePromocion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ViewState["GvDatosOrden"] = "golosina";

                gvDatosInfoProm.AllowPaging = true;
                gvDatosInfoProm.AllowSorting = true;
                gvDatosInfoProm.PageSize = 2;
               
                cargarComboBox();
                cargarGrilla();
            }
           

        }

        private void cargarComboBox()
        {
            cblPromociones.DataTextField = "descuento";
            cblPromociones.DataValueField = "idDescuento";
            cblPromociones.DataSource = GestorDescuento.ObtenerTodosDescuentos();
            cblPromociones.DataBind();
        }

        private void cargarGrilla()
        {
            string orden = ViewState["GvDatosOrden"].ToString();

            gvDatosInfoProm.DataSource = GestorPromociones.buscarInfoProm(orden);
            gvDatosInfoProm.DataBind();
            
        }

        protected void gvDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDatosInfoProm.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }
        protected void gvDatos_Sorting(object sender, GridViewSortEventArgs e)
        {
            ViewState["GvDatosOrden"] = e.SortExpression;
            cargarGrilla();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string s;
            string descuento;
            s = "(";
            for (int i = 0; i < cblPromociones.Items.Count; i++)
            {
                if (cblPromociones.Items[i].Selected)
                {
                    s = s +"'"+ cblPromociones.Items[i].Text+"'" + ",";
                }
            }
            
            DateTime fecha = DateTime.Today;
            descuento = s + "'0')";
            if (txtFechaMax.Text != "")
            { fecha = DateTime.Parse(txtFechaMax.Text); }
            
            string orden = ViewState["GvDatosOrden"].ToString();

            gvDatosInfoProm.DataSource = GestorPromociones.buscarInfoPromOpciones(txtNombreBuscar.Text, fecha, descuento, orden);
            gvDatosInfoProm.DataBind();
        }

       

    }
}