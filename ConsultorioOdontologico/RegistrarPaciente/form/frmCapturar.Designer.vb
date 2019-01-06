<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapturar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCapturar))
        Me.WebCam1 = New WebCAM.WebCam()
        Me.PictureCapturar = New System.Windows.Forms.PictureBox()
        Me.cmdCapturar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.SaveGuardarImagen = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureCapturar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebCam1
        '
        Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCam1.Imagen = Nothing
        Me.WebCam1.Location = New System.Drawing.Point(36, 26)
        Me.WebCam1.MilisegundosCaptura = 100
        Me.WebCam1.Name = "WebCam1"
        Me.WebCam1.Size = New System.Drawing.Size(285, 333)
        Me.WebCam1.TabIndex = 0
        '
        'PictureCapturar
        '
        Me.PictureCapturar.Location = New System.Drawing.Point(359, 26)
        Me.PictureCapturar.Name = "PictureCapturar"
        Me.PictureCapturar.Size = New System.Drawing.Size(297, 333)
        Me.PictureCapturar.TabIndex = 1
        Me.PictureCapturar.TabStop = False
        '
        'cmdCapturar
        '
        Me.cmdCapturar.Location = New System.Drawing.Point(373, 421)
        Me.cmdCapturar.Name = "cmdCapturar"
        Me.cmdCapturar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCapturar.TabIndex = 2
        Me.cmdCapturar.Text = "CAPTURAR"
        Me.cmdCapturar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(484, 420)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 3
        Me.cmdGuardar.Text = "GUARDAR"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'SaveGuardarImagen
        '
        Me.SaveGuardarImagen.Filter = "imagenes|*.jpg"
        '
        'frmCapturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(674, 475)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdCapturar)
        Me.Controls.Add(Me.PictureCapturar)
        Me.Controls.Add(Me.WebCam1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCapturar"
        Me.Text = "Capturar"
        CType(Me.PictureCapturar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebCam1 As WebCAM.WebCam
    Friend WithEvents PictureCapturar As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCapturar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents SaveGuardarImagen As System.Windows.Forms.SaveFileDialog
End Class
