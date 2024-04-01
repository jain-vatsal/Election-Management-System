<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class upcomingelections
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
        Me.backBtn = New System.Windows.Forms.Button()
        Me.dgvElections = New System.Windows.Forms.DataGridView()
        CType(Me.dgvElections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backBtn
        '
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.Location = New System.Drawing.Point(989, 32)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(150, 62)
        Me.backBtn.TabIndex = 0
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'dgvElections
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvElections.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvElections.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvElections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElections.Location = New System.Drawing.Point(201, 29)
        Me.dgvElections.Name = "dgvElections"
        Me.dgvElections.RowTemplate.Height = 24
        Me.dgvElections.Size = New System.Drawing.Size(685, 632)
        Me.dgvElections.TabIndex = 1
        '
        'upcomingelections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1185, 708)
        Me.Controls.Add(Me.dgvElections)
        Me.Controls.Add(Me.backBtn)
        Me.Name = "upcomingelections"
        Me.Text = "upcomingelections"
        CType(Me.dgvElections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backBtn As System.Windows.Forms.Button
    Friend WithEvents dgvElections As System.Windows.Forms.DataGridView
End Class
