Public Class frmRegistrarEmpleado
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

    Private Sub frmRegistrarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblHora.Text = DateTime.Now.ToShortTimeString()
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Me.cmdAceptar.Visible = False
        Me.cmdCancelar.Visible = False
        Me.cmdBuscar.Enabled = False
        Me.grpPaciente.Visible = False
        Me.grpBuscador.Visible = True

        dgvEmpleado.DataSource = BDHelper.GetEmpleados()

        Me.txtBuscador.Focus()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Dim añoMenor As Integer
        añoMenor = DateTime.Now.Year - 110

        Try


            CargarCombo(cboTipoDocumento, BDHelper.GetTipoDocumentos(), "id", "descripcion")
            CargarCombo(cboLocalidad, BDHelper.getLocalidades(), "id", "descripcion")
            CargarCombo(cboBuscador, BDHelper.getBuscador(), "id", "descripcion")
            CargarCombo(cboCargo, BDHelper.getCargos(), "id", "descripcion")
            CargarCombo(cboEspecialidad, BDHelper.getEspecializaciones, "id", "descripcion")


            Me.dtpFechaNac.MaxDate = Date.Now
            Me.dtpFechaNac.MinDate = añoMenor & "-01-01"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Function validar() As Boolean
        If Me.txtNombre.Text = "" Then
            MsgBox("El nombre no puede estar vacio", MsgBoxStyle.Critical, "importante")
            Me.txtNombre.Focus()
            Return False
        End If
        If Me.txtApellido.Text = "" Then
            MsgBox("EL apellido no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.txtApellido.Focus()
            Return False
        End If

        If Me.cboTipoDocumento.SelectedIndex = -1 Then
            MsgBox("No se selecciono el tipo de documento")
            Me.cboTipoDocumento.Focus()
            Return False

        End If
        If Me.txtNroDocumento.Text = "" Then
            MsgBox("El documento no puede estar vacio")
            Me.txtNroDocumento.Focus()
            Return False
        End If
        If Me.txtNroDocumento.Text < 1000000 Or Me.txtNroDocumento.Text > 100000000 Then
            MsgBox("El documento no es correcto, no esta en el rango 1.000.000-100.000.000")
            Me.txtNroDocumento.Focus()
            Return False
        End If
        If Me.cboEspecialidad.SelectedIndex = -1 Then
            MsgBox("No se selecciono la especialidad")
            Me.cboEspecialidad.Focus()
            Return False
        End If
        If Me.cboCargo.SelectedIndex = -1 Then
            MsgBox("No se selecciono el cargo")
            Me.cboEspecialidad.Focus()
            Return False
        End If
        If Me.txtHoraIngreso.MaskFull = False Then
            MsgBox("La hora ingreso no puede estar vacia, cargue los 4 digitos")
            Me.txtHoraIngreso.Focus()
            Return False
        End If
        If Me.txtHoraSalida.MaskFull = False Then
            MsgBox("La hora salida no puede estar vacia, cargue los 4 digitos")
            Me.txtHoraSalida.Focus()
            Return False
        End If
        If Me.txtCalle.Text = "" Then
            MsgBox("La calle no puede estar vacia")
            Me.txtCalle.Focus()
            Return False
        End If
        If Me.txtNumero.Text = "" Then
            MsgBox("El numero de domicilio no puede estar vacio")
            Me.txtNumero.Focus()
            Return False
        End If
        If Me.cboLocalidad.SelectedIndex = -1 Then
            MsgBox("No se selecciono la localidad")
            Me.cboLocalidad.Focus()
            Return False
        End If

        Return True
    End Function

  

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress, txtNombre.KeyPress, txtDepartamento.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 9, 15, 14
            Case 13

                Exit Sub
        End Select

        If IsNumeric(e.KeyChar) = True Then
            e.KeyChar = ""
        End If
    End Sub


    Private Sub txtFechaNacimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHoraIngreso.KeyPress, txtHoraSalida.KeyPress, txtNumero.KeyPress, txtTelefono.KeyPress, txtCelular.KeyPress, txtPiso.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim valor As Integer = 0

        Me.grpBuscador.Visible = False
        Me.grpPaciente.Visible = True
        Me.cmdAceptar.Visible = True
        Me.cmdCancelar.Visible = True
        Me.cmdNuevo.Visible = False
        Me.cmdBorrar.Visible = False
        Me.cmdModificar.Visible = False
        Me.cmdSalir.Visible = False
        Me.limpiar()

        Me.accion = estado.insertar

        valor = BDHelper.getCodigoEmpleado.Rows(0)("ultimo")
        Me.lblCodigo.Text = valor

    End Sub

    Private Sub limpiar()
        Me.txtApellido.Clear()
        Me.txtCalle.Clear()
        Me.txtDepartamento.Clear()
        Me.dtpFechaNac.Text = Date.Now.ToShortDateString
        Me.txtHoraIngreso.Clear()
        Me.txtHoraSalida.Clear()
        Me.txtNombre.Clear()
        Me.txtNroDocumento.Clear()
        Me.txtNumero.Clear()
        Me.txtPiso.Clear()
        Me.cboCargo.SelectedIndex = -1
        Me.cboTipoDocumento.SelectedIndex = -1
        Me.cboLocalidad.SelectedIndex = -1
        Me.cboEspecialidad.SelectedIndex = -1

        Me.txtNombre.Focus()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Try
            Dim cod As Integer = Me.dgvEmpleado.CurrentRow.Cells(0).Value
            Dim valor As Integer = 0

            limpiar()
            BDHelper.cargarEmpleado(cod)

            Me.lblCodigo.Text = BDHelper.cargarEmpleado(cod).Rows(0)("codigoEmpleado")
            Me.txtNombre.Text = BDHelper.cargarEmpleado(cod).Rows(0)("nombre")
            Me.txtApellido.Text = BDHelper.cargarEmpleado(cod).Rows(0)("apellido")
            Me.cboTipoDocumento.SelectedValue = BDHelper.cargarEmpleado(cod).Rows(0)("idTipoDoc")
            Me.txtNroDocumento.Text = BDHelper.cargarEmpleado(cod).Rows(0)("documento")
            Me.dtpFechaNac.Text = BDHelper.cargarEmpleado(cod).Rows(0)("fechaNac")
            Me.txtCalle.Text = BDHelper.cargarEmpleado(cod).Rows(0)("calle")
            Me.txtNumero.Text = BDHelper.cargarEmpleado(cod).Rows(0)("numero")
            Me.txtPiso.Text = BDHelper.cargarEmpleado(cod).Rows(0)("piso")
            Me.txtDepartamento.Text = BDHelper.cargarEmpleado(cod).Rows(0)("depto")
            Me.cboLocalidad.SelectedValue = BDHelper.cargarEmpleado(cod).Rows(0)("idLocalidad")
            Me.txtTelefono.Text = BDHelper.cargarEmpleado(cod).Rows(0)("telefono")
            Me.txtCelular.Text = BDHelper.cargarEmpleado(cod).Rows(0)("celular")
            Me.txtHoraIngreso.Text = BDHelper.cargarEmpleado(cod).Rows(0)("Hora Ingreso")
            Me.txtHoraSalida.Text = BDHelper.cargarEmpleado(cod).Rows(0)("Hora Salida")
            Me.cboCargo.SelectedValue = BDHelper.cargarEmpleado(cod).Rows(0)("Cargo")
            Me.cboEspecialidad.SelectedValue = BDHelper.cargarEmpleado(cod).Rows(0)("Especializacion")

            Me.accion = estado.modificar


            Me.grpBuscador.Visible = False
            Me.grpPaciente.Visible = True
            Me.cmdAceptar.Visible = True
            Me.cmdCancelar.Visible = True
            Me.cmdNuevo.Visible = False
            Me.cmdBorrar.Visible = False
            Me.cmdModificar.Visible = False
            Me.cmdSalir.Visible = False
        Catch ex As Exception
            MessageBox.Show("No se selecciono un empleado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        

    End Sub

    Private Sub cmdCancelar_Click_1(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.grpBuscador.Visible = True
        Me.grpPaciente.Visible = False
        Me.cmdAceptar.Visible = False
        Me.cmdCancelar.Visible = False
        Me.cmdNuevo.Visible = True
        Me.cmdBorrar.Visible = True
        Me.cmdModificar.Visible = True
        Me.cmdSalir.Visible = True
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        dgvEmpleado.DataSource = BDHelper.BuscarEmpleados(Me.cboBuscador.Text, Me.txtBuscador.Text)

    End Sub

    Private Sub txtBuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscador.KeyPress
        Me.cmdBuscar.Enabled = True

        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 9, 15, 14
            Case 13
                Me.cmdBuscar_Click(sender, e)
                Exit Sub
        End Select
        If cboBuscador.Text = "DOCUMENTO" Then
            If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
                e.KeyChar = ""
                e.Handled = True
                txtBuscador.Focus()
            End If

        End If

        If cboBuscador.Text = "NOMBRE" Or cboBuscador.Text = "APELLIDO" Then
            If IsNumeric(e.KeyChar) = True Then
                e.KeyChar = ""
            End If

        End If
    End Sub

    Private Sub cmdAceptar_Click_1(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        If Me.validar() = True Then
            If Me.accion = estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Se grabó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ya está cargada una persona con ese codigo", "Importante", _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                Me.modificar()
                MessageBox.Show("Se modifico exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            dgvEmpleado.DataSource = BDHelper.GetEmpleados()
            Me.grpBuscador.Visible = True
            Me.grpPaciente.Visible = False
            Me.cmdAceptar.Visible = False
            Me.cmdCancelar.Visible = False
            Me.cmdNuevo.Visible = True
            Me.cmdBorrar.Visible = True
            Me.cmdModificar.Visible = True
            Me.cmdSalir.Visible = True
        End If
    End Sub

    Private Function validar_existencia() As termino
        
        If BDHelper.existenciaEmpleado(Me.lblCodigo.Text).Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        Try
            Dim cod As Integer = Me.dgvEmpleado.CurrentRow.Cells(0).Value
            If (MessageBox.Show("Está seguro que desea borrar ese registro", "Atención",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK) Then

            End If
            Dim tablaEmp As Data.DataTable
            tablaEmp = BDHelper.borrarEmpleadoXturno(cod)
            If (tablaEmp.Rows.Count > 0) Then
                MsgBox("Este empleado tiene turnos relacionados")
            Else
                BDHelper.borrarEmpleadoXhorario(cod)
                BDHelper.borrarEmpleadoXcargo(cod)
                BDHelper.borrarEmpleadoXespecializacion(cod)
                BDHelper.borrarEmpleado(cod)
                dgvEmpleado.DataSource = BDHelper.GetEmpleados()
            End If

        Catch ex As Exception
            MessageBox.Show("No se selecciono un empleado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
       
        
    End Sub

    Private Function modificar() As termino

        BDHelper.modificarEmpleado(lblCodigo.Text, txtNombre.Text, txtApellido.Text, cboTipoDocumento.SelectedValue, txtNroDocumento.Text, dtpFechaNac.Text, txtCalle.Text, txtNumero.Text, txtPiso.Text, txtDepartamento.Text, cboLocalidad.SelectedValue, txtTelefono.Text, txtCelular.Text)
        BDHelper.modificarEmpleadoXhorario(lblCodigo.Text, txtHoraIngreso.Text, txtHoraSalida.Text)
        BDHelper.modificarEmpleadoXcargos(lblCodigo.Text, cboCargo.SelectedValue)
        BDHelper.modificarEmpleadoXespecializacion(lblCodigo.Text, cboEspecialidad.SelectedValue)

        Return termino.aprobado
    End Function

    Private Function insertar() As termino

        BDHelper.guardarEmpleado(lblCodigo.Text, txtNombre.Text, txtApellido.Text, cboTipoDocumento.SelectedValue, txtNroDocumento.Text, dtpFechaNac.Text, txtCalle.Text, txtNumero.Text, txtPiso.Text, txtDepartamento.Text, cboLocalidad.SelectedValue, txtTelefono.Text, txtCelular.Text)
        BDHelper.guardarEmpleadoXhorario(lblCodigo.Text, txtHoraIngreso.Text, txtHoraSalida.Text)
        BDHelper.guardarEmpleadoXcargos(lblCodigo.Text, cboCargo.SelectedValue)
        BDHelper.guardarEmpleadoXespecializacion(lblCodigo.Text, cboEspecialidad.SelectedValue)
   

        Return termino.aprobado
    End Function

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        dgvEmpleado.DataSource = BDHelper.GetEmpleados()
    End Sub


    Private Sub dgvEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles dgvEmpleado.DoubleClick
        Try
            Dim cod As Integer = Me.dgvEmpleado.CurrentRow.Cells(0).Value
            Dim valor As Integer = 0

            limpiar()
            BDHelper.cargarEmpleado(cod)

            Me.lblCodigo.Text = BDHelper.cargarEmpleado(cod).Rows(0)("codigoEmpleado")
            Me.txtNombre.Text = BDHelper.cargarEmpleado(cod).Rows(0)("nombre")
            Me.txtApellido.Text = BDHelper.cargarEmpleado(cod).Rows(0)("apellido")
            Me.cboTipoDocumento.SelectedValue = BDHelper.cargarEmpleado(cod).Rows(0)("idTipoDoc")
            Me.txtNroDocumento.Text = BDHelper.cargarEmpleado(cod).Rows(0)("documento")
            Me.dtpFechaNac.Text = BDHelper.cargarEmpleado(cod).Rows(0)("fechaNac")
            Me.txtCalle.Text = BDHelper.cargarEmpleado(cod).Rows(0)("calle")
            Me.txtNumero.Text = BDHelper.cargarEmpleado(cod).Rows(0)("numero")
            Me.txtPiso.Text = BDHelper.cargarEmpleado(cod).Rows(0)("piso")
            Me.txtDepartamento.Text = BDHelper.cargarEmpleado(cod).Rows(0)("depto")
            Me.cboLocalidad.SelectedValue = BDHelper.cargarEmpleado(cod).Rows(0)("idLocalidad")
            Me.txtTelefono.Text = BDHelper.cargarEmpleado(cod).Rows(0)("telefono")
            Me.txtCelular.Text = BDHelper.cargarEmpleado(cod).Rows(0)("celular")
            Me.txtHoraIngreso.Text = BDHelper.cargarEmpleado(cod).Rows(0)("Hora Ingreso")
            Me.txtHoraSalida.Text = BDHelper.cargarEmpleado(cod).Rows(0)("Hora Salida")
            Me.cboCargo.SelectedValue = BDHelper.cargarEmpleado(cod).Rows(0)("Cargo")
            Me.cboEspecialidad.SelectedValue = BDHelper.cargarEmpleado(cod).Rows(0)("Especializacion")

            Me.accion = estado.modificar


            Me.grpBuscador.Visible = False
            Me.grpPaciente.Visible = True
            Me.cmdAceptar.Visible = True
            Me.cmdCancelar.Visible = True
            Me.cmdNuevo.Visible = False
            Me.cmdBorrar.Visible = False
            Me.cmdModificar.Visible = False
            Me.cmdSalir.Visible = False
        Catch ex As Exception
            MessageBox.Show("No se selecciono un empleado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class