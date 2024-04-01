<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ballots
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBallot = New System.Windows.Forms.DataGridView()
        Me.electionName = New System.Windows.Forms.Label()
        Me.voterName = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        CType(Me.dgvBallot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBallot
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvBallot.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBallot.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvBallot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBallot.GridColor = System.Drawing.Color.Gray
        Me.dgvBallot.Location = New System.Drawing.Point(279, 133)
        Me.dgvBallot.Name = "dgvBallot"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBallot.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.AliceBlue
        Me.dgvBallot.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBallot.RowTemplate.Height = 24
        Me.dgvBallot.Size = New System.Drawing.Size(567, 426)
        Me.dgvBallot.TabIndex = 0
        '
        'electionName
        '
        Me.electionName.AutoSize = True
        Me.electionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.electionName.Location = New System.Drawing.Point(114, 35)
        Me.electionName.Name = "electionName"
        Me.electionName.Size = New System.Drawing.Size(86, 29)
        Me.electionName.TabIndex = 1
        Me.electionName.Text = "Label1"
        '
        'voterName
        '
        Me.voterName.AutoSize = True
        Me.voterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voterName.Location = New System.Drawing.Point(91, 167)
        Me.voterName.Name = "voterName"
        Me.voterName.Size = New System.Drawing.Size(71, 25)
        Me.voterName.TabIndex = 2
        Me.voterName.Text = "Label2"
        '
        'backBtn
        '
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.Location = New System.Drawing.Point(940, 44)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(140, 54)
        Me.backBtn.TabIndex = 3
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'ballots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1138, 637)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.voterName)
        Me.Controls.Add(Me.electionName)
        Me.Controls.Add(Me.dgvBallot)
        Me.Name = "ballots"
        Me.Text = "ballotsd"
        CType(Me.dgvBallot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBallot As System.Windows.Forms.DataGridView
    Friend WithEvents electionName As System.Windows.Forms.Label
    Friend WithEvents voterName As System.Windows.Forms.Label
    Friend WithEvents backBtn As System.Windows.Forms.Button
End Class
