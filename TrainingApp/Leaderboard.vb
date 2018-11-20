'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb
Public Class Leaderboard
    'Declares the variable dtaadpTrain as OleDbDataAdapter
    Dim dtaadpTrain As New OleDbDataAdapter
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False
 
    Private Sub Leaderboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets the CurrentRowNo to equal 0
        CurrentRowNo = 0
        'Shows the DataGridView
        ShowDGV()
        'Shows the comparison DataGridView
        ShowDGVMeCompare()
    End Sub
    Private Sub ShowDGVMeCompare()
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpTrain to equal new OleDbCommand
        dtaadpTrain.SelectCommand = New OleDbCommand
        'Initializes the variable dtaadpComparison as conAppDatabase
        dtaadpTrain.SelectCommand.Connection = conAppDatabase
        'The DataAdapter selects all the records from the Training_Details table where the Runner_ID is equal to the variable ID
        dtaadpTrain.SelectCommand.CommandText = "SELECT * FROM Training_Details WHERE Runner_ID =" & ID
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpTrain.Fill(dtasetAppDatabase, "tblTraining_Details")
        'Sets the CurrentRowNo to equal 0
        CurrentRowNo = 0

        'Clears the DataSet
        dtasetAppDatabase.Tables("tblTraining_Details").Clear()
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpTrain.Fill(dtasetAppDatabase, "tblTraining_Details")
        'Sets the DataSource for the DataGridView to the DataSet, dtasetAppDatabase
        DGVMeCompare.DataSource = dtasetAppDatabase
        'Sets the DataMember for the DataGridView to equal the table Training_Details
        DGVMeCompare.DataMember = "tblTraining_Details"
        'Sets the column Training_ID as false, meaning that it is not visible
        DGVMeCompare.Columns("Training_ID").Visible = False
        'Sets the column Runner_ID as false, meaning that it is not visible
        DGVMeCompare.Columns("Runner_ID").Visible = False
        'Renames the Running_Distance to Running Distance (km)
        DGVMeCompare.Columns("Running_Distance").HeaderText = "Running Distance (km)"
        'Renames the Cycling_Distance to Cycling Distance (km)
        DGVMeCompare.Columns("Cycling_Distance").HeaderText = "Cycling Distance (km)"
        'Renames the Swimming_Distance to Swimming Distance (km)
        DGVMeCompare.Columns("Swimming_Distance").HeaderText = "Swimming Distance (km)"
        'Renames the AverageDist to Average Distance (km))
        DGVMeCompare.Columns("AverageDist").HeaderText = "Average Distance (km)"
        'Automatically sets the size of the DataGridView
        DGVMeCompare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        'Sets the Runner_ID as not sortable
        DGVMeCompare.Columns("Runner_ID").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the Running_Distance as not sortable
        DGVMeCompare.Columns("Running_Distance").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the Cycling_Distance as not sortable
        DGVMeCompare.Columns("Cycling_Distance").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the Swimming_Distance as not sortable
        DGVMeCompare.Columns("Swimming_Distance").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the AverageDist as not sortable
        DGVMeCompare.Columns("AverageDist").SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub
    Private Sub ShowDGV()
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable  dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        'Initializes the variable dtaadpComparison as new OleDbCommand
        dtaadpComparison.SelectCommand = New OleDbCommand
        'Initializes the variable dtaadpComparison as conAppDatabase
        dtaadpComparison.SelectCommand.Connection = conAppDatabase
        'Initializes the variable dtaadpPdet as conAppDatabase
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'The DataAdapter selects all the records from the Personal_Details table where the Runner_ID is equal to 0
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = 0"
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")
        'Clears the DataSet
        dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
        'The DataAdapter selects all the records from the Personal and Training Details tables where both have matching Runner_IDs and Training_ID is equal to 0
        dtaadpComparison.SelectCommand.CommandText = "SELECT * FROM Personal_Details, Training_Details WHERE Personal_Details.Runner_ID = Training_Details.Runner_ID AND Training_ID = 0"
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpComparison.Fill(dtasetAppDatabase, "tblLeaderboard")
        'Clears the DataSet
        dtasetAppDatabase.Tables("tblLeaderboard").Clear()
        'The DataAdapter selects all the records from the Personal and Training Details table where both have equal Runner_IDs
        dtaadpComparison.SelectCommand.CommandText = "SELECT * FROM Personal_Details, Training_Details WHERE Personal_Details.Runner_ID = Training_Details.Runner_ID"
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpComparison.Fill(dtasetAppDatabase, "tblLeaderboard")
        'Sets the DataSource for the DataGridView to the DataSet, dtasetAppDatabase
        DGV.DataSource = dtasetAppDatabase
        'Sets the DataMember for the DataGridView to equal the table Leaderboard
        DGV.DataMember = "tblLeaderboard"
        'Sets the column Training_ID as false, meaning that it is not visible
        DGV.Columns("Training_ID").Visible = False
        'Sets the column Athlete_pass as false, meaning that it is not visible
        DGV.Columns("Athlete_pass").Visible = False
        'Sets the column Height_ft as false, meaning that it is not visible
        DGV.Columns("Height_ft").Visible = False
        'Sets the column Weight_kg as false, meaning that it is not visible
        DGV.Columns("Weight_kg").Visible = False
        'Sets the column Gender as false, meaning that it is not visible
        DGV.Columns("Gender").Visible = False
        'Sets the column Date_Of_Birth as false, meaning that it is not visible
        DGV.Columns("Date_Of_Birth").Visible = False
        'Sets the column Training_Details.Runner_ID as false, meaning that it is not visible
        DGV.Columns("Training_Details.Runner_ID").Visible = False
        'Sets the column Email as false, meaning that it is not visible
        DGV.Columns("Email").Visible = False
        'Sets the column Security_Question as false, meaning that it is not visible
        DGV.Columns("Security_Question").Visible = False
        'Renames the Personal_Details.Runner_ID to ID
        DGV.Columns("Personal_Details.Runner_ID").HeaderText = "ID"
        'Renames the First_name to First Name
        DGV.Columns("First_name").HeaderText = "First Name"
        'Renames the Surname to Surname
        DGV.Columns("Surname").HeaderText = "Surname"
        'Renames the Cycling_Distance to Cycling Distance (km)
        DGV.Columns("Cycling_Distance").HeaderText = "Cycling Distance (km)"
        'Renames theRunning_Distance to Running Distance (km)
        DGV.Columns("Running_Distance").HeaderText = "Running Distance (km)"
        'Renames the Swimming_Distance to Swimming Distance (km)
        DGV.Columns("Swimming_Distance").HeaderText = "Swimming Distance (km)"
        'Renames the AverageDist to Average Distance (km)
        DGV.Columns("AverageDist").HeaderText = "Average Distance (km)"
        'Automatically sets the size of the DataGridView
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        'Sorts the DataGridView under the column AverageDist in descending order
        DGV.Sort(DGV.Columns("AverageDist"), System.ComponentModel.ListSortDirection.Descending)
        'Sets the Personal_Details.Runner_ID as not sortable
        DGV.Columns("Personal_Details.Runner_ID").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the First_name as not sortable
        DGV.Columns("First_name").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the Surname as not sortable
        DGV.Columns("Surname").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the Cycling_Distance as not sortable
        DGV.Columns("Cycling_Distance").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the Running_Distance as not sortable
        DGV.Columns("Running_Distance").SortMode = DataGridViewColumnSortMode.NotSortable
        'Sets the Swimming_Distance as not sortable
        DGV.Columns("Swimming_Distance").SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub
    Private Sub Backbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backbtn2.Click
        'When the back button is clicked, the homepage form is shown and the leaderboard form is close
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub Refreshbtn_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refreshbtn.Click
        'If the user hasn't selected a training activity but press the refresh button, a messagebox pops up telling the user to select an activity
        If Activitycbo.SelectedIndex = -1 Then
            MessageBox.Show("Please select a training activity", "No Training Activity Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'If the first choice for the combobox is selected and the refresh button is clicked then
        ElseIf Activitycbo.SelectedIndex = 0 Then
            'The column Training_ID is set to not visible
            DGV.Columns("Training_ID").Visible = False
            'The column Athlete_pass is set to not visible
            DGV.Columns("Athlete_pass").Visible = False
            'The column Height_ft is set to not visible
            DGV.Columns("Height_ft").Visible = False
            'The column Weight_kg is set to not visible
            DGV.Columns("Weight_kg").Visible = False
            'The column Gender is set to not visible
            DGV.Columns("Gender").Visible = False
            'The column Date_Of_Birth is set to not visible
            DGV.Columns("Date_Of_Birth").Visible = False
            'The column Training_Details.Runner_ID is set to not visible
            DGV.Columns("Training_Details.Runner_ID").Visible = False
            'The column Cycling_Distance is set to not visible
            DGV.Columns("Cycling_Distance").Visible = True
            'The column Running_Distance is set to not visible
            DGV.Columns("Running_Distance").Visible = True
            'The column Swimming_Distance is set to not visible
            DGV.Columns("Swimming_Distance").Visible = True
            'The column AverageDist is set to not visible
            DGV.Columns("AverageDist").Visible = True
            'Renames the column Personal_Details.Runner_ID to ID
            DGV.Columns("Personal_Details.Runner_ID").HeaderText = "ID"
            'Renames the column First_name to First Name
            DGV.Columns("First_name").HeaderText = "First Name"
            'Renames the column Surname to Surname
            DGV.Columns("Surname").HeaderText = "Surname"
            'Renames the column Cycling_Distance to Cycling Distance(km)
            DGV.Columns("Cycling_Distance").HeaderText = "Cycling Distance(km)"
            'Renames the column Running_Distance to Running Distance(km)
            DGV.Columns("Running_Distance").HeaderText = "Running Distance(km)"
            'Renames the column Swimming_Distanc to Swimming Distance(km)
            DGV.Columns("Swimming_Distance").HeaderText = "Swimming Distance(km)"
            'Renames the column AverageDist to Average Distance(km)
            DGV.Columns("AverageDist").HeaderText = "Average Distance(km)"
            'Automatically sets the size of the DataGridView
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            'Sorts the DataGridView under the column AverageDist in descending order
            DGV.Sort(DGV.Columns("AverageDist"), System.ComponentModel.ListSortDirection.Descending)
            'Sets the Personal_Details.Runner_ID as not sortable
            DGV.Columns("Personal_Details.Runner_ID").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the First_name as not sortable
            DGV.Columns("First_name").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the Surname as not sortable
            DGV.Columns("Surname").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the Cycling_Distance as not sortable
            DGV.Columns("Cycling_Distance").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the Running_Distance as not sortable
            DGV.Columns("Running_Distance").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the Swimming_Distance as not sortable
            DGV.Columns("Swimming_Distance").SortMode = DataGridViewColumnSortMode.NotSortable

            'Otherwise if the second choice for the combobox is selected and the refresh button is clicked then
        ElseIf Activitycbo.SelectedIndex = 1 Then
            'The column Training_ID is set to not visible
            DGV.Columns("Training_ID").Visible = False
            'The column Athlete_pass is set to not visible
            DGV.Columns("Athlete_pass").Visible = False
            'The column Height_ft is set to not visible
            DGV.Columns("Height_ft").Visible = False
            'The column Weight_kg is set to not visible
            DGV.Columns("Weight_kg").Visible = False
            'The column Gender is set to not visible
            DGV.Columns("Gender").Visible = False
            'The column Date_Of_Birth is set to not visible
            DGV.Columns("Date_Of_Birth").Visible = False
            'The column Training_Details.Runner_ID is set to not visible
            DGV.Columns("Training_Details.Runner_ID").Visible = False
            'The column Swimming_Distance is set to not visible
            DGV.Columns("Swimming_Distance").Visible = False
            'The column Cycling_Distance is set to not visible
            DGV.Columns("Cycling_Distance").Visible = False
            'The column AverageDist is set to not visible
            DGV.Columns("AverageDist").Visible = False
            'The column Running_Distance is set to visible
            DGV.Columns("Running_Distance").Visible = True
            'Renames the column Personal_Details.Runner_ID to ID
            DGV.Columns("Personal_Details.Runner_ID").HeaderText = "ID"
            'Renames the column First_name to First Name
            DGV.Columns("First_name").HeaderText = "First Name"
            'Renames the column Surname to Surname
            DGV.Columns("Surname").HeaderText = "Surname"
            'Renames the column Running_Distance to Running Distance(km)
            DGV.Columns("Running_Distance").HeaderText = "Running Distance(km)"
            'Sorts the DataGridView under the column Running_Distance in descending order
            DGV.Sort(DGV.Columns("Running_Distance"), System.ComponentModel.ListSortDirection.Descending)
            'Sets the sort mode of column Running_Distance to automatic
            DGV.Columns("Running_Distance").SortMode = DataGridViewColumnSortMode.Automatic
            'Sets the sort mode of column Personal_Details.Runner_ID to not sortable
            DGV.Columns("Personal_Details.Runner_ID").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the sort mode of column First_name to not sortable
            DGV.Columns("First_name").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the sort mode of column Surname to not sortable
            DGV.Columns("Surname").SortMode = DataGridViewColumnSortMode.NotSortable

            'Otherwise if the third choice for the combobox is selected and the refresh button is clicked then
        ElseIf Activitycbo.SelectedIndex = 2 Then
            'The column Training_ID is set to not visible
            DGV.Columns("Training_ID").Visible = False
            'The column Athlete_pass is set to not visible
            DGV.Columns("Athlete_pass").Visible = False
            'The column Height_ft is set to not visible
            DGV.Columns("Height_ft").Visible = False
            'The column Weight_kg is set to not visible
            DGV.Columns("Weight_kg").Visible = False
            'The column Gender is set to not visible
            DGV.Columns("Gender").Visible = False
            'The column Date_Of_Birth is set to not visible
            DGV.Columns("Date_Of_Birth").Visible = False
            'The column Runner_ID in the Training Details table is set to not visible
            DGV.Columns("Training_Details.Runner_ID").Visible = False
            'The column Running_Distance is set to not visible
            DGV.Columns("Running_Distance").Visible = False
            'The column Cycling_Distance is set to not visible
            DGV.Columns("Cycling_Distance").Visible = False
            'The column AverageDist is set to not visible
            DGV.Columns("AverageDist").Visible = False
            'The column Swimming_Distance is set to visible
            DGV.Columns("Swimming_Distance").Visible = True
            'Renames the column Runner_ID in the Personal Details table to ID
            DGV.Columns("Personal_Details.Runner_ID").HeaderText = "ID"
            'Renames the column First_name to First Name
            DGV.Columns("First_name").HeaderText = "First Name"
            'Renames the column Surname to Surname
            DGV.Columns("Surname").HeaderText = "Surname"
            'Renames the column Swimming_Distance to Swimming Distance(km)
            DGV.Columns("Swimming_Distance").HeaderText = "Swimming Distance(km)"
            'Sorts the DataGridView under the column Swimming_Distance in descending order
            DGV.Sort(DGV.Columns("Swimming_Distance"), System.ComponentModel.ListSortDirection.Descending)
            'Sets the sort mode of column Swimming_Distance to automatic
            DGV.Columns("Swimming_Distance").SortMode = DataGridViewColumnSortMode.Automatic
            'Sets the sort mode of column Runner_ID in the Personal Details table to not sortable
            DGV.Columns("Personal_Details.Runner_ID").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the sort mode of column First_name to not sortable
            DGV.Columns("First_name").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the sort mode of column Surname to not sortable
            DGV.Columns("Surname").SortMode = DataGridViewColumnSortMode.NotSortable

            'Otherwise if the fourth choice for the combobox is selected and the refresh button is clicked then
        ElseIf Activitycbo.SelectedIndex = 3 Then
            'The column Training_ID is set to not visible
            DGV.Columns("Training_ID").Visible = False
            'The column Athlete_pass is set to not visible
            DGV.Columns("Athlete_pass").Visible = False
            'The column Height_ft is set to not visible
            DGV.Columns("Height_ft").Visible = False
            'The column Weight_kg is set to not visible
            DGV.Columns("Weight_kg").Visible = False
            'The column Gender is set to not visible
            DGV.Columns("Gender").Visible = False
            'The column Date_Of_Birth is set to not visible
            DGV.Columns("Date_Of_Birth").Visible = False
            'The column Runner_ID in the Training Details table is set to not visible
            DGV.Columns("Training_Details.Runner_ID").Visible = False
            'The column Swimming_Distance is set to not visible
            DGV.Columns("Swimming_Distance").Visible = False
            'The column Running_Distance is set to not visible
            DGV.Columns("Running_Distance").Visible = False
            'The column AverageDist is set to not visible
            DGV.Columns("AverageDist").Visible = False
            'The column Cycling_Distance is set to visible
            DGV.Columns("Cycling_Distance").Visible = True
            'Renames the column Runner_ID in the Personal Details table to ID
            DGV.Columns("Personal_Details.Runner_ID").HeaderText = "ID"
            'Renames the column First_name to First Name
            DGV.Columns("First_name").HeaderText = "First Name"
            'Renames the column Surname to Surname
            DGV.Columns("Surname").HeaderText = "Surname"
            'Renames the column Cycling_Distance to Cycling Distance(km)
            DGV.Columns("Cycling_Distance").HeaderText = "Cycling Distance(km)"
            'Sorts the DataGridView under the column Cycling_Distance in descending order
            DGV.Sort(DGV.Columns("Cycling_Distance"), System.ComponentModel.ListSortDirection.Descending)
            'Sets the sort mode of column Cycling_Distance to automatic
            DGV.Columns("Cycling_Distance").SortMode = DataGridViewColumnSortMode.Automatic
            'Sets the sort mode of column Runner_ID in the Personal Details table to not sortable
            DGV.Columns("Personal_Details.Runner_ID").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the sort mode of column First_name to not sortable
            DGV.Columns("First_name").SortMode = DataGridViewColumnSortMode.NotSortable
            'Sets the sort mode of column Surname to not sortable
            DGV.Columns("Surname").SortMode = DataGridViewColumnSortMode.NotSortable
        End If

    End Sub
End Class