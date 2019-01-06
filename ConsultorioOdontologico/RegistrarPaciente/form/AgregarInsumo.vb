Public Class AgregarInsumo
    Dim tablaInsumos As New DataTable
    Private Sub AgregarInsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablaInsumos = BDHelper.obtenerInsumos
        gridInsumos.DataSource = tablaInsumos
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtCantidad.Text = "") Then
            MessageBox.Show("Ingrese la cantidad de insumo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If (txtCantidad.Text <= 0) Then
            MessageBox.Show("La cantidad no puede ser cero o menor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If (gridInsumos.Rows.Count > 0) Then

            _variable.ElementoInsumoTabla("id") = gridInsumos.CurrentRow.Cells(0).Value
            _variable.ElementoInsumoTabla("descripcion") = gridInsumos.CurrentRow.Cells(1).Value
            _variable.ElementoInsumoTabla("cantidad") = txtCantidad.Text
            _variable.ElementoInsumoTabla("precio") = gridInsumos.CurrentRow.Cells(2).Value

            Me.Close()
        Else
            MessageBox.Show("No se selecciono o no esta cargada la grilla", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

  


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 9, 15, 14
            Case 13

                Exit Sub
        End Select

        If IsNumeric(e.KeyChar) = False Then
            e.KeyChar = ""
        End If
    End Sub

End Class