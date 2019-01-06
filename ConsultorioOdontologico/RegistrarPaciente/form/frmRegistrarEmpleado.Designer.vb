<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarEmpleado
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarEmpleado))
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDomicilio = New System.Windows.Forms.GroupBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.cboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblHoraIngreso = New System.Windows.Forms.Label()
        Me.lblHoraSalida = New System.Windows.Forms.Label()
        Me.txtHoraIngreso = New System.Windows.Forms.MaskedTextBox()
        Me.txtHoraSalida = New System.Windows.Forms.MaskedTextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.grpPaciente = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.txtNroDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.lblCodigoEmpleado = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.grpBuscador = New System.Windows.Forms.GroupBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cboBuscador = New System.Windows.Forms.ComboBox()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.lblDomicilio.SuspendLayout()
        Me.grpPaciente.SuspendLayout()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBuscador.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoCompleteCustomSource.AddRange(New String() {"DNI"})
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Items.AddRange(New Object() {"DNI"})
        Me.cboTipoDocumento.Location = New System.Drawing.Point(120, 160)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoDocumento.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(97, 74)
        Me.txtApellido.MaxLength = 30
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(201, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(97, 34)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(201, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblDomicilio
        '
        Me.lblDomicilio.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblDomicilio.Controls.Add(Me.lblCelular)
        Me.lblDomicilio.Controls.Add(Me.txtCelular)
        Me.lblDomicilio.Controls.Add(Me.txtTelefono)
        Me.lblDomicilio.Controls.Add(Me.lblTelefono)
        Me.lblDomicilio.Controls.Add(Me.cboLocalidad)
        Me.lblDomicilio.Controls.Add(Me.txtDepartamento)
        Me.lblDomicilio.Controls.Add(Me.txtPiso)
        Me.lblDomicilio.Controls.Add(Me.txtNumero)
        Me.lblDomicilio.Controls.Add(Me.txtCalle)
        Me.lblDomicilio.Controls.Add(Me.lblPiso)
        Me.lblDomicilio.Controls.Add(Me.lblDepartamento)
        Me.lblDomicilio.Controls.Add(Me.lblLocalidad)
        Me.lblDomicilio.Controls.Add(Me.lblNumero)
        Me.lblDomicilio.Controls.Add(Me.lblCalle)
        Me.lblDomicilio.Location = New System.Drawing.Point(22, 369)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(440, 221)
        Me.lblDomicilio.TabIndex = 0
        Me.lblDomicilio.TabStop = False
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(206, 182)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 19
        Me.lblCelular.Text = "Celular"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(268, 179)
        Me.txtCelular.MaxLength = 30
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(95, 20)
        Me.txtCelular.TabIndex = 16
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(73, 179)
        Me.txtTelefono.MaxLength = 30
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(95, 20)
        Me.txtTelefono.TabIndex = 15
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(11, 182)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 16
        Me.lblTelefono.Text = "Teléfono"
        '
        'cboLocalidad
        '
        Me.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.ItemHeight = 13
        Me.cboLocalidad.Items.AddRange(New Object() {"Córdoba"})
        Me.cboLocalidad.Location = New System.Drawing.Point(79, 139)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(135, 21)
        Me.cboLocalidad.TabIndex = 14
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(174, 93)
        Me.txtDepartamento.MaxLength = 3
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(75, 20)
        Me.txtDepartamento.TabIndex = 13
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(56, 90)
        Me.txtPiso.MaxLength = 3
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(50, 20)
        Me.txtPiso.TabIndex = 12
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(293, 38)
        Me.txtNumero.MaxLength = 5
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(75, 20)
        Me.txtNumero.TabIndex = 11
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(56, 38)
        Me.txtCalle.MaxLength = 30
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(164, 20)
        Me.txtCalle.TabIndex = 10
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
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(11, 139)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(60, 13)
        Me.lblLocalidad.TabIndex = 0
        Me.lblLocalidad.Text = "Localidad *"
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
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(24, 197)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(89, 13)
        Me.lblNroDocumento.TabIndex = 18
        Me.lblNroDocumento.Text = "Nro Documento *"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(24, 160)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(93, 13)
        Me.lblTipoDocumento.TabIndex = 19
        Me.lblTipoDocumento.Text = "Tipo Documento *"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(23, 116)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(100, 13)
        Me.lblFechaNacimiento.TabIndex = 21
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento *"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(24, 74)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(51, 13)
        Me.lblApellido.TabIndex = 23
        Me.lblApellido.Text = "Apellido *"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(24, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 13)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre *"
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Location = New System.Drawing.Point(26, 240)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(74, 13)
        Me.lblEspecialidad.TabIndex = 34
        Me.lblEspecialidad.Text = "Especialidad *"
        '
        'cboEspecialidad
        '
        Me.cboEspecialidad.AutoCompleteCustomSource.AddRange(New String() {"DNI"})
        Me.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialidad.FormattingEnabled = True
        Me.cboEspecialidad.Items.AddRange(New Object() {"DNI"})
        Me.cboEspecialidad.Location = New System.Drawing.Point(116, 237)
        Me.cboEspecialidad.Name = "cboEspecialidad"
        Me.cboEspecialidad.Size = New System.Drawing.Size(121, 21)
        Me.cboEspecialidad.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(26, 272)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(42, 13)
        Me.lblCargo.TabIndex = 36
        Me.lblCargo.Text = "Cargo *"
        '
        'lblHoraIngreso
        '
        Me.lblHoraIngreso.AutoSize = True
        Me.lblHoraIngreso.Location = New System.Drawing.Point(26, 305)
        Me.lblHoraIngreso.Name = "lblHoraIngreso"
        Me.lblHoraIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lblHoraIngreso.TabIndex = 38
        Me.lblHoraIngreso.Text = "Hora Ingreso *"
        '
        'lblHoraSalida
        '
        Me.lblHoraSalida.AutoSize = True
        Me.lblHoraSalida.Location = New System.Drawing.Point(26, 336)
        Me.lblHoraSalida.Name = "lblHoraSalida"
        Me.lblHoraSalida.Size = New System.Drawing.Size(69, 13)
        Me.lblHoraSalida.TabIndex = 39
        Me.lblHoraSalida.Text = "Hora Salida *"
        '
        'txtHoraIngreso
        '
        Me.txtHoraIngreso.Location = New System.Drawing.Point(116, 302)
        Me.txtHoraIngreso.Mask = "00:00"
        Me.txtHoraIngreso.Name = "txtHoraIngreso"
        Me.txtHoraIngreso.Size = New System.Drawing.Size(36, 20)
        Me.txtHoraIngreso.TabIndex = 8
        Me.txtHoraIngreso.ValidatingType = GetType(Date)
        '
        'txtHoraSalida
        '
        Me.txtHoraSalida.Location = New System.Drawing.Point(116, 333)
        Me.txtHoraSalida.Mask = "00:00"
        Me.txtHoraSalida.Name = "txtHoraSalida"
        Me.txtHoraSalida.Size = New System.Drawing.Size(36, 20)
        Me.txtHoraSalida.TabIndex = 9
        Me.txtHoraSalida.ValidatingType = GetType(Date)
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(400, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 40
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(489, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 41
        Me.lblHora.Text = "Hora"
        '
        'grpPaciente
        '
        Me.grpPaciente.Controls.Add(Me.Label1)
        Me.grpPaciente.Controls.Add(Me.dtpFechaNac)
        Me.grpPaciente.Controls.Add(Me.cboCargo)
        Me.grpPaciente.Controls.Add(Me.txtNroDocumento)
        Me.grpPaciente.Controls.Add(Me.lblCodigoEmpleado)
        Me.grpPaciente.Controls.Add(Me.lblCodigo)
        Me.grpPaciente.Controls.Add(Me.lblDomicilio)
        Me.grpPaciente.Controls.Add(Me.lblCargo)
        Me.grpPaciente.Controls.Add(Me.lblHoraIngreso)
        Me.grpPaciente.Controls.Add(Me.cboEspecialidad)
        Me.grpPaciente.Controls.Add(Me.txtHoraSalida)
        Me.grpPaciente.Controls.Add(Me.lblEspecialidad)
        Me.grpPaciente.Controls.Add(Me.lblHoraSalida)
        Me.grpPaciente.Controls.Add(Me.txtHoraIngreso)
        Me.grpPaciente.Controls.Add(Me.txtNombre)
        Me.grpPaciente.Controls.Add(Me.lblNombre)
        Me.grpPaciente.Controls.Add(Me.lblApellido)
        Me.grpPaciente.Controls.Add(Me.cboTipoDocumento)
        Me.grpPaciente.Controls.Add(Me.lblFechaNacimiento)
        Me.grpPaciente.Controls.Add(Me.txtApellido)
        Me.grpPaciente.Controls.Add(Me.lblTipoDocumento)
        Me.grpPaciente.Controls.Add(Me.lblNroDocumento)
        Me.grpPaciente.Location = New System.Drawing.Point(12, 24)
        Me.grpPaciente.Name = "grpPaciente"
        Me.grpPaciente.Size = New System.Drawing.Size(551, 596)
        Me.grpPaciente.TabIndex = 43
        Me.grpPaciente.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "De 0 a 24 hs"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(129, 116)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNac.TabIndex = 3
        '
        'cboCargo
        '
        Me.cboCargo.AutoCompleteCustomSource.AddRange(New String() {"DNI"})
        Me.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Items.AddRange(New Object() {"DNI"})
        Me.cboCargo.Location = New System.Drawing.Point(115, 272)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(121, 21)
        Me.cboCargo.TabIndex = 7
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(120, 197)
        Me.txtNroDocumento.Mask = "99999999"
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtNroDocumento.TabIndex = 5
        '
        'lblCodigoEmpleado
        '
        Me.lblCodigoEmpleado.AutoSize = True
        Me.lblCodigoEmpleado.Location = New System.Drawing.Point(26, 16)
        Me.lblCodigoEmpleado.Name = "lblCodigoEmpleado"
        Me.lblCodigoEmpleado.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigoEmpleado.TabIndex = 41
        Me.lblCodigoEmpleado.Text = "Codigo"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(103, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(25, 13)
        Me.lblCodigo.TabIndex = 40
        Me.lblCodigo.Text = "133"
        '
        'dgvEmpleado
        '
        Me.dgvEmpleado.AllowUserToAddRows = False
        Me.dgvEmpleado.AllowUserToOrderColumns = True
        Me.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleado.Location = New System.Drawing.Point(6, 107)
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.ReadOnly = True
        Me.dgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleado.Size = New System.Drawing.Size(616, 457)
        Me.dgvEmpleado.TabIndex = 44
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(107, 638)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 17
        Me.cmdAceptar.Text = "ACEPTAR"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(208, 638)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 18
        Me.cmdCancelar.Text = "CANCELAR"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'grpBuscador
        '
        Me.grpBuscador.Controls.Add(Me.cmdActualizar)
        Me.grpBuscador.Controls.Add(Me.cboBuscador)
        Me.grpBuscador.Controls.Add(Me.txtBuscador)
        Me.grpBuscador.Controls.Add(Me.cmdBuscar)
        Me.grpBuscador.Controls.Add(Me.dgvEmpleado)
        Me.grpBuscador.Location = New System.Drawing.Point(3, 24)
        Me.grpBuscador.Name = "grpBuscador"
        Me.grpBuscador.Size = New System.Drawing.Size(631, 596)
        Me.grpBuscador.TabIndex = 47
        Me.grpBuscador.TabStop = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.actualizar
        Me.cmdActualizar.Location = New System.Drawing.Point(522, 34)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(53, 47)
        Me.cmdActualizar.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.cmdActualizar, "Actualizar")
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'cboBuscador
        '
        Me.cboBuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscador.FormattingEnabled = True
        Me.cboBuscador.Location = New System.Drawing.Point(248, 56)
        Me.cboBuscador.Name = "cboBuscador"
        Me.cboBuscador.Size = New System.Drawing.Size(121, 21)
        Me.cboBuscador.TabIndex = 50
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(32, 56)
        Me.txtBuscador.MaxLength = 30
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(193, 20)
        Me.txtBuscador.TabIndex = 49
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.BUSCAR01
        Me.cmdBuscar.Location = New System.Drawing.Point(450, 34)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(53, 47)
        Me.cmdBuscar.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.cmdBuscar, "Buscar")
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.modificar
        Me.cmdModificar.Location = New System.Drawing.Point(137, 626)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(53, 47)
        Me.cmdModificar.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.cmdModificar, "Modificar")
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ConsultorioOdontologico.My.Resources.Resources.puerta
        Me.cmdSalir.Location = New System.Drawing.Point(440, 626)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(53, 47)
        Me.cmdSalir.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.cmdSalir, "Salir")
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.ConsultorioOdontologico.My.Resources.Resources.Nuevo
        Me.cmdNuevo.Location = New System.Drawing.Point(38, 626)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(53, 47)
        Me.cmdNuevo.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.cmdNuevo, "Insertar Nuevo")
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.CANCELAR
        Me.cmdBorrar.Location = New System.Drawing.Point(230, 626)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(53, 47)
        Me.cmdBorrar.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.cmdBorrar, "Eliminar")
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'frmRegistrarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(636, 685)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.grpBuscador)
        Me.Controls.Add(Me.grpPaciente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegistrarEmpleado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultorio Odontologico-Registrar Empleado"
        Me.lblDomicilio.ResumeLayout(False)
        Me.lblDomicilio.PerformLayout()
        Me.grpPaciente.ResumeLayout(False)
        Me.grpPaciente.PerformLayout()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBuscador.ResumeLayout(False)
        Me.grpBuscador.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents lblDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents txtPiso As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblPiso As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
    Friend WithEvents cboEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents lblHoraIngreso As System.Windows.Forms.Label
    Friend WithEvents lblHoraSalida As System.Windows.Forms.Label
    Friend WithEvents txtHoraIngreso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHoraSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents grpPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEmpleado As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents grpBuscador As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cboBuscador As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblCodigoEmpleado As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCargo As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDocumento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
