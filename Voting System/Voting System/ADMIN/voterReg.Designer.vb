<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voterReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(voterReg))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRoll = New System.Windows.Forms.TextBox()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboYear = New System.Windows.Forms.ComboBox()
        Me.comboCourse = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.comboHostel = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(122, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 21)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Email"
        '
        'txtRoll
        '
        Me.txtRoll.BackColor = System.Drawing.Color.FloralWhite
        Me.txtRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoll.Location = New System.Drawing.Point(246, 198)
        Me.txtRoll.Multiline = True
        Me.txtRoll.Name = "txtRoll"
        Me.txtRoll.Size = New System.Drawing.Size(336, 33)
        Me.txtRoll.TabIndex = 47
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_register.Location = New System.Drawing.Point(259, 478)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(193, 44)
        Me.btn_register.TabIndex = 43
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(122, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 21)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(122, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(122, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 21)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Year"
        '
        'comboYear
        '
        Me.comboYear.BackColor = System.Drawing.Color.FloralWhite
        Me.comboYear.DropDownHeight = 116
        Me.comboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboYear.FormattingEnabled = True
        Me.comboYear.IntegralHeight = False
        Me.comboYear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.comboYear.Location = New System.Drawing.Point(246, 342)
        Me.comboYear.Name = "comboYear"
        Me.comboYear.Size = New System.Drawing.Size(336, 28)
        Me.comboYear.TabIndex = 37
        '
        'comboCourse
        '
        Me.comboCourse.BackColor = System.Drawing.Color.FloralWhite
        Me.comboCourse.DropDownHeight = 116
        Me.comboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCourse.FormattingEnabled = True
        Me.comboCourse.IntegralHeight = False
        Me.comboCourse.Items.AddRange(New Object() {"B.Tech", "M.Tech"})
        Me.comboCourse.Location = New System.Drawing.Point(246, 298)
        Me.comboCourse.Name = "comboCourse"
        Me.comboCourse.Size = New System.Drawing.Size(336, 28)
        Me.comboCourse.TabIndex = 36
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FloralWhite
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(246, 99)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(336, 33)
        Me.txtname.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FloralWhite
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(246, 243)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(336, 33)
        Me.txtPassword.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(122, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 21)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Roll Number"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FloralWhite
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(246, 145)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(336, 33)
        Me.txtEmail.TabIndex = 49
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(524, 119)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(604, 49)
        Me.TextBox1.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(122, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 21)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Hostel"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(88, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 43)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Voter"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 68)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.comboHostel)
        Me.Panel1.Controls.Add(Me.btn_register)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.comboYear)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.comboCourse)
        Me.Panel1.Controls.Add(Me.txtRoll)
        Me.Panel1.Font = New System.Drawing.Font("MS Reference Specialty", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Panel1.Location = New System.Drawing.Point(304, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 608)
        Me.Panel1.TabIndex = 57
        '
        'comboHostel
        '
        Me.comboHostel.BackColor = System.Drawing.Color.FloralWhite
        Me.comboHostel.DropDownHeight = 116
        Me.comboHostel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboHostel.FormattingEnabled = True
        Me.comboHostel.IntegralHeight = False
        Me.comboHostel.Location = New System.Drawing.Point(246, 394)
        Me.comboHostel.Name = "comboHostel"
        Me.comboHostel.Size = New System.Drawing.Size(336, 28)
        Me.comboHostel.TabIndex = 55
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(309, 599)
        Me.Panel2.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(40, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 43)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Registration"
        '
        'voterReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1048, 618)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "voterReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "voterReg"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRoll As System.Windows.Forms.TextBox
    Friend WithEvents btn_register As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboYear As System.Windows.Forms.ComboBox
    Friend WithEvents comboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents comboHostel As System.Windows.Forms.ComboBox
End Class
