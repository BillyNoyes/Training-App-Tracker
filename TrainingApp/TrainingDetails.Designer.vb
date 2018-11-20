<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainingDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainingDetails))
        Me.TrainingDetailsAddbtn = New System.Windows.Forms.Button
        Me.Backbtn = New System.Windows.Forms.Button
        Me.kmlbl = New System.Windows.Forms.Label
        Me.RunningDisttxt = New System.Windows.Forms.TextBox
        Me.SwimmingDisttxt = New System.Windows.Forms.TextBox
        Me.CyclingDisttxt = New System.Windows.Forms.TextBox
        Me.Running_Distancelbl = New System.Windows.Forms.Label
        Me.Swimming_Distancelbl = New System.Windows.Forms.Label
        Me.Cycling_Distancelbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Editbtn = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.AvgDistlbl = New System.Windows.Forms.Label
        Me.AvgDisttxt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TrainingDetailsAddbtn
        '
        Me.TrainingDetailsAddbtn.Location = New System.Drawing.Point(163, 170)
        Me.TrainingDetailsAddbtn.Name = "TrainingDetailsAddbtn"
        Me.TrainingDetailsAddbtn.Size = New System.Drawing.Size(75, 23)
        Me.TrainingDetailsAddbtn.TabIndex = 1
        Me.TrainingDetailsAddbtn.Text = "Add Details"
        Me.TrainingDetailsAddbtn.UseVisualStyleBackColor = True
        Me.TrainingDetailsAddbtn.Visible = False
        '
        'Backbtn
        '
        Me.Backbtn.Location = New System.Drawing.Point(12, 7)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(75, 23)
        Me.Backbtn.TabIndex = 7
        Me.Backbtn.Text = "<"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'kmlbl
        '
        Me.kmlbl.AutoSize = True
        Me.kmlbl.Location = New System.Drawing.Point(216, 57)
        Me.kmlbl.Name = "kmlbl"
        Me.kmlbl.Size = New System.Drawing.Size(21, 13)
        Me.kmlbl.TabIndex = 10
        Me.kmlbl.Text = "km"
        '
        'RunningDisttxt
        '
        Me.RunningDisttxt.Enabled = False
        Me.RunningDisttxt.Location = New System.Drawing.Point(112, 54)
        Me.RunningDisttxt.Name = "RunningDisttxt"
        Me.RunningDisttxt.Size = New System.Drawing.Size(100, 20)
        Me.RunningDisttxt.TabIndex = 11
        '
        'SwimmingDisttxt
        '
        Me.SwimmingDisttxt.Enabled = False
        Me.SwimmingDisttxt.Location = New System.Drawing.Point(111, 81)
        Me.SwimmingDisttxt.Name = "SwimmingDisttxt"
        Me.SwimmingDisttxt.Size = New System.Drawing.Size(100, 20)
        Me.SwimmingDisttxt.TabIndex = 12
        '
        'CyclingDisttxt
        '
        Me.CyclingDisttxt.Enabled = False
        Me.CyclingDisttxt.Location = New System.Drawing.Point(110, 108)
        Me.CyclingDisttxt.Name = "CyclingDisttxt"
        Me.CyclingDisttxt.Size = New System.Drawing.Size(100, 20)
        Me.CyclingDisttxt.TabIndex = 13
        '
        'Running_Distancelbl
        '
        Me.Running_Distancelbl.AutoSize = True
        Me.Running_Distancelbl.Location = New System.Drawing.Point(13, 57)
        Me.Running_Distancelbl.Name = "Running_Distancelbl"
        Me.Running_Distancelbl.Size = New System.Drawing.Size(92, 13)
        Me.Running_Distancelbl.TabIndex = 14
        Me.Running_Distancelbl.Text = "Running Distance"
        '
        'Swimming_Distancelbl
        '
        Me.Swimming_Distancelbl.AutoSize = True
        Me.Swimming_Distancelbl.Location = New System.Drawing.Point(6, 84)
        Me.Swimming_Distancelbl.Name = "Swimming_Distancelbl"
        Me.Swimming_Distancelbl.Size = New System.Drawing.Size(99, 13)
        Me.Swimming_Distancelbl.TabIndex = 15
        Me.Swimming_Distancelbl.Text = "Swimming Distance"
        '
        'Cycling_Distancelbl
        '
        Me.Cycling_Distancelbl.AutoSize = True
        Me.Cycling_Distancelbl.Location = New System.Drawing.Point(19, 111)
        Me.Cycling_Distancelbl.Name = "Cycling_Distancelbl"
        Me.Cycling_Distancelbl.Size = New System.Drawing.Size(86, 13)
        Me.Cycling_Distancelbl.TabIndex = 16
        Me.Cycling_Distancelbl.Text = "Cycling Distance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "km"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "km"
        '
        'Editbtn
        '
        Me.Editbtn.Location = New System.Drawing.Point(30, 170)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(75, 23)
        Me.Editbtn.TabIndex = 24
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "km"
        '
        'AvgDistlbl
        '
        Me.AvgDistlbl.AutoSize = True
        Me.AvgDistlbl.Location = New System.Drawing.Point(57, 137)
        Me.AvgDistlbl.Name = "AvgDistlbl"
        Me.AvgDistlbl.Size = New System.Drawing.Size(47, 13)
        Me.AvgDistlbl.TabIndex = 26
        Me.AvgDistlbl.Text = "Average"
        '
        'AvgDisttxt
        '
        Me.AvgDisttxt.Enabled = False
        Me.AvgDisttxt.Location = New System.Drawing.Point(110, 134)
        Me.AvgDisttxt.Name = "AvgDisttxt"
        Me.AvgDisttxt.Size = New System.Drawing.Size(100, 20)
        Me.AvgDisttxt.TabIndex = 25
        '
        'TrainingDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 205)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AvgDistlbl)
        Me.Controls.Add(Me.AvgDisttxt)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cycling_Distancelbl)
        Me.Controls.Add(Me.Swimming_Distancelbl)
        Me.Controls.Add(Me.Running_Distancelbl)
        Me.Controls.Add(Me.CyclingDisttxt)
        Me.Controls.Add(Me.SwimmingDisttxt)
        Me.Controls.Add(Me.RunningDisttxt)
        Me.Controls.Add(Me.kmlbl)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.TrainingDetailsAddbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "TrainingDetails"
        Me.Text = "Training Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrainingDetailsAddbtn As System.Windows.Forms.Button
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents kmlbl As System.Windows.Forms.Label
    Friend WithEvents RunningDisttxt As System.Windows.Forms.TextBox
    Friend WithEvents SwimmingDisttxt As System.Windows.Forms.TextBox
    Friend WithEvents CyclingDisttxt As System.Windows.Forms.TextBox
    Friend WithEvents Running_Distancelbl As System.Windows.Forms.Label
    Friend WithEvents Swimming_Distancelbl As System.Windows.Forms.Label
    Friend WithEvents Cycling_Distancelbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AvgDistlbl As System.Windows.Forms.Label
    Friend WithEvents AvgDisttxt As System.Windows.Forms.TextBox
End Class
