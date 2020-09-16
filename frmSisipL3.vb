Public Class frmSisipL3

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        dlgSavePicture.Filter = "Graphics Files|*.bmp;*.jpg;*.jpeg|All Files|*.*"
        If dlgSavePicture.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Simpan citra hasil enkripsi
            txtCitraHasil.Text = dlgSavePicture.FileName
        End If

        If ImgResult3 Is Nothing Then
            MsgBox("Proses Penyisipan belum dilakukan !", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If txtCitraHasil.Text.Trim <> "" Then
            Try
                ImgResult3.Save(txtCitraHasil.Text)
                MessageBox.Show("Citra Tersimpan !", "Simpan Citra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Nama file citra hasil masih kosong !", "Simpan Citra", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnLanjut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLanjut.Click
        Me.Close()
        frmEnkripsi.ShowDialog()
    End Sub

    Private Sub btnSisip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSisip.Click
        Dim start_time As Date = Now

        'Proses penyisipan
        Dim i As Integer
        Dim j As Integer
        Dim cTempBit As String = ""
        Dim cArrBit() As String
        Dim nSuku As Integer = 0
        Dim nWarna As Color
        Dim Hasil As T_Ruang

        'Baca bit citra biner teracak
        ReDim cArrBit((resultArray.GetUpperBound(0) + 1) * (resultArray.GetUpperBound(1) + 1))
        nSuku = 0
        For j = 0 To ImgResult.Height - 1
            For i = 0 To ImgResult.Width - 1
                nWarna = ImgResult.GetPixel(i, j)
                'Kelompokkan bit citra biner teracak
                nSuku += 1
                If nSuku > cArrBit.GetUpperBound(0) Then
                    Exit For
                Else
                    If nWarna.R = 0 Then
                        cArrBit(nSuku) = 0
                    Else
                        cArrBit(nSuku) = 1
                    End If
                    cTempBit &= cArrBit(nSuku)
                End If
            Next
        Next

        ImgResult3 = New Bitmap(ImgOriginal1)
        ReDim resultArray(ImgOriginal1.Height - 1, ImgOriginal1.Width - 1)

        cTempBit = ""
        nSuku = 0
        strPosisi = ""
        ReDim originalArray3(originalArray1.GetUpperBound(0), originalArray1.GetUpperBound(1), originalArray1.GetUpperBound(2))
        For i = 0 To originalArray2.GetUpperBound(0)
            For j = 0 To originalArray2.GetUpperBound(1)
                If i = 0 And j <= 3 Then

                ElseIf originalArray2(i, j, 2) > 0 Then
                    'Merupakan area kulit --> sisip di Cr
                    cTempBit = FDec2Biner(originalArray1(i, j, 2), 8)

                    If nSuku < cArrBit.GetUpperBound(0) Then
                        strPosisi &= Format(i, "000") & Format(j, "000")
                        nSuku += 1
                        cTempBit = Kiri(cTempBit, 7) & cArrBit(nSuku)
                        originalArray1(i, j, 2) = FBiner2Dec(cTempBit)

                        Hasil = YCbCr2RGB(originalArray1(i, j, 0), originalArray1(i, j, 1), originalArray1(i, j, 2))
                        originalArray3(i, j, 0) = Hasil.Nilai1
                        originalArray3(i, j, 1) = Hasil.Nilai2
                        originalArray3(i, j, 2) = Hasil.Nilai3

                        ImgResult3.SetPixel(j, i, Color.FromArgb(originalArray3(i, j, 0), originalArray3(i, j, 1), originalArray3(i, j, 2)))
                    End If
                End If
            Next
        Next

        If nSuku < cArrBit.GetUpperBound(0) Then
            MsgBox("Citra biner tidak dapat disisipkan ke dalam citra sampul !", MsgBoxStyle.Critical)
            Exit Sub
        End If


        '------------------------------------------------------------
        'Sisip ukuran citra biner teracak ke dalam citra stego ; 
        '2 piksel awal untuk simpan lebar citra biner
        '2 piksel berikutnya untuk simpan tinggi citra biner
        '------------------------------------------------------------
        'Ubah lebar citra ke bentuk biner
        Dim cBitLebar As String = FDec2Biner(ImgOriginal.Width, 18)

        'Sisipkan bit lebar citra ke piksel 1 dan 2 (total 3 x 3 x 2 = 18 bit)
        'Piksel 1 (R)
        cTempBit = FDec2Biner(originalArray0(0, 0, 0), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitLebar, 1, 3)
        originalArray1(0, 0, 0) = FBiner2Dec(cTempBit)

        'Piksel 1 (G)
        cTempBit = FDec2Biner(originalArray0(0, 0, 1), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitLebar, 4, 3)
        originalArray1(0, 0, 1) = FBiner2Dec(cTempBit)

        'Piksel 1 (B)
        cTempBit = FDec2Biner(originalArray0(0, 0, 2), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitLebar, 7, 3)
        originalArray1(0, 0, 2) = FBiner2Dec(cTempBit)

        ImgResult3.SetPixel(0, 0, Color.FromArgb(originalArray1(0, 0, 0), originalArray1(0, 0, 1), originalArray1(0, 0, 2)))


        'Piksel 2 (R)
        cTempBit = FDec2Biner(originalArray0(0, 1, 0), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitLebar, 10, 3)
        originalArray1(0, 1, 0) = FBiner2Dec(cTempBit)

        'Piksel 2 (G)
        cTempBit = FDec2Biner(originalArray0(0, 1, 1), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitLebar, 13, 3)
        originalArray1(0, 1, 1) = FBiner2Dec(cTempBit)

        'Piksel 2 (B)
        cTempBit = FDec2Biner(originalArray0(0, 1, 2), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitLebar, 16, 3)
        originalArray1(0, 1, 2) = FBiner2Dec(cTempBit)

        ImgResult3.SetPixel(1, 0, Color.FromArgb(originalArray1(0, 1, 0), originalArray1(0, 1, 1), originalArray1(0, 1, 2)))


        'Ubah tinggi citra ke bentuk biner
        Dim cBitTinggi As String = FDec2Biner(ImgOriginal.Height, 18)

        'Sisipkan bit lebar citra ke piksel 1 dan 2 (total 3 x 3 x 2 = 18 bit)
        'Piksel 3 (R)
        cTempBit = FDec2Biner(originalArray0(0, 2, 0), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitTinggi, 1, 3)
        originalArray1(0, 2, 0) = FBiner2Dec(cTempBit)

        'Piksel 3 (G)
        cTempBit = FDec2Biner(originalArray0(0, 2, 1), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitTinggi, 4, 3)
        originalArray1(0, 2, 1) = FBiner2Dec(cTempBit)

        'Piksel 3 (B)
        cTempBit = FDec2Biner(originalArray0(0, 2, 2), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitTinggi, 7, 3)
        originalArray1(0, 2, 2) = FBiner2Dec(cTempBit)

        ImgResult3.SetPixel(2, 0, Color.FromArgb(originalArray1(0, 2, 0), originalArray1(0, 2, 1), originalArray1(0, 2, 2)))


        'Piksel 4 (R)
        cTempBit = FDec2Biner(originalArray0(0, 3, 0), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitTinggi, 10, 3)
        originalArray1(0, 3, 0) = FBiner2Dec(cTempBit)

        'Piksel 4 (G)
        cTempBit = FDec2Biner(originalArray0(0, 3, 1), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitTinggi, 13, 3)
        originalArray1(0, 3, 1) = FBiner2Dec(cTempBit)

        'Piksel 4 (B)
        cTempBit = FDec2Biner(originalArray0(0, 3, 2), 8)
        cTempBit = Kiri(cTempBit, 5) & Mid(cBitTinggi, 16, 3)
        originalArray1(0, 3, 2) = FBiner2Dec(cTempBit)

        ImgResult3.SetPixel(3, 0, Color.FromArgb(originalArray1(0, 3, 0), originalArray1(0, 3, 1), originalArray1(0, 3, 2)))

        picStego.BackgroundImage = ImgResult3

        'Hitung total waktu yang diperlukan
        Dim stop_time As Date = Now
        Dim elapsed_time As TimeSpan = stop_time - start_time
        lblWaktu.Text = elapsed_time.Seconds.ToString & " . " & _
                        elapsed_time.Milliseconds.ToString
    End Sub

    Private Sub lblWaktu_Click(sender As Object, e As EventArgs) Handles lblWaktu.Click

    End Sub

    Private Sub frmSisipL3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class