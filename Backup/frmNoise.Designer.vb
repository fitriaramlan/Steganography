<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoise
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
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnProses = New System.Windows.Forms.Button
        Me.txtNoise = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dlgOpenPicture = New System.Windows.Forms.OpenFileDialog
        Me.dlgSavePicture = New System.Windows.Forms.SaveFileDialog
        Me.PanelCanvas = New System.Windows.Forms.Panel
        Me.picCanvas = New System.Windows.Forms.PictureBox
        Me.pic1 = New System.Windows.Forms.PictureBox
        Me.PanelCanvas.SuspendLayout()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Citra Stego / Citra Teracak"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(544, 9)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(109, 23)
        Me.btnBrowse.TabIndex = 17
        Me.btnBrowse.Text = "Browse Citra"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(659, 546)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(109, 34)
        Me.btnKeluar.TabIndex = 18
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(433, 9)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 23)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "Reset Gambar"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(659, 506)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(109, 34)
        Me.btnSimpan.TabIndex = 20
        Me.btnSimpan.Text = "Simpan Citra"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(250, 600)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(94, 30)
        Me.btnProses.TabIndex = 23
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'txtNoise
        '
        Me.txtNoise.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoise.Location = New System.Drawing.Point(162, 602)
        Me.txtNoise.Name = "txtNoise"
        Me.txtNoise.Size = New System.Drawing.Size(82, 26)
        Me.txtNoise.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 605)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Jumlah titik noise"
        '
        'dlgOpenPicture
        '
        Me.dlgOpenPicture.Filter = "Image Files|*.bmp;*.gif;*.jpg;*.jpe*;*.png;*.tif|All Files (*.*)|*.*"
        '
        'dlgSavePicture
        '
        Me.dlgSavePicture.Filter = "Bmp File|*.bmp|JPG Files|*.jpg|GIF Files|*GIF"
        '
        'PanelCanvas
        '
        Me.PanelCanvas.BackColor = System.Drawing.SystemColors.Control
        Me.PanelCanvas.Controls.Add(Me.picCanvas)
        Me.PanelCanvas.Location = New System.Drawing.Point(12, 38)
        Me.PanelCanvas.Name = "PanelCanvas"
        Me.PanelCanvas.Size = New System.Drawing.Size(641, 542)
        Me.PanelCanvas.TabIndex = 122
        '
        'picCanvas
        '
        Me.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCanvas.Location = New System.Drawing.Point(3, 3)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(610, 536)
        Me.picCanvas.TabIndex = 1
        Me.picCanvas.TabStop = False
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Black
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic1.Location = New System.Drawing.Point(806, 605)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(44, 34)
        Me.pic1.TabIndex = 123
        Me.pic1.TabStop = False
        Me.pic1.Visible = False
        '
        'frmNoise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 652)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.PanelCanvas)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.txtNoise)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoise"
        Me.Text = "Form Add Noise"
        Me.PanelCanvas.ResumeLayout(False)
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents txtNoise As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dlgOpenPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSavePicture As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PanelCanvas As System.Windows.Forms.Panel
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
End Class
