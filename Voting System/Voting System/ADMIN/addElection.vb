Imports System.Data.Odbc

Public Class addElection
    Private adminEmail As String
    Public Property emailId() As String
        Get
            Return adminEmail
        End Get
        Set(ByVal value As String)
            adminEmail = value
        End Set
    End Property

    Private positionsList As New List(Of String)

    Private Sub btnAddPosition_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddPosition.Click
        ' Add the position name entered by the user to the list
        Dim positionName As String = txtPositionName.Text.Trim()
        If Not String.IsNullOrEmpty(positionName) Then
            positionsList.Add(positionName)
            ' Clear the TextBox after adding the position
            txtPositionName.Clear()
            ' Refresh the DataGridView to display the updated list of positions
            RefreshDataGridView()
        Else
            MessageBox.Show("Please enter a position name.")
        End If
    End Sub

    Private Sub RefreshDataGridView()
        ' Clear the existing rows in the DataGridView
        DataGridViewPositions.Rows.Clear()
        ' Add each position from the list to the DataGridView
        For Each position As String In positionsList
            DataGridViewPositions.Rows.Add(position)
        Next
    End Sub

    Private Sub ButtonAddElection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAddElection.Click
        ' Check if there are positions in the list
        If positionsList.Count > 0 Then
            ' Add the election to the database
            Try
                Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
                Using connection As New OdbcConnection(connectionString)
                    connection.Open()
                    ' Add the election
                    Dim addElectionCommand As New OdbcCommand("INSERT INTO elections (election_name, start_datetime, end_datetime, election_type) VALUES (?, ?, ?, ?); SELECT SCOPE_IDENTITY();", connection)
                    addElectionCommand.Parameters.AddWithValue("@electionName", txtElectionName.Text.Trim())
                    addElectionCommand.Parameters.AddWithValue("@startDateTime", DateTimePickerStart.Value)
                    addElectionCommand.Parameters.AddWithValue("@endDateTime", DateTimePickerEnd.Value)
                    ' Retrieve the selected election type from comboElectionType
                    addElectionCommand.Parameters.AddWithValue("@electionType", comboElectionType.SelectedItem.ToString()) ' Assuming comboElectionType contains the election type
                    Dim electionId As Integer = Convert.ToInt32(addElectionCommand.ExecuteScalar())

                    ' Add each position to the database
                    For Each position As String In positionsList
                        Dim addPositionCommand As New OdbcCommand("INSERT INTO positions (position_name, election_id) VALUES (?, ?);", connection)
                        addPositionCommand.Parameters.AddWithValue("@positionName", position)
                        addPositionCommand.Parameters.AddWithValue("@electionId", electionId)
                        addPositionCommand.ExecuteNonQuery()
                    Next

                    MessageBox.Show("Election added successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error adding election: " & ex.Message)
            End Try

            ' Clear the positions list and refresh the DataGridView
            positionsList.Clear()
            RefreshDataGridView()
        Else
            MessageBox.Show("Please add at least one position.")
        End If
    End Sub

    Private Sub addElection_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Initialize the DataGridView with column headers
        DataGridViewPositions.Columns.Add("Position", "Position Name")
        ' Set the DateTimePicker formats
        DateTimePickerStart.Format = DateTimePickerFormat.Custom
        DateTimePickerStart.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        DateTimePickerEnd.Format = DateTimePickerFormat.Custom
        DateTimePickerEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss"

        ' Add election types to comboElectionType
        comboElectionType.Items.AddRange({"Lohit", "Brahma", "Manas", "Umiam", "Kapili", "Siang", "Disang", "Dhansiri", "Subhansiri", "Dihing", "Kameng", "Barak", "General"})
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        Me.Hide()
        Dim adminMainForm As New admin_main()
        adminMainForm.emailId = adminEmail
        adminMainForm.Show() ' Show the admin_main form
    End Sub
End Class
