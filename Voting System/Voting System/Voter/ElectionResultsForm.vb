Imports System.Data.Odbc

Public Class ElectionResultsForm
    ' Declare variables to store election details
    Private _electionId As Integer
    Private WithEvents btnClose As Button

    Private connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
    ' Constructor to initialize the form with election ID
    Public Sub New(ByVal electionId As Integer)
        InitializeComponent()

        ' Initialize the election ID
        _electionId = electionId

        ' Load election results based on the provided election ID
        ' sample testing
        LoadElectionResults(_electionId)
    End Sub

    Private Sub LoadElectionResults(ByVal electionId As Integer)
        Try
            Dim dt As New DataTable()
            Dim sql As String = "SELECT winner, votes_received, position_name FROM (" &
                               "SELECT c.candidate_name AS winner, " &
                               "COUNT(v.vote_id) AS votes_received, " &
                               "p.position_name, " &
                               "ROW_NUMBER() OVER(PARTITION BY p.position_name ORDER BY COUNT(v.vote_id) DESC) AS rank " &
                               "FROM candidates c " &
                               "INNER JOIN votes v ON c.candidate_id = v.candidate_id " &
                               "INNER JOIN positions p ON c.position_id = p.position_id " &
                               "WHERE c.election_id = ? " &
                               "GROUP BY c.candidate_name, p.position_name) AS ranked_candidates " &
                               "WHERE rank = 1;"
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@electionId", electionId)
                    Dim adapter As New OdbcDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using

            ' Clear existing columns
            dgvResults.Columns.Clear()

            ' Add columns to DataGridView
            dgvResults.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading election results: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the election results form
        Me.Close()
    End Sub

    Private Sub ElectionResultsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvResults_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvResults.CellContentClick

    End Sub
End Class
