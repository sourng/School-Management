﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Long_Program
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LVMainProgram = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtMainProgram = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ឈ្មោះកម្មវិធីសិក្សា (ជំ​នាញ)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.LVMainProgram)
        Me.GroupBox1.Controls.Add(Me.txtMainProgram)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 348)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "លេខរៀង"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(172, 13)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(112, 32)
        Me.txtID.TabIndex = 31
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.Navy
        Me.Label19.Font = New System.Drawing.Font("Khmer OS Battambang", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(-5, -2)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(5)
        Me.Label19.Size = New System.Drawing.Size(567, 56)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "ឈ្មោះកម្មវិធីសិក្សា (ជំ​នាញ)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LVMainProgram
        '
        Me.LVMainProgram.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LVMainProgram.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVMainProgram.Location = New System.Drawing.Point(18, 103)
        Me.LVMainProgram.Name = "LVMainProgram"
        Me.LVMainProgram.Size = New System.Drawing.Size(423, 239)
        Me.LVMainProgram.TabIndex = 55
        Me.LVMainProgram.UseCompatibleStateImageBehavior = False
        Me.LVMainProgram.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "លេខរៀង"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ឈ្មោះកម្មវិធីសិក្សា(ជំនាញ)"
        Me.ColumnHeader4.Width = 288
        '
        'txtMainProgram
        '
        Me.txtMainProgram.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMainProgram.Location = New System.Drawing.Point(172, 51)
        Me.txtMainProgram.Name = "txtMainProgram"
        Me.txtMainProgram.Size = New System.Drawing.Size(269, 30)
        Me.txtMainProgram.TabIndex = 54
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnUpdate.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(469, 146)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(65, 41)
        Me.btnUpdate.TabIndex = 56
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(469, 103)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 41)
        Me.btnDelete.TabIndex = 57
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAdd.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(469, 61)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 41)
        Me.btnAdd.TabIndex = 58
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnClear.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(469, 18)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 41)
        Me.btnClear.TabIndex = 59
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Register_Long_Program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 405)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Register_Long_Program"
        Me.Text = "Register_Long_Program"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LVMainProgram As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtMainProgram As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
