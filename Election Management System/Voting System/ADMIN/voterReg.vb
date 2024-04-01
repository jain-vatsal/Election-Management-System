Imports System.Data.Odbc

Public Class voterReg
    Private Sub voterReg_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Add hostel options to comboHostel
        comboHostel.Items.AddRange({"Lohit", "Brahma", "Manas", "Umiam", "Kapili", "Siang", "Disang", "Dhansiri", "Subhansiri", "Dihing", "Kameng", "Barak"})
    End Sub

    Private Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_register.Click
        Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
        ' Check if the email ends with "@iitg.ac.in"
        If Not txtEmail.Text.ToLower().EndsWith("@iitg.ac.in") Then
            MessageBox.Show("Email must end with @iitg.ac.in. Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Stop further execution
        End If
        Dim sqlQuery As String = "INSERT INTO voters (voter_name, voter_roll_no, voter_email, voter_password, voter_course, voter_year, hostel) VALUES (?, ?, ?, ?, ?, ?, ?); SELECT SCOPE_IDENTITY();"

        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim command As New OdbcCommand(sqlQuery, connection)
                ' Set parameters for the INSERT query
                command.Parameters.AddWithValue("@voter_name", txtname.Text)
                command.Parameters.AddWithValue("@voter_roll_no", txtRoll.Text)
                command.Parameters.AddWithValue("@voter_email", txtEmail.Text)
                command.Parameters.AddWithValue("@voter_password", txtPassword.Text)
                command.Parameters.AddWithValue("@voter_course", comboCourse.SelectedItem.ToString())
                command.Parameters.AddWithValue("@voter_year", comboYear.SelectedItem.ToString())
                command.Parameters.AddWithValue("@hostel", comboHostel.SelectedItem.ToString()) ' Retrieve selected hostel from comboHostel

                ' Execute the INSERT query and retrieve the last inserted voter_id
                Dim voterId As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Display a message with the newly inserted voter_id
                MessageBox.Show("Voter registered successfully ")

                ' After successful registration, redirect to the dashboard
                Dim dashboardForm As New voter_dashboard()
                dashboardForm.VoterId = voterId ' Pass the voter ID to the dashboard
                Me.Hide()
                dashboardForm.Show()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub comboCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboCourse.SelectedIndexChanged
        ' Clear existing items in comboYear
        comboYear.Items.Clear()

        ' Get the selected course
        Dim selectedCourse As String = comboCourse.SelectedItem.ToString()

        ' Depending on the selected course, populate comboYear with corresponding options
        Select Case selectedCourse
            Case "B.Tech"
                ' Add years 1 to 4
                comboYear.Items.AddRange({"1", "2", "3", "4"})
            Case "M.Tech"
                ' Add years 1 and 2
                comboYear.Items.AddRange({"1", "2"})
            Case Else
                ' Handle other cases if needed
        End Select
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.TextChanged
        ' Set the PasswordChar property to * to hide the password input
        txtPassword.PasswordChar = "*"
    End Sub

    'Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
    '   Me.Hide()

    ' Show the login form
    '  Dim loginForm As New login_page()
    '   loginForm.Show()
    '   End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
