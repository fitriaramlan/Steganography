Public Class frmEnkripsi

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        dlgSavePicture.Filter = "Graphics Files|*.bmp;*.jpg;*.jpeg|All Files|*.*"
        If dlgSavePicture.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Simpan citra hasil enkripsi
            txtCitraHasil.Text = dlgSavePicture.FileName
        End If

        If ImgResult Is Nothing Then
            MsgBox("Proses Penyisipan belum dilakukan !", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If txtCitraHasil.Text.Trim <> "" Then
            Try
                ImgResult.Save(txtCitraHasil.Text)

                Dim NamaFile As String = dlgSavePicture.FileName
                Dim Path As String = Mid(NamaFile, 1, NamaFile.Length - 4) & ".key"

                Dim writer As New System.IO.StreamWriter(Path)
                writer.WriteLine(strPosisi)
                writer.Close()

                MessageBox.Show("Citra Tersimpan !", "Simpan Citra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Nama file citra hasil masih kosong !", "Simpan Citra", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click
        With frmLaporan
            .rtbHitung.Text = cLap
            .ShowDialog()
        End With
    End Sub

    Private Sub btnEnkripsi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnkripsi.Click
        Dim i As Integer
        Dim j As Integer
        'Dim k As Integer
        Dim strWarna As String = ""
        Dim strHasil As String = ""
        Dim cNilaiKunci As String
        Dim TempSubKunci As String
        Dim nWarna As Color

        If txtPwd.Text.Trim = "" Then
            MsgBox("Password masih kosong !", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Simpan warna piksel ke array
        originalArray4 = Nothing
        ReDim originalArray4(ImgResult3.Height - 1, ImgResult3.Width - 1, 2)
        For j = 0 To ImgResult3.Height - 1
            For i = 0 To ImgResult3.Width - 1
                nWarna = ImgResult3.GetPixel(i, j)

                originalArray4(j, i, 0) = nWarna.R
                originalArray4(j, i, 1) = nWarna.G
                originalArray4(j, i, 2) = nWarna.B
            Next
        Next

        ImgResult5 = New Bitmap(ImgResult3.Width, ImgResult3.Height)

        'For i = 0 To ImgOriginal.Height - 1
        '    For j = 0 To ImgOriginal.Width - 1
        '        cHex = FDec2Biner(originalArray1(i, j, 0), 8)
        '        strWarna &= IIf(cHex.Length = 1, "0", "") & cHex
        '    Next
        'Next

        Dim SubKunci As String = KeyGeneration(txtPwd.Text)
        Dim Suku As Long = 0
        Dim TotalLength As Long = (originalArray1.GetUpperBound(0) + 1) * (originalArray1.GetUpperBound(1) + 1) * (originalArray1.GetUpperBound(2) + 1) * 8

        'Buat kunci jadi sepanjang bit citra
        'TempSubKunci = SubKunci
        'Do
        '    TempSubKunci &= SubKunci
        'Loop Until TempSubKunci.Length >= TotalLength
        'SubKunci = Mid(TempSubKunci, 1, TotalLength)

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

                resultArray4(i, j, 0) = FBiner2Dec(FXOR(FDec2Biner(originalArray4(i, j, 0), 8), cNilaiKunci))
                resultArray4(i, j, 1) = originalArray4(i, j, 1)
                resultArray4(i, j, 2) = originalArray4(i, j, 2)
                Suku += 8
                'Next
                ImgResult5.SetPixel(j, i, Color.FromArgb(resultArray4(i, j, 0), resultArray4(i, j, 1), resultArray4(i, j, 2)))
            Next
        Next

        Dim nL As Integer = FBiner2Dec(Mid(TempSubKunci, 1, 8))
        Enkripsi(nL)
        'picEnkripsi.BackgroundImage = ImgResult5
        'picEnkripsi.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Sub Enkripsi(ByVal nL As Integer)
        Dim nWarna As Color
        Dim nXH As Integer
        Dim nYH As Integer

        Dim i As Integer
        Dim j As Integer

        'Simpan warna piksel ke array
        originalArray5 = Nothing
        ReDim originalArray5(ImgResult5.Height - 1, ImgResult5.Width - 1, 2)
        For j = 0 To ImgResult5.Height - 1
            For i = 0 To ImgResult5.Width - 1
                nWarna = ImgResult5.GetPixel(i, j)

                originalArray5(j, i, 0) = nWarna.R
                originalArray5(j, i, 1) = nWarna.G
                originalArray5(j, i, 2) = nWarna.B
            Next
        Next

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
                ImgResult.SetPixel(nXH, nYH, Color.FromArgb(originalArray5(j, i, 0), originalArray5(j, i, 1), originalArray5(j, i, 2)))
            Next
        Next
        picEnkripsi.BackgroundImage = ImgResult
        picEnkripsi.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

End Class