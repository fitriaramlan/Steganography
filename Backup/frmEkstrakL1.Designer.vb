<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEkstrakL1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtL = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRekonstruksi = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.picCitraTeracak = New System.Windows.Forms.PictureBox
        Me.picCitraHasil = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnLaporan = New System.Windows.Forms.Button
        Me.btnEkstraksi = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblWaktu = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.picCitraTeracak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCitraHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Citra Biner Teracak"
        '
        'txtL
        '
        Me.txtL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL.Location = New System.Drawing.Point(126, 483)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(82, 26)
        Me.txtL.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nilai Kunci L"
        '
        'btnRekonstruksi
        '
        Me.btnRekonstruksi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRekonstruksi.Location = New System.Drawing.Point(214, 481)
        Me.btnRekonstruksi.Name = "btnRekonstruksi"
        Me.btnRekonstruksi.Size = New System.Drawing.Size(152, 30)
        Me.btnRekonstruksi.TabIndex = 15
        Me.btnRekonstruksi.Text = "Rekonstruksi"
        Me.btnRekonstruksi.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(694, 479)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(125, 34)
        Me.btnKeluar.TabIndex = 17
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Langkah 2:"
        '
        'picCitraTeracak
        '
        Me.picCitraTeracak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCitraTeracak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCitraTeracak.Location = New System.Drawing.Point(12, 70)
        Me.picCitraTeracak.Name = "picCitraTeracak"
        Me.picCitraTeracak.Size = New System.Drawing.Size(400, 400)
        Me.picCitraTeracak.TabIndex = 55
        Me.picCitraTeracak.TabStop = False
        '
        'picCitraHasil
        '
        Me.picCitraHasil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCitraHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCitraHasil.Location = New System.Drawing.Point(418, 70)
        Me.picCitraHasil.Name = "picCitraHasil"
        Me.picCitraHasil.Size = New System.Drawing.Size(400, 400)
        Me.picCitraHasil.TabIndex = 57
        Me.picCitraHasil.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(414, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 19)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Citra Hasil Rekonstruksi"
        '
        'btnLaporan
        '
        Me.btnLaporan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.Location = New System.Drawing.Point(563, 479)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(125, 34)
        Me.btnLaporan.TabIndex = 58
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnEkstraksi
        '
        Me.btnEkstraksi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEkstraksi.Location = New System.Drawing.Point(312, 37)
        Me.btnEkstraksi.Name = "btnEkstraksi"
        Me.btnEkstraksi.Size = New System.Drawing.Size(100, 30)
        Me.btnEkstraksi.TabIndex = 59
        Me.btnEkstraksi.Text = "Ekstraksi"
        Me.btnEkstraksi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(761, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "milisekon"
        '
        'lblWaktu
        '
        Me.lblWaktu.BackColor = System.Drawing.Color.White
        Me.lblWaktu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWaktu.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktu.Location = New System.Drawing.Point(638, 3)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(117, 27)
        Me.lblWaktu.TabIndex = 61
        Me.lblWaktu.Text = "0"
        Me.lblWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(533, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Waktu Eksekusi :"
        '
        'frmEkstrakL1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 525)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEkstraksi)
        Me.Controls.Add(Me.btnLaporan)
        Me.Controls.Add(Me.picCitraHasil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picCitraTeracak)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnRekonstruksi)
        Me.Controls.Add(Me.txtL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmEkstrakL1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proses Ekstraksi"
        CType(Me.picCitraTeracak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCitraHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRekonstruksi As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picCitraTeracak As System.Windows.Forms.PictureBox
    Friend WithEvents picCitraHasil As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
    Friend WithEvents btnEkstraksi As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblWaktu As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
