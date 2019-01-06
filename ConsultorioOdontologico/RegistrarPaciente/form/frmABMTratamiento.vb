Public Class frmABMTratamiento
    Enum estado
        insertar
        modificar
    End Enum
    Enum valida
        ok
        errores
    End Enum
    Enum respuesta
        si
        no
    End Enum
    Dim accion As estado = estado.insertar
    Dim validar As valida = valida.errores

    Private Sub frmABMTratamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblHora.Text = DateTime.Now.ToShortTimeString()
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Me.cargo_grilla(leo_tabla())
    End Sub


    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Me.accion = estado.insertar
        Me.txtID.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtCosto.Text = ""
        Me.txtID.Enabled = True
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub cargo_grilla(ByVal tabla As Data.DataTable)
        Me.dgv.DataSource = tabla
        Me.seteo_grilla()
    End Sub

    Private Sub seteo_grilla()

        Me.dgv.Columns(0).HeaderText = "Id"
        Me.dgv.Columns(1).HeaderText = "Descripción"
        Me.dgv.Columns(2).HeaderText = "Costo"
        Me.dgv.Columns(1).Width = 150

    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If validacion() = valida.ok Then
            If Me.accion = estado.insertar Then
                Me.insertar()
                Me.accion = estado.modificar
            Else
                Me.modificar()
            End If
            Me.cargo_grilla(leo_tabla())
        End If
        Me.accion = estado.insertar
        Me.txtID.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtCosto.Text = ""
        Me.txtID.Enabled = True
        Me.txtDescripcion.Focus()
    End Sub
    Private Function validacion() As valida

        If Me.txtDescripcion.Text = "" Then
            MsgBox("El nombre del tipo no puede estar vacio", MsgBoxStyle.Critical, "Error")
            Me.txtDescripcion.Focus()
            Return valida.errores
        End If
        Return valida.ok
    End Function
    Private Sub insertar()

        Dim valor As Integer = 0



        If txtID.Text = "" Then
            valor = BDHelper.getIdTratamiento().Rows(0)("ultimo")
            Me.txtID.Text = valor
        End If


        BDHelper.guardarTratamiento(txtID.Text, txtDescripcion.Text, txtCosto.Text)
   
    End Sub
    Private Sub modificar()

        BDHelper.modificarTratamiento(txtID.Text, txtDescripcion.Text, txtCosto.Text)
       
    End Sub
    Private Function leo_tabla() As Data.DataTable

        Return BDHelper.cargarTratamiento()

    End Function


    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.DoubleClick

        'MsgBox(Me.grid.Rows(Me.grid.CurrentRow.Index).Cells(1).Value)
        Me.txtDescripcion.Text = Me.dgv.CurrentRow.Cells(1).Value
        Me.txtID.Text = Me.dgv.CurrentRow.Cells(0).Value
        Me.txtCosto.Text = Me.dgv.CurrentRow.Cells(2).Value
        Me.accion = estado.modificar
        Me.txtDescripcion.Focus()
        Me.txtID.Enabled = False


    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        Dim id As Integer = Me.dgv.CurrentRow.Cells(0).Value
        If (MessageBox.Show("Está seguro que desea borrar ese registro", "Atención", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question, _
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK) Then
            BDHelper.borrarTratamiento(id)
            
            Me.cargo_grilla(leo_tabla())
        End If
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        dgv.DataSource = BDHelper.BuscarTratamiento("descripcion", Me.txtDescripcion.Text)
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        Me.cargo_grilla(leo_tabla())
    End Sub
End Class