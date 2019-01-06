<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarPaciente))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.saveImagen = New System.Windows.Forms.OpenFileDialog()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.lblDomicilio = New System.Windows.Forms.GroupBox()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.grp_Datos = New System.Windows.Forms.GroupBox()
        Me.txtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_CodigoPaciente = New System.Windows.Forms.Label()
        Me.grp_Paciente = New System.Windows.Forms.GroupBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_IngresarDatos = New System.Windows.Forms.TextBox()
        Me.cmb_Buscador = New System.Windows.Forms.ComboBox()
        Me.grp_Inicio = New System.Windows.Forms.GroupBox()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdPuerta = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.lblDomicilio.SuspendLayout()
        Me.grp_Datos.SuspendLayout()
        Me.grp_Paciente.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Inicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(55, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre *"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(58, 67)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(51, 13)
        Me.lblApellido.TabIndex = 0
        Me.lblApellido.Text = "Apellido *"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(9, 101)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(100, 13)
        Me.lblFechaNacimiento.TabIndex = 0
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento *"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(18, 139)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(93, 13)
        Me.lblTipoDocumento.TabIndex = 0
        Me.lblTipoDocumento.Text = "Tipo Documento *"
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(22, 170)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(89, 13)
        Me.lblNroDocumento.TabIndex = 0
        Me.lblNroDocumento.Text = "Nro Documento *"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(120, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(201, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(120, 60)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(201, 20)
        Me.txtApellido.TabIndex = 2
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoCompleteCustomSource.AddRange(New String() {"DNI"})
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Items.AddRange(New Object() {"DNI"})
        Me.cboTipoDocumento.Location = New System.Drawing.Point(120, 131)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoDocumento.TabIndex = 4
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(120, 167)
        Me.txtNroDocumento.MaxLength = 8
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtNroDocumento.TabIndex = 5
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
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(7, 38)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(37, 13)
        Me.lblCalle.TabIndex = 0
        Me.lblCalle.Text = "Calle *"
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
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(129, 93)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(39, 13)
        Me.lblDepartamento.TabIndex = 0
        Me.lblDepartamento.Text = "Depto:"
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
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(56, 38)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(164, 20)
        Me.txtCalle.TabIndex = 7
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(293, 38)
        Me.txtNumero.MaxLength = 5
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(75, 20)
        Me.txtNumero.TabIndex = 8
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(56, 90)
        Me.txtPiso.MaxLength = 3
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(50, 20)
        Me.txtPiso.TabIndex = 9
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(174, 93)
        Me.txtDepartamento.MaxLength = 4
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(75, 20)
        Me.txtDepartamento.TabIndex = 10
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(11, 184)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(73, 181)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(95, 20)
        Me.txtTelefono.TabIndex = 12
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(268, 181)
        Me.txtCelular.MaxLength = 20
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(95, 20)
        Me.txtCelular.TabIndex = 13
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(206, 184)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 15
        Me.lblCelular.Text = "Celular"
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
        'cboLocalidad
        '
        Me.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Items.AddRange(New Object() {"Córdoba"})
        Me.cboLocalidad.Location = New System.Drawing.Point(79, 128)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(135, 21)
        Me.cboLocalidad.TabIndex = 11
        '
        'lblDomicilio
        '
        Me.lblDomicilio.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblDomicilio.Controls.Add(Me.cboLocalidad)
        Me.lblDomicilio.Controls.Add(Me.lblLocalidad)
        Me.lblDomicilio.Controls.Add(Me.lblCelular)
        Me.lblDomicilio.Controls.Add(Me.txtCelular)
        Me.lblDomicilio.Controls.Add(Me.txtTelefono)
        Me.lblDomicilio.Controls.Add(Me.lblTelefono)
        Me.lblDomicilio.Controls.Add(Me.txtDepartamento)
        Me.lblDomicilio.Controls.Add(Me.txtPiso)
        Me.lblDomicilio.Controls.Add(Me.txtNumero)
        Me.lblDomicilio.Controls.Add(Me.txtCalle)
        Me.lblDomicilio.Controls.Add(Me.lblPiso)
        Me.lblDomicilio.Controls.Add(Me.lblDepartamento)
        Me.lblDomicilio.Controls.Add(Me.lblNumero)
        Me.lblDomicilio.Controls.Add(Me.lblCalle)
        Me.lblDomicilio.Location = New System.Drawing.Point(15, 258)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(405, 222)
        Me.lblDomicilio.TabIndex = 6
        Me.lblDomicilio.TabStop = False
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblHistorial
        '
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.Location = New System.Drawing.Point(47, 206)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(64, 13)
        Me.lblHistorial.TabIndex = 50
        Me.lblHistorial.Text = "Nro Historial"
        '
        'grp_Datos
        '
        Me.grp_Datos.Controls.Add(Me.txtFechaNacimiento)
        Me.grp_Datos.Controls.Add(Me.lbl_CodigoPaciente)
        Me.grp_Datos.Controls.Add(Me.lblHistorial)
        Me.grp_Datos.Controls.Add(Me.txtNroDocumento)
        Me.grp_Datos.Controls.Add(Me.cboTipoDocumento)
        Me.grp_Datos.Controls.Add(Me.txtApellido)
        Me.grp_Datos.Controls.Add(Me.txtNombre)
        Me.grp_Datos.Controls.Add(Me.lblNroDocumento)
        Me.grp_Datos.Controls.Add(Me.lblTipoDocumento)
        Me.grp_Datos.Controls.Add(Me.lblFechaNacimiento)
        Me.grp_Datos.Controls.Add(Me.lblApellido)
        Me.grp_Datos.Controls.Add(Me.lblNombre)
        Me.grp_Datos.Location = New System.Drawing.Point(15, 19)
        Me.grp_Datos.Name = "grp_Datos"
        Me.grp_Datos.Size = New System.Drawing.Size(325, 233)
        Me.grp_Datos.TabIndex = 53
        Me.grp_Datos.TabStop = False
        Me.grp_Datos.Text = "Datos Personales"
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(122, 97)
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(198, 20)
        Me.txtFechaNacimiento.TabIndex = 52
        '
        'lbl_CodigoPaciente
        '
        Me.lbl_CodigoPaciente.AutoSize = True
        Me.lbl_CodigoPaciente.Location = New System.Drawing.Point(121, 206)
        Me.lbl_CodigoPaciente.Name = "lbl_CodigoPaciente"
        Me.lbl_CodigoPaciente.Size = New System.Drawing.Size(25, 13)
        Me.lbl_CodigoPaciente.TabIndex = 51
        Me.lbl_CodigoPaciente.Text = "100"
        '
        'grp_Paciente
        '
        Me.grp_Paciente.Controls.Add(Me.btn_Cancelar)
        Me.grp_Paciente.Controls.Add(Me.btn_Aceptar)
        Me.grp_Paciente.Controls.Add(Me.grp_Datos)
        Me.grp_Paciente.Controls.Add(Me.lblDomicilio)
        Me.grp_Paciente.Location = New System.Drawing.Point(10, 25)
        Me.grp_Paciente.Name = "grp_Paciente"
        Me.grp_Paciente.Size = New System.Drawing.Size(434, 515)
        Me.grp_Paciente.TabIndex = 54
        Me.grp_Paciente.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(218, 486)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(63, 23)
        Me.btn_Cancelar.TabIndex = 55
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(94, 486)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(67, 23)
        Me.btn_Aceptar.TabIndex = 54
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(449, 349)
        Me.DataGridView1.TabIndex = 55
        '
        'txt_IngresarDatos
        '
        Me.txt_IngresarDatos.Location = New System.Drawing.Point(25, 28)
        Me.txt_IngresarDatos.Name = "txt_IngresarDatos"
        Me.txt_IngresarDatos.Size = New System.Drawing.Size(192, 20)
        Me.txt_IngresarDatos.TabIndex = 56
        '
        'cmb_Buscador
        '
        Me.cmb_Buscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Buscador.FormattingEnabled = True
        Me.cmb_Buscador.Items.AddRange(New Object() {"Nombre", "Apellido", "Documento"})
        Me.cmb_Buscador.Location = New System.Drawing.Point(234, 27)
        Me.cmb_Buscador.Name = "cmb_Buscador"
        Me.cmb_Buscador.Size = New System.Drawing.Size(134, 21)
        Me.cmb_Buscador.TabIndex = 57
        '
        'grp_Inicio
        '
        Me.grp_Inicio.Controls.Add(Me.DataGridView1)
        Me.grp_Inicio.Controls.Add(Me.btn_Actualizar)
        Me.grp_Inicio.Controls.Add(Me.txt_IngresarDatos)
        Me.grp_Inicio.Controls.Add(Me.cmd_Buscar)
        Me.grp_Inicio.Controls.Add(Me.cmb_Buscador)
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
        Me.cmd_Buscar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.BUSCAR01
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
        Me.cmdPuerta.Image = Global.ConsultorioOdontologico.My.Resources.Resources.puerta
        Me.cmdPuerta.Location = New System.Drawing.Point(508, 546)
        Me.cmdPuerta.Name = "cmdPuerta"
        Me.cmdPuerta.Size = New System.Drawing.Size(39, 36)
        Me.cmdPuerta.TabIndex = 16
        Me.cmdPuerta.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.ConsultorioOdontologico.My.Resources.Resources.Nuevo
        Me.cmdNuevo.Location = New System.Drawing.Point(16, 546)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(33, 36)
        Me.cmdNuevo.TabIndex = 15
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'frmRegistrarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(562, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.grp_Inicio)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdPuerta)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.grp_Paciente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistrarPaciente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Consultorio Odontológico-Registrar Paciente"
        Me.lblDomicilio.ResumeLayout(False)
        Me.lblDomicilio.PerformLayout()
        Me.grp_Datos.ResumeLayout(False)
        Me.grp_Datos.PerformLayout()
        Me.grp_Paciente.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Inicio.ResumeLayout(False)
        Me.grp_Inicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents saveImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdPuerta As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblPiso As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtPiso As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents cboLocalidad As ComboBox
    Friend WithEvents lblDomicilio As GroupBox
    Friend WithEvents lblHistorial As Label
    Friend WithEvents cmdModificar As Button
    Friend WithEvents grp_Datos As GroupBox
    Friend WithEvents grp_Paciente As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_IngresarDatos As TextBox
    Friend WithEvents cmb_Buscador As ComboBox
    Friend WithEvents btn_Actualizar As Button
    Friend WithEvents grp_Inicio As GroupBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Aceptar As Button
    Friend WithEvents lbl_CodigoPaciente As Label
    Friend WithEvents txtFechaNacimiento As DateTimePicker
End Class
