using DulceCorNeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DulceCor_final_
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (GestorUsuarios.VerificarUsuarioClave(Login1.UserName, Login1.Password) && GestorConsumidores.Habilitado(Login1.UserName)==true)
            {
                Session["Usuario"] = Login1.UserName;
                e.Authenticated = true;  // genera cookie de seguridad con datos del usuario (sin los roles) 
                Session["Carrito"] = null;
            }
            else
            {
                e.Authenticated = false;

            }
        }
    }
}