Imports System.Data.Odbc

Public Class viewCandidates
    Private _electionId As Integer
    Private adminEmail As String
    Public Property emailId() As String
        Get
            Return adminEmail
        End Get
        Set(ByVal value As String)
            adminEmail = value
        End Set
    End Property
    ' Property to store the Election ID
    Public Property ElectionId() As Integer
        Get
            Return _electionId
        End Get
        Set(ByVal value As Integer)
            _electionId = value
        End Set
    End Property

    Private Sub viewCandidates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
            Dim sql As String = "SELECT c.candidate_name, c.candidate_email, p.position_name " &
                    "FROM candidates c " &
                    "INNER JOIN positions p ON c.position_id = p.position_id " &
                    "WHERE c.election_id = ? GROUP BY p.position_id, c.candidate_name, c.candidate_email, p.position_name;"


            Dim dt As New DataTable()

            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Using adapter As New OdbcDataAdapter(sql, connection)
                    adapter.SelectCommand.Parameters.AddWithValue("@electionId", ElectionId)
                    adapter.Fill(dt)
                End Using
            End Using

            ' Display candidates and their positions in some way (e.g., in a DataGridView)
            ' For demonstration purposes, let's assume you have a DataGridView named dgvCandidates
            dgvCandidates.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading candidates: " & ex.Message)
        End Try
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        ' Close the current form (viewCandidates) and open the upcomingElections form
        Dim upcomingForm As New upcomingelections()
        upcomingForm.emailId = adminEmail
        upcomingForm.Show()

        Me.Close()

    End Sub

    Private Sub dgvCandidates_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCandidates.CellContentClick

    End Sub
End Class