<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransaksiBeli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransaksiBeli))
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.BtnBatalBeli = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtNmPemasok = New System.Windows.Forms.TextBox()
        Me.TxtFaktur = New System.Windows.Forms.TextBox()
        Me.TxtStockBrg = New System.Windows.Forms.TextBox()
        Me.TxtHrgJualBrg = New System.Windows.Forms.TextBox()
        Me.TxtJml = New System.Windows.Forms.TextBox()
        Me.TxtNmBrg = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbID = New System.Windows.Forms.ComboBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.DGTransaksi = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBarang
        '
        Me.BtnBarang.Image = CType(resources.GetObject("BtnBarang.Image"), System.Drawing.Image)
        Me.BtnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBarang.Location = New System.Drawing.Point(163, 60)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(26, 24)
        Me.BtnBarang.TabIndex = 87
        Me.BtnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'BtnBatalBeli
        '
        Me.BtnBatalBeli.Image = CType(resources.GetObject("BtnBatalBeli.Image"), System.Drawing.Image)
        Me.BtnBatalBeli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatalBeli.Location = New System.Drawing.Point(10, 474)
        Me.BtnBatalBeli.Name = "BtnBatalBeli"
        Me.BtnBatalBeli.Size = New System.Drawing.Size(87, 24)
        Me.BtnBatalBeli.TabIndex = 86
        Me.BtnBatalBeli.Text = "Batal"
        Me.BtnBatalBeli.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(528, 447)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Total :"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(572, 444)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(176, 20)
        Me.TxtTotal.TabIndex = 84
        Me.TxtTotal.Text = "0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNmPemasok
        '
        Me.TxtNmPemasok.Location = New System.Drawing.Point(602, 33)
        Me.TxtNmPemasok.Name = "TxtNmPemasok"
        Me.TxtNmPemasok.Size = New System.Drawing.Size(146, 20)
        Me.TxtNmPemasok.TabIndex = 82
        '
        'TxtFaktur
        '
        Me.TxtFaktur.Location = New System.Drawing.Point(602, 7)
        Me.TxtFaktur.Name = "TxtFaktur"
        Me.TxtFaktur.ReadOnly = True
        Me.TxtFaktur.Size = New System.Drawing.Size(146, 20)
        Me.TxtFaktur.TabIndex = 80
        '
        'TxtStockBrg
        '
        Me.TxtStockBrg.Location = New System.Drawing.Point(554, 63)
        Me.TxtStockBrg.Name = "TxtStockBrg"
        Me.TxtStockBrg.Size = New System.Drawing.Size(91, 20)
        Me.TxtStockBrg.TabIndex = 77
        Me.TxtStockBrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtHrgJualBrg
        '
        Me.TxtHrgJualBrg.Location = New System.Drawing.Point(454, 63)
        Me.TxtHrgJualBrg.Name = "TxtHrgJualBrg"
        Me.TxtHrgJualBrg.Size = New System.Drawing.Size(94, 20)
        Me.TxtHrgJualBrg.TabIndex = 75
        Me.TxtHrgJualBrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtJml
        '
        Me.TxtJml.Location = New System.Drawing.Point(651, 63)
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(97, 20)
        Me.TxtJml.TabIndex = 74
        Me.TxtJml.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNmBrg
        '
        Me.TxtNmBrg.Location = New System.Drawing.Point(195, 63)
        Me.TxtNmBrg.Name = "TxtNmBrg"
        Me.TxtNmBrg.Size = New System.Drawing.Size(253, 20)
        Me.TxtNmBrg.TabIndex = 73
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(501, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Pemasok :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(501, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "No Faktur :"
        '
        'CmbID
        '
        Me.CmbID.FormattingEnabled = True
        Me.CmbID.Location = New System.Drawing.Point(53, 63)
        Me.CmbID.Name = "CmbID"
        Me.CmbID.Size = New System.Drawing.Size(104, 21)
        Me.CmbID.TabIndex = 79
        '
        'BtnProses
        '
        Me.BtnProses.Image = CType(resources.GetObject("BtnProses.Image"), System.Drawing.Image)
        Me.BtnProses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProses.Location = New System.Drawing.Point(102, 474)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(87, 24)
        Me.BtnProses.TabIndex = 78
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'DGTransaksi
        '
        Me.DGTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransaksi.Location = New System.Drawing.Point(10, 90)
        Me.DGTransaksi.Name = "DGTransaksi"
        Me.DGTransaksi.Size = New System.Drawing.Size(738, 345)
        Me.DGTransaksi.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "ID :"
        '
        'FrmTransaksiBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 507)
        Me.Controls.Add(Me.BtnBarang)
        Me.Controls.Add(Me.BtnBatalBeli)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtNmPemasok)
        Me.Controls.Add(Me.TxtFaktur)
        Me.Controls.Add(Me.TxtStockBrg)
        Me.Controls.Add(Me.TxtHrgJualBrg)
        Me.Controls.Add(Me.TxtJml)
        Me.Controls.Add(Me.TxtNmBrg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmbID)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.DGTransaksi)
        Me.Controls.Add(Me.Label15)
        Me.MaximizeBox = False
        Me.Name = "FrmTransaksiBeli"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Pembelian"
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBarang As System.Windows.Forms.Button
    Friend WithEvents BtnBatalBeli As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmPemasok As System.Windows.Forms.TextBox
    Friend WithEvents TxtFaktur As System.Windows.Forms.TextBox
    Friend WithEvents TxtStockBrg As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgJualBrg As System.Windows.Forms.TextBox
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmBrg As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CmbID As System.Windows.Forms.ComboBox
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents DGTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
