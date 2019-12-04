Public Class FrmMenu
    Private Sub Frmmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Format(Now, "dddd, dd-MMMM-yyyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub BtnBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBarang.Click
        FrmBarang.ShowDialog()
    End Sub

    Private Sub BtnMerk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMerk.Click
        FrmMerk.Text = "Data Merk"
        FrmMerk.ShowDialog()
    End Sub

    Private Sub BtnSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSatuan.Click
        FrmSatuan.Text = "Data Satuan"
        FrmSatuan.ShowDialog()
    End Sub

    Private Sub BtnTransaksiBeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransaksiBeli.Click
        FrmTransaksiBeli.ShowDialog()
    End Sub

    Private Sub BtnTransaksiJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransaksiJual.Click
        FrmTransaksiJual.ShowDialog()
    End Sub
End Class
