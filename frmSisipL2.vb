Public Class frmSisipL2

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If ofdOldFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim bm As New Bitmap(ofdOldFile.FileName)

            'Set citra ke variabel
            txtFileInput.Text = ofdOldFile.FileName

            ImgOriginal1 = bm
            picCitra.BackgroundImage = bm
            picCitra.BackgroundImageLayout = ImageLayout.Stretch
            lblUkuran.Text = "Ukuran citra :  " & ImgOriginal1.Width & " x " & ImgOriginal1.Height
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If originalArray2 Is Nothing Then
            MsgBox("Ekstraksi citra sampul belum dihasilkan !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        '-------------------------------------
        ' Revisi Terakhir
        '-------------------------------------
        If (ImgOriginal.Height * ImgOriginal.Width) > CInt(lblTotal.Text) Then
            MsgBox("Citra biner tidak dapat disisipkan ke dalam citra sampul !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        '-------------------------------------
        Me.Close()
        frmSisipL3.ShowDialog()
    End Sub

    Private Sub btnEkstraksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEkstraksi.Click
        btnEkstraksi.Enabled = False
        Dim start_time As Date = Now
        Dim stop_time As Date
        Dim elapsed_time As TimeSpan
        Dim nIndeks As Integer = 1
        Dim Hasil As T_Ruang
        Dim nTotal As Integer = 0
        Dim nWarna As Color

        Me.Cursor = Cursors.AppStarting

        Dim i As Integer
        Dim j As Integer
        Dim cLap As String = ""

        'Simpan warna piksel ke array
        originalArray0 = Nothing
        ReDim originalArray0(ImgOriginal1.Height - 1, ImgOriginal1.Width - 1, 2)
        For j = 0 To ImgOriginal1.Height - 1
            For i = 0 To ImgOriginal1.Width - 1
                nWarna = ImgOriginal1.GetPixel(i, j)

                originalArray0(j, i, 0) = nWarna.R
                originalArray0(j, i, 1) = nWarna.G
                originalArray0(j, i, 2) = nWarna.B
            Next
        Next

        'Proses pendeteksian wajah
        ReDim originalArray1(originalArray0.GetUpperBound(0), originalArray0.GetUpperBound(1), 2)
        ReDim originalArray2(originalArray0.GetUpperBound(0), originalArray0.GetUpperBound(1), 2)

        ImgResult4 = New Bitmap(ImgOriginal1)
        For i = 0 To originalArray0.GetUpperBound(0)
            For j = 0 To originalArray0.GetUpperBound(1)
                '1. Konversi ke YCbCr
                Hasil = YCbCr(originalArray0(i, j, 0), originalArray0(i, j, 1), originalArray0(i, j, 2))
                originalArray1(i, j, 0) = Hasil.Nilai1
                originalArray1(i, j, 1) = Hasil.Nilai2
                originalArray1(i, j, 2) = Hasil.Nilai3

                '2. Segmentasi Warna Kulit
                'Warna kulit --> 77 < Cb < 127 ; 133 < Cr < 177
                If originalArray1(i, j, 1) > 77 And originalArray1(i, j, 1) < 127 And _
                originalArray1(i, j, 2) > 133 And originalArray1(i, j, 2) < 177 Then
                    'Area kulit
                    originalArray2(i, j, 0) = originalArray0(i, j, 0)
                    originalArray2(i, j, 1) = originalArray0(i, j, 1)
                    originalArray2(i, j, 2) = originalArray0(i, j, 2)

                    nTotal += 1
                Else
                    originalArray2(i, j, 0) = 0
                    originalArray2(i, j, 1) = 0
                    originalArray2(i, j, 2) = 0
                End If

                ImgResult4.SetPixel(j, i, Color.FromArgb(originalArray2(i, j, 0), originalArray2(i, j, 1), originalArray2(i, j, 2)))

                stop_time = Now
                elapsed_time = stop_time - start_time
                lblTotal.Text = nTotal
            Next
        Next
        pic2.BackgroundImage = ImgResult4
        pic2.BackgroundImageLayout = ImageLayout.Stretch

        Me.Cursor = Cursors.Default
        btnEkstraksi.Enabled = True
    End Sub

    Private Sub frmSisipL2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        originalArray0 = Nothing
        originalArray1 = Nothing
        originalArray2 = Nothing
    End Sub
End Class