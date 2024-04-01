Imports System.Data.Odbc

Public Class ballots
    Private _electionId As Integer
    Private _voterId As Integer
    Private connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"

    Public Sub New(ByVal electionId As Integer, ByVal voterId As Integer)
        InitializeComponent()
        _electionId = electionId
        _voterId = voterId

        ' Populate the election name and voter name labels
        electionName.Text = GetElectionName(_electionId)
        voterName.Text = GetVoterName(_voterId)

        ' Populate the DataGridView with the positions and candidates voted for by the voter
        LoadBallotsData()
    End Sub

    Private Sub LoadBallotsData()
        Try
            Dim dt As New DataTable()
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT p.position_name, c.candidate_name " &
                                    "FROM votes v " &
                                    "INNER JOIN positions p ON v.position_id = p.position_id " &
                                    "INNER JOIN candidates c ON v.candidate_id = c.candidate_id " &
                                    "WHERE v.election_id = ? AND v.voter_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@electionId", _electionId)
                    command.Parameters.AddWithValue("@voterId", _voterId)
                    Using reader As OdbcDataReader = command.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using

            dgvBallot.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading ballot data: " & ex.Message)
        End Try
    End Sub

    Private Function GetElectionName(ByVal electionId As Integer) As String
        Dim electionName As String = ""
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT election_name FROM elections WHERE election_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@electionId", electionId)
                    electionName = Convert.ToString(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the election name: " & ex.Message)
        End Try
        Return electionName
    End Function

    Private Function GetVoterName(ByVal voterId As Integer) As String
        Dim voterName As String = ""
        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT voter_name FROM voters WHERE voter_id = ?;"
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@voterId", voterId)
                    voterName = Convert.ToString(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the voter name: " & ex.Message)
        End Try
        Return voterName
    End Function

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Hide()
        Dim voterDashBoardForm As New voter_dashboard()
        voterDashBoardForm.VoterId = _voterId
        voterDashBoardForm.Show()
    End Sub
End Class