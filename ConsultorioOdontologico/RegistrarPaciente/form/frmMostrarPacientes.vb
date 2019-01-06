Public Class frmMostrarPacientes

    Private Sub frmMostrarPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTodos.DataSource = BDHelper.getPacientes
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        _variable.valorBusqueda = dgvTodos.CurrentRow.Cells(1).Value
        _variable.nombrePaciente = dgvTodos.CurrentRow.Cells(2).Value
        _variable.apellidoPaciente = dgvTodos.CurrentRow.Cells(3).Value

        'Dim tablaIDDoc As DataTable

        'tablaIDDoc = BDHelper.getIDdocumento(dgvTodos.CurrentRow.Cells(0).Value.ToString)
        _variable.tipoDocumento = BDHelper.getIDdocumento(dgvTodos.CurrentRow.Cells(0).Value.ToString)
        Close()

    End Sub

    Private Sub dgvTodos_DoubleClick(sender As Object, e As EventArgs) Handles dgvTodos.DoubleClick
        _variable.valorBusqueda = dgvTodos.CurrentRow.Cells(1).Value
        _variable.nombrePaciente = dgvTodos.CurrentRow.Cells(2).Value
        _variable.apellidoPaciente = dgvTodos.CurrentRow.Cells(3).Value

        'Dim tablaIDDoc As DataTable

        'tablaIDDoc = BDHelper.getIDdocumento(dgvTodos.CurrentRow.Cells(0).Value.ToString)
        _variable.tipoDocumento = BDHelper.getIDdocumento(dgvTodos.CurrentRow.Cells(0).Value.ToString)
        Close()
    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String,
                           ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
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
                    Me.dgvTodos.DataSource = BDHelper.BuscarPacientes(var, Me.txt_IngresarDatos.Text)

                End If
            Case 1
                var = "apellido"
                If Me.txt_IngresarDatos.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txt_IngresarDatos.Focus()
                Else
                    Me.dgvTodos.DataSource = BDHelper.BuscarPacientes(var, Me.txt_IngresarDatos.Text)

                End If
            Case 2
                var = "nroDoc"
                If Me.txt_IngresarDatos.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txt_IngresarDatos.Focus()
                Else
                    Me.dgvTodos.DataSource = BDHelper.BuscarPacientes(var, Me.txt_IngresarDatos.Text)

                End If
        End Select

    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        dgvTodos.DataSource = BDHelper.getPacientes
    End Sub
End Class