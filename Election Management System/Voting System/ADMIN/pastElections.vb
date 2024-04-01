Imports System.Data.Odbc

Public Class pastElections
    Private adminEmail As String
    Public Property emailId() As String
        Get
            Return adminEmail
        End Get
        Set(ByVal value As String)
            adminEmail = value
        End Set
    End Property

    Private Sub pastElections_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEndedElections()
    End Sub

    Private Sub LoadEndedElections()
        Try
            Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
            Dim sql As String = "SELECT election_id, election_name FROM elections WHERE status = 'Ended';"
            Dim dt As New DataTable()

            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Using adapter As New OdbcDataAdapter(sql, connection)
                    adapter.Fill(dt)
                End Using
            End Using

            ' Clear existing columns
            dgvPastElections.Columns.Clear()
            ' Set the datasource
            dgvPastElections.DataSource = dt
            ' Add a button column for viewing results
            Dim btnColumn As New DataGridViewButtonColumn()
            btnColumn.HeaderText = "View Results"
            btnColumn.Text = "View Results"
            btnColumn.Name = "btnViewResults"
            btnColumn.UseColumnTextForButtonValue = True
            dgvPastElections.Columns.Add(btnColumn)

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading past elections: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvPastElections_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPastElections.CellContentClick
        ' Check if the clicked cell is in the "View Results" column
        If e.ColumnIndex = dgvPastElections.Columns("btnViewResults").Index AndAlso e.RowIndex >= 0 Then
            Dim electionId As Integer = Convert.ToInt32(dgvPastElections.Rows(e.RowIndex).Cells("election_id").Value)
            ' Redirect to ElectionResultsForm passing the election id
            Dim electionResultsForm As New ElectionResultsForm(electionId)
            electionResultsForm.Show()
        End If
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Hide()
        Dim adminMainForm As New admin_main()
        adminMainForm.emailId = adminEmail
        adminMainForm.Show() ' Show the admin_main form
    End Sub
End Class
