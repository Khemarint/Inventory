<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnGoLogin = New System.Windows.Forms.Button()
        Me.RdoMale = New System.Windows.Forms.RadioButton()
        Me.RdoFemale = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblRegister
        '
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(210, 35)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(240, 88)
        Me.lblRegister.TabIndex = 0
        Me.lblRegister.Text = "Register"
        Me.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRegister.UseCompatibleTextRendering = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(257, 180)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(210, 22)
        Me.txtUsername.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(179, 183)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(70, 16)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(181, 238)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 16)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(257, 235)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(210, 22)
        Me.txtPassword.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(199, 291)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(257, 288)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(210, 22)
        Me.txtEmail.TabIndex = 7
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(359, 395)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(108, 32)
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnGoLogin
        '
        Me.btnGoLogin.Location = New System.Drawing.Point(202, 395)
        Me.btnGoLogin.Name = "btnGoLogin"
        Me.btnGoLogin.Size = New System.Drawing.Size(108, 32)
        Me.btnGoLogin.TabIndex = 11
        Me.btnGoLogin.Text = "BackLogin"
        Me.btnGoLogin.UseVisualStyleBackColor = True
        '
        'RdoMale
        '
        Me.RdoMale.AutoSize = True
        Me.RdoMale.Location = New System.Drawing.Point(257, 340)
        Me.RdoMale.Name = "RdoMale"
        Me.RdoMale.Size = New System.Drawing.Size(58, 20)
        Me.RdoMale.TabIndex = 12
        Me.RdoMale.TabStop = True
        Me.RdoMale.Text = "Male"
        Me.RdoMale.UseVisualStyleBackColor = True
        '
        'RdoFemale
        '
        Me.RdoFemale.AutoSize = True
        Me.RdoFemale.Location = New System.Drawing.Point(394, 340)
        Me.RdoFemale.Name = "RdoFemale"
        Me.RdoFemale.Size = New System.Drawing.Size(74, 20)
        Me.RdoFemale.TabIndex = 13
        Me.RdoFemale.TabStop = True
        Me.RdoFemale.Text = "Female"
        Me.RdoFemale.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 562)
        Me.Controls.Add(Me.RdoFemale)
        Me.Controls.Add(Me.RdoMale)
        Me.Controls.Add(Me.btnGoLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Inventory Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegister As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnGoLogin As Button
    Friend WithEvents RdoMale As RadioButton
    Friend WithEvents RdoFemale As RadioButton
End Class
