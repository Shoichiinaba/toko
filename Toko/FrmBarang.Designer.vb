<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarang))
        Me.BtnSatuan = New System.Windows.Forms.Button()
        Me.CmbSatuan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RbSatuan = New System.Windows.Forms.RadioButton()
        Me.RbMerk = New System.Windows.Forms.RadioButton()
        Me.RbNama = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.BtnMerk = New System.Windows.Forms.Button()
        Me.CmbMerk = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnKoreksiStock = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtHrgJual = New System.Windows.Forms.TextBox()
        Me.TxtHrgBeli = New System.Windows.Forms.TextBox()
        Me.TxtNm = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSatuan
        '
        Me.BtnSatuan.Image = CType(resources.GetObject("BtnSatuan.Image"), System.Drawing.Image)
        Me.BtnSatuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSatuan.Location = New System.Drawing.Point(259, 87)
        Me.BtnSatuan.Name = "BtnSatuan"
        Me.BtnSatuan.Size = New System.Drawing.Size(26, 24)
        Me.BtnSatuan.TabIndex = 80
        Me.BtnSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSatuan.UseVisualStyleBackColor = True
        '
        'CmbSatuan
        '
        Me.CmbSatuan.FormattingEnabled = True
        Me.CmbSatuan.Location = New System.Drawing.Point(116, 89)
        Me.CmbSatuan.Name = "CmbSatuan"
        Me.CmbSatuan.Size = New System.Drawing.Size(137, 21)
        Me.CmbSatuan.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Satuan :"
        '
        'RbSatuan
        '
        Me.RbSatuan.AutoSize = True
        Me.RbSatuan.Location = New System.Drawing.Point(700, 145)
        Me.RbSatuan.Name = "RbSatuan"
        Me.RbSatuan.Size = New System.Drawing.Size(59, 17)
        Me.RbSatuan.TabIndex = 77
        Me.RbSatuan.TabStop = True
        Me.RbSatuan.Text = "Satuan"
        Me.RbSatuan.UseVisualStyleBackColor = True
        '
        'RbMerk
        '
        Me.RbMerk.AutoSize = True
        Me.RbMerk.Location = New System.Drawing.Point(645, 145)
        Me.RbMerk.Name = "RbMerk"
        Me.RbMerk.Size = New System.Drawing.Size(49, 17)
        Me.RbMerk.TabIndex = 76
        Me.RbMerk.TabStop = True
        Me.RbMerk.Text = "Merk"
        Me.RbMerk.UseVisualStyleBackColor = True
        '
        'RbNama
        '
        Me.RbNama.AutoSize = True
        Me.RbNama.Location = New System.Drawing.Point(547, 145)
        Me.RbNama.Name = "RbNama"
        Me.RbNama.Size = New System.Drawing.Size(90, 17)
        Me.RbNama.TabIndex = 75
        Me.RbNama.TabStop = True
        Me.RbNama.Text = "Nama Barang"
        Me.RbNama.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(500, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Cari :"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(547, 172)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(206, 20)
        Me.TxtCari.TabIndex = 73
        '
        'BtnMerk
        '
        Me.BtnMerk.Image = CType(resources.GetObject("BtnMerk.Image"), System.Drawing.Image)
        Me.BtnMerk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMerk.Location = New System.Drawing.Point(259, 60)
        Me.BtnMerk.Name = "BtnMerk"
        Me.BtnMerk.Size = New System.Drawing.Size(26, 24)
        Me.BtnMerk.TabIndex = 72
        Me.BtnMerk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMerk.UseVisualStyleBackColor = True
        '
        'CmbMerk
        '
        Me.CmbMerk.FormattingEnabled = True
        Me.CmbMerk.Location = New System.Drawing.Point(116, 62)
        Me.CmbMerk.Name = "CmbMerk"
        Me.CmbMerk.Size = New System.Drawing.Size(137, 21)
        Me.CmbMerk.TabIndex = 71
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 13)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "Merk :"
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(291, 476)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(86, 24)
        Me.BtnBatal.TabIndex = 68
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnKoreksiStock
        '
        Me.BtnKoreksiStock.Image = CType(resources.GetObject("BtnKoreksiStock.Image"), System.Drawing.Image)
        Me.BtnKoreksiStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKoreksiStock.Location = New System.Drawing.Point(653, 476)
        Me.BtnKoreksiStock.Name = "BtnKoreksiStock"
        Me.BtnKoreksiStock.Size = New System.Drawing.Size(100, 24)
        Me.BtnKoreksiStock.TabIndex = 67
        Me.BtnKoreksiStock.Text = "Koreksi Stock"
        Me.BtnKoreksiStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKoreksiStock.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(199, 476)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(86, 24)
        Me.BtnHapus.TabIndex = 66
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(107, 476)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(86, 24)
        Me.BtnUbah.TabIndex = 65
        Me.BtnUbah.Text = "&Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(15, 476)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(86, 24)
        Me.BtnTambah.TabIndex = 64
        Me.BtnTambah.Text = "&Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(116, 172)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(100, 20)
        Me.TxtStock.TabIndex = 63
        '
        'TxtHrgJual
        '
        Me.TxtHrgJual.Location = New System.Drawing.Point(116, 146)
        Me.TxtHrgJual.Name = "TxtHrgJual"
        Me.TxtHrgJual.Size = New System.Drawing.Size(100, 20)
        Me.TxtHrgJual.TabIndex = 62
        '
        'TxtHrgBeli
        '
        Me.TxtHrgBeli.Location = New System.Drawing.Point(116, 121)
        Me.TxtHrgBeli.Name = "TxtHrgBeli"
        Me.TxtHrgBeli.Size = New System.Drawing.Size(100, 20)
        Me.TxtHrgBeli.TabIndex = 61
        '
        'TxtNm
        '
        Me.TxtNm.Location = New System.Drawing.Point(116, 36)
        Me.TxtNm.Name = "TxtNm"
        Me.TxtNm.Size = New System.Drawing.Size(172, 20)
        Me.TxtNm.TabIndex = 60
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(116, 10)
        Me.TxtID.MaxLength = 3
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 20)
        Me.TxtID.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Stock :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Hrg Jual :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Hrg Beli :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "ID Barang :"
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(15, 198)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(738, 271)
        Me.DGBarang.TabIndex = 69
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 507)
        Me.Controls.Add(Me.BtnSatuan)
        Me.Controls.Add(Me.CmbSatuan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RbSatuan)
        Me.Controls.Add(Me.RbMerk)
        Me.Controls.Add(Me.RbNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.BtnMerk)
        Me.Controls.Add(Me.CmbMerk)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnKoreksiStock)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtHrgJual)
        Me.Controls.Add(Me.TxtHrgBeli)
        Me.Controls.Add(Me.TxtNm)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGBarang)
        Me.MaximizeBox = False
        Me.Name = "FrmBarang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSatuan As System.Windows.Forms.Button
    Friend WithEvents CmbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RbSatuan As System.Windows.Forms.RadioButton
    Friend WithEvents RbMerk As System.Windows.Forms.RadioButton
    Friend WithEvents RbNama As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents BtnMerk As System.Windows.Forms.Button
    Friend WithEvents CmbMerk As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnKoreksiStock As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgJual As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgBeli As System.Windows.Forms.TextBox
    Friend WithEvents TxtNm As System.Windows.Forms.TextBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
End Class
