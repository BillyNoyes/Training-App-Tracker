<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordChange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordChange))
        Me.PassChangebtn = New System.Windows.Forms.Button
        Me.Passlbl1 = New System.Windows.Forms.Label
        Me.Passtxt1 = New System.Windows.Forms.TextBox
        Me.Passtxt2 = New System.Windows.Forms.TextBox
        Me.Passlbl2 = New System.Windows.Forms.Label
        Me.Backbtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Passtxt3 = New System.Windows.Forms.TextBox
        Me.PasswordGBox = New System.Windows.Forms.GroupBox
        Me.SecurityQuestChangebtn = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SecurityQuestGBox = New System.Windows.Forms.GroupBox
        Me.Editbtn = New System.Windows.Forms.Button
        Me.SecurityQuestiontxt = New System.Windows.Forms.TextBox
        Me.SecurityQuestionlbl = New System.Windows.Forms.Label
        Me.Passtxt4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Passtxt5 = New System.Windows.Forms.TextBox
        Me.AccountDelGBox = New System.Windows.Forms.GroupBox
        Me.DelAccountbtn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Passtxt6 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Passtxt7 = New System.Windows.Forms.TextBox
        Me.PasswordGBox.SuspendLayout()
        Me.SecurityQuestGBox.SuspendLayout()
        Me.AccountDelGBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PassChangebtn
        '
        Me.PassChangebtn.Location = New System.Drawing.Point(91, 122)
        Me.PassChangebtn.Name = "PassChangebtn"
        Me.PassChangebtn.Size = New System.Drawing.Size(75, 36)
        Me.PassChangebtn.TabIndex = 0
        Me.PassChangebtn.Text = "Change Password"
        Me.PassChangebtn.UseVisualStyleBackColor = True
        '
        'Passlbl1
        '
        Me.Passlbl1.AutoSize = True
        Me.Passlbl1.Location = New System.Drawing.Point(7, 21)
        Me.Passlbl1.Name = "Passlbl1"
        Me.Passlbl1.Size = New System.Drawing.Size(53, 13)
        Me.Passlbl1.TabIndex = 1
        Me.Passlbl1.Text = "Password"
        '
        'Passtxt1
        '
        Me.Passtxt1.Location = New System.Drawing.Point(66, 18)
        Me.Passtxt1.Name = "Passtxt1"
        Me.Passtxt1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt1.Size = New System.Drawing.Size(100, 20)
        Me.Passtxt1.TabIndex = 2
        '
        'Passtxt2
        '
        Me.Passtxt2.Location = New System.Drawing.Point(66, 53)
        Me.Passtxt2.Name = "Passtxt2"
        Me.Passtxt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt2.Size = New System.Drawing.Size(100, 20)
        Me.Passtxt2.TabIndex = 3
        '
        'Passlbl2
        '
        Me.Passlbl2.AutoSize = True
        Me.Passlbl2.Location = New System.Drawing.Point(7, 47)
        Me.Passlbl2.Name = "Passlbl2"
        Me.Passlbl2.Size = New System.Drawing.Size(53, 26)
        Me.Passlbl2.TabIndex = 4
        Me.Passlbl2.Text = "Re-enter " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'Backbtn
        '
        Me.Backbtn.Location = New System.Drawing.Point(12, 12)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(75, 23)
        Me.Backbtn.TabIndex = 14
        Me.Backbtn.Text = "<"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'Passtxt3
        '
        Me.Passtxt3.Location = New System.Drawing.Point(66, 91)
        Me.Passtxt3.Name = "Passtxt3"
        Me.Passtxt3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt3.Size = New System.Drawing.Size(100, 20)
        Me.Passtxt3.TabIndex = 15
        '
        'PasswordGBox
        '
        Me.PasswordGBox.Controls.Add(Me.Passtxt3)
        Me.PasswordGBox.Controls.Add(Me.Label1)
        Me.PasswordGBox.Controls.Add(Me.PassChangebtn)
        Me.PasswordGBox.Controls.Add(Me.Passlbl1)
        Me.PasswordGBox.Controls.Add(Me.Passtxt1)
        Me.PasswordGBox.Controls.Add(Me.Passlbl2)
        Me.PasswordGBox.Controls.Add(Me.Passtxt2)
        Me.PasswordGBox.Location = New System.Drawing.Point(12, 59)
        Me.PasswordGBox.Name = "PasswordGBox"
        Me.PasswordGBox.Size = New System.Drawing.Size(200, 168)
        Me.PasswordGBox.TabIndex = 17
        Me.PasswordGBox.TabStop = False
        Me.PasswordGBox.Text = "Password Change"
        '
        'SecurityQuestChangebtn
        '
        Me.SecurityQuestChangebtn.Location = New System.Drawing.Point(118, 135)
        Me.SecurityQuestChangebtn.Name = "SecurityQuestChangebtn"
        Me.SecurityQuestChangebtn.Size = New System.Drawing.Size(87, 67)
        Me.SecurityQuestChangebtn.TabIndex = 0
        Me.SecurityQuestChangebtn.Text = "Change Security Question Answer"
        Me.SecurityQuestChangebtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'SecurityQuestGBox
        '
        Me.SecurityQuestGBox.Controls.Add(Me.Editbtn)
        Me.SecurityQuestGBox.Controls.Add(Me.SecurityQuestiontxt)
        Me.SecurityQuestGBox.Controls.Add(Me.SecurityQuestionlbl)
        Me.SecurityQuestGBox.Controls.Add(Me.SecurityQuestChangebtn)
        Me.SecurityQuestGBox.Controls.Add(Me.Label3)
        Me.SecurityQuestGBox.Controls.Add(Me.Passtxt4)
        Me.SecurityQuestGBox.Controls.Add(Me.Label4)
        Me.SecurityQuestGBox.Controls.Add(Me.Passtxt5)
        Me.SecurityQuestGBox.Location = New System.Drawing.Point(238, 59)
        Me.SecurityQuestGBox.Name = "SecurityQuestGBox"
        Me.SecurityQuestGBox.Size = New System.Drawing.Size(223, 208)
        Me.SecurityQuestGBox.TabIndex = 18
        Me.SecurityQuestGBox.TabStop = False
        Me.SecurityQuestGBox.Text = "Security Question Change"
        '
        'Editbtn
        '
        Me.Editbtn.Location = New System.Drawing.Point(28, 149)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(75, 23)
        Me.Editbtn.TabIndex = 19
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'SecurityQuestiontxt
        '
        Me.SecurityQuestiontxt.Enabled = False
        Me.SecurityQuestiontxt.Location = New System.Drawing.Point(28, 110)
        Me.SecurityQuestiontxt.Name = "SecurityQuestiontxt"
        Me.SecurityQuestiontxt.Size = New System.Drawing.Size(177, 20)
        Me.SecurityQuestiontxt.TabIndex = 18
        '
        'SecurityQuestionlbl
        '
        Me.SecurityQuestionlbl.AutoSize = True
        Me.SecurityQuestionlbl.Location = New System.Drawing.Point(25, 85)
        Me.SecurityQuestionlbl.Name = "SecurityQuestionlbl"
        Me.SecurityQuestionlbl.Size = New System.Drawing.Size(180, 13)
        Me.SecurityQuestionlbl.TabIndex = 17
        Me.SecurityQuestionlbl.Text = "What is your mother's maiden name?"
        '
        'Passtxt4
        '
        Me.Passtxt4.Location = New System.Drawing.Point(66, 18)
        Me.Passtxt4.Name = "Passtxt4"
        Me.Passtxt4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt4.Size = New System.Drawing.Size(100, 20)
        Me.Passtxt4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Re-enter " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'Passtxt5
        '
        Me.Passtxt5.Location = New System.Drawing.Point(66, 53)
        Me.Passtxt5.Name = "Passtxt5"
        Me.Passtxt5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt5.Size = New System.Drawing.Size(100, 20)
        Me.Passtxt5.TabIndex = 3
        '
        'AccountDelGBox
        '
        Me.AccountDelGBox.Controls.Add(Me.DelAccountbtn)
        Me.AccountDelGBox.Controls.Add(Me.Label5)
        Me.AccountDelGBox.Controls.Add(Me.Passtxt6)
        Me.AccountDelGBox.Controls.Add(Me.Label6)
        Me.AccountDelGBox.Controls.Add(Me.Passtxt7)
        Me.AccountDelGBox.Location = New System.Drawing.Point(483, 63)
        Me.AccountDelGBox.Name = "AccountDelGBox"
        Me.AccountDelGBox.Size = New System.Drawing.Size(200, 135)
        Me.AccountDelGBox.TabIndex = 18
        Me.AccountDelGBox.TabStop = False
        Me.AccountDelGBox.Text = "Account Deactivation"
        '
        'DelAccountbtn
        '
        Me.DelAccountbtn.Location = New System.Drawing.Point(66, 87)
        Me.DelAccountbtn.Name = "DelAccountbtn"
        Me.DelAccountbtn.Size = New System.Drawing.Size(75, 36)
        Me.DelAccountbtn.TabIndex = 0
        Me.DelAccountbtn.Text = "Delete Account"
        Me.DelAccountbtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password"
        '
        'Passtxt6
        '
        Me.Passtxt6.Location = New System.Drawing.Point(66, 18)
        Me.Passtxt6.Name = "Passtxt6"
        Me.Passtxt6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt6.Size = New System.Drawing.Size(100, 20)
        Me.Passtxt6.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 26)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Re-enter " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'Passtxt7
        '
        Me.Passtxt7.Location = New System.Drawing.Point(66, 53)
        Me.Passtxt7.Name = "Passtxt7"
        Me.Passtxt7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt7.Size = New System.Drawing.Size(100, 20)
        Me.Passtxt7.TabIndex = 3
        '
        'PasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 279)
        Me.Controls.Add(Me.AccountDelGBox)
        Me.Controls.Add(Me.SecurityQuestGBox)
        Me.Controls.Add(Me.PasswordGBox)
        Me.Controls.Add(Me.Backbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PasswordChange"
        Me.Text = "Security Details "
        Me.PasswordGBox.ResumeLayout(False)
        Me.PasswordGBox.PerformLayout()
        Me.SecurityQuestGBox.ResumeLayout(False)
        Me.SecurityQuestGBox.PerformLayout()
        Me.AccountDelGBox.ResumeLayout(False)
        Me.AccountDelGBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PassChangebtn As System.Windows.Forms.Button
    Friend WithEvents Passlbl1 As System.Windows.Forms.Label
    Friend WithEvents Passtxt1 As System.Windows.Forms.TextBox
    Friend WithEvents Passtxt2 As System.Windows.Forms.TextBox
    Friend WithEvents Passlbl2 As System.Windows.Forms.Label
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Passtxt3 As System.Windows.Forms.TextBox
    Friend WithEvents PasswordGBox As System.Windows.Forms.GroupBox
    Friend WithEvents SecurityQuestGBox As System.Windows.Forms.GroupBox
    Friend WithEvents SecurityQuestChangebtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Passtxt4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Passtxt5 As System.Windows.Forms.TextBox
    Friend WithEvents SecurityQuestiontxt As System.Windows.Forms.TextBox
    Friend WithEvents SecurityQuestionlbl As System.Windows.Forms.Label
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents AccountDelGBox As System.Windows.Forms.GroupBox
    Friend WithEvents DelAccountbtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Passtxt6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Passtxt7 As System.Windows.Forms.TextBox
End Class
