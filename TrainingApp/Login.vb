'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb
Public Class Login
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'DataAdapter Selects all from the Personal_Details table and orders them by their Runner_ID
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details ORDER BY Runner_ID"
        'Fills the dataset with the the records selected from the Personal_Details table which are currently in the DataAdapter
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")
    End Sub
    Private Sub Loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loginbtn.Click
        'If either the ID or Password text box contain nothing, show an authentication error messagebox
        If IDtxt.Text = "" Or Passtxt.Text = "" Then
            MessageBox.Show("Athlete ID Or Password Empty", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Otherwise if the ID text box does not contain only numbers, set it to equal/contain nothing and show a character error messagebox
        ElseIf IsNumeric(IDtxt.Text) = False Then
            IDtxt.Text = vbNullString
            MessageBox.Show("Your ID must contain only numbers", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Otherwise declare both the Runner_ID and Athlete_Pass to the string datatype
        Else
            Dim Runner_ID As String
            Dim Athlete_Pass As String


            'Initializes the Runner_ID to equal the ID textbox and then convert it to decimal, as well as initialize Athlete_Pass to equal the pass textbox
            Runner_ID = Convert.ToDecimal(IDtxt.Text)
            Athlete_Pass = Passtxt.Text

            'Select all the records from the Personal_Details table where the Runner_ID in the table equals the ID entered in the text box
            'As well as the Athlete_Pass matching the Athlete pass entered
            dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = " & Runner_ID & " AND Athlete_pass = '" & Athlete_Pass & "'"
            'Clear the dataset to make sure that it contains nothing
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Fill the dataset with the records selected
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

            'If the dataset row equals 0 (ID and password match no record from the database table_ display a User Incorrect Login messagebox
            'Also clear both the ID and Pass textboxes
            If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count = 0 Then
                MessageBox.Show("Runner ID Or Password Incorrect", "User Incorrect Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Passtxt.Text = ""
                IDtxt.Text = ""

                'Otherwise the ID declared in the SharedVariables module is set to equal the Runner_ID, as well as opening the homepage form and closing the login form
            Else
                ID = Runner_ID
                Homepage.Show()
                Me.Hide()
            End If
        End If

        'Clears both the ID and Pass textboxes, so no information is visible if the user clicks the logout button from the homepage
        IDtxt.Text = ""
        Passtxt.Text = ""
    End Sub
    Private Sub ForgotPass_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ForgotPassbtn.LinkClicked

        'When the ForgotPassword button is pressed, the Passwordreset form is displayed and the Login form is closed
        PasswordReset.Show()
        Me.Close()
    End Sub

    Private Sub User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles User.Click

        'When the Create New User button is pressed, the NewUser form is displayed and the Login form is closed
        NewUser.Show()
        Me.Close()
    End Sub
End Class