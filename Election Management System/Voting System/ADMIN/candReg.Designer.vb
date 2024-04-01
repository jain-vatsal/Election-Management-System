<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class candReg
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAgendas = New System.Windows.Forms.TextBox()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboPosition = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-24, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 85)
        Me.Panel1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Candidate Registration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 25)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Agendas"
        '
        'txtAgendas
        '
        Me.txtAgendas.BackColor = System.Drawing.Color.FloralWhite
        Me.txtAgendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgendas.Location = New System.Drawing.Point(330, 276)
        Me.txtAgendas.Multiline = True
        Me.txtAgendas.Name = "txtAgendas"
        Me.txtAgendas.Size = New System.Drawing.Size(285, 33)
        Me.txtAgendas.TabIndex = 29
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.Location = New System.Drawing.Point(295, 371)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(210, 49)
        Me.btn_register.TabIndex = 27
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Position"
        '
        'comboPosition
        '
        Me.comboPosition.BackColor = System.Drawing.Color.FloralWhite
        Me.comboPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboPosition.FormattingEnabled = True
        Me.comboPosition.Items.AddRange(New Object() {"VicePresident", "TechnicalSecretary", "WelfareSecretary", "SportsSecretary", "Senator"})
        Me.comboPosition.Location = New System.Drawing.Point(330, 191)
        Me.comboPosition.Name = "comboPosition"
        Me.comboPosition.Size = New System.Drawing.Size(285, 33)
        Me.comboPosition.TabIndex = 22
        '
        'candReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(827, 494)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAgendas)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboPosition)
        Me.Name = "candReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "candReg"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAgendas As System.Windows.Forms.TextBox
    Friend WithEvents btn_register As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
