<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewCandidates
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
        Me.dgvCandidates = New System.Windows.Forms.DataGridView()
        Me.backBtn = New System.Windows.Forms.Button()
        CType(Me.dgvCandidates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCandidates
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvCandidates.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCandidates.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCandidates.GridColor = System.Drawing.Color.AliceBlue
        Me.dgvCandidates.Location = New System.Drawing.Point(264, 95)
        Me.dgvCandidates.Name = "dgvCandidates"
        Me.dgvCandidates.RowTemplate.Height = 24
        Me.dgvCandidates.Size = New System.Drawing.Size(579, 499)
        Me.dgvCandidates.TabIndex = 0
        '
        'backBtn
        '
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.Location = New System.Drawing.Point(977, 37)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(147, 60)
        Me.backBtn.TabIndex = 1
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'viewCandidates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1168, 739)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.dgvCandidates)
        Me.Name = "viewCandidates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewCandidates"
        CType(Me.dgvCandidates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCandidates As System.Windows.Forms.DataGridView
    Friend WithEvents backBtn As System.Windows.Forms.Button
End Class
