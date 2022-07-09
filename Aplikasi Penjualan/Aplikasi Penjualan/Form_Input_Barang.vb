﻿Imports System.Data.OleDb
Public Class Form_Input_Barang
    Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Form_Input_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Semua wajib data diisi")
        Else
            'melakukan penecekan data ke database apakah kode barang sudah ada
            cmd = New OleDbCommand("select * from tbl_barang where kode_barang='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                'melakukan penyimpan data ke databases
                cmd = New OleDbCommand("insert into tbl_barang values('" & TextBox1.Text &
                                       "','" & TextBox2.Text &
                                       "','" & ComboBox1.Text &
                                       "','" & ComboBox2.Text &
                                       "','" & TextBox3.Text &
                                       "','" & TextBox4.Text &
                                       "','" & TextBox5.Text &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di tambah !!")
                Call clear()
                Call Form_Barang.tampil_barang()
            Else
                'melakukan edit data berdasarkan kode barang yg di panggil
                cmd = New OleDbCommand("update tbl_barang set nama_barang='" & TextBox2.Text &
                                       "',jenis_barang='" & ComboBox1.Text &
                                       "',satuan_barang='" & ComboBox2.Text &
                                       "',harga_beli='" & TextBox3.Text &
                                       "',harga_jual='" & TextBox4.Text &
                                       "',stok='" & TextBox5.Text &
                                       "' where kode_barang= '" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil di edit")
                Call clear()
                Call Form_Barang.tampil_barang()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'memanggil data barang berdasarkan kode
        cmd = New OleDbCommand("select * from tbl_barang where kode_barang='" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd(1)
            ComboBox1.Text = rd(2)
            ComboBox2.Text = rd(3)
            TextBox3.Text = rd(4)
            TextBox4.Text = rd(5)
            TextBox5.Text = rd(6)
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Apakah data akan dihapus ...???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("delete from tbl_barang where kode_barang='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
            Call clear()
            Call Form_Barang.tampil_barang()
        End If
    End Sub
End Class