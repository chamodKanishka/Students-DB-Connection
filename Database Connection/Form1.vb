Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Conn As New SqlConnection
        Dim cmd As New SqlCommand

        Conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Chathuranga\Desktop\Projects\Created Apps\Visual Basic App\Database Connection\Database Connection\StudentBase.mdf;Integrated Security=True;User Instance=True"
        Conn.Open()
        cmd.Connection = Conn
        cmd.CommandText = "INSERT INTO StudentInfo(Name,Age) Values(@Name,@Age);"
        cmd.Parameters.AddWithValue("Name", TextBoxName.Text)
        cmd.Parameters.AddWithValue("Age", TextBoxAge.Text)
        cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Conn As New SqlConnection
        Dim cmd As New SqlCommand

        Conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Chathuranga\Desktop\Projects\Created Apps\Visual Basic App\Database Connection\Database Connection\StudentBase.mdf;Integrated Security=True;User Instance=True"
        Conn.Open()
        cmd.Connection = Conn
        cmd.CommandText = "SELECT * FROM StudentInfo;"

        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()

        While reader.Read()
            MsgBox(reader("Name"))
        End While
        reader.Close()
        Conn.Close()
    End Sub
End Class
