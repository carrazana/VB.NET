Public Class frmRegistrarStock
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
    Dim encontrado As Boolean

    Private Sub frmRegistrarStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        If Me.CboInsumo.SelectedIndex = -1 Then
            MessageBox.Show("No se selecciono el insumo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.CboInsumo.Focus()
            Return False
        End If
        If Me.txtCantidad.Text = "" Then
            MessageBox.Show("La cantidad no puede estar vacia", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtCantidad.Focus()
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

        Me.grp_Stock.Visible = True
        Me.grp_Inicio.Visible = False

        Me.cmdModificar.Enabled = False
        Me.cmdEliminar.Enabled = False

    End Sub


    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        Dim var As String
        Select Case Me.cmb_Buscador.SelectedIndex
            Case 0
                var = "descripcion"
                If Me.txtBuscar.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txtBuscar.Focus()
                Else
                    Me.dgv_stock.DataSource = BDHelper.buscarInsumosStock(var, Me.txtBuscar.Text)

                End If
            Case 1
                var = "descripcion"
                If Me.txtBuscar.Text = "" Then
                    MsgBox("Debe completar el campo")
                    txtBuscar.Focus()
                Else
                    Me.dgv_stock.DataSource = BDHelper.buscarInsumosStock(var, Me.txtBuscar.Text)

                End If
        End Select

    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click

        Try
            Dim cod1 As String = Me.dgv_stock.CurrentRow.Cells(0).Value
          
            Dim tabla1 As New Data.DataTable
            If (MessageBox.Show("Está seguro que desea borrar ese registro", "Atención",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK) Then
                tabla1 = BDHelper.idInsumo(cod1)
                Dim idInsumo As Integer = tabla1.Rows(0)("id")
                BDHelper.borrarStock(idInsumo)
                actualizar()

            End If
        Catch ex As Exception
            MessageBox.Show("No se selecciono un dato", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    

    End Sub



    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        Try
            Dim cod As String = Me.dgv_stock.CurrentRow.Cells(0).Value

            BDHelper.cargarStock(cod)

            'Me.cboProveedor.Text = BDHelper.cargarStock(cod).Rows(0)("nombre")
            Me.CboInsumo.Text = BDHelper.cargarStock(cod).Rows(0)("descripcion")
            Me.txtCantidad.Text = BDHelper.cargarStock(cod).Rows(0)("cantidad")

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


        If BDHelper.buscarProveedorxInsumo(Me.cboProveedor.SelectedValue, Me.CboInsumo.SelectedValue).Rows.Count() >= 1 Then
            Return False
        Else
            Return True
        End If

    End Function


    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click

        actualizar()

    End Sub

    Private Sub actualizar()

        dgv_stock.DataSource = BDHelper.getStock

    End Sub

    Private Sub borrarCampos()
        Me.txtCantidad.Clear()
        Me.cboProveedor.SelectedValue = -1
        Me.CboInsumo.SelectedValue = -1

    End Sub



    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este caracter (" + e.KeyChar + ") no es un numero")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        borrarCampos()

        Me.grp_Stock.Visible = False
        Me.grp_Inicio.Visible = True

        Me.cmdModificar.Enabled = True
        Me.cmdEliminar.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validar() = True Then
            If Me.accion = estado.insertar Then
                If validarExistencia() = True Then

                    guardarStock(CboInsumo.SelectedValue, txtCantidad.Text, "")
                    MessageBox.Show("Se grabó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    actualizar()
                    Me.grp_Stock.Visible = False
                    Me.grp_Inicio.Visible = True

                    Me.cmdModificar.Enabled = True
                    Me.cmdEliminar.Enabled = True

                Else
                    MessageBox.Show("Ya está cargado un insumo con ese codigo", "Importante", _
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.cboProveedor.Focus()

                End If
            Else
                If Me.accion = estado.modificar Then

                    modificarStock(CboInsumo.SelectedValue, txtCantidad.Text, "COMPRAR")
                    MessageBox.Show("Se modifico exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    actualizar()
                    Me.grp_Stock.Visible = False
                    Me.grp_Inicio.Visible = True

                    Me.cmdModificar.Enabled = True
                    Me.cmdEliminar.Enabled = True
                End If

            End If
        End If
    End Sub

 
End Class
