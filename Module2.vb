Module Module2

    Public Structure word
        Dim b0 As Byte
        Dim b1 As Byte
        Dim b2 As Byte
        Dim b3 As Byte
    End Structure

    Public Function AndW(ByVal w1 As word, ByVal w2 As word) As word
        AndW.b0 = w1.b0 And w2.b0
        AndW.b1 = w1.b1 And w2.b1
        AndW.b2 = w1.b2 And w2.b2
        AndW.b3 = w1.b3 And w2.b3
    End Function

    Public Function OrW(ByVal w1 As word, ByVal w2 As word) As word
        OrW.b0 = w1.b0 Or w2.b0
        OrW.b1 = w1.b1 Or w2.b1
        OrW.b2 = w1.b2 Or w2.b2
        OrW.b3 = w1.b3 Or w2.b3
    End Function

    Public Function XorW(ByVal w1 As word, ByVal w2 As word) As word
        XorW.b0 = w1.b0 Xor w2.b0
        XorW.b1 = w1.b1 Xor w2.b1
        XorW.b2 = w1.b2 Xor w2.b2
        XorW.b3 = w1.b3 Xor w2.b3
    End Function

    Public Function NotW(ByVal w As word) As word
        NotW.b0 = Not w.b0
        NotW.b1 = Not w.b1
        NotW.b2 = Not w.b2
        NotW.b3 = Not w.b3
    End Function

    Public Function AddW(ByVal w1 As word, ByVal w2 As word) As word
        Dim I As Integer, w As word

        I = CInt(w1.b3) + w2.b3
        w.b3 = I Mod 256
        I = CInt(w1.b2) + w2.b2 + (I \ 256)
        w.b2 = I Mod 256
        I = CInt(w1.b1) + w2.b1 + (I \ 256)
        w.b1 = I Mod 256
        I = CInt(w1.b0) + w2.b0 + (I \ 256)
        w.b0 = I Mod 256

        AddW = w
    End Function

    Public Function CircShiftLeftW(ByVal w As word, ByVal n As Integer) As word
        Dim d1 As Double, d2 As Double

        d1 = WordToDouble(w)
        d2 = d1
        d1 = d1 * (2 ^ n)
        d2 = d2 / (2 ^ (32 - n))
        CircShiftLeftW = OrW(DoubleToWord(d1), DoubleToWord(d2))
    End Function

    Public Function HexToWord(ByVal H As String) As word
        HexToWord = DoubleToWord(Val("&H" & H & "#"))
    End Function

    Public Function DoubleToWord(ByVal n As Double) As word
        DoubleToWord.b0 = Int(DMod(n, 2 ^ 32) / (2 ^ 24))
        DoubleToWord.b1 = Int(DMod(n, 2 ^ 24) / (2 ^ 16))
        DoubleToWord.b2 = Int(DMod(n, 2 ^ 16) / (2 ^ 8))
        DoubleToWord.b3 = Int(DMod(n, 2 ^ 8))
    End Function

    Public Function WordToDouble(ByVal w As word) As Double
        WordToDouble = (w.b0 * (2 ^ 24)) + (w.b1 * (2 ^ 16)) + (w.b2 * (2 ^ 8)) + w.b3
    End Function

    Public Function DMod(ByVal value As Double, ByVal divisor As Double) As Double
        DMod = value - (Int(value / divisor) * divisor)
        If DMod < 0 Then DMod = DMod + divisor
    End Function

    Public Function F(ByVal t As Integer, ByVal B As word, ByVal C As word, ByVal D As word) As word
        Select Case t
            Case Is <= 19
                F = OrW(AndW(B, C), AndW(NotW(B), D))
            Case Is <= 39
                F = XorW(XorW(B, C), D)
            Case Is <= 59
                F = OrW(OrW(AndW(B, C), AndW(B, D)), AndW(C, D))
            Case Else
                F = XorW(XorW(B, C), D)
        End Select
    End Function

    Public Function WordToHex(ByVal w As word) As String
        WordToHex = Hex(w.b0).PadLeft(2, "0") & Hex(w.b1).PadLeft(2, "0") & Hex(w.b2).PadLeft(2, "0") & Hex(w.b3).PadLeft(2, "0")
    End Function

    Public Function SHA_3(ByVal Msg As String) As String
        Dim w(79) As word
        Dim WordText, hasil As String
        Dim k(3) As word
        Dim h0, h1, h2, h3, h4, inLenW As word
        Dim a, b, c, d, e, temp As word
        Dim PadMsg, BlockText As String
        Dim inLen, NumBlocks, t, i As Integer
        inLen = Msg.Length
        inLenW = DoubleToWord(CDbl(inLen) * 8)
        k(0) = HexToWord("5A827999")
        k(1) = HexToWord("6ED9EBA1")
        k(2) = HexToWord("8F1BBCDC")
        k(3) = HexToWord("CA62C1D6")

        h0 = HexToWord("67452301")
        h1 = HexToWord("EFCDAB89")
        h2 = HexToWord("98BADCFE")
        h3 = HexToWord("10325476")
        h4 = HexToWord("C3D2E1F0")

        a = h0
        b = h1
        c = h2
        d = h3
        e = h4

        PadMsg = Msg
        PadMsg &= Chr(128)
        PadMsg &= StrDup((128 - (inLen Mod 64) - 9) Mod 64, Chr(0))
        PadMsg &= StrDup(4, Chr(0))
        PadMsg &= Chr(inLenW.b0)
        PadMsg &= Chr(inLenW.b1)
        PadMsg &= Chr(inLenW.b2)
        PadMsg &= Chr(inLenW.b3)

        NumBlocks = Len(PadMsg) / 64
        For i = 0 To NumBlocks - 1
            BlockText = Mid$(PadMsg, (i * 64) + 1, 64)

            For t = 0 To 15
                WordText = Mid$(BlockText, (t * 4) + 1, 4)
                w(t).b0 = Asc(Mid$(WordText, 1, 1))
                w(t).b1 = Asc(Mid$(WordText, 2, 1))
                w(t).b2 = Asc(Mid$(WordText, 3, 1))
                w(t).b3 = Asc(Mid$(WordText, 4, 1))
            Next t

            For t = 16 To 79
                w(t) = CircShiftLeftW(XorW(XorW(XorW(w(t - 3), w(t - 8)), w(t - 14)), w(t - 16)), 1)
            Next t

            a = h0
            b = h1
            c = h2
            d = h3
            e = h4

            For t = 0 To 79
                temp = AddW(AddW(AddW(AddW(CircShiftLeftW(a, 5), F(t, b, c, d)), e), w(t)), k(t \ 20))
                e = d
                d = c
                c = CircShiftLeftW(b, 30)
                b = a
                a = temp
            Next t

            h0 = AddW(h0, a)
            h1 = AddW(h1, b)
            h2 = AddW(h2, c)
            h3 = AddW(h3, d)
            h4 = AddW(h4, e)
        Next i
        hasil = WordToHex(h0) & WordToHex(h1) & WordToHex(h2) & WordToHex(h3) & WordToHex(h4)
        Return hasil
    End Function

    'Heksa ke desimal
    Public Function FHex2Dec(ByVal pcText As String) As Double
        Dim i As Integer

        For i = 1 To Len(pcText)
            Select Case Mid(pcText, i, 1)
                Case "1" To "9" : FHex2Dec = FHex2Dec + CDec(Mid(pcText, i, 1)) * 16 ^ (Len(pcText) - i)
                Case "A", "a" : FHex2Dec = FHex2Dec + 10 * 16 ^ (Len(pcText) - i)
                Case "B", "b" : FHex2Dec = FHex2Dec + 11 * 16 ^ (Len(pcText) - i)
                Case "C", "c" : FHex2Dec = FHex2Dec + 12 * 16 ^ (Len(pcText) - i)
                Case "D", "d" : FHex2Dec = FHex2Dec + 13 * 16 ^ (Len(pcText) - i)
                Case "E", "e" : FHex2Dec = FHex2Dec + 14 * 16 ^ (Len(pcText) - i)
                Case "F", "f" : FHex2Dec = FHex2Dec + 15 * 16 ^ (Len(pcText) - i)
            End Select
        Next i
    End Function


End Module
