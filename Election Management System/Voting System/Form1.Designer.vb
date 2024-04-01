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
        Me.btn_exit = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.combo_role = New System.Windows.Forms.ComboBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_usrname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.AutoSize = True
        Me.btn_exit.Location = New System.Drawing.Point(672, 45)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(51, 22)
        Me.btn_exit.TabIndex = 25
        Me.btn_exit.TabStop = True
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Goudy Old Style", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 21)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Role"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Goudy Old Style", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username"
        '
        'btn_register
        '
        Me.btn_register.Location = New System.Drawing.Point(302, 395)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(129, 36)
        Me.btn_register.TabIndex = 21
        Me.btn_register.Text = "Login"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'combo_role
        '
        Me.combo_role.FormattingEnabled = True
        Me.combo_role.Items.AddRange(New Object() {"Student", "Candidate"})
        Me.combo_role.Location = New System.Drawing.Point(207, 322)
        Me.combo_role.Name = "combo_role"
        Me.combo_role.Size = New System.Drawing.Size(380, 24)
        Me.combo_role.TabIndex = 20
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(207, 226)
        Me.txt_pass.Multiline = True
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(380, 39)
        Me.txt_pass.TabIndex = 19
        '
        'txt_usrname
        '
        Me.txt_usrname.Location = New System.Drawing.Point(207, 147)
        Me.txt_usrname.Multiline = True
        Me.txt_usrname.Name = "txt_usrname"
        Me.txt_usrname.Size = New System.Drawing.Size(380, 39)
        Me.txt_usrname.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(823, 495)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.combo_role)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_usrname)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_register As System.Windows.Forms.Button
    Friend WithEvents combo_role As System.Windows.Forms.ComboBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_usrname As System.Windows.Forms.TextBox

End Class
