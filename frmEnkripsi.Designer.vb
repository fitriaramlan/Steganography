<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnkripsi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCitraHasil = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picEnkripsi = New System.Windows.Forms.PictureBox()
        Me.btnEnkripsi = New System.Windows.Forms.Button()
        Me.dlgSavePicture = New System.Windows.Forms.SaveFileDialog()
        CType(Me.picEnkripsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 574)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lokasi Penyimpanan"
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(424, 626)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(109, 34)
        Me.btnKeluar.TabIndex = 14
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(14, 60)
        Me.txtPwd.Multiline = True
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPwd.Size = New System.Drawing.Size(519, 62)
        Me.txtPwd.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Langkah 4:"
        '
        'txtCitraHasil
        '
        Me.txtCitraHasil.Location = New System.Drawing.Point(14, 596)
        Me.txtCitraHasil.Name = "txtCitraHasil"
        Me.txtCitraHasil.Size = New System.Drawing.Size(418, 20)
        Me.txtCitraHasil.TabIndex = 55
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(438, 590)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(95, 30)
        Me.btnBrowse.TabIndex = 54
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Hasil Enkripsi"
        '
        'picEnkripsi
        '
        Me.picEnkripsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnkripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEnkripsi.Location = New System.Drawing.Point(13, 162)
        Me.picEnkripsi.Name = "picEnkripsi"
        Me.picEnkripsi.Size = New System.Drawing.Size(400, 400)
        Me.picEnkripsi.TabIndex = 57
        Me.picEnkripsi.TabStop = False
        '
        'btnEnkripsi
        '
        Me.btnEnkripsi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnkripsi.Location = New System.Drawing.Point(318, 129)
        Me.btnEnkripsi.Name = "btnEnkripsi"
        Me.btnEnkripsi.Size = New System.Drawing.Size(95, 30)
        Me.btnEnkripsi.TabIndex = 59
        Me.btnEnkripsi.Text = "Enkripsi"
        Me.btnEnkripsi.UseVisualStyleBackColor = True
        '
        'dlgSavePicture
        '
        Me.dlgSavePicture.Filter = "Graphics Files|*.bmp;*.jpg;*.jpeg;*.png|All Files|*.*"
        '
        'frmEnkripsi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 672)
        Me.Controls.Add(Me.btnEnkripsi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picEnkripsi)
        Me.Controls.Add(Me.txtCitraHasil)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmEnkripsi"
        Me.Text = "Proses Enkripsi"
        CType(Me.picEnkripsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCitraHasil As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picEnkripsi As System.Windows.Forms.PictureBox
    Friend WithEvents btnEnkripsi As System.Windows.Forms.Button
    Friend WithEvents dlgSavePicture As System.Windows.Forms.SaveFileDialog
End Class
