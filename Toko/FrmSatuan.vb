Public Class FrmSatuan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblMerk As DataTable
    Sub Data_Record()
        tblMerk = Proses.ExecuteQuery("Select * From TblSatuan")
        DGSatuan.DataSource = tblMerk
        DGSatuan.Columns(0).Width = 50
        DGSatuan.Columns(1).Width = 170
    End Sub
    Sub Kode_Otomatis()
        tblMerk = Proses.ExecuteQuery("Select * From Tblsatuan order by ID desc")
        If tblMerk.Rows.Count = 0 Then
            TxtID.Text = "STN-001"
        Else
            With tblMerk.Rows(0)
                TxtID.Text = .Item("ID")
            End With

            TxtID.Text = Val(Microsoft.VisualBasic.Mid(TxtID.Text, 5, 3)) + 1

            If Len(TxtID.Text) = 1 Then
                TxtID.Text = "STN-00" & TxtID.Text & ""
            ElseIf Len(TxtID.Text) = 2 Then
                TxtID.Text = "STN-0" & TxtID.Text & ""
            ElseIf Len(TxtID.Text) = 3 Then
                TxtID.Text = "STN-" & TxtID.Text & ""
            End If

        End If
    End Sub
    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        BtnTambah.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        TxtID.Enabled = False
        TxtNm.Text = ""
        TxtNm.Focus()
    End Sub
    Private Sub FrmJenisbarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub DGSatuan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGSatuan.DoubleClick
        Select Case Me.Text
            Case "Data Satuan"
                TxtID.Text = DGSatuan.SelectedCells(0).Value
                TxtNm.Text = DGSatuan.SelectedCells(1).Value
                BtnUbah.Enabled = True
                BtnHapus.Enabled = True
                BtnTambah.Enabled = False
            Case "Data Satuan Barang"
                FrmBarang.CmbSatuan.Text = "" & DGSatuan.SelectedCells(0).Value & "/" & DGSatuan.SelectedCells(1).Value & ""
                Me.Close()
        End Select
    End Sub
    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If TxtNm.Text = "" Then TxtNm.Focus() : Exit Sub
        SQL = "Insert Into Tblsatuan Values ('" & TxtID.Text & "','" & TxtNm.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        Call Atur()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        SQL = "delete from tblsatuan where ID = '" & TxtID.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        Call Atur()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TxtNm.Text = "" Then TxtNm.Focus() : Exit Sub
        SQL = "update Tblsatuan set satuan = '" & TxtNm.Text & "' where ID = '" & TxtID.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        Call Atur()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Atur()
    End Sub

    Private Sub DGMerk_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSatuan.CellContentClick

    End Sub
End Class