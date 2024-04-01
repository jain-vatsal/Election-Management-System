<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voter_dashboard
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.LabelRollNumber = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.dgvElections = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCandidateReg = New System.Windows.Forms.Button()
        Me.LabelHostel = New System.Windows.Forms.Label()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.btnEnded = New System.Windows.Forms.Button()
        Me.btnUpcoming = New System.Windows.Forms.Button()
        Me.btnOngoing = New System.Windows.Forms.Button()
        Me.LabelElectionType = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.side_panel = New System.Windows.Forms.Panel()
        CType(Me.dgvElections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainpanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.side_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVote
        '
        Me.btnVote.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVote.Location = New System.Drawing.Point(118, 34)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(197, 65)
        Me.btnVote.TabIndex = 0
        Me.btnVote.Text = "Vote here"
        Me.btnVote.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Voter Dashboard"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelName.Location = New System.Drawing.Point(24, 157)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(64, 25)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Name"
        '
        'LabelCourse
        '
        Me.LabelCourse.AutoSize = True
        Me.LabelCourse.Location = New System.Drawing.Point(24, 263)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(76, 25)
        Me.LabelCourse.TabIndex = 3
        Me.LabelCourse.Text = "Course"
        '
        'LabelRollNumber
        '
        Me.LabelRollNumber.AutoSize = True
        Me.LabelRollNumber.Location = New System.Drawing.Point(24, 298)
        Me.LabelRollNumber.Name = "LabelRollNumber"
        Me.LabelRollNumber.Size = New System.Drawing.Size(79, 25)
        Me.LabelRollNumber.TabIndex = 4
        Me.LabelRollNumber.Text = "Roll No."
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(24, 192)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(60, 25)
        Me.LabelEmail.TabIndex = 6
        Me.LabelEmail.Text = "Email"
        '
        'dgvElections
        '
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvElections.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvElections.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvElections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvElections.DefaultCellStyle = DataGridViewCellStyle26
        Me.dgvElections.GridColor = System.Drawing.Color.SlateGray
        Me.dgvElections.Location = New System.Drawing.Point(39, 136)
        Me.dgvElections.Name = "dgvElections"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvElections.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.AliceBlue
        Me.dgvElections.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvElections.RowTemplate.Height = 24
        Me.dgvElections.Size = New System.Drawing.Size(720, 304)
        Me.dgvElections.TabIndex = 7
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Beige
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(81, 624)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(144, 54)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnCandidateReg
        '
        Me.btnCandidateReg.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCandidateReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCandidateReg.Location = New System.Drawing.Point(442, 34)
        Me.btnCandidateReg.Name = "btnCandidateReg"
        Me.btnCandidateReg.Size = New System.Drawing.Size(243, 65)
        Me.btnCandidateReg.TabIndex = 9
        Me.btnCandidateReg.Text = "Register as Candidate"
        Me.btnCandidateReg.UseVisualStyleBackColor = False
        '
        'LabelHostel
        '
        Me.LabelHostel.AutoSize = True
        Me.LabelHostel.Location = New System.Drawing.Point(24, 227)
        Me.LabelHostel.Name = "LabelHostel"
        Me.LabelHostel.Size = New System.Drawing.Size(67, 25)
        Me.LabelHostel.TabIndex = 10
        Me.LabelHostel.Text = "Hostel"
        '
        'mainpanel
        '
        Me.mainpanel.AutoSize = True
        Me.mainpanel.BackColor = System.Drawing.Color.AliceBlue
        Me.mainpanel.Controls.Add(Me.btnEnded)
        Me.mainpanel.Controls.Add(Me.btnUpcoming)
        Me.mainpanel.Controls.Add(Me.btnOngoing)
        Me.mainpanel.Controls.Add(Me.LabelElectionType)
        Me.mainpanel.Controls.Add(Me.Panel1)
        Me.mainpanel.Controls.Add(Me.Label1)
        Me.mainpanel.Controls.Add(Me.dgvElections)
        Me.mainpanel.Location = New System.Drawing.Point(321, 2)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(1061, 942)
        Me.mainpanel.TabIndex = 11
        '
        'btnEnded
        '
        Me.btnEnded.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEnded.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnded.Location = New System.Drawing.Point(522, 491)
        Me.btnEnded.Name = "btnEnded"
        Me.btnEnded.Size = New System.Drawing.Size(197, 65)
        Me.btnEnded.TabIndex = 15
        Me.btnEnded.Text = "Ended"
        Me.btnEnded.UseVisualStyleBackColor = False
        '
        'btnUpcoming
        '
        Me.btnUpcoming.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpcoming.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpcoming.Location = New System.Drawing.Point(282, 491)
        Me.btnUpcoming.Name = "btnUpcoming"
        Me.btnUpcoming.Size = New System.Drawing.Size(197, 65)
        Me.btnUpcoming.TabIndex = 14
        Me.btnUpcoming.Text = "Upcoming"
        Me.btnUpcoming.UseVisualStyleBackColor = False
        '
        'btnOngoing
        '
        Me.btnOngoing.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOngoing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOngoing.Location = New System.Drawing.Point(33, 491)
        Me.btnOngoing.Name = "btnOngoing"
        Me.btnOngoing.Size = New System.Drawing.Size(197, 65)
        Me.btnOngoing.TabIndex = 13
        Me.btnOngoing.Text = "Ongoing"
        Me.btnOngoing.UseVisualStyleBackColor = False
        '
        'LabelElectionType
        '
        Me.LabelElectionType.AutoSize = True
        Me.LabelElectionType.Location = New System.Drawing.Point(336, 103)
        Me.LabelElectionType.Name = "LabelElectionType"
        Me.LabelElectionType.Size = New System.Drawing.Size(94, 17)
        Me.LabelElectionType.TabIndex = 12
        Me.LabelElectionType.Text = "Election Type"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCandidateReg)
        Me.Panel1.Controls.Add(Me.btnVote)
        Me.Panel1.Location = New System.Drawing.Point(0, 588)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 131)
        Me.Panel1.TabIndex = 11
        '
        'side_panel
        '
        Me.side_panel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.side_panel.Controls.Add(Me.LabelHostel)
        Me.side_panel.Controls.Add(Me.btnLogout)
        Me.side_panel.Controls.Add(Me.LabelName)
        Me.side_panel.Controls.Add(Me.LabelEmail)
        Me.side_panel.Controls.Add(Me.LabelRollNumber)
        Me.side_panel.Controls.Add(Me.LabelCourse)
        Me.side_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.side_panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.side_panel.Location = New System.Drawing.Point(0, 0)
        Me.side_panel.Name = "side_panel"
        Me.side_panel.Size = New System.Drawing.Size(322, 722)
        Me.side_panel.TabIndex = 12
        '
        'voter_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 722)
        Me.Controls.Add(Me.side_panel)
        Me.Controls.Add(Me.mainpanel)
        Me.Name = "voter_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "voter_dashboard"
        CType(Me.dgvElections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.side_panel.ResumeLayout(False)
        Me.side_panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVote As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents LabelCourse As System.Windows.Forms.Label
    Friend WithEvents LabelRollNumber As System.Windows.Forms.Label
    Friend WithEvents LabelEmail As System.Windows.Forms.Label
    Friend WithEvents dgvElections As System.Windows.Forms.DataGridView
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnCandidateReg As System.Windows.Forms.Button
    Friend WithEvents LabelHostel As System.Windows.Forms.Label
    Friend WithEvents mainpanel As System.Windows.Forms.Panel
    Friend WithEvents side_panel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelElectionType As System.Windows.Forms.Label
    Friend WithEvents btnEnded As System.Windows.Forms.Button
    Friend WithEvents btnUpcoming As System.Windows.Forms.Button
    Friend WithEvents btnOngoing As System.Windows.Forms.Button
End Class
