'Imports the database connection library 
Imports System.Data
Imports System.Data.OleDb
'Imports the email library 
Imports System.Net.Mail
Imports System.IO
Public Class PasswordReset
    'Declares the CurrentRowNo to the datatype Integer, which equals -1
    Dim CurrentRowNo As Integer = -1
    'Declares AddRecord as the Boolean datatype (True or False), and sets it to false
    Dim AddRecord As Boolean = False
    'Declares the CaptchaAnswer as a string
    Dim CaptchaAnswer As String '= RandString(5, False)
    'Declares the email entered by the user (UserEmail) as a string
    Dim UserEmail As String
    'Declares the Random Pass generated (RandPass) as Random 
    Dim RandPass As New Random()
    Private Sub generateLines(ByVal G As Graphics)

        If Not G Is Nothing Then
            'Declares the variable R as Random
            Dim R As New Random()
            'Declares the variable LineBrush as the datatype used for drawing the randomly generated lines (SolidBrush)
            Dim lineBrush As New SolidBrush(Color.LightGray)

            'The code used for drawing the randomly generated lines which are used for the Captcha test
            For i% = 0 To 9
                G.DrawLines(New Pen(lineBrush, R.Next(1, 2)), New Point() {New Point(0, R.Next(0, 60)), New Point(200, R.Next(0, 60))})
            Next

        End If
    End Sub
    Private Function FinalCaptchaImage() As Image
        'Declares the variable as the Bitmap datatype, with the dimensions of 200x60
        Dim B As New Bitmap(200, 60)
        'Initializes the Variable G as the datatype Graphics and lets it equal to the image generated using the variable B
        Using G As Graphics = Graphics.FromImage(B)
            With G
                .Clear(Color.White)
                'Code used for the randomly generated string of characters
                .DrawString(RandString(5, False), New Font("Segoe UI", 20), Brushes.Black, New Rectangle(0, 0, 200, 60), New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End With
            'Generates the final Captcha image using the variable G, this includes both the string of randomly generated characters and lines
            generateLines(G)
        End Using
        Return B
    End Function


    Public Function RandString(ByRef len As Integer, ByRef upper As Boolean) As String
        'Declares the variable RandPass as Random
        Dim RandPass As New Random()
        'Declares the variable allowableChars as char which includes all of the characters the new password is able to contain
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyz".ToCharArray()
        'Declares the final password as string which is empty
        Dim FinalPass As String = String.Empty
        'Loop/counter which generates the final password depending on the number of times it needs to repeat
        For i As Integer = 0 To len - 1
            FinalPass += allowableChars(RandPass.Next(allowableChars.Length - 1))
        Next
        'Returns the final password which has been generated
        Return IIf(upper, FinalPass.ToUpper(), FinalPass)
    End Function
    Public Function RandStringCaptcha(ByRef len As Integer, ByRef upper As Boolean) As String
        'Declares the variable RandCaptcha as a Random
        Dim RandCaptcha As New Random()
        'Declares the variable allowableChars as char which includes all of the characters the new Captcha string is able to contain
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyz".ToCharArray()
        'Declares the final Captcha as string which is empty
        Dim FinalCaptcha As String = String.Empty
        'Loop/counter which generates the final Captcha depending on the number of times it needs to repeat
        For i As Integer = 0 To len - 1
            FinalCaptcha += allowableChars(RandCaptcha.Next(allowableChars.Length - 1))
        Next
        'Returns the final Captcha which has been generated
        Return IIf(upper, FinalCaptcha.ToUpper(), FinalCaptcha)
    End Function

    Private Sub PasswordReset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connects to the SharedVariables Module
        Connect()
        'Initializes the variable dtaadpPdet to equal a new OleDbCommand
        dtaadpPdet.SelectCommand = New OleDbCommand
        dtaadpPdet.SelectCommand.Connection = conAppDatabase
        'DataAdapter Selects all from the Personal_Details table, where their Runner_ID is equal to 0
        dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = 0"
        'Fills the dataset with the the records selected from the Personal_Details table which are currently in the DataAdapter
        dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")
        'Sets the Captcha image to equal the finaly Captcha image which is generated
        CaptchaImg.Image = FinalCaptchaImage()
        'Initializes the Captcha answer as the RandStringCaptcha of 5 characters, which was previously generated
        CaptchaAnswer = RandStringCaptcha(5, False)
    End Sub

    Private Sub ResetPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPass.Click
        'If the ID or Security Question answer are Null, display a Missing Information messagebox
        If IDtxt2.Text = "" Or SecurityQuestiontxt.Text = "" Then
            MessageBox.Show("Both your ID and security question answer has to be entered", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Otherwise if the ID entered does not only contain numbers, reset the text box to equal NULL and display a Character Error messagebox
        ElseIf Not IsNumeric(IDtxt2.Text) Then
            IDtxt2.Text = vbNullString
            MessageBox.Show("Your ID must contain only numbers", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if the Security Question text box does not contain only letters, display the Character Error messagebox
        ElseIf Char.IsLetter(SecurityQuestiontxt.Text) = False Then
            SecurityQuestiontxt.Text = vbNullString
            MessageBox.Show("Your answer to the security question must contain only letters", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if the Captcha answer does not equal only letters, reset the text box to equal NULL and display a Character Error messagebox
        ElseIf Char.IsLetter(SecurityChecktxt.Text) = False Then
            SecurityChecktxt.Text = vbNullString
            MessageBox.Show("The CAPTCHA answer must contain only letters", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Otherwise if the Captcha answer text box equals NULL, display an Incorrect CAPTCHA Code messagebox and generate a new Captcha image
        ElseIf SecurityChecktxt.Text = "" Then
            MessageBox.Show("Make sure a CAPTCHA has been entered", "Incorrect CAPTCHA Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CaptchaImg.Image = FinalCaptchaImage()
            'Otherwise initialize the ID variable to equal the ID entered in the ID textbox
        Else
            ID = IDtxt2.Text
            'Declare the Runner_ID as string
            Dim Runner_ID As String
            'Declare the Security Question answer as string
            Dim SecurityQuest As String
            'Initializes the string Runner_ID to the ID text box which is then converted to a decimal
            Runner_ID = Convert.ToDecimal(IDtxt2.Text)
            'Initialize the Security Question answer to equal the appropriate textbox
            SecurityQuest = SecurityQuestiontxt.Text
            'DataAdapter Selects all from the Personal_Details table, where their Runner_ID is equal to the Runner_ID variable
            'And Security_Question is equal to the SecurityQuest variable
            dtaadpPdet.SelectCommand.CommandText = "SELECT * FROM Personal_Details WHERE Runner_ID = " & Runner_ID & " AND Security_Question = '" & SecurityQuest & "'"
            'Clears the Dataset
            dtasetAppDatabase.Tables("tblPersonal_Details").Clear()
            'Fills the DataAdapter
            dtaadpPdet.Fill(dtasetAppDatabase, "tblPersonal_Details")

            'If the Dataset row is equal to 0, then show an Incorrect Information messagebox, set the ID text box to equal NULL
            'Set the Security Question textbox to equal NULL and generate a new Captcha image
            If dtasetAppDatabase.Tables("tblPersonal_Details").Rows.Count = 0 Then
                MessageBox.Show("ID or Security Question incorrect", "Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                IDtxt2.Text = ""
                SecurityQuestiontxt.Text = ""
                CaptchaImg.Image = FinalCaptchaImage()
                'Otherwise select the appropriate case
            Else
                Select Case SecurityChecktxt.Text
                    'If the Captcha answer entered matches the one generated, set the CurrentRowNo to equal 0
                    Case Is = CaptchaAnswer
                        CurrentRowNo = 0
                        'Set the Athlete_Pass of the current row in the dataset to equal the randomly generated 5 character password
                        dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Athlete_Pass") = RandString(5, False)
                        'Updates the DataAdapter
                        dtaadpPdet.Update(dtasetAppDatabase, "tblPersonal_Details")
                        'Sets the AddRecord variable to false
                        AddRecord = False

                        'Declares the variable Answer as a messagebox answer (DialogResult)
                        Dim Answer As DialogResult
                        'Sets the variable answer to equal the messagebox
                        Answer = MessageBox.Show("Is your computer currently online?", "Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        'If the messagebox answer is yes, set the variable UserEmail to equal the email matched to the Runner_ID
                        If Answer = Windows.Forms.DialogResult.Yes Then
                            UserEmail = dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Email")

                            'Declares the variable MyMailMessage
                            Dim MyMailMessage As New MailMessage
                            Try
                                'Sets the email in which the email is sent from
                                MyMailMessage.From() = New MailAddress("athletetrackerapp@gmail.com")
                                'Sets the email which the program sends the email to, to equal the variable UserEmail
                                MyMailMessage.To.Add(UserEmail)
                                'Sets the subject of the email to Password Reset
                                MyMailMessage.Subject = "Password Reset"
                                'Sets the body of the message to equal a string of text with the new generated password, through concatenation
                                MyMailMessage.Body = ("The password for your AthleteTracker account was reset" & Environment.NewLine & Environment.NewLine & "New Password: " & dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Athlete_Pass") & Environment.NewLine & Environment.NewLine & "Once logged in you should navigate to the personal details page, then goto the 'Update Your Security Details' page. From here you will be able to change your password to something more memorable")
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
                            'Displays a New Password messagebox
                            MessageBox.Show("Your new password has been sent to the email you've entered", "New Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Otherwise if the answer clicked within the messagebox was no, display a messagebox containing the new generated password
                        ElseIf Answer = Windows.Forms.DialogResult.No Then
                            MessageBox.Show("Your new password is: " & dtasetAppDatabase.Tables("tblPersonal_Details").Rows(CurrentRowNo)("Athlete_Pass"), "New Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        'Opens the Login form
                        Login.Show()
                        'Closes the PasswordReset form
                        Me.Close()

                        'Otherwise display an Incorrect CAPTCHA Code messagebox, generate a new Captcha image and set the Captcha answer textbox to NULL
                    Case Else
                        MessageBox.Show("The CAPTCHA code entered was incorrect", "Incorrect CAPTCHA Code", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        CaptchaImg.Image = FinalCaptchaImage()
                        SecurityChecktxt.Text = ""
                End Select
            End If
        End If
    End Sub
    Private Sub RefreshCaptchabtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshCaptchabtn.Click
        'When the refresh button is clicked, generate a new image and set the Captcha answer textbox to null
        CaptchaImg.Image = FinalCaptchaImage()
        SecurityChecktxt.Text = ""
    End Sub

    Private Sub Backbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backbtn2.Click
        'When the backbutton is clicked, show the Login form and close the Password resert form
        Login.Show()
        Me.Close()
    End Sub
End Class