Module Module3

    Public Function SHA3(ByVal pcMessage As String) As String
        Dim nLen As String = pcMessage.Length
        Dim cBitMessage As String = ""
        Dim i As Integer
        Dim cKar As String
        Dim Nilai As Integer
        Dim P(15) As String
        Dim nIndex As Integer
        Dim HasilP(15) As String

        '=================================
        ' Message Padding
        '=================================
        'Konversi ke ASCII Code bienr
        For i = 1 To pcMessage.Length
            cKar = Mid(pcMessage, i, 1)
            Nilai = Asc(cKar)
            cBitMessage &= FDec2Biner(Nilai, 8)
        Next

        'Tambahkan satu bit "1"
        cBitMessage &= "1"

        'Tambahkan m bit "0"
        Dim m As Integer = 448 - cBitMessage.Length
        cBitMessage &= StrDup(m, "0")

        'Tambahkan panjang bit pesan (sebanyak 64 bit)
        cBitMessage &= FDec2Biner(nLen, 64)
        '=================================

        'Pecahkan pesan menjadi 16 buah subblok P0 sampai P15
        For i = 1 To cBitMessage.Length Step 32
            P(i) = Mid(cBitMessage, i, 32)
        Next


        For nIndex = 0 To 15
            'XOR dengan P sebelumnya
            'P(i) XOR P(i - 1)
            If nIndex > 0 Then
                HasilP(nIndex) = FXOR(P(nIndex), HasilP(nIndex - 1))
            End If

            'Masukkan ke operasi chi, theta, rho, phi, iota


        Next



    End Function

    'Module SHA-3
    Public Sub Chi(ByVal pcBit As String)
        Dim A(,) As String
        Dim i As Integer
        Dim j As Integer
        Dim aKecil(7, 3) As String

        For j = 0 To (pcBit.Length \ 8 - 1)
            For i = 0 To (pcBit.Length \ 4 - 1)

            Next
        Next


    End Sub

    Public Sub KeccakPermutationOnWords(ByVal State() As Long)
        Dim i As Byte

        For i = 0 To 23
            Theta(State)
            Rho(State)
            Pi(State)
            Chi(State)
            Iota(State, i)
        Next
    End Sub

    Public Sub Theta(ByVal A() As Long)
        Dim C(4) As Long
        Dim D(4) As Long
        Dim x As Byte
        Dim y As Byte

        For x = 0 To 4
            C(x) = 0
            For y = 0 To 4
                C(x) ^= A(index(x, y))
                D(X)=
            Next
        Next

    End Sub

    Public Sub Rho(ByVal A() As Long)
        Dim x As Integer
        Dim y As Integer



    End Sub

    Public Sub Pi(ByVal A() As Long)
        Dim tempA As Long


    End Sub

    Public Sub Chi(ByVal A() As Long)

    End Sub

    Public Sub Iota(ByVal A() As Long, ByVal indexRound As Integer)

    End Sub

End Module
