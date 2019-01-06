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
    public partial class Consumidores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("Administradores"))
            { btnAgregar.Visible = true; btnConsultar.Visible = true; btnEliminar.Visible = true; }

            else
            { btnAgregar.Visible = false; btnConsultar.Visible = false; btnEliminar.Visible = false; }

            lblMensaje.Visible = false;

            if(!Page.IsPostBack)
            {
                ViewState["GvDatosOrden"] = "nombre";

                gvDatos.AutoGenerateColumns = false;
                gvDatos.AllowPaging = true;
                gvDatos.PageSize =4;
                gvDatos.AllowSorting = true;

                cargarGrilla();

                ddlBarrio.DataTextField = "nombre";
                ddlBarrio.DataValueField = "idBarrio";
                ddlBarrio.DataSource = GestorBarrios.ObtenerTodosBarrios();
                ddlBarrio.DataBind();
                ddlBarrio.Items.Insert(0, new ListItem("Elija un barrio", "0"));
            }
                
        }

        private void cargarGrilla()
        {
            string orden = ViewState["GvDatosOrden"].ToString();
            gvDatos.DataSource = GestorConsumidores.buscarTodos(orden);          
            gvDatos.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            pnConsulta.Visible = false;
            pnRegistro.Visible = true;

            btnBorrar.Visible = false;
            btnModificar.Visible = false;
            btnGrabar.Visible = true;
            
            lblAccion.Text = "Agregando";
            lblAccion.Visible = true;                    
            txtIdConsumidor.Enabled = false;
            
            limpiar();

            Habilitar();
        }

        private void Habilitar()
        {
            txtIdConsumidor.Text = "0";
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtFechaNac.Enabled = true;
            txtDireccion.Enabled = true;
            ddlBarrio.Enabled = true;
            txtEmail.Enabled = true;
            txtNumDoc.Enabled = true;
            txtPuntaje.Enabled = true;
            txtRazonSocial.Enabled = true;
            txtTelefono.Enabled = true;
            txtCuit.Enabled = true;
            chbHabilitado.Enabled = true;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (gvDatos.SelectedValue != null)
            {
                pnConsulta.Visible = false;
                pnRegistro.Visible = true;
                
                btnBorrar.Visible = false;
                btnGrabar.Visible = false;
                btnModificar.Visible = true;

                Deshabilitar();
                lblAccion.Visible = true;  
                lblAccion.Text = "Consultando";
                
                int idConsumidor = (int)gvDatos.SelectedValue;
                
                DatosConsumidor(idConsumidor);
                
                        
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Enabled = true;
                lblMensaje.Text = "Seleccione un consumidor";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvDatos.SelectedValue != null)
            {
                pnConsulta.Visible = false;
                pnRegistro.Visible = true;
                lblAccion.Visible = true;  
                lblAccion.Text = "Eliminando";
               
                btnBorrar.Visible = true;
                btnGrabar.Visible = false;
                btnModificar.Visible = false;

                Deshabilitar();

                int idConsumidor = (int)gvDatos.SelectedValue;

                DatosConsumidor(idConsumidor);
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Enabled = true;
                lblMensaje.Text = "Seleccione un consumidor";
            }
        }

        private void DatosConsumidor(int idConsumidor)
        {
            Consumidor con = GestorConsumidores.buscarPorId(idConsumidor);

            txtIdConsumidor.Text = con.idConsumidor.ToString();
            txtNombre.Text = con.nombre;
            txtTelefono.Text = con.telefono.ToString();
            txtApellido.Text = con.apellido;

            if (con.fechaNac!= null)
            { DateTime fecha = con.fechaNac.Value;

                txtFechaNac.Text = fecha.ToShortDateString();
            }

        
            
            txtNumDoc.Text = con.numeroDoc.ToString();

            if (con.barrioId != null)
            { ddlBarrio.SelectedValue = con.barrioId.ToString(); }
            else
            { ddlBarrio.SelectedValue = "0"; }

            txtDireccion.Text = con.direccion;
            txtEmail.Text = con.correo;
            txtRazonSocial.Text = con.razonSocial;
            txtCuit.Text = con.cuit;
            txtPuntaje.Text = con.puntaje.ToString();

            if (con.habilitado != null)
            { chbHabilitado.Checked = con.habilitado.Value; }
            else
            { chbHabilitado.Checked = false; }
            ViewState["telefono"]=txtTelefono.Text;
            ViewState["dni"] = txtNumDoc.Text;
        }

        private void Deshabilitar()
        {
            txtIdConsumidor.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtFechaNac.Enabled = false;
            txtDireccion.Enabled = false;
            ddlBarrio.Enabled = false;
            txtEmail.Enabled = false;
            txtNumDoc.Enabled = false;
            txtPuntaje.Enabled = false;
            txtRazonSocial.Enabled = false;
            txtTelefono.Enabled = false;
            txtCuit.Enabled = false;
            chbHabilitado.Enabled = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblUnico.Visible =false;          
            pnConsulta.Visible = true;
            pnRegistro.Visible = false;
            lblAccion.Visible = false;  
            lblAccion.Text = "";
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try { 
            lblUnico.Visible = false;


            Consumidor con = GestorConsumidores.buscarExistenciaTel(long.Parse(txtTelefono.Text));
            Consumidor cons = GestorConsumidores.buscarExistenciaDni(long.Parse(txtNumDoc.Text));
            
            int idCon = int.Parse(txtIdConsumidor.Text);
            long dni =0 ;
            long tel =0 ;

            if (cons != null)
            { dni = cons.numeroDoc;}
            if(con!=null)
            {tel=con.telefono;}
            if (idCon == 0)
            {

                if (tel == long.Parse(txtTelefono.Text) || dni == long.Parse(txtNumDoc.Text))
                {

                    lblUnico.Visible = true;
                    lblUnico.Text = string.Format("Numero de telefono y/o DNI ya existen: {0} , {1}", tel, dni);
                }
                else
                {
                    Grabar();
                }
            }
            else
            {

                long numDoc = long.Parse(ViewState["dni"].ToString());             //guardo en la consulta
                long telef = long.Parse(ViewState["telefono"].ToString());
                if (long.Parse(txtTelefono.Text) == telef) //verifica si se cambio lo que estaba en la consulta y lo de ahora
                {
                    if (long.Parse(txtNumDoc.Text) == numDoc)
                    {
                        Grabar();
                    }
                    else
                    {
                        if (dni == long.Parse(txtNumDoc.Text))
                        {
                            lblUnico.Visible = true;
                            lblUnico.Text = string.Format("Numero de DNI ya existe: {0} ", dni);

                        }

                        else
                        {
                            Grabar();
                        }
                    }
                }
                else
                {
                    if (tel == long.Parse(txtTelefono.Text))
                    {
                        lblUnico.Visible = true;
                        lblUnico.Text = string.Format("Numero de telefono ya existen: {0} ", tel);
                    }
                    else
                    {
                        if (dni == long.Parse(txtNumDoc.Text))
                        {
                            lblUnico.Visible = true;
                            lblUnico.Text = string.Format("Numero de DNI ya existe: {0} ", dni);
                        }

                        else
                        {
                            Grabar();
                        }
                    }
                }

            }
               
            
       }
            catch (Exception ex) 
            { lblUnico.Text = ex.Message; }
     }

        private void Grabar()
        {
            pnConsulta.Visible = true;
            pnRegistro.Visible = false;

            lblAccion.Visible = false;
            lblAccion.Text = "";

            Consumidor c = new Consumidor();

            c.idConsumidor = int.Parse(txtIdConsumidor.Text);

            c.nombre = txtNombre.Text;

            c.apellido = txtApellido.Text;

            if (txtFechaNac.Text != "")
            { c.fechaNac = DateTime.Parse(txtFechaNac.Text); }
            else
            { c.fechaNac = DateTime.Parse("01/01/1900"); }

            c.numeroDoc = long.Parse(txtNumDoc.Text);

            if (int.Parse(ddlBarrio.SelectedValue)!=0)
            {c.barrioId = int.Parse(ddlBarrio.SelectedValue);}
            else
            { c.barrioId = 4; }
            
            c.direccion = txtDireccion.Text;

            c.correo = txtEmail.Text;

            c.razonSocial = txtRazonSocial.Text;

            c.cuit = txtCuit.Text;
          
            c.habilitado = chbHabilitado.Checked;

            if (txtPuntaje.Text != "")
            { c.puntaje = float.Parse(txtPuntaje.Text); }
            else
            { c.puntaje = 0; }

            c.telefono = long.Parse(txtTelefono.Text); //validar

            try
            {
                GestorConsumidores.Agregar(c);
                cargarGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtIdConsumidor.Text = "";
            txtNumDoc.Text = "";
            txtTelefono.Text = "";
            txtPuntaje.Text = "";
            txtEmail.Text = "";
            txtFechaNac.Text = "";
            txtDireccion.Text = "";
            txtCuit.Text = "";
            txtRazonSocial.Text = "";
            chbHabilitado.Checked = false;
            ddlBarrio.SelectedValue = "0";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            gvDatos.DataSource = GestorConsumidores.buscarPorNombre(txtNombreBuscar.Text);
            gvDatos.DataBind();
        }

        protected void gvDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idConsumidor = (int)gvDatos.SelectedValue;
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int idComprador = (int)gvDatos.SelectedValue;
            GestorConsumidores.Eliminar(idComprador);
            cargarGrilla();
            pnRegistro.Visible = false;
            pnConsulta.Visible = true;
        }

        protected void gvDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDatos.PageIndex = e.NewPageIndex;
            cargarGrilla();
        }

        protected void gvDatos_Sorting(object sender, GridViewSortEventArgs e)
        {
            ViewState["GvDatosOrden"] = e.SortExpression;
            cargarGrilla();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            btnGrabar.Visible = true;
            btnModificar.Visible = false;
           
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtFechaNac.Enabled = true;
            txtDireccion.Enabled = true;
            ddlBarrio.Enabled = true;
            txtEmail.Enabled = true;
            txtNumDoc.Enabled = true;
            txtPuntaje.Enabled = true;
            txtRazonSocial.Enabled = true;
            txtTelefono.Enabled = true;
            txtCuit.Enabled = true;
            chbHabilitado.Enabled = true;
        }

    

    }
}