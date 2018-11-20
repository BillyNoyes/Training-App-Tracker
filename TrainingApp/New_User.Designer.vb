<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUser))
        Me.NewUserbtn = New System.Windows.Forms.Button
        Me.RegisterPass1lbl = New System.Windows.Forms.Label
        Me.RegisterPass2lbl = New System.Windows.Forms.Label
        Me.RegisterPass1txt = New System.Windows.Forms.TextBox
        Me.RegisterPass2txt = New System.Windows.Forms.TextBox
        Me.Cancelbtn = New System.Windows.Forms.Button
        Me.RegisterEmailtxt = New System.Windows.Forms.TextBox
        Me.Emaillbl = New System.Windows.Forms.Label
        Me.SecurityQuestionlbl = New System.Windows.Forms.Label
        Me.SecurityQuestiontxt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'NewUserbtn
        '
        Me.NewUserbtn.Location = New System.Drawing.Point(197, 180)
        Me.NewUserbtn.Name = "NewUserbtn"
        Me.NewUserbtn.Size = New System.Drawing.Size(75, 37)
        Me.NewUserbtn.TabIndex = 0
        Me.NewUserbtn.Text = "Create New User"
        Me.NewUserbtn.UseVisualStyleBackColor = True
        '
        'RegisterPass1lbl
        '
        Me.RegisterPass1lbl.AutoSize = True
        Me.RegisterPass1lbl.Location = New System.Drawing.Point(12, 54)
        Me.RegisterPass1lbl.Name = "RegisterPass1lbl"
        Me.RegisterPass1lbl.Size = New System.Drawing.Size(53, 13)
        Me.RegisterPass1lbl.TabIndex = 3
        Me.RegisterPass1lbl.Text = "Password"
        '
        'RegisterPass2lbl
        '
        Me.RegisterPass2lbl.AutoSize = True
        Me.RegisterPass2lbl.Location = New System.Drawing.Point(12, 89)
        Me.RegisterPass2lbl.Name = "RegisterPass2lbl"
        Me.RegisterPass2lbl.Size = New System.Drawing.Size(53, 13)
        Me.RegisterPass2lbl.TabIndex = 5
        Me.RegisterPass2lbl.Text = "Password"
        '
        'RegisterPass1txt
        '
        Me.RegisterPass1txt.Location = New System.Drawing.Point(87, 51)
        Me.RegisterPass1txt.Name = "RegisterPass1txt"
        Me.RegisterPass1txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RegisterPass1txt.Size = New System.Drawing.Size(100, 20)
        Me.RegisterPass1txt.TabIndex = 7
        '
        'RegisterPass2txt
        '
        Me.RegisterPass2txt.Location = New System.Drawing.Point(87, 86)
        Me.RegisterPass2txt.Name = "RegisterPass2txt"
        Me.RegisterPass2txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RegisterPass2txt.Size = New System.Drawing.Size(100, 20)
        Me.RegisterPass2txt.TabIndex = 8
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Location = New System.Drawing.Point(15, 187)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelbtn.TabIndex = 10
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'RegisterEmailtxt
        '
        Me.RegisterEmailtxt.Location = New System.Drawing.Point(87, 19)
        Me.RegisterEmailtxt.Name = "RegisterEmailtxt"
        Me.RegisterEmailtxt.Size = New System.Drawing.Size(100, 20)
        Me.RegisterEmailtxt.TabIndex = 12
        '
        'Emaillbl
        '
        Me.Emaillbl.AutoSize = True
        Me.Emaillbl.Location = New System.Drawing.Point(33, 22)
        Me.Emaillbl.Name = "Emaillbl"
        Me.Emaillbl.Size = New System.Drawing.Size(32, 13)
        Me.Emaillbl.TabIndex = 11
        Me.Emaillbl.Text = "Email"
        '
        'SecurityQuestionlbl
        '
        Me.SecurityQuestionlbl.AutoSize = True
        Me.SecurityQuestionlbl.Location = New System.Drawing.Point(53, 119)
        Me.SecurityQuestionlbl.Name = "SecurityQuestionlbl"
        Me.SecurityQuestionlbl.Size = New System.Drawing.Size(180, 13)
        Me.SecurityQuestionlbl.TabIndex = 13
        Me.SecurityQuestionlbl.Text = "What is your mother's maiden name?"
        '
        'SecurityQuestiontxt
        '
        Me.SecurityQuestiontxt.Location = New System.Drawing.Point(56, 144)
        Me.SecurityQuestiontxt.Name = "SecurityQuestiontxt"
        Me.SecurityQuestiontxt.Size = New System.Drawing.Size(177, 20)
        Me.SecurityQuestiontxt.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 225)
        Me.Controls.Add(Me.SecurityQuestiontxt)
        Me.Controls.Add(Me.SecurityQuestionlbl)
        Me.Controls.Add(Me.RegisterEmailtxt)
        Me.Controls.Add(Me.Emaillbl)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.RegisterPass2txt)
        Me.Controls.Add(Me.RegisterPass1txt)
        Me.Controls.Add(Me.RegisterPass2lbl)
        Me.Controls.Add(Me.RegisterPass1lbl)
        Me.Controls.Add(Me.NewUserbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Create New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewUserbtn As System.Windows.Forms.Button
    Friend WithEvents RegisterPass1lbl As System.Windows.Forms.Label
    Friend WithEvents RegisterPass2lbl As System.Windows.Forms.Label
    Friend WithEvents RegisterPass1txt As System.Windows.Forms.TextBox
    Friend WithEvents RegisterPass2txt As System.Windows.Forms.TextBox
    Friend WithEvents Cancelbtn As System.Windows.Forms.Button
    Friend WithEvents RegisterEmailtxt As System.Windows.Forms.TextBox
    Friend WithEvents Emaillbl As System.Windows.Forms.Label
    Friend WithEvents SecurityQuestionlbl As System.Windows.Forms.Label
    Friend WithEvents SecurityQuestiontxt As System.Windows.Forms.TextBox
End Class
