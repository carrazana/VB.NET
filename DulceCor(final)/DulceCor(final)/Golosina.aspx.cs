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
    public partial class GolosinaWf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("Administradores"))
            { btnAgregar.Visible = true; btnConsultar.Visible = true; btnEliminar.Visible = true; btnEditar.Visible = true; }
            else
            { btnAgregar.Visible = false; btnConsultar.Visible = false; btnEliminar.Visible = false; btnEditar.Visible = false; }

            lblAccion.Visible = false;
            lblMensaje.Visible = false;
            lblMensaje2.Visible = false;
            lblMensaje.Text = "";
            lblMensaje2.Text = "";
            if (!IsPostBack)
            {
                ddlTipoGolosina.DataTextField = "nombre";
                ddlTipoGolosina.DataValueField = "idTipoGolosina";
                ddlTipoGolosina.DataSource = GestorTipoGolosina.obtenerTodas();
                ddlTipoGolosina.DataBind();
                ddlTipoGolosina.Items.Insert(0, new ListItem("Elija un Tipo Golosina", "0"));


                ddlMarca.DataTextField = "nombre";
                ddlMarca.DataValueField = "idMarca";
                ddlMarca.DataSource = GestorMarca.obtenerTodas();
                ddlMarca.DataBind();
                ddlMarca.Items.Insert(0, new ListItem("Elija una marca", ""));


                ViewState["GvDatosOrden"] = "nombre";
                gvDatos.AllowPaging = true;
                gvDatos.AllowSorting = true;
                gvDatos.PageSize = 2;
                gvDatos.AutoGenerateColumns = false;
                cargar();
                lblMensaje2.Visible = false;
                //textheader(titulo)
                //datafield(propiedad del data source)
                //sortexpression
            }

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            lblAccion.Visible = true;
            lblAccion.Text = "Agregando...";
            pnlConsulta.Visible = false;
            pnlRegistro.Visible = true;
            btnGrabar.Text = "Agregar";
            btnCancelar.Visible = true;
            camposEnBlanco();
            desbloquear();
            FileUpload.Visible = true;
            Image.Visible = false;

        }
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (gvDatos.SelectedRow != null)
            {
                lblAccion.Visible = true;
                lblAccion.Text = "Consultando...";
                pnlConsulta.Visible = false;
                pnlRegistro.Visible = true;
                btnGrabar.Text = "Aceptar";
                btnCancelar.Visible = false;
                consultar();
                bloquear();

            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Seleccione una golosina";
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            if (gvDatos.SelectedRow != null)
            {
                lblAccion.Visible = true;
                lblAccion.Text = "Eliminando...";
                pnlConsulta.Visible = false;
                pnlRegistro.Visible = true;
                btnCancelar.Visible = true;
                btnGrabar.Text = "Borrar";
                consultar();
                bloquear();
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Seleccione una golosina";
            }
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (gvDatos.SelectedRow != null)
            {
                lblAccion.Visible = true;
                lblAccion.Text = "Editando...";
                pnlConsulta.Visible = false;
                pnlRegistro.Visible = true;
                btnGrabar.Text = "Actualizar";
                btnCancelar.Visible = true;
                consultar();
                desbloquear();


            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Seleccione una golosina";
            }

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            //if (!Page.IsValid)
            //  return;

            //pnlConsulta.Visible = true;
            //pnlRegistro.Visible = false;
            lblAccion.Visible = true;
            try
            {
                if (lblAccion.Text == "Agregando...")
                {
                    try
                    {
                        Golosina go = new Golosina();
                        if (GestorGolosina.existenciaCodigo(int.Parse(txtCodigo.Text)) == true)
                        {
                            lblMensaje2.Visible = true;
                            lblMensaje2.Text = "El codigo ya existe, debe ingresar otro";
                        }
                        else
                        {

                            //FileUpload.SaveAs(Server.MapPath("~/img/" + FileUpload.FileName + ".jpg"));
                            if (FileUpload.FileName != "")
                                FileUpload.SaveAs(Server.MapPath("~/img/" + FileUpload.FileName));

                            grabar(go);
                            cargar();
                            lblAccion.Text = "";
                            lblAccion.Visible = false;

                        }

                    }
                    catch (Exception ex)
                    {
                        lblMensaje2.Visible = true;
                        lblMensaje2.Text = ex.ToString(); }
                }
                if (lblAccion.Text == "Eliminando...")
                {
                    int idGolosina = int.Parse(txtIdGolosina.Text);
                    try
                    {
                        GestorGolosina.eliminarGolosina(idGolosina);
                        cargar();
                        lblAccion.Text = "";
                        lblAccion.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        lblMensaje2.Visible = true;
                        lblMensaje2.Text = ex.Message; }
                }
                if (lblAccion.Text == "Consultando...")
                {
                    cargar();
                    lblAccion.Text = "";
                    lblAccion.Visible = false;
                }
                if (lblAccion.Text == "Editando...")
                {
                    int idGolosina = int.Parse(txtIdGolosina.Text);
                    ;
                    try
                    {
                        Golosina go = new Golosina();
                        go.IdGolosina = idGolosina;
                        //grabar(go);
                        //cargar();
                        //
                        if (GestorGolosina.existenciaCodigo(int.Parse(txtCodigo.Text), idGolosina) == true)
                        {
                            lblMensaje2.Visible = true;
                            lblMensaje2.Text = "El codigo ya existe, debe ingresar otro";

                        }
                        else
                        {
                            //FileUpload.SaveAs(Server.MapPath("~/img/" + FileUpload.FileName + ".jpg"));
                            if (FileUpload.FileName != "")
                                FileUpload.SaveAs(Server.MapPath("~/img/" + FileUpload.FileName));

                            grabar(go);
                            cargar();
                            lblAccion.Text = "";
                            lblAccion.Visible = false;
                        }


                    }
                    catch (Exception ex)
                    {
                        lblMensaje2.Visible = true;
                        lblMensaje2.Text = ex.ToString(); }
                }



            }
            catch (Exception ex)
            {
                lblMensaje2.Text = ex.ToString();
            }

        }

        private void grabar(Golosina go)
        {

            go.Nombre = txtNombre.Text;
            go.Precio = decimal.Parse(txtPrecio.Text);
            if (txtCantidad.Text != "")
                go.CantidadPaquete = int.Parse(txtCantidad.Text);
            else
            { go.CantidadPaquete = null; }

            go.Descripcion = txtDescripcion.Text;
            go.TipoGolosinaId = int.Parse(ddlTipoGolosina.SelectedValue);
            //if(ddlMarca.SelectValue!=0)
            go.TipoMarcaId = int.Parse(ddlMarca.SelectedValue);
            //else  go.TipoMarca=null
            go.Disponibilidad = ckDisponibilidad.Checked;
            go.Codigo = int.Parse(txtCodigo.Text);

            if (FileUpload.Visible == true)
            {
                if (FileUpload.FileName != "")
                    go.Imagen = "img/" + FileUpload.FileName;
                else
                    go.Imagen = "img/vacio.jpg";
            }
            else
            {
                go.Imagen = Image.ImageUrl;
            }


            GestorGolosina.grabarGolosina(go);

        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblAccion.Text = "";
            pnlConsulta.Visible = true;
            pnlRegistro.Visible = false;
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string orden = ViewState["GvDatosOrden"].ToString();
            gvDatos.DataSource = GestorGolosina.buscarPorNombre(txtNombreBuscar.Text, orden);
            gvDatos.DataBind();
        }

        private void cargar()
        {
            string orden = ViewState["GvDatosOrden"].ToString();
            gvDatos.DataSource = GestorGolosina.buscarPorNombre(txtNombreBuscar.Text, orden);
            gvDatos.DataBind();
            pnlConsulta.Visible = true;
            pnlRegistro.Visible = false;
        }

        private void camposEnBlanco()
        {
            txtIdGolosina.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            ddlTipoGolosina.SelectedIndex = -1;
            ddlMarca.SelectedIndex = -1;
            ckDisponibilidad.Checked = false;
            txtCodigo.Text = "";

        }

        private void consultar()
        {

            int idGolosina = (int)gvDatos.SelectedValue;
            try
            {
                Golosina go = GestorGolosina.buscarPorID(idGolosina);
                txtIdGolosina.Text = go.IdGolosina.ToString();
                txtNombre.Text = go.Nombre;
                txtPrecio.Text = go.Precio.ToString();
                txtCantidad.Text = go.CantidadPaquete.ToString();
                txtDescripcion.Text = go.Descripcion;

                if (go.TipoGolosinaId != null)
                    ddlTipoGolosina.SelectedValue = go.TipoGolosinaId.ToString();
                else
                { ddlTipoGolosina.SelectedIndex = -1; }

                if (go.TipoMarcaId != null)
                    ddlMarca.SelectedValue = go.TipoMarcaId.ToString();
                else
                { ddlMarca.SelectedIndex = -1; }
                ckDisponibilidad.Checked = go.Disponibilidad;
                txtCodigo.Text = go.Codigo.ToString();

                if (go.Imagen == "img/vacio.jpg")
                {
                    FileUpload.Visible = true;
                    Image.Visible = false;
                }
                else
                {
                    FileUpload.Visible = false;
                    Image.Visible = true;
                }

                //Image.ImageUrl = "img/" + go.Imagen + ".jpg";
                Image.ImageUrl = go.Imagen;
            }
            catch (Exception ex)
            {
                lblAccion.Text = ex.Message;
            }
        }

        private void bloquear()
        {
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtCantidad.Enabled = false;
            txtDescripcion.Enabled = false;
            ddlTipoGolosina.Enabled = false;
            ddlMarca.Enabled = false;
            ckDisponibilidad.Enabled = false;
            txtCodigo.Enabled = false;
            FileUpload.Enabled = false;
        }

        private void desbloquear()
        {
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtCantidad.Enabled = true;
            txtDescripcion.Enabled = true;
            ddlTipoGolosina.Enabled = true;
            ddlMarca.Enabled = true;
            ckDisponibilidad.Enabled = true;
            txtCodigo.Enabled = true;
            FileUpload.Enabled = true;
        }

        protected void gvDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDatos.PageIndex = e.NewPageIndex;
            cargar();
        }
        protected void gvDatos_Sorting(object sender, GridViewSortEventArgs e)
        {
            ViewState["GvDatosOrden"] = e.SortExpression;
            cargar();
        }

        protected void valListaTipoGolosina_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "0")
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }

            //args.IsValid = args.Value == "0";
        }
    }
}