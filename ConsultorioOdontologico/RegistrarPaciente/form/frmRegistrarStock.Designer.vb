<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarStock
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarStock))
        Me.saveImagen = New System.Windows.Forms.OpenFileDialog()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dgv_stock = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmb_Buscador = New System.Windows.Forms.ComboBox()
        Me.grp_Inicio = New System.Windows.Forms.GroupBox()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdPuerta = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.grp_Datos = New System.Windows.Forms.GroupBox()
        Me.CboInsumo = New System.Windows.Forms.ComboBox()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblInsumo = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grp_Stock = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Inicio.SuspendLayout()
        Me.grp_Datos.SuspendLayout()
        Me.grp_Stock.SuspendLayout()
        Me.SuspendLayout()
        '
        'saveImagen
        '
        Me.saveImagen.FileName = "saveImagen"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(470, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 43
        Me.lblHora.Text = "Hora"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(358, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 42
        Me.lblFecha.Text = "Fecha"
        '
        'dgv_stock
        '
        Me.dgv_stock.AllowUserToAddRows = False
        Me.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stock.Location = New System.Drawing.Point(25, 96)
        Me.dgv_stock.Name = "dgv_stock"
        Me.dgv_stock.ReadOnly = True
        Me.dgv_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_stock.Size = New System.Drawing.Size(449, 215)
        Me.dgv_stock.TabIndex = 55
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(25, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(192, 20)
        Me.txtBuscar.TabIndex = 56
        '
        'cmb_Buscador
        '
        Me.cmb_Buscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Buscador.FormattingEnabled = True
        Me.cmb_Buscador.Items.AddRange(New Object() {"Insumo", "Criticidad"})
        Me.cmb_Buscador.Location = New System.Drawing.Point(234, 27)
        Me.cmb_Buscador.Name = "cmb_Buscador"
        Me.cmb_Buscador.Size = New System.Drawing.Size(138, 21)
        Me.cmb_Buscador.TabIndex = 57
        '
        'grp_Inicio
        '
        Me.grp_Inicio.Controls.Add(Me.dgv_stock)
        Me.grp_Inicio.Controls.Add(Me.btn_Actualizar)
        Me.grp_Inicio.Controls.Add(Me.txtBuscar)
        Me.grp_Inicio.Controls.Add(Me.cmd_Buscar)
        Me.grp_Inicio.Controls.Add(Me.cmb_Buscador)
        Me.grp_Inicio.Location = New System.Drawing.Point(16, 60)
        Me.grp_Inicio.Name = "grp_Inicio"
        Me.grp_Inicio.Size = New System.Drawing.Size(505, 330)
        Me.grp_Inicio.TabIndex = 59
        Me.grp_Inicio.TabStop = False
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
        'cmd_Buscar
        '
        Me.cmd_Buscar.Image = CType(resources.GetObject("cmd_Buscar.Image"), System.Drawing.Image)
        Me.cmd_Buscar.Location = New System.Drawing.Point(378, 20)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(50, 45)
        Me.cmd_Buscar.TabIndex = 48
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModificar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.modificar1
        Me.cmdModificar.Location = New System.Drawing.Point(155, 410)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(42, 36)
        Me.cmdModificar.TabIndex = 52
        Me.cmdModificar.UseVisualStyleBackColor = False
        Me.cmdModificar.Visible = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.CANCELAR1
        Me.cmdEliminar.Location = New System.Drawing.Point(335, 410)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(42, 36)
        Me.cmdEliminar.TabIndex = 47
        Me.cmdEliminar.UseVisualStyleBackColor = True
        Me.cmdEliminar.Visible = False
        '
        'cmdPuerta
        '
        Me.cmdPuerta.Image = CType(resources.GetObject("cmdPuerta.Image"), System.Drawing.Image)
        Me.cmdPuerta.Location = New System.Drawing.Point(461, 410)
        Me.cmdPuerta.Name = "cmdPuerta"
        Me.cmdPuerta.Size = New System.Drawing.Size(39, 36)
        Me.cmdPuerta.TabIndex = 16
        Me.cmdPuerta.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(41, 410)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(33, 36)
        Me.cmdNuevo.TabIndex = 15
        Me.cmdNuevo.UseVisualStyleBackColor = True
        Me.cmdNuevo.Visible = False
        '
        'grp_Datos
        '
        Me.grp_Datos.Controls.Add(Me.CboInsumo)
        Me.grp_Datos.Controls.Add(Me.cboProveedor)
        Me.grp_Datos.Controls.Add(Me.txtCantidad)
        Me.grp_Datos.Controls.Add(Me.lblInsumo)
        Me.grp_Datos.Controls.Add(Me.lblCantidad)
        Me.grp_Datos.Controls.Add(Me.lblProveedor)
        Me.grp_Datos.Location = New System.Drawing.Point(10, 28)
        Me.grp_Datos.Name = "grp_Datos"
        Me.grp_Datos.Size = New System.Drawing.Size(405, 203)
        Me.grp_Datos.TabIndex = 56
        Me.grp_Datos.TabStop = False
        Me.grp_Datos.Text = "Stock"
        '
        'CboInsumo
        '
        Me.CboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInsumo.FormattingEnabled = True
        Me.CboInsumo.Location = New System.Drawing.Point(148, 64)
        Me.CboInsumo.Name = "CboInsumo"
        Me.CboInsumo.Size = New System.Drawing.Size(201, 21)
        Me.CboInsumo.TabIndex = 57
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(148, 27)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(201, 21)
        Me.cboProveedor.TabIndex = 56
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(148, 97)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(201, 20)
        Me.txtCantidad.TabIndex = 55
        '
        'lblInsumo
        '
        Me.lblInsumo.AutoSize = True
        Me.lblInsumo.Location = New System.Drawing.Point(89, 67)
        Me.lblInsumo.Name = "lblInsumo"
        Me.lblInsumo.Size = New System.Drawing.Size(41, 13)
        Me.lblInsumo.TabIndex = 52
        Me.lblInsumo.Text = "Insumo"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(81, 100)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 0
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(76, 30)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProveedor.TabIndex = 0
        Me.lblProveedor.Text = "Proveedor"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(123, 249)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(67, 23)
        Me.btnAceptar.TabIndex = 57
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(234, 249)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(63, 23)
        Me.btnCancelar.TabIndex = 58
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grp_Stock
        '
        Me.grp_Stock.Controls.Add(Me.btnCancelar)
        Me.grp_Stock.Controls.Add(Me.btnAceptar)
        Me.grp_Stock.Controls.Add(Me.grp_Datos)
        Me.grp_Stock.Location = New System.Drawing.Point(32, 51)
        Me.grp_Stock.Name = "grp_Stock"
        Me.grp_Stock.Size = New System.Drawing.Size(468, 353)
        Me.grp_Stock.TabIndex = 59
        Me.grp_Stock.TabStop = False
        '
        'frmRegistrarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(538, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdPuerta)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.grp_Inicio)
        Me.Controls.Add(Me.grp_Stock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistrarStock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Consultorio Odontológico-Registrar Stock"
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Inicio.ResumeLayout(False)
        Me.grp_Inicio.PerformLayout()
        Me.grp_Datos.ResumeLayout(False)
        Me.grp_Datos.PerformLayout()
        Me.grp_Stock.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdPuerta As System.Windows.Forms.Button
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents dgv_stock As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cmb_Buscador As ComboBox
    Friend WithEvents btn_Actualizar As Button
    Friend WithEvents grp_Inicio As GroupBox
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents grp_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents CboInsumo As System.Windows.Forms.ComboBox
    Friend WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblInsumo As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents grp_Stock As System.Windows.Forms.GroupBox
End Class
