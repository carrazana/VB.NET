Public Class frmInicioSistema


    Private Sub MeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ABMPacienteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMPacienteToolStripMenuItem1.Click
        frmRegistrarPaciente.ShowDialog()
    End Sub

    Private Sub ABMEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMEmpleadoToolStripMenuItem.Click
        frmRegistrarEmpleado.ShowDialog()

    End Sub

    Private Sub frmInicioSistema_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que quiere salir del sistema", _
        "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = _
        Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub frmInicioSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblHora.Text = DateTime.Now.ToShortTimeString()
        Me.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lblHora.Text = TimeOfDay.TimeOfDay.ToString()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ABMCargosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ABMCargosToolStripMenuItem1.Click
        Dim frm_ABM_gener As New frmABMGenerico("cargos", "id", "descripcion")
        frm_ABM_gener.ShowDialog()
    End Sub

    Private Sub ABMEspecializacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMEspecializacionToolStripMenuItem.Click
        Dim frm_ABM_gener As New frmABMGenerico("especializaciones", "id", "descripcion")
        frm_ABM_gener.ShowDialog()
    End Sub

    Private Sub ABMTratamientosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ABMTratamientosToolStripMenuItem1.Click
        frmABMTratamiento.ShowDialog()
    End Sub

    Private Sub ABMLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMLocalidadToolStripMenuItem.Click
        Dim frm_ABM_gener As New frmABMGenerico("localidades", "id", "descripcion")
        frm_ABM_gener.ShowDialog()
    End Sub


    Private Sub ABMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMToolStripMenuItem.Click
        Dim frm_ABM_gener As New frmABMGenerico("tipoDocumentos", "id", "descripcion")
        frm_ABM_gener.ShowDialog()
    End Sub

    Private Sub ABMInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMInsumosToolStripMenuItem.Click
        Dim frm_ABM_gener As New frmABMGenerico("insumos", "id", "descripcion")
        frm_ABM_gener.ShowDialog()
    End Sub

    Private Sub ABMMutualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMMutualToolStripMenuItem.Click
        frmRegistrarProveedor.ShowDialog()
    End Sub

    Private Sub ABMBuscadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMBuscadorToolStripMenuItem.Click
        Dim frm_ABM_gener As New frmABMGenerico("buscador", "id", "descripcion")
        frm_ABM_gener.ShowDialog()
    End Sub

    Private Sub ABMTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTurnosToolStripMenuItem.Click
        frmABMTurnos.ShowDialog()
    End Sub

    Private Sub CompraInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraInsumosToolStripMenuItem.Click
        frmCompraInsumo.ShowDialog()
    End Sub

    Private Sub IntervencionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntervencionesToolStripMenuItem.Click
        frmRegistrarIntervencion.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        frmRegistrarStock.ShowDialog()
    End Sub

    Private Sub StockDeInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeInsumosToolStripMenuItem.Click
        frmListadoStock.ShowDialog()

    End Sub

    Private Sub TurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnosToolStripMenuItem.Click
        frmListadoTurnos.ShowDialog()

    End Sub

    Private Sub TratamientosMasUsadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientosMasUsadosToolStripMenuItem.Click
        frmEstadisticaTratamientosMasUsados.ShowDialog()
    End Sub

    Private Sub btnTurnos_Click(sender As Object, e As EventArgs) Handles btnTurnos.Click
        frmABMTurnos.ShowDialog()
    End Sub

    Private Sub QueFaltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("terminar reportes, agregar columna stock, controlar stock")
    End Sub

    Private Sub QueFaltaToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        MsgBox("Cuando pongo modificar en proveedor no te deja cargar depto y numero, terminar reportes")
    End Sub

    Private Sub InsumosMasUsadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        InsumosMasUsadosvb.ShowDialog()
    End Sub

    Private Sub ProfesionalConMasIntervencionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesionalConMasIntervencionesToolStripMenuItem.Click
        frmProfesionalConMasTurnos.ShowDialog()
    End Sub

    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click
        frmListadoPacientes.ShowDialog()
    End Sub
End Class