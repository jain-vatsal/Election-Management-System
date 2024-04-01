Imports System.Data.Odbc

Public Class login_page
    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim role As String = txtRole.Text ' Assuming txtRole is the ComboBox

        Dim sqlQuery As String = ""
        Dim loginSuccessful As Boolean = False
        Dim voterId As Integer = 0

        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()

                ' Construct the SQL query based on the selected role
                Select Case role
                    Case "Admin"
                        sqlQuery = "SELECT * FROM adminTable WHERE admin_email = ? AND admin_password = ?"
                    Case "Voter"
                        sqlQuery = "SELECT voter_id FROM voters WHERE voter_email = ? AND voter_password = ?"
                    Case "Candidate"
                        ' Code for Candidate login
                End Select

                Dim command As New OdbcCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@password", password)

                Dim reader As OdbcDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    MessageBox.Show("Login successful.")
                    loginSuccessful = True
                    Me.Hide() ' Hide the current form

                    ' Open the corresponding form based on the role
                    Select Case role
                        Case "Admin"
                            Dim adminMainForm As New admin_main()
                            adminMainForm.emailId = email
                            adminMainForm.Show() ' Show the admin_main form
                        Case "Voter"
                            Dim voterDashboardForm As New voter_dashboard()
                            If reader.Read() Then
                                voterId = Convert.ToInt32(reader("voter_id"))
                            End If
                            voterDashboardForm.VoterId = voterId
                            voterDashboardForm.Show() ' Show the voter_dashboard form
                    End Select
                Else
                    MessageBox.Show("Invalid email or password for the selected role.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        If Not loginSuccessful Then
            ' Clear password field if login was not successful
            txtPassword.Clear()
        End If
    End Sub

    Private Sub login_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Assuming txtRole is the ComboBox for selecting the role
        txtRole.Items.AddRange(New String() {"Admin", "Voter"})
        txtPassword.PasswordChar = "*"c ' Set PasswordChar property to hide the password
    End Sub


    Private Sub btnVoterRegsiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoterRegsiter.Click
        ' Open the voter registration form
        Dim voterRegistrationForm As New voterReg()
        Me.Hide()
        voterRegistrationForm.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class