<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioSistema
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioSistema))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMPacienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMMutualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMCargosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMTratamientosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMEspecializacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMBuscadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntervencionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDeInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientosMasUsadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesionalConMasIntervencionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnTurnos = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.StockToolStripMenuItem, Me.InformesToolStripMenuItem, Me.EstadisticasToolStripMenuItem, Me.MeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(568, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMPacienteToolStripMenuItem1, Me.ABMEmpleadoToolStripMenuItem, Me.ABMMutualToolStripMenuItem, Me.ABMTurnosToolStripMenuItem, Me.OTROSToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "ABMs"
        '
        'ABMPacienteToolStripMenuItem1
        '
        Me.ABMPacienteToolStripMenuItem1.Name = "ABMPacienteToolStripMenuItem1"
        Me.ABMPacienteToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ABMPacienteToolStripMenuItem1.Text = "ABM Paciente"
        '
        'ABMEmpleadoToolStripMenuItem
        '
        Me.ABMEmpleadoToolStripMenuItem.Name = "ABMEmpleadoToolStripMenuItem"
        Me.ABMEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ABMEmpleadoToolStripMenuItem.Text = "ABM Empleado"
        '
        'ABMMutualToolStripMenuItem
        '
        Me.ABMMutualToolStripMenuItem.Name = "ABMMutualToolStripMenuItem"
        Me.ABMMutualToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ABMMutualToolStripMenuItem.Text = "ABM Proveedor"
        '
        'ABMTurnosToolStripMenuItem
        '
        Me.ABMTurnosToolStripMenuItem.Name = "ABMTurnosToolStripMenuItem"
        Me.ABMTurnosToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ABMTurnosToolStripMenuItem.Text = "ABM Turnos"
        '
        'OTROSToolStripMenuItem
        '
        Me.OTROSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMCargosToolStripMenuItem1, Me.ABMLocalidadToolStripMenuItem, Me.ABMToolStripMenuItem, Me.ABMTratamientosToolStripMenuItem1, Me.ABMEspecializacionToolStripMenuItem, Me.ABMInsumosToolStripMenuItem, Me.ABMBuscadorToolStripMenuItem})
        Me.OTROSToolStripMenuItem.Name = "OTROSToolStripMenuItem"
        Me.OTROSToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OTROSToolStripMenuItem.Text = "OTROS"
        '
        'ABMCargosToolStripMenuItem1
        '
        Me.ABMCargosToolStripMenuItem1.Name = "ABMCargosToolStripMenuItem1"
        Me.ABMCargosToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.ABMCargosToolStripMenuItem1.Text = "ABM Cargo"
        '
        'ABMLocalidadToolStripMenuItem
        '
        Me.ABMLocalidadToolStripMenuItem.Name = "ABMLocalidadToolStripMenuItem"
        Me.ABMLocalidadToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMLocalidadToolStripMenuItem.Text = "ABM Localidad"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMToolStripMenuItem.Text = "ABM Tipo Documento"
        '
        'ABMTratamientosToolStripMenuItem1
        '
        Me.ABMTratamientosToolStripMenuItem1.Name = "ABMTratamientosToolStripMenuItem1"
        Me.ABMTratamientosToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.ABMTratamientosToolStripMenuItem1.Text = "ABM Tratamiento"
        '
        'ABMEspecializacionToolStripMenuItem
        '
        Me.ABMEspecializacionToolStripMenuItem.Name = "ABMEspecializacionToolStripMenuItem"
        Me.ABMEspecializacionToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMEspecializacionToolStripMenuItem.Text = "ABM Especializacion"
        '
        'ABMInsumosToolStripMenuItem
        '
        Me.ABMInsumosToolStripMenuItem.Name = "ABMInsumosToolStripMenuItem"
        Me.ABMInsumosToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMInsumosToolStripMenuItem.Text = "ABM Insumos"
        '
        'ABMBuscadorToolStripMenuItem
        '
        Me.ABMBuscadorToolStripMenuItem.Name = "ABMBuscadorToolStripMenuItem"
        Me.ABMBuscadorToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ABMBuscadorToolStripMenuItem.Text = "ABM Buscador"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompraInsumosToolStripMenuItem, Me.IntervencionesToolStripMenuItem})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.TransaccionesToolStripMenuItem.Text = "Transacciones"
        '
        'CompraInsumosToolStripMenuItem
        '
        Me.CompraInsumosToolStripMenuItem.Name = "CompraInsumosToolStripMenuItem"
        Me.CompraInsumosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CompraInsumosToolStripMenuItem.Text = "Compra Insumos"
        '
        'IntervencionesToolStripMenuItem
        '
        Me.IntervencionesToolStripMenuItem.Name = "IntervencionesToolStripMenuItem"
        Me.IntervencionesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.IntervencionesToolStripMenuItem.Text = "Intervenciones"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockDeInsumosToolStripMenuItem, Me.TurnosToolStripMenuItem, Me.PacientesToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.InformesToolStripMenuItem.Text = "Listados"
        '
        'StockDeInsumosToolStripMenuItem
        '
        Me.StockDeInsumosToolStripMenuItem.Name = "StockDeInsumosToolStripMenuItem"
        Me.StockDeInsumosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.StockDeInsumosToolStripMenuItem.Text = "Stock de Insumos"
        '
        'TurnosToolStripMenuItem
        '
        Me.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem"
        Me.TurnosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TurnosToolStripMenuItem.Text = "Turnos"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TratamientosMasUsadosToolStripMenuItem, Me.ProfesionalConMasIntervencionesToolStripMenuItem})
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'TratamientosMasUsadosToolStripMenuItem
        '
        Me.TratamientosMasUsadosToolStripMenuItem.Name = "TratamientosMasUsadosToolStripMenuItem"
        Me.TratamientosMasUsadosToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.TratamientosMasUsadosToolStripMenuItem.Text = "Tratamientos mas usados"
        '
        'ProfesionalConMasIntervencionesToolStripMenuItem
        '
        Me.ProfesionalConMasIntervencionesToolStripMenuItem.Name = "ProfesionalConMasIntervencionesToolStripMenuItem"
        Me.ProfesionalConMasIntervencionesToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ProfesionalConMasIntervencionesToolStripMenuItem.Text = "Profesional con mas Turnos"
        '
        'MeToolStripMenuItem
        '
        Me.MeToolStripMenuItem.Name = "MeToolStripMenuItem"
        Me.MeToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.MeToolStripMenuItem.Text = "Salir"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(6, 48)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(81, 33)
        Me.lblFecha.TabIndex = 42
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(194, 48)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(69, 33)
        Me.lblHora.TabIndex = 43
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnTurnos
        '
        Me.btnTurnos.BackColor = System.Drawing.Color.Transparent
        Me.btnTurnos.Image = Global.ConsultorioOdontologico.My.Resources.Resources.turnos
        Me.btnTurnos.Location = New System.Drawing.Point(27, 118)
        Me.btnTurnos.Name = "btnTurnos"
        Me.btnTurnos.Size = New System.Drawing.Size(102, 104)
        Me.btnTurnos.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btnTurnos, "Turnos")
        Me.btnTurnos.UseVisualStyleBackColor = False
        '
        'frmInicioSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 506)
        Me.Controls.Add(Me.btnTurnos)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmInicioSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultorio Odontologico"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMPacienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMMutualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OTROSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMCargosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMLocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMTratamientosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMEspecializacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMBuscadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMTurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntervencionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDeInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TratamientosMasUsadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesionalConMasIntervencionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTurnos As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
