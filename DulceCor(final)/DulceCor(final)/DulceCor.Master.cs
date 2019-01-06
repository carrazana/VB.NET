using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DulceCor_final_
{
    public partial class DulceCor : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lnkSuCompra.Visible = Page.User.IsInRole("clientes");
            lnkSuPromocion.Visible = Page.User.IsInRole("administradores");
            lnkMenuAbm.Visible = Page.User.IsInRole("administradores");
            lnkMenuInforme.Visible = Page.User.IsInRole("administradores");
            lnkMenuConsumidores.Visible =  Page.User.IsInRole("administradores");
            lnkMenuGolosinas.Visible =  Page.User.IsInRole("administradores");
            lnkNuevaPromocion.Visible = Page.User.IsInRole("administradores");
            lnkInformePromocion.Visible = Page.User.IsInRole("administradores");
            lnkInformeVenta.Visible = Page.User.IsInRole("administradores");
            //if (Page.User.Identity != null)
            //{
            //    string usuario = Page.User.Identity.Name;
            //    bool EsAdministrador = Page.User.IsInRole("administradores");
            //}
        }

    }
}