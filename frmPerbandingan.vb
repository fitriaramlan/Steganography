Public Class frmPerbandingan

    Dim oriArray(,,) As Double
    Dim oriArray1(,,) As Double
    Dim cNama As String
    Dim cNama1 As String

    Private Sub btnBrowse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse1.Click
        Dim i As Integer
        Dim j As Integer

        If ofdOldFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim bm As New Bitmap(ofdOldFile.FileName)
            Dim nWarna As Color

            cNama = ofdOldFile.FileName

            'Set citra ke variabel
            Original = bm
            picCitraI.BackgroundImage = bm
            picCitraI.BackgroundImageLayout = ImageLayout.Stretch

            'Simpan warna piksel ke array
            ReDim oriArray(Original.Height - 1, Original.Width - 1, 2)
            For j = 0 To Original.Height - 1
                For i = 0 To Original.Width - 1
                    If j <= bm.Height - 1 And i <= bm.Width - 1 Then
                        nWarna = bm.GetPixel(i, j)
                        oriArray(j, i, 0) = nWarna.R
                        oriArray(j, i, 1) = nWarna.G
                        oriArray(j, i, 2) = nWarna.B
                    Else
                        oriArray(j, i, 0) = 255
                        oriArray(j, i, 1) = 255
                        oriArray(j, i, 2) = 255
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub btnBrowse2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse2.Click
        Dim i As Integer
        Dim j As Integer

        If ofdOldFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim bm As New Bitmap(ofdOldFile.FileName)
            Dim nWarna As Color

            cNama1 = ofdOldFile.FileName

            'Set citra ke variabel
            Original1 = bm
            picCitraII.BackgroundImage = bm
            picCitraII.BackgroundImageLayout = ImageLayout.Stretch

            'Simpan warna piksel ke array
            ReDim oriArray1(Original1.Height - 1, Original1.Width - 1, 2)
            For j = 0 To Original1.Height - 1
                For i = 0 To Original1.Width - 1
                    If j <= bm.Height - 1 And i <= bm.Width - 1 Then
                        nWarna = bm.GetPixel(i, j)
                        oriArray1(j, i, 0) = nWarna.R
                        oriArray1(j, i, 1) = nWarna.G
                        oriArray1(j, i, 2) = nWarna.B
                    Else
                        oriArray1(j, i, 0) = 255
                        oriArray1(j, i, 1) = 255
                        oriArray1(j, i, 2) = 255
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim i As Integer
        Dim j As Integer
        Dim nSama As Double
        Dim nTidak As Double
        Dim nTotal As Double
        Dim nMSE As Double
        Dim nL As Double = 0
        Dim ListItem As ListViewItem

        If Original Is Nothing Then
            MsgBox("Citra I belum dimasukkan !", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf Original1 Is Nothing Then
            MsgBox("Citra II belum dimasukkan !", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Perbandingan
        If Original.Width = Original1.Width And Original.Height = Original1.Height Then
            For j = 0 To Original.Height - 1
                For i = 0 To Original.Width - 1
                    If oriArray(j, i, 0) = oriArray1(j, i, 0) And _
                    oriArray(j, i, 1) = oriArray1(j, i, 1) And _
                    oriArray(j, i, 2) = oriArray1(j, i, 2) Then
                        nSama += 1
                    Else
                        nTidak += 1
                    End If
                Next
            Next
            nTotal = nSama + nTidak

            lblSama.Text = nSama
            lblBerbeda.Text = nTidak
            lblTotal.Text = nTotal

            lblMirip.Text = nSama * 100 / nTotal

            'Hitung MSE
            nMSE = 0
            Dim nTotal1 As Double
            Dim nTotal2 As Double
            For j = 0 To Original.Height - 1
                For i = 0 To Original.Width - 1
                    nTotal1 = (oriArray(j, i, 0) + oriArray(j, i, 1) + oriArray(j, i, 2)) / 3
                    nTotal2 = (oriArray1(j, i, 0) + oriArray1(j, i, 1) + oriArray1(j, i, 2)) / 3
                    nMSE += (nTotal2 - nTotal1) ^ 2
                    If nL < nTotal1 Then nL = nTotal1
                    If nL < nTotal2 Then nL = nTotal2
                Next
            Next

            nMSE = Math.Round(Math.Sqrt(nMSE / (Original.Height * Original.Width)), 4)

            lblMSE.Text = nMSE

            Dim nPSNR As Double
            If nMSE = 0 Then
                nPSNR = 0
            Else
                nPSNR = 10 * Math.Log10(nL ^ 2 / nMSE)
            End If
            lblPSNR.Text = nPSNR & " db"

            'Simpan warna piksel ke array
            originalArray = Nothing
            Dim nWarna As Color
            ReDim originalArray(Original.Height - 1, Original.Width - 1)
            For j = 0 To Original.Height - 1
                For i = 0 To Original.Width - 1
                    nWarna = Original1.GetPixel(i, j)
                    originalArray(j, i) = nWarna.R
                Next
            Next

            ListItem = lstPesan.Items.Add(My.Computer.FileSystem.GetName(cNama))
            ListItem.SubItems.Add(My.Computer.FileSystem.GetName(cNama1))
            ListItem.SubItems.Add(Original.Height & " x " & Original.Width)
            ListItem.SubItems.Add(nMSE)
            ListItem.SubItems.Add(nPSNR)
        Else
            MsgBox("Ukuran citra tidak sama !", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lstPesan.Items.Clear()
        picCitraI.BackgroundImage = Nothing
        picCitraII.BackgroundImage = Nothing
        lblSama.Text = ""
        lblBerbeda.Text = ""
        lblTotal.Text = ""
        lblMirip.Text = ""
        lblMSE.Text = ""
        lblPSNR.Text = ""
    End Sub

    Private Sub lstPesan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPesan.SelectedIndexChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub frmPerbandingan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class