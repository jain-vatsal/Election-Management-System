Imports System.Data.Odbc
Imports System.Windows.Forms

Public Class admin_main

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchAndDisplayAdminDetails()
    End Sub
    Private adminEmail As String

    Public Property emailId() As String
        Get
            Return adminEmail
        End Get
        Set(ByVal value As String)
            adminEmail = value
        End Set
    End Property
    Private connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
    Private Sub FetchAndDisplayAdminDetails()
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()

                ' Define the SQL query to select admin details
                Dim sqlQuery As String = "SELECT admin_name, admin_email FROM adminTable WHERE admin_email = ?"

                ' Create a command to execute the SQL query
                Using command As New OdbcCommand(sqlQuery, connection)
                    ' Bind the email parameter
                    command.Parameters.AddWithValue("@admin_email", adminEmail)

                    ' Execute the query and retrieve data
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        ' Check if any rows were returned
                        If reader.HasRows Then
                            ' Read the first row
                            reader.Read()

                            ' Display admin details
                            Dim adminName As String = reader("admin_name").ToString()
                            Dim adminEmail As String = reader("admin_email").ToString()

                            ' Create labels to display admin details
                            Dim nameLabel As New Label()
                            With nameLabel
                                .Text = "Admin Name: " & adminName
                                .Location = New Point(20, 200) ' Adjust the location as needed
                                .Font = New Font("Arial", 14, FontStyle.Bold) ' Increase font size and make it bold
                                .ForeColor = Color.Black ' Change font color
                                .AutoSize = True ' Automatically adjust the size
                            End With
                            MainPanel.Controls.Add(nameLabel)

                            Dim emailLabel As New Label()
                            With emailLabel
                                .Text = "Admin Email: " & adminEmail
                                .Location = New Point(20, nameLabel.Top + 60) ' Position it next to the name label
                                .Font = New Font("Arial", 14, FontStyle.Bold) ' Increase font size and make it bold
                                .ForeColor = Color.Black ' Change font color
                                .AutoSize = True ' Automatically adjust the size
                            End With
                            MainPanel.Controls.Add(emailLabel)

                        Else
                            MessageBox.Show("Admin details not found.", "Error")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching admin details: " & ex.Message)
        End Try
    End Sub
    ' Event handler for the "Start Election" button
    Private Sub btn_strt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_strt.Click
        ' Create an instance of the addElection form
        Dim addElectionForm As New addElection()
        Me.Hide()
        addElectionForm.emailId = adminEmail
        ' Display the addElection form
        addElectionForm.Show()
    End Sub

    ' Event handler for the logout button
    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        ' Display a confirmation message
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check if the user confirms the logout
        If result = DialogResult.Yes Then
            ' Hide the current form
            Me.Close()

            ' Show the login form
            Dim loginForm As New login_page()
            loginForm.Show()
        End If
    End Sub

    ' Event handler for the "View Voters" button
    Private Sub btn_voters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_voters.Click
        Try
            ' Clear any existing controls in the MainPanel
            MainPanel.Controls.Clear()

            ' Create a new connection
            Using connection As New OdbcConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Define the SQL query to select all voters
                Dim sqlQuery As String = "SELECT voter_id, voter_name, voter_roll_no, voter_email, voter_course, voter_year, hostel FROM voters"

                ' Create a command to execute the SQL query
                Using command As New OdbcCommand(sqlQuery, connection)
                    ' Execute the query and retrieve data
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        ' Initialize Y-coordinate for panel positioning
                        Dim panelY As Integer = 60

                        Dim titleLabel As New Label()
                        titleLabel.Text = "Voters"
                        titleLabel.Font = New Font(titleLabel.Font.FontFamily, 16, FontStyle.Bold) ' Make the title bold
                        titleLabel.Location = New Point(230, 20) ' Adjust the location of the title label
                        MainPanel.Controls.Add(titleLabel)

                        ' Loop through the rows in the result set
                        While reader.Read()
                            ' Create labels to display voter information
                            Dim voterId As Integer = Convert.ToInt32(reader("voter_id"))
                            Dim voterName As String = reader("voter_name").ToString()
                            Dim voterRollNo As String = reader("voter_roll_no").ToString()
                            Dim voterEmail As String = reader("voter_email").ToString()
                            Dim voterCourse As String = reader("voter_course").ToString()
                            Dim voterYear As String = reader("voter_year").ToString()
                            Dim hostel As String = reader("hostel").ToString()

                            ' Create a panel to hold voter information
                            Dim panel As New Panel()
                            panel.BackColor = Color.Lavender
                            panel.BorderStyle = BorderStyle.FixedSingle
                            panel.Width = 500
                            panel.Height = 100
                            panel.Location = New Point(30, panelY) ' Set panel position

                            ' Create labels for voter information
                            Dim nameLabel As New Label()
                            nameLabel.Text = "Name: " & voterName
                            nameLabel.Location = New Point(10, 10)

                            Dim rollNoLabel As New Label()
                            rollNoLabel.Text = "Roll No: " & voterRollNo
                            rollNoLabel.Location = New Point(10, 40)

                            Dim emailLabel As New Label()
                            emailLabel.Text = "Email: " & voterEmail
                            emailLabel.Location = New Point(10, 70)

                            Dim courseLabel As New Label()
                            courseLabel.Text = "Course: " & voterCourse
                            courseLabel.Location = New Point(250, 10)

                            Dim yearLabel As New Label()
                            yearLabel.Text = "Year: " & voterYear
                            yearLabel.Location = New Point(250, 40)

                            Dim hostelLabel As New Label()
                            hostelLabel.Text = "Hostel: " & hostel
                            hostelLabel.Location = New Point(250, 70)


                            ' Add controls to the panel
                            panel.Controls.Add(nameLabel)
                            panel.Controls.Add(rollNoLabel)
                            panel.Controls.Add(emailLabel)
                            panel.Controls.Add(courseLabel)
                            panel.Controls.Add(yearLabel)
                            panel.Controls.Add(hostelLabel)

                            ' Add the panel to the MainPanel
                            MainPanel.Controls.Add(panel)
                            MainPanel.AutoScroll = True

                            ' Increment Y-coordinate for the next panel
                            panelY += panel.Height + 10
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching voters: " & ex.Message)
        End Try
    End Sub

    ' Event handler for the delete button
    Private Sub DeleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim voterId As Integer = Convert.ToInt32(button.Tag)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this voter?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Create a new connection
                Using connection As New OdbcConnection(connectionString)
                    ' Open the connection
                    connection.Open()

                    ' Check if the voter exists in the candidate table
                    Dim candidateExistsQuery As String = "SELECT COUNT(*) FROM candidates WHERE voter_id = ?"
                    Using candidateExistsCommand As New OdbcCommand(candidateExistsQuery, connection)
                        candidateExistsCommand.Parameters.AddWithValue("@voterId", voterId)
                        Dim candidateCount As Integer = Convert.ToInt32(candidateExistsCommand.ExecuteScalar())

                        ' If the voter exists in the candidate table, delete from candidate table first
                        If candidateCount > 0 Then
                            Dim deleteCandidateQuery As String = "DELETE FROM candidates WHERE voter_id = ?"
                            Using deleteCandidateCommand As New OdbcCommand(deleteCandidateQuery, connection)
                                deleteCandidateCommand.Parameters.AddWithValue("@voterId", voterId)
                                deleteCandidateCommand.ExecuteNonQuery()
                            End Using
                        End If

                        ' Now delete the voter from the voters table
                        Dim deleteVoterQuery As String = "DELETE FROM voters WHERE voter_id = ?"
                        Using deleteVoterCommand As New OdbcCommand(deleteVoterQuery, connection)
                            deleteVoterCommand.Parameters.AddWithValue("@voterId", voterId)
                            Dim rowsAffected As Integer = deleteVoterCommand.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Voter deleted successfully.")
                                ' Refresh the list of voters
                                btn_voters_Click(Nothing, Nothing)
                            Else
                                MessageBox.Show("Failed to delete voter.")
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting voter: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub MainPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainPanel.Paint
        ' Call the btn_voters_Click method to populate the voters list when the panel is painted
        'btn_voters_Click(Nothing, Nothing)
        'MainPanel.AutoScroll = True
    End Sub

   Private Sub btn_candidates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_candidates.Click
        Try
            ' Clear any existing controls in the MainPanel
            MainPanel.Controls.Clear()

            ' Create a new connection
            Using connection As New OdbcConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Define the SQL query to select all candidates
                Dim sqlQuery As String = "SELECT * FROM candidates"

                ' Create a command to execute the SQL query
                Using command As New OdbcCommand(sqlQuery, connection)
                    ' Execute the query and retrieve data
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        ' Initialize Y-coordinate for panel positioning
                        Dim panelY As Integer = 60

                        Dim titleLabel As New Label()
                        titleLabel.Text = "Candidates"
                        titleLabel.Font = New Font(titleLabel.Font.FontFamily, 14, FontStyle.Bold) ' Make the title bold
                        titleLabel.Location = New Point(200, 20) ' Adjust the location of the title label
                        MainPanel.Controls.Add(titleLabel)

                        ' Loop through the rows in the result set
                        While reader.Read()
                            ' Create labels to display candidate information
                            Dim candidateId As Integer = Convert.ToInt32(reader("candidate_id"))
                            Dim candidateName As String = reader("candidate_name").ToString()
                            Dim candidateRollNo As String = reader("candidate_roll_no").ToString()
                            Dim candidateEmail As String = reader("candidate_email").ToString()
                            Dim candidateCourse As String = reader("candidate_course").ToString()
                            Dim candidateYear As String = reader("candidate_year").ToString()
                            Dim hostel As String = reader("hostel").ToString()

                            ' Create a panel to hold candidate information
                            Dim panel As New Panel()
                            panel.BorderStyle = BorderStyle.FixedSingle
                            panel.Width = 500
                            panel.Height = 100
                            panel.Location = New Point(30, panelY) ' Set panel position

                            ' Create labels for candidate information
                            Dim nameLabel As New Label()
                            nameLabel.Text = "Name: " & candidateName
                            nameLabel.Location = New Point(10, 10)

                            Dim rollNoLabel As New Label()
                            rollNoLabel.Text = "Roll No: " & candidateRollNo
                            rollNoLabel.Location = New Point(10, 40)

                            Dim emailLabel As New Label()
                            emailLabel.Text = "Email: " & candidateEmail
                            emailLabel.Location = New Point(10, 70)

                            Dim courseLabel As New Label()
                            courseLabel.Text = "Course: " & candidateCourse
                            courseLabel.Location = New Point(250, 10)

                            Dim yearLabel As New Label()
                            yearLabel.Text = "Year: " & candidateYear
                            yearLabel.Location = New Point(250, 40)

                            Dim hostelLabel As New Label()
                            hostelLabel.Text = "Hostel: " & hostel
                            hostelLabel.Location = New Point(250, 70)

                            ' Add controls to the panel
                            panel.Controls.Add(nameLabel)
                            panel.Controls.Add(rollNoLabel)
                            panel.Controls.Add(emailLabel)
                            panel.Controls.Add(courseLabel)
                            panel.Controls.Add(yearLabel)
                            panel.Controls.Add(hostelLabel)

                            ' Add the panel to the MainPanel
                            MainPanel.Controls.Add(panel)

                            ' Increment Y-coordinate for the next panel
                            panelY += panel.Height + 10
                        End While
                    End Using
                End Using
            End Using
            'MainPanel.AutoScroll = True
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching candidates: " & ex.Message)
        End Try
    End Sub


    ' Event handler for the delete candidate button
    Private Sub DeleteCandidateButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim candidateId As Integer = Convert.ToInt32(button.Tag)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this candidate?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Create a new connection
                Using connection As New OdbcConnection(connectionString)
                    ' Open the connection
                    connection.Open()

                    ' Delete related records in the votes table first
                    Dim deleteVotesQuery As String = "DELETE FROM votes WHERE candidate_id = ?"
                    Using deleteVotesCommand As New OdbcCommand(deleteVotesQuery, connection)
                        deleteVotesCommand.Parameters.AddWithValue("@candidateId", candidateId)
                        deleteVotesCommand.ExecuteNonQuery()
                    End Using

                    ' Now delete the candidate from the candidates table
                    Dim deleteCandidateQuery As String = "DELETE FROM candidates WHERE candidate_id = ?"
                    Using deleteCandidateCommand As New OdbcCommand(deleteCandidateQuery, connection)
                        deleteCandidateCommand.Parameters.AddWithValue("@candidateId", candidateId)

                        ' Execute the query
                        Dim rowsAffected As Integer = deleteCandidateCommand.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Candidate deleted successfully.")
                            ' Refresh the list of candidates
                            btn_candidates_Click(Nothing, Nothing)
                        Else
                            MessageBox.Show("Failed to delete candidate.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting candidate: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub btn_addAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addAdmin.Click
        ' Create a new instance of Form
        'Dim addAdminForm As New Form()
        Dim addAdminForm As New adminadder()

        Me.Hide()
        addAdminForm.emailId = adminEmail
        addAdminForm.Show()
    End Sub

    Private Sub btn_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' Create a new connection
            Using connection As New OdbcConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Define the SQL query to select admin details based on email
                Dim sqlQuery As String = "SELECT admin_name, admin_email FROM adminTable WHERE admin_email = ?"

                ' Create a command to execute the SQL query
                Using command As New OdbcCommand(sqlQuery, connection)
                    ' Bind the email parameter
                    command.Parameters.AddWithValue("@admin_email", adminEmail)

                    ' Execute the query and retrieve data
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        ' Check if any rows were returned
                        If reader.HasRows Then
                            ' Read the first row
                            reader.Read()

                            ' Display admin details
                            Dim adminName As String = reader("admin_name").ToString()
                            Dim adminEmail As String = reader("admin_email").ToString()
                            MessageBox.Show("Admin Name: " & adminName & vbCrLf &
                                            "Admin Email: " & adminEmail, "Admin Profile")
                        Else
                            MessageBox.Show("Admin details not found.", "Error")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching admin details: " & ex.Message)
        End Try
    End Sub


    Private Sub btn_end_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_end.Click
        Try
            ' Fetch all ongoing elections
            Dim sqlQuery As String = "SELECT * FROM elections WHERE status = 'Ongoing'"

            ' Create a new form to display the ongoing elections
            Dim ongoingElectionsForm As New Form()
            ongoingElectionsForm.Text = "Ongoing Elections"
            ongoingElectionsForm.StartPosition = FormStartPosition.CenterScreen

            ' Create a panel to hold the list of ongoing elections
            Dim panel As New FlowLayoutPanel()
            panel.FlowDirection = FlowDirection.TopDown
            panel.Dock = DockStyle.Fill

            Using connection As New OdbcConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a command to execute the SQL query
                Using command As New OdbcCommand(sqlQuery, connection)
                    ' Execute the query and retrieve data
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        ' Check if any ongoing elections were found
                        If reader.HasRows Then
                            ' Loop through the ongoing elections
                            While reader.Read()
                                ' Get election details
                                Dim electionId As Integer = Convert.ToInt32(reader("election_id"))
                                Dim electionName As String = reader("election_name").ToString()

                                ' Create a label to display the election name
                                Dim electionLabel As New Label()
                                electionLabel.Text = electionName

                                ' Create a button to end the election
                                Dim endElectionButton As New Button()
                                endElectionButton.Text = "End Election"
                                endElectionButton.Tag = electionId ' Set the Tag property to store the election ID
                                AddHandler endElectionButton.Click, AddressOf EndElectionButton_Click ' Add event handler

                                ' Add controls to the panel
                                panel.Controls.Add(electionLabel)
                                panel.Controls.Add(endElectionButton)
                            End While

                            ' Add the panel to the form
                            ongoingElectionsForm.Controls.Add(panel)

                            ' Display the form
                            ongoingElectionsForm.ShowDialog()
                        Else
                            MessageBox.Show("No ongoing elections found.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching ongoing elections: " & ex.Message)
        End Try
    End Sub

    Private Sub EndElectionButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim electionId As Integer = Convert.ToInt32(button.Tag)

        ' Prompt the user to confirm ending the election
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to end this election?", "Confirm End Election", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Create a new connection
                Using connection As New OdbcConnection(connectionString)
                    ' Open the connection
                    connection.Open()

                    ' Update the status of the selected election to "Ended" in the database
                    Dim sqlQuery As String = "UPDATE elections SET status = 'Ended' WHERE election_id = ?"

                    ' Create a command to execute the SQL query
                    Using command As New OdbcCommand(sqlQuery, connection)
                        ' Bind the election ID parameter
                        command.Parameters.AddWithValue("@electionId", electionId)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Election ended successfully.")
                            ' Remove the ended election from the form
                            Dim buttonParent As Control = button.Parent
                            buttonParent.Controls.Remove(button)
                        Else
                            MessageBox.Show("Failed to end the election.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while ending the election: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub side_panel_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles side_panel.Paint

    End Sub


    Private Sub startElection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startElection.Click
        Me.Hide()
        Dim upcomingElectionsForm As New upcomingelections()
        upcomingElectionsForm.emailId = adminEmail
        upcomingElectionsForm.Show()
    End Sub


    Private Sub StartElectionButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim electionId As Integer = Convert.ToInt32(button.Tag)

        ' Prompt the user to confirm starting the election
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to start this election?", "Confirm Start Election", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Create a new connection
                Using connection As New OdbcConnection(connectionString)
                    ' Open the connection
                    connection.Open()

                    ' Update the status of the selected election to "Ongoing" in the database
                    Dim sqlQuery As String = "UPDATE elections SET status = 'Ongoing' WHERE election_id = ?"

                    ' Create a command to execute the SQL query
                    Using command As New OdbcCommand(sqlQuery, connection)
                        ' Bind the election ID parameter
                        command.Parameters.AddWithValue("@electionId", electionId)

                        ' Execute the query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Election started successfully.")
                            ' Remove the started election from the form
                            Dim buttonParent As Control = button.Parent
                            buttonParent.Controls.Remove(button)
                        Else
                            MessageBox.Show("Failed to start the election.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while starting the election: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub admin_main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPastElections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastElections.Click
        ' Instantiate the pastElections form
        Dim pastElectionsForm As New pastElections()
        Me.Hide()
        pastElectionsForm.emailId = adminEmail
        ' Show the pastElections form
        pastElectionsForm.Show()



    End Sub

End Class
