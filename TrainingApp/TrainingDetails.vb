'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb

Public Class TrainingDetails
    'Declares the variable dtaadpTrain as OleDbDataAdapter
    Dim dtaadpTrain As New OleDbDataAdapter
    'Declares the variable sqlcmdbldTrain as OleDbCommandBuilder
    Dim sqlcmdbldTrain As New OleDbCommandBuilder(dtaadpTrain)
    'Declares the variable CurrentRowNo as Integer, and then -1
    Dim CurrentRowNo As Integer = -1
    'Declares the variable AddRecord as Boolean, and then false
    Dim AddRecord As Boolean = False
    'Declares the variable Average as Integer
    Dim Average As Integer



    Private Sub TrainingDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpTrain to equal a new OleDbCommand
        dtaadpTrain.SelectCommand = New OleDbCommand
        dtaadpTrain.SelectCommand.Connection = conAppDatabase
        'DataAdapter selects all from the Training_Details table in the database where the Runner_ID is equal to 0
        dtaadpTrain.SelectCommand.CommandText = "SELECT * FROM Training_Details WHERE Runner_ID =" & ID
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpTrain.Fill(dtasetAppDatabase, "tblTraining_Details")
        'Current RowNo is set to 0
        CurrentRowNo = 0
        'Initializes the variable dtaadpTraining_Details to equal a new OleDbCommand
        dtaadpTraining_Details.SelectCommand = New OleDbCommand
        dtaadpTraining_Details.SelectCommand.Connection = conAppDatabase
        'DataAdapter selects all from the Training_Details table in the database where the Runner_ID is equal to 0
        dtaadpTraining_Details.SelectCommand.CommandText = "SELECT * FROM Training_Details WHERE Runner_ID = 0"
        'DataAdapter selects all from the Training_Details table in the database where the Runner_ID is equal to 0
        dtaadpTraining_Details.Fill(dtasetAppDatabase, "tblTraining_Details")
        'Runs the DisplayAccount Sub
        DisplayAccount()

        'If the number of rows in the DataSet is equal to 0, clear the DataSet, add a new row contain Nothing, ID and 4x 0
        If dtasetAppDatabase.Tables("tblTraining_Details").Rows.Count = 0 Then
            dtasetAppDatabase.Tables("tblTraining_Details").Clear()
            dtasetAppDatabase.Tables("tblTraining_Details").Rows.Add(Nothing, ID, 0, 0, 0, 0)
            'Set AddRecord to true
            AddRecord = True
            'Sets CurrentRowNo to equal 0
            CurrentRowNo = 0
            'Otherwise it also sets CurrentRowNo to equal 0
        Else
            CurrentRowNo = 0
        End If
    End Sub
    Private Sub DisplayAccount()
        'If the number of rows in the DataSet are greater than 0, the four textboxes display the information in the database which is
        'linked to the same ID
        If dtasetAppDatabase.Tables("tblTraining_Details").Rows.Count > 0 Then
            RunningDisttxt.Text = RTrim(dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo).Item("Running_Distance").ToString)
            SwimmingDisttxt.Text = RTrim(dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo).Item("Swimming_Distance").ToString)
            CyclingDisttxt.Text = dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo).Item("Cycling_Distance").ToString
            AvgDisttxt.Text = dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo).Item("AverageDist").ToString
            'Otherwise all of the four textboxes are left blank (contain Nothing)
        Else
            RunningDisttxt.Text = Nothing
            SwimmingDisttxt.Text = Nothing
            CyclingDisttxt.Text = Nothing
            AvgDisttxt.Text = Nothing
        End If
    End Sub
    Private Sub TrainingDetailsAddbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainingDetailsAddbtn.Click
        'All three textboxes are link to their appropriate columns in the database table
        dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo)("Swimming_Distance") = (SwimmingDisttxt.Text)
        dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo)("Running_Distance") = (RunningDisttxt.Text)
        dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo)("Cycling_Distance") = (CyclingDisttxt.Text)
        'Adds up all the information in the three textboxes and finds the average (divides by three)
        'Each one is divided by 1, in order for the final total distance to be divided by three
        Average = (1.5 * (RunningDisttxt.Text / 1) + (SwimmingDisttxt.Text / 1) + 0.5 * (CyclingDisttxt.Text / 1)) / 3
        dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo)("AverageDist") = Average
        'DataAdapter is updated with all the records from the DataSet
        dtaadpTrain.Update(dtasetAppDatabase, "tblTraining_Details")
        'AddRecord is set to true
        AddRecord = True

        'If the Running Distance text box is equal to null, the Running Distance row in the Training Details table is set to Nothing
        If RunningDisttxt.Text = "" Then
            dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo)("Running_Distance") = (Nothing)

            'Otherwise if the Swimming Distance text box is equal to null, the Swimming Distance row in the Training Details table is set to Nothing
        ElseIf SwimmingDisttxt.Text = "" Then
            dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo)("Swimming_Distance") = (Nothing)

            'Otherwise if the Swimming Distance text box is equal to null, the Swimming Distance row in the Training Details table is set to Nothing
        ElseIf CyclingDisttxt.Text = "" Then
            dtasetAppDatabase.Tables("tblTraining_Details").Rows(CurrentRowNo)("Cycling_Distance") = (Nothing)
        End If

        'Runs the code within the DisplayAccount private sub
        DisplayAccount()

        'Displays a Save Updates messagebox
        MessageBox.Show("The updates have been saved to disk.", "Save Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Sets the Training Details Add button and the edit button to be invisible
        TrainingDetailsAddbtn.Visible = False
        Editbtn.Visible = True
        'Disables all three of the distance textboxes
        RunningDisttxt.Enabled = False
        SwimmingDisttxt.Enabled = False
        CyclingDisttxt.Enabled = False

    End Sub

    Private Sub Backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backbtn.Click
        'When the back button is clicked, the homepage form is opened and the Training Details form is close
        Homepage.Show()
        Me.Close()
    End Sub
    Private Sub RunningDisttxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunningDisttxt.TextChanged
        'If the information entered in the Running Distance textbox is not a number, a Character Error messagebox is shown and the textbox is set to NULL
        If IsNumeric(RunningDisttxt.Text) = False Then
            MessageBox.Show("The distance you've run must contain only numbers", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RunningDisttxt.Text = ""
        End If
    End Sub

    Private Sub SwimmingDisttxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwimmingDisttxt.TextChanged
        'If the information entered in the Swimming Distance textbox is not a number, a Character Error messagebox is shown and the textbox is set to NULL
        If IsNumeric(SwimmingDisttxt.Text) = False Then
            MessageBox.Show("The distance you've swam must contain only numbers", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SwimmingDisttxt.Text = ""
        End If
    End Sub

    Private Sub CyclingDisttxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CyclingDisttxt.TextChanged
        'If the information entered in the Cycling Distance textbox is not a number, a Character Error messagebox is shown and the textbox is set to NULL
        If IsNumeric(CyclingDisttxt.Text) = False Then
            MessageBox.Show("The distance you've cycled must contain only numbers", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CyclingDisttxt.Text = ""
        End If
    End Sub
    Private Sub Editbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editbtn.Click
        'When the edit button is clicked, the Running, Swimming and Cycling textboxes become enabled, as well as the add button becoming visible
        'The edit button becomes invisible
        RunningDisttxt.Enabled = True
        SwimmingDisttxt.Enabled = True
        CyclingDisttxt.Enabled = True
        TrainingDetailsAddbtn.Visible = True
        Editbtn.Visible = False
    End Sub
End Class

