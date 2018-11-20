'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb
Public Class SearchResult
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False

    Private Sub SearchResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'DataAdapter Selects all from the Personal_Details table, where their Runner_ID is equal to 0
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = 0"
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

        'Clears the DataSet
        dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
        'Adds a completely blank row to the DataSet
        dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'Sets the CurrentRowNo to equal 0
        CurrentRowNo = 0

        'The DataAdapter selects all the records from the Personal_Details table where the Runner_ID is equal to the vaiable ID
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = " & ID
        'Clears the DataSet
        dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
        'Fills the DataAdapter with all the records from the DataSet
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

        'If the row number of the DataSet = 0, then set the DataAdapter to equal all the records from the Personal_Details and order it
        'in descending order of the Runner_ID
        If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count = 0 Then
            dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details ORDER BY Runner_ID DESC"
            'Clear the DataSet
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Fill the DataAdapter will all the records from the DataSet
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")
            'Set the variable AddRecord to equal true
            AddRecord = True
            'Run the Private Sub DisplayAccount()
            DisplayAccount()
            'Otherwise run the Private Sub DisplayAccount() anyway
        Else
            DisplayAccount()
        End If
    End Sub
    Private Sub DisplayAccount()
        'If the number of rows in the DataSet is greater than 0, then:
        If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count > 0 Then
            'Set the FirstName textbox to equal the First_Name column in the database
            FirstNametxt2.Text = RTrim(dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("First_Name").ToString)
            'Set the Surname textbox to equal the Surname column in the database
            Surnametxt2.Text = RTrim(dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Surname").ToString)
            'Set the Gender textbox to equal the Gender column in the database
            Gendertxt.Text = RTrim(dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Gender").ToString)
            'Set the DOB textbox to equal the Date_Of_Birth column in the database
            DOBtxt2.Text = dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Date_Of_Birth").ToString
            'Set the Height textbox to equal the Height_ft column in the database
            Heighttxt2.Text = dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Height_ft").ToString
            'Set the Weight textbox to equal the Weight_kg column in the database
            Weighttxt2.Text = dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Weight_kg").ToString
            'Otherwise set the following textboxes to equal nothing
        Else
            FirstNametxt2.Text = Nothing
            Surnametxt2.Text = Nothing
            DOBtxt2.Text = Nothing
            Surnametxt2.Text = Nothing
            Heighttxt2.Text = Nothing
            Weighttxt2.Text = Nothing
            Gendertxt.Text = Nothing

        End If
    End Sub

    Private Sub Backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backbtn.Click
        'When the back button is clicked, show the homepage and close the SearchResult page
        Homepage.Show()
        Me.Close()
    End Sub
End Class