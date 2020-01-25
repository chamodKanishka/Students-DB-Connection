Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Conn As New SqlConnection
        Dim cmd As New SqlCommand

        Conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Chathuranga\AppData\Local\Temporary Projects\WindowsApplication1\StudentBase.mdf;Integrated Security=True;User Instance=True"
        Conn.Open()
        cmd.Connection = Conn
        cmd.CommandText = "INSERT INTO StudentInfo(Name,Age) Values(@Name,@Age);"
        cmd.Parameters.AddWithValue("Name", TextBoxName.Text)
        cmd.Parameters.AddWithValue("Age", TextBoxAge.Text)
        cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAge.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
