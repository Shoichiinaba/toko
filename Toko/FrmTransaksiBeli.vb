Imports vb = Microsoft.VisualBasic
Public Class FrmTransaksiBeli
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim TblTransaksi As DataTable
    Dim Data As DataSet
    Sub Data_Barang()
        TblTransaksi = Proses.ExecuteQuery("Select * From TblBarang")
        If TblTransaksi.Rows.Count = 0 Then
        Else
            CmbID.Items.Clear()
            With TblTransaksi.Columns(1)
                For a = 0 To TblTransaksi.Rows.Count - 1
                    CmbID.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub
    Sub Data_Record_Pembelian()
        TblTransaksi = Proses.ExecuteQuery("Select * From TblTransaksi_Beli_Rinci where No_Faktur = '" & TxtFaktur.Text & "'")
        DGTransaksi.DataSource = TblTransaksi
        DGTransaksi.Columns(0).Visible = False
        DGTransaksi.Columns(2).Width = 295
    End Sub
    Sub Faktur_Otomatis()
        TblTransaksi = Proses.ExecuteQuery("Select * From TblTransaksi_Beli order by no_faktur desc")
        If TblTransaksi.Rows.Count = 0 Then
            TxtFaktur.Text = "" + Format(Now, "yyyy-MM-dd") + "-001"
        Else
            With TblTransaksi.Rows(0)
                TxtFaktur.Text = .Item("no_faktur")
            End With

            TxtFaktur.Text = Val(Microsoft.VisualBasic.Mid(TxtFaktur.Text, 12, 3)) + 1

            If Len(TxtFaktur.Text) = 1 Then
                TxtFaktur.Text = "" + Format(Now, "yyyy-MM-dd") + "-00" & TxtFaktur.Text & ""
            ElseIf Len(TxtFaktur.Text) = 2 Then
                TxtFaktur.Text = "" + Format(Now, "yyyy-MM-dd") + "-0" & TxtFaktur.Text & ""
            ElseIf Len(TxtFaktur.Text) = 3 Then
                TxtFaktur.Text = "" + Format(Now, "yyyy-MM-dd") + "" & TxtFaktur.Text & ""
            End If

        End If
    End Sub
    Sub Atur()
        CmbID.Text = ""
        TxtNmBrg.Text = ""
        TxtHrgJualBrg.Text = ""
        TxtStockBrg.Text = ""
        TxtJml.Text = ""
        TxtTotal.Text = ""
        CmbID.Focus()
        Call Data_Barang()
        Call Data_Record_Pembelian()
        Call Faktur_Otomatis()
    End Sub

    Private Sub CmbID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbID.TextChanged
        TblTransaksi = Proses.ExecuteQuery("Select * From Tblbarang where ID = '" & vb.Left(CmbID.Text, 3) & "'")
        If TblTransaksi.Rows.Count = 0 Then
        Else
            TxtNmBrg.Text = TblTransaksi.Rows(0).Item("nama")
            TxtHrgJualBrg.Text = TblTransaksi.Rows(0).Item("hrg_beli")
            TxtStockBrg.Text = TblTransaksi.Rows(0).Item("stock")
            TxtJml.Focus()
        End If
    End Sub
    Private Sub TxtJml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJml.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJml.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                If TxtNmPemasok.Text = "" Then TxtNmPemasok.Focus() : Exit Sub

                Dim Total_Harga = Val(TxtJml.Text) * Val(TxtHrgJualBrg.Text)
                SQL = "Insert Into TblTransaksi_Beli_Rinci Values ('" & TxtFaktur.Text & "','" & vb.Left(CmbID.Text, 3) & "','" & TxtNmBrg.Text & "','" & TxtHrgJualBrg.Text & "','" & TxtJml.Text & "','" & Total_Harga & "')"
                Proses.ExecuteNonQuery(SQL)
                Dim Stock = Val(TxtStockBrg.Text) + Val(TxtJml.Text)
                SQL = "Update TblBarang set stock = '" & Stock & "' where ID = '" & vb.Left(CmbID.Text, 3) & "'"
                Proses.ExecuteNonQuery(SQL)

                CmbID.Text = ""
                TxtNmBrg.Text = ""
                TxtHrgJualBrg.Text = ""
                TxtStockBrg.Text = ""
                TxtJml.Text = ""
                CmbID.Focus()

                Call Data_Record_Pembelian()

                TxtTotal.Text = ""

                Dim i As Integer
                i = DGTransaksi.CurrentRow.Index
                For i = 0 To DGTransaksi.Rows.Count - 1
                    TxtTotal.Text = Format(Val(Replace(TxtTotal.Text, ".", "")) + Val(DGTransaksi.Item(5, i).Value), "#,#")
                Next

            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub
    Private Sub BtnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        SQL = "Insert Into TblTransaksi_Beli Values ('" & TxtFaktur.Text & "','" & Format(Now, "yyyy-MM-dd") & "','" & TxtNmPemasok.Text & "','" & TxtTotal.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        Call Faktur_Otomatis()
        Call Atur()
    End Sub
    Private Sub BtnBatalBeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatalBeli.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGTransaksi.CurrentRow.Index
        For i = 0 To DGTransaksi.Rows.Count - 1
            TblTransaksi = Proses.ExecuteQuery("select * from tblbarang where ID = '" & DGTransaksi.Item(3, i).Value & "'")
            If TblTransaksi.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(TblTransaksi.Rows(0).Item("stock")) - Val(DGTransaksi.Item(4, i).Value)
                SQL = "update tblbarang set stock = '" & CInt(Jumlah) & "' where id = '" & DGTransaksi.Item(3, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next

        SQL = "delete from TblTransaksi_beli_rinci where no_faktur ='" & TxtFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)

        MessageBox.Show("Transaksi sudah dibatalakan...!!", "Pembatalan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Atur()
        Call Faktur_Otomatis()
        Call Data_Record_Pembelian()
Keluar:
    End Sub
    Private Sub BtnBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBarang.Click
        FrmBarang.Text = "Data Barang Pembelian"
        FrmBarang.ShowDialog()
    End Sub

    Private Sub FrmTransaksiBeli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub TxtJml_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtJml.TextChanged

    End Sub

    Private Sub CmbID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbID.SelectedIndexChanged

    End Sub
End Class