Public Class frmCompraInsumo

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

    Dim encontrado As Boolean

    Private Sub frmCompraInsumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim añoMenor As Integer = DateTime.Now.Year - 110
        Me.lblHora.Text = DateTime.Now.ToShortTimeString()
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        carga_combo(Me.cboProveedor, BDHelper.leo_tabla("Proveedores"), "idProveedores", "nombre")
        carga_combo(Me.CboInsumo, BDHelper.leo_tabla("Insumos"), "id", "descripcion")

        Me.grp_Stock.Visible = False
        Me.grp_Inicio.Visible = True
        actualizar()

        Me.cmdNuevo.Enabled = True
        Me.cmdModificar.Enabled = True
        Me.cmdEliminar.Enabled = True

        Me.txtFechaC.MaxDate = Date.Now
        Me.txtFechaC.MinDate = añoMenor & "-01-01"

    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String,
                            ByVal descripcion As String)

        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

    Private Function validar() As Boolean

        If Me.cboProveedor.SelectedIndex = -1 Then
            MessageBox.Show("No se selecciono el proveedor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cboProveedor.Focus()
            Return False
        End If

        If Me.dgvInsumos.Rows.Count = 0 Then
            MessageBox.Show("Debe ingresar insumos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.CboInsumo.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function validarInsumos() As Boolean

        If Me.CboInsumo.SelectedIndex = -1 Then
            MessageBox.Show("No se selecciono el insumo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.CboInsumo.Focus()
            Return False
        End If
        If Me.txtPrecioUnitario.Text = "" Then
            MessageBox.Show("El precio Unitario no puede estar vacio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtPrecioUnitario.Focus()
            Return False
        End If
        If Me.txtPrecioUnitario.Text <= 0 Then
            MessageBox.Show("El precio Unitario no puede ser cero o menor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtPrecioUnitario.Focus()
            Return False
        End If
        If Me.txtCantidad.Text = "" Then
            MessageBox.Show("La cantidad no puede estar vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtCantidad.Focus()
            Return False
        End If

        If Me.txtCantidad.Text <= 0 Then
            MessageBox.Show("La cantidad no puede ser cero o menor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtCantidad.Focus()
            Return False
        End If

        Return True
    End Function


    Private Sub cmdPuerta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPuerta.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        borrarCampos()
        cboProveedor.Focus()
        Me.grp_Stock.Visible = True
        Me.grp_Inicio.Visible = False

        Me.cmdModificar.Enabled = False
        Me.cmdEliminar.Enabled = False
        Me.accion = estado.insertar
    End Sub


    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        Dim var As String
        Select Case Me.cmb_Buscador.SelectedIndex
            Case 0
                var = "C.codProveedor"
                If Me.txtBuscar.Text = "" Then
                    MessageBox.Show("Debe completar el campo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBuscar.Focus()
                Else
                    Me.dgv_compra.DataSource = BDHelper.buscarCompra(var, Me.txtBuscar.Text)

                End If
            Case 1
                var = "P.nombre"
                If Me.txtBuscar.Text = "" Then
                    MessageBox.Show("Debe completar el campo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBuscar.Focus()
                Else
                    Me.dgv_compra.DataSource = BDHelper.buscarCompra(var, Me.txtBuscar.Text)

                End If
            Case 2
                Try
                    var = "C.fechaHora"
                    If Me.txtBuscar.Text = "" Then
                        MessageBox.Show("Debe completar el campo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtBuscar.Focus()
                    Else
                        Me.dgv_compra.DataSource = BDHelper.buscarCompra(var, Me.txtBuscar.Text)

                    End If
                Catch ex As Exception
                    MessageBox.Show("En formato año/mes/dia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try


        End Select

    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click

        Try
            Dim cod As String = Me.dgv_compra.CurrentRow.Cells(0).Value
            Dim fecha As String = Me.dgv_compra.CurrentRow.Cells(2).Value
            If (MessageBox.Show("Está seguro que desea borrar ese registro", "Atención",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK) Then

                BDHelper.borrarDetalleCompra(cod, fecha)
                BDHelper.borrarCompra(cod, fecha)
                actualizar()

            End If
        Catch ex As Exception
            MessageBox.Show("No se selecciono un dato", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        Try
            borrarCampos()
            Dim cod As String = Me.dgv_compra.CurrentRow.Cells(0).Value
            Dim fecha As String = Me.dgv_compra.CurrentRow.Cells(2).Value
            Dim i As Integer = 0

            BDHelper.cargarCompra(cod, fecha)

            Me.cboProveedor.SelectedValue = BDHelper.cargarCompra(cod, fecha).Rows(0)("codProveedor")
            Me.txtFechaC.Text = BDHelper.cargarCompra(cod, fecha).Rows(0)("fechaHora")
            Me.lblMontoTotal.Text = BDHelper.cargarCompra(cod, fecha).Rows(0)("montoTotal")

            For i = 0 To BDHelper.cargarCompra(cod, fecha).Rows.Count - 1
                Dim nuevaFila() As String = {BDHelper.cargarCompra(cod, fecha).Rows(i)("codInsumo"), BDHelper.cargarCompra(cod, fecha).Rows(i)("cantidad"), BDHelper.cargarCompra(cod, fecha).Rows(i)("precioUnitario")}

                dgvInsumos.Rows.Add(nuevaFila)

            Next


            Me.accion = estado.modificar

            Me.grp_Stock.Visible = True
            Me.grp_Inicio.Visible = False

            Me.cmdModificar.Enabled = False
            Me.cmdEliminar.Enabled = False
            Me.cboProveedor.Focus()

        Catch ex As Exception
            MessageBox.Show("No se selecciono un dato", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Function validarExistencia() As Boolean

        If BDHelper.cargarCompra(cboProveedor.SelectedValue, txtFechaC.Text).Rows.Count >= 1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click

        actualizar()

    End Sub

    Private Sub actualizar()

        dgv_compra.DataSource = BDHelper.getCompra

    End Sub

    Private Sub borrarCampos()
        Me.txtCantidad.Clear()
        Me.cboProveedor.SelectedIndex = -1
        Me.CboInsumo.SelectedIndex = -1
        Me.txtPrecioUnitario.Clear()
        Me.dgvInsumos.Rows.Clear()
        Me.txtFechaC.Text = Date.Now.ToShortDateString
        Me.lblMontoTotal.Text = 0
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress, txtPrecioUnitario.KeyPress
        If IsNumeric(e.KeyChar) = False Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub dgv_proveedores_DoubleClick(sender As Object, e As EventArgs) Handles dgv_compra.DoubleClick
        Try
            borrarCampos()
            Dim cod As String = Me.dgv_compra.CurrentRow.Cells(0).Value
            Dim fecha As String = Me.dgv_compra.CurrentRow.Cells(2).Value
            Dim i As Integer = 0

            BDHelper.cargarCompra(cod, fecha)

            Me.cboProveedor.SelectedValue = BDHelper.cargarCompra(cod, fecha).Rows(0)("codProveedor")
            Me.txtFechaC.Text = BDHelper.cargarCompra(cod, fecha).Rows(0)("fechaHora")
            Me.lblMontoTotal.Text = BDHelper.cargarCompra(cod, fecha).Rows(0)("montoTotal")

            For i = 0 To BDHelper.cargarCompra(cod, fecha).Rows.Count - 1
                Dim nuevaFila() As String = {BDHelper.cargarCompra(cod, fecha).Rows(i)("codInsumo"), BDHelper.cargarCompra(cod, fecha).Rows(i)("cantidad"), BDHelper.cargarCompra(cod, fecha).Rows(i)("precioUnitario")}

                dgvInsumos.Rows.Add(nuevaFila)

            Next


            Me.accion = estado.modificar

            Me.grp_Stock.Visible = True
            Me.grp_Inicio.Visible = False

            Me.cmdModificar.Enabled = False
            Me.cmdEliminar.Enabled = False
            Me.cboProveedor.Focus()

        Catch ex As Exception
            MessageBox.Show("No se selecciono un dato", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        borrarCampos()

        Me.grp_Stock.Visible = False
        Me.grp_Inicio.Visible = True

        Me.cmdModificar.Enabled = True
        Me.cmdEliminar.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim i As Integer = 0
        If validar() = True Then
            If Me.accion = estado.insertar Then
                If validarExistencia() = True Then

                    guardarCompra(cboProveedor.SelectedValue, txtFechaC.Text, lblMontoTotal.Text)
                    For i = 0 To dgvInsumos.Rows.Count - 1
                        BDHelper.guardarDetalleCompra(cboProveedor.SelectedValue, dgvInsumos.Rows(i).Cells(0).Value.ToString, dgvInsumos.Rows(i).Cells(1).Value.ToString, txtFechaC.Text, dgvInsumos.Rows(i).Cells(2).Value.ToString)

                    Next
                    'Stock
                    For i = 0 To dgvInsumos.Rows.Count - 1

                        Dim tabla As Data.DataTable = BDHelper.idInsumoStock(dgvInsumos.Rows(i).Cells(0).Value.ToString)
                        Dim cantidad As Integer = 0
                        cantidad = tabla.Rows(0)("cantidad")

                        If cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString = 0 Then
                            BDHelper.modificarStock(dgvInsumos.Rows(i).Cells(0).Value.ToString, cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString, "COMPRAR")
                        End If

                        If cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString > 0 And cantidad - dgvInsumos.Rows(i).Cells(1).Value.ToString <= 5 Then
                            BDHelper.modificarStock(dgvInsumos.Rows(i).Cells(0).Value.ToString, cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString, "CRITICO")
                        End If

                        If cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString > 5 Then
                            BDHelper.modificarStock(dgvInsumos.Rows(i).Cells(0).Value.ToString, cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString, "NORMAL")
                        End If

                    Next

                    MessageBox.Show("El registro se ha guardado correctamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Existe actualmente un proveedor y una fecha igual cargados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.cboProveedor.Focus()

                End If
            Else

                BDHelper.modificarCompra(cboProveedor.SelectedValue, txtFechaC.Text, lblMontoTotal.Text)
                For i = 0 To dgvInsumos.Rows.Count - 1
                    BDHelper.modificarDetalleCompra(cboProveedor.SelectedValue, dgvInsumos.Rows(i).Cells(0).Value.ToString, dgvInsumos.Rows(i).Cells(1).Value.ToString, txtFechaC.Text, dgvInsumos.Rows(i).Cells(2).Value.ToString)
                Next
                'Stock
                For i = 0 To dgvInsumos.Rows.Count - 1

                    Dim tabla As Data.DataTable = BDHelper.idInsumoStock(dgvInsumos.Rows(i).Cells(0).Value.ToString)
                    Dim cantidad As Integer = 0
                    cantidad = tabla.Rows(0)("cantidad")

                    If cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString = 0 Then
                        BDHelper.modificarStock(dgvInsumos.Rows(i).Cells(0).Value.ToString, cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString, "COMPRAR")
                    End If

                    If cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString > 0 And cantidad + dgvInsumos.Rows(i).Cells(2).Value.ToString <= 5 Then
                        BDHelper.modificarStock(dgvInsumos.Rows(i).Cells(0).Value.ToString, cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString, "CRITICO")
                    End If

                    If cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString > 5 Then
                        BDHelper.modificarStock(dgvInsumos.Rows(i).Cells(0).Value.ToString, cantidad + dgvInsumos.Rows(i).Cells(1).Value.ToString, "NORMAL")
                    End If

                Next

                MessageBox.Show("El registro se ha modificado correctamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            actualizar()
            Me.grp_Stock.Visible = False
            Me.grp_Inicio.Visible = True

            Me.cmdModificar.Enabled = True
            Me.cmdEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            
            If validarInsumos() = True Then
                Dim nuevaFila() As String = {Me.CboInsumo.SelectedValue, txtCantidad.Text, txtPrecioUnitario.Text}
                encontrado = False
                Dim i As Integer
                For i = 0 To dgvInsumos.Rows.Count - 1
                    If (dgvInsumos.Rows(i).Cells(0).Value.ToString()) = Me.CboInsumo.SelectedValue Then
                        encontrado = True
                    End If

                Next
                If encontrado = True Then
                    MessageBox.Show("Ya se ha cargado el insumo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dgvInsumos.Rows.Add(nuevaFila)
                End If
                lblMontoTotal.Text = 0
                calcularTotal()
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            dgvInsumos.Rows.Remove(dgvInsumos.CurrentRow)
            lblMontoTotal.Text = 0
            calcularTotal()
        Catch ex As Exception
            MessageBox.Show("La grilla esta vacia")
        End Try

    End Sub

    Public Sub calcularTotal()
        Dim i As Integer = 0
        Dim contador As Integer = 0
        For i = 0 To dgvInsumos.Rows.Count - 1
            contador = contador + (dgvInsumos.Rows(i).Cells(1).Value.ToString * dgvInsumos.Rows(i).Cells(2).Value.ToString)
            lblMontoTotal.Text = ""
            lblMontoTotal.Text = contador
        Next

    End Sub

   
    Private Sub btnVerStock_Click(sender As Object, e As EventArgs) Handles btnVerStock.Click
        frmRegistrarStock.ShowDialog()
    End Sub
End Class