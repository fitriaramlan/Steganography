Public Class frmMain1

    Private Sub MetodeEnkripsiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetodeEnkripsiToolStripMenuItem.Click
        frmSisipL1.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MetodeSteganografiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetodeSteganografiToolStripMenuItem.Click
        frmDekripsi.ShowDialog()
    End Sub

    Private Sub ProsesPengujianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProsesPengujianToolStripMenuItem.Click
        frmNoise.ShowDialog()
    End Sub

    Private Sub PengujianMSEPSNRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengujianMSEPSNRToolStripMenuItem.Click
        frmPerbandingan.ShowDialog()
    End Sub
End Class
