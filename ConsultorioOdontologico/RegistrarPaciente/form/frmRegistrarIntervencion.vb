Imports System.ComponentModel

Public Class frmRegistrarIntervencion
    Enum tipoABM
        alta
        baja
        modifcacion
        consulta
    End Enum

    Dim ABM As tipoABM

    Dim tablaIntervencionXPaciente As New DataTable
    Dim tablaInsumosXIntervencion As New DataTable

    Dim Sep As Char

    Private Sub frmRegistrarIntervencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMontoTotal.Text = "0"
        Me.lblHora.Text = DateTime.Now.ToShortTimeString()
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Me.cargo_combo(Me.cmbTipoBusqueda, leo_tabla("buscador"), "id", "descripcion")
        Me.cargo_combo(cmbTratamientos, leo_tabla("tratamientos"), "id", "descripcion")
        mostrarGroupConsulta()

        'cargar grilla insumos
        'validar q ya existe
        tablaInsumosXIntervencion.NewRow()
        tablaInsumosXIntervencion.Columns.Add("id")
        tablaInsumosXIntervencion.Columns.Add("descripcion")
        tablaInsumosXIntervencion.Columns.Add("cantidad")
        tablaInsumosXIntervencion.Columns.Add("precio")
        gridInsumosTramientoXIntervencion.DataSource = tablaInsumosXIntervencion

        btnNuevo.Enabled = False

        gridTratamientosXPaciente.DataSource = BDHelper.getIntervenciones

        If (gridTratamientosXPaciente.Rows.Count > 0) Then
            'txtNroHistorial.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(3).Value
            'txtNombrePaciente.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(7).Value
            'txtApellidoPaciente.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(8).Value
        End If
    End Sub


    Private Sub cargo_combo(ByVal cmb As ComboBox, ByVal tabla As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        cmb.DataSource = tabla
        cmb.DisplayMember = descripcion
        cmb.ValueMember = pk
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If (Me.validardatosBusqueda() = False) Then
            Exit Sub
        End If

        mostrarDatos()

        If Not (txtNroHistorial.Text = "") Then
            groupDatosIntervencion.Enabled = True
            btnNuevo.Enabled = True

        End If


    End Sub

    Private Function validardatosBusqueda() As Boolean
        Dim validar = True
        If (cmbTipoBusqueda.SelectedIndex = -1) Then
            MessageBox.Show("No se ha seleccionado ningun tipo de busqueda o es incorrecto", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbTipoBusqueda.Focus()
            validar = False
            Return validar
            Exit Function
        End If

        If (txtValorBusqueda.Text = "") Then
            MessageBox.Show("No se ha ingresado un valor de busqueda", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtValorBusqueda.Focus()
            Return False
        End If
        Return validar
    End Function

    Private Sub mostrarDatos()

        cargarBD()

        cargarNomApeNroHis()

    End Sub

    Private Sub cargarBD()
        ''Dim tablaIntervencionXPaciente As New DataTable
        If (cmbTipoBusqueda.Text = "NOMBRE") Then
            tablaIntervencionXPaciente = BDHelper.obtenerDatosIntervencionPacienteXnombre(txtValorBusqueda.Text)
            cargarGrilla()

        Else
            If (cmbTipoBusqueda.Text = "APELLIDO") Then
                tablaIntervencionXPaciente = BDHelper.obtenerDatosIntervencionPacienteXapellido(txtValorBusqueda.Text)
                cargarGrilla()

            Else
                If (cmbTipoBusqueda.Text = "DOCUMENTO") Then
                    If (IsNumeric(txtValorBusqueda.Text)) Then
                        tablaIntervencionXPaciente = BDHelper.obtenerDatosIntervencionPacienteXnroDoc(txtValorBusqueda.Text)
                        cargarGrilla()
                    Else
                        MessageBox.Show("No se cargo el valor de busqueda con numeros", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtValorBusqueda.Focus()
                    End If

                    Exit Sub

                End If

            End If
        End If

    End Sub

    Private Sub cargarGrilla()
        If (tablaIntervencionXPaciente.Rows.Count > 0) Then
            gridTratamientosXPaciente.DataSource = tablaIntervencionXPaciente
        Else
            MessageBox.Show("No se encontro algun paciente con intervencion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            groupDatosIntervencion.Enabled = False
            tablaIntervencionXPaciente.Clear()
            tablaIntervencionXPaciente.AcceptChanges()
            gridTratamientosXPaciente.DataSource = tablaIntervencionXPaciente
            Exit Sub
        End If
    End Sub

    Private Sub cargarNomApeNroHis()
        Dim tablaNomApeHis As Data.DataTable

        If (cmbTipoBusqueda.Text = "NOMBRE") Then
            If (BDHelper.obtenerNroHistorialXNombre(txtValorBusqueda.Text).Rows.Count > 0) Then
                tablaNomApeHis = BDHelper.obtenerNroHistorialXNombre(txtValorBusqueda.Text)

                txtNombrePaciente.Text = tablaNomApeHis.Rows(0).Item(0)
                txtApellidoPaciente.Text = tablaNomApeHis.Rows(0).Item(1)
                txtNroHistorial.Text = tablaNomApeHis.Rows(0).Item(2)
            Else

            End If

        End If
        If (cmbTipoBusqueda.Text = "APELLIDO") Then
            If (BDHelper.obtenerNroHistorialXApellido(txtValorBusqueda.Text).Rows.Count > 0) Then
                tablaNomApeHis = BDHelper.obtenerNroHistorialXApellido(txtValorBusqueda.Text)

                txtNombrePaciente.Text = tablaNomApeHis.Rows(0).Item(0)
                txtApellidoPaciente.Text = tablaNomApeHis.Rows(0).Item(1)
                txtNroHistorial.Text = tablaNomApeHis.Rows(0).Item(2)
            Else

            End If

        End If
        If (cmbTipoBusqueda.Text = "DOCUMENTO") Then
            If (IsNumeric(txtValorBusqueda.Text)) Then

                If (BDHelper.obtenerNroHistorialXNroDoc(txtValorBusqueda.Text).Rows.Count > 0) Then
                    tablaNomApeHis = BDHelper.obtenerNroHistorialXNroDoc(txtValorBusqueda.Text)

                    txtNombrePaciente.Text = tablaNomApeHis.Rows(0).Item(0)
                    txtApellidoPaciente.Text = tablaNomApeHis.Rows(0).Item(1)
                    txtNroHistorial.Text = tablaNomApeHis.Rows(0).Item(2)
                Else

                End If

            End If
        End If

        If (gridTratamientosXPaciente.RowCount > 1) Then
            txtNombrePaciente.Text = gridTratamientosXPaciente.CurrentRow.Cells(7).Value
            txtApellidoPaciente.Text = gridTratamientosXPaciente.CurrentRow.Cells(8).Value
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        mostrarGroupAlta()

        btnGuardar.Text = "Guardar"

    End Sub

    Private Sub cmbTratamientos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTratamientos.SelectedIndexChanged
        Dim tablaTratamientos As DataTable
        tablaTratamientos = BDHelper.leo_tabla("tratamientos")
        txtCosto.Text = tablaTratamientos.Rows(cmbTratamientos.SelectedIndex).Item("costo")
        calcularMonto()
    End Sub

    Private Sub mostrarGroupConsulta()
        grpAlta.Enabled = False
        grpAlta.Visible = False



        grpConsulta.Enabled = True
        grpConsulta.Visible = True

    End Sub

    Private Sub mostrarGroupAlta()
        grpConsulta.Enabled = False
        grpConsulta.Visible = False

        grpAlta.Enabled = True
        grpAlta.Visible = True
    End Sub


    Private Sub limpiarAlta()
        txtObservacion.Text = ""
        txtMontoTotal.Text = ""
        'cmbTratamientos.SelectedIndex = -1
        'txtCosto.Text = ""
        txtApellidoPaciente.Text = ""
        txtNombrePaciente.Text = ""
        txtNroHistorial.Text = ""

        tablaInsumosXIntervencion.Clear()
    End Sub

    Private Function validarAltaModificacion()
        Dim validar As Boolean
        If (cmbTratamientos.SelectedIndex = -1) Then
            MessageBox.Show("No se ha seleccionado ningun tipo de tratamientos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbTratamientos.Focus()
            validar = False
            Return validar
            Exit Function
        End If

        If (txtCosto.Text = "") Then
            MessageBox.Show("No se cargo ningun costo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCosto.Focus()
            validar = False
            Return validar
            Exit Function

        End If

        If (txtObservacion.Text = "") Then
            MessageBox.Show("No se cargo ninguna observacion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtObservacion.Focus()
            validar = False
            Return validar
            Exit Function

        End If

        If (txtMontoTotal.Text = "") Then
            MessageBox.Show("No se cargo el monto total", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            validar = False
            Return validar
            Exit Function
        End If
        validar = True
        Return True

    End Function

    Private Sub btnAgregarInsumo_Click(sender As Object, e As EventArgs) Handles btnAgregarInsumo.Click
        'VER INSUMOS x EL DETALLEINSUMOS PRECIO
        _variable.ElementoInsumoTabla = tablaInsumosXIntervencion.NewRow
        My.Forms.AgregarInsumo.ShowDialog()
        'ver cuando cierro el formulario y no agrego nada LISTO
        If (_variable.ElementoInsumoTabla.IsNull("cantidad") = False) Then
            For i = 0 To (gridInsumosTramientoXIntervencion.RowCount - 1)
                If (gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value = _variable.ElementoInsumoTabla.Item("id")) Then
                    MessageBox.Show("Ya se ha cargado el insumo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

            Next i
            MessageBox.Show("Se cargo el insumo con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.tablaInsumosXIntervencion.Rows.Add(_variable.ElementoInsumoTabla)
            Me.tablaInsumosXIntervencion.AcceptChanges()
        End If


        calcularMonto()
    End Sub

    Private Sub calcularMonto()

        Dim contador As Double = 0
        contador += txtCosto.Text
        For i = 0 To gridInsumosTramientoXIntervencion.RowCount - 1

            contador += (gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value * gridInsumosTramientoXIntervencion.Rows(i).Cells(3).Value)
            'MsgBox(contador)
        Next i
        txtMontoTotal.Text = contador
        contador = 0
    End Sub

    Private Sub txtValorBusqueda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorBusqueda.KeyPress
        If (cmbTipoBusqueda.Text = "DOCUMENTO") Then
            If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
                e.KeyChar = ""
                e.Handled = True
                txtValorBusqueda.Focus()
            End If
        End If

    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (gridTratamientosXPaciente.RowCount > 0) Then
            Dim yesNo = MsgBox("Esta seguro que desea borrar este tratamiento?", MsgBoxStyle.YesNo)
            If (yesNo = 7) Then
                MessageBox.Show("Se cancelo la operacion", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                BDHelper.eliminarInsumoXIntervencion(gridTratamientosXPaciente.CurrentRow.Cells(0).Value.ToString)
                BDHelper.eliminarIntervencion(gridTratamientosXPaciente.CurrentRow.Cells(0).Value.ToString)

                MessageBox.Show("Se elimino el registro con exito", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                gridTratamientosXPaciente.DataSource = BDHelper.getIntervenciones

            End If
        Else
            MsgBox("No hay ninguna intervencion...")
        End If


    End Sub



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (gridTratamientosXPaciente.RowCount > 0) Then

            txtNroHistorial.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(3).Value
            txtNombrePaciente.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(7).Value
            txtApellidoPaciente.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(8).Value



            cmbTratamientos.SelectedIndex = gridTratamientosXPaciente.CurrentRow.Cells(3).Value - 1
            txtObservacion.Text = gridTratamientosXPaciente.CurrentRow.Cells(5).Value
            txtMontoTotal.Text = gridTratamientosXPaciente.CurrentRow.Cells(6).Value

            tablaInsumosXIntervencion = BDHelper.obtenerInsumosIntervencionPaciente(gridTratamientosXPaciente.CurrentRow.Cells(0).Value)
            gridInsumosTramientoXIntervencion.DataSource = tablaInsumosXIntervencion

            btnGuardar.Text = "Modificar"
            'btnSalir.Text = "Cancelar"
            mostrarGroupAlta()
        Else
            MsgBox("no existe ninguna intervencion cargada")
        End If

    End Sub

    Private Sub btnEliminarInsumo_Click(sender As Object, e As EventArgs) Handles btnEliminarInsumo.Click
        If (gridInsumosTramientoXIntervencion.SelectedRows.Count > 0) Then
            If (tablaInsumosXIntervencion.Rows.Count > 0) Then
                tablaInsumosXIntervencion.Rows.RemoveAt(gridInsumosTramientoXIntervencion.CurrentRow.Index)
                tablaInsumosXIntervencion.AcceptChanges()

                calcularMonto()
            End If
        Else
            MsgBox("No se selecciono ningun insumo")
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (btnGuardar.Text = "Guardar") Then

            If (validarAltaModificacion()) Then
                'If (validarExistenciaAlta()) Then
                '    MsgBox("Ya existe cargado un mismo tramiento para este paciente")
                'Else
               

                'Stock
                Dim faltaInsumos As Boolean = False
                Dim puntoReposicion As String = ""
                For i = 0 To gridInsumosTramientoXIntervencion.Rows.Count - 1

                    Dim tabla As Data.DataTable = BDHelper.idInsumoStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString)
                    Dim cantidad As Integer = 0
                    cantidad = tabla.Rows(0)("cantidad")
                    If cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString < 0 Then
                        faltaInsumos = True
                    End If


                Next

                If faltaInsumos = False Then

                    BDHelper.insertarIntervencion(txtNroHistorial.Text, cmbTratamientos.SelectedValue, Date.Now.ToString("dd/MM/yyyy"), txtMontoTotal.Text, txtObservacion.Text)

                    For i = 0 To (gridInsumosTramientoXIntervencion.RowCount - 1)
                        BDHelper.insertarInsumoEnIntervencion(BDHelper.obtenerUltimoCodIntervencion(), gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value, gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value)
                    Next i

                    For i = 0 To gridInsumosTramientoXIntervencion.Rows.Count - 1

                        Dim tabla As Data.DataTable = BDHelper.idInsumoStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString)
                        Dim cantidad As Integer = 0
                        cantidad = tabla.Rows(0)("cantidad")

                        If cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString = 0 Then
                            BDHelper.modificarStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString, cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString, "COMPRAR")
                        End If

                        If cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString > 0 And cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString <= 5 Then
                            BDHelper.modificarStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString, cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString, "CRITICO")
                        End If

                        If cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString > 5 Then
                            BDHelper.modificarStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString, cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString, "NORMAL")
                        End If

                    Next
                    MessageBox.Show("El registro se ha guardado correctamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrarGroupConsulta()
                    limpiarAlta()
                    cargarBD()
                Else
                    MessageBox.Show("Algun insumo ingresado no cuenta con stock suficiente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If


        End If


        If (btnGuardar.Text = "Modificar") Then

            If (validarAltaModificacion()) Then

                Dim faltaInsumos As Boolean = False
                Dim puntoReposicion As String = ""
                For i = 0 To gridInsumosTramientoXIntervencion.Rows.Count - 1

                    Dim tabla As Data.DataTable = BDHelper.idInsumoStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString)
                    Dim cantidad As Integer = 0
                    cantidad = tabla.Rows(0)("cantidad")
                    If cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString < 0 Then
                        faltaInsumos = True
                    End If
                Next


                If faltaInsumos = False Then

                    BDHelper.modificarTratamiento(txtNroHistorial.Text, txtMontoTotal.Text, cmbTratamientos.SelectedValue, txtObservacion.Text, Date.Now.ToString("dd/MM/yyyy"), gridTratamientosXPaciente.CurrentRow.Cells(0).Value)
                    ''validar
                    BDHelper.eliminarInsumoXIntervencion(gridTratamientosXPaciente.CurrentRow.Cells(0).Value)
                    For i = 0 To (gridInsumosTramientoXIntervencion.RowCount - 1)
                        BDHelper.insertarInsumoEnIntervencion(BDHelper.obtenerUltimoCodIntervencion(), gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value, gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value)
                    Next i

                    For i = 0 To gridInsumosTramientoXIntervencion.Rows.Count - 1

                        Dim tabla As Data.DataTable = BDHelper.idInsumoStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString)
                        Dim cantidad As Integer = 0
                        cantidad = tabla.Rows(0)("cantidad")

                        If cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString = 0 Then
                            BDHelper.modificarStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString, cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString, "COMPRAR")
                        End If

                        If cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString > 0 And cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString <= 5 Then
                            BDHelper.modificarStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString, cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString, "CRITICO")
                        End If

                        If cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString > 5 Then
                            BDHelper.modificarStock(gridInsumosTramientoXIntervencion.Rows(i).Cells(0).Value.ToString, cantidad - gridInsumosTramientoXIntervencion.Rows(i).Cells(2).Value.ToString, "NORMAL")
                        End If

                    Next
                    MessageBox.Show("El registro se ha modificado correctamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrarGroupConsulta()
                    limpiarAlta()
                    cargarBD()
                Else
                    MessageBox.Show("Algun insumo ingresado no cuenta con stock suficiente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If

        End If

    End Sub

    Private Function validarExistenciaAlta() As Boolean
        If (BDHelper.verificarExistenciaTratamiento(cmbTratamientos.SelectedValue) = 1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        mostrarGroupConsulta()
        limpiarAlta()

    End Sub

    Private Sub gridTratamientosXPaciente_DoubleClick(sender As Object, e As EventArgs) Handles gridTratamientosXPaciente.DoubleClick
        If (gridTratamientosXPaciente.RowCount > 0) Then


            txtNroHistorial.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(3).Value
            txtNombrePaciente.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(7).Value
            txtApellidoPaciente.Text = gridTratamientosXPaciente.Rows(gridTratamientosXPaciente.CurrentRow.Index).Cells(8).Value




            cmbTratamientos.SelectedIndex = gridTratamientosXPaciente.CurrentRow.Cells(3).Value - 1
            txtObservacion.Text = gridTratamientosXPaciente.CurrentRow.Cells(5).Value
            txtMontoTotal.Text = gridTratamientosXPaciente.CurrentRow.Cells(6).Value

            tablaInsumosXIntervencion = BDHelper.obtenerInsumosIntervencionPaciente(gridTratamientosXPaciente.CurrentRow.Cells(0).Value)
            gridInsumosTramientoXIntervencion.DataSource = tablaInsumosXIntervencion

            btnGuardar.Text = "Modificar"
            'btnSalir.Text = "Cancelar"
            mostrarGroupAlta()
        Else
            MsgBox("No hay cargado una intervencion")
        End If


    End Sub


    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        frmMostrarPacientes.ShowDialog()
        txtValorBusqueda.Text = _variable.valorBusqueda
        cmbTipoBusqueda.SelectedIndex = 0
        btnBuscar.PerformClick()
    End Sub

    Private Sub cmbTipoBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoBusqueda.SelectedIndexChanged
        txtValorBusqueda.Text = ""
    End Sub


    Private Sub btnVerStock_Click(sender As Object, e As EventArgs) Handles btnVerStock.Click
        frmRegistrarStock.ShowDialog()
    End Sub

    Private Sub txtApellidoPaciente_TextChanged(sender As Object, e As EventArgs) Handles txtApellidoPaciente.TextChanged

    End Sub

    Private Sub txtValorBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtValorBusqueda.TextChanged

    End Sub

    Private Sub grpAlta_Enter(sender As Object, e As EventArgs) Handles grpAlta.Enter

    End Sub
End Class