Public Class frmNoise

    Structure TPos
        Dim X As Integer
        Dim Y As Integer
    End Structure

    Public CitraAsli As Bitmap

    Dim oriArray(,,) As Double

    Const nTebal = 3
    Private m_OriginalBitmap As Bitmap
    Private m_CurrentBitmap As Bitmap
    Private m_TempBitmap As Bitmap
    Private m_Gr As Graphics
    Private m_Pen As Pen

    Private m_SelectingArea As Boolean
    Private m_X1 As Integer
    Private m_Y1 As Integer
    Private cEvent As String = ""

    Dim Ada As Integer

    Dim nWarna As Color

    Public nMaskPos() As TPos
    Public OriImage As Bitmap
    Public gTinggi, gLebar As Integer
    Public originalArray(,,) As Byte
    Public dataArray(,,) As Byte
    Public imageArray(,,) As Byte
    Public nData1(,) As Double
    Dim cNama As String
    Dim nTotal As Double


    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Public Sub CekScrollBar()
        Me.PanelCanvas.AutoScroll = True

        With Me.picCanvas
            .SizeMode = PictureBoxSizeMode.Normal
            .Height = picCanvas.Height * Me.PanelCanvas.ClientSize.Width / picCanvas.Width
            .Width = Me.PanelCanvas.ClientSize.Width

            If Me.PanelCanvas.ClientSize.Height > picCanvas.Height Then
                .Width -= SystemInformation.VerticalScrollBarWidth
            End If
        End With

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If dlgOpenPicture.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim bm As New Bitmap(dlgOpenPicture.FileName)
                cNama = dlgOpenPicture.FileName
                m_OriginalBitmap = New Bitmap(bm)
                CitraAsli = New Bitmap(bm)
                m_CurrentBitmap = New Bitmap(bm)
                OriImage = New Bitmap(bm)
                bm.Dispose()
                picCanvas.Image = m_CurrentBitmap
                dlgSavePicture.InitialDirectory = dlgOpenPicture.FileName

                '' Make the form big enough.
                CekScrollBar()
                picCanvas.Size = New Size(m_OriginalBitmap.Width, m_OriginalBitmap.Height)
                Ada = 1
                gTinggi = m_CurrentBitmap.Height
                gLebar = m_CurrentBitmap.Width

                'ReDim originalArray(gTinggi, gLebar, 3)

                'For b = 0 To gTinggi - 1
                '    For a = 0 To gLebar - 1
                '        nWarna = m_CurrentBitmap.GetPixel(a, b)
                '        originalArray(b, a, 0) = nWarna.R
                '        originalArray(b, a, 1) = nWarna.G
                '        originalArray(b, a, 2) = nWarna.B
                '    Next
                'Next


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        dlgSavePicture.Filter = "Graphics Files|*.bmp;*.jpg;*.jpeg|All Files|*.*"
        If dlgSavePicture.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                m_CurrentBitmap = picCanvas.Image
                m_CurrentBitmap.Save(dlgSavePicture.FileName)
                dlgOpenPicture.InitialDirectory = dlgSavePicture.FileName
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    ' Start selecting an area.
    Private Sub picCanvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        Dim i As Integer
        Dim j As Integer

        ' Make sure we have a picture loaded.
        If m_OriginalBitmap Is Nothing Then Exit Sub

        m_SelectingArea = True
        m_X1 = e.X
        m_Y1 = e.Y
        ReDim nData1(gLebar, gTinggi)

        ''Simpan posisi yang dihapus
        nMaskPos(nMaskPos.GetUpperBound(0)).X = m_X1
        nMaskPos(nMaskPos.GetUpperBound(0)).Y = m_Y1
        nData1(m_X1, m_Y1) = 1

        For i = 0 To nTebal
            For j = 0 To nTebal
                If e.X + i < m_OriginalBitmap.Width And e.Y + j < m_OriginalBitmap.Height Then
                    If nData1(m_X1 + i, m_Y1 + j) < 1 Then nTotal += 1
                    nData1(m_X1 + i, m_Y1 + j) = 1
                    m_OriginalBitmap.SetPixel(e.X + i, e.Y + j, pic1.BackColor)
                    ReDim Preserve nMaskPos(nMaskPos.GetUpperBound(0) + 1)
                    nMaskPos(nMaskPos.GetUpperBound(0)).X = m_X1 + i
                    nMaskPos(nMaskPos.GetUpperBound(0)).Y = m_Y1 + j
                    Application.DoEvents()
                End If
            Next
        Next

        '' Set the current bitmap to the result.
        m_CurrentBitmap = New Bitmap(m_OriginalBitmap)

        '' Display the result.
        picCanvas.Image = m_CurrentBitmap

        cEvent = "Mouse Down"

        ReDim Preserve nMaskPos(nMaskPos.GetUpperBound(0) + 1)
    End Sub

    ' Continue selecting the area.
    Private Sub picCanvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        Dim i As Integer
        Dim j As Integer

        If cEvent = "Mouse Down" Then
            m_SelectingArea = True
            m_X1 = e.X
            m_Y1 = e.Y

            'nData1(m_X1, m_Y1) = 1

            For i = 0 To nTebal
                For j = 0 To nTebal
                    If e.X + i < m_OriginalBitmap.Width And e.Y + j < m_OriginalBitmap.Height And _
                       e.X >= 0 And e.Y >= 0 Then
                        If m_X1 < 0 Then m_X1 = 0
                        If m_Y1 < 0 Then m_Y1 = 0
                        If nData1(m_X1 + i, m_Y1 + j) < 1 Then nTotal += 1
                        'nData1(m_X1 + i, m_Y1 + j) = 1
                        m_OriginalBitmap.SetPixel(e.X + i, e.Y + j, pic1.BackColor)
                        ReDim Preserve nMaskPos(nMaskPos.GetUpperBound(0) + 1)
                        nMaskPos(nMaskPos.GetUpperBound(0)).X = m_X1 + i
                        nMaskPos(nMaskPos.GetUpperBound(0)).Y = m_Y1 + j
                        nData1(m_X1 + i, m_Y1 + j) = 1
                        Application.DoEvents()
                    End If
                Next
            Next

            ' Set the current bitmap to the result.
            m_CurrentBitmap = New Bitmap(m_OriginalBitmap)

            ' Display the result.
            picCanvas.Image = m_CurrentBitmap
        End If

    End Sub

    ' Finish selecting the area.
    Private Sub picCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        cEvent = "Mouse Up"
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If CitraAsli Is Nothing Then
            Exit Sub
        End If
        nTotal = 0
        m_CurrentBitmap = CitraAsli.Clone
        m_OriginalBitmap = CitraAsli.Clone
        picCanvas.Image = m_CurrentBitmap
    End Sub

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim i As Integer
        Dim nRnd As Integer
        Dim nRnd1 As Integer

        For i = 1 To CInt(0 & txtNoise.Text)
            Randomize()
            nRnd = Int(Rnd() * gTinggi)
            nRnd1 = Int(Rnd() * gLebar)
            m_CurrentBitmap.SetPixel(nRnd1, nRnd, Color.Black)
        Next
        picCanvas.Image = m_CurrentBitmap

    End Sub
End Class