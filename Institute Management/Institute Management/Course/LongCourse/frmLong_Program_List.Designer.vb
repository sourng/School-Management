﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLong_Program_List
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboStuList = New System.Windows.Forms.ComboBox()
        Me.cboPrType = New System.Windows.Forms.ComboBox()
        Me.cboPrMainSubject = New System.Windows.Forms.ComboBox()
        Me.cbobach = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(965, 56)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "បញ្ជីកម្មវិធីវគ្គវែង (PL)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.LVCourse)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboStuList)
        Me.GroupBox1.Controls.Add(Me.cboPrType)
        Me.GroupBox1.Controls.Add(Me.cboPrMainSubject)
        Me.GroupBox1.Controls.Add(Me.cbobach)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 449)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnUpdate.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(811, 167)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 41)
        Me.btnUpdate.TabIndex = 60
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(811, 124)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 41)
        Me.btnDelete.TabIndex = 61
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAdd.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(811, 82)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 41)
        Me.btnAdd.TabIndex = 62
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnClear.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(811, 39)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 41)
        Me.btnClear.TabIndex = 63
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'LVCourse
        '
        Me.LVCourse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LVCourse.Location = New System.Drawing.Point(7, 88)
        Me.LVCourse.Name = "LVCourse"
        Me.LVCourse.Size = New System.Drawing.Size(790, 345)
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
        Me.txtID.Location = New System.Drawing.Point(7, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(81, 32)
        Me.txtID.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(669, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 24)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "បញ្ជីឈ្មោះសិស្ស"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(496, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ប្រភេទ (កម្រិត) កម្មវិធី"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ឈ្មោះកម្មវិធីសិក្សា (ជំ​នាញ)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "លេខរៀង"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ឈ្មោះជំនាន់​ / ក្រុម"
        '
        'cboStuList
        '
        Me.cboStuList.FormattingEnabled = True
        Me.cboStuList.Location = New System.Drawing.Point(663, 50)
        Me.cboStuList.Name = "cboStuList"
        Me.cboStuList.Size = New System.Drawing.Size(132, 32)
        Me.cboStuList.TabIndex = 0
        '
        'cboPrType
        '
        Me.cboPrType.FormattingEnabled = True
        Me.cboPrType.Location = New System.Drawing.Point(478, 50)
        Me.cboPrType.Name = "cboPrType"
        Me.cboPrType.Size = New System.Drawing.Size(180, 32)
        Me.cboPrType.TabIndex = 0
        '
        'cboPrMainSubject
        '
        Me.cboPrMainSubject.FormattingEnabled = True
        Me.cboPrMainSubject.Location = New System.Drawing.Point(242, 50)
        Me.cboPrMainSubject.Name = "cboPrMainSubject"
        Me.cboPrMainSubject.Size = New System.Drawing.Size(231, 32)
        Me.cboPrMainSubject.TabIndex = 0
        '
        'cbobach
        '
        Me.cbobach.FormattingEnabled = True
        Me.cbobach.Location = New System.Drawing.Point(93, 50)
        Me.cbobach.Name = "cbobach"
        Me.cbobach.Size = New System.Drawing.Size(144, 32)
        Me.cbobach.TabIndex = 0
        '
        'frmLong_Program_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 512)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLong_Program_List"
        Me.Text = "Long_Program_List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LVCourse As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboStuList As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrType As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrMainSubject As System.Windows.Forms.ComboBox
    Friend WithEvents cbobach As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
