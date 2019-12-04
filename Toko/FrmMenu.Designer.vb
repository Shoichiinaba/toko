<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.BtnMerk = New System.Windows.Forms.Button()
        Me.BtnSatuan = New System.Windows.Forms.Button()
        Me.BtnTransaksiBeli = New System.Windows.Forms.Button()
        Me.BtnTransaksiJual = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(177, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 28)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Program Toko Ver. Belajar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(155, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 38)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Pemrograman Database dengan Visual Basic 2010"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(171, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'BtnBarang
        '
        Me.BtnBarang.Image = CType(resources.GetObject("BtnBarang.Image"), System.Drawing.Image)
        Me.BtnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBarang.Location = New System.Drawing.Point(12, 12)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(106, 45)
        Me.BtnBarang.TabIndex = 52
        Me.BtnBarang.Text = "Barang"
        Me.BtnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'BtnMerk
        '
        Me.BtnMerk.ForeColor = System.Drawing.Color.Black
        Me.BtnMerk.Image = CType(resources.GetObject("BtnMerk.Image"), System.Drawing.Image)
        Me.BtnMerk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMerk.Location = New System.Drawing.Point(12, 63)
        Me.BtnMerk.Name = "BtnMerk"
        Me.BtnMerk.Size = New System.Drawing.Size(106, 45)
        Me.BtnMerk.TabIndex = 53
        Me.BtnMerk.Text = "Merk"
        Me.BtnMerk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMerk.UseVisualStyleBackColor = True
        '
        'BtnSatuan
        '
        Me.BtnSatuan.Image = CType(resources.GetObject("BtnSatuan.Image"), System.Drawing.Image)
        Me.BtnSatuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSatuan.Location = New System.Drawing.Point(12, 114)
        Me.BtnSatuan.Name = "BtnSatuan"
        Me.BtnSatuan.Size = New System.Drawing.Size(106, 45)
        Me.BtnSatuan.TabIndex = 54
        Me.BtnSatuan.Text = "Satuan"
        Me.BtnSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSatuan.UseVisualStyleBackColor = True
        '
        'BtnTransaksiBeli
        '
        Me.BtnTransaksiBeli.Image = CType(resources.GetObject("BtnTransaksiBeli.Image"), System.Drawing.Image)
        Me.BtnTransaksiBeli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTransaksiBeli.Location = New System.Drawing.Point(12, 197)
        Me.BtnTransaksiBeli.Name = "BtnTransaksiBeli"
        Me.BtnTransaksiBeli.Size = New System.Drawing.Size(106, 45)
        Me.BtnTransaksiBeli.TabIndex = 55
        Me.BtnTransaksiBeli.Text = "Transaksi Beli"
        Me.BtnTransaksiBeli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTransaksiBeli.UseVisualStyleBackColor = True
        '
        'BtnTransaksiJual
        '
        Me.BtnTransaksiJual.Image = CType(resources.GetObject("BtnTransaksiJual.Image"), System.Drawing.Image)
        Me.BtnTransaksiJual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTransaksiJual.Location = New System.Drawing.Point(12, 252)
        Me.BtnTransaksiJual.Name = "BtnTransaksiJual"
        Me.BtnTransaksiJual.Size = New System.Drawing.Size(106, 45)
        Me.BtnTransaksiJual.TabIndex = 56
        Me.BtnTransaksiJual.Text = "Transaksi Jual"
        Me.BtnTransaksiJual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTransaksiJual.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 323)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(489, 22)
        Me.StatusStrip1.TabIndex = 57
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 345)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnTransaksiJual)
        Me.Controls.Add(Me.BtnTransaksiBeli)
        Me.Controls.Add(Me.BtnSatuan)
        Me.Controls.Add(Me.BtnMerk)
        Me.Controls.Add(Me.BtnBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Toko Penjualan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBarang As System.Windows.Forms.Button
    Friend WithEvents BtnMerk As System.Windows.Forms.Button
    Friend WithEvents BtnSatuan As System.Windows.Forms.Button
    Friend WithEvents BtnTransaksiBeli As System.Windows.Forms.Button
    Friend WithEvents BtnTransaksiJual As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel

End Class
