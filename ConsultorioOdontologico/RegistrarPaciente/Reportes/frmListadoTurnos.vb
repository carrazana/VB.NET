Public Class frmListadoTurnos
    Private Sub frmListadoTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Reporte As New ReporteTurnos
        CrystalReportViewer1.ReportSource = Reporte
        CrystalReportViewer1.Show()
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class