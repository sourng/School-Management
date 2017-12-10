<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Long_Program_List
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LVCourse = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboStuList = New System.Windows.Forms.ComboBox()
        Me.cboPrType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPrMainSubject = New System.Windows.Forms.ComboBox()
        Me.cbobach = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.LVCourse)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboStuList)
        Me.GroupBox1.Controls.Add(Me.cboPrType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPrMainSubject)
        Me.GroupBox1.Controls.Add(Me.cbobach)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(13, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(989, 449)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'LVCourse
        '
        Me.LVCourse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LVCourse.Location = New System.Drawing.Point(6, 81)
        Me.LVCourse.Name = "LVCourse"
        Me.LVCourse.Size = New System.Drawing.Size(977, 357)
        Me.LVCourse.TabIndex = 32
        Me.LVCourse.UseCompatibleStateImageBehavior = False
        Me.LVCourse.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#ល.រ"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ជំនាន់/ក្រុម"
        Me.ColumnHeader2.Width = 135
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ឈ្មោះកម្មវិធី(ជំនាញ)"
        Me.ColumnHeader3.Width = 235
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ប្រភេទ(កម្រិត)កម្មវិធី"
        Me.ColumnHeader4.Width = 155
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "បញ្ជីឈ្មោះសិស្ស"
        Me.ColumnHeader5.Width = 205
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 43)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(107, 32)
        Me.txtID.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(692, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 24)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "បញ្ជីឈ្មោះសិស្ស"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(513, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ប្រភេទ (កម្រិត) កម្មវិធី"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(273, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ឈ្មោះកម្មវិធីសិក្សា (ជំ​នាញ)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ឈ្មោះជំនាន់​ / ក្រុម"
        '
        'cboStuList
        '
        Me.cboStuList.FormattingEnabled = True
        Me.cboStuList.Location = New System.Drawing.Point(692, 40)
        Me.cboStuList.Name = "cboStuList"
        Me.cboStuList.Size = New System.Drawing.Size(132, 32)
        Me.cboStuList.TabIndex = 0
        '
        'cboPrType
        '
        Me.cboPrType.FormattingEnabled = True
        Me.cboPrType.Location = New System.Drawing.Point(513, 43)
        Me.cboPrType.Name = "cboPrType"
        Me.cboPrType.Size = New System.Drawing.Size(168, 32)
        Me.cboPrType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "លេខរៀង"
        '
        'cboPrMainSubject
        '
        Me.cboPrMainSubject.FormattingEnabled = True
        Me.cboPrMainSubject.Location = New System.Drawing.Point(273, 43)
        Me.cboPrMainSubject.Name = "cboPrMainSubject"
        Me.cboPrMainSubject.Size = New System.Drawing.Size(231, 32)
        Me.cboPrMainSubject.TabIndex = 0
        '
        'cbobach
        '
        Me.cbobach.FormattingEnabled = True
        Me.cbobach.Location = New System.Drawing.Point(119, 43)
        Me.cbobach.Name = "cbobach"
        Me.cbobach.Size = New System.Drawing.Size(144, 32)
        Me.cbobach.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(1023, 56)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "បញ្ជីកម្មវិធីវគ្គវែង (PL)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Long_Program_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 523)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Long_Program_List"
        Me.Text = "Long_Program_List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPrType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPrMainSubject As System.Windows.Forms.ComboBox
    Friend WithEvents cbobach As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboStuList As System.Windows.Forms.ComboBox
    Friend WithEvents LVCourse As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
