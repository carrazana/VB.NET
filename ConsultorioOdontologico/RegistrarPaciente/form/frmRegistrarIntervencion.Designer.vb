<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarIntervencion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarIntervencion))
        Me.groupBuscarPaciente = New System.Windows.Forms.GroupBox()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.txtValorBusqueda = New System.Windows.Forms.TextBox()
        Me.groupDatosIntervencion = New System.Windows.Forms.GroupBox()
        Me.grpConsulta = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gridTratamientosXPaciente = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNroHistorial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApellidoPaciente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.grpAlta = New System.Windows.Forms.GroupBox()
        Me.btnVerStock = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTratamientos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarInsumo = New System.Windows.Forms.Button()
        Me.btnAgregarInsumo = New System.Windows.Forms.Button()
        Me.gridInsumosTramientoXIntervencion = New System.Windows.Forms.DataGridView()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.groupBuscarPaciente.SuspendLayout()
        Me.groupDatosIntervencion.SuspendLayout()
        Me.grpConsulta.SuspendLayout()
        CType(Me.gridTratamientosXPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAlta.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gridInsumosTramientoXIntervencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBuscarPaciente
        '
        Me.groupBuscarPaciente.Controls.Add(Me.btnTodos)
        Me.groupBuscarPaciente.Controls.Add(Me.btnBuscar)
        Me.groupBuscarPaciente.Controls.Add(Me.cmbTipoBusqueda)
        Me.groupBuscarPaciente.Controls.Add(Me.Label1)
        Me.groupBuscarPaciente.Controls.Add(Me.lblNroDocumento)
        Me.groupBuscarPaciente.Controls.Add(Me.txtValorBusqueda)
        Me.groupBuscarPaciente.Location = New System.Drawing.Point(50, 41)
        Me.groupBuscarPaciente.Name = "groupBuscarPaciente"
        Me.groupBuscarPaciente.Size = New System.Drawing.Size(618, 96)
        Me.groupBuscarPaciente.TabIndex = 40
        Me.groupBuscarPaciente.TabStop = False
        Me.groupBuscarPaciente.Text = "Buscar Paciente"
        '
        'btnTodos
        '
        Me.btnTodos.Location = New System.Drawing.Point(476, 29)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(99, 39)
        Me.btnTodos.TabIndex = 41
        Me.btnTodos.Text = "Mostrar Pacientes"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(365, 29)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 39)
        Me.btnBuscar.TabIndex = 40
        Me.btnBuscar.Text = "Buscar paciente"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cmbTipoBusqueda
        '
        Me.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoBusqueda.FormattingEnabled = True
        Me.cmbTipoBusqueda.Location = New System.Drawing.Point(133, 26)
        Me.cmbTipoBusqueda.Name = "cmbTipoBusqueda"
        Me.cmbTipoBusqueda.Size = New System.Drawing.Size(205, 21)
        Me.cmbTipoBusqueda.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Tipo de Busqueda:"
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(29, 55)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(100, 13)
        Me.lblNroDocumento.TabIndex = 30
        Me.lblNroDocumento.Text = "Valor de Busqueda:"
        '
        'txtValorBusqueda
        '
        Me.txtValorBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorBusqueda.Location = New System.Drawing.Point(133, 53)
        Me.txtValorBusqueda.Name = "txtValorBusqueda"
        Me.txtValorBusqueda.Size = New System.Drawing.Size(205, 20)
        Me.txtValorBusqueda.TabIndex = 29
        '
        'groupDatosIntervencion
        '
        Me.groupDatosIntervencion.Controls.Add(Me.txtNroHistorial)
        Me.groupDatosIntervencion.Controls.Add(Me.Label4)
        Me.groupDatosIntervencion.Controls.Add(Me.Label10)
        Me.groupDatosIntervencion.Controls.Add(Me.txtApellidoPaciente)
        Me.groupDatosIntervencion.Controls.Add(Me.Label11)
        Me.groupDatosIntervencion.Controls.Add(Me.txtNombrePaciente)
        Me.groupDatosIntervencion.Controls.Add(Me.grpAlta)
        Me.groupDatosIntervencion.Controls.Add(Me.grpConsulta)
        Me.groupDatosIntervencion.Location = New System.Drawing.Point(50, 143)
        Me.groupDatosIntervencion.Name = "groupDatosIntervencion"
        Me.groupDatosIntervencion.Size = New System.Drawing.Size(615, 446)
        Me.groupDatosIntervencion.TabIndex = 47
        Me.groupDatosIntervencion.TabStop = False
        Me.groupDatosIntervencion.Text = "Datos de la intervencion"
        '
        'grpConsulta
        '
        Me.grpConsulta.Controls.Add(Me.btnModificar)
        Me.grpConsulta.Controls.Add(Me.btnEliminar)
        Me.grpConsulta.Controls.Add(Me.gridTratamientosXPaciente)
        Me.grpConsulta.Controls.Add(Me.btnNuevo)
        Me.grpConsulta.Location = New System.Drawing.Point(6, 87)
        Me.grpConsulta.Name = "grpConsulta"
        Me.grpConsulta.Size = New System.Drawing.Size(597, 338)
        Me.grpConsulta.TabIndex = 51
        Me.grpConsulta.TabStop = False
        Me.grpConsulta.Text = "Informacion sobre tratamientos del paciente"
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.modificar
        Me.btnModificar.Location = New System.Drawing.Point(101, 273)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(53, 47)
        Me.btnModificar.TabIndex = 53
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.CANCELAR
        Me.btnEliminar.Location = New System.Drawing.Point(190, 273)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(53, 47)
        Me.btnEliminar.TabIndex = 50
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'gridTratamientosXPaciente
        '
        Me.gridTratamientosXPaciente.AllowUserToAddRows = False
        Me.gridTratamientosXPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTratamientosXPaciente.Location = New System.Drawing.Point(12, 19)
        Me.gridTratamientosXPaciente.Name = "gridTratamientosXPaciente"
        Me.gridTratamientosXPaciente.ReadOnly = True
        Me.gridTratamientosXPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridTratamientosXPaciente.Size = New System.Drawing.Size(567, 219)
        Me.gridTratamientosXPaciente.TabIndex = 36
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.ConsultorioOdontologico.My.Resources.Resources.Nuevo
        Me.btnNuevo.Location = New System.Drawing.Point(18, 273)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(53, 47)
        Me.btnNuevo.TabIndex = 51
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtNroHistorial
        '
        Me.txtNroHistorial.Enabled = False
        Me.txtNroHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroHistorial.Location = New System.Drawing.Point(433, 53)
        Me.txtNroHistorial.Name = "txtNroHistorial"
        Me.txtNroHistorial.Size = New System.Drawing.Size(100, 26)
        Me.txtNroHistorial.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(399, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Numero de historial:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Nombre del paciente:"
        '
        'txtApellidoPaciente
        '
        Me.txtApellidoPaciente.Enabled = False
        Me.txtApellidoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoPaciente.Location = New System.Drawing.Point(133, 61)
        Me.txtApellidoPaciente.Name = "txtApellidoPaciente"
        Me.txtApellidoPaciente.Size = New System.Drawing.Size(205, 20)
        Me.txtApellidoPaciente.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Apellido del paciente:"
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Enabled = False
        Me.txtNombrePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePaciente.Location = New System.Drawing.Point(133, 30)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(205, 20)
        Me.txtNombrePaciente.TabIndex = 43
        '
        'grpAlta
        '
        Me.grpAlta.Controls.Add(Me.btnVerStock)
        Me.grpAlta.Controls.Add(Me.btnGuardar)
        Me.grpAlta.Controls.Add(Me.btnCancelar)
        Me.grpAlta.Controls.Add(Me.Label2)
        Me.grpAlta.Controls.Add(Me.txtObservacion)
        Me.grpAlta.Controls.Add(Me.Label8)
        Me.grpAlta.Controls.Add(Me.txtCosto)
        Me.grpAlta.Controls.Add(Me.txtMontoTotal)
        Me.grpAlta.Controls.Add(Me.Label6)
        Me.grpAlta.Controls.Add(Me.cmbTratamientos)
        Me.grpAlta.Controls.Add(Me.Label7)
        Me.grpAlta.Controls.Add(Me.GroupBox3)
        Me.grpAlta.Location = New System.Drawing.Point(6, 97)
        Me.grpAlta.Name = "grpAlta"
        Me.grpAlta.Size = New System.Drawing.Size(591, 343)
        Me.grpAlta.TabIndex = 45
        Me.grpAlta.TabStop = False
        Me.grpAlta.Text = "Informacion de la intervencion"
        '
        'btnVerStock
        '
        Me.btnVerStock.Location = New System.Drawing.Point(101, 302)
        Me.btnVerStock.Name = "btnVerStock"
        Me.btnVerStock.Size = New System.Drawing.Size(71, 29)
        Me.btnVerStock.TabIndex = 53
        Me.btnVerStock.Text = "Ver Stock"
        Me.btnVerStock.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(427, 305)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 48
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(508, 305)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 49
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Observacion:"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(127, 72)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(310, 51)
        Me.txtObservacion.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(84, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Costo:"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(127, 46)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = True
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 55
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Enabled = False
        Me.txtMontoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoTotal.Location = New System.Drawing.Point(305, 299)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(100, 29)
        Me.txtMontoTotal.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(186, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Monto total:"
        '
        'cmbTratamientos
        '
        Me.cmbTratamientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTratamientos.FormattingEnabled = True
        Me.cmbTratamientos.Location = New System.Drawing.Point(127, 19)
        Me.cmbTratamientos.Name = "cmbTratamientos"
        Me.cmbTratamientos.Size = New System.Drawing.Size(310, 21)
        Me.cmbTratamientos.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Tratamiento: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnEliminarInsumo)
        Me.GroupBox3.Controls.Add(Me.btnAgregarInsumo)
        Me.GroupBox3.Controls.Add(Me.gridInsumosTramientoXIntervencion)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(579, 170)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de insumos del tratamiento por intervencion"
        '
        'btnEliminarInsumo
        '
        Me.btnEliminarInsumo.Location = New System.Drawing.Point(142, 134)
        Me.btnEliminarInsumo.Name = "btnEliminarInsumo"
        Me.btnEliminarInsumo.Size = New System.Drawing.Size(119, 29)
        Me.btnEliminarInsumo.TabIndex = 52
        Me.btnEliminarInsumo.Text = "Eliminar Insumo"
        Me.btnEliminarInsumo.UseVisualStyleBackColor = True
        '
        'btnAgregarInsumo
        '
        Me.btnAgregarInsumo.Location = New System.Drawing.Point(17, 134)
        Me.btnAgregarInsumo.Name = "btnAgregarInsumo"
        Me.btnAgregarInsumo.Size = New System.Drawing.Size(119, 29)
        Me.btnAgregarInsumo.TabIndex = 51
        Me.btnAgregarInsumo.Text = "Agregar Insumo"
        Me.btnAgregarInsumo.UseVisualStyleBackColor = True
        '
        'gridInsumosTramientoXIntervencion
        '
        Me.gridInsumosTramientoXIntervencion.AllowUserToAddRows = False
        Me.gridInsumosTramientoXIntervencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridInsumosTramientoXIntervencion.Location = New System.Drawing.Point(17, 19)
        Me.gridInsumosTramientoXIntervencion.Name = "gridInsumosTramientoXIntervencion"
        Me.gridInsumosTramientoXIntervencion.ReadOnly = True
        Me.gridInsumosTramientoXIntervencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridInsumosTramientoXIntervencion.Size = New System.Drawing.Size(556, 109)
        Me.gridInsumosTramientoXIntervencion.TabIndex = 0
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(635, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 49
        Me.lblHora.Text = "Hora"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(523, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 48
        Me.lblFecha.Text = "Fecha"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.ConsultorioOdontologico.My.Resources.Resources.puerta
        Me.btnSalir.Location = New System.Drawing.Point(594, 597)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 47)
        Me.btnSalir.TabIndex = 52
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmRegistrarIntervencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(709, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.groupBuscarPaciente)
        Me.Controls.Add(Me.groupDatosIntervencion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegistrarIntervencion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistrarIntervencion"
        Me.groupBuscarPaciente.ResumeLayout(False)
        Me.groupBuscarPaciente.PerformLayout()
        Me.groupDatosIntervencion.ResumeLayout(False)
        Me.groupDatosIntervencion.PerformLayout()
        Me.grpConsulta.ResumeLayout(False)
        CType(Me.gridTratamientosXPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAlta.ResumeLayout(False)
        Me.grpAlta.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.gridInsumosTramientoXIntervencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupBuscarPaciente As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cmbTipoBusqueda As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNroDocumento As Label
    Friend WithEvents txtValorBusqueda As TextBox
    Friend WithEvents groupDatosIntervencion As GroupBox
    Friend WithEvents txtNroHistorial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grpAlta As GroupBox
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAgregarInsumo As Button
    Friend WithEvents gridInsumosTramientoXIntervencion As DataGridView
    Friend WithEvents cmbTratamientos As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtApellidoPaciente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grpConsulta As GroupBox
    Friend WithEvents gridTratamientosXPaciente As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents btnEliminarInsumo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents btnVerStock As System.Windows.Forms.Button
End Class
