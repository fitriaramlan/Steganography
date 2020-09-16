Public Class frmLaporan

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        With SFD
            .InitialDirectory = My.Application.Info.DirectoryPath
            .FileName = ""
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                rtbHitung.SaveFile(.FileName, RichTextBoxStreamType.TextTextOleObjs)
            End If
        End With
    End Sub

    Private Sub rtbHitung_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtbHitung.KeyPress
        e.KeyChar = ""
    End Sub

End Class