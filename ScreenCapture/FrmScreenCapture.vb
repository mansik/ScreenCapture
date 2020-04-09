Imports System
Imports System.Drawing

Public Class FrmScreenCapture
    Private bMap As Bitmap

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        CaptureBox.Image = Nothing
    End Sub

    Private Sub CaptureBtn_Click(sender As System.Object, e As System.EventArgs) Handles CaptureBtn.Click
        Try
            bMap = New Bitmap(CaptureBox.Width, CaptureBox.Height)

            Dim gp As Graphics = Graphics.FromImage(bMap)
            gp.CopyFromScreen(PointToScreen(New Point(CaptureBox.Location.X, CaptureBox.Location.Y)), New Point(0, 0), bMap.Size)

            gp.Dispose()

            '화면에 보여주기
            CaptureBox.Image = bMap

            '클립보드로 복사
            Clipboard.SetImage(bMap)
        Catch ex As Exception
            MsgBox("CaptureBtn_Click : " + ex.Message)
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles SaveBtn.Click
        Try
            FileSaveDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            FileSaveDlg.DefaultExt = "jpg"
            FileSaveDlg.Filter = "jpg|*.jpg|All files (*.*)|*.*"
            FileSaveDlg.ShowDialog()
            If (Me.FileSaveDlg.FileName = "") Then
                Exit Sub
            Else
                Dim SaveFileName As String = FileSaveDlg.FileName

                bMap.Save(SaveFileName)

            End If

        Catch ex As Exception
            MsgBox("SaveBtn_Click : " + ex.Message)
        End Try
    End Sub
End Class
