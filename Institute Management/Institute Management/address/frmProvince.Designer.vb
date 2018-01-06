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
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.btnAddDistrict = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.grbProvinceInfo.SuspendLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_province_title.Size = New System.Drawing.Size(977, 49)
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
        Me.lvProvince.Size = New System.Drawing.Size(383, 282)
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
        Me.grbProvinceInfo.Size = New System.Drawing.Size(375, 179)
        Me.grbProvinceInfo.TabIndex = 5
        Me.grbProvinceInfo.TabStop = False
        Me.grbProvinceInfo.Text = "បំពេញ​ព័ត៌មាន​របស់​ខេត្ត/ខ័ណ្ឌ"
        '
        'txtProvince_En
        '
        Me.txtProvince_En.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince_En.Location = New System.Drawing.Point(144, 120)
        Me.txtProvince_En.Name = "txtProvince_En"
        Me.txtProvince_En.Size = New System.Drawing.Size(210, 36)
        Me.txtProvince_En.TabIndex = 10
        '
        'lbl_province_en
        '
        Me.lbl_province_en.AutoSize = True
        Me.lbl_province_en.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_province_en.Location = New System.Drawing.Point(21, 123)
        Me.lbl_province_en.Name = "lbl_province_en"
        Me.lbl_province_en.Size = New System.Drawing.Size(100, 27)
        Me.lbl_province_en.TabIndex = 9
        Me.lbl_province_en.Tag = "lbl_no"
        Me.lbl_province_en.Text = "ខេត្ត​/ខ័ណ្ឌ​(En)"
        '
        'txtProvince_Kh
        '
        Me.txtProvince_Kh.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince_Kh.Location = New System.Drawing.Point(144, 78)
        Me.txtProvince_Kh.Name = "txtProvince_Kh"
        Me.txtProvince_Kh.Size = New System.Drawing.Size(210, 36)
        Me.txtProvince_Kh.TabIndex = 8
        '
        'lbl_province_kh
        '
        Me.lbl_province_kh.AutoSize = True
        Me.lbl_province_kh.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_province_kh.Location = New System.Drawing.Point(21, 81)
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
        Me.txtID.Location = New System.Drawing.Point(144, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(210, 36)
        Me.txtID.TabIndex = 6
        '
        'lbl_no
        '
        Me.lbl_no.AutoSize = True
        Me.lbl_no.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(21, 39)
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
        Me.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.Institute_Management.My.Resources.Resources.if_close_delete_70975
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(702, 316)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 42)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "បិត"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Institute_Management.My.Resources.Resources.if_edit_delete_23231
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(619, 316)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 42)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.Institute_Management.My.Resources.Resources.if_floppy_285657
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(520, 316)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 42)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "រក្សាទុក"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.Institute_Management.My.Resources.Resources.if_Plus_206460
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(421, 316)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 42)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "បន្ថែម"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtTotalDistrict
        '
        Me.txtTotalDistrict.Enabled = False
        Me.txtTotalDistrict.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDistrict.Location = New System.Drawing.Point(93, 373)
        Me.txtTotalDistrict.Name = "txtTotalDistrict"
        Me.txtTotalDistrict.Size = New System.Drawing.Size(108, 36)
        Me.txtTotalDistrict.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 376)
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
        Me.txtTotalCommune.Location = New System.Drawing.Point(272, 373)
        Me.txtTotalCommune.Name = "txtTotalCommune"
        Me.txtTotalCommune.Size = New System.Drawing.Size(119, 36)
        Me.txtTotalCommune.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 27)
        Me.Label2.TabIndex = 15
        Me.Label2.Tag = "lbl_no"
        Me.Label2.Text = "ចំនួន​ឃុំ"
        '
        'Pic1
        '
        Me.Pic1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic1.InitialImage = Global.Institute_Management.My.Resources.Resources.if_book_image_add_103392
        Me.Pic1.Location = New System.Drawing.Point(805, 55)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(165, 183)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 17
        Me.Pic1.TabStop = False
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChooseImage.BackColor = System.Drawing.Color.Transparent
        Me.btnChooseImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnChooseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseImage.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseImage.Image = Global.Institute_Management.My.Resources.Resources.if_book_image_add_103392
        Me.btnChooseImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChooseImage.Location = New System.Drawing.Point(804, 244)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(165, 48)
        Me.btnChooseImage.TabIndex = 18
        Me.btnChooseImage.Text = "ជ្រើសរូបថត"
        Me.btnChooseImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChooseImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChooseImage.UseVisualStyleBackColor = False
        '
        'btnAddDistrict
        '
        Me.btnAddDistrict.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDistrict.BackColor = System.Drawing.Color.Transparent
        Me.btnAddDistrict.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddDistrict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDistrict.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDistrict.Image = Global.Institute_Management.My.Resources.Resources.if_document_new_232121
        Me.btnAddDistrict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDistrict.Location = New System.Drawing.Point(805, 298)
        Me.btnAddDistrict.Name = "btnAddDistrict"
        Me.btnAddDistrict.Size = New System.Drawing.Size(164, 58)
        Me.btnAddDistrict.TabIndex = 19
        Me.btnAddDistrict.Text = "បន្ថែម​ស្រុក​" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add District"
        Me.btnAddDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddDistrict.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddDistrict.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(8, 417)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(961, 171)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'frmProvince
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 598)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnAddDistrict)
        Me.Controls.Add(Me.btnChooseImage)
        Me.Controls.Add(Me.Pic1)
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
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents btnAddDistrict As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
