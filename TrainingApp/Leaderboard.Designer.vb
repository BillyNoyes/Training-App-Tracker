<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leaderboard))
        Me.Backbtn2 = New System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Activitycbo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Refreshbtn = New System.Windows.Forms.Button
        Me.DGVMeCompare = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMeCompare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Backbtn2
        '
        Me.Backbtn2.Location = New System.Drawing.Point(12, 12)
        Me.Backbtn2.Name = "Backbtn2"
        Me.Backbtn2.Size = New System.Drawing.Size(75, 23)
        Me.Backbtn2.TabIndex = 13
        Me.Backbtn2.Text = "<"
        Me.Backbtn2.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 92)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(585, 255)
        Me.DGV.TabIndex = 14
        '
        'Activitycbo
        '
        Me.Activitycbo.FormattingEnabled = True
        Me.Activitycbo.Items.AddRange(New Object() {"All", "Running", "Swimming", "Cycling"})
        Me.Activitycbo.Location = New System.Drawing.Point(382, 55)
        Me.Activitycbo.Name = "Activitycbo"
        Me.Activitycbo.Size = New System.Drawing.Size(121, 21)
        Me.Activitycbo.TabIndex = 17
        Me.Activitycbo.Text = "Activity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Leaderboard"
        '
        'Refreshbtn
        '
        Me.Refreshbtn.Location = New System.Drawing.Point(509, 43)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.Size = New System.Drawing.Size(88, 43)
        Me.Refreshbtn.TabIndex = 21
        Me.Refreshbtn.Text = "Update Activity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selection"
        Me.Refreshbtn.UseVisualStyleBackColor = True
        '
        'DGVMeCompare
        '
        Me.DGVMeCompare.AllowUserToAddRows = False
        Me.DGVMeCompare.AllowUserToDeleteRows = False
        Me.DGVMeCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMeCompare.Location = New System.Drawing.Point(11, 384)
        Me.DGVMeCompare.Name = "DGVMeCompare"
        Me.DGVMeCompare.ReadOnly = True
        Me.DGVMeCompare.Size = New System.Drawing.Size(586, 85)
        Me.DGVMeCompare.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Your Training Results:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 26)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Compare results between " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "different activities"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 483)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVMeCompare)
        Me.Controls.Add(Me.Refreshbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Activitycbo)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Backbtn2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Leaderboard"
        Me.Text = "Leaderboard"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMeCompare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Backbtn2 As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Activitycbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Refreshbtn As System.Windows.Forms.Button
    Friend WithEvents DGVMeCompare As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
