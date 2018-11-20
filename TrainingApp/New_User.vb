'Imports the database connection library, as well as the email library
Imports System.Data
Imports System.Data.OleDb
'Imports the email library 
Imports System.Net.Mail
Imports System.IO

Public Class NewUser
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False

    Private Sub NewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'DataAdapter selects all from the Personal_Details table where the Runner_ID is equal to 0
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = 0"
        'Fills the dataset with the records selected from the Personal_Details table which are currently in the DataAdapter
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")
    End Sub
    Private Sub NewUserbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewUserbtn.Click
        'Runner_ID = Convert.ToDecimal(IDtxt.Text)

        'If the email textbox contains no information, dislay a missing information messagebox
        If RegisterEmailtxt.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Otherwise If the first password textbox contains no information, dislay a missing information messagebox
        ElseIf RegisterPass1txt.Text = "" Or RegisterPass2txt.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Otherwise If the security question textbox contains no information, dislay a missing information messagebox
        ElseIf SecurityQuestiontxt.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Otherwise If both the password textboxes don't contain the same information (don't equal to each other), display a authentication error messagebox
        ElseIf RegisterPass2txt.Text <> RegisterPass1txt.Text Then
            MessageBox.Show("Please make sure that both passwords match", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Otherwise If the length of the second password textbox is less than 5 characters long, display a password length error messagebox 
        ElseIf Len(RegisterPass2txt.Text) < 5 Then
            MessageBox.Show("The password entered is too short, must be greater than 5 characters long", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Otherwise If the length of the second password textbox is greater than 20 characters long, display a password length error messagebox 
        ElseIf Len(RegisterPass2txt.Text) > 20 Then
            MessageBox.Show("The password entered is too long, must be less than 20 characters long", "Password Length Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Otherwise run through this section of code
        Else
            'Clear the dataset
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Create a new row in the DataSet containing 7 blank fields, as well as the password, email and security question answer entered
            'These will be stored in the order which they are in the Database table (Nothing, Password, Email, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, SecurityQuestionAnswer)
            dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Add(Nothing, RegisterPass1txt.Text, RegisterEmailtxt.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, SecurityQuestiontxt.Text)
            'Set the CurrentRowNo to equal 0
            CurrentRowNo = 0
            'Update the DataAdapter with the records stored in the DataSet
            dtaadpPdet.Update(dtasetAppDatabase, "tblPersonal_Details")
            'DataAdapter selects the top 1 record from the Personal_Details table and orders them by descending Runner_ID
            'Meaning that the new user will have the largest ID and is therefore at the top of the DataAdpter/will be the top 1 record
            dtaadpPdet.SelectCommand.CommandText = "SELECT TOP 1 * FROM Personal_Details ORDER BY Runner_ID DESC"
            'Clears the DataSet to make sure that it contains nothing
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Fills the DataAdapter with the records in the DataSet
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")
            'Sets the AddRecord to equal True
            AddRecord = True
            'DisplayAccount()
            'MessageBox.Show("The ID you will use for logging in is: " & dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Runner_ID") & ", You will have to use both the ID and the password you just created ", "Save Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("You will shortly be sent an email with the details required for logging in", "Save Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Declares the variable MyMailMessage
            Dim MyMailMessage As New MailMessage
            Try
                'Sets the email in which the email is sent from
                MyMailMessage.From() = New MailAddress("athletetrackerapp@gmail.com")
                'Sets the email which the program sends the email to, to equal the variable UserEmail
                MyMailMessage.To.Add(RegisterEmailtxt.Text)
                'Sets the subject of the email to Account Details
                MyMailMessage.Subject = "Account Details"
                'Sets the body of the message to equal a string of text with the user's ID and Password, through concatenation
                MyMailMessage.Body = ("You recently signed up for AthleteTracker" & Environment.NewLine & Environment.NewLine & "ID: " & dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Runner_ID") & Environment.NewLine & Environment.NewLine & "Password: " & dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Athlete_Pass"))
                'Declares the variable SMTP as the SmtpClient for Gmail
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                'Sets the port to 25
                SMTP.Port = 25
                'Enables Ssl (Secure Sockets Layer)
                SMTP.EnableSsl = True
                'Sets the credentials in which the program can access the server and send from the specific email given by the developer
                SMTP.Credentials = New System.Net.NetworkCredential("athletetrackerapp@gmail.com", "BillyNoyes123")
                'Sends the message under the variable MyMailMessage
                SMTP.Send(MyMailMessage)

            Catch ex As Exception

            End Try

            'Shows the Login form and closes the New User form
            Login.Show()
            Me.Close()

            'Initializes the variable ID to equal the Runner_ID of the CurrentRowNo in the DataSet
            ID = dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Runner_ID")
        End If





    End Sub
    Private Sub Cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelbtn.Click
        'When the cancel button is clicked, declare the variable Answer as DialogResult
        Dim Answer As DialogResult
        'Initialize the variable Answer to the messagebox asking whether the user wants to cancel creating the new account or not
        Answer = MessageBox.Show("Are you sure you want to cancel creating this account?", "Cancel Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If the answer is yes, shows the Login form and close the New User form
        If Answer = Windows.Forms.DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
        'If the variable AddRecord equals true, show the Cancel Updates Messagebox
        If AddRecord = True Then
            MessageBox.Show("Please click the Save button to save the record.", "Cancel Updates", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class