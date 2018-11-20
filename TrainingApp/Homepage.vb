'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb
Public Class Homepage
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False
    Private Sub Homepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'DataAdapter selects all from the Personal_Details table in the database where the Runner_ID is equal to 0
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = 0"
        'Fills the Dataadapter with the records selected from the Personal_Details table which are currently in the Dataset
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

        'dtaadpPdet.Fill(dtasetAppDatabase, "Personal_Details")
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = " & ID
        'dtasetAth.Tables("tblAthlete").Clear()
        dtaadpPdet.Fill(dtasetAppDatabase, "Personal_Details")
        'Initializes the variable CurrentRowNo as 0
        CurrentRowNo = 0
        'Runs the DisplayAccount Sub
        DisplayAccount()

    End Sub
    Private Sub DisplayAccount()
        'Initializes the ID display textbox to the Runner_ID of the CurrentRowNo in the DataSet
        YourIDtxt.Text = dtasetAppDatabase.Tables("Personal_Details").Rows(CurrentRowNo).Item("Runner_ID").ToString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logoutbtn.Click
        'When logout button is clicked, it shows the Login page, closes the Homepage and sets the Search Box textbox to NULL
        Login.Show()
        Me.Close()
        SearchBoxtxt.Text = ""
    End Sub

    Private Sub PersonalDetailsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalDetailsbtn.Click
        'When the Personal Details button is clicked, it shows the Personal Details page, closes the Homepage and sets the Search Box textbox to NULL
        Personal_Details.Show()
        Me.Close()
        SearchBoxtxt.Text = ""
    End Sub

    Private Sub Leaderboardbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Leaderboardbtn.Click
        'When the Leaderboard button is clicked, it shows the Leaderboard page, closes the Homepage and sets the Search Box textbox to NULL
        Leaderboard.Show()
        Me.Close()
        SearchBoxtxt.Text = ""
    End Sub
    Private Sub Gobtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gobtn.Click
        'When the search button is pressed, if the Search Box textbox equals NULL, display an Authentication Error messagebox
        If SearchBoxtxt.Text = "" Then
            MessageBox.Show("Please enter search before pressing go", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise if the length of the ID entered is greater than 1000, display and ID length error messagebox
        ElseIf Len(SearchBoxtxt.Text) > 500 Then
            MessageBox.Show("The ID entered is too long", "ID Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SearchBoxtxt.Text = ""
            'Otherwise declare the variable Run_ID as Integer
        Else
            Dim Run_ID As Integer
            'Initializes the variable as the result of the Search Box textbox and convert it to a decimal
            Run_ID = Convert.ToDecimal(SearchBoxtxt.Text)
            'The DataAdapter selects all the records from the Personal_Details table where the Runner_ID is equal to 0 and Run_ID
            dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = 0" & Run_ID
            'Clears the DataSet
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Fills the DataAdapter with the records from the DataSet
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

            'If the DataSet row is equal to 0 then display an ID Searched is incorrect messagebox and set the Search Box textbox to NULL
            If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count = 0 Then
                MessageBox.Show("The ID you typed does not exist", "ID Searched is incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SearchBoxtxt.Text = ""

                'Otherwise if the ID entered in the Search Box textbox is not a number, display a Character Error messagebox and set the Search Box textbox to NULL
            ElseIf IsNumeric(SearchBoxtxt.Text) = False Then
                MessageBox.Show("The ID entered must only contain numbers", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SearchBoxtxt.Text = ""
            Else
                'Show the SearchResult form and close the Homepage form
                SearchResult.Show()
                Me.Close()

            End If
        End If

    End Sub

    Private Sub TrainingDetailsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainingDetailsbtn.Click
        'When the Training Details button is clicked, show the Training Details form, close the Hompage and set the Search Box textbox to NULL
        TrainingDetails.Show()
        Me.Close()
        SearchBoxtxt.Text = ""
    End Sub

    Private Sub Teambtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Teambtn.Click
        'When the Team button is clicked, show the Top 8 Athlete form, close the Hompage and set the Search Box textbox to NULL
        Team.Show()
        Me.Close()
        SearchBoxtxt.Text = ""
    End Sub
End Class