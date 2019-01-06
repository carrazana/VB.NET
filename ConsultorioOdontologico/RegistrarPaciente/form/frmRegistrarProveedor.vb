Public Class frmRegistrarProveedor
    Enum validacion
        positiva
        negativa
    End Enum

    Enum termino
        aprobado
        rechazado
    End Enum

    Enum estado
        insertar
        modificar
    End Enum
    Dim accion As estado = estado.insertar
    Dim cadena_conexion As String

    Private Sub frmRegistrarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblHora.Text = DateTime.Now.ToShortTimeString()
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        carga_combo(Me.cboLocalidad, BDHelper.leo_tabla("localidades"), "id", "descripcion")

        Me.grp_Proveedor.Visible = False
        Me.grp_Inicio.Visible = True
        actualizar()

        Me.cmdNuevo.Enabled = True
        Me.cmdModificar.Enabled = True
        Me.cmdEliminar.Enabled = True

    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String,
                            ByVal descripcion As String)

        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

    Private Function validar() As Boolean
        If Me.txtNombre.Text = "" Then
            MsgBox("El nombre no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.txtResponsable.Focus()
            Return False
        End If
        If Me.txtResponsable.Text = "" Then
            MsgBox("El nombre del responsable no puede estar vacio", MsgBoxStyle.Critical, "importante")
            Me.txtResponsable.Focus()
            Return False
        End If

        If Me.txtCalle.Text = "" Then
            MsgBox("La calle no puede estar vacia")
            txtCalle.Focus()
            Return False
        End If
        If Me.txtNumero.Text = "" Then
            MsgBox("El numero de la calle no puede estar vacio")
            txtNumero.Focus()
            Return False
        End If

        If Me.cboLocalidad.SelectedIndex = -1 Then
            MsgBox("No se selecciono la localidad")
            Me.cboLocalidad.Focus()
            Return False
        End If

        Return True
    End Function


    Private Sub cmdPuerta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPuerta.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim valor As Integer = 0
        borrarCampos()
        Me.grp_Proveedor.Visible = True
        Me.grp_Inicio.Visible = False

        Me.cmdModificar.Enabled = False
        Me.cmdEliminar.Enabled = False
        Me.txtNombre.Focus()
        valor = BDHelper.getCodigoProveedor.Rows(0)("ultimo")
        Me.lblID.Text = valor

        Me.accion = estado.insertar

    End Sub


    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        Dim var As String
        Select Case Me.cmb_Buscador.SelectedIndex
            Case 0
                var = "nombre"
                If Me.txtBuscar.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txtBuscar.Focus()
                Else
                    Me.dgv_proveedores.DataSource = BDHelper.buscarProveedores(var, Me.txtBuscar.Text)

                End If
            Case 1
                var = "nombre_responsable"
                If Me.txtBuscar.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txtBuscar.Focus()
                Else
                    Me.dgv_proveedores.DataSource = BDHelper.buscarProveedores(var, Me.txtBuscar.Text)

                End If
        End Select

    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim cod As Integer = Me.dgv_proveedores.CurrentRow.Cells(0).Value

            If (MessageBox.Show("Está seguro que desea borrar ese registro", "Atención",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK) Then

                Dim tablaEmp As Data.DataTable
                tablaEmp = BDHelper.borrarProveedorXCompra(cod)
                If (tablaEmp.Rows.Count > 0) Then
                    MsgBox("Este proveedor tiene compras relacionadas")
                Else

                    BDHelper.borrarProveedor(cod)
                    actualizar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("No se selecciono un proveedor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

     

    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Dim tabla As New DataTable

        If validar() = True Then
            If Me.accion = estado.insertar Then
                If validarExistencia() = termino.aprobado Then

                    guardarProveedor(lblID.Text, txtNombre.Text, txtResponsable.Text, txtTelefono.Text, txtMail.Text, txtCalle.Text, txtNumero.Text, txtDepartamento.Text, txtPiso.Text, cboLocalidad.SelectedValue)
                    MessageBox.Show("Se grabó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    actualizar()
                    Me.grp_Proveedor.Visible = False
                    Me.grp_Inicio.Visible = True

                    Me.cmdModificar.Enabled = True
                    Me.cmdEliminar.Enabled = True

                Else
                    MessageBox.Show("Existe actualmente una proveedor con el mismo codigo", "Importante", _
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtNombre.Focus()

                End If
            Else
                If Me.accion = estado.modificar Then

                    BDHelper.modificarProveedores(lblID.Text, txtNombre.Text, txtResponsable.Text, txtTelefono.Text, txtMail.Text, txtCalle.Text, txtNumero.Text, txtDepartamento.Text, txtPiso.Text, cboLocalidad.SelectedValue)

                    MessageBox.Show("Se modifico exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    actualizar()
                    Me.grp_Proveedor.Visible = False
                    Me.grp_Inicio.Visible = True

                    Me.cmdModificar.Enabled = True
                    Me.cmdEliminar.Enabled = True
                End If

            End If
        End If

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        borrarCampos()
        Me.grp_Proveedor.Visible = False
        Me.grp_Inicio.Visible = True

        Me.cmdModificar.Enabled = True
        Me.cmdEliminar.Enabled = True

    End Sub


    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click

        Try
            Dim cod As Integer = Me.dgv_proveedores.CurrentRow.Cells(0).Value
            Dim valor As Integer = 0
            BDHelper.cargarProveedor(cod)

            Me.lblID.Text = BDHelper.cargarProveedor(cod).Rows(0)("idProveedores")
            Me.txtNombre.Text = BDHelper.cargarProveedor(cod).Rows(0)("nombre")
            Me.txtResponsable.Text = BDHelper.cargarProveedor(cod).Rows(0)("nombre_responsable")
            Me.txtTelefono.Text = BDHelper.cargarProveedor(cod).Rows(0)("telefono")
            Me.txtMail.Text = BDHelper.cargarProveedor(cod).Rows(0)("mail")
            Me.txtCalle.Text = BDHelper.cargarProveedor(cod).Rows(0)("calle")
            Me.txtNumero.Text = BDHelper.cargarProveedor(cod).Rows(0)("numero")
            Me.txtDepartamento.Text = BDHelper.cargarProveedor(cod).Rows(0)("piso")
            Me.txtPiso.Text = BDHelper.cargarProveedor(cod).Rows(0)("departamento")
            Me.cboLocalidad.SelectedValue = BDHelper.cargarProveedor(cod).Rows(0)("idLocalidad")

            Me.accion = estado.modificar

            Me.grp_Proveedor.Visible = True
            Me.grp_Inicio.Visible = False

            Me.cmdModificar.Enabled = False
            Me.cmdEliminar.Enabled = False
            Me.txtNombre.Focus()
        Catch ex As Exception
            MessageBox.Show("No se selecciono un proveedor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
      



    End Sub

    Private Function validarExistencia() As Boolean

        If BDHelper.existenciaProveedor(Me.lblID.Text).Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If

    End Function


    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click

        actualizar()

    End Sub

    Private Sub actualizar()

        dgv_proveedores.datasource = BDHelper.getProveedores

    End Sub

    Private Sub borrarCampos()
        Me.txtNombre.Clear()
        Me.txtResponsable.Clear()
        Me.txtTelefono.Clear()
        Me.txtMail.Clear()
        Me.txtCalle.Clear()
        Me.txtNumero.Clear()
        Me.txtDepartamento.Clear()
        Me.txtPiso.Clear()
        Me.cboLocalidad.SelectedValue = -1

    End Sub

    Private Sub txtResponsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 9, 15, 14
            Case 13

                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = True Then

            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress, txtTelefono.KeyPress, txtPiso.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.KeyChar = ""
            e.Handled = True
            txtNumero.Focus()
        End If
    End Sub

    Private Sub dgv_proveedores_DoubleClick(sender As Object, e As EventArgs) Handles dgv_proveedores.DoubleClick

        Try
            Dim cod As Integer = Me.dgv_proveedores.CurrentRow.Cells(0).Value
            Dim valor As Integer = 0
            BDHelper.cargarProveedor(cod)

            Me.lblID.Text = BDHelper.cargarProveedor(cod).Rows(0)("idProveedores")
            Me.txtNombre.Text = BDHelper.cargarProveedor(cod).Rows(0)("nombre")
            Me.txtResponsable.Text = BDHelper.cargarProveedor(cod).Rows(0)("nombre_responsable")
            Me.txtTelefono.Text = BDHelper.cargarProveedor(cod).Rows(0)("telefono")
            Me.txtMail.Text = BDHelper.cargarProveedor(cod).Rows(0)("mail")
            Me.txtCalle.Text = BDHelper.cargarProveedor(cod).Rows(0)("calle")
            Me.txtNumero.Text = BDHelper.cargarProveedor(cod).Rows(0)("numero")
            Me.txtDepartamento.Text = BDHelper.cargarProveedor(cod).Rows(0)("piso")
            Me.txtPiso.Text = BDHelper.cargarProveedor(cod).Rows(0)("departamento")
            Me.cboLocalidad.SelectedValue = BDHelper.cargarProveedor(cod).Rows(0)("idLocalidad")

            Me.accion = estado.modificar

            Me.grp_Proveedor.Visible = True
            Me.grp_Inicio.Visible = False

            Me.cmdModificar.Enabled = False
            Me.cmdEliminar.Enabled = False
            Me.txtNombre.Focus()
        Catch ex As Exception
            MessageBox.Show("No se selecciono un proveedor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub
End Class
