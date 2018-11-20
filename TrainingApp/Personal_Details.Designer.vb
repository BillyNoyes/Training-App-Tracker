<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personal_Details))
        Me.FirstNamelbl = New System.Windows.Forms.Label
        Me.FirstNametxt = New System.Windows.Forms.TextBox
        Me.Surnamelbl = New System.Windows.Forms.Label
        Me.Surnametxt = New System.Windows.Forms.TextBox
        Me.DOBlbl = New System.Windows.Forms.Label
        Me.Genderlbl = New System.Windows.Forms.Label
        Me.Heighttxt = New System.Windows.Forms.TextBox
        Me.Heightlbl = New System.Windows.Forms.Label
        Me.Weighttxt = New System.Windows.Forms.TextBox
        Me.Weightlbl = New System.Windows.Forms.Label
        Me.Backbtn = New System.Windows.Forms.Button
        Me.Editbtn = New System.Windows.Forms.Button
        Me.Savebtn = New System.Windows.Forms.Button
        Me.Gendercbo = New System.Windows.Forms.ComboBox
        Me.Cancelbtn2 = New System.Windows.Forms.Button
        Me.SecuritySettingsbtn = New System.Windows.Forms.Button
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker
        Me.Emailtxt = New System.Windows.Forms.TextBox
        Me.Emaillbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'FirstNamelbl
        '
        Me.FirstNamelbl.AutoSize = True
        Me.FirstNamelbl.Location = New System.Drawing.Point(32, 66)
        Me.FirstNamelbl.Name = "FirstNamelbl"
        Me.FirstNamelbl.Size = New System.Drawing.Size(57, 13)
        Me.FirstNamelbl.TabIndex = 0
        Me.FirstNamelbl.Text = "First Name"
        '
        'FirstNametxt
        '
        Me.FirstNametxt.Enabled = False
        Me.FirstNametxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FirstNametxt.Location = New System.Drawing.Point(95, 63)
        Me.FirstNametxt.Name = "FirstNametxt"
        Me.FirstNametxt.Size = New System.Drawing.Size(100, 20)
        Me.FirstNametxt.TabIndex = 1
        '
        'Surnamelbl
        '
        Me.Surnamelbl.AutoSize = True
        Me.Surnamelbl.Location = New System.Drawing.Point(32, 105)
        Me.Surnamelbl.Name = "Surnamelbl"
        Me.Surnamelbl.Size = New System.Drawing.Size(49, 13)
        Me.Surnamelbl.TabIndex = 2
        Me.Surnamelbl.Text = "Surname"
        '
        'Surnametxt
        '
        Me.Surnametxt.Enabled = False
        Me.Surnametxt.Location = New System.Drawing.Point(95, 102)
        Me.Surnametxt.Name = "Surnametxt"
        Me.Surnametxt.Size = New System.Drawing.Size(100, 20)
        Me.Surnametxt.TabIndex = 3
        '
        'DOBlbl
        '
        Me.DOBlbl.AutoSize = True
        Me.DOBlbl.Location = New System.Drawing.Point(14, 181)
        Me.DOBlbl.Name = "DOBlbl"
        Me.DOBlbl.Size = New System.Drawing.Size(71, 26)
        Me.DOBlbl.TabIndex = 4
        Me.DOBlbl.Text = "Date of Birth*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(dd/mm/yyyy)"
        '
        'Genderlbl
        '
        Me.Genderlbl.AutoSize = True
        Me.Genderlbl.Location = New System.Drawing.Point(32, 231)
        Me.Genderlbl.Name = "Genderlbl"
        Me.Genderlbl.Size = New System.Drawing.Size(42, 13)
        Me.Genderlbl.TabIndex = 6
        Me.Genderlbl.Text = "Gender"
        '
        'Heighttxt
        '
        Me.Heighttxt.Enabled = False
        Me.Heighttxt.Location = New System.Drawing.Point(95, 306)
        Me.Heighttxt.Name = "Heighttxt"
        Me.Heighttxt.Size = New System.Drawing.Size(100, 20)
        Me.Heighttxt.TabIndex = 9
        '
        'Heightlbl
        '
        Me.Heightlbl.AutoSize = True
        Me.Heightlbl.Location = New System.Drawing.Point(24, 309)
        Me.Heightlbl.Name = "Heightlbl"
        Me.Heightlbl.Size = New System.Drawing.Size(57, 13)
        Me.Heightlbl.TabIndex = 8
        Me.Heightlbl.Text = "Height (ft)*"
        '
        'Weighttxt
        '
        Me.Weighttxt.Enabled = False
        Me.Weighttxt.Location = New System.Drawing.Point(95, 266)
        Me.Weighttxt.Name = "Weighttxt"
        Me.Weighttxt.Size = New System.Drawing.Size(100, 20)
        Me.Weighttxt.TabIndex = 11
        '
        'Weightlbl
        '
        Me.Weightlbl.AutoSize = True
        Me.Weightlbl.Location = New System.Drawing.Point(23, 269)
        Me.Weightlbl.Name = "Weightlbl"
        Me.Weightlbl.Size = New System.Drawing.Size(66, 13)
        Me.Weightlbl.TabIndex = 10
        Me.Weightlbl.Text = "Weight (kg)*"
        '
        'Backbtn
        '
        Me.Backbtn.Location = New System.Drawing.Point(13, 13)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(75, 23)
        Me.Backbtn.TabIndex = 12
        Me.Backbtn.Text = "<"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Location = New System.Drawing.Point(35, 352)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(75, 23)
        Me.Editbtn.TabIndex = 13
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Savebtn
        '
        Me.Savebtn.Location = New System.Drawing.Point(149, 403)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(75, 23)
        Me.Savebtn.TabIndex = 15
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        Me.Savebtn.Visible = False
        '
        'Gendercbo
        '
        Me.Gendercbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gendercbo.Enabled = False
        Me.Gendercbo.FormattingEnabled = True
        Me.Gendercbo.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gendercbo.Location = New System.Drawing.Point(95, 228)
        Me.Gendercbo.Name = "Gendercbo"
        Me.Gendercbo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Gendercbo.Size = New System.Drawing.Size(100, 21)
        Me.Gendercbo.TabIndex = 16
        '
        'Cancelbtn2
        '
        Me.Cancelbtn2.Location = New System.Drawing.Point(68, 403)
        Me.Cancelbtn2.Name = "Cancelbtn2"
        Me.Cancelbtn2.Size = New System.Drawing.Size(75, 23)
        Me.Cancelbtn2.TabIndex = 17
        Me.Cancelbtn2.Text = "Cancel"
        Me.Cancelbtn2.UseVisualStyleBackColor = True
        Me.Cancelbtn2.Visible = False
        '
        'SecuritySettingsbtn
        '
        Me.SecuritySettingsbtn.Location = New System.Drawing.Point(116, 345)
        Me.SecuritySettingsbtn.Name = "SecuritySettingsbtn"
        Me.SecuritySettingsbtn.Size = New System.Drawing.Size(93, 37)
        Me.SecuritySettingsbtn.TabIndex = 18
        Me.SecuritySettingsbtn.Text = "Update Your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Security Details"
        Me.SecuritySettingsbtn.UseVisualStyleBackColor = True
        '
        'DOBPicker
        '
        Me.DOBPicker.Enabled = False
        Me.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBPicker.Location = New System.Drawing.Point(95, 181)
        Me.DOBPicker.MaxDate = New Date(2015, 3, 5, 0, 0, 0, 0)
        Me.DOBPicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(100, 20)
        Me.DOBPicker.TabIndex = 19
        Me.DOBPicker.Value = New Date(2001, 1, 1, 0, 0, 0, 0)
        '
        'Emailtxt
        '
        Me.Emailtxt.Enabled = False
        Me.Emailtxt.Location = New System.Drawing.Point(95, 139)
        Me.Emailtxt.Name = "Emailtxt"
        Me.Emailtxt.Size = New System.Drawing.Size(100, 20)
        Me.Emailtxt.TabIndex = 21
        '
        'Emaillbl
        '
        Me.Emaillbl.AutoSize = True
        Me.Emaillbl.Location = New System.Drawing.Point(32, 142)
        Me.Emaillbl.Name = "Emaillbl"
        Me.Emaillbl.Size = New System.Drawing.Size(36, 13)
        Me.Emaillbl.TabIndex = 20
        Me.Emaillbl.Text = "Email*"
        '
        'Personal_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(236, 436)
        Me.Controls.Add(Me.Emailtxt)
        Me.Controls.Add(Me.Emaillbl)
        Me.Controls.Add(Me.DOBPicker)
        Me.Controls.Add(Me.SecuritySettingsbtn)
        Me.Controls.Add(Me.Cancelbtn2)
        Me.Controls.Add(Me.Gendercbo)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.Weighttxt)
        Me.Controls.Add(Me.Weightlbl)
        Me.Controls.Add(Me.Heighttxt)
        Me.Controls.Add(Me.Heightlbl)
        Me.Controls.Add(Me.Genderlbl)
        Me.Controls.Add(Me.DOBlbl)
        Me.Controls.Add(Me.Surnametxt)
        Me.Controls.Add(Me.Surnamelbl)
        Me.Controls.Add(Me.FirstNametxt)
        Me.Controls.Add(Me.FirstNamelbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Personal_Details"
        Me.Text = "Personal Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstNamelbl As System.Windows.Forms.Label
    Friend WithEvents FirstNametxt As System.Windows.Forms.TextBox
    Friend WithEvents Surnamelbl As System.Windows.Forms.Label
    Friend WithEvents Surnametxt As System.Windows.Forms.TextBox
    Friend WithEvents DOBlbl As System.Windows.Forms.Label
    Friend WithEvents Genderlbl As System.Windows.Forms.Label
    Friend WithEvents Heighttxt As System.Windows.Forms.TextBox
    Friend WithEvents Heightlbl As System.Windows.Forms.Label
    Friend WithEvents Weighttxt As System.Windows.Forms.TextBox
    Friend WithEvents Weightlbl As System.Windows.Forms.Label
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Savebtn As System.Windows.Forms.Button
    Friend WithEvents Gendercbo As System.Windows.Forms.ComboBox
    Friend WithEvents Cancelbtn2 As System.Windows.Forms.Button
    Friend WithEvents SecuritySettingsbtn As System.Windows.Forms.Button
    Friend WithEvents DOBPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Emailtxt As System.Windows.Forms.TextBox
    Friend WithEvents Emaillbl As System.Windows.Forms.Label

End Class
