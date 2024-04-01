<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_page))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRole = New System.Windows.Forms.ComboBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Role = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnVoterRegsiter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FloralWhite
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(699, 139)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(221, 37)
        Me.txtEmail.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FloralWhite
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(699, 190)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(221, 37)
        Me.txtPassword.TabIndex = 1
        '
        'txtRole
        '
        Me.txtRole.BackColor = System.Drawing.Color.FloralWhite
        Me.txtRole.DropDownHeight = 124
        Me.txtRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.FormattingEnabled = True
        Me.txtRole.IntegralHeight = False
        Me.txtRole.Location = New System.Drawing.Point(699, 249)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(221, 28)
        Me.txtRole.TabIndex = 2
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(556, 144)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(56, 20)
        Me.Email.TabIndex = 3
        Me.Email.Text = "Email"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(556, 195)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(91, 20)
        Me.Password.TabIndex = 4
        Me.Password.Text = "Password"
        '
        'Role
        '
        Me.Role.AutoSize = True
        Me.Role.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role.Location = New System.Drawing.Point(556, 253)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(47, 20)
        Me.Role.TabIndex = 5
        Me.Role.Text = "Role"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(720, 332)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(175, 56)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnVoterRegsiter
        '
        Me.btnVoterRegsiter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVoterRegsiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoterRegsiter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVoterRegsiter.Location = New System.Drawing.Point(699, 469)
        Me.btnVoterRegsiter.Name = "btnVoterRegsiter"
        Me.btnVoterRegsiter.Size = New System.Drawing.Size(250, 55)
        Me.btnVoterRegsiter.TabIndex = 8
        Me.btnVoterRegsiter.Text = "Voter Registration"
        Me.btnVoterRegsiter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnVoterRegsiter)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Role)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Email)
        Me.Panel1.Controls.Add(Me.txtRole)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1144, 664)
        Me.Panel1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(594, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Login using your account"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(521, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "If not registered : "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 662)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(68, 44)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(188, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(64, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 35)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Election System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student Council"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'login_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1144, 664)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "login_page"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login_page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtRole As System.Windows.Forms.ComboBox
    Friend WithEvents Email As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents Role As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnVoterRegsiter As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
