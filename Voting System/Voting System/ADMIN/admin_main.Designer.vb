<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.side_panel = New System.Windows.Forms.Panel()
        Me.startElection = New System.Windows.Forms.Button()
        Me.btnPastElections = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_strt = New System.Windows.Forms.Button()
        Me.btn_addAdmin = New System.Windows.Forms.Button()
        Me.btn_candidates = New System.Windows.Forms.Button()
        Me.btn_voters = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.side_panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MainPanel)
        Me.Panel1.Controls.Add(Me.side_panel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 751)
        Me.Panel1.TabIndex = 0
        '
        'MainPanel
        '
        Me.MainPanel.AutoScroll = True
        Me.MainPanel.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.MainPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainPanel.Controls.Add(Me.Label1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(306, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(972, 751)
        Me.MainPanel.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'side_panel
        '
        Me.side_panel.AutoScroll = True
        Me.side_panel.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.side_panel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.side_panel.Controls.Add(Me.startElection)
        Me.side_panel.Controls.Add(Me.btnPastElections)
        Me.side_panel.Controls.Add(Me.PictureBox1)
        Me.side_panel.Controls.Add(Me.btn_logout)
        Me.side_panel.Controls.Add(Me.btn_end)
        Me.side_panel.Controls.Add(Me.btn_strt)
        Me.side_panel.Controls.Add(Me.btn_addAdmin)
        Me.side_panel.Controls.Add(Me.btn_candidates)
        Me.side_panel.Controls.Add(Me.btn_voters)
        Me.side_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.side_panel.Location = New System.Drawing.Point(0, 0)
        Me.side_panel.Name = "side_panel"
        Me.side_panel.Size = New System.Drawing.Size(306, 751)
        Me.side_panel.TabIndex = 14
        '
        'startElection
        '
        Me.startElection.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.startElection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startElection.Location = New System.Drawing.Point(59, 379)
        Me.startElection.Name = "startElection"
        Me.startElection.Size = New System.Drawing.Size(175, 51)
        Me.startElection.TabIndex = 22
        Me.startElection.Text = "Start Election"
        Me.startElection.UseVisualStyleBackColor = False
        '
        'btnPastElections
        '
        Me.btnPastElections.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPastElections.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastElections.Location = New System.Drawing.Point(59, 322)
        Me.btnPastElections.Name = "btnPastElections"
        Me.btnPastElections.Size = New System.Drawing.Size(175, 51)
        Me.btnPastElections.TabIndex = 21
        Me.btnPastElections.Text = "Past elections"
        Me.btnPastElections.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(84, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Beige
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(59, 686)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(175, 53)
        Me.btn_logout.TabIndex = 18
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_end
        '
        Me.btn_end.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_end.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.Location = New System.Drawing.Point(59, 493)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(175, 51)
        Me.btn_end.TabIndex = 17
        Me.btn_end.Text = "End Election"
        Me.btn_end.UseVisualStyleBackColor = False
        '
        'btn_strt
        '
        Me.btn_strt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_strt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_strt.Location = New System.Drawing.Point(59, 436)
        Me.btn_strt.Name = "btn_strt"
        Me.btn_strt.Size = New System.Drawing.Size(175, 51)
        Me.btn_strt.TabIndex = 16
        Me.btn_strt.Text = "Add Election"
        Me.btn_strt.UseVisualStyleBackColor = False
        '
        'btn_addAdmin
        '
        Me.btn_addAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_addAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addAdmin.Location = New System.Drawing.Point(59, 265)
        Me.btn_addAdmin.Name = "btn_addAdmin"
        Me.btn_addAdmin.Size = New System.Drawing.Size(175, 51)
        Me.btn_addAdmin.TabIndex = 15
        Me.btn_addAdmin.Text = "Add Admin"
        Me.btn_addAdmin.UseVisualStyleBackColor = False
        '
        'btn_candidates
        '
        Me.btn_candidates.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_candidates.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_candidates.Location = New System.Drawing.Point(59, 208)
        Me.btn_candidates.Name = "btn_candidates"
        Me.btn_candidates.Size = New System.Drawing.Size(175, 51)
        Me.btn_candidates.TabIndex = 14
        Me.btn_candidates.Text = "Candidates Info"
        Me.btn_candidates.UseVisualStyleBackColor = False
        '
        'btn_voters
        '
        Me.btn_voters.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_voters.FlatAppearance.BorderSize = 0
        Me.btn_voters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voters.Location = New System.Drawing.Point(59, 151)
        Me.btn_voters.Name = "btn_voters"
        Me.btn_voters.Size = New System.Drawing.Size(175, 51)
        Me.btn_voters.TabIndex = 13
        Me.btn_voters.Text = "Voters Info"
        Me.btn_voters.UseVisualStyleBackColor = False
        '
        'admin_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 40)
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1278, 751)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "admin_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_main"
        Me.Panel1.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.side_panel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents side_panel As System.Windows.Forms.Panel
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_end As System.Windows.Forms.Button
    Friend WithEvents btn_strt As System.Windows.Forms.Button
    Friend WithEvents btn_addAdmin As System.Windows.Forms.Button
    Friend WithEvents btn_candidates As System.Windows.Forms.Button
    Friend WithEvents btn_voters As System.Windows.Forms.Button
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPastElections As System.Windows.Forms.Button
    Friend WithEvents startElection As System.Windows.Forms.Button
End Class
