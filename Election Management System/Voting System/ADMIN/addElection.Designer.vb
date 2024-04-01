<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addElection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtelectionName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewPositions = New System.Windows.Forms.DataGridView()
        Me.ButtonAddElection = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.txtPositionName = New System.Windows.Forms.TextBox()
        Me.btnAddPosition = New System.Windows.Forms.Button()
        Me.lblElectionType = New System.Windows.Forms.Label()
        Me.DateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.comboElectionType = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridViewPositions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Election Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Positions"
        '
        'txtelectionName
        '
        Me.txtelectionName.BackColor = System.Drawing.Color.FloralWhite
        Me.txtelectionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtelectionName.Location = New System.Drawing.Point(221, 117)
        Me.txtelectionName.Multiline = True
        Me.txtelectionName.Name = "txtelectionName"
        Me.txtelectionName.Size = New System.Drawing.Size(200, 36)
        Me.txtelectionName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Election Name"
        '
        'DateTimePickerStart
        '
        Me.DateTimePickerStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerStart.Location = New System.Drawing.Point(221, 258)
        Me.DateTimePickerStart.Name = "DateTimePickerStart"
        Me.DateTimePickerStart.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePickerStart.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Start date time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "End date time"
        '
        'DataGridViewPositions
        '
        Me.DataGridViewPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPositions.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPositions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPositions.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewPositions.Location = New System.Drawing.Point(197, 400)
        Me.DataGridViewPositions.Name = "DataGridViewPositions"
        Me.DataGridViewPositions.RowTemplate.Height = 24
        Me.DataGridViewPositions.Size = New System.Drawing.Size(236, 102)
        Me.DataGridViewPositions.TabIndex = 8
        '
        'ButtonAddElection
        '
        Me.ButtonAddElection.BackColor = System.Drawing.Color.LimeGreen
        Me.ButtonAddElection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddElection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddElection.Location = New System.Drawing.Point(61, 532)
        Me.ButtonAddElection.Name = "ButtonAddElection"
        Me.ButtonAddElection.Size = New System.Drawing.Size(154, 42)
        Me.ButtonAddElection.TabIndex = 9
        Me.ButtonAddElection.Text = "Add Election"
        Me.ButtonAddElection.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.LimeGreen
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(267, 532)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(132, 42)
        Me.ButtonClear.TabIndex = 10
        Me.ButtonClear.Text = "Back"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'txtPositionName
        '
        Me.txtPositionName.BackColor = System.Drawing.Color.FloralWhite
        Me.txtPositionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPositionName.Location = New System.Drawing.Point(221, 340)
        Me.txtPositionName.Name = "txtPositionName"
        Me.txtPositionName.Size = New System.Drawing.Size(200, 30)
        Me.txtPositionName.TabIndex = 11
        '
        'btnAddPosition
        '
        Me.btnAddPosition.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPosition.Location = New System.Drawing.Point(24, 432)
        Me.btnAddPosition.Name = "btnAddPosition"
        Me.btnAddPosition.Size = New System.Drawing.Size(156, 44)
        Me.btnAddPosition.TabIndex = 12
        Me.btnAddPosition.Text = "Add Position"
        Me.btnAddPosition.UseVisualStyleBackColor = False
        '
        'lblElectionType
        '
        Me.lblElectionType.AutoSize = True
        Me.lblElectionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElectionType.Location = New System.Drawing.Point(37, 191)
        Me.lblElectionType.Name = "lblElectionType"
        Me.lblElectionType.Size = New System.Drawing.Size(131, 25)
        Me.lblElectionType.TabIndex = 13
        Me.lblElectionType.Text = "Election Type"
        '
        'DateTimePickerEnd
        '
        Me.DateTimePickerEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerEnd.Location = New System.Drawing.Point(221, 308)
        Me.DateTimePickerEnd.Name = "DateTimePickerEnd"
        Me.DateTimePickerEnd.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePickerEnd.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.comboElectionType)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonAddElection)
        Me.Panel1.Controls.Add(Me.ButtonClear)
        Me.Panel1.Controls.Add(Me.btnAddPosition)
        Me.Panel1.Controls.Add(Me.lblElectionType)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DataGridViewPositions)
        Me.Panel1.Controls.Add(Me.txtPositionName)
        Me.Panel1.Controls.Add(Me.txtelectionName)
        Me.Panel1.Controls.Add(Me.DateTimePickerStart)
        Me.Panel1.Controls.Add(Me.DateTimePickerEnd)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(167, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 628)
        Me.Panel1.TabIndex = 15
        '
        'comboElectionType
        '
        Me.comboElectionType.BackColor = System.Drawing.Color.FloralWhite
        Me.comboElectionType.FormattingEnabled = True
        Me.comboElectionType.Location = New System.Drawing.Point(220, 191)
        Me.comboElectionType.Name = "comboElectionType"
        Me.comboElectionType.Size = New System.Drawing.Size(200, 24)
        Me.comboElectionType.TabIndex = 15
        '
        'addElection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 40)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(844, 663)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "addElection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addElection"
        CType(Me.DataGridViewPositions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtelectionName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewPositions As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAddElection As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents txtPositionName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddPosition As System.Windows.Forms.Button
    Friend WithEvents lblElectionType As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents comboElectionType As System.Windows.Forms.ComboBox
End Class
