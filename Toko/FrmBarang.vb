Imports vb = Microsoft.VisualBasic
Public Class FrmBarang
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim TblBarang As DataTable
    Dim Data As DataSet
    Sub Data_Record()
        TblBarang = Proses.ExecuteQuery("Select * From tblbarang")
        DGBarang.DataSource = TblBarang
        DGBarang.Columns(0).Width = 50
        DGBarang.Columns(1).Width = 195
        DGBarang.Columns(6).Width = 50
    End Sub
    Sub Data_Merk()
        TblBarang = Proses.ExecuteQuery("Select * From Tblmerk")
        If TblBarang.Rows.Count = 0 Then
        Else
            CmbMerk.Items.Clear()
            With TblBarang.Columns(1)
                For a = 0 To TblBarang.Rows.Count - 1
                    CmbMerk.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub
    Sub Data_Satuan()
        TblBarang = Proses.ExecuteQuery("Select * From TblSatuan")
        If TblBarang.Rows.Count = 0 Then
        Else
            CmbSatuan.Items.Clear()
            With TblBarang.Columns(1)
                For a = 0 To TblBarang.Rows.Count - 1
                    CmbSatuan.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub
    Sub Atur()
        TxtID.ReadOnly = False
        TxtID.Text = ""
        TxtNm.Text = ""
        CmbMerk.Text = ""
        CmbSatuan.Text = ""
        TxtHrgBeli.Text = ""
        TxtHrgJual.Text = ""
        TxtStock.Text = "0"

        BtnTambah.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnKoreksiStock.Enabled = False

        Call Data_Merk()
        Call Data_Satuan()
        Call Data_Record()

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub
    Private Sub DGBarang_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGBarang.DoubleClick
        Try
            Select Case Me.Text
                Case "Data Barang"
                    TxtID.Text = DGBarang.SelectedCells(0).Value
                    TxtNm.Text = DGBarang.SelectedCells(1).Value
                    CmbMerk.Text = DGBarang.SelectedCells(2).Value
                    CmbSatuan.Text = DGBarang.SelectedCells(3).Value
                    TxtHrgBeli.Text = DGBarang.SelectedCells(4).Value
                    TxtHrgJual.Text = DGBarang.SelectedCells(5).Value
                    TxtStock.Text = DGBarang.SelectedCells(6).Value
                    TxtID.ReadOnly = True
                    BtnTambah.Enabled = False
                    BtnUbah.Enabled = True
                    BtnHapus.Enabled = True
                    BtnKoreksiStock.Enabled = True
                Case "Data Barang Pembelian"
                    FrmTransaksiBeli.CmbID.Text = "" & DGBarang.SelectedCells(0).Value & "/" & DGBarang.SelectedCells(1).Value & ""
                    Me.Close()
                Case "Data Barang Penjualan"
                    FrmTransaksiJual.CmbID.Text = "" & DGBarang.SelectedCells(0).Value & "/" & DGBarang.SelectedCells(1).Value & ""
                    Me.Close()
            End Select
        Catch
        End Try
    End Sub
    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        SQL = "Insert Into Tblbarang Values ('" & TxtID.Text & "','" & TxtNm.Text & "','" & vb.Left(CmbMerk.Text, 7) & "','" & vb.Left(CmbSatuan.Text, 7) & "','" & TxtHrgBeli.Text & "','" & TxtHrgJual.Text & "','" & TxtStock.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()
    End Sub
    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        SQL = "Update tblBarang set Nama ='" & TxtNm.Text & "', merk = '" & vb.Left(CmbMerk.Text, 7) & "',  satuan = '" & vb.Left(CmbSatuan.Text, 7) & "', hrg_beli = '" & TxtHrgBeli.Text & "', hrg_jual = '" & TxtHrgJual.Text & "',stock = '" & TxtStock.Text & "' where id ='" & TxtID.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data sudah diperbaiki...!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()
    End Sub
    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        SQL = "delete from tblbarang where ID ='" & TxtID.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data sudah dihapus...!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()
    End Sub
    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Atur()
    End Sub
    Private Sub BtnKoreksiStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKoreksiStock.Click
        Dim Jumlah = InputBox("Masukkan jumlah barang", "Tambah stock")
        On Error GoTo Pesan
        Dim Tambah_Stock = Val(TxtStock.Text) + Val(Jumlah)
        SQL = "Update tblbarang set stock = '" & Tambah_Stock & "' where ID ='" & TxtID.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Penambahan stock berhasil!!", "Tambah stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()
        Exit Sub
Pesan:
        MsgBox("Masukkan Angka")
    End Sub
    Private Sub BtnMerk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMerk.Click
        FrmMerk.Text = "Data Merk Barang"
        FrmMerk.ShowDialog()
    End Sub
    Private Sub BtnSatuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSatuan.Click
        FrmSatuan.Text = "Data Merk Satuan"
        FrmSatuan.ShowDialog()
    End Sub
    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        If RbNama.Checked = True Then
            TblBarang = Proses.ExecuteQuery("Select * From TblBarang where nama like '%" & TxtCari.Text & "%' order by id asc")
            DGBarang.DataSource = TblBarang
            DGBarang.Columns(0).Width = 50
            DGBarang.Columns(1).Width = 195
            DGBarang.Columns(6).Width = 50
        ElseIf RbMerk.Checked = True Then
            TblBarang = Proses.ExecuteQuery("Select * From TblBarang where merk like '%" & TxtCari.Text & "%' order by id asc")
            DGBarang.DataSource = TblBarang
            DGBarang.Columns(0).Width = 50
            DGBarang.Columns(1).Width = 195
            DGBarang.Columns(6).Width = 50
        ElseIf RbSatuan.Checked = True Then
            TblBarang = Proses.ExecuteQuery("Select * From TblBarang where satuan like '%" & TxtCari.Text & "%' order by id asc")
            DGBarang.DataSource = TblBarang
            DGBarang.Columns(0).Width = 50
            DGBarang.Columns(1).Width = 195
            DGBarang.Columns(6).Width = 50
        End If
    End Sub

    Private Sub DGBarang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBarang.CellContentClick

    End Sub
End Class