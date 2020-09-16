<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSisipL2
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
        Me.picCitra = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBatal = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.pic2 = New System.Windows.Forms.PictureBox
        Me.btnEkstraksi = New System.Windows.Forms.Button
        Me.ofdOldFile = New System.Windows.Forms.OpenFileDialog
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFileInput = New System.Windows.Forms.TextBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblUkuran = New System.Windows.Forms.Label
        CType(Me.picCitra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCitra
        '
        Me.picCitra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCitra.Location = New System.Drawing.Point(14, 99)
        Me.picCitra.Name = "picCitra"
        Me.picCitra.Size = New System.Drawing.Size(400, 400)
        Me.picCitra.TabIndex = 0
        Me.picCitra.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Input Citra Sampul"
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(711, 556)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(109, 34)
        Me.btnBatal.TabIndex = 14
        Me.btnBatal.Text = "Batalkan Proses"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(510, 556)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(195, 34)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Lanjut ke Langkah Berikutnya"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Hasil Ekstraksi Warna Kulit"
        '
        'pic2
        '
        Me.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic2.Location = New System.Drawing.Point(420, 99)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(400, 400)
        Me.pic2.TabIndex = 16
        Me.pic2.TabStop = False
        '
        'btnEkstraksi
        '
        Me.btnEkstraksi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEkstraksi.Location = New System.Drawing.Point(552, 505)
        Me.btnEkstraksi.Name = "btnEkstraksi"
        Me.btnEkstraksi.Size = New System.Drawing.Size(268, 34)
        Me.btnEkstraksi.TabIndex = 18
        Me.btnEkstraksi.Text = "Proses Ekstraksi Warna Kulit Manusia"
        Me.btnEkstraksi.UseVisualStyleBackColor = True
        '
        'ofdOldFile
        '
        Me.ofdOldFile.FileName = "OpenFileDialog1"
        Me.ofdOldFile.Filter = "Graphics Files|*.bmp;*.jpg;*.jpeg;*.png|All Files|*.*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Langkah 2:"
        '
        'txtFileInput
        '
        Me.txtFileInput.Location = New System.Drawing.Point(14, 42)
        Me.txtFileInput.Name = "txtFileInput"
        Me.txtFileInput.Size = New System.Drawing.Size(705, 20)
        Me.txtFileInput.TabIndex = 53
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(725, 36)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(95, 30)
        Me.btnBrowse.TabIndex = 52
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 505)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Total piksel citra biner yang dapat ditampung"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(336, 505)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblTotal.TabIndex = 56
        '
        'lblUkuran
        '
        Me.lblUkuran.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUkuran.Location = New System.Drawing.Point(192, 80)
        Me.lblUkuran.Name = "lblUkuran"
        Me.lblUkuran.Size = New System.Drawing.Size(218, 16)
        Me.lblUkuran.TabIndex = 57
        Me.lblUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSisipL2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 602)
        Me.Controls.Add(Me.lblUkuran)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFileInput)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnEkstraksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picCitra)
        Me.Name = "frmSisipL2"
        Me.Text = "Proses Penyisipan Citra Biner - Input Citra Sampul"
        CType(Me.picCitra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCitra As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEkstraksi As System.Windows.Forms.Button
    Friend WithEvents ofdOldFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFileInput As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblUkuran As System.Windows.Forms.Label
End Class
