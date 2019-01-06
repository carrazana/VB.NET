using DulceCorEnt;
using DulceCorNeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DulceCor_final_
{
    public partial class Promociones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                rptTipoGolosina.DataSource = GestorTipoGolosina.ObtenerLista();
                rptTipoGolosina.DataBind();

                int idTipoGolosina = 0;
                if (Request.QueryString["idTipoGolosina"] != null)
                {
                    idTipoGolosina = Convert.ToInt32(Request.QueryString["idTipoGolosina"]);
                }
                
                rptGolosinas.DataSource = GestorPromociones.ObtenerListaPromociones(idTipoGolosina);
                rptGolosinas.DataBind();


            }
        }

        private void AgregarCompra(int idTipoProm, int cantidad)
        {
            TipoPromocion tp = GestorPromociones.ObtenerPrecioCantProm(idTipoProm);
            Golosina go = GestorGolosina.buscarPorID(tp.golosinaId);
            
            if (go != null)
            {
                ItemCarrito ic = new ItemCarrito()
                {
                    IdGolosina = go.IdGolosina,
                    Nombre = go.Nombre,
                    Descripcion = go.Descripcion,
                    Precio = (tp.precioProm/tp.cantidadPaquetes),
                    Cantidad = (cantidad*tp.cantidadPaquetes)
                };


                List<ItemCarrito> carrito = new List<ItemCarrito>();

                if (Session["Carrito"] != null)
                {
                    carrito = (List<ItemCarrito>)Session["Carrito"];
                }
                bool flag = false;

                foreach (var item in carrito)
                {
                    if (ic.IdGolosina == item.IdGolosina)
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "La Golosina con ID=" + ic.IdGolosina + " ya fue ingresada";
                }
                else
                {
                    carrito.Add(ic);
                    Session["Carrito"] = carrito;

                    Response.Redirect("SuCompra.aspx", false);
                }

               
            }
        }

        protected void rptGolosinas_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Comprar")
            {
                int idTipoProm = Convert.ToInt32(e.CommandArgument);
                TextBox txtCantidad = (TextBox)e.Item.FindControl("txtCantidad");
                int cantidad = int.Parse(txtCantidad.Text);

                AgregarCompra(idTipoProm, cantidad);

            }

            //else if (e.CommandName == "ver")
            //{
            //    int idGolosina = Convert.ToInt32(e.CommandArgument);
                //Response.Redirect(string.Format("DetalleA.aspx?idArticulo={0}", idGolosina));
            //}
        }
    
    }
}