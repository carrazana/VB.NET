Public Class frmRegistrarPaciente
    Enum validacion
        positiva
        negativa
    End Enum

    Enum termino
        aprovado
        rechazado
    End Enum

    Enum estado
        insertar
        modificar
    End Enum
    Dim accion As estado = estado.insertar
    Dim cadena_conexion As String

    Private Sub frmRegistrarPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim añoMenor As Integer
        añoMenor = DateTime.Now.Year - 110

        Me.lblHora.Text = DateTime.Now.ToShortTimeString()
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Me.txtFechaNacimiento.MaxDate = Date.Now
        Me.txtFechaNacimiento.MinDate = añoMenor & "-01-01"

        'nico
        'Me.cadena_conexion = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CONSULTORIO_ODONTOLOGICO;Data Source=NICO-PC\SQLEXPRESS"
        'pablo
        'Me.cadena_conexion = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CONSULTORIO_ODONTOLOGICO;Data Source=CARRAZANA"
        'conexion en la facu
        'Me.cadena_conexion = "Provider=SQLOLEDB.1;Password=avisuales1;Persist Security Info=True;User ID=avisuales1;Initial Catalog=CONSULTORIO_FINAL ;Data Source=maquis"


        carga_combo(Me.cboTipoDocumento, Me.leo_tabla("tipoDocumentos"), "id", "descripcion")
        carga_combo(Me.cboLocalidad, Me.leo_tabla("localidades"), "id", "descripcion")

        Me.grp_Paciente.Visible = False
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


    Private Function leo_tabla(ByVal nombre_tabla As String) As Data.DataTable

        '  Dim conexion As New Data.OleDb.OleDbConnection
        '   Dim cmd As New Data.OleDb.OleDbCommand
        '   Dim tabla As New Data.DataTable

        '   conexion.ConnectionString = Me.cadena_conexion
        '   conexion.Open()
        '   cmd.Connection = conexion
        '  cmd.CommandType = CommandType.Text
        '  cmd.CommandText = "select * from " & nombre_tabla
        '  tabla.Load(cmd.ExecuteReader())
        '  Return tabla
        Return leerTabla(nombre_tabla)
    End Function

    Private Function validar() As Boolean
        If Me.txtApellido.Text = "" Then
            MsgBox("el apellido no puede estar vacio", MsgBoxStyle.Critical, "Importante")
            Me.txtApellido.Focus()
            Return False
        End If
        If Me.txtNombre.Text = "" Then
            MsgBox("El nombre no puede estar vacio", MsgBoxStyle.Critical, "importante")
            Me.txtNombre.Focus()
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

        If Me.cboLocalidad.SelectedIndex = -1 Then
            MsgBox("No se selecciono la localidad")
            Me.cboLocalidad.Focus()
            Return False

        End If

        If Me.txtFechaNacimiento.Text = "" Then
            MsgBox("La fecha de nacimiento no puede estar vacio")
            txtFechaNacimiento.Focus()
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

        Return True
    End Function


    Private Sub cmdPuerta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPuerta.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Dim valor As Integer = 0
        borrarCampos()
        Me.grp_Paciente.Visible = True
        Me.grp_Inicio.Visible = False

        Me.cmdModificar.Enabled = False
        Me.cmdEliminar.Enabled = False
        Me.txtNroDocumento.Enabled = True
        Me.txtNombre.Focus()

        valor = BDHelper.getCodigoPacientes.Rows(0)("ultimo")
        Me.lbl_CodigoPaciente.Text = valor

        Me.accion = estado.insertar

    End Sub


    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        Dim var As String
        Select Case Me.cmb_Buscador.SelectedIndex
            Case 0
                var = "nombre"
                If Me.txt_IngresarDatos.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txt_IngresarDatos.Focus()
                Else
                    Me.DataGridView1.DataSource = BDHelper.BuscarPacientes(var, Me.txt_IngresarDatos.Text)

                End If
            Case 1
                var = "apellido"
                If Me.txt_IngresarDatos.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txt_IngresarDatos.Focus()
                Else
                    Me.DataGridView1.DataSource = BDHelper.BuscarPacientes(var, Me.txt_IngresarDatos.Text)

                End If
            Case 2
                var = "nroDoc"
                If Me.txt_IngresarDatos.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txt_IngresarDatos.Focus()
                Else
                    Me.DataGridView1.DataSource = BDHelper.BuscarPacientes(var, Me.txt_IngresarDatos.Text)

                End If
        End Select

    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click

        Try
            Dim cod As Integer = Me.DataGridView1.CurrentRow.Cells(1).Value

            If (MessageBox.Show("Está seguro que desea borrar ese registro", "Atención",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK) Then

                Dim tablaEmp As Data.DataTable
                Dim tablaDNI As Data.DataTable
                tablaDNI = BDHelper.obtenerDNI(Me.DataGridView1.CurrentRow.Cells(0).Value)
                tablaEmp = BDHelper.borrarPacienteXTurno(tablaDNI.Rows(0)(0), cod, Me.DataGridView1.CurrentRow.Cells(4).Value)
                If (tablaEmp.Rows.Count > 0) Then
                    MsgBox("Este paciente tiene turnos relacionados")
                Else
                    BDHelper.borrarPacientes(cod)
                    actualizar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("No se selecciono un paciente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
       

    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        If validar() = True Then
            If validarExistencia() = True Then

                BDHelper.guardarPacientes(cboTipoDocumento.SelectedValue, txtNroDocumento.Text, txtNombre.Text, txtApellido.Text, lbl_CodigoPaciente.Text, txtFechaNacimiento.Text, txtCalle.Text, txtNumero.Text, txtPiso.Text, txtDepartamento.Text, cboLocalidad.SelectedValue, txtTelefono.Text, txtCelular.Text)
                MessageBox.Show("Se grabó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                actualizar()
                Me.grp_Paciente.Visible = False
                Me.grp_Inicio.Visible = True

                Me.cmdModificar.Enabled = True
                Me.cmdEliminar.Enabled = True

                Me.txtNroDocumento.Enabled = True

            Else
                If validarExistenciaCodigo() = True Then

                    modificarPacientes(cboTipoDocumento.SelectedValue, txtNroDocumento.Text, txtNombre.Text, txtApellido.Text, lbl_CodigoPaciente.Text, txtFechaNacimiento.Text, txtCalle.Text, txtNumero.Text, txtPiso.Text, txtDepartamento.Text, cboLocalidad.SelectedValue, txtTelefono.Text, txtCelular.Text)
                    MessageBox.Show("Se modifico exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    actualizar()
                    Me.grp_Paciente.Visible = False
                    Me.grp_Inicio.Visible = True

                    Me.cmdModificar.Enabled = True
                    Me.cmdEliminar.Enabled = True

                    Me.txtNroDocumento.Enabled = True

                Else
                    MessageBox.Show("Ya está cargada una persona con ese documento", "Importante", _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtNroDocumento.Focus()

                End If

            End If
        End If
       

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        borrarCampos()
        Me.grp_Paciente.Visible = False
        Me.grp_Inicio.Visible = True

        Me.cmdModificar.Enabled = True
        Me.cmdEliminar.Enabled = True
        Me.txtNroDocumento.Enabled = True

    End Sub


    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If (DataGridView1.RowCount > 0) Then
            Dim cod As Integer = Me.DataGridView1.CurrentRow.Cells(1).Value
            Dim valor As Integer = 0
            Try
                BDHelper.cargarPacientes(cod)


                Me.cboTipoDocumento.SelectedValue = BDHelper.cargarPacientes(cod).Rows(0)("idTipoDoc")
                Me.txtNroDocumento.Text = BDHelper.cargarPacientes(cod).Rows(0)("nroDoc")
                Me.txtNombre.Text = BDHelper.cargarPacientes(cod).Rows(0)("nombre")
                Me.txtApellido.Text = BDHelper.cargarPacientes(cod).Rows(0)("apellido")
                Me.lbl_CodigoPaciente.Text = BDHelper.cargarPacientes(cod).Rows(0)("nroHistorial")
                Me.txtTelefono.Text = BDHelper.cargarPacientes(cod).Rows(0)("telefono")
                Me.cboLocalidad.SelectedValue = BDHelper.cargarPacientes(cod).Rows(0)("idLocalidad")
                Me.txtFechaNacimiento.Text = BDHelper.cargarPacientes(cod).Rows(0)("fechaNacimiento")
                Me.txtCelular.Text = BDHelper.cargarPacientes(cod).Rows(0)("celular")
                Me.txtCalle.Text = BDHelper.cargarPacientes(cod).Rows(0)("calle")
                Me.txtNumero.Text = BDHelper.cargarPacientes(cod).Rows(0)("nroCalle")
                Me.txtPiso.Text = BDHelper.cargarPacientes(cod).Rows(0)("piso")
                Me.txtDepartamento.Text = BDHelper.cargarPacientes(cod).Rows(0)("departamento")

                Me.accion = estado.modificar

                Me.grp_Paciente.Visible = True
                Me.grp_Inicio.Visible = False

                Me.cmdModificar.Enabled = False
                Me.cmdEliminar.Enabled = False
                Me.txtNroDocumento.Enabled = False
                Me.txtNombre.Focus()
            Catch ex As Exception
                MessageBox.Show("No se selecciono un paciente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MsgBox("No hay ningun paciente seleccionado")
        End If


    End Sub

    Private Function validarExistencia() As Boolean
        If BDHelper.BuscarPacientes("nroDoc", Me.txtNroDocumento.Text).Rows.Count() = 1 Then
            Return False
        Else
            Return True
        End If

    End Function
    Private Function validarExistenciaCodigo() As Boolean

        If BDHelper.BuscarPacientes("nroHistorial", Me.lbl_CodigoPaciente.Text).Rows.Count = 1 Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click

        actualizar()

    End Sub

    Private Sub actualizar()

        Me.DataGridView1.DataSource = BDHelper.actualizar()

    End Sub

    Private Sub borrarCampos()
        Me.txtNombre.Clear()
        Me.txtFechaNacimiento.ResetText()
        Me.txtDepartamento.Clear()
        Me.txtCalle.Clear()
        Me.txtApellido.Clear()
        Me.txtNroDocumento.Clear()
        Me.txtNumero.Clear()
        Me.txtPiso.Clear()
        Me.txtTelefono.Clear()
        Me.txtCelular.Clear()
        Me.cboLocalidad.SelectedValue = -1
        Me.cboTipoDocumento.SelectedValue = -1

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 9, 15, 14
            Case 13

                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = True Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 9, 15, 14
            Case 13
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = True Then
            e.KeyChar = ""
        End If
    End Sub


    Private Sub txtNroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocumento.KeyPress, txtNumero.KeyPress, txtPiso.KeyPress, txtTelefono.KeyPress, txtCelular.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        Dim cod As Integer = Me.DataGridView1.CurrentRow.Cells(1).Value
        Dim valor As Integer = 0

        BDHelper.cargarPacientes(cod)
        Me.txtNombre.Text = BDHelper.cargarPacientes(cod).Rows(0)("nombre")
        Me.txtNroDocumento.Text = BDHelper.cargarPacientes(cod).Rows(0)("nroDoc")
        Me.txtApellido.Text = BDHelper.cargarPacientes(cod).Rows(0)("apellido")
        Me.lbl_CodigoPaciente.Text = BDHelper.cargarPacientes(cod).Rows(0)("nroHistorial")
        Me.txtTelefono.Text = BDHelper.cargarPacientes(cod).Rows(0)("telefono")
        Me.cboLocalidad.SelectedValue = BDHelper.cargarPacientes(cod).Rows(0)("idLocalidad")
        Me.txtFechaNacimiento.Text = BDHelper.cargarPacientes(cod).Rows(0)("fechaNacimiento")
        Me.txtCelular.Text = BDHelper.cargarPacientes(cod).Rows(0)("celular")
        Me.txtCalle.Text = BDHelper.cargarPacientes(cod).Rows(0)("calle")
        Me.txtNumero.Text = BDHelper.cargarPacientes(cod).Rows(0)("nroCalle")
        Me.txtPiso.Text = BDHelper.cargarPacientes(cod).Rows(0)("piso")
        Me.txtDepartamento.Text = BDHelper.cargarPacientes(cod).Rows(0)("departamento")

        Me.grp_Paciente.Visible = True
        Me.grp_Inicio.Visible = False

        Me.accion = estado.modificar

        Me.cmdModificar.Enabled = False
        Me.cmdEliminar.Enabled = False
        Me.txtNroDocumento.Enabled = False
        Me.txtNombre.Focus()
    End Sub



    Private Sub txt_IngresarDatos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_IngresarDatos.KeyPress
        If (cmb_Buscador.Text = "Documento") Then

            If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
                e.KeyChar = ""
                e.Handled = True
                txt_IngresarDatos.Focus()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub



    '  Private Sub txtFechaNacimiento_Validated(sender As Object, e As EventArgs)
    ' Dim fechaMin As String = "01/01/1910"
    '  Dim fechaMax As String = DateTime.Now.ToString("dd/MM/yyyy")
    '

    ' If IsDate(sender.text) Then

    ' If Not sender.text = Format(CDate(sender.text), "dd/mm/yyyy") Then
    'Else
    '            MsgBox("fecha invalida")
    '            sender.focus
    'Exit Sub
    'End If
    'Else
    '        MsgBox("fecha invalida")
    '        sender.focus
    'Exit Sub
    'End If
    ' End Sub

End Class
