<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRegister
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("ID")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Code")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Name(KH)")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Name(EN)")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Gender")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Date Of Birth")
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBrowIM = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtRetypePass = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LVCourseOfEdu = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPermission = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExport = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(860, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 174)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-5, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(1053, 56)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ការចុះឈ្មោះអ្នកប្រើប្រាស់"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(952, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 35)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "ថតរូប"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnBrowIM
        '
        Me.btnBrowIM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowIM.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowIM.Location = New System.Drawing.Point(860, 192)
        Me.btnBrowIM.Name = "btnBrowIM"
        Me.btnBrowIM.Size = New System.Drawing.Size(86, 35)
        Me.btnBrowIM.TabIndex = 17
        Me.btnBrowIM.Text = "ជ្រើសរូបថត"
        Me.btnBrowIM.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Location = New System.Drawing.Point(860, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 245)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(6, 13)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(163, 34)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "សិស្សថ្មី"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(6, 203)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(163, 34)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "ចំណាយ"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 143)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(163, 34)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "កែប្រែ"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(6, 96)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 34)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "ត្រឡប់ក្រោយ"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(6, 53)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(163, 34)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "រក្សារទុក"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.txtRetypePass)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtRecord)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LVCourseOfEdu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPermission)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 415)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(708, 54)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(109, 32)
        Me.cboGender.TabIndex = 32
        '
        'txtRetypePass
        '
        Me.txtRetypePass.Location = New System.Drawing.Point(358, 119)
        Me.txtRetypePass.Name = "txtRetypePass"
        Me.txtRetypePass.Size = New System.Drawing.Size(146, 32)
        Me.txtRetypePass.TabIndex = 31
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(212, 119)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(139, 32)
        Me.txtPassword.TabIndex = 31
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(357, 54)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(155, 32)
        Me.txtLName.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(15, 119)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(191, 32)
        Me.txtEmail.TabIndex = 31
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(518, 54)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(184, 32)
        Me.txtUserName.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(519, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Permission"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(354, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Retype PassWord"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(212, 54)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(139, 32)
        Me.txtFName.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(212, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Pass Word"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "E-Mail"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(704, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 24)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(514, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "User Name"
        '
        'txtRecord
        '
        Me.txtRecord.Location = New System.Drawing.Point(105, 54)
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.Size = New System.Drawing.Size(101, 32)
        Me.txtRecord.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "First Name"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(15, 54)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(84, 32)
        Me.txtID.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Record #"
        '
        'LVCourseOfEdu
        '
        Me.LVCourseOfEdu.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.LVCourseOfEdu.Location = New System.Drawing.Point(15, 162)
        Me.LVCourseOfEdu.Name = "LVCourseOfEdu"
        Me.LVCourseOfEdu.Size = New System.Drawing.Size(802, 235)
        Me.LVCourseOfEdu.TabIndex = 30
        Me.LVCourseOfEdu.UseCompatibleStateImageBehavior = False
        Me.LVCourseOfEdu.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No."
        '
        'cboPermission
        '
        Me.cboPermission.FormattingEnabled = True
        Me.cboPermission.Location = New System.Drawing.Point(518, 119)
        Me.cboPermission.Name = "cboPermission"
        Me.cboPermission.Size = New System.Drawing.Size(299, 32)
        Me.cboPermission.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnEdit, Me.btnDelete, Me.btnSearch, Me.btnPrint, Me.btnExport, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 485)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1047, 39)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.Image = Global.Institute_Management.My.Resources.Resources.if_Plus_206460
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(93, 36)
        Me.btnNew.Text = "បន្ថែម​ថ្មី"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Institute_Management.My.Resources.Resources.if_floppy_285657
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 36)
        Me.btnSave.Text = "រក្សាទុក"
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Institute_Management.My.Resources.Resources.if_retweet_334739
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(123, 36)
        Me.btnEdit.Text = "បន្ទាន់​សម័យ"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Institute_Management.My.Resources.Resources.if_edit_delete_23231
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 36)
        Me.btnDelete.Text = "លុប"
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.Institute_Management.My.Resources.Resources.if_Find_27847
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 36)
        Me.btnSearch.Text = "ស្វែងរក"
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.Institute_Management.My.Resources.Resources.if_print_173079
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(95, 36)
        Me.btnPrint.Text = "បោះពុម្ភ"
        '
        'btnExport
        '
        Me.btnExport.Image = Global.Institute_Management.My.Resources.Resources.if_export_excel_64174
        Me.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(154, 36)
        Me.btnExport.Text = "នាំចេញទៅ​ Excel"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Institute_Management.My.Resources.Resources.if_close_delete_70975
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 36)
        Me.btnClose.Text = "បិត"
        '
        'frmUserRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 524)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBrowIM)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmUserRegister"
        Me.Text = "frmUserRegister"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnBrowIM As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents LVCourseOfEdu As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPermission As System.Windows.Forms.ComboBox
    Friend WithEvents txtRecord As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRetypePass As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExport As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
End Class
