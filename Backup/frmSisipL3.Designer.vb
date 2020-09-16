<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSisipL3
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
        Me.picStego = New System.Windows.Forms.PictureBox
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnLanjut = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblWaktu = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSisip = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.dlgSavePicture = New System.Windows.Forms.SaveFileDialog
        Me.txtCitraHasil = New System.Windows.Forms.TextBox
        CType(Me.picStego, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Citra Stego"
        '
        'picStego
        '
        Me.picStego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStego.Location = New System.Drawing.Point(11, 49)
        Me.picStego.Name = "picStego"
        Me.picStego.Size = New System.Drawing.Size(400, 400)
        Me.picStego.TabIndex = 4
        Me.picStego.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(303, 502)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(109, 34)
        Me.btnKeluar.TabIndex = 15
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnLanjut
        '
        Me.btnLanjut.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanjut.Location = New System.Drawing.Point(188, 502)
        Me.btnLanjut.Name = "btnLanjut"
        Me.btnLanjut.Size = New System.Drawing.Size(109, 34)
        Me.btnLanjut.TabIndex = 16
        Me.btnLanjut.Text = "Lanjut"
        Me.btnLanjut.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "milisekon"
        '
        'lblWaktu
        '
        Me.lblWaktu.BackColor = System.Drawing.Color.White
        Me.lblWaktu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWaktu.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktu.Location = New System.Drawing.Point(113, 455)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(117, 27)
        Me.lblWaktu.TabIndex = 28
        Me.lblWaktu.Text = "0"
        Me.lblWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Waktu Eksekusi :"
        '
        'btnSisip
        '
        Me.btnSisip.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSisip.Location = New System.Drawing.Point(303, 12)
        Me.btnSisip.Name = "btnSisip"
        Me.btnSisip.Size = New System.Drawing.Size(109, 34)
        Me.btnSisip.TabIndex = 30
        Me.btnSisip.Text = "Sisipkan"
        Me.btnSisip.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(302, 451)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(109, 34)
        Me.btnSimpan.TabIndex = 31
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'dlgSavePicture
        '
        Me.dlgSavePicture.Filter = "Graphics Files|*.bmp;*.jpg;*.jpeg;*.png|All Files|*.*"
        '
        'txtCitraHasil
        '
        Me.txtCitraHasil.Location = New System.Drawing.Point(113, 556)
        Me.txtCitraHasil.Name = "txtCitraHasil"
        Me.txtCitraHasil.Size = New System.Drawing.Size(446, 20)
        Me.txtCitraHasil.TabIndex = 40
        Me.txtCitraHasil.Visible = False
        '
        'frmSisipL3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 548)
        Me.Controls.Add(Me.txtCitraHasil)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnSisip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLanjut)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picStego)
        Me.Name = "frmSisipL3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proses Penyisipan Citra Biner - Simpan Citra Stego"
        CType(Me.picStego, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picStego As System.Windows.Forms.PictureBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnLanjut As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblWaktu As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSisip As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents dlgSavePicture As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtCitraHasil As System.Windows.Forms.TextBox
End Class
