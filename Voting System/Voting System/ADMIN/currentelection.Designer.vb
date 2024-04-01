<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currentelection
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
        Me.lblElectionName = New System.Windows.Forms.Label()
        Me.ListBoxPositions = New System.Windows.Forms.ListBox()
        Me.btnConfirmVote = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelCandidates = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'lblElectionName
        '
        Me.lblElectionName.AutoSize = True
        Me.lblElectionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElectionName.ForeColor = System.Drawing.Color.Black
        Me.lblElectionName.Location = New System.Drawing.Point(65, 51)
        Me.lblElectionName.Name = "lblElectionName"
        Me.lblElectionName.Size = New System.Drawing.Size(151, 25)
        Me.lblElectionName.TabIndex = 7
        Me.lblElectionName.Text = "Election Name"
        '
        'ListBoxPositions
        '
        Me.ListBoxPositions.BackColor = System.Drawing.Color.AliceBlue
        Me.ListBoxPositions.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPositions.FormattingEnabled = True
        Me.ListBoxPositions.ItemHeight = 29
        Me.ListBoxPositions.Location = New System.Drawing.Point(59, 210)
        Me.ListBoxPositions.Name = "ListBoxPositions"
        Me.ListBoxPositions.Size = New System.Drawing.Size(273, 410)
        Me.ListBoxPositions.TabIndex = 9
        '
        'btnConfirmVote
        '
        Me.btnConfirmVote.BackColor = System.Drawing.Color.Beige
        Me.btnConfirmVote.Location = New System.Drawing.Point(895, 36)
        Me.btnConfirmVote.Name = "btnConfirmVote"
        Me.btnConfirmVote.Size = New System.Drawing.Size(170, 61)
        Me.btnConfirmVote.TabIndex = 10
        Me.btnConfirmVote.Text = "General Ballot"
        Me.btnConfirmVote.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Choose the candidate you wish to vote for and then click on 'Save Vote.'"
        '
        'FlowLayoutPanelCandidates
        '
        Me.FlowLayoutPanelCandidates.BackColor = System.Drawing.Color.AliceBlue
        Me.FlowLayoutPanelCandidates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanelCandidates.Location = New System.Drawing.Point(396, 210)
        Me.FlowLayoutPanelCandidates.Name = "FlowLayoutPanelCandidates"
        Me.FlowLayoutPanelCandidates.Size = New System.Drawing.Size(574, 404)
        Me.FlowLayoutPanelCandidates.TabIndex = 12
        '
        'currentelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1127, 645)
        Me.Controls.Add(Me.FlowLayoutPanelCandidates)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirmVote)
        Me.Controls.Add(Me.ListBoxPositions)
        Me.Controls.Add(Me.lblElectionName)
        Me.Name = "currentelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "currentelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblElectionName As System.Windows.Forms.Label
    Friend WithEvents ListBoxPositions As System.Windows.Forms.ListBox
    Friend WithEvents btnConfirmVote As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanelCandidates As System.Windows.Forms.FlowLayoutPanel
End Class
