Imports System.Data.SqlClient

Public Class Form1
    Dim sqlconn As SqlConnection
    Dim sqlcmd As SqlCommand
    Dim sqlRd As SqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New SqlDataAdapter
    Dim sqlQuery As String

    Dim Server As String = "JENNINGS\MSSQLSERVER1"
    Dim Database As String = "LibraryDB"

    Private bitmap As Bitmap

    Private Sub updatetable()
        Try
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"

            sqlconn.Open()
            sqlcmd = New SqlCommand("SELECT * FROM Books", sqlconn)
            sqlRd = sqlcmd.ExecuteReader()

            sqlDt.Clear()
            sqlDt.Load(sqlRd)
            sqlRd.Close()
            sqlconn.Close()
            dvgBooks.DataSource = sqlDt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatetable()
    End Sub

    Private Sub BtnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Try
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"

            sqlconn.Open()

            sqlQuery = "INSERT INTO Books (Title, Author, YearPublished, Genre) VALUES (@Title, @Author, @YearPublished, @Genre)"

            sqlcmd = New SqlCommand(sqlQuery, sqlconn)
            sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            sqlcmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            sqlcmd.Parameters.AddWithValue("@YearPublished", txtYearPublish.Text)
            sqlcmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        updatetable()
    End Sub



    ' Fixing the btnUpdate_Click method
    Private Sub BtnUpdate2_Click(sender As Object, e As EventArgs) Handles BtnUpdate2.Click


        updatetable()
    End Sub

    Private Sub BtnDelete2_Click(sender As Object, e As EventArgs) Handles BtnDelete2.Click
        Try
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"

            sqlconn.Open()

            sqlQuery = "DELETE FROM Books WHERE Title = @Title"

            sqlcmd = New SqlCommand(sqlQuery, sqlconn)
            sqlcmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            sqlcmd.Parameters.AddWithValue("@Genre", txtGenre.Text)
            sqlcmd.Parameters.AddWithValue("@YearPublished", Integer.Parse(txtYearPublish.Text))
            sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        updatetable()
    End Sub


    Private Sub BtnClear2_Click(sender As Object, e As EventArgs) Handles BtnClear2.Click
        Try
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"

            sqlconn.Open()

            sqlQuery = "DELETE FROM Books"

            sqlcmd = New SqlCommand(sqlQuery, sqlconn)
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        updatetable()
    End Sub


End Class