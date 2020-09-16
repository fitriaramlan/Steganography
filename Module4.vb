Module Module4

    'Public pesan As String
    Dim temp As String
    Dim stringBiner() As String

    Dim p(15, 7, 3) As Integer
    Dim bitrate(7, 3) As String

    Dim arrayBiner(7, 5) As Integer
    Dim arrayCHI(5, 3) As Integer
    Dim arrayTheta1(3, 5) As Integer
    Dim arrayTheta2(5, 3) As Integer
    Dim arrayPI(5, 3) As Integer
    Dim arrayRho(5, 3) As Integer
    Dim arrayIota(5, 3) As Integer
    Dim arrayHexa(3) As String
    Dim iota As String
    Dim hasilXOR(7, 3) As Integer
    Dim stringHASH As String

    'Fungsi untuk merubah karakter ke BINER
    Public Function CharToBinary(ByVal CharStr As String) As String
        Dim lValue As Integer
        Dim BinaryArr() As String
        Dim BinaryStr As String = ""
        Dim i As Integer

        lValue = Asc(CharStr)
        i = 0

        ReDim BinaryArr(i)
        While lValue <> 0
            ReDim Preserve BinaryArr(i)
            BinaryArr(i) = lValue Mod 2
            lValue = lValue \ 2
            i = i + 1
        End While

        If UBound(BinaryArr) >= 0 Then
            For i = 0 To UBound(BinaryArr)
                BinaryStr = BinaryArr(i) & BinaryStr
            Next
            BinaryStr = String.Format("0", 8 - Len(BinaryStr)) & BinaryStr
        End If
        CharToBinary = BinaryStr
    End Function

    Public Function bitpadding(ByVal pesan As String)
        Dim x As Integer
        Dim y As Integer

        temp = ""

        Dim pos As Integer = 0
        y = 0
        Dim tambahkan_8 As Boolean = False
        Dim index_pesan As Integer = 0
        For z As Integer = 0 To 60 'angka 60 (4 * 15) setiap P memiliki 4 karakter
            If z <= pesan.Length - 1 Then
                For x = 0 To 7
                    p(pos, x, y) = stringBiner(index_pesan).Substring(x, 1).ToString
                    temp = temp & p(pos, x, y)
                Next
                temp = temp & " "

                If y = 3 Then
                    y = 0
                    temp = ""
                    pos += 1
                Else
                    y += 1
                End If

                index_pesan += 1
            Else
                'cek apakah 8000 sudah ditambahkan
                If tambahkan_8 = False Then
                    For x = 0 To 7
                        If x = 0 Then
                            p(pos, x, y) = "1"
                        Else
                            p(pos, x, y) = "0"
                        End If
                        temp = temp & p(pos, x, y)
                    Next
                    temp = temp & " "

                    tambahkan_8 = True
                Else
                    For x = 0 To 7
                        p(pos, x, y) = "0"
                        temp = temp & p(pos, x, y)
                    Next
                    temp = temp & " "
                End If

                If y = 3 Then
                    y = 0
                    temp = ""
                    pos += 1
                Else
                    y += 1
                End If
            End If
        Next


        'untuk P15
        For y = 0 To 1
            For x = 0 To 7
                p(15, x, y) = "0"
                temp = temp & p(15, x, y)
            Next
            temp = temp & " "
        Next


        Dim b As Integer = pesan.Length * 8
        Dim hasil_convert_decima_to_string = Convert.ToString(b, 2)
        Dim panjang_bin As Integer = hasil_convert_decima_to_string.Length
        Dim sisa_panjang As Integer = 8 - hasil_convert_decima_to_string.Length

        Dim bin As String = ""
        For x = 1 To sisa_panjang
            bin = bin & "0"
        Next
        bin = bin & hasil_convert_decima_to_string

        For x = 0 To 7
            p(15, x, 3) = bin.Substring(x, 1).ToString
            temp = temp & p(15, x, 3)
        Next
        temp = ""

        'inisialisasi bitrate awal dengan 0
        For y = 0 To 3
            For x = 0 To 7
                bitrate(x, y) = "0" 'sehingga terbentuk biterate awal 00000000 00000000 00000000 00000000
            Next
        Next

        Return True
    End Function

    Public Function SHA3(ByVal pesan As String) As String
        Dim x As Integer
        Dim y As Integer
        Dim i As Integer
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        stringHASH = ""
        'untuk mengambil pesan yang diinput dan disimpan pada variabel pesan
        'pesan = Trim(txtPesan.Text) ' Trim berfungsi untuk menghapus jika ada spasi misal : __pesan__

        'melakukan perulangan sebanyak jumlah pesan untuk mengubah tiap karakter ke biner
        For i = 0 To pesan.Length - 1
            ReDim Preserve stringBiner(i)
            'memanggil fungsi CharToBinary untuk merubah karakter ke biner dan disimpan kedalam variable array
            stringBiner(i) = CharToBinary(pesan.Substring(i, 1).ToString)
        Next


        temp = ""
        For y = 0 To UBound(stringBiner)
            For x = 0 To stringBiner(y).Length - 1
                arrayBiner(x, y) = stringBiner(y).Substring(x, 1).ToString
            Next
            temp = temp & stringBiner(y) & " "
        Next

        bitpadding(pesan)

        For prosesAktif As Integer = 0 To 15
            'HASIL XOR
            temp = ""
            For y = 0 To 3
                For x = 0 To 7
                    'melakukan fungsi XOR tiap-tiap bit
                    hasilXOR(x, y) = p(prosesAktif, x, y) Xor bitrate(x, y)
                    temp = temp & hasilXOR(x, y)
                Next
            Next


            ''''''''''''''''''''''''''''''

            'Operasi CHI

            ''''''''''''''''''''''''''''''
            temp = ""
            Dim indexChi As Integer = 0
            For y = 0 To 3
                For x = 0 To 5

                    a = hasilXOR(x, y) ' untuk mendapatkan a[x,y]
                    b = hasilXOR((x + 1), y) 'untuk mendapatkan a[x+1, y]
                    c = hasilXOR((x + 2), y) 'untuk mendapatkan a[x+2, y]

                    'untuk fungsi NOT pada nilai b = NOT a[x+1,y]
                    Dim bTemp As Integer
                    If b = 0 Then
                        bTemp = 1
                    Else
                        bTemp = 0
                    End If

                    arrayCHI(x, y) = a Xor (bTemp And c)

                    temp = temp & arrayCHI(x, y)
                Next
                temp = temp & " "
            Next
            'menampilkan hasil CHI kedalam txtCHI
            'txtCHI.Text = temp



            '''''''''''''''''''''''''''''''''

            'Operasi Theta

            '''''''''''''''''''''''''''''''''

            'Algoritma 1
            temp = ""
            For x = 0 To 5
                For y = 0 To 3
                    a = arrayCHI(x, 0) 'untuk mendapatkan c[x] = a[x,0]
                    b = arrayCHI(x, y) 'untuk mendapatkan c[x] = a[x,y]

                    ' Disini terjadi perubahan, dimana nilai y menjadi x dan x menjadi y.
                    ' Sehingga array tetap menjadi 3, 5
                    arrayTheta1(y, x) = a Xor b

                    temp = temp & arrayTheta1(y, x)
                Next
                temp = temp & " "
            Next
            'txtTheta1.Text = temp


            'Algoritma 2
            temp = ""
            Dim d As Integer
            For x = 0 To 3
                c = arrayCHI(x, 0) 'untuk mendapatkan C[x] yang nilainya sama dengan a[x,0] 

                a = arrayTheta1(1, (x + 1)) 'Karena ROT jadi berubah posisi x,y -> y,x
                d = c Xor a 'nilai D[x]

                For y = 0 To 5
                    arrayTheta2(y, x) = arrayTheta1(x, y) Xor d

                    temp = temp & arrayTheta2(y, x)
                Next
                temp = temp & " "
            Next
            'txtTheta2.Text = temp



            ''''''''''''''''''''''''''
            '
            'Operasi PI
            '
            ''''''''''''''''''''''''''

            temp = ""
            Dim posX, posY As Integer
            For y = 0 To 3
                For x = 0 To 5
                    'perkalian matrix
                    posX = (0 * x) + (1 * y)
                    posY = (2 * x) + (3 * y)

                    If posX > 5 Then
                        posX = posX Mod 6
                    End If
                    If posY > 3 Then
                        posY = posY Mod 4
                    End If
                    arrayPI(x, y) = arrayTheta2(posX, posY)
                    temp = temp & arrayPI(x, y)
                Next
                temp = temp & " "
            Next
            'txtPi.Text = temp

            ''''''''''''''''''''''''''
            '
            'Operasi Rho
            '
            ''''''''''''''''''''''''''
            Dim xPI, xBARU, yPI, yBARU As Integer
            x = 0
            y = 1

            xBARU = 0
            yBARU = 0
            For t As Integer = 0 To 23
                xPI = ((t + 1) * (t + 2)) / 2
                yPI = arrayPI(x, y)

                If xPI >= 6 Then
                    xPI = xPI Mod 6
                End If

                arrayRho(xBARU, yBARU) = arrayPI(xPI, yPI)
                xBARU += 1
                yBARU += 1

                If xBARU = 5 Then
                    xBARU = 0
                End If
                If yBARU = 3 Then
                    yBARU = 0
                End If

                'perkalian matrix untuk mendapatkan titik kordinat baru
                x = (0 * x) + (1 * y)
                y = (2 * x) + (3 * y)

                If x >= 6 Then
                    x = x Mod 6
                End If

                If y >= 4 Then
                    y = y Mod 4
                End If

            Next

            'menampilkan ke txtRHO
            temp = ""
            For y = 0 To 3
                For x = 0 To 5
                    temp = temp & arrayRho(x, y)
                Next
                temp = temp & " "
            Next
            'txtRho.Text = temp



            ''''''''''''''''''''''''''
            '
            'Operasi Iota
            '
            ''''''''''''''''''''''''''
            temp = ""
            Dim tempTerseleksi As String = ""
            Dim temp1 As String = ""
            Dim temp2 As String = ""

            For y = 0 To 3
                temp = ""
                For x = 0 To 5
                    temp = temp & arrayRho(x, y)
                Next

                If Not temp = "000000" Then
                    'jika bukan 0 maka bagi 2

                    temp1 = temp.Substring(0, 3)
                    temp2 = temp.Substring(3, 3)

                    ' bandingkan apakah temp1 dan 2 sama, jika sama berarti simetris
                    If temp1 = temp2 Then
                        ' tambahkan 1 pada bit pertama

                        Dim bit1 As Integer = temp1.Substring(0, 1)
                        Dim bit2 As Integer = temp2.Substring(0, 1)

                        If bit1 = 1 Then
                            temp1 = "0" & temp1.Substring(1, 2)
                        Else
                            temp1 = "1" & temp1.Substring(1, 2)
                        End If

                        If bit2 = 1 Then
                            temp2 = "0" & temp2.Substring(1, 2)
                        Else
                            temp2 = "1" & temp2.Substring(1, 2)
                        End If

                        tempTerseleksi = tempTerseleksi & temp1 & temp2
                    Else

                        tempTerseleksi = tempTerseleksi & temp
                    End If
                Else
                    tempTerseleksi = tempTerseleksi & temp
                End If

                tempTerseleksi = tempTerseleksi & " "
            Next

            iota = tempTerseleksi

            ''''''''''''''''''''''''''
            '
            'Penambahan BIT
            '
            ''''''''''''''''''''''''''
            temp = ""
            Dim tempBit As String = ""
            Dim data() As String = iota.Trim.Split(" ")
            For y = 0 To UBound(data)
                For x = 0 To data(y).Length - 1
                    temp = temp & data(y).Substring(x, 1)
                Next
                arrayHexa(y) = temp & "00" 'menambahkan bit
                tempBit = tempBit & arrayHexa(y) & " "
                temp = ""
            Next


            'merubah dari biner ke HEXA
            temp = ""
            For y = 0 To 3
                temp = temp & Convert.ToString(Convert.ToInt32(arrayHexa(y), 2), 16).ToUpper & " "
            Next

            stringHASH = stringHASH & temp


            'Hasil akhir dari penambahan bit akan dijadikan sebagai nilai Bitrate untuk di XOR kan kembali ke P berikutnya

            For y = 0 To 3
                For x = 0 To 7
                    bitrate(x, y) = arrayHexa(y).Substring(x, 1).ToString
                Next
            Next

        Next

        Return stringHASH
    End Function
End Module
