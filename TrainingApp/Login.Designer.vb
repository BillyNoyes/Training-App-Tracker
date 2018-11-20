<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Loginbtn = New System.Windows.Forms.Button
        Me.User = New System.Windows.Forms.Button
        Me.LoginUserlbl = New System.Windows.Forms.Label
        Me.IDtxt = New System.Windows.Forms.TextBox
        Me.LoginPasslbl = New System.Windows.Forms.Label
        Me.Passtxt = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ForgotPassbtn = New System.Windows.Forms.LinkLabel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Loginbtn
        '
        Me.Loginbtn.Location = New System.Drawing.Point(137, 310)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(75, 23)
        Me.Loginbtn.TabIndex = 0
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(21, 302)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(75, 39)
        Me.User.TabIndex = 1
        Me.User.Text = "Create New User"
        Me.User.UseVisualStyleBackColor = True
        '
        'LoginUserlbl
        '
        Me.LoginUserlbl.AutoSize = True
        Me.LoginUserlbl.Location = New System.Drawing.Point(55, 233)
        Me.LoginUserlbl.Name = "LoginUserlbl"
        Me.LoginUserlbl.Size = New System.Drawing.Size(18, 13)
        Me.LoginUserlbl.TabIndex = 2
        Me.LoginUserlbl.Text = "ID"
        '
        'IDtxt
        '
        Me.IDtxt.Location = New System.Drawing.Point(81, 230)
        Me.IDtxt.Name = "IDtxt"
        Me.IDtxt.Size = New System.Drawing.Size(131, 20)
        Me.IDtxt.TabIndex = 3
        '
        'LoginPasslbl
        '
        Me.LoginPasslbl.AutoSize = True
        Me.LoginPasslbl.Location = New System.Drawing.Point(20, 271)
        Me.LoginPasslbl.Name = "LoginPasslbl"
        Me.LoginPasslbl.Size = New System.Drawing.Size(53, 13)
        Me.LoginPasslbl.TabIndex = 4
        Me.LoginPasslbl.Text = "Password"
        '
        'Passtxt
        '
        Me.Passtxt.Location = New System.Drawing.Point(81, 268)
        Me.Passtxt.Name = "Passtxt"
        Me.Passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtxt.Size = New System.Drawing.Size(131, 20)
        Me.Passtxt.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TrainingApp.My.Resources.Resources.LogoUpdated
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(13, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ForgotPassbtn
        '
        Me.ForgotPassbtn.AutoSize = True
        Me.ForgotPassbtn.Location = New System.Drawing.Point(126, 355)
        Me.ForgotPassbtn.Name = "ForgotPassbtn"
        Me.ForgotPassbtn.Size = New System.Drawing.Size(86, 13)
        Me.ForgotPassbtn.TabIndex = 7
        Me.ForgotPassbtn.TabStop = True
        Me.ForgotPassbtn.Text = "Forgot Password"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 377)
        Me.Controls.Add(Me.ForgotPassbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Passtxt)
        Me.Controls.Add(Me.LoginPasslbl)
        Me.Controls.Add(Me.IDtxt)
        Me.Controls.Add(Me.LoginUserlbl)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Loginbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Loginbtn As System.Windows.Forms.Button
    Friend WithEvents User As System.Windows.Forms.Button
    Friend WithEvents LoginUserlbl As System.Windows.Forms.Label
    Friend WithEvents IDtxt As System.Windows.Forms.TextBox
    Friend WithEvents LoginPasslbl As System.Windows.Forms.Label
    Friend WithEvents Passtxt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ForgotPassbtn As System.Windows.Forms.LinkLabel
End Class
