Public Class frmDekripsi

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If ofdOldFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim bm As New Bitmap(ofdOldFile.FileName)

            'If bm.Width > 1000 Or bm.Height > 1000 Then
            '    MsgBox("Ukuran citra maksimal 1000 x 1000 !", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If

            'Set citra ke variabel
            txtFileInput.Text = ofdOldFile.FileName

            ImgOriginal = bm
            picCitra.BackgroundImage = bm
            picCitra.BackgroundImageLayout = ImageLayout.Stretch
            lblUkuran.Text = "Ukuran citra :  " & ImgOriginal.Width & " x " & ImgOriginal.Height

            Dim NamaFile As String = ofdOldFile.FileName
            Dim Path As String = Mid(NamaFile, 1, NamaFile.Length - 4) & ".key"
            Dim reader As New System.IO.StreamReader(Path)
            Dim Temp As String

            strPosisi = ""
            Do
                Temp = reader.ReadLine
                If Temp Is Nothing Then
                Else
                    strPosisi &= Temp
                End If
            Loop Until Temp Is Nothing
            reader.Close()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnLanjut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLanjut.Click
        frmEkstrakL1.ShowDialog()
    End Sub

    Private Sub btnDekripsi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDekripsi.Click
        Dim i As Integer
        Dim j As Integer
        Dim strWarna As String = ""
        Dim strHasil As String = ""
        Dim cNilaiKunci As String
        Dim TempSubKunci As String = ""
        Dim nWarna As Color

        If txtPwd.Text.Trim = "" Then
            MsgBox("Password masih kosong !", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Simpan warna piksel ke array
        originalArray1 = Nothing
        ReDim originalArray1(ImgOriginal.Height - 1, ImgOriginal.Width - 1, 2)
        For j = 0 To ImgOriginal.Height - 1
            For i = 0 To ImgOriginal.Width - 1
                nWarna = ImgOriginal.GetPixel(i, j)

                originalArray1(j, i, 0) = nWarna.R
                originalArray1(j, i, 1) = nWarna.G
                originalArray1(j, i, 2) = nWarna.B
            Next
        Next
        ImgResult5 = New Bitmap(ImgOriginal.Width, ImgOriginal.Height)

        Dim SubKunci As String = KeyGeneration(txtPwd.Text)
        Dim Suku As Long = 0
        Dim TotalLength As Long = (originalArray1.GetUpperBound(0) + 1) * (originalArray1.GetUpperBound(1) + 1) * (originalArray1.GetUpperBound(2) + 1) * 8

        ''Buat kunci jadi sepanjang bit citra
        'TempSubKunci = SubKunci
        'Do
        '    TempSubKunci &= SubKunci
        'Loop Until TempSubKunci.Length >= TotalLength
        'SubKunci = Mid(TempSubKunci, 1, TotalLength)

        Dim nL As Integer = FBiner2Dec(Mid(SubKunci, 1, 8))
        Dekripsi(nL)

        originalArray1 = Nothing
        ReDim originalArray1(ImgResult.Height - 1, ImgResult.Width - 1, 2)
        For j = 0 To ImgResult.Height - 1
            For i = 0 To ImgResult.Width - 1
                nWarna = ImgResult.GetPixel(i, j)

                originalArray1(j, i, 0) = nWarna.R
                originalArray1(j, i, 1) = nWarna.G
                originalArray1(j, i, 2) = nWarna.B
            Next
        Next

        TempSubKunci = SubKunci

        Suku = 1
        ReDim resultArray4(originalArray1.GetUpperBound(0), originalArray1.GetUpperBound(1), 2)
        For i = 0 To originalArray1.GetUpperBound(0)
            For j = 0 To originalArray1.GetUpperBound(1)
                'For k = 0 To originalArray1.GetUpperBound(2)
                cNilaiKunci = Mid(SubKunci, Suku, 8)
                If cNilaiKunci.Length < 8 Then
                    SubKunci = cNilaiKunci & TempSubKunci
                    Suku = 1
                    cNilaiKunci = Mid(SubKunci, Suku, 8)
                End If

                resultArray4(i, j, 0) = FBiner2Dec(FXOR(FDec2Biner(originalArray1(i, j, 0), 8), cNilaiKunci))
                resultArray4(i, j, 1) = originalArray1(i, j, 1)
                resultArray4(i, j, 2) = originalArray1(i, j, 2)

                Suku += 8
                'Next
                ImgResult5.SetPixel(j, i, Color.FromArgb(resultArray4(i, j, 0), resultArray4(i, j, 1), resultArray4(i, j, 2)))
            Next
        Next

        picDekripsi.BackgroundImage = ImgResult5
        picDekripsi.BackgroundImageLayout = ImageLayout.Stretch

        ImgOriginal1 = ImgResult5.Clone

        'ImgOriginal1 = ImgOriginal.Clone
    End Sub

    Sub Dekripsi(ByVal nL As Integer)
        'Dim nWarna As Color
        Dim nXH As Integer
        Dim nYH As Integer

        'If nL = 0 Then
        '    MsgBox("Nilai L masih kosong !", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        Dim i As Integer
        Dim j As Integer

        ''Simpan warna piksel ke array
        'originalArray6 = Nothing
        'ReDim originalArray6(ImgResult5.Height - 1, ImgResult5.Width - 1, 2)
        'For j = 0 To ImgResult5.Height - 1
        '    For i = 0 To ImgResult5.Width - 1
        '        nWarna = ImgResult5.GetPixel(i, j)

        '        originalArray6(j, i, 0) = nWarna.R
        '        originalArray6(j, i, 1) = nWarna.G
        '        originalArray6(j, i, 2) = nWarna.B

        '        'If nWarna.R <= 128 Then
        '        '    originalArray(j, i) = 0
        '        'Else
        '        '    originalArray(j, i) = 1
        '        'End If

        '        'If nWarna.R <> nWarna.G Or nWarna.R <> nWarna.B Then
        '        '    MsgBox("Citra input harus berupa citra biner (citra hitam putih) !", MsgBoxStyle.Critical)
        '        '    Exit Sub
        '        'End If
        '    Next
        'Next

        'Acak citra dengan metode Shin
        Dim ArrHasil(,) As String = Chaos(nL, ImgResult5.Height)
        Dim cTemp() As String

        ImgResult = New Bitmap(ImgResult5)
        ReDim resultArray(ImgResult5.Height - 1, ImgResult5.Width - 1)
        For j = 0 To ImgResult5.Height - 1
            For i = 0 To ImgResult5.Width - 1
                cTemp = Split(ArrHasil(j, i), ",")
                nXH = CInt(cTemp(0))
                nYH = CInt(cTemp(1))

                'If originalArray(nYH, nXH) = 0 Then
                '    resultArray(nYH, nXH) = 0
                'Else
                '    resultArray(nYH, nXH) = 255
                'End If
                'ImgResult.SetPixel(nXH, nYH, Color.FromArgb(resultArray(j, i), resultArray(j, i), resultArray(j, i)))
                ImgResult.SetPixel(i, j, Color.FromArgb(originalArray1(nYH, nXH, 0), originalArray1(nYH, nXH, 1), originalArray1(nYH, nXH, 2)))
            Next
        Next
        'picDekripsi.BackgroundImage = ImgResult
        'picDekripsi.BackgroundImageLayout = ImageLayout.Stretch

        'ImgOriginal1 = ImgResult.Clone
    End Sub

    Private Sub frmDekripsi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class