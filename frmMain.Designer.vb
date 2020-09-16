<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MetodeEnkripsiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesEnkripsiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesDekripsiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesPengujianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MengenaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MetodeEnkripsiToolStripMenuItem, Me.ProsesPengujianToolStripMenuItem, Me.MengenaiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(698, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MetodeEnkripsiToolStripMenuItem
        '
        Me.MetodeEnkripsiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProsesEnkripsiToolStripMenuItem, Me.ProsesDekripsiToolStripMenuItem})
        Me.MetodeEnkripsiToolStripMenuItem.Name = "MetodeEnkripsiToolStripMenuItem"
        Me.MetodeEnkripsiToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.MetodeEnkripsiToolStripMenuItem.Text = "Metode Enkripsi"
        '
        'ProsesEnkripsiToolStripMenuItem
        '
        Me.ProsesEnkripsiToolStripMenuItem.Name = "ProsesEnkripsiToolStripMenuItem"
        Me.ProsesEnkripsiToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProsesEnkripsiToolStripMenuItem.Text = "Proses Enkripsi"
        '
        'ProsesDekripsiToolStripMenuItem
        '
        Me.ProsesDekripsiToolStripMenuItem.Name = "ProsesDekripsiToolStripMenuItem"
        Me.ProsesDekripsiToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProsesDekripsiToolStripMenuItem.Text = "Proses Dekripsi"
        '
        'ProsesPengujianToolStripMenuItem
        '
        Me.ProsesPengujianToolStripMenuItem.Name = "ProsesPengujianToolStripMenuItem"
        Me.ProsesPengujianToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.ProsesPengujianToolStripMenuItem.Text = "Proses Penambahan Noise"
        '
        'MengenaiToolStripMenuItem
        '
        Me.MengenaiToolStripMenuItem.Name = "MengenaiToolStripMenuItem"
        Me.MengenaiToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.MengenaiToolStripMenuItem.Text = "Mengenai"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 317)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Pengamanan Isi Informasi Menggunakan New Encryption Method dan Steganography"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MetodeEnkripsiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesEnkripsiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesDekripsiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MengenaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesPengujianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
