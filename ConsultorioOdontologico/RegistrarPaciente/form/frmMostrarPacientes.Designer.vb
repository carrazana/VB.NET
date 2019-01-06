<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarPacientes
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
        Me.dgvTodos = New System.Windows.Forms.DataGridView()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmb_Buscador = New System.Windows.Forms.ComboBox()
        Me.txt_IngresarDatos = New System.Windows.Forms.TextBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTodos
        '
        Me.dgvTodos.AllowUserToAddRows = False
        Me.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodos.Location = New System.Drawing.Point(17, 94)
        Me.dgvTodos.Name = "dgvTodos"
        Me.dgvTodos.ReadOnly = True
        Me.dgvTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodos.Size = New System.Drawing.Size(540, 284)
        Me.dgvTodos.TabIndex = 0
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.actualizar
        Me.cmdActualizar.Location = New System.Drawing.Point(504, 12)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(53, 47)
        Me.cmdActualizar.TabIndex = 57
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'cmb_Buscador
        '
        Me.cmb_Buscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Buscador.FormattingEnabled = True
        Me.cmb_Buscador.Items.AddRange(New Object() {"Nombre", "Apellido", "Documento"})
        Me.cmb_Buscador.Location = New System.Drawing.Point(250, 26)
        Me.cmb_Buscador.Name = "cmb_Buscador"
        Me.cmb_Buscador.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Buscador.TabIndex = 56
        '
        'txt_IngresarDatos
        '
        Me.txt_IngresarDatos.Location = New System.Drawing.Point(34, 26)
        Me.txt_IngresarDatos.MaxLength = 30
        Me.txt_IngresarDatos.Name = "txt_IngresarDatos"
        Me.txt_IngresarDatos.Size = New System.Drawing.Size(193, 20)
        Me.txt_IngresarDatos.TabIndex = 55
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Image = Global.ConsultorioOdontologico.My.Resources.Resources.BUSCAR01
        Me.cmd_Buscar.Location = New System.Drawing.Point(432, 12)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(53, 47)
        Me.cmd_Buscar.TabIndex = 54
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(161, 414)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 59
        Me.cmdAceptar.Text = "ACEPTAR"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(267, 414)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 60
        Me.cmdCancelar.Text = "CANCELAR"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmMostrarPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(584, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmb_Buscador)
        Me.Controls.Add(Me.txt_IngresarDatos)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.dgvTodos)
        Me.Name = "frmMostrarPacientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMostrarPacientes"
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTodos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmb_Buscador As System.Windows.Forms.ComboBox
    Friend WithEvents txt_IngresarDatos As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Buscar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
