<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarProveedor))
        Me.saveImagen = New System.Windows.Forms.OpenFileDialog()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.grp_Proveedor = New System.Windows.Forms.GroupBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.grp_Datos = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIDProveedor = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.GroupBox()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.dgv_proveedores = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmb_Buscador = New System.Windows.Forms.ComboBox()
        Me.grp_Inicio = New System.Windows.Forms.GroupBox()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdPuerta = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.grp_Proveedor.SuspendLayout()
        Me.grp_Datos.SuspendLayout()
        Me.lblDomicilio.SuspendLayout()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Inicio.SuspendLayout()
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
        'grp_Proveedor
        '
        Me.grp_Proveedor.Controls.Add(Me.btn_Cancelar)
        Me.grp_Proveedor.Controls.Add(Me.btn_Aceptar)
        Me.grp_Proveedor.Controls.Add(Me.grp_Datos)
        Me.grp_Proveedor.Controls.Add(Me.lblDomicilio)
        Me.grp_Proveedor.Location = New System.Drawing.Point(3, 60)
        Me.grp_Proveedor.Name = "grp_Proveedor"
        Me.grp_Proveedor.Size = New System.Drawing.Size(487, 445)
        Me.grp_Proveedor.TabIndex = 54
        Me.grp_Proveedor.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(218, 385)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(63, 23)
        Me.btn_Cancelar.TabIndex = 0
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(94, 385)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(67, 23)
        Me.btn_Aceptar.TabIndex = 0
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'grp_Datos
        '
        Me.grp_Datos.Controls.Add(Me.lblID)
        Me.grp_Datos.Controls.Add(Me.lblIDProveedor)
        Me.grp_Datos.Controls.Add(Me.txtTelefono)
        Me.grp_Datos.Controls.Add(Me.Label2)
        Me.grp_Datos.Controls.Add(Me.txtMail)
        Me.grp_Datos.Controls.Add(Me.Label1)
        Me.grp_Datos.Controls.Add(Me.txtResponsable)
        Me.grp_Datos.Controls.Add(Me.txtNombre)
        Me.grp_Datos.Controls.Add(Me.lblTipoDocumento)
        Me.grp_Datos.Controls.Add(Me.lblNombre)
        Me.grp_Datos.Location = New System.Drawing.Point(15, 19)
        Me.grp_Datos.Name = "grp_Datos"
        Me.grp_Datos.Size = New System.Drawing.Size(405, 188)
        Me.grp_Datos.TabIndex = 53
        Me.grp_Datos.TabStop = False
        Me.grp_Datos.Text = "Datos Personales"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(154, 17)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(44, 13)
        Me.lblID.TabIndex = 57
        Me.lblID.Text = "Numero"
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.AutoSize = True
        Me.lblIDProveedor.Location = New System.Drawing.Point(102, 17)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(18, 13)
        Me.lblIDProveedor.TabIndex = 56
        Me.lblIDProveedor.Text = "ID"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(148, 119)
        Me.txtTelefono.MaxLength = 15
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(201, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Mail"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(148, 156)
        Me.txtMail.MaxLength = 50
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(201, 20)
        Me.txtMail.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Nombre del responsable *"
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(148, 86)
        Me.txtResponsable.MaxLength = 50
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(201, 20)
        Me.txtResponsable.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(148, 49)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(201, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(81, 122)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(49, 13)
        Me.lblTipoDocumento.TabIndex = 0
        Me.lblTipoDocumento.Text = "Telefono"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(15, 54)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(119, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre del proveedor *"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblDomicilio.Controls.Add(Me.cboLocalidad)
        Me.lblDomicilio.Controls.Add(Me.lblLocalidad)
        Me.lblDomicilio.Controls.Add(Me.txtDepartamento)
        Me.lblDomicilio.Controls.Add(Me.txtPiso)
        Me.lblDomicilio.Controls.Add(Me.txtNumero)
        Me.lblDomicilio.Controls.Add(Me.txtCalle)
        Me.lblDomicilio.Controls.Add(Me.lblPiso)
        Me.lblDomicilio.Controls.Add(Me.lblDepartamento)
        Me.lblDomicilio.Controls.Add(Me.lblNumero)
        Me.lblDomicilio.Controls.Add(Me.lblCalle)
        Me.lblDomicilio.Location = New System.Drawing.Point(15, 213)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(405, 161)
        Me.lblDomicilio.TabIndex = 0
        Me.lblDomicilio.TabStop = False
        Me.lblDomicilio.Text = "Domicilio"
        '
        'cboLocalidad
        '
        Me.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Items.AddRange(New Object() {"Córdoba"})
        Me.cboLocalidad.Location = New System.Drawing.Point(79, 128)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(135, 21)
        Me.cboLocalidad.TabIndex = 9
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(10, 136)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(60, 13)
        Me.lblLocalidad.TabIndex = 16
        Me.lblLocalidad.Text = "Localidad *"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(174, 93)
        Me.txtDepartamento.MaxLength = 5
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(75, 20)
        Me.txtDepartamento.TabIndex = 8
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(56, 90)
        Me.txtPiso.MaxLength = 3
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(50, 20)
        Me.txtPiso.TabIndex = 7
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(293, 38)
        Me.txtNumero.MaxLength = 6
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(75, 20)
        Me.txtNumero.TabIndex = 6
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(56, 38)
        Me.txtCalle.MaxLength = 50
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(164, 20)
        Me.txtCalle.TabIndex = 5
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Location = New System.Drawing.Point(10, 93)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(30, 13)
        Me.lblPiso.TabIndex = 0
        Me.lblPiso.Text = "Piso:"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(129, 93)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(39, 13)
        Me.lblDepartamento.TabIndex = 0
        Me.lblDepartamento.Text = "Depto:"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(244, 41)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(31, 13)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Nro *"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(7, 38)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(37, 13)
        Me.lblCalle.TabIndex = 0
        Me.lblCalle.Text = "Calle *"
        '
        'dgv_proveedores
        '
        Me.dgv_proveedores.AllowUserToAddRows = False
        Me.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedores.Location = New System.Drawing.Point(25, 96)
        Me.dgv_proveedores.Name = "dgv_proveedores"
        Me.dgv_proveedores.ReadOnly = True
        Me.dgv_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_proveedores.Size = New System.Drawing.Size(449, 349)
        Me.dgv_proveedores.TabIndex = 55
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
        Me.cmb_Buscador.Items.AddRange(New Object() {"Nombre Proveedor", "Nombre Responsable"})
        Me.cmb_Buscador.Location = New System.Drawing.Point(234, 27)
        Me.cmb_Buscador.Name = "cmb_Buscador"
        Me.cmb_Buscador.Size = New System.Drawing.Size(134, 21)
        Me.cmb_Buscador.TabIndex = 57
        '
        'grp_Inicio
        '
        Me.grp_Inicio.Controls.Add(Me.btn_Actualizar)
        Me.grp_Inicio.Controls.Add(Me.txtBuscar)
        Me.grp_Inicio.Controls.Add(Me.cmd_Buscar)
        Me.grp_Inicio.Controls.Add(Me.cmb_Buscador)
        Me.grp_Inicio.Controls.Add(Me.dgv_proveedores)
        Me.grp_Inicio.Location = New System.Drawing.Point(16, 60)
        Me.grp_Inicio.Name = "grp_Inicio"
        Me.grp_Inicio.Size = New System.Drawing.Size(505, 468)
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
        Me.cmdModificar.Location = New System.Drawing.Point(112, 546)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(42, 36)
        Me.cmdModificar.TabIndex = 52
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.CANCELAR1
        Me.cmdEliminar.Location = New System.Drawing.Point(249, 546)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(42, 36)
        Me.cmdEliminar.TabIndex = 47
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdPuerta
        '
        Me.cmdPuerta.Image = CType(resources.GetObject("cmdPuerta.Image"), System.Drawing.Image)
        Me.cmdPuerta.Location = New System.Drawing.Point(508, 546)
        Me.cmdPuerta.Name = "cmdPuerta"
        Me.cmdPuerta.Size = New System.Drawing.Size(39, 36)
        Me.cmdPuerta.TabIndex = 16
        Me.cmdPuerta.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(16, 546)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(33, 36)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'frmRegistrarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(559, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdPuerta)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.grp_Proveedor)
        Me.Controls.Add(Me.grp_Inicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistrarProveedor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Consultorio Odontológico-Registrar Proveedor"
        Me.grp_Proveedor.ResumeLayout(False)
        Me.grp_Datos.ResumeLayout(False)
        Me.grp_Datos.PerformLayout()
        Me.lblDomicilio.ResumeLayout(False)
        Me.lblDomicilio.PerformLayout()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Inicio.ResumeLayout(False)
        Me.grp_Inicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdPuerta As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents cmdModificar As Button
    Friend WithEvents grp_Proveedor As GroupBox
    Friend WithEvents dgv_proveedores As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cmb_Buscador As ComboBox
    Friend WithEvents btn_Actualizar As Button
    Friend WithEvents grp_Inicio As GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents grp_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents txtDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents txtPiso As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblPiso As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblIDProveedor As System.Windows.Forms.Label
End Class
