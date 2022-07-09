Imports System.Data.OleDb
Public Class Form_Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Username atau Password Masih Kosong")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_user where user_name='" & TextBox1.Text & "' and pwd='" & TextBox2.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                Form_Menu.lbl_nama.Text = rd.Item("nama_user")
                Form_Menu.lbl_level.Text = rd.Item("lvl")
                Me.Hide()
                Form_Menu.Show()
            Else
                MessageBox.Show("Password dan Username Salah !!!")
            End If
        End If
    End Sub
End Class