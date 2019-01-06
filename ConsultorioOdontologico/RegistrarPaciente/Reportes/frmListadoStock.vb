Public Class frmListadoStock
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
        Dim Reporte As New ReporteStock
        CrystalReportViewer1.ReportSource = Reporte
        CrystalReportViewer1.Show()
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class