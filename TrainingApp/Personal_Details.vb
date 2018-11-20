'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb

Public Class Personal_Details
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'DataAdapter selects all from the Personal_Details table in the database where the Runner_ID is equal to 0
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = 0"
        'Fills the DataSet with the records selected from the Personal_Details table which are currently in the DataAdapter
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

        'Clears the Dataset
        dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
        'Creates a new row in the Dataset which contains Nothing in each column
        dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Add(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'Initializes the variable CurrentRowNo to equal 0
        CurrentRowNo = 0
        'The Dataadpter selects all the records from the Personal Details table where the Runner_ID is equal to the ID variable
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = " & ID
        'Clears the Dataset
        dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
        'Fills the Dataapter with all the records in the Dataset
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

        'If the number of rows in the Dataset is eqaul to 0, the Dataadapter selects all the records from the Personal Details table and orders them by the Runner_ID in descending order
        If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count = 0 Then
            dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details ORDER BY Runner_ID DESC"
            'Clears the Dataset
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Fills the Dataadapter with all the records in the Dataset
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")
            'Sets the AddRecord variable to equal True
            AddRecord = True
            'Runs the DisplayAccount Private Sub
            DisplayAccount()
            'Otherwise it Runs the DisplayAccount Private Sub
        Else
            DisplayAccount()
        End If
    End Sub
    Private Sub DisplayAccount()
        'If the number of rows in the Dataset are greater than 0, then the First Name, Surname and Email textbox are set to equal their appropriate column in the Personal Details table
        If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count > 0 Then
            FirstNametxt.Text = RTrim(dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("First_Name").ToString)
            Surnametxt.Text = RTrim(dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Surname").ToString)
            Emailtxt.Text = RTrim(dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Email").ToString)
            'If Female is selected in the Gender combobox, F is saved to the Gender column in the Dataset, M for Male, otherwise the Gender combobox equals Null 
            Select Case dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Gender").ToString
                Case "F"
                    Gendercbo.Text = "Female"
                Case "M"
                    Gendercbo.Text = "Male"
                Case Else
                    Gendercbo.Text = ""
            End Select
            'The Date of Birth picker, and both the Height and Weight textboxes are set to equal their appropriate column in the Personal Details table
            DOBPicker.Text = dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Date_Of_Birth").ToString
            Heighttxt.Text = dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Height_ft").ToString
            Weighttxt.Text = dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Weight_kg").ToString
            'Otherwise all of the textboxes, the Date of Birth picker and the Gender combobox are set to Nothing
        Else
            FirstNametxt.Text = Nothing
            Surnametxt.Text = Nothing
            Emailtxt.Text = Nothing
            DOBPicker.Text = Nothing
            Surnametxt.Text = Nothing
            Heighttxt.Text = Nothing
            Weighttxt.Text = Nothing
            Gendercbo.Text = Nothing
        End If
    End Sub
    Private Sub Editbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editbtn.Click
        'When the Edit button is clicked, all of the textboxes, the Date of Birth picker and the Gender combobox are enabled
        FirstNametxt.Enabled = True
        Surnametxt.Enabled = True
        Emailtxt.Enabled = True
        DOBPicker.Enabled = True
        Gendercbo.Enabled = True
        Weighttxt.Enabled = True
        Heighttxt.Enabled = True
        'Save and Cancel button become visible
        Savebtn.Visible = True
        Cancelbtn2.Visible = True
        'Edit, back and Security Details Update form button become invisible
        Editbtn.Visible = False
        SecuritySettingsbtn.Visible = False
        Backbtn.Visible = False

    End Sub
    Private Sub Backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backbtn.Click
        'When the Back button is clicked, the Homepage form is opened and the Personal Details form is closed
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub Savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Savebtn.Click
        'If all the characters entered into the First Name textbox are not letters, the textbox is set to Null and a Character Error messagebox pops up
        If Char.IsLetter(FirstNametxt.Text) = False Then
            FirstNametxt.Text = vbNullString
            MessageBox.Show("Your firstname must contain only letters", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if all the characters entered into the Surname textbox are not letters, the textbox is set to Null and a Character Error messagebox pops up
        ElseIf Char.IsLetter(Surnametxt.Text) = False Then
            Surnametxt.Text = vbNullString
            MessageBox.Show("Your surname must contain only letters", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if all the characters entered into the Height textbox are not numers, the textbox is set to Null and a Character Error messagebox pops up
        ElseIf IsNumeric(Heighttxt.Text) = False Then
            Heighttxt.Text = vbNullString
            MessageBox.Show("Your height must contain only numbers", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if all the characters entered into the Weight textbox are not numers, the textbox is set to Null and a Character Error messagebox pops up
        ElseIf IsNumeric(Weighttxt.Text) = False Then
            Weighttxt.Text = vbNullString
            MessageBox.Show("Your weight must contain only numbers", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Otherwise if the First Name textbox equals Null, the First Name column in the Dataset where the row number is equal to the CurrentRowNow, is set to Nothing
        ElseIf FirstNametxt.Text = "" Then
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("First_Name") = Nothing
            'Otherwise if the Surname textbox equals Null, the Surname column in the Dataset where the row number is equal to the CurrentRowNow, is set to Nothing
        ElseIf Surnametxt.Text = "" Then
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Surname") = Nothing
            'Otherwise if the Gender combobox equals Null, the Gender column in the Dataset where the row number is equal to the CurrentRowNow, is set to Nothing
        ElseIf Gendercbo.Text = "" Then
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Gender") = Nothing

            'Otherwise if the Email textbox is equal to Null, a Missing Information messagebox pops up
        ElseIf Emailtxt.Text = "" Then
            MessageBox.Show("You must enter your email", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if the Date of Birth picker is equal to Null, a Missing Information messagebox pops up
        ElseIf DOBPicker.Text = "" Then
            MessageBox.Show("You must enter your date of birth", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if the Height textbox is equal to Null, a Missing Information messagebox pops up
        ElseIf Heighttxt.Text = "" Then
            MessageBox.Show("You must enter your height", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if the Weight textbox is equal to Null, a Missing Information messagebox pops up
        ElseIf Weighttxt.Text = "" Then
            MessageBox.Show("You must enter your weight", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Otherwise all of the columns linking to the Personal Details form, in the Personal Details table where the row number is equal to the CurrentRowNo are set to equal their
            'appropriate textbox, date picker or combobox
        Else

            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("First_Name") = FirstNametxt.Text
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Surname") = Surnametxt.Text
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Email") = Emailtxt.Text
            'dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Date_Of_Birth") = DOBtxt.Text
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Date_Of_Birth") = DOBPicker.Text
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Gender") = Gendercbo.Text.Substring(0, 1)
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Height_ft") = CInt(Heighttxt.Text)
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Weight_kg") = CInt(Weighttxt.Text)
            'Dataadapter is updated with all the records in the Dataset
            dtaadpPdet.Update(dtasetAppDatabase, "tblPersonal_Details")
            'AddRecord variable is set to false
            AddRecord = False
            'Save Updates messagebox pops up
            MessageBox.Show("The updates have been saved to disk.", "Save Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)


            'All of the textboxes, date picker and combobox become disabled.
            FirstNametxt.Enabled = False
            Surnametxt.Enabled = False
            Emailtxt.Enabled = False
            DOBPicker.Enabled = False
            Gendercbo.Enabled = False
            Weighttxt.Enabled = False
            Heighttxt.Enabled = False
            'Save and Cancel button become invisible
            Savebtn.Visible = False
            Cancelbtn2.Visible = False
            'Security Settings button becomes visible
            SecuritySettingsbtn.Visible = True
            'Back and Edit button become invisible
            Backbtn.Visible = True
            Editbtn.Visible = True
        End If

    End Sub


    Private Sub Cancelbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelbtn2.Click
        'When the cancel button is clicked, declare the variable Answer as DialogResult
        Dim Answer As DialogResult
        'Initialize the variable Answer to the messagebox asking whether the user wants to cancel their updates or not
        Answer = MessageBox.Show("Are you sure you want to cancel the updates made?", "Cancel Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If the answer is yes, all of the textboxes are set to Null and the Gender comboxbox is set to -1
        If Answer = Windows.Forms.DialogResult.Yes Then
            FirstNametxt.Text = ""
            Surnametxt.Text = ""
            Emailtxt.Text = ""
            'DOBtxt.Text = ""
            DOBPicker.Text = ""
            Gendercbo.SelectedIndex = -1
            Weighttxt.Text = ""
            Heighttxt.Text = ""

            'The First Name, Surname, Email, Date of Birth picker, Gender combobox, Weight and Height textboxes are set to disabled
            FirstNametxt.Enabled = False
            Surnametxt.Enabled = False
            Emailtxt.Enabled = False
            'DOBtxt.Enabled = False
            DOBPicker.Enabled = False
            Gendercbo.Enabled = False
            Weighttxt.Enabled = False
            Heighttxt.Enabled = False
            'Save button becomes invisible
            Savebtn.Visible = False
            'Edit button becomes visible
            Editbtn.Visible = True
            'Cancel button becomes invisible
            Cancelbtn2.Visible = False
            'Back button becomes visible
            Backbtn.Visible = True
            'Update Security Details button becomes visible
            SecuritySettingsbtn.Visible = True
            DisplayAccount()
        End If

    End Sub
    Private Sub SecuritySettingsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecuritySettingsbtn.Click
        'When the Security Settings button is clicked, the Security Details Update form opens and the Personal Details form closes 
        PasswordChange.Show()
        Me.Close()
    End Sub
End Class

