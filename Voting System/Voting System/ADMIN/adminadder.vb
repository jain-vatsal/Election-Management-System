Imports System.Data.Odbc

Public Class adminadder
    Private adminEmail As String

    Public Property emailId() As String
        Get
            Return adminEmail
        End Get
        Set(ByVal value As String)
            adminEmail = value
        End Set
    End Property
    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"

        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        Dim sqlQuery As String = "INSERT INTO adminTable (admin_name, admin_email, admin_password) VALUES (?, ?, ?)"


        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim command As New OdbcCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("?", name)
                command.Parameters.AddWithValue("?", email)
                command.Parameters.AddWithValue("?", password)
                command.ExecuteNonQuery()
                MessageBox.Show("Admin added successfully.")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Hide()

        ' Show the login form
        Dim adminMainForm As New admin_main()
        adminMainForm.emailId = adminEmail
        adminMainForm.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class