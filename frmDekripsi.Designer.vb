<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDekripsi
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
        Me.btnDekripsi = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picDekripsi = New System.Windows.Forms.PictureBox()
        Me.picCitra = New System.Windows.Forms.PictureBox()
        Me.txtFileInput = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnLanjut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ofdOldFile = New System.Windows.Forms.OpenFileDialog()
        Me.lblUkuran = New System.Windows.Forms.Label()
        CType(Me.picDekripsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCitra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDekripsi
        '
        Me.btnDekripsi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDekripsi.Location = New System.Drawing.Point(727, 151)
        Me.btnDekripsi.Name = "btnDekripsi"
        Me.btnDekripsi.Size = New System.Drawing.Size(95, 30)
        Me.btnDekripsi.TabIndex = 71
        Me.btnDekripsi.Text = "Dekripsi"
        Me.btnDekripsi.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(418, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 19)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Citra Stego Hasil Dekripsi"
        '
        'picDekripsi
        '
        Me.picDekripsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDekripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDekripsi.Location = New System.Drawing.Point(422, 184)
        Me.picDekripsi.Name = "picDekripsi"
        Me.picDekripsi.Size = New System.Drawing.Size(400, 400)
        Me.picDekripsi.TabIndex = 69
        Me.picDekripsi.TabStop = False
        '
        'picCitra
        '
        Me.picCitra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCitra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCitra.Location = New System.Drawing.Point(16, 184)
        Me.picCitra.Name = "picCitra"
        Me.picCitra.Size = New System.Drawing.Size(400, 400)
        Me.picCitra.TabIndex = 68
        Me.picCitra.TabStop = False
        '
        'txtFileInput
        '
        Me.txtFileInput.Location = New System.Drawing.Point(16, 158)
        Me.txtFileInput.Name = "txtFileInput"
        Me.txtFileInput.Size = New System.Drawing.Size(301, 20)
        Me.txtFileInput.TabIndex = 67
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(321, 151)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(95, 30)
        Me.btnBrowse.TabIndex = 66
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Langkah 1:"
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(16, 60)
        Me.txtPwd.Multiline = True
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPwd.Size = New System.Drawing.Size(806, 62)
        Me.txtPwd.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Password"
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(713, 590)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(109, 34)
        Me.btnBatal.TabIndex = 62
        Me.btnBatal.Text = "Batalkan Proses"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnLanjut
        '
        Me.btnLanjut.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanjut.Location = New System.Drawing.Point(512, 590)
        Me.btnLanjut.Name = "btnLanjut"
        Me.btnLanjut.Size = New System.Drawing.Size(195, 34)
        Me.btnLanjut.TabIndex = 61
        Me.btnLanjut.Text = "Lanjut ke Langkah Berikutnya"
        Me.btnLanjut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 19)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Input Citra Terenkripsi"
        '
        'ofdOldFile
        '
        Me.ofdOldFile.FileName = "OpenFileDialog1"
        Me.ofdOldFile.Filter = "Graphics Files|*.bmp;*.jpg;*.jpeg;*.png|All Files|*.*"
        '
        'lblUkuran
        '
        Me.lblUkuran.AutoSize = True
        Me.lblUkuran.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUkuran.Location = New System.Drawing.Point(20, 590)
        Me.lblUkuran.Name = "lblUkuran"
        Me.lblUkuran.Size = New System.Drawing.Size(0, 16)
        Me.lblUkuran.TabIndex = 72
        '
        'frmDekripsi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 638)
        Me.Controls.Add(Me.lblUkuran)
        Me.Controls.Add(Me.btnDekripsi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picDekripsi)
        Me.Controls.Add(Me.picCitra)
        Me.Controls.Add(Me.txtFileInput)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnLanjut)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmDekripsi"
        Me.Text = "Proses Dekripsi"
        CType(Me.picDekripsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCitra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDekripsi As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picDekripsi As System.Windows.Forms.PictureBox
    Friend WithEvents picCitra As System.Windows.Forms.PictureBox
    Friend WithEvents txtFileInput As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnLanjut As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ofdOldFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblUkuran As System.Windows.Forms.Label
End Class
