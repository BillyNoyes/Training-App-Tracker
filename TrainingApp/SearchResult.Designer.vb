<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchResult))
        Me.Backbtn = New System.Windows.Forms.Button
        Me.Weighttxt2 = New System.Windows.Forms.TextBox
        Me.Weightlbl2 = New System.Windows.Forms.Label
        Me.Heighttxt2 = New System.Windows.Forms.TextBox
        Me.Heightlbl2 = New System.Windows.Forms.Label
        Me.Genderlbl2 = New System.Windows.Forms.Label
        Me.DOBtxt2 = New System.Windows.Forms.TextBox
        Me.DOBlbl2 = New System.Windows.Forms.Label
        Me.Surnametxt2 = New System.Windows.Forms.TextBox
        Me.Surnamelbl2 = New System.Windows.Forms.Label
        Me.FirstNametxt2 = New System.Windows.Forms.TextBox
        Me.FirstNamelbl2 = New System.Windows.Forms.Label
        Me.Gendertxt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Backbtn
        '
        Me.Backbtn.Location = New System.Drawing.Point(12, 12)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(75, 23)
        Me.Backbtn.TabIndex = 24
        Me.Backbtn.Text = "<"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Weighttxt2
        '
        Me.Weighttxt2.Enabled = False
        Me.Weighttxt2.Location = New System.Drawing.Point(89, 228)
        Me.Weighttxt2.Name = "Weighttxt2"
        Me.Weighttxt2.Size = New System.Drawing.Size(100, 20)
        Me.Weighttxt2.TabIndex = 23
        '
        'Weightlbl2
        '
        Me.Weightlbl2.AutoSize = True
        Me.Weightlbl2.Location = New System.Drawing.Point(26, 231)
        Me.Weightlbl2.Name = "Weightlbl2"
        Me.Weightlbl2.Size = New System.Drawing.Size(62, 13)
        Me.Weightlbl2.TabIndex = 22
        Me.Weightlbl2.Text = "Weight (kg)"
        '
        'Heighttxt2
        '
        Me.Heighttxt2.Enabled = False
        Me.Heighttxt2.Location = New System.Drawing.Point(89, 268)
        Me.Heighttxt2.Name = "Heighttxt2"
        Me.Heighttxt2.Size = New System.Drawing.Size(100, 20)
        Me.Heighttxt2.TabIndex = 21
        '
        'Heightlbl2
        '
        Me.Heightlbl2.AutoSize = True
        Me.Heightlbl2.Location = New System.Drawing.Point(26, 271)
        Me.Heightlbl2.Name = "Heightlbl2"
        Me.Heightlbl2.Size = New System.Drawing.Size(53, 13)
        Me.Heightlbl2.TabIndex = 20
        Me.Heightlbl2.Text = "Height (ft)"
        '
        'Genderlbl2
        '
        Me.Genderlbl2.AutoSize = True
        Me.Genderlbl2.Location = New System.Drawing.Point(26, 193)
        Me.Genderlbl2.Name = "Genderlbl2"
        Me.Genderlbl2.Size = New System.Drawing.Size(42, 13)
        Me.Genderlbl2.TabIndex = 19
        Me.Genderlbl2.Text = "Gender"
        '
        'DOBtxt2
        '
        Me.DOBtxt2.Enabled = False
        Me.DOBtxt2.Location = New System.Drawing.Point(100, 149)
        Me.DOBtxt2.Name = "DOBtxt2"
        Me.DOBtxt2.Size = New System.Drawing.Size(89, 20)
        Me.DOBtxt2.TabIndex = 18
        '
        'DOBlbl2
        '
        Me.DOBlbl2.AutoSize = True
        Me.DOBlbl2.Location = New System.Drawing.Point(26, 152)
        Me.DOBlbl2.Name = "DOBlbl2"
        Me.DOBlbl2.Size = New System.Drawing.Size(68, 13)
        Me.DOBlbl2.TabIndex = 17
        Me.DOBlbl2.Text = "Date Of Birth"
        '
        'Surnametxt2
        '
        Me.Surnametxt2.Enabled = False
        Me.Surnametxt2.Location = New System.Drawing.Point(89, 105)
        Me.Surnametxt2.Name = "Surnametxt2"
        Me.Surnametxt2.Size = New System.Drawing.Size(100, 20)
        Me.Surnametxt2.TabIndex = 16
        '
        'Surnamelbl2
        '
        Me.Surnamelbl2.AutoSize = True
        Me.Surnamelbl2.Location = New System.Drawing.Point(26, 108)
        Me.Surnamelbl2.Name = "Surnamelbl2"
        Me.Surnamelbl2.Size = New System.Drawing.Size(49, 13)
        Me.Surnamelbl2.TabIndex = 15
        Me.Surnamelbl2.Text = "Surname"
        '
        'FirstNametxt2
        '
        Me.FirstNametxt2.Enabled = False
        Me.FirstNametxt2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FirstNametxt2.Location = New System.Drawing.Point(89, 62)
        Me.FirstNametxt2.Name = "FirstNametxt2"
        Me.FirstNametxt2.Size = New System.Drawing.Size(100, 20)
        Me.FirstNametxt2.TabIndex = 14
        '
        'FirstNamelbl2
        '
        Me.FirstNamelbl2.AutoSize = True
        Me.FirstNamelbl2.Location = New System.Drawing.Point(26, 65)
        Me.FirstNamelbl2.Name = "FirstNamelbl2"
        Me.FirstNamelbl2.Size = New System.Drawing.Size(57, 13)
        Me.FirstNamelbl2.TabIndex = 13
        Me.FirstNamelbl2.Text = "First Name"
        '
        'Gendertxt
        '
        Me.Gendertxt.Enabled = False
        Me.Gendertxt.Location = New System.Drawing.Point(89, 193)
        Me.Gendertxt.Name = "Gendertxt"
        Me.Gendertxt.Size = New System.Drawing.Size(100, 20)
        Me.Gendertxt.TabIndex = 25
        '
        'SearchResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 321)
        Me.Controls.Add(Me.Gendertxt)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.Weighttxt2)
        Me.Controls.Add(Me.Weightlbl2)
        Me.Controls.Add(Me.Heighttxt2)
        Me.Controls.Add(Me.Heightlbl2)
        Me.Controls.Add(Me.Genderlbl2)
        Me.Controls.Add(Me.DOBtxt2)
        Me.Controls.Add(Me.DOBlbl2)
        Me.Controls.Add(Me.Surnametxt2)
        Me.Controls.Add(Me.Surnamelbl2)
        Me.Controls.Add(Me.FirstNametxt2)
        Me.Controls.Add(Me.FirstNamelbl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "SearchResult"
        Me.Text = "SearchResult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Weighttxt2 As System.Windows.Forms.TextBox
    Friend WithEvents Weightlbl2 As System.Windows.Forms.Label
    Friend WithEvents Heighttxt2 As System.Windows.Forms.TextBox
    Friend WithEvents Heightlbl2 As System.Windows.Forms.Label
    Friend WithEvents Genderlbl2 As System.Windows.Forms.Label
    Friend WithEvents DOBtxt2 As System.Windows.Forms.TextBox
    Friend WithEvents DOBlbl2 As System.Windows.Forms.Label
    Friend WithEvents Surnametxt2 As System.Windows.Forms.TextBox
    Friend WithEvents Surnamelbl2 As System.Windows.Forms.Label
    Friend WithEvents FirstNametxt2 As System.Windows.Forms.TextBox
    Friend WithEvents FirstNamelbl2 As System.Windows.Forms.Label
    Friend WithEvents Gendertxt As System.Windows.Forms.TextBox
End Class
