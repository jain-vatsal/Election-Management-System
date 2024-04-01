Imports System.Data.Odbc

Public Class voter_dashboard
    Private connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
    Private selectedElectionId As Integer
    Private userHostel As String
    Dim year As String
    Public Property VoterId() As Integer

    Private Sub FetchVoterDetails(ByVal voterId As Integer)
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM voters WHERE voter_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@voterId", voterId)
                    Dim reader As OdbcDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        btnCandidateReg.Visible = False
                        btnVote.Visible = True
                        LabelName.Text = "Name: " & reader("voter_name").ToString()
                        LabelEmail.Text = "Email: " & reader("voter_email").ToString()
                        LabelRollNumber.Text = "Roll No: " & reader("voter_roll_no").ToString()
                        LabelCourse.Text = "Course: " & reader("voter_course").ToString()
                        LabelHostel.Text = "Hostel : " & reader("hostel").ToString()
                        userHostel = reader("hostel").ToString()
                        year = reader("voter_year").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching voter details: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadElections(ByVal status As String)
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM elections WHERE status = ? AND (election_type = ? OR election_type = 'General');"
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Using adapter As New OdbcDataAdapter(sql, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@status", status)
                    adapter.SelectCommand.Parameters.AddWithValue("@electionType", userHostel)
                    adapter.Fill(dt)
                End Using
            End Using
            dgvElections.Columns.Clear()
            dgvElections.DataSource = dt

            ' Only add the "View Results" button column if the status is "Ended"
            If status = "Ended" Then
                Dim resultsButtonColumn As New DataGridViewButtonColumn()
                resultsButtonColumn.HeaderText = "Results"
                resultsButtonColumn.Name = "ResultsButtonColumn"
                resultsButtonColumn.Text = "View Results"
                resultsButtonColumn.UseColumnTextForButtonValue = True
                dgvElections.Columns.Add(resultsButtonColumn)
            End If

            ' Hide the "Register as Candidate" button for btnEnded and btnOngoing
            If status = "Ended" OrElse status = "Ongoing" Then
                btnCandidateReg.Visible = False
            End If

            ' Update the election type label
            LabelElectionType.Text = "Election Type: " & status

            ' Show the "Vote Here" button only if there are ongoing elections
            If status = "Ongoing" AndAlso dt.Rows.Count > 0 Then
                btnVote.Visible = True
            Else
                btnVote.Visible = False
            End If

            If status = "Upcoming" AndAlso dt.Rows.Count > 0 AndAlso year = "4" Then
                btnCandidateReg.Visible = True
            Else
                btnCandidateReg.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading elections: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvElections_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvElections.CellContentClick
        If e.RowIndex >= 0 Then
            selectedElectionId = Convert.ToInt32(dgvElections.Rows(e.RowIndex).Cells("election_id").Value)
            If dgvElections.Columns(e.ColumnIndex) Is dgvElections.Columns("ResultsButtonColumn") Then
                If ElectionHasEnded(selectedElectionId) Then
                    Dim electionResultsForm As New ElectionResultsForm(selectedElectionId)
                    electionResultsForm.ShowDialog()
                Else
                    MessageBox.Show("This election has not ended yet.")
                End If
            End If
        End If
    End Sub

    Private Function ElectionHasEnded(ByVal electionId As Integer) As Boolean
        Dim hasEnded As Boolean = False
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT status FROM elections WHERE election_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@electionId", electionId)
                    Dim status As String = Convert.ToString(command.ExecuteScalar())
                    If status = "Ended" Then
                        hasEnded = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking the status of the election: " & ex.Message)
        End Try
        Return hasEnded
    End Function

    Private Sub voter_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchVoterDetails(VoterId)
        LoadElections("Ongoing")
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New login_page()
            loginForm.Show()
        End If
    End Sub

    Private Function IsUserRegisteredAsCandidate(ByVal electionId As Integer, ByVal voterId As Integer) As Boolean
        Dim registered As Boolean = False
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT COUNT(*) FROM candidates WHERE election_id = ? AND voter_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@electionId", electionId)
                    command.Parameters.AddWithValue("@voterId", voterId)
                    Dim candidateCount As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If candidateCount > 0 Then
                        registered = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking if the user is registered as a candidate: " & ex.Message)
        End Try
        Return registered
    End Function

    Private Sub btnCandidateReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandidateReg.Click
        If selectedElectionId > 0 And VoterId > 0 Then
            If Not IsUserRegisteredAsCandidate(selectedElectionId, VoterId) Then
                Dim candidateRegistrationForm As New candReg(selectedElectionId, VoterId)
                Me.Hide()
                candidateRegistrationForm.Show()
            Else
                MessageBox.Show("You have already registered as a candidate for this election.")
            End If
        Else
            MessageBox.Show("Please select an election.")
        End If
    End Sub

    Private Sub btnOngoing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOngoing.Click
        btnCandidateReg.Visible = False
        btnVote.Visible = True
        LoadElections("Ongoing")
    End Sub

    Private Sub btnUpcoming_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpcoming.Click
        btnVote.Visible = False
        If year = "4" Then
            btnCandidateReg.Visible = True
        Else
            btnCandidateReg.Visible = False
        End If
        LoadElections("Upcoming")
    End Sub

    Private Sub btnEnded_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnded.Click
        btnVote.Visible = False
        btnCandidateReg.Visible = False
        LoadElections("Ended")
    End Sub

    Private Sub btnVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVote.Click
        If selectedElectionId > 0 Then
            If Not HasVotedForElection(VoterId, selectedElectionId) Then
                Me.Hide()
                Dim currentElectionForm As New currentelection(selectedElectionId, VoterId)
                currentElectionForm.Show()
            Else
                MessageBox.Show("You have already voted for this election.")
            End If
        Else
            MessageBox.Show("Please select an election.")
        End If
    End Sub

    Private Function HasVotedForElection(ByVal voterId As Integer, ByVal electionId As Integer) As Boolean
        Dim voted As Boolean = False
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT COUNT(*) FROM votes WHERE voter_id = ? AND election_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@voterId", voterId)
                    command.Parameters.AddWithValue("@electionId", electionId)
                    Dim voteCount As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If voteCount > 0 Then
                        voted = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking if the user has voted: " & ex.Message)
        End Try
        Return voted
    End Function

   
End Class
