<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordReset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordReset))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.IDtxt2 = New System.Windows.Forms.TextBox
        Me.SecurityChecktxt = New System.Windows.Forms.TextBox
        Me.ResetPass = New System.Windows.Forms.Button
        Me.RefreshCaptchabtn = New System.Windows.Forms.Button
        Me.CaptchaImg = New System.Windows.Forms.PictureBox
        Me.SecurityQuestiontxt = New System.Windows.Forms.TextBox
        Me.SecurityQuestionlbl = New System.Windows.Forms.Label
        Me.Backbtn2 = New System.Windows.Forms.Button
        CType(Me.CaptchaImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Are you human? Type the word you see in the box "
        '
        'IDtxt2
        '
        Me.IDtxt2.Location = New System.Drawing.Point(87, 49)
        Me.IDtxt2.Name = "IDtxt2"
        Me.IDtxt2.Size = New System.Drawing.Size(100, 20)
        Me.IDtxt2.TabIndex = 4
        '
        'SecurityChecktxt
        '
        Me.SecurityChecktxt.Location = New System.Drawing.Point(87, 342)
        Me.SecurityChecktxt.Name = "SecurityChecktxt"
        Me.SecurityChecktxt.Size = New System.Drawing.Size(100, 20)
        Me.SecurityChecktxt.TabIndex = 5
        '
        'ResetPass
        '
        Me.ResetPass.Location = New System.Drawing.Point(196, 334)
        Me.ResetPass.Name = "ResetPass"
        Me.ResetPass.Size = New System.Drawing.Size(75, 35)
        Me.ResetPass.TabIndex = 6
        Me.ResetPass.Text = "Reset Password"
        Me.ResetPass.UseVisualStyleBackColor = True
        '
        'RefreshCaptchabtn
        '
        Me.RefreshCaptchabtn.Location = New System.Drawing.Point(5, 334)
        Me.RefreshCaptchabtn.Name = "RefreshCaptchabtn"
        Me.RefreshCaptchabtn.Size = New System.Drawing.Size(75, 35)
        Me.RefreshCaptchabtn.TabIndex = 8
        Me.RefreshCaptchabtn.Text = "New Image"
        Me.RefreshCaptchabtn.UseVisualStyleBackColor = True
        '
        'CaptchaImg
        '
        Me.CaptchaImg.Location = New System.Drawing.Point(15, 175)
        Me.CaptchaImg.Name = "CaptchaImg"
        Me.CaptchaImg.Size = New System.Drawing.Size(244, 143)
        Me.CaptchaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CaptchaImg.TabIndex = 9
        Me.CaptchaImg.TabStop = False
        '
        'SecurityQuestiontxt
        '
        Me.SecurityQuestiontxt.Location = New System.Drawing.Point(47, 109)
        Me.SecurityQuestiontxt.Name = "SecurityQuestiontxt"
        Me.SecurityQuestiontxt.Size = New System.Drawing.Size(177, 20)
        Me.SecurityQuestiontxt.TabIndex = 16
        '
        'SecurityQuestionlbl
        '
        Me.SecurityQuestionlbl.AutoSize = True
        Me.SecurityQuestionlbl.Location = New System.Drawing.Point(44, 84)
        Me.SecurityQuestionlbl.Name = "SecurityQuestionlbl"
        Me.SecurityQuestionlbl.Size = New System.Drawing.Size(180, 13)
        Me.SecurityQuestionlbl.TabIndex = 15
        Me.SecurityQuestionlbl.Text = "What is your mother's maiden name?"
        '
        'Backbtn2
        '
        Me.Backbtn2.Location = New System.Drawing.Point(12, 12)
        Me.Backbtn2.Name = "Backbtn2"
        Me.Backbtn2.Size = New System.Drawing.Size(75, 23)
        Me.Backbtn2.TabIndex = 14
        Me.Backbtn2.Text = "<"
        Me.Backbtn2.UseVisualStyleBackColor = True
        '
        'PasswordReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 378)
        Me.Controls.Add(Me.SecurityQuestiontxt)
        Me.Controls.Add(Me.SecurityQuestionlbl)
        Me.Controls.Add(Me.Backbtn2)
        Me.Controls.Add(Me.CaptchaImg)
        Me.Controls.Add(Me.RefreshCaptchabtn)
        Me.Controls.Add(Me.ResetPass)
        Me.Controls.Add(Me.SecurityChecktxt)
        Me.Controls.Add(Me.IDtxt2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PasswordReset"
        Me.Text = "Password Reset"
        CType(Me.CaptchaImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IDtxt2 As System.Windows.Forms.TextBox
    Friend WithEvents SecurityChecktxt As System.Windows.Forms.TextBox
    Friend WithEvents ResetPass As System.Windows.Forms.Button
    Friend WithEvents RefreshCaptchabtn As System.Windows.Forms.Button
    Friend WithEvents CaptchaImg As System.Windows.Forms.PictureBox
    Friend WithEvents SecurityQuestiontxt As System.Windows.Forms.TextBox
    Friend WithEvents SecurityQuestionlbl As System.Windows.Forms.Label
    Friend WithEvents Backbtn2 As System.Windows.Forms.Button
End Class
