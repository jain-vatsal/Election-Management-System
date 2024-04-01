Imports System.Data.Odbc
Public Class upcomingelections
    Private adminEmail As String
    Public Property emailId() As String
        Get
            Return adminEmail
        End Get
        Set(ByVal value As String)
            adminEmail = value
        End Set
    End Property
    Private Sub upcomingelections_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadUpcomingElections()
    End Sub

    Private Sub LoadUpcomingElections()
        Try
            Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
            Dim sql As String = "SELECT * FROM elections WHERE status = 'Upcoming';"
            Dim dt As New DataTable()

            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Using adapter As New OdbcDataAdapter(sql, connection)
                    adapter.Fill(dt)
                End Using
            End Using

            ' Clear existing columns
            dgvElections.Columns.Clear()

            ' Add columns to the DataGridView
            dgvElections.Columns.Add("electionId", "Election ID") ' Add the electionId column
            dgvElections.Columns.Add("electionType", "Election Type")
            dgvElections.Columns.Add("startButton", "Start")
            dgvElections.Columns.Add("viewCandidatesButton", "View Candidates")

            For Each row As DataRow In dt.Rows
                Dim electionId As Integer = Convert.ToInt32(row("election_id"))
                Dim electionType As String = row("election_type").ToString()

                ' Add data to the DataGridView
                dgvElections.Rows.Add(electionId, electionType, "Start", "View Candidates")
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading upcoming elections: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvElections_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvElections.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvElections.Columns("startButton").Index Then
            ' Handle Start button click
            Dim electionId As Integer = Convert.ToInt32(dgvElections.Rows(e.RowIndex).Cells("electionId").Value)

            ' Change the status of the election to 'Ongoing'
            Try
                Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
                Dim sql As String = "UPDATE elections SET status = 'Ongoing' WHERE election_id = ?;"

                Using connection As New OdbcConnection(connectionString)
                    connection.Open()
                    Using command As New OdbcCommand(sql, connection)
                        command.Parameters.AddWithValue("@electionId", electionId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Election started successfully!")
                ' Reload the upcoming elections list after updating the status
                LoadUpcomingElections()
            Catch ex As Exception
                MessageBox.Show("An error occurred while starting the election: " & ex.Message)
            End Try
        ElseIf e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvElections.Columns("viewCandidatesButton").Index Then
            ' Handle View Candidates button click
            Dim electionId As Integer = Convert.ToInt32(dgvElections.Rows(e.RowIndex).Cells("electionId").Value)
            ViewCandidates(electionId)
        End If
    End Sub

    Private Sub ViewCandidates(ByVal electionId As Integer)
        ' Redirect to viewCandidates form passing the election id
        Dim viewCandidatesForm As New viewCandidates() ' Assuming the viewCandidates class has a parameterless constructor
        viewCandidatesForm.ElectionId = electionId ' Assuming there's a property named ElectionId in viewCandidates class
        viewCandidatesForm.emailId = adminEmail
        Me.Hide()

        viewCandidatesForm.Show()
    End Sub



    Private Sub StartButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim electionId As Integer = Convert.ToInt32(button.Tag)

        ' Change the status of the election to 'Ongoing'
        Try
            Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
            Dim sql As String = "UPDATE elections SET status = 'Ongoing' WHERE election_id = ?;"

            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Using command As New OdbcCommand(sql, connection)
                    command.Parameters.AddWithValue("@electionId", electionId)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Election started successfully!")
            ' Reload the upcoming elections list after updating the status
            LoadUpcomingElections()
        Catch ex As Exception
            MessageBox.Show("An error occurred while starting the election: " & ex.Message)
        End Try
    End Sub

    Private Sub ViewCandidatesButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim electionId As Integer = Convert.ToInt32(button.Tag)

        ' Redirect to viewCandidates form passing the election id
        Dim viewCandidatesForm As New viewCandidates() ' Assuming the viewCandidates class has a parameterless constructor
        viewCandidatesForm.ElectionId = electionId
        viewCandidatesForm.emailId = adminEmail ' Assuming there's a property named ElectionId in viewCandidates class
        Me.Hide()

        viewCandidatesForm.Show()
    End Sub




    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Hide()

        Dim adminMainForm As New admin_main()
        adminMainForm.emailId = adminEmail
        adminMainForm.Show() ' Show the admin_main form
    End Sub
End Class