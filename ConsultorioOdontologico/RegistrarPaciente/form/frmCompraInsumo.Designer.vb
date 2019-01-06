<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompraInsumo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraInsumo))
        Me.grp_Stock = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.grp_Datos = New System.Windows.Forms.GroupBox()
        Me.btnVerStock = New System.Windows.Forms.Button()
        Me.lblMontoTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFechaC = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaC = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvInsumos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CboInsumo = New System.Windows.Forms.ComboBox()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblInsumo = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.grp_Inicio = New System.Windows.Forms.GroupBox()
        Me.dgv_compra = New System.Windows.Forms.DataGridView()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.cmb_Buscador = New System.Windows.Forms.ComboBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdPuerta = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grp_Stock.SuspendLayout()
        Me.grp_Datos.SuspendLayout()
        CType(Me.dgvInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Inicio.SuspendLayout()
        CType(Me.dgv_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Stock
        '
        Me.grp_Stock.Controls.Add(Me.btnCancelar)
        Me.grp_Stock.Controls.Add(Me.btnAceptar)
        Me.grp_Stock.Controls.Add(Me.grp_Datos)
        Me.grp_Stock.Location = New System.Drawing.Point(26, 25)
        Me.grp_Stock.Name = "grp_Stock"
        Me.grp_Stock.Size = New System.Drawing.Size(483, 372)
        Me.grp_Stock.TabIndex = 60
        Me.grp_Stock.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(231, 329)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(63, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(120, 329)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(67, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'grp_Datos
        '
        Me.grp_Datos.Controls.Add(Me.btnVerStock)
        Me.grp_Datos.Controls.Add(Me.lblMontoTotal)
        Me.grp_Datos.Controls.Add(Me.Label2)
        Me.grp_Datos.Controls.Add(Me.txtPrecioUnitario)
        Me.grp_Datos.Controls.Add(Me.Label1)
        Me.grp_Datos.Controls.Add(Me.txtFechaC)
        Me.grp_Datos.Controls.Add(Me.lblFechaC)
        Me.grp_Datos.Controls.Add(Me.btnQuitar)
        Me.grp_Datos.Controls.Add(Me.btnAgregar)
        Me.grp_Datos.Controls.Add(Me.dgvInsumos)
        Me.grp_Datos.Controls.Add(Me.CboInsumo)
        Me.grp_Datos.Controls.Add(Me.cboProveedor)
        Me.grp_Datos.Controls.Add(Me.txtCantidad)
        Me.grp_Datos.Controls.Add(Me.lblInsumo)
        Me.grp_Datos.Controls.Add(Me.lblCantidad)
        Me.grp_Datos.Controls.Add(Me.lblProveedor)
        Me.grp_Datos.Location = New System.Drawing.Point(9, 10)
        Me.grp_Datos.Name = "grp_Datos"
        Me.grp_Datos.Size = New System.Drawing.Size(459, 313)
        Me.grp_Datos.TabIndex = 56
        Me.grp_Datos.TabStop = False
        Me.grp_Datos.Text = "Compra Insumo"
        '
        'btnVerStock
        '
        Me.btnVerStock.Location = New System.Drawing.Point(222, 277)
        Me.btnVerStock.Name = "btnVerStock"
        Me.btnVerStock.Size = New System.Drawing.Size(71, 29)
        Me.btnVerStock.TabIndex = 67
        Me.btnVerStock.Text = "Ver Stock"
        Me.btnVerStock.UseVisualStyleBackColor = True
        '
        'lblMontoTotal
        '
        Me.lblMontoTotal.Location = New System.Drawing.Point(350, 282)
        Me.lblMontoTotal.Name = "lblMontoTotal"
        Me.lblMontoTotal.ReadOnly = True
        Me.lblMontoTotal.Size = New System.Drawing.Size(44, 20)
        Me.lblMontoTotal.TabIndex = 66
        Me.lblMontoTotal.Text = "0"
        Me.lblMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Monto:"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(148, 116)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(65, 20)
        Me.txtPrecioUnitario.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Precio Unitario"
        '
        'txtFechaC
        '
        Me.txtFechaC.Location = New System.Drawing.Point(148, 55)
        Me.txtFechaC.Name = "txtFechaC"
        Me.txtFechaC.Size = New System.Drawing.Size(199, 20)
        Me.txtFechaC.TabIndex = 2
        '
        'lblFechaC
        '
        Me.lblFechaC.AutoSize = True
        Me.lblFechaC.Location = New System.Drawing.Point(89, 62)
        Me.lblFechaC.Name = "lblFechaC"
        Me.lblFechaC.Size = New System.Drawing.Size(37, 13)
        Me.lblFechaC.TabIndex = 61
        Me.lblFechaC.Text = "Fecha"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(353, 161)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(67, 23)
        Me.btnQuitar.TabIndex = 7
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(270, 161)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(67, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvInsumos
        '
        Me.dgvInsumos.AllowUserToAddRows = False
        Me.dgvInsumos.AllowUserToDeleteRows = False
        Me.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInsumos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.cantidad, Me.precioUnitario})
        Me.dgvInsumos.Location = New System.Drawing.Point(48, 190)
        Me.dgvInsumos.Name = "dgvInsumos"
        Me.dgvInsumos.ReadOnly = True
        Me.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInsumos.Size = New System.Drawing.Size(385, 83)
        Me.dgvInsumos.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "Insumo"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precioUnitario
        '
        Me.precioUnitario.HeaderText = "Precio Unitario"
        Me.precioUnitario.Name = "precioUnitario"
        Me.precioUnitario.ReadOnly = True
        '
        'CboInsumo
        '
        Me.CboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInsumo.FormattingEnabled = True
        Me.CboInsumo.Location = New System.Drawing.Point(148, 85)
        Me.CboInsumo.Name = "CboInsumo"
        Me.CboInsumo.Size = New System.Drawing.Size(199, 21)
        Me.CboInsumo.TabIndex = 3
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(148, 27)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(199, 21)
        Me.cboProveedor.TabIndex = 1
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(148, 142)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(65, 20)
        Me.txtCantidad.TabIndex = 5
        '
        'lblInsumo
        '
        Me.lblInsumo.AutoSize = True
        Me.lblInsumo.Location = New System.Drawing.Point(89, 88)
        Me.lblInsumo.Name = "lblInsumo"
        Me.lblInsumo.Size = New System.Drawing.Size(41, 13)
        Me.lblInsumo.TabIndex = 52
        Me.lblInsumo.Text = "Insumo"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(81, 142)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 0
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(75, 31)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProveedor.TabIndex = 0
        Me.lblProveedor.Text = "Proveedor"
        '
        'grp_Inicio
        '
        Me.grp_Inicio.Controls.Add(Me.Label4)
        Me.grp_Inicio.Controls.Add(Me.dgv_compra)
        Me.grp_Inicio.Controls.Add(Me.btn_Actualizar)
        Me.grp_Inicio.Controls.Add(Me.txtBuscar)
        Me.grp_Inicio.Controls.Add(Me.cmd_Buscar)
        Me.grp_Inicio.Controls.Add(Me.cmb_Buscador)
        Me.grp_Inicio.Location = New System.Drawing.Point(10, 53)
        Me.grp_Inicio.Name = "grp_Inicio"
        Me.grp_Inicio.Size = New System.Drawing.Size(505, 330)
        Me.grp_Inicio.TabIndex = 61
        Me.grp_Inicio.TabStop = False
        '
        'dgv_compra
        '
        Me.dgv_compra.AllowUserToAddRows = False
        Me.dgv_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_compra.Location = New System.Drawing.Point(25, 96)
        Me.dgv_compra.Name = "dgv_compra"
        Me.dgv_compra.ReadOnly = True
        Me.dgv_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_compra.Size = New System.Drawing.Size(449, 215)
        Me.dgv_compra.TabIndex = 55
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.actualizar1
        Me.btn_Actualizar.Location = New System.Drawing.Point(434, 20)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(50, 44)
        Me.btn_Actualizar.TabIndex = 58
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(25, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(192, 20)
        Me.txtBuscar.TabIndex = 56
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Image = CType(resources.GetObject("cmd_Buscar.Image"), System.Drawing.Image)
        Me.cmd_Buscar.Location = New System.Drawing.Point(378, 20)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(50, 45)
        Me.cmd_Buscar.TabIndex = 48
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'cmb_Buscador
        '
        Me.cmb_Buscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Buscador.FormattingEnabled = True
        Me.cmb_Buscador.Items.AddRange(New Object() {"CODIGO PROVEEDOR", "NOMBRE PROVEEDOR", "FECHA COMPRA"})
        Me.cmb_Buscador.Location = New System.Drawing.Point(234, 27)
        Me.cmb_Buscador.Name = "cmb_Buscador"
        Me.cmb_Buscador.Size = New System.Drawing.Size(138, 21)
        Me.cmb_Buscador.TabIndex = 57
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(464, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 63
        Me.lblHora.Text = "Hora"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(352, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 62
        Me.lblFecha.Text = "Fecha"
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModificar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.modificar1
        Me.cmdModificar.Location = New System.Drawing.Point(140, 412)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(42, 36)
        Me.cmdModificar.TabIndex = 67
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.CANCELAR1
        Me.cmdEliminar.Location = New System.Drawing.Point(320, 412)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(42, 36)
        Me.cmdEliminar.TabIndex = 66
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdPuerta
        '
        Me.cmdPuerta.Image = CType(resources.GetObject("cmdPuerta.Image"), System.Drawing.Image)
        Me.cmdPuerta.Location = New System.Drawing.Point(446, 412)
        Me.cmdPuerta.Name = "cmdPuerta"
        Me.cmdPuerta.Size = New System.Drawing.Size(39, 36)
        Me.cmdPuerta.TabIndex = 65
        Me.cmdPuerta.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(26, 412)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(33, 36)
        Me.cmdNuevo.TabIndex = 64
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "* Fecha en formato aaaa-mm-dd"
        '
        'frmCompraInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(524, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdPuerta)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.grp_Inicio)
        Me.Controls.Add(Me.grp_Stock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompraInsumo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCompraInsumo"
        Me.grp_Stock.ResumeLayout(False)
        Me.grp_Datos.ResumeLayout(False)
        Me.grp_Datos.PerformLayout()
        CType(Me.dgvInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Inicio.ResumeLayout(False)
        Me.grp_Inicio.PerformLayout()
        CType(Me.dgv_compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_Stock As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents grp_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvInsumos As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CboInsumo As System.Windows.Forms.ComboBox
    Friend WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblInsumo As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents grp_Inicio As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_compra As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_Buscador As System.Windows.Forms.ComboBox
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdPuerta As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents txtPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFechaC As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaC As System.Windows.Forms.Label
    Friend WithEvents precioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMontoTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnVerStock As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
