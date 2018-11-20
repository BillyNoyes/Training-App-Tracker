<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Team
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Team))
        Me.DGVTeam = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Backbtn2 = New System.Windows.Forms.Button
        CType(Me.DGVTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVTeam
        '
        Me.DGVTeam.AllowUserToAddRows = False
        Me.DGVTeam.AllowUserToDeleteRows = False
        Me.DGVTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTeam.Location = New System.Drawing.Point(12, 65)
        Me.DGVTeam.Name = "DGVTeam"
        Me.DGVTeam.ReadOnly = True
        Me.DGVTeam.Size = New System.Drawing.Size(743, 255)
        Me.DGVTeam.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Team Select"
        '
        'Backbtn2
        '
        Me.Backbtn2.Location = New System.Drawing.Point(12, 12)
        Me.Backbtn2.Name = "Backbtn2"
        Me.Backbtn2.Size = New System.Drawing.Size(75, 23)
        Me.Backbtn2.TabIndex = 23
        Me.Backbtn2.Text = "<"
        Me.Backbtn2.UseVisualStyleBackColor = True
        '
        'Team
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 330)
        Me.Controls.Add(Me.Backbtn2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVTeam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Team"
        Me.Text = "Team"
        CType(Me.DGVTeam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVTeam As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Backbtn2 As System.Windows.Forms.Button
End Class
