Public Class frmABMTurnos

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

    Private Sub frmABMTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblHora.Text = DateTime.Now.ToShortTimeString()
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Me.cmdAceptar.Visible = False
        Me.cmdCancelar.Visible = False
        Me.cmdBuscar.Enabled = False
        Me.grpTurnos.Visible = False
        Me.grpBuscador.Visible = True

        dgv.DataSource = BDHelper.getTurnos()

        CargarCombo(cboProfesional, BDHelper.leo_tabla("Empleados"), "codigoEmpleado", "apellido")


        Me.txtBuscador.Focus()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


        Dim añoMayor As Integer
        'añoMenor = DateTime.Now.Year - 110
        añoMayor = DateTime.Now.Year + 1

        Try

            Me.txtFecha.MaxDate = añoMayor & "-12-31"
            Me.txtFecha.MinDate = Date.Now

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Function validar() As Boolean

        If Me.cboProfesional.SelectedIndex = -1 Then
            MessageBox.Show("No se selecciono el profesional", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cboProfesional.Focus()
            Return False
        End If

        If Me.dgvHorarios.Rows.Count = 0 Then
            MessageBox.Show("La grilla esta vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.dgvHorarios.Focus()
            Return False
        End If
        If Me.txtDocumento.Text = "" Then
            MessageBox.Show("No se ingreso un paciente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtDocumento.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub txtHora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHora.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 9, 15, 14
            Case 13

                Exit Sub
        End Select

        If IsNumeric(e.KeyChar) = False Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Me.grpBuscador.Visible = False
        Me.grpTurnos.Visible = True
        Me.cmdAceptar.Visible = True
        Me.cmdCancelar.Visible = True
        Me.cmdNuevo.Visible = False
        Me.cmdEliminar.Visible = False
        Me.cmdModificar.Visible = False
        Me.cmdSalir.Visible = False
        Me.limpiar()

        Me.grpHora.Visible = False

        Me.accion = estado.insertar

    End Sub

    Private Sub limpiar()

        txtDocumento.Clear()
        txtApellido.Clear()
        txtNombre.Clear()
        Me.cboProfesional.SelectedIndex = -1
        Me.txtFecha.ResetText()
        Me.txtHora.Clear()
        Me.dgvHorarios.Rows.Clear()

    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Try
            Dim fecha As Date = Me.dgv.CurrentRow.Cells(2).Value
            Dim hora As String = Me.dgv.CurrentRow.Cells(3).Value


            limpiar()
            BDHelper.existenciaTurno(fecha, hora)
            Me.txtDocumento.Text = BDHelper.existenciaTurno(fecha, hora).Rows(0)("nroDocPaciente")
            Me.cboProfesional.SelectedValue = BDHelper.existenciaTurno(fecha, hora).Rows(0)("codEmpleado")
            Me.txtFecha.Text = BDHelper.existenciaTurno(fecha, hora).Rows(0)("fecha")
            Me.txtHora.Text = BDHelper.existenciaTurno(fecha, hora).Rows(0)("Hora")
            

            Me.accion = estado.modificar


            Me.grpBuscador.Visible = False
            Me.grpTurnos.Visible = True
            Me.cmdAceptar.Visible = True
            Me.cmdCancelar.Visible = True
            Me.cmdNuevo.Visible = False
            Me.cmdEliminar.Visible = False
            Me.cmdModificar.Visible = False
            Me.cmdSalir.Visible = False

            Me.grpHora.Visible = True
        Catch ex As Exception
            MessageBox.Show("No se selecciono un empleado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Sub cmdCancelar_Click_1(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.grpBuscador.Visible = True
        Me.grpTurnos.Visible = False
        Me.cmdAceptar.Visible = False
        Me.cmdCancelar.Visible = False
        Me.cmdNuevo.Visible = True
        Me.cmdEliminar.Visible = True
        Me.cmdModificar.Visible = True
        Me.cmdSalir.Visible = True
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim var As String
        Select Case Me.cboBuscador.SelectedIndex
            Case 0
                var = "T.nroDocPaciente"
                If Me.txtBuscador.Text = "" Then
                    MessageBox.Show("Debe completar el campo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBuscador.Focus()
                Else
                    Me.dgv.DataSource = BDHelper.buscarTurno(var, Me.txtBuscador.Text)

                End If
            Case 1
                Try
                    var = "T.fecha"
                    If Me.txtBuscador.Text = "" Then
                        MessageBox.Show("Debe completar el campo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtBuscador.Focus()
                    Else
                        Me.dgv.DataSource = BDHelper.buscarTurno(var, Me.txtBuscador.Text)

                    End If
                Catch ex As Exception
                    MessageBox.Show("En formato año/mes/dia")
                End Try
            Case 2
                var = "T.codEmpleado"
                If Me.txtBuscador.Text = "" Then
                    MessageBox.Show("Debe completar el campo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBuscador.Focus()
                Else
                    Me.dgv.DataSource = BDHelper.buscarTurno(var, Me.txtBuscador.Text)

                End If
            Case 3
                var = "E.Apellido"
                If Me.txtBuscador.Text = "" Then
                    MessageBox.Show("Debe completar el campo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBuscador.Focus()
                Else
                    Me.dgv.DataSource = BDHelper.buscarTurno(var, Me.txtBuscador.Text)

                End If


        End Select

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
            If IsNumeric(e.KeyChar) = False Then
                e.KeyChar = ""
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

            dgv.DataSource = BDHelper.getTurnos()

            Me.grpBuscador.Visible = True
            Me.grpTurnos.Visible = False
            Me.cmdAceptar.Visible = False
            Me.cmdCancelar.Visible = False
            Me.cmdNuevo.Visible = True
            Me.cmdEliminar.Visible = True
            Me.cmdModificar.Visible = True
            Me.cmdSalir.Visible = True
        End If
    End Sub

    Private Function validar_existencia() As termino

        If BDHelper.existenciaTurno(txtFecha.Text, dgvHorarios.CurrentRow.Cells(0).Value.ToString).Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim hora As String = Me.dgv.CurrentRow.Cells(3).Value
            Dim fecha As Date = Me.dgv.CurrentRow.Cells(2).Value

            If (MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", _
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK) Then
                BDHelper.borrarTurnos(hora, fecha)
   
                dgv.DataSource = BDHelper.getTurnos()
            End If
        Catch ex As Exception
            MessageBox.Show("No se selecciono un empleado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Function modificar() As termino

        BDHelper.modificarTurnos(cboProfesional.SelectedValue, _variable.tipoDocumento, txtDocumento.Text, txtFecha.Text, dgvHorarios.CurrentRow.Cells(0).Value.ToString)

        Return termino.aprobado
    End Function

    Private Function insertar() As termino

        BDHelper.guardarTurnos(cboProfesional.SelectedValue, _variable.tipoDocumento, txtDocumento.Text, txtFecha.Text, dgvHorarios.CurrentRow.Cells(0).Value.ToString)
        Return termino.aprobado
    End Function

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        dgv.DataSource = BDHelper.getTurnos()
    End Sub


    Private Sub dgvEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Try
            Dim fecha As Date = Me.dgv.CurrentRow.Cells(2).Value
            Dim hora As String = Me.dgv.CurrentRow.Cells(3).Value


            limpiar()
            BDHelper.existenciaTurno(fecha, hora)
            Me.txtDocumento.Text = BDHelper.existenciaTurno(fecha, hora).Rows(0)("nroDocPaciente")
            Me.cboProfesional.SelectedValue = BDHelper.existenciaTurno(fecha, hora).Rows(0)("codEmpleado")
            Me.txtFecha.Text = BDHelper.existenciaTurno(fecha, hora).Rows(0)("fecha")
            Me.txtHora.Text = BDHelper.existenciaTurno(fecha, hora).Rows(0)("Hora")


            Me.accion = estado.modificar


            Me.grpBuscador.Visible = False
            Me.grpTurnos.Visible = True
            Me.cmdAceptar.Visible = True
            Me.cmdCancelar.Visible = True
            Me.cmdNuevo.Visible = False
            Me.cmdEliminar.Visible = False
            Me.cmdModificar.Visible = False
            Me.cmdSalir.Visible = False

            Me.grpHora.Visible = True
        Catch ex As Exception
            MessageBox.Show("No se selecciono un empleado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        frmRegistrarPaciente.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarPaciente.Click

        frmMostrarPacientes.ShowDialog()
        txtDocumento.Text = _variable.valorBusqueda
        txtNombre.Text = _variable.nombrePaciente
        txtApellido.Text = _variable.apellidoPaciente

    End Sub

    Private Sub btnBuscarTurnos_Click_1(sender As Object, e As EventArgs) Handles btnBuscarTurnos.Click
        
        If cboProfesional.SelectedIndex = -1 Then
            MessageBox.Show("No se selecciono un profesional", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboProfesional.Focus()
        Else
            Dim i As Integer = 0
            Dim horaSuma As Integer = 0

            Me.dgvHorarios.Rows.Clear()
            For i = 0 To BDHelper.cantidadTurnos(cboProfesional.SelectedValue, BDHelper.cantidadMinutos(cboProfesional.SelectedValue)).Rows(0)("tiempo") - 1
                If BDHelper.existenciaTurno(txtFecha.Text, BDHelper.sumaHora(cboProfesional.SelectedValue, horaSuma).Rows(0)("suma")).Rows.Count = 1 Then
                Else
                    dgvHorarios.Rows.Add(BDHelper.sumaHora(cboProfesional.SelectedValue, horaSuma).Rows(0)("suma"))
                End If

                horaSuma = horaSuma + 30
            Next

        End If

    End Sub

    Private Sub txtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFecha.ValueChanged
        If Not (cboProfesional.SelectedIndex = -1) Then
            btnBuscarTurnos.PerformClick()
        End If
    End Sub
End Class