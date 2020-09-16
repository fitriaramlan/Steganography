Module Module1

    Public Structure TKompleks
        Dim Nilai As Double
        Dim Imaginer As Double
    End Structure

    Public Const Phi = 3.1428571428571428

    Public Original As Bitmap
    Public Original1 As Bitmap

    Public ImgOriginal As Bitmap
    Public ImgOriginal1 As Bitmap

    Public ImgResult As Bitmap
    Public ImgResult1 As Bitmap
    Public ImgResult2 As Bitmap
    Public ImgResult3 As Bitmap
    Public ImgResult4 As Bitmap
    Public ImgResult5 As Bitmap

    Public ImgHasil As Bitmap

    Public originalArray(,) As Double
    Public originalArray0(,,) As Double
    Public originalArray1(,,) As Double
    Public originalArray2(,,) As Double
    Public originalArray3(,,) As Double
    Public originalArray4(,,) As Double

    Public originalArray5(,,) As Double
    Public originalArray6(,,) As Double

    Public resultArray4(,,) As Double

    Public resultArray(,) As Double

    Public Matriks(,) As Byte

    Public Structure T_Ruang
        Dim Nilai1 As Double
        Dim Nilai2 As Double
        Dim Nilai3 As Double
    End Structure

    Structure TFFT
        Dim k1 As Integer
        Dim k2 As Integer
        Dim Nilai As Double
        Dim Imag As Double
        Dim Amplitude As Double
        Dim Phase As Double
    End Structure

    Public bReport As Boolean = False
    Public cLap As String
    Public nArrF(,) As Byte
    Public strPosisi As String = ""

    Public Function YCbCr2RGB(ByVal Y As Double, ByVal Cb As Double, ByVal Cr As Double) As T_Ruang
        Dim R As Double
        Dim G As Double
        Dim B As Double
        Dim Hasil As T_Ruang
        Dim nY As Double = Y
        Dim nCb As Double = Cb
        Dim nCr As Double = Cr

        R = (nY - 16) + 1.402 * (nCr - 128)
        If bReport Then
            cLap &= "R = (y - 16) + 1.402 * (Cr - 128)" & vbCrLf & _
                   "R = (" & nY & " - 16) + 1.402 * (" & nCr & " - 128)" & vbCrLf & _
                   "R = " & R & vbCrLf
        End If

        G = (nY - 16) - 0.34414 * (nCb - 128) - 0.71414 * (nCr - 128)
        If bReport Then
            cLap &= "G = (Y - 16) - 0.34414 * (Cb - 128) - 0.71414 * (Cr - 128)" & vbCrLf & _
                    "G = (" & nY & " - 16) - 0.34414 * (" & nCb & " - 128) - 0.71414 * (" & nCr & " - 128)" & vbCrLf & _
                    "G = " & G & vbCrLf
        End If

        B = (nY - 16) + 1.772 * (nCb - 128)
        If bReport Then
            cLap &= "B = (y - 16) + 1.402 * (Cr - 128)" & vbCrLf & _
                    "B = (" & nY & " - 16) + 1.402 * (" & nCr & " - 128)" & vbCrLf & _
                    "B = " & B & vbCrLf
        End If

        R = Math.Round(R)
        G = Math.Round(G)
        B = Math.Round(B)

        Dim TempHasil As T_Ruang
        Dim bChangeR As Boolean = False
        Dim bChangeB As Boolean = False
        If R <= 255 And G <= 255 And B <= 255 And R >= 0 And G >= 0 And B >= 0 Then
        Else
            If R > 255 Or G > 255 Then
                Do
                    If R > 255 Then
                        R = 255
                        bChangeR = True
                    ElseIf bChangeR Then
                        R -= 1
                    End If

                    If G > 255 Then
                        G = 255
                        bChangeB = True
                    ElseIf bChangeB Then
                        G -= 1
                    End If
                    TempHasil = YCbCr(R, G, B)
                Loop Until (TempHasil.Nilai3 Mod 2) = (Cr Mod 2)
            Else
                Do
                    If R < 0 Then
                        R = 0
                        bChangeR = True
                    ElseIf bChangeR Then
                        R += 1
                    End If

                    If G < 0 Then
                        G = 0
                        bChangeB = True
                    ElseIf bChangeB Then
                        G += 1
                    End If
                    TempHasil = YCbCr(R, G, B)
                Loop Until (TempHasil.Nilai3 Mod 2) = (Cr Mod 2)
            End If
        End If

        Hasil.Nilai1 = Math.Round(R)
        Hasil.Nilai2 = Math.Round(G)
        Hasil.Nilai3 = Math.Round(B)

        Return Hasil
    End Function

    Public Function YCbCr(ByVal R As Byte, ByVal G As Byte, ByVal B As Byte) As T_Ruang
        Dim Y As Double
        Dim Cb As Double
        Dim Cr As Double
        Dim Hasil As T_Ruang

        Y = 0.299 * R + 0.587 * G + 0.114 * B + 16
        If bReport Then
            cLap &= "y = 0.299 * R + 0.587 * G + 0.114 * B + 16" & vbCrLf & _
                    "y = 0.299 * " & R & " + 0.587 * " & G & "+ 0.114 * " & B & " + 16 " & vbCrLf & _
                    "y = " & Y & vbCrLf
        End If

        Cb = -0.169 * R + -0.331 * G + 0.5 * B + 128
        If bReport Then
            cLap &= "Cb = -0.169 * R + -0.331 * G + 0.5 * B + 128" & vbCrLf & _
                    "Cb = -0.169 * " & R & " + -0.331 * " & G & " + 0.5 * " & B & " + 128" & vbCrLf & _
                    "Cb = " & Cb & vbCrLf
        End If

        Cr = 0.5 * R + -0.419 * G + -0.081 * B + 128
        If bReport Then
            cLap &= "Cr = 0.5 * " & R & " + -0.419 * " & G & " + -0.081 * " & B & " + 128" & vbCrLf & _
                    "Cr = 0.5 * R + -0.419 * G + -0.081 * B + 128" & vbCrLf & _
                    "Cr = " & Cr & vbCrLf & vbCrLf
        End If

        Hasil.Nilai1 = Math.Round(Y)
        Hasil.Nilai2 = Math.Round(Cb)
        Hasil.Nilai3 = Math.Round(Cr)

        Return Hasil
    End Function

    'Public Function YCbCr2RGB(ByVal Y As Double, ByVal Cb As Double, ByVal Cr As Double) As T_Ruang
    '    Dim R As Double
    '    Dim G As Double
    '    Dim B As Double
    '    Dim Hasil As T_Ruang
    '    Dim nY As Double = Y
    '    Dim nCb As Double = Cb
    '    Dim nCr As Double = Cr

    '    R = nY + 1.402 * nCr
    '    If bReport Then
    '        cLap &= "R = (y - 16) + 1.402 * (Cr - 128)" & vbCrLf & _
    '               "R = (" & nY & " - 16) + 1.402 * (" & nCr & " - 128)" & vbCrLf & _
    '               "R = " & R & vbCrLf
    '    End If

    '    G = nY - 0.34414 * nCb - 0.71414 * nCr
    '    If bReport Then
    '        cLap &= "G = (Y - 16) - 0.34414 * (Cb - 128) - 0.71414 * (Cr - 128)" & vbCrLf & _
    '                "G = (" & nY & " - 16) - 0.34414 * (" & nCb & " - 128) - 0.71414 * (" & nCr & " - 128)" & vbCrLf & _
    '                "G = " & G & vbCrLf
    '    End If

    '    B = nY + 1.772 * nCb
    '    If bReport Then
    '        cLap &= "B = (y - 16) + 1.402 * (Cr - 128)" & vbCrLf & _
    '                "B = (" & nY & " - 16) + 1.402 * (" & nCr & " - 128)" & vbCrLf & _
    '                "B = " & B & vbCrLf
    '    End If

    '    Hasil.Nilai1 = Math.Round(R)
    '    Hasil.Nilai2 = Math.Round(G)
    '    Hasil.Nilai3 = Math.Round(B)

    '    Return Hasil
    'End Function

    'Public Function YCbCr(ByVal R As Byte, ByVal G As Byte, ByVal B As Byte) As T_Ruang
    '    Dim Y As Double
    '    Dim Cb As Double
    '    Dim Cr As Double
    '    Dim Hasil As T_Ruang

    '    Y = 0.299 * R + 0.587 * G + 0.114 * B
    '    If bReport Then
    '        cLap &= "y = 0.299 * R + 0.587 * G + 0.114 * B + 16" & vbCrLf & _
    '                "y = 0.299 * " & R & " + 0.587 * " & G & "+ 0.114 * " & B & " + 16 " & vbCrLf & _
    '                "y = " & Y & vbCrLf
    '    End If

    '    Cb = -0.169 * R + -0.331 * G + 0.5 * B
    '    If bReport Then
    '        cLap &= "Cb = -0.169 * R + -0.331 * G + 0.5 * B + 128" & vbCrLf & _
    '                "Cb = -0.169 * " & R & " + -0.331 * " & G & " + 0.5 * " & B & " + 128" & vbCrLf & _
    '                "Cb = " & Cb & vbCrLf
    '    End If

    '    Cr = 0.5 * R + -0.419 * G + -0.081 * B
    '    If bReport Then
    '        cLap &= "Cr = 0.5 * " & R & " + -0.419 * " & G & " + -0.081 * " & B & " + 128" & vbCrLf & _
    '                "Cr = 0.5 * R + -0.419 * G + -0.081 * B + 128" & vbCrLf & _
    '                "Cr = " & Cr & vbCrLf & vbCrLf
    '    End If

    '    Hasil.Nilai1 = Math.Round(Y)
    '    Hasil.Nilai2 = Math.Round(Cb)
    '    Hasil.Nilai3 = Math.Round(Cr)

    '    Return Hasil
    'End Function

    Public Function FModulus(ByVal pnValue1 As Double, ByVal pnValue2 As Double) As Double
        Dim nKali As Double
        Dim nHasil As Double

        If pnValue1 < 0 Then
            nKali = Math.Abs(pnValue1 \ pnValue2)
            nHasil = pnValue1 + (nKali * pnValue2)
            nHasil = (nHasil + pnValue2) Mod pnValue2
        Else
            nHasil = pnValue1 Mod pnValue2
        End If

        Return nHasil
    End Function

    'Shin Chaos Function
    Public Function Chaos(ByVal pnL As Integer, ByVal pnN As Integer) As Array
        Dim nXi As Integer
        Dim nYi As Integer
        Dim nX As Integer
        Dim nY As Integer
        Dim ArrHasil(pnN, pnN) As String

        For nX = 0 To pnN - 1
            For nY = 0 To pnN - 1
                nXi = (nX + nY) Mod pnN
                nYi = (pnL * nX + (pnL + 1) * nY) Mod pnN
                ArrHasil(nX, nY) = nXi & "," & nYi
            Next
        Next

        Return ArrHasil
    End Function

    Public Sub Coba()
        Dim ArrFB(7, 34) As Byte

        ArrFB(0, 0) = 0
        ArrFB(0, 1) = 0

        IrFFT(ArrFB, 5)

    End Sub

    Public Function IrFFT(ByVal pnArrFB(,) As Byte, ByVal pnN As Byte) As Array
        Dim x As Integer
        Dim y As Integer
        Dim u As Integer
        Dim v As Integer
        Dim Hasil(7, 34) As TKompleks
        Dim Hasil1(7, 34) As Byte
        Dim Tetha As Double

        For u = 0 To 7
            For v = 0 To 34
                'cLap &= "f(" & u & ", " & v & ").Nilai = "
                For x = 0 To pnN - 1
                    For y = 0 To pnN - 1
                        Tetha = 2 * Phi * (x * u + y * u) / pnN
                        Hasil(u, v).Nilai += Math.Round(pnArrFB(x, y) * Math.Cos(Tetha) / pnN, 12)
                        Hasil(u, v).Imaginer -= Math.Round(pnArrFB(x, y) * Math.Sin(Tetha) / pnN, 12)
                        'cLap &= IIf(x = 0 And y = 0, "", " + ") & _
                        '        pnArrFB(x, y) & " * cos(2 * Phi * (" & x & " * " & u & " + " & y & " * " & u & ")" 
                    Next
                Next

                'cLap &= vbCrLf
                For x = 0 To pnN - 1
                    For y = 0 To pnN - 1
                        Tetha = 2 * Phi * (x * u + y * u) / pnN
                        'cLap &= IIf(x = 0 And y = 0, "", " + ") & _
                        '        pnArrFB(x, y) & " * cos(" & Tetha & ")"
                    Next
                Next

                'cLap &= vbCrLf
                For x = 0 To pnN - 1
                    For y = 0 To pnN - 1
                        Tetha = 2 * Phi * (x * u + y * u) / pnN
                        'cLap &= IIf(x = 0 And y = 0, "", " + ") & _
                        '        pnArrFB(x, y) & " * " & Math.Cos(Tetha)
                    Next
                Next

                'cLap &= vbCrLf & _
                '        "f(" & u & ", " & v & ").Nilai = " & Hasil(u, v).Nilai & vbCrLf & vbCrLf

                If Hasil(u, v).Imaginer > 0 Then
                    Hasil1(u, v) = 1 'Hasil(u, v).Nilai   '
                Else
                    Hasil1(u, v) = 0
                End If
            Next
        Next

        Return Hasil1
    End Function

    'Biner ke desimal
    Public Function FBiner2Dec(ByVal pcText As String) As Double
        Dim nLoop As Double
        Dim nHasil As Double

        nHasil = 0
        'Konversi dari belakang
        For nLoop = Len(pcText) To 1 Step -1
            If Mid(pcText, nLoop, 1) = "1" Then
                nHasil = nHasil + (2 ^ (Len(pcText) - nLoop))
            End If
        Next nLoop

        'Angka Desimal
        FBiner2Dec = nHasil
    End Function

    'Desimal ke Biner
    Public Function FDec2Biner(ByVal pnAngka As Double, ByVal pnLength As Double) As String

        Dim nLoop As Double
        Dim nHasilBagi As Double
        Dim nSisaBagi As Double
        Dim cBiner1 As String
        Dim cBiner2 As String

        nHasilBagi = pnAngka
        cBiner1 = ""
        While nHasilBagi <> 0
            nSisaBagi = FMod(nHasilBagi, 2)
            cBiner1 = cBiner1 & Format(nSisaBagi)   'format = CStr
            nHasilBagi = FDiv(nHasilBagi, 2)        'div = \
        End While
        If cBiner1 = "" Then cBiner1 = "0"

        'Ambil Terbalik
        cBiner2 = ""
        For nLoop = Len(cBiner1) To 1 Step -1
            cBiner2 = cBiner2 & Mid(cBiner1, nLoop, 1)
        Next nLoop

        If Len(cBiner2) <= pnLength Then
            'Angka Biner Kurang dari pnLength
            FDec2Biner = FString(pnLength - Len(cBiner2), "0") & cBiner2
        Else
            'Angka Biner Melebihi pnLength
            FDec2Biner = Left(cBiner2, pnLength)
        End If

    End Function

    Public Function FString(ByVal pnValue As Double, ByVal pcChar As String) As String
        Dim nI As Double
        Dim cTemp As String

        cTemp = ""
        For nI = 1 To pnValue
            cTemp = cTemp & pcChar
        Next

        FString = cTemp
    End Function

    'Operasi modulo untuk bilangan besar
    Public Function FMod(ByVal pnA1 As Double, ByVal pnA2 As Double) As Double
        Dim nMod As Double

        nMod = pnA1 / pnA2
        FMod = pnA1 - (pnA2 * Int(nMod))

    End Function

    'Operasi div untuk bilangan besar
    Public Function FDiv(ByVal pnA1 As Double, ByVal pnA2 As Double) As Double
        Dim nDiv As Double

        nDiv = pnA1 / pnA2
        FDiv = Int(nDiv)

    End Function

    Public Function Kiri(ByVal pcTeks As String, ByVal pnLen As Integer) As String
        Return Left(pcTeks, pnLen)
    End Function

    Public Function KeyGeneration(ByVal pcPassword As String) As String
        'Proses SHA3
        Dim Hasil As String = SHA_3(pcPassword)
        Dim i As Integer
        Dim j As Integer
        Dim Hasil1 As String = ""
        Dim Pnjg As Integer = 0
        Dim f(,) As Byte
        Dim x As Integer
        Dim y As Integer
        Dim N As Byte = 5

        ReDim Matriks(7, 34)

        'Operasi Matriks Permutasi Terhadap Message digest yang Diperoleh
        For i = 0 To 7
            For j = 0 To 34
                Pnjg += 1
                If Pnjg > Hasil.Length Then
                    Pnjg -= Hasil.Length
                End If
                Matriks(i, j) = FHex2Dec(Mid(Hasil, Pnjg, 1))
            Next
        Next

        'Proses IrFFT
        f = IrFFT(Matriks, N)
        For x = 0 To 7
            For y = 0 To 34
                If f(x, y) > 0 Then
                    f(x, y) = 1
                Else
                    f(x, y) = 0
                End If
                'Hasil1 &= f(x, y)
                Hasil1 &= Matriks(x, y)
            Next
        Next

        Dim BitHasil As String = ""
        For i = 1 To Hasil1.Length
            BitHasil &= FDec2Biner(Asc(Mid(Hasil1, i, 1)), 4)
        Next

        Return BitHasil

        'Return Hasil1
    End Function

    Public Function FXOR(ByVal pcBiner1 As String, ByVal pcBiner2 As String) As String
        Dim i As Byte
        Dim Hasil As String = ""

        For i = 1 To pcBiner1.Length
            Hasil &= CInt(Mid(pcBiner1, i, 1)) Xor CInt(Mid(pcBiner2, i, 1))
        Next

        Return Hasil
    End Function

    'Public Function IrFFT(ByVal NB1 As Integer, ByVal NB2 As Integer) As Double
    '    Dim ArrF(NB1 - 1, NB2 - 1) As TFFT
    '    Dim ArrG(NB1 - 1, NB2 - 1) As TFFT
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim k As Integer
    '    Dim l As Integer
    '    Dim M1 As Integer
    '    Dim M2 As Integer
    '    Dim k1 As Integer
    '    Dim k2 As Integer
    '    Dim n1 As Integer
    '    Dim n2 As Integer
    '    Dim Puncak As Double

    '    Dim RFG(NB1 - 1, NB2 - 1) As TFFT
    '    Dim RFGAbs(NB1 - 1, NB2 - 1) As TFFT

    '    Dim Tetha As Double

    '    M1 = (NB1 - 1) / 2
    '    M2 = (NB2 - 1) / 2

    '    'Hitung nilai F dan G
    '    k1 = -M1 - 1
    '    For i = 0 To NB1 - 1
    '        k1 += 1
    '        k2 = -M2 - 1
    '        For j = 0 To NB2 - 1
    '            k2 += 1

    '            ArrF(i, j).k1 = k1
    '            ArrF(i, j).k2 = k2

    '            ArrG(i, j).k1 = k1
    '            ArrG(i, j).k2 = k2

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Proses perulangan untuk setiap n1, n2
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            n1 = -M1 - 1
    '            For k = 0 To NB1 - 1
    '                n1 += 1 : n2 = -M2 - 1
    '                For l = 0 To NB2 - 1
    '                    n2 += 1

    '                    '-----------------------
    '                    'Transformasi fourier
    '                    '-----------------------
    '                    Tetha = 2 * Phi * (k1 * n1 / NB1 + k2 * n2 / NB2) / (NB1 * NB2)

    '                    ArrF(i, j).Nilai += Math.Round(oriArray(k, l) * Math.Cos(Tetha) / (NB1 * NB2), 12)
    '                    ArrF(i, j).Imag -= Math.Round(oriArray(k, l) * Math.Sin(Tetha) / (NB1 * NB2), 12)

    '                    ArrG(i, j).Nilai += Math.Round(oriArray1(k, l) * Math.Cos(Tetha) / (NB1 * NB2), 12)
    '                    ArrG(i, j).Imag -= Math.Round(oriArray1(k, l) * Math.Sin(Tetha) / (NB1 * NB2), 12)
    '                Next
    '            Next
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            ArrF(i, j).Amplitude = Math.Sqrt(ArrF(i, j).Nilai ^ 2 + ArrF(i, j).Imag ^ 2)
    '            ArrF(i, j).Phase = Math.Atan(ArrF(i, j).Imag / ArrF(i, j).Nilai)

    '            ArrG(i, j).Amplitude = Math.Sqrt(ArrG(i, j).Nilai ^ 2 + ArrG(i, j).Imag ^ 2)
    '            ArrG(i, j).Phase = Math.Atan(ArrG(i, j).Imag / ArrG(i, j).Nilai)
    '        Next
    '    Next

    '    'Hitung cross phase spectrum (normalized cross spectrum)
    '    k1 = -M1 - 1
    '    For i = 0 To NB1 - 1
    '        k1 += 1 : k2 = -M2 - 1
    '        For j = 0 To NB2 - 1
    '            k2 += 1
    '            RFG(i, j).k1 = k1
    '            RFG(i, j).k2 = k2

    '            RFG(i, j).Amplitude = 1
    '            RFG(i, j).Phase = Math.Round(ArrF(i, j).Phase - ArrG(i, j).Phase, 12)
    '        Next
    '    Next

    '    Dim nTNilai As Double
    '    Dim nTImag As Double

    '    'Hitung fungsi POC
    '    k1 = -M1 - 1
    '    For i = 0 To NB1 - 1
    '        k1 += 1
    '        k2 = -M2 - 1
    '        For j = 0 To NB2 - 1
    '            k2 += 1

    '            rTFG(i, j).k1 = k1
    '            rTFG(i, j).k2 = k2

    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            'Proses perulangan untuk setiap n1, n2
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '            n1 = -M1 - 1
    '            nTNilai = 0 : nTImag = 0
    '            For k = 0 To NB1 - 1
    '                n1 += 1 : n2 = -M2 - 1
    '                For l = 0 To NB2 - 1
    '                    n2 += 1

    '                    '-----------------------
    '                    'Transformasi fourier
    '                    '-----------------------
    '                    Tetha = RFG(i, j).Phase + 2 * Phi * (k1 * n1 / NB1 + k2 * n2 / NB2) / (NB1 * NB2)

    '                    nTNilai += Math.Round(Math.Cos(Tetha), 12)
    '                    nTImag += Math.Round(Math.Sin(Tetha), 12)
    '                Next
    '            Next
    '            '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '        Next
    '    Next

    '    Return 1 - Puncak
    'End Function
End Module
