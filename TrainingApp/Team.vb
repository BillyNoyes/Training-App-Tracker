'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb
Public Class Team
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False
    'Declares Querytop8 as String
    Dim Querytop8 As String
    'Declares TeamQuery as String
    Dim TeamQuery As String
    'Declares dtaadpTop8 as OleDbDataAdapter
    Dim dtaadpTop8 As New OleDbDataAdapter
    'Declares sqlcmdbldtop8 as OleDbCommandBuilder(dtaadpTop8)
    Dim sqlcmdbldtop8 As New OleDbCommandBuilder(dtaadpTop8)


    Private Sub Team_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Initializes the variable TeamQuery as all the records from the Personal_Details and Training_Details where both have matching Runner_IDs
        TeamQuery = "SELECT * FROM Personal_Details, Training_Details WHERE Personal_Details.Runner_ID = Training_Details.Runner_ID"
        'Initializes the CurrentRowNo to equal 0
        CurrentRowNo = 0
        'Shows the DGVTeam DataGridView
        ShowDGVTeam()
    End Sub

    Private Sub ShowDGVTeam()
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        'Initializes the variable dtaadpComparison to equal a new OleDbCommand
        dtaadpComparison.SelectCommand = New OleDbCommand
        'Initializes the variable dtaadpComparison as conAppDatabase
        dtaadpComparison.SelectCommand.Connection = conAppDatabase
        'Initializes the variable dtaadpPdet as conAppDatabase
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'The DataAdapter selects all the records from the Personal_Details where the Runner_ID equals 0
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = 0"
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")
        'Clears the DataSet
        dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
        'The DataAdapter selects the top 8 average distances from the Training_Details
        dtaadpComparison.SelectCommand.CommandText = "SELECT TOP 8 Training_Details.Runner_ID, Personal_Details.First_Name, Personal_Details.Surname, Training_Details.Cycling_Distance, Training_Details.Running_Distance,Training_Details.Swimming_Distance, Training_Details.AverageDist FROM Personal_Details, Training_Details WHERE Personal_Details.Runner_ID = Training_Details.Runner_ID AND Training_Details.AverageDist > 0 AND Training_Details.Runner_ID = 0 ORDER BY AverageDist DESC"
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpComparison.Fill(dtasetAppDatabase, "Team")
        'Clears the DataSet
        dtasetAppDatabase.Tables("Team").Clear()
        'The DataAdapter selects the top 8 average distances from the Training_Details
        dtaadpComparison.SelectCommand.CommandText = "SELECT TOP 8 Training_Details.Runner_ID, Personal_Details.First_Name, Personal_Details.Surname, Training_Details.Cycling_Distance, Training_Details.Running_Distance,Training_Details.Swimming_Distance, Training_Details.AverageDist FROM Personal_Details, Training_Details WHERE Personal_Details.Runner_ID = Training_Details.Runner_ID AND Training_Details.AverageDist > 0 ORDER BY AverageDist DESC"
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpComparison.Fill(dtasetAppDatabase, "Team")
        'Sets the datasource of the DataGridView to the DataSet
        DGVTeam.DataSource = dtasetAppDatabase
        'Sets the DataMember of the DataGridView to Team
        DGVTeam.DataMember = "Team"
        'Renames the Runner_ID to ID
        DGVTeam.Columns("Runner_ID").HeaderText = "ID"
        'Renames the First_name to First Name
        DGVTeam.Columns("First_name").HeaderText = "First Name"
        'Renames the Surname to Surname
        DGVTeam.Columns("Surname").HeaderText = "Surname"
        'Renames the Cycling_Distance to Cycling Distance (km)
        DGVTeam.Columns("Cycling_Distance").HeaderText = "Cycling Distance (km)"
        'Renames the Running_Distance to Running Distance (km)
        DGVTeam.Columns("Running_Distance").HeaderText = "Running Distance (km)"
        'Renames the Swimming_Distance toSwimming Distance (km)
        DGVTeam.Columns("Swimming_Distance").HeaderText = "Swimming Distance (km)"
        'Renames the AverageDist to Average Distance (km)
        DGVTeam.Columns("AverageDist").HeaderText = "Average Distance (km)"
        'Automatically sets the size of the DataGridView
        DGVTeam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        'Sorts the DataGridView under the column AverageDist in descending order
        DGVTeam.Sort(DGVTeam.Columns("AverageDist"), System.ComponentModel.ListSortDirection.Descending)
        'Sets the Runner_ID as not sortable
        DGVTeam.Columns("Runner_ID").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the First_Name as not sortable
        DGVTeam.Columns("First_name").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the Surname as not sortable
        DGVTeam.Columns("Surname").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Backbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backbtn2.Click
        'When the back button is clicked, the homepage shows and the top 8 form closes
        Homepage.Show()
        Me.Close()
    End Sub
End Class