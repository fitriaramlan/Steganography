<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSisipL1
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picCitra = New System.Windows.Forms.PictureBox()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picAcak = New System.Windows.Forms.PictureBox()
        Me.btnAcak = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnLanjut = New System.Windows.Forms.Button()
        Me.lblUkuran = New System.Windows.Forms.Label()
        Me.txtFileInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ofdOldFile = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picCitra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAcak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(723, 42)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(95, 30)
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Input Citra Biner"
        '
        'picCitra
        '
        Me.picCitra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCitra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCitra.Location = New System.Drawing.Point(12, 103)
        Me.picCitra.Name = "picCitra"
        Me.picCitra.Size = New System.Drawing.Size(400, 400)
        Me.picCitra.TabIndex = 8
        Me.picCitra.TabStop = False
        '
        'txtL
        '
        Me.txtL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtL.Location = New System.Drawing.Point(125, 531)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(82, 26)
        Me.txtL.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 534)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nilai Kunci L"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(414, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Citra Biner Teracak"
        '
        'picAcak
        '
        Me.picAcak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAcak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAcak.Location = New System.Drawing.Point(418, 103)
        Me.picAcak.Name = "picAcak"
        Me.picAcak.Size = New System.Drawing.Size(400, 400)
        Me.picAcak.TabIndex = 13
        Me.picAcak.TabStop = False
        '
        'btnAcak
        '
        Me.btnAcak.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcak.Location = New System.Drawing.Point(213, 529)
        Me.btnAcak.Name = "btnAcak"
        Me.btnAcak.Size = New System.Drawing.Size(152, 30)
        Me.btnAcak.TabIndex = 15
        Me.btnAcak.Text = "Acak Citra Biner"
        Me.btnAcak.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(622, 528)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(195, 34)
        Me.btnBatal.TabIndex = 17
        Me.btnBatal.Text = "Batalkan Proses"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnLanjut
        '
        Me.btnLanjut.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanjut.Location = New System.Drawing.Point(421, 528)
        Me.btnLanjut.Name = "btnLanjut"
        Me.btnLanjut.Size = New System.Drawing.Size(195, 34)
        Me.btnLanjut.TabIndex = 16
        Me.btnLanjut.Text = "Lanjut ke Langkah Berikutnya"
        Me.btnLanjut.UseVisualStyleBackColor = True
        '
        'lblUkuran
        '
        Me.lblUkuran.AutoSize = True
        Me.lblUkuran.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUkuran.Location = New System.Drawing.Point(16, 507)
        Me.lblUkuran.Name = "lblUkuran"
        Me.lblUkuran.Size = New System.Drawing.Size(0, 16)
        Me.lblUkuran.TabIndex = 48
        '
        'txtFileInput
        '
        Me.txtFileInput.Location = New System.Drawing.Point(12, 48)
        Me.txtFileInput.Name = "txtFileInput"
        Me.txtFileInput.Size = New System.Drawing.Size(705, 20)
        Me.txtFileInput.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Langkah 1:"
        '
        'ofdOldFile
        '
        Me.ofdOldFile.FileName = "OpenFileDialog1"
        Me.ofdOldFile.Filter = "Graphics Files|*.bmp;*.jpg;*.jpeg;*.png|All Files|*.*"
        '
        'frmSisipL1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 571)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFileInput)
        Me.Controls.Add(Me.lblUkuran)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnLanjut)
        Me.Controls.Add(Me.btnAcak)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picAcak)
        Me.Controls.Add(Me.txtL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picCitra)
        Me.Name = "frmSisipL1"
        Me.Text = "Proses Penyisipan Citra Biner - Input Citra Biner"
        CType(Me.picCitra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAcak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picCitra As System.Windows.Forms.PictureBox
    Friend WithEvents txtL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picAcak As System.Windows.Forms.PictureBox
    Friend WithEvents btnAcak As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnLanjut As System.Windows.Forms.Button
    Friend WithEvents lblUkuran As System.Windows.Forms.Label
    Friend WithEvents txtFileInput As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ofdOldFile As System.Windows.Forms.OpenFileDialog
End Class
