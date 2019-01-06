Public Class frmCapturar


    Private Sub frmCapturar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        WebCam1.Stop()

    End Sub

    Private Sub frmCapturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebCam1.Start()
    End Sub

    Private Sub cmdCapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapturar.Click
        Me.PictureCapturar.Image = WebCam1.Imagen
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If PictureCapturar.Image Is Nothing = False Then
            SaveGuardarImagen.ShowDialog()
        Else
            MsgBox("No hay imagen para mostrar", MsgBoxStyle.Exclamation)
        End If
        Me.Close()
    End Sub

    Private Sub SaveGuardarImagen_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveGuardarImagen.FileOk
        PictureCapturar.Image.Save(SaveGuardarImagen.FileName)
    End Sub


End Class