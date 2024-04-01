Imports System.Data.Odbc

Public Class currentelection

    Private connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
    Private _electionId As Integer
    Private _voterId As Integer
    Private _votes As New Dictionary(Of Integer, Integer)() ' Dictionary to store position ID and selected candidate ID

    Public Sub New(ByVal electionId As Integer, ByVal voterId As Integer)
        InitializeComponent()
        _electionId = electionId
        _voterId = voterId
        LoadPositions()
        CheckVotes()
    End Sub

    Private Sub currentelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim electionName As String = GetElectionName(_electionId)
        lblElectionName.Text = "Election: " & electionName
    End Sub

    Private Sub LoadPositions()
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT position_id, position_name FROM positions WHERE election_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@electionId", _electionId)
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim positionId As Integer = Convert.ToInt32(reader("position_id"))
                            Dim positionName As String = reader("position_name").ToString()
                            ListBoxPositions.Items.Add(New PositionItem(positionId, positionName))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving positions: " & ex.Message)
        End Try
    End Sub

    Private Sub ListBoxPositions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBoxPositions.SelectedIndexChanged
        ' Clear existing candidates
        FlowLayoutPanelCandidates.Controls.Clear()

        ' Populate candidates for the selected position
        If ListBoxPositions.SelectedItem IsNot Nothing Then
            Dim positionId As Integer = DirectCast(ListBoxPositions.SelectedItem, PositionItem).Id
            PopulateCandidates(positionId)

            ' Restore previously selected candidate for this position, if any
            If _votes.ContainsKey(positionId) Then
                Dim candidateId As Integer = _votes(positionId)
                For Each control As Control In FlowLayoutPanelCandidates.Controls
                    If TypeOf control Is RadioButton Then
                        Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                        If CInt(radioButton.Tag) = candidateId Then
                            radioButton.Checked = True
                            Exit For
                        End If
                    End If
                Next
            End If
        End If

        ' Check if all positions have been voted for
        CheckVotes()
    End Sub

    Private Sub PopulateCandidates(ByVal positionId As Integer)
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT candidate_id, candidate_name FROM candidates WHERE position_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@positionId", positionId)
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim candidateId As Integer = Convert.ToInt32(reader("candidate_id"))
                            Dim candidateName As String = reader("candidate_name").ToString()

                            Dim radioButton As New RadioButton()
                            radioButton.Text = candidateName
                            radioButton.Tag = candidateId
                            AddHandler radioButton.CheckedChanged, AddressOf RadioButton_CheckedChanged

                            FlowLayoutPanelCandidates.Controls.Add(radioButton)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving candidates: " & ex.Message)
        End Try
    End Sub

    Private Sub RadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        Dim candidateId As Integer = CInt(radioButton.Tag)
        Dim positionId As Integer = DirectCast(ListBoxPositions.SelectedItem, PositionItem).Id

        If radioButton.Checked Then
            _votes(positionId) = candidateId
        End If

        ' Check if all positions have been voted for
        CheckVotes()
    End Sub

    Private Function GetElectionName(ByVal electionId As Integer) As String
        Dim electionName As String = ""
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT election_name FROM elections WHERE election_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@electionId", electionId)
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            electionName = reader("election_name").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the election name: " & ex.Message)
        End Try
        Return electionName
    End Function

    Private Sub btnConfirmVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmVote.Click
        If Not HasVoted(_voterId, _electionId) Then
            ConfirmVotesAndSave()
            Me.Hide()
            Dim ballotForm As New ballots(_electionId, _voterId)
            ballotForm.Show()
        Else
            MessageBox.Show("You have already voted for this election.")
            Dim ballotForm As New ballots(_electionId, _voterId)
            ballotForm.Show()
        End If
    End Sub

    Private Sub ConfirmVotesAndSave()
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()

                ' Iterate through the votes dictionary and save the votes to the database
                For Each kvp As KeyValuePair(Of Integer, Integer) In _votes
                    Dim positionId As Integer = kvp.Key
                    Dim candidateId As Integer = kvp.Value

                    ' Insert the vote into the votes table
                    Dim sql As String = "INSERT INTO votes (voter_id, candidate_id, position_id, election_id) VALUES (?, ?, ?, ?);"
                    Using command As New OdbcCommand(sql, connection)
                        ' Assuming you have the voter_id available, replace 1 with the actual voter_id
                        command.Parameters.AddWithValue("@voterId", _voterId)
                        command.Parameters.AddWithValue("@candidateId", candidateId)
                        command.Parameters.AddWithValue("@positionId", positionId)
                        command.Parameters.AddWithValue("@electionId", _electionId)
                        command.ExecuteNonQuery()
                    End Using
                Next

                ' After saving the votes, clear the votes dictionary for the next election or session
                _votes.Clear()

                MessageBox.Show("Votes saved successfully!" & Environment.NewLine & "Redirecting to ballot page....")

            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving votes: " & ex.Message)
        End Try
    End Sub

    Private Function HasVoted(ByVal voterId As Integer, ByVal electionId As Integer) As Boolean
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

    Private Sub CheckVotes()
        ' Check if all positions have been voted for
        Dim allPositionsVoted As Boolean = True
        For Each positionItem As PositionItem In ListBoxPositions.Items
            If Not _votes.ContainsKey(positionItem.Id) Then
                allPositionsVoted = False
                Exit For
            End If
        Next

        ' Show or hide the confirm vote button accordingly
        btnConfirmVote.Visible = allPositionsVoted
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

End Class

Public Class PositionItem
    Public Property Id As Integer
    Public Property Name As String

    Public Sub New(ByVal id As Integer, ByVal name As String)
        Me.Id = id
        Me.Name = name
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class