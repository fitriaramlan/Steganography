Public Class frmSisipL1

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
        End If
    End Sub

    Private Sub txtL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtL.KeyPress
        If (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9")) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 27 Then
            'input angka 
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnAcak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcak.Click
        Dim nL As Integer = CInt(0 & txtL.Text)
        Dim nWarna As Color
        Dim nXH As Integer
        Dim nYH As Integer

        If ImgOriginal Is Nothing Then
            MsgBox("Citra biner belum dimasukkan !", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf ImgOriginal.Height <> ImgOriginal.Width Then
            MsgBox("Citra biner harus berbentuk persegi !", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf nL = 0 Then
            MsgBox("Nilai L masih kosong !", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim i As Integer
        Dim j As Integer

        'Simpan warna piksel ke array
        originalArray = Nothing
        ReDim originalArray(ImgOriginal.Height - 1, ImgOriginal.Width - 1)
        For j = 0 To ImgOriginal.Height - 1
            For i = 0 To ImgOriginal.Width - 1
                nWarna = ImgOriginal.GetPixel(i, j)

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
        Dim ArrHasil(,) As String = Chaos(nL, ImgOriginal.Height)
        Dim cTemp() As String

        ImgResult = New Bitmap(ImgOriginal)
        ReDim resultArray(ImgOriginal.Height - 1, ImgOriginal.Width - 1)
        For j = 0 To ImgOriginal.Height - 1
            For i = 0 To ImgOriginal.Width - 1
                cTemp = Split(ArrHasil(j, i), ",")
                nXH = CInt(cTemp(0))
                nYH = CInt(cTemp(1))

                If originalArray(j, i) = 0 Then
                    resultArray(j, i) = 0
                Else
                    resultArray(j, i) = 255
                End If
                ImgResult.SetPixel(nXH, nYH, Color.FromArgb(resultArray(j, i), resultArray(j, i), resultArray(j, i)))
            Next
        Next
        picAcak.BackgroundImage = ImgResult
        picAcak.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub btnLanjut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLanjut.Click
        If resultArray Is Nothing Then
            MsgBox("Citra acak belum dihasilkan !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Me.Close()
        frmSisipL2.ShowDialog()
    End Sub

    Private Sub frmSisipL1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        originalArray = Nothing
    End Sub

    Private Sub txtL_TextChanged(sender As Object, e As EventArgs) Handles txtL.TextChanged
        '-------------------------------------
        ' Revisi Terakhir
        '-------------------------------------
        txtL.MaxLength = 5
        '-------------------------------------
    End Sub
End Class