Imports System.Data.OleDb
Public Class Form_User
    Sub tampil_user()
        cmd = New OleDbCommand("select * from tbl_user", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub
    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Form_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_user()
        Call bersih()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call bersih()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Apakah data akan dihapus ...???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("delete from tbl_user where kode_user='" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
            Call bersih()
            Call tampil_user()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua wajib data diisi")
        Else
            'melakukan penecekan data ke database apakah kode user sudah ada
            cmd = New OleDbCommand("select * from tbl_user where kode_user='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                Call koneksi()
                'melakukan penyimpan data ke databases
                cmd = New OleDbCommand("insert into tbl_user values('" & TextBox1.Text &
                                       "','" & TextBox2.Text &
                                       "','" & TextBox3.Text &
                                       "','" & TextBox4.Text &
                                       "','" & ComboBox1.Text &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di tambah !!")
                Call bersih()
                Call tampil_user()
            Else
                Call koneksi()
                'melakukan edit data berdasarkan kode user yg di panggil
                cmd = New OleDbCommand("update tbl_user set nama_user='" & TextBox2.Text &
                                       "',user_name='" & TextBox3.Text &
                                       "',pwd='" & TextBox4.Text &
                                       "',lvl='" & ComboBox1.Text &
                                       "' where kode_user= '" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil di edit")
                Call bersih()
                Call tampil_user()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'memanggil data user berdasarkan kode
        cmd = New OleDbCommand("select * from tbl_user where kode_user='" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd(1)
            TextBox3.Text = rd(2)
            TextBox4.Text = rd(3)
            ComboBox1.Text = rd(4)
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            ComboBox1.Text = ""
        End If
    End Sub
End Class