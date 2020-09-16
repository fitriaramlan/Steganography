Public Class frmEkstrakL1

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click
        With frmLaporan
            .rtbHitung.Text = cLap
            .ShowDialog()
        End With
    End Sub

    Private Sub btnRekonstruksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRekonstruksi.Click
        Dim nL As Integer = CInt(0 & txtL.Text)
        Dim nWarna As Color
        Dim nXH As Integer
        Dim nYH As Integer

        If nL = 0 Then
            MsgBox("Nilai L masih kosong !", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim i As Integer
        Dim j As Integer

        'Simpan warna piksel ke array
        originalArray = Nothing
        ReDim originalArray(ImgOriginal.Height - 1, ImgOriginal.Width - 1)
        For j = 0 To ImgResult3.Height - 1
            For i = 0 To ImgResult3.Width - 1
                nWarna = ImgResult3.GetPixel(i, j)

                If nWarna.R <= 128 Then
                    originalArray(j, i) = 0
                Else
                    originalArray(j, i) = 1
                End If

                If nWarna.R <> nWarna.G Or nWarna.R <> nWarna.B Then
                    MsgBox("Citra input harus berupa citra biner (citra hitam putih) !", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Next
        Next

        'Acak citra dengan metode Shin
        Dim ArrHasil(,) As String = Chaos(nL, ImgResult3.Height)
        Dim cTemp() As String

        ImgResult = New Bitmap(ImgResult3)
        ReDim resultArray(ImgResult3.Height - 1, ImgResult3.Width - 1)
        For j = 0 To ImgResult3.Height - 1
            For i = 0 To ImgResult3.Width - 1
                cTemp = Split(ArrHasil(j, i), ",")
                nXH = CInt(cTemp(0))
                nYH = CInt(cTemp(1))

                If originalArray(nYH, nXH) = 0 Then
                    resultArray(nYH, nXH) = 0
                Else
                    resultArray(nYH, nXH) = 255
                End If
                'ImgResult.SetPixel(nXH, nYH, Color.FromArgb(resultArray(j, i), resultArray(j, i), resultArray(j, i)))
                ImgResult.SetPixel(i, j, Color.FromArgb(resultArray(nYH, nXH), resultArray(nYH, nXH), resultArray(nYH, nXH)))
            Next
        Next
        picCitraHasil.BackgroundImage = ImgResult
        picCitraHasil.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub txtL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtL.KeyPress
        If Not ((Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9")) Or Asc(e.KeyChar) = 8) Then
            'Batalkan input selain digit angka
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtL.TextChanged

    End Sub

    Private Sub btnEkstraksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEkstraksi.Click
        btnEkstraksi.Enabled = False

        'Proses ekstraksi warna kulit
        Dim start_time As Date = Now
        Dim nIndeks As Integer = 1
        Dim Hasil As T_Ruang
        Dim nWarna As Color

        Dim cTempBit As String = ""

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

        'Proses ekstraksi ukuran lebar dan tinggi citra biner
        Dim nLebar As Integer
        Dim nTinggi As Integer
        Dim cBitLebar As String = ""
        Dim cBitTinggi As String = ""
        Dim cBit As String

        cBit = FDec2Biner(originalArray0(0, 0, 0), 8)
        cBitLebar = Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 0, 1), 8)
        cBitLebar &= Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 0, 2), 8)
        cBitLebar &= Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 1, 0), 8)
        cBitLebar = Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 1, 1), 8)
        cBitLebar &= Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 1, 2), 8)
        cBitLebar &= Mid(cBit, 6, 3)


        cBit = FDec2Biner(originalArray0(0, 2, 0), 8)
        cBitTinggi = Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 2, 1), 8)
        cBitTinggi &= Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 2, 2), 8)
        cBitTinggi &= Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 3, 0), 8)
        cBitTinggi = Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 3, 1), 8)
        cBitTinggi &= Mid(cBit, 6, 3)

        cBit = FDec2Biner(originalArray0(0, 3, 2), 8)
        cBitTinggi &= Mid(cBit, 6, 3)

        nLebar = FBiner2Dec(cBitLebar)
        nTinggi = FBiner2Dec(cBitTinggi)


        'Proses pendeteksian wajah
        ReDim originalArray1(originalArray0.GetUpperBound(0), originalArray0.GetUpperBound(1), 2)
        ReDim originalArray2(originalArray0.GetUpperBound(0), originalArray0.GetUpperBound(1), 2)

        ImgResult3 = New Bitmap(nLebar, nTinggi)
        cTempBit = ""

        For i = 0 To originalArray0.GetUpperBound(0)
            For j = 0 To originalArray0.GetUpperBound(1)
                '1. Konversi ke YCbCr
                Hasil = YCbCr(originalArray0(i, j, 0), originalArray0(i, j, 1), originalArray0(i, j, 2))
                originalArray1(i, j, 0) = Hasil.Nilai1
                originalArray1(i, j, 1) = Hasil.Nilai2
                originalArray1(i, j, 2) = Hasil.Nilai3
            Next
        Next

        Dim nTemp As Integer
        Dim nTemp1 As Integer
        For i = 1 To strPosisi.Length Step 6
            nTemp = Mid(strPosisi, i, 3)
            nTemp1 = Mid(strPosisi, i + 3, 3)
            cTempBit &= Mid(FDec2Biner(originalArray1(nTemp, nTemp1, 2), 8), 8, 1)
        Next

        'For i = 0 To originalArray0.GetUpperBound(0)
        '    For j = 0 To originalArray0.GetUpperBound(1)
        '        '1. Konversi ke YCbCr
        '        Hasil = YCbCr(originalArray0(i, j, 0), originalArray0(i, j, 1), originalArray0(i, j, 2))
        '        originalArray1(i, j, 0) = Hasil.Nilai1
        '        originalArray1(i, j, 1) = Hasil.Nilai2
        '        originalArray1(i, j, 2) = Hasil.Nilai3

        '        '2. Segmentasi Warna Kulit
        '        'Warna kulit --> 77 < Cb < 127 ; 133 < Cr < 177
        '        If i = 0 And j <= 3 Then

        '        ElseIf originalArray1(i, j, 1) > 77 And originalArray1(i, j, 1) < 127 And _
        '        originalArray1(i, j, 2) > 133 And originalArray1(i, j, 2) < 177 Then
        '            'Area kulit --> ekstrak keluar bit-nya lohhhh dari Cr ....
        '            If cTempBit.Length < nLebar * nTinggi Then
        '                strPosisi &= Format(i, "000") & Format(j, "000")
        '                cTempBit &= Mid(FDec2Biner(originalArray1(i, j, 2), 8), 8, 1)
        '            End If
        '        End If
        '    Next
        'Next

        'Susun bit terekstrak jadi bentuk citra
        Dim nSuku As Integer = 0
        For j = 0 To nTinggi - 1
            For i = 0 To nLebar - 1
                nSuku += 1
                cBit = Mid(cTempBit, nSuku, 1)
                If cBit = "0" Then
                    ImgResult3.SetPixel(i, j, Color.FromArgb(0, 0, 0))
                Else
                    ImgResult3.SetPixel(i, j, Color.FromArgb(255, 255, 255))
                End If
            Next
        Next

        picCitraTeracak.BackgroundImage = ImgResult3

        'Hitung total waktu yang diperlukan
        Dim stop_time As Date = Now
        Dim elapsed_time As TimeSpan = stop_time - start_time
        lblWaktu.Text = elapsed_time.Minutes.ToString & " : " & elapsed_time.Seconds.ToString & " . " & _
                        elapsed_time.Milliseconds.ToString

        Me.Cursor = Cursors.Default
        btnEkstraksi.Enabled = True
    End Sub
End Class