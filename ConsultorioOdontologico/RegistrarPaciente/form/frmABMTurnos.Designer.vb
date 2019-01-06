<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMTurnos))
        Me.grpTurnos = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.grp_Datos = New System.Windows.Forms.GroupBox()
        Me.grpHora = New System.Windows.Forms.GroupBox()
        Me.lblHoraT = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscarTurnos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnBuscarPaciente = New System.Windows.Forms.Button()
        Me.dgvHorarios = New System.Windows.Forms.DataGridView()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboProfesional = New System.Windows.Forms.ComboBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaT = New System.Windows.Forms.Label()
        Me.lblProfesional = New System.Windows.Forms.Label()
        Me.grpBuscador = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cboBuscador = New System.Windows.Forms.ComboBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpTurnos.SuspendLayout()
        Me.grp_Datos.SuspendLayout()
        Me.grpHora.SuspendLayout()
        CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBuscador.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTurnos
        '
        Me.grpTurnos.Controls.Add(Me.cmdCancelar)
        Me.grpTurnos.Controls.Add(Me.cmdAceptar)
        Me.grpTurnos.Controls.Add(Me.grp_Datos)
        Me.grpTurnos.Location = New System.Drawing.Point(43, 36)
        Me.grpTurnos.Name = "grpTurnos"
        Me.grpTurnos.Size = New System.Drawing.Size(529, 416)
        Me.grpTurnos.TabIndex = 60
        Me.grpTurnos.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(261, 377)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(63, 23)
        Me.cmdCancelar.TabIndex = 55
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(137, 377)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(67, 23)
        Me.cmdAceptar.TabIndex = 54
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'grp_Datos
        '
        Me.grp_Datos.Controls.Add(Me.grpHora)
        Me.grp_Datos.Controls.Add(Me.btnBuscarTurnos)
        Me.grp_Datos.Controls.Add(Me.Label3)
        Me.grp_Datos.Controls.Add(Me.Label2)
        Me.grp_Datos.Controls.Add(Me.Label1)
        Me.grp_Datos.Controls.Add(Me.txtApellido)
        Me.grp_Datos.Controls.Add(Me.txtNombre)
        Me.grp_Datos.Controls.Add(Me.txtDocumento)
        Me.grp_Datos.Controls.Add(Me.btnPaciente)
        Me.grp_Datos.Controls.Add(Me.btnBuscarPaciente)
        Me.grp_Datos.Controls.Add(Me.dgvHorarios)
        Me.grp_Datos.Controls.Add(Me.cboProfesional)
        Me.grp_Datos.Controls.Add(Me.txtFecha)
        Me.grp_Datos.Controls.Add(Me.lblFechaT)
        Me.grp_Datos.Controls.Add(Me.lblProfesional)
        Me.grp_Datos.Location = New System.Drawing.Point(19, 19)
        Me.grp_Datos.Name = "grp_Datos"
        Me.grp_Datos.Size = New System.Drawing.Size(494, 352)
        Me.grp_Datos.TabIndex = 53
        Me.grp_Datos.TabStop = False
        Me.grp_Datos.Text = "Datos Personales"
        '
        'grpHora
        '
        Me.grpHora.BackColor = System.Drawing.Color.MediumTurquoise
        Me.grpHora.Controls.Add(Me.lblHoraT)
        Me.grpHora.Controls.Add(Me.txtHora)
        Me.grpHora.Location = New System.Drawing.Point(143, 171)
        Me.grpHora.Name = "grpHora"
        Me.grpHora.Size = New System.Drawing.Size(94, 38)
        Me.grpHora.TabIndex = 65
        Me.grpHora.TabStop = False
        Me.grpHora.Visible = False
        '
        'lblHoraT
        '
        Me.lblHoraT.AutoSize = True
        Me.lblHoraT.Location = New System.Drawing.Point(6, 16)
        Me.lblHoraT.Name = "lblHoraT"
        Me.lblHoraT.Size = New System.Drawing.Size(37, 13)
        Me.lblHoraT.TabIndex = 0
        Me.lblHoraT.Text = "Hora *"
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtHora.Location = New System.Drawing.Point(49, 12)
        Me.txtHora.Mask = "00:00"
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(39, 20)
        Me.txtHora.TabIndex = 55
        Me.txtHora.ValidatingType = GetType(Date)
        '
        'btnBuscarTurnos
        '
        Me.btnBuscarTurnos.Location = New System.Drawing.Point(345, 161)
        Me.btnBuscarTurnos.Name = "btnBuscarTurnos"
        Me.btnBuscarTurnos.Size = New System.Drawing.Size(116, 39)
        Me.btnBuscarTurnos.TabIndex = 64
        Me.btnBuscarTurnos.Text = "Buscar turnos diponibles"
        Me.btnBuscarTurnos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Nombre "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Nro Documento "
        '
        'txtApellido
        '
        Me.txtApellido.Enabled = False
        Me.txtApellido.Location = New System.Drawing.Point(127, 74)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 60
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(127, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 59
        '
        'txtDocumento
        '
        Me.txtDocumento.Enabled = False
        Me.txtDocumento.Location = New System.Drawing.Point(127, 22)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.ReadOnly = True
        Me.txtDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtDocumento.TabIndex = 58
        '
        'btnPaciente
        '
        Me.btnPaciente.Location = New System.Drawing.Point(336, 53)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(66, 37)
        Me.btnPaciente.TabIndex = 56
        Me.btnPaciente.Text = "Nuevo Paciente"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnBuscarPaciente
        '
        Me.btnBuscarPaciente.Location = New System.Drawing.Point(269, 53)
        Me.btnBuscarPaciente.Name = "btnBuscarPaciente"
        Me.btnBuscarPaciente.Size = New System.Drawing.Size(63, 36)
        Me.btnBuscarPaciente.TabIndex = 41
        Me.btnBuscarPaciente.Text = "Buscar Pacientes"
        Me.btnBuscarPaciente.UseVisualStyleBackColor = True
        '
        'dgvHorarios
        '
        Me.dgvHorarios.AllowUserToAddRows = False
        Me.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHorarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Horario})
        Me.dgvHorarios.Location = New System.Drawing.Point(20, 213)
        Me.dgvHorarios.Name = "dgvHorarios"
        Me.dgvHorarios.ReadOnly = True
        Me.dgvHorarios.Size = New System.Drawing.Size(458, 133)
        Me.dgvHorarios.TabIndex = 57
        '
        'Horario
        '
        Me.Horario.HeaderText = "Horario"
        Me.Horario.Name = "Horario"
        Me.Horario.ReadOnly = True
        '
        'cboProfesional
        '
        Me.cboProfesional.AutoCompleteCustomSource.AddRange(New String() {"DNI"})
        Me.cboProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfesional.FormattingEnabled = True
        Me.cboProfesional.Items.AddRange(New Object() {"DNI"})
        Me.cboProfesional.Location = New System.Drawing.Point(116, 118)
        Me.cboProfesional.Name = "cboProfesional"
        Me.cboProfesional.Size = New System.Drawing.Size(200, 21)
        Me.cboProfesional.TabIndex = 54
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(118, 145)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(198, 20)
        Me.txtFecha.TabIndex = 52
        '
        'lblFechaT
        '
        Me.lblFechaT.AutoSize = True
        Me.lblFechaT.Location = New System.Drawing.Point(61, 152)
        Me.lblFechaT.Name = "lblFechaT"
        Me.lblFechaT.Size = New System.Drawing.Size(44, 13)
        Me.lblFechaT.TabIndex = 0
        Me.lblFechaT.Text = "Fecha *"
        '
        'lblProfesional
        '
        Me.lblProfesional.AutoSize = True
        Me.lblProfesional.Location = New System.Drawing.Point(40, 121)
        Me.lblProfesional.Name = "lblProfesional"
        Me.lblProfesional.Size = New System.Drawing.Size(66, 13)
        Me.lblProfesional.TabIndex = 0
        Me.lblProfesional.Text = "Profesional *"
        '
        'grpBuscador
        '
        Me.grpBuscador.Controls.Add(Me.Label4)
        Me.grpBuscador.Controls.Add(Me.dgv)
        Me.grpBuscador.Controls.Add(Me.cmdActualizar)
        Me.grpBuscador.Controls.Add(Me.txtBuscador)
        Me.grpBuscador.Controls.Add(Me.cmdBuscar)
        Me.grpBuscador.Controls.Add(Me.cboBuscador)
        Me.grpBuscador.Location = New System.Drawing.Point(23, 23)
        Me.grpBuscador.Name = "grpBuscador"
        Me.grpBuscador.Size = New System.Drawing.Size(505, 429)
        Me.grpBuscador.TabIndex = 61
        Me.grpBuscador.TabStop = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(25, 96)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(449, 288)
        Me.dgv.TabIndex = 55
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.actualizar1
        Me.cmdActualizar.Location = New System.Drawing.Point(434, 20)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(50, 44)
        Me.cmdActualizar.TabIndex = 58
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(25, 28)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(192, 20)
        Me.txtBuscador.TabIndex = 56
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.BUSCAR01
        Me.cmdBuscar.Location = New System.Drawing.Point(378, 20)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(50, 45)
        Me.cmdBuscar.TabIndex = 48
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cboBuscador
        '
        Me.cboBuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscador.FormattingEnabled = True
        Me.cboBuscador.Items.AddRange(New Object() {"DOCUMENTO", "FECHA", "COD PROFESIONAL", "NOM PROFESIONAL"})
        Me.cboBuscador.Location = New System.Drawing.Point(234, 27)
        Me.cboBuscador.Name = "cboBuscador"
        Me.cboBuscador.Size = New System.Drawing.Size(134, 21)
        Me.cboBuscador.TabIndex = 57
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(526, 7)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 63
        Me.lblHora.Text = "Hora"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(437, 7)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 62
        Me.lblFecha.Text = "Fecha"
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModificar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.modificar1
        Me.cmdModificar.Location = New System.Drawing.Point(120, 474)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(42, 36)
        Me.cmdModificar.TabIndex = 56
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.CANCELAR1
        Me.cmdEliminar.Location = New System.Drawing.Point(257, 474)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(42, 36)
        Me.cmdEliminar.TabIndex = 55
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ConsultorioOdontologico.My.Resources.Resources.puerta
        Me.cmdSalir.Location = New System.Drawing.Point(516, 474)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(39, 36)
        Me.cmdSalir.TabIndex = 54
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = Global.ConsultorioOdontologico.My.Resources.Resources.Nuevo
        Me.cmdNuevo.Location = New System.Drawing.Point(24, 474)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(33, 36)
        Me.cmdNuevo.TabIndex = 53
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "* Fecha en formato aaaa-mm-dd"
        '
        'frmABMTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(589, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.grpBuscador)
        Me.Controls.Add(Me.grpTurnos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmABMTurnos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultorio Odontológico-ABM Turnos"
        Me.grpTurnos.ResumeLayout(False)
        Me.grp_Datos.ResumeLayout(False)
        Me.grp_Datos.PerformLayout()
        Me.grpHora.ResumeLayout(False)
        Me.grpHora.PerformLayout()
        CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBuscador.ResumeLayout(False)
        Me.grpBuscador.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents grpTurnos As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents grp_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents txtHora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboProfesional As System.Windows.Forms.ComboBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHoraT As System.Windows.Forms.Label
    Friend WithEvents lblFechaT As System.Windows.Forms.Label
    Friend WithEvents lblProfesional As System.Windows.Forms.Label
    Friend WithEvents grpBuscador As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cboBuscador As System.Windows.Forms.ComboBox
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnPaciente As System.Windows.Forms.Button
    Friend WithEvents dgvHorarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarPaciente As System.Windows.Forms.Button
    Friend WithEvents btnBuscarTurnos As Button
    Friend WithEvents Horario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpHora As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
