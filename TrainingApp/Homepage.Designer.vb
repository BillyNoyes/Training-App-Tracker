<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.Logoutbtn = New System.Windows.Forms.Button
        Me.Leaderboardbtn = New System.Windows.Forms.Button
        Me.PersonalDetailsbtn = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Gobtn = New System.Windows.Forms.Button
        Me.Searchlbl = New System.Windows.Forms.Label
        Me.SearchBoxtxt = New System.Windows.Forms.TextBox
        Me.TrainingDetailsbtn = New System.Windows.Forms.Button
        Me.Teambtn = New System.Windows.Forms.Button
        Me.YourIDlbl = New System.Windows.Forms.Label
        Me.YourIDtxt = New System.Windows.Forms.TextBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logoutbtn
        '
        Me.Logoutbtn.Location = New System.Drawing.Point(13, 13)
        Me.Logoutbtn.Name = "Logoutbtn"
        Me.Logoutbtn.Size = New System.Drawing.Size(75, 23)
        Me.Logoutbtn.TabIndex = 0
        Me.Logoutbtn.Text = "Logout"
        Me.Logoutbtn.UseVisualStyleBackColor = True
        '
        'Leaderboardbtn
        '
        Me.Leaderboardbtn.Location = New System.Drawing.Point(153, 263)
        Me.Leaderboardbtn.Name = "Leaderboardbtn"
        Me.Leaderboardbtn.Size = New System.Drawing.Size(75, 23)
        Me.Leaderboardbtn.TabIndex = 1
        Me.Leaderboardbtn.Text = "Leaderboard"
        Me.Leaderboardbtn.UseVisualStyleBackColor = True
        '
        'PersonalDetailsbtn
        '
        Me.PersonalDetailsbtn.Location = New System.Drawing.Point(415, 255)
        Me.PersonalDetailsbtn.Name = "PersonalDetailsbtn"
        Me.PersonalDetailsbtn.Size = New System.Drawing.Size(75, 39)
        Me.PersonalDetailsbtn.TabIndex = 2
        Me.PersonalDetailsbtn.Text = "Personal Details"
        Me.PersonalDetailsbtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.TrainingApp.My.Resources.Resources.LogoUpdated
        Me.PictureBox2.Location = New System.Drawing.Point(135, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(249, 182)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Gobtn
        '
        Me.Gobtn.Location = New System.Drawing.Point(471, 12)
        Me.Gobtn.Name = "Gobtn"
        Me.Gobtn.Size = New System.Drawing.Size(37, 23)
        Me.Gobtn.TabIndex = 5
        Me.Gobtn.Text = "Go"
        Me.Gobtn.UseVisualStyleBackColor = True
        '
        'Searchlbl
        '
        Me.Searchlbl.AutoSize = True
        Me.Searchlbl.Location = New System.Drawing.Point(263, 17)
        Me.Searchlbl.Name = "Searchlbl"
        Me.Searchlbl.Size = New System.Drawing.Size(69, 13)
        Me.Searchlbl.TabIndex = 6
        Me.Searchlbl.Text = "Search by ID"
        '
        'SearchBoxtxt
        '
        Me.SearchBoxtxt.Location = New System.Drawing.Point(333, 14)
        Me.SearchBoxtxt.Name = "SearchBoxtxt"
        Me.SearchBoxtxt.Size = New System.Drawing.Size(132, 20)
        Me.SearchBoxtxt.TabIndex = 7
        '
        'TrainingDetailsbtn
        '
        Me.TrainingDetailsbtn.Location = New System.Drawing.Point(271, 263)
        Me.TrainingDetailsbtn.Name = "TrainingDetailsbtn"
        Me.TrainingDetailsbtn.Size = New System.Drawing.Size(94, 23)
        Me.TrainingDetailsbtn.TabIndex = 8
        Me.TrainingDetailsbtn.Text = "Training Details"
        Me.TrainingDetailsbtn.UseVisualStyleBackColor = True
        '
        'Teambtn
        '
        Me.Teambtn.Location = New System.Drawing.Point(29, 263)
        Me.Teambtn.Name = "Teambtn"
        Me.Teambtn.Size = New System.Drawing.Size(75, 23)
        Me.Teambtn.TabIndex = 9
        Me.Teambtn.Text = "Team"
        Me.Teambtn.UseVisualStyleBackColor = True
        '
        'YourIDlbl
        '
        Me.YourIDlbl.AutoSize = True
        Me.YourIDlbl.Location = New System.Drawing.Point(414, 44)
        Me.YourIDlbl.Name = "YourIDlbl"
        Me.YourIDlbl.Size = New System.Drawing.Size(43, 13)
        Me.YourIDlbl.TabIndex = 10
        Me.YourIDlbl.Text = "Your ID"
        '
        'YourIDtxt
        '
        Me.YourIDtxt.Enabled = False
        Me.YourIDtxt.Location = New System.Drawing.Point(463, 41)
        Me.YourIDtxt.Name = "YourIDtxt"
        Me.YourIDtxt.Size = New System.Drawing.Size(45, 20)
        Me.YourIDtxt.TabIndex = 11
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 319)
        Me.Controls.Add(Me.YourIDtxt)
        Me.Controls.Add(Me.YourIDlbl)
        Me.Controls.Add(Me.Teambtn)
        Me.Controls.Add(Me.TrainingDetailsbtn)
        Me.Controls.Add(Me.SearchBoxtxt)
        Me.Controls.Add(Me.Searchlbl)
        Me.Controls.Add(Me.Gobtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PersonalDetailsbtn)
        Me.Controls.Add(Me.Leaderboardbtn)
        Me.Controls.Add(Me.Logoutbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Homepage"
        Me.Text = "Homepage"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logoutbtn As System.Windows.Forms.Button
    Friend WithEvents Leaderboardbtn As System.Windows.Forms.Button
    Friend WithEvents PersonalDetailsbtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Gobtn As System.Windows.Forms.Button
    Friend WithEvents Searchlbl As System.Windows.Forms.Label
    Friend WithEvents SearchBoxtxt As System.Windows.Forms.TextBox
    Friend WithEvents TrainingDetailsbtn As System.Windows.Forms.Button
    Friend WithEvents Teambtn As System.Windows.Forms.Button
    Friend WithEvents YourIDlbl As System.Windows.Forms.Label
    Friend WithEvents YourIDtxt As System.Windows.Forms.TextBox
End Class
