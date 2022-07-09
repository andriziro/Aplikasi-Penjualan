Imports System.Data.OleDb
Public Class Form_Penjualan
    Sub no_faktur()
        cmd = New OleDbCommand("select * from tbl_jual where faktur_jual in(select max(faktur_jual) from tbl_jual) order by faktur_jual DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            v0nofaktur.Text = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                v0nofaktur.Text = Format(Now, "yyMMdd") + "0001"
            Else
                v0nofaktur.Text = rd.Item("faktur_jual") + 1
            End If
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles v0kasir.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles v0tanggal.TextChanged

    End Sub
    Sub grand_total()
        Dim jumlah As Decimal = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            jumlah = jumlah + DataGridView1.Rows(i).Cells(6).Value
            v0grandtotal.Text = jumlah

        Next
        If v0grandtotal.Text = "" Then
            v0grandtotal.Text = "0"
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Form_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call no_faktur()
        Call grand_total()
        v0dibayar.Text = "0"
        v0kembalian.Text = "0"
        v0kdbarang.Focus()
        v0kasir.Text = Form_Menu.lbl_nama.Text

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        v0tanggal.Text = Format(Now, "MM/dd/yyyy")
        v0jam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub v0kdbarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v0kdbarang.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from tbl_barang where kode_barang='" & v0kdbarang.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                v0namabarang.Text = rd.Item("nama_barang")
                v0satuan.Text = rd.Item("satuan_barang")
                v0jenisbarang.Text = rd.Item("jenis_barang")
                v0harga.Text = rd.Item("harga_jual")
                MessageBox.Show("Barang DItemukan")
                v0qty.Focus()
            Else
                v0namabarang.Text = ""
                v0satuan.Text = ""
                v0jenisbarang.Text = ""
                v0harga.Text = ""
                v0kdbarang.Focus()
                MessageBox.Show("Barang Ini Tidak Ditemukan / Tidak Terdaftar Didatabase")
            End If
        End If
    End Sub
    Sub bersih_barang()
        v0kdbarang.Text = ""
        v0namabarang.Text = ""
        v0satuan.Text = ""
        v0jenisbarang.Text = ""
        v0harga.Text = ""
        v0qty.Text = ""
        v0totalharga.Text = ""
        v0kdbarang.Focus()
    End Sub

    Private Sub v0qty_TextChanged(sender As Object, e As EventArgs) Handles v0qty.TextChanged
        Try
            v0totalharga.Text = Val(v0harga.Text) * Val(v0qty.Text)
        Catch ex As Exception
            v0totalharga.Text = ""
        End Try
    End Sub

    Private Sub v0qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v0qty.KeyPress
        If e.KeyChar = Chr(13) Then
            DataGridView1.Rows.Add(v0kdbarang.Text, v0namabarang.Text, v0jenisbarang.Text, v0satuan.Text, v0harga.Text, v0qty.Text, v0totalharga.Text)
            Call bersih_barang()
            Call grand_total()
        End If
    End Sub

    Private Sub v0dibayar_TextChanged(sender As Object, e As EventArgs) Handles v0dibayar.TextChanged
        Try
            v0kembalian.Text = Val(v0dibayar.Text) - Val(v0grandtotal.Text)
        Catch ex As Exception
            v0kembalian.Text = "0"
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If v0grandtotal.Text = "0" Then
            MessageBox.Show("Belum ada Barang yang Diinput!!")
        ElseIf val(v0dibayar.Text) < Val(v0grandtotal.Text) Then
            MessageBox.Show("Pembayaran Masih Kurang !!")
        Else
            'Data simpan didatabase tabel jual
            Call koneksi()
            cmd = New OleDbCommand("insert into tbl_jual(faktur_jual,tgl_jual,jam,grand_total,dibayar,kembalian,kasir)values('" & v0nofaktur.Text &
                                   "','" & v0tanggal.Text &
                                   "','" & v0jam.Text &
                                   "','" & v0grandtotal.Text &
                                   "','" & v0dibayar.Text &
                                   "','" & v0kembalian.Text &
                                   "','" & v0kasir.Text &
                                   "') ", conn)
            cmd.ExecuteNonQuery()
            'simpan data rincian barang dari gridview ke tbl_rinci_jual
            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                cmd = New OleDbCommand("insert into tbl_rinci_jual values('" & v0nofaktur.Text &
                                       "','" & DataGridView1.Rows(baris).Cells(0).Value &
                                       "','" & DataGridView1.Rows(baris).Cells(5).Value &
                                       "','" & DataGridView1.Rows(baris).Cells(6).Value &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                'pengurangan stok  
                cmd = New OleDbCommand("select * from tbl_barang where kode_barang='" & DataGridView1.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    cmd = New OleDbCommand("update tbl_barang set stok='" & rd.Item("stok") - Val(DataGridView1.Rows(baris).Cells(5).Value) &
                                           "' where kode_barang='" & DataGridView1.Rows(baris).Cells(0).Value & "'", conn)
                    cmd.ExecuteNonQuery()
                End If

            Next
            'Membersikan data transaksi
            MessageBox.Show("Transaksi Penjualan Berhasil Disimpan !!!")
            DataGridView1.Rows.Clear()
            v0grandtotal.Text = ""
            v0dibayar.Text = ""
            v0kembalian.Text = ""
            Call no_faktur()
            Call bersih_barang()

        End If
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = Chr(27) Then
            Dim baris As Integer
            baris = DataGridView1.CurrentCell.RowIndex
            Try
                DataGridView1.Rows.RemoveAt(baris)
                Call grand_total()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Apakah data penjualan akan dihapus ...???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            DataGridView1.Rows.Clear()
            v0grandtotal.Text = ""
            v0dibayar.Text = ""
            v0kembalian.Text = ""
            MessageBox.Show("Data penjualan berhasil dihapus")
        End If
    End Sub
End Class