Imports System.Data.SqlClient

Public Class Form1
    ' Declaring class-level variables for SQL operations
    Dim sqlconn As SqlConnection
    Dim sqlcmd As SqlCommand
    Dim sqlRd As SqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New SqlDataAdapter
    Dim sqlQuery As String

    ' Database connection parameters
    Dim Server As String = "JENNINGS\MSSQLSERVER1"
    Dim Database As String = "LibraryDB"

    Private bitmap As Bitmap

    ' Method to update DataGridView with current data from Books table
    Private Sub updatetable()
        Try
            ' Establishing connection to SQL Server
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' Executing SQL query to fetch all rows from Books table
            sqlcmd = New SqlCommand("SELECT * FROM Books", sqlconn)
            sqlRd = sqlcmd.ExecuteReader()

            ' Loading data into DataTable and binding it to DataGridView
            sqlDt.Clear()
            sqlDt.Load(sqlRd)
            sqlRd.Close()
            sqlconn.Close()
            dvgBooks.DataSource = sqlDt

        Catch ex As Exception
            ' Handling exceptions related to SQL operations
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensuring connection is closed even if an exception occurs
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try
    End Sub

    ' Form load event handler: initial data load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatetable()
    End Sub

    ' Button click event handler for adding a new record to Books table
    Private Sub BtnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Try
            ' Establishing connection to SQL Server
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' SQL query to insert new record into Books table
            sqlQuery = "INSERT INTO Books (Title, Author, YearPublished, Genre) VALUES (@Title, @Author, @YearPublished, @Genre)"
            sqlcmd = New SqlCommand(sqlQuery, sqlconn)

            ' Adding parameter values for the insert query
            sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            sqlcmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
            sqlcmd.Parameters.AddWithValue("@YearPublished", txtYearPublish.Text)
            sqlcmd.Parameters.AddWithValue("@Genre", txtGenre.Text)

            ' Executing the insert query
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            ' Handling exceptions related to SQL operations
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensuring connection is closed even if an exception occurs
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        ' Refreshing DataGridView with updated data
        updatetable()
    End Sub

    ' Button click event handler for updating records in the Books table
    Private Sub BtnUpdate2_Click(sender As Object, e As EventArgs) Handles BtnUpdate2.Click
        ' This button appears not to have been fully implemented in the provided code.
        ' Typically, it would involve retrieving data from UI controls, executing an UPDATE SQL command, and then calling updatetable().

        ' Placeholder comment reflecting that update functionality needs implementation.
        updatetable()
    End Sub

    ' Button click event handler for deleting a record from Books table
    Private Sub BtnDelete2_Click(sender As Object, e As EventArgs) Handles BtnDelete2.Click
        Try
            ' Establishing connection to SQL Server
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' SQL query to delete a record from Books table based on Title
            sqlQuery = "DELETE FROM Books WHERE Title = @Title"
            sqlcmd = New SqlCommand(sqlQuery, sqlconn)

            ' Adding parameter value for delete query
            sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text)

            ' Executing the delete query
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            ' Handling exceptions related to SQL operations
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensuring connection is closed even if an exception occurs
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        ' Refreshing DataGridView with updated data
        updatetable()
    End Sub

    ' Button click event handler for clearing all records from Books table
    Private Sub BtnClear2_Click(sender As Object, e As EventArgs) Handles BtnClear2.Click
        Try
            ' Establishing connection to SQL Server
            sqlconn = New SqlConnection()
            sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"
            sqlconn.Open()

            ' SQL query to delete all records from Books table
            sqlQuery = "DELETE FROM Books"
            sqlcmd = New SqlCommand(sqlQuery, sqlconn)

            ' Executing the delete query
            sqlcmd.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            ' Handling exceptions related to SQL operations
            MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensuring connection is closed even if an exception occurs
            If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
        End Try

        ' Refreshing DataGridView with updated data
        updatetable()
    End Sub

End Class
