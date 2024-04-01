Imports System.Data.Odbc

Public Class candReg

    Private _electionId As Integer
    Private _voterId As Integer
    Private _name As String
    Private _email As String
    Private _rollNumber As String
    Private _password As String
    Private _course As String
    Private _year As String
    Private _hostel As String
    ' Voter ID property
    ' Constructor to set election id
    Public Sub New(ByVal electionId As Integer, ByVal voterId As Integer)
        InitializeComponent()
        _electionId = electionId
        _voterId = voterId
        FetchVoterDetails()
        LoadPositions()
    End Sub

    ' Method to fetch voter details from the database
    Private Sub FetchVoterDetails()
        Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
        Dim sqlQuery As String = "SELECT voter_name, voter_email, voter_roll_no, voter_password, voter_course, voter_year, hostel FROM voters WHERE voter_id = ?"

        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim command As New OdbcCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@voter_id", _voterId)
                Dim reader As OdbcDataReader = command.ExecuteReader()

                If reader.Read() Then
                    _name = reader("voter_name").ToString()
                    _email = reader("voter_email").ToString()
                    _rollNumber = reader("voter_roll_no").ToString()
                    _password = reader("voter_password").ToString()
                    _course = reader("voter_course").ToString()
                    _year = reader("voter_year").ToString()
                    _hostel = reader("hostel").ToString() ' Add hostel field
                Else
                    MessageBox.Show("Voter details not found.")
                    ' Handle the case where voter details are not found
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching voter details: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadPositions()
        ' Clear existing items in comboPosition
        comboPosition.Items.Clear()

        Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"
        Dim sqlQuery As String = "SELECT position_name FROM positions WHERE election_id = ?"

        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim command As New OdbcCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@election_id", _electionId)
                Dim reader As OdbcDataReader = command.ExecuteReader()

                While reader.Read()
                    ' Add position names to comboPosition
                    comboPosition.Items.Add(reader("position_name").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading positions: " & ex.Message)
        End Try
    End Sub

    Private Function GetPositionId(ByVal positionName As String) As Integer
        Dim positionId As Integer = 0 ' Initialize positionId variable
        Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"

        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim sqlQuery As String = "SELECT position_id FROM positions WHERE position_name = ? and election_id = ?"
                Using command As New OdbcCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@position_name", positionName)
                    command.Parameters.AddWithValue("@election_id", _electionId)
                    Dim reader As OdbcDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        positionId = Convert.ToInt32(reader("position_id"))
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching position ID: " & ex.Message)
        End Try

        Return positionId
    End Function


    Private Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_register.Click
        Dim connectionString As String = "Driver={SQL Server};Server=DESKTOP-42BTCUI\SQLEXPRESS;Database=electionmanagement;"

        Dim agendas As String = txtAgendas.Text
        Dim position As String = comboPosition.SelectedItem.ToString()

        Dim sqlQuery As String = "INSERT INTO candidates (candidate_name, candidate_roll_no, candidate_email, candidate_password, candidate_course, candidate_year, candidate_agenda, hostel, position_id, election_id, voter_id) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Try
            Using connection As New OdbcConnection(connectionString)
                connection.Open()
                Dim command As New OdbcCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@candidate_name", _name)
                command.Parameters.AddWithValue("@candidate_roll_no", _rollNumber)
                command.Parameters.AddWithValue("@candidate_email", _email)
                command.Parameters.AddWithValue("@candidate_password", _password)
                command.Parameters.AddWithValue("@candidate_course", _course)
                command.Parameters.AddWithValue("@candidate_year", _year)
                command.Parameters.AddWithValue("@candidate_agenda", agendas)
                command.Parameters.AddWithValue("@hostel", _hostel)
                ' Get position_id based on position name
                Dim positionId As Integer = GetPositionId(position)
                command.Parameters.AddWithValue("@position_id", positionId)
                command.Parameters.AddWithValue("@election_id", _electionId)
                command.Parameters.AddWithValue("@voter_id", _voterId) ' Add voter ID parameter
                command.ExecuteNonQuery()
                MessageBox.Show("Data saved successfully.")
                ' Close the current form
                Me.Close()

                ' Open the voter dashboard form
                Dim voterDashboardForm As New voter_dashboard()
                voterDashboardForm.VoterId = _voterId ' Pass the voter ID to the dashboard
                voterDashboardForm.Show()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub



    Private Sub candReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    
End Class
