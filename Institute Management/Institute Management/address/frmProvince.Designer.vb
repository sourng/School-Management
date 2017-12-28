<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProvince
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProvince))
        Me.lbl_province_title = New System.Windows.Forms.Label()
        Me.lvProvince = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grbProvinceInfo = New System.Windows.Forms.GroupBox()
        Me.txtProvince_En = New System.Windows.Forms.TextBox()
        Me.lbl_province_en = New System.Windows.Forms.Label()
        Me.txtProvince_Kh = New System.Windows.Forms.TextBox()
        Me.lbl_province_kh = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtTotalDistrict = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCommune = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbProvinceInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_province_title
        '
        Me.lbl_province_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_province_title.BackColor = System.Drawing.Color.Navy
        Me.lbl_province_title.Font = New System.Drawing.Font("Khmer OS Battambang", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_province_title.ForeColor = System.Drawing.Color.White
        Me.lbl_province_title.Location = New System.Drawing.Point(1, 0)
        Me.lbl_province_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_province_title.Name = "lbl_province_title"
        Me.lbl_province_title.Padding = New System.Windows.Forms.Padding(5)
        Me.lbl_province_title.Size = New System.Drawing.Size(816, 49)
        Me.lbl_province_title.TabIndex = 0
        Me.lbl_province_title.Tag = "lbl_province_title"
        Me.lbl_province_title.Text = "គ្រប់​គ្រង​ខេត្ត​ទាំង​អស់​"
        '
        'lvProvince
        '
        Me.lvProvince.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvProvince.FullRowSelect = True
        Me.lvProvince.GridLines = True
        Me.lvProvince.Location = New System.Drawing.Point(8, 76)
        Me.lvProvince.MultiSelect = False
        Me.lvProvince.Name = "lvProvince"
        Me.lvProvince.ShowItemToolTips = True
        Me.lvProvince.Size = New System.Drawing.Size(383, 319)
        Me.lvProvince.TabIndex = 3
        Me.lvProvince.UseCompatibleStateImageBehavior = False
        Me.lvProvince.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ល.រ"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ខេត្ត/ខ័ណ្ឌ​(ខ្មែរ)"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ខេត្ត/ខ័ណ្ឌ​(En)"
        Me.ColumnHeader3.Width = 160
        '
        'grbProvinceInfo
        '
        Me.grbProvinceInfo.Controls.Add(Me.txtProvince_En)
        Me.grbProvinceInfo.Controls.Add(Me.lbl_province_en)
        Me.grbProvinceInfo.Controls.Add(Me.txtProvince_Kh)
        Me.grbProvinceInfo.Controls.Add(Me.lbl_province_kh)
        Me.grbProvinceInfo.Controls.Add(Me.txtID)
        Me.grbProvinceInfo.Controls.Add(Me.lbl_no)
        Me.grbProvinceInfo.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbProvinceInfo.Location = New System.Drawing.Point(423, 131)
        Me.grbProvinceInfo.Name = "grbProvinceInfo"
        Me.grbProvinceInfo.Size = New System.Drawing.Size(375, 206)
        Me.grbProvinceInfo.TabIndex = 5
        Me.grbProvinceInfo.TabStop = False
        Me.grbProvinceInfo.Text = "បំពេញ​ព័ត៌មាន​របស់​ខេត្ត/ខ័ណ្ឌ"
        '
        'txtProvince_En
        '
        Me.txtProvince_En.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince_En.Location = New System.Drawing.Point(144, 141)
        Me.txtProvince_En.Name = "txtProvince_En"
        Me.txtProvince_En.Size = New System.Drawing.Size(210, 36)
        Me.txtProvince_En.TabIndex = 10
        '
        'lbl_province_en
        '
        Me.lbl_province_en.AutoSize = True
        Me.lbl_province_en.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_province_en.Location = New System.Drawing.Point(21, 144)
        Me.lbl_province_en.Name = "lbl_province_en"
        Me.lbl_province_en.Size = New System.Drawing.Size(100, 27)
        Me.lbl_province_en.TabIndex = 9
        Me.lbl_province_en.Tag = "lbl_no"
        Me.lbl_province_en.Text = "ខេត្ត​/ខ័ណ្ឌ​(En)"
        '
        'txtProvince_Kh
        '
        Me.txtProvince_Kh.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince_Kh.Location = New System.Drawing.Point(144, 99)
        Me.txtProvince_Kh.Name = "txtProvince_Kh"
        Me.txtProvince_Kh.Size = New System.Drawing.Size(210, 36)
        Me.txtProvince_Kh.TabIndex = 8
        '
        'lbl_province_kh
        '
        Me.lbl_province_kh.AutoSize = True
        Me.lbl_province_kh.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_province_kh.Location = New System.Drawing.Point(21, 102)
        Me.lbl_province_kh.Name = "lbl_province_kh"
        Me.lbl_province_kh.Size = New System.Drawing.Size(110, 27)
        Me.lbl_province_kh.TabIndex = 7
        Me.lbl_province_kh.Tag = ""
        Me.lbl_province_kh.Text = "ខេត្ត​/ខ័ណ្ឌ(ខ្មែរ) :"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(144, 57)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(210, 36)
        Me.txtID.TabIndex = 6
        '
        'lbl_no
        '
        Me.lbl_no.AutoSize = True
        Me.lbl_no.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(21, 60)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(75, 27)
        Me.lbl_no.TabIndex = 5
        Me.lbl_no.Tag = "lbl_no"
        Me.lbl_no.Text = "លេខ​រៀង :"
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(423, 74)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(273, 36)
        Me.txtFind.TabIndex = 11
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Image = Global.Institute_Management.My.Resources.Resources.if_Find_27847
        Me.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFind.Location = New System.Drawing.Point(702, 74)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(96, 36)
        Me.btnFind.TabIndex = 12
        Me.btnFind.Text = "ស្វែងរក"
        Me.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.Institute_Management.My.Resources.Resources.if_close_delete_70975
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(713, 359)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 36)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "បិត"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Institute_Management.My.Resources.Resources.if_edit_delete_23231
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(630, 359)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 36)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.Institute_Management.My.Resources.Resources.if_floppy_285657
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(531, 359)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 36)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "រក្សាទុក"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.Institute_Management.My.Resources.Resources.if_document_new_23212
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(423, 359)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 36)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "បន្ថែម"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtTotalDistrict
        '
        Me.txtTotalDistrict.Enabled = False
        Me.txtTotalDistrict.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDistrict.Location = New System.Drawing.Point(93, 401)
        Me.txtTotalDistrict.Name = "txtTotalDistrict"
        Me.txtTotalDistrict.Size = New System.Drawing.Size(108, 36)
        Me.txtTotalDistrict.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Tag = "lbl_no"
        Me.Label1.Text = "ចំនួន​ស្រុក"
        '
        'txtTotalCommune
        '
        Me.txtTotalCommune.Enabled = False
        Me.txtTotalCommune.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCommune.Location = New System.Drawing.Point(272, 401)
        Me.txtTotalCommune.Name = "txtTotalCommune"
        Me.txtTotalCommune.Size = New System.Drawing.Size(119, 36)
        Me.txtTotalCommune.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 27)
        Me.Label2.TabIndex = 15
        Me.Label2.Tag = "lbl_no"
        Me.Label2.Text = "ចំនួន​ឃុំ"
        '
        'frmProvince
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 441)
        Me.Controls.Add(Me.txtTotalCommune)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalDistrict)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grbProvinceInfo)
        Me.Controls.Add(Me.lvProvince)
        Me.Controls.Add(Me.lbl_province_title)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.Name = "frmProvince"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Province"
        Me.grbProvinceInfo.ResumeLayout(False)
        Me.grbProvinceInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_province_title As System.Windows.Forms.Label
    Friend WithEvents lvProvince As System.Windows.Forms.ListView
    Friend WithEvents grbProvinceInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtProvince_En As System.Windows.Forms.TextBox
    Friend WithEvents lbl_province_en As System.Windows.Forms.Label
    Friend WithEvents txtProvince_Kh As System.Windows.Forms.TextBox
    Friend WithEvents lbl_province_kh As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lbl_no As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTotalDistrict As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCommune As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
