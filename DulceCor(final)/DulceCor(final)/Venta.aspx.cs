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
    public partial class Venta : System.Web.UI.Page
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
               
                rptGolosinas.DataSource = GestorVenta.ObtenerListaGolosinas(idTipoGolosina);
                rptGolosinas.DataBind();
 
            }
        }

        private void AgregarCompra(int idGolosina, int cantidad)
        {
            Golosina go = GestorGolosina.buscarPorID(idGolosina);
                            
            if (go != null)
            {
                ItemCarrito ic = new ItemCarrito()
                {
                    IdGolosina = go.IdGolosina,
                    Nombre = go.Nombre,
                    Descripcion = go.Descripcion,
                    Precio = go.Precio,
                    Cantidad = cantidad,
                };
                

                List<ItemCarrito> carrito = new List<ItemCarrito>();

                if (Session["Carrito"] != null)
                {
                    carrito = (List<ItemCarrito>)Session["Carrito"];
                }

                bool flag=false;

                foreach (var item in carrito)
	            {
		            if(ic.IdGolosina==item.IdGolosina)
                    {
                        flag=true;
                    }
	            }
                if(flag==true)
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
            if(Page.User.IsInRole("clientes"))
            {
                if (e.CommandName == "Comprar")
                {
                int idGolosina = Convert.ToInt32(e.CommandArgument);
                TextBox txtCantidad = (TextBox)e.Item.FindControl("txtCantidad");
                int cantidad=int.Parse(txtCantidad.Text);
                
                AgregarCompra(idGolosina, cantidad);

                }

                else if (e.CommandName == "ver")
                {
                int idGolosina = Convert.ToInt32(e.CommandArgument);
                //Response.Redirect(string.Format("DetalleA.aspx?idArticulo={0}", idGolosina));
                }
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Debe loguearse";
            }
            
        }
    }
}