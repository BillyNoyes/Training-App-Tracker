'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb
Public Class PasswordChange
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False
    Private Sub PasswordChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'DataAdapter selects all from the Personal_Details table in the database and orders the records by the Runner_ID
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details ORDER BY Runner_ID"
        'Fills the Dataadapter with the records selected from the Personal_Details table which are currently in the Dataset
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

        'Runs the DisplayAccount Private Sub
        DisplayAccount()

    End Sub
    Private Sub DisplayAccount()
        'Initializes the variable CurrentRowNo as 0
        CurrentRowNo = 0
        'If the number of rows in the dataset are greater than 0, the Security Question textbox is set to the Security_Question column in the Personal_Details table where the row is equal to the CurrentRowNo
        If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count > 0 Then
            SecurityQuestiontxt.Text = RTrim(dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Item("Security_Question").ToString)
            'Otherwise the Security Question textbox is set to Nothing
        Else
            SecurityQuestiontxt.Text = Nothing
        End If
    End Sub
    Private Sub Backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backbtn.Click
        'When the back button is clicked, declare the variable Answer as DialogResult
        Dim Answer As DialogResult
        'Initialize the variable Answer to the messagebox asking whether the user wants to cancel the updates made
        Answer = MessageBox.Show("Are you sure you want to cancel the updates made?", "Cancel Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If the answer is yes, shows the Personal Details form and close the Security Details Update form
        If Answer = Windows.Forms.DialogResult.Yes Then
            Personal_Details.Show()
            Me.Close()
        End If
    End Sub
    Private Sub PassChangebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassChangebtn.Click
        'If the either Password textbox is equal to Null, an Authentication Error messagebox pops up
        If Passtxt1.Text = "" Or Passtxt2.Text = "" Then
            MessageBox.Show("Please type your password into both text boxes", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise if both Password textboxes don't match, another Authentication Error messagebox pops up
        ElseIf Passtxt1.Text <> Passtxt2.Text Then
            MessageBox.Show("Both passwords entered do not match", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Passtxt3.Text = "" Then
            MessageBox.Show("Please type your new password into the text box", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise If the length of the new password textbox is less than 5 characters long, display a password length error messagebox 
        ElseIf Len(Passtxt3.Text) < 5 Then
            MessageBox.Show("The new password entered is too short, must be greater than 5 characters long", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise If the length of the new password textbox is greater than 20 characters long, display a password length error messagebox 
        ElseIf Len(Passtxt3.Text) > 20 Then
            MessageBox.Show("The new password entered is too long, must be less than 20 characters long", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise both the Runner_ID and Athlete_Pass variables are declared as String
        Else
            Dim Runner_ID As String
            Dim Athlete_Pass As String

            'Runner_ID is initialized to equal the ID which is converted to a decimal
            Runner_ID = Convert.ToDecimal(ID)

            'Athlete_Pass is initialized to equal to the first Password textbox
            Athlete_Pass = Passtxt1.Text

            'Dataadapter selects all the records from the Personal Details table where the Runner_ID is equal to the Runner_ID variable and the Athlete_Pass is equal to the Athlete_Pass variable
            dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = " & Runner_ID & " AND Athlete_Pass = '" & Athlete_Pass & "'"

            'Dataset is cleared
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()

            'Dataadapter is filled with all the records from the Dataset
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

            'If the number of rows in the Dataset is equal to 0, a Password Wrong messagebox pops up and both Password textboxes are set to Null
            If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count = 0 Then
                MessageBox.Show("The passwords entered do not match your ID", "Password Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Passtxt1.Text = ""
                Passtxt2.Text = ""
                'Otherwise the CurrentRowNo is set to equal 0 and the ID variable is set to equal the Runner_ID variable
            Else
                CurrentRowNo = 0
                ID = Runner_ID

                'The Athlete_Pass column with the row set to the CurrentRowNo in the Dataset is set to equal the third Password textbox (the new Password textbox)
                dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Athlete_Pass") = Passtxt3.Text
                'The Dataadapter is updated with the records from the Dataset
                dtaadpPdet.Update(dtasetAppDatabase, "tblPersonal_Details")
                'The AddRecord variable is set to false
                AddRecord = False
                'A Save Updates messagebox is shown which includes the password stored in the Athlete_Pass column of the Dataset on the row which is equal to the CurrentRowNo 
                MessageBox.Show("Your new password is: " & dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Athlete_Pass"), "Saved Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Personal Details form is opened and the Security Details Update form is closed
                Personal_Details.Show()
                Me.Close()
            End If
        End If
        'All Password textboxes are set to Null
        Passtxt1.Text = ""
        Passtxt2.Text = ""
        Passtxt3.Text = ""
    End Sub
    Private Sub SecurityQuestChangebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecurityQuestChangebtn.Click
        'If the either Password textbox is equal to Null, an Authentication Error messagebox pops up
        If Passtxt4.Text = "" Or Passtxt5.Text = "" Then
            MessageBox.Show("Please type your password into both text boxes", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise if the Security Question answer textbox equals Null, an authentication error messagebox pops up
        ElseIf SecurityQuestiontxt.Text = "" Then
            MessageBox.Show("Please type your new security question into the text box", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise if the password textbox doesn't contain only letters, display a character error messagebox
        ElseIf Char.IsLetter(Passtxt4.Text) = False Then
            MessageBox.Show("Your password must contain only letters", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if the Security Question answer textbox doesn't contain only letters, display a character error messagebox
        ElseIf Char.IsLetter(SecurityQuestiontxt.Text) = False Then
            MessageBox.Show("Your new security question answer must contain only letters", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if both Password textboxes don't match, another Authentication Error messagebox pops up
        ElseIf Passtxt4.Text <> Passtxt5.Text Then
            MessageBox.Show("Both passwords entered do not match", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise both the Runner_ID and Athlete_Pass variables are declared as String
        Else
            Dim Runner_ID As String
            Dim Athlete_Pass As String

            'Runner_ID is initialized to equal the ID which is converted to a decimal
            Runner_ID = Convert.ToDecimal(ID)

            'Athlete_Pass is initialized to equal to the Password textbox
            Athlete_Pass = Passtxt4.Text

            'Dataadapter selects all the records from the Personal Details table where the Runner_ID is equal to the Runner_ID variable and the Athlete_Pass is equal to the Athlete_Pass variable
            dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = " & Runner_ID & " AND Athlete_Pass = '" & Athlete_Pass & "'"
            'Dataset is cleared
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Dataadapter is filled with all the records from the Dataset
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

            'If the number of rows in the Dataset is equal to 0, a Password Wrong messagebox pops up and both Password textboxes are set to Null
            If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count = 0 Then
                MessageBox.Show("The passwords entered do not match your ID", "Password Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Passtxt4.Text = ""
                Passtxt5.Text = ""
                'Otherwise the CurrentRowNo is set to equal 0 and the ID variable is set to equal the Runner_ID variable
            Else
                CurrentRowNo = 0
                ID = Runner_ID
                'The Security_Question column with the row set to the CurrentRowNo in the Dataset is set to equal the Security Question Answer textbox (the new Security Question Answer textbox)
                dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Security_Question") = SecurityQuestiontxt.Text
                'The Dataadapter is updated with the records from the Dataset
                dtaadpPdet.Update(dtasetAppDatabase, "tblPersonal_Details")
                'The AddRecord variable is set to false
                AddRecord = False
                'A Save Updates messagebox is shown which includes the password stored in the Athlete_Pass column of the Dataset on the row which is equal to the CurrentRowNo 
                MessageBox.Show("Your new security question answer is: " & dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Security_Question"), "Saved Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'The Security Question Answer textboxes is disabled
                SecurityQuestiontxt.Enabled = False
            End If
        End If
        'Both Password textboxes are set to Null
        Passtxt4.Text = ""
        Passtxt5.Text = ""
    End Sub
    Private Sub Editbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editbtn.Click
        'When the Edit button is clicked, the Security Question Answer textbox is enabled
        SecurityQuestiontxt.Enabled = True
        Editbtn.Visible = False

    End Sub

    Private Sub DelAccountbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelAccountbtn.Click
        'If the either Password textbox is equal to Null, an Authentication Error messagebox pops up
        If Passtxt6.Text = "" Or Passtxt7.Text = "" Then
            MessageBox.Show("Please type your password into both text boxes", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise if both Password textboxes don't match, another Authentication Error messagebox pops up
        ElseIf Passtxt6.Text <> Passtxt7.Text Then
            MessageBox.Show("Both passwords entered do not match", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise both the Runner_ID and Athlete_Pass variables are declared as String
        Else
            Dim Runner_ID As String
            Dim Password As String

            'Runner_ID is initialized to equal the ID 
            Runner_ID = ID
            'Password variable is initialized to equal to the Password textbox
            Password = Passtxt6.Text

            'Dataadapter selects all the records from the Personal Details table where the Runner_ID is equal to the Runner_ID variable and the Athlete_Pass is equal to the Athlete_Pass variable
            dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = " & ID & " AND Athlete_Pass = '" & Password & "'"
            'Dataset is cleared
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Dataadapter is filled with all the records from the Dataset
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

            'If the number of rows in the Dataset is equal to 0, a Password Wrong messagebox pops up and both Password textboxes are set to Null
            If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count = 0 Then
                MessageBox.Show("The passwords entered do not match your ID", "Password Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Passtxt6.Text = ""
                Passtxt7.Text = ""
                'Otherwise the CurrentRowNo is set to equal 0 and the ID variable is set to equal the Runner_ID variable
            Else
                CurrentRowNo = 0
                ID = Runner_ID
                'When the cancel button is clicked, declare the variable Answer as DialogResult
                Dim Answer As DialogResult
                'Initialize the variable Answer to the messagebox asking whether the user wants to deactivate their account
                Answer = MessageBox.Show("Are you sure you want to deactivate your account? Deactivation is not reversible", "Deactivate account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'If the answer is yes, all the records in the Dataset where the row is equal to CurrentRowNo is deleted
                If Answer = Windows.Forms.DialogResult.Yes Then
                    dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo).Delete()
                    'The Dataadapter is updated with all the records in the Dataset
                    dtaadpPdet.Update(dtasetAppDatabase, "tblPersonal_Details")
                    'Account Deactivated messagebox pops up
                    MessageBox.Show("Your account has been deactivated", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'The login form is opened and the Security Details Update form is closed
                    Login.Show()
                    Me.Close()
                End If
            End If
        End If
        Passtxt6.Text = ""
        Passtxt7.Text = ""
    End Sub
End Class