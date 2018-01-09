<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentRegistration
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentRegistration))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbmageFile = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPob = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDob = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTravelDistance = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboTransportMethod = New System.Windows.Forms.ComboBox()
        Me.cboCommune = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboDistrict = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboProvice = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumOfDependants = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtParentPhone = New System.Windows.Forms.TextBox()
        Me.txtParentAdress = New System.Windows.Forms.TextBox()
        Me.txtParentMail = New System.Windows.Forms.TextBox()
        Me.txtParentName = New System.Windows.Forms.TextBox()
        Me.txtStuID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNationalid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLNameEN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLNameKH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFNameEN = New System.Windows.Forms.TextBox()
        Me.txtFNameKh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExport = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(95, 5, 5, 5)
        Me.Label2.Size = New System.Drawing.Size(1059, 56)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ចុះឈ្មោះសិស្ស"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbmageFile
        '
        Me.lbmageFile.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.lbmageFile.ImageSize = New System.Drawing.Size(16, 16)
        Me.lbmageFile.TransparentColor = System.Drawing.Color.Transparent
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtPob)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtDob)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtTravelDistance)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboTransportMethod)
        Me.GroupBox1.Controls.Add(Me.cboCommune)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cboDistrict)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cboProvice)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cboMaritalStatus)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtNumOfDependants)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtParentPhone)
        Me.GroupBox1.Controls.Add(Me.txtParentAdress)
        Me.GroupBox1.Controls.Add(Me.txtParentMail)
        Me.GroupBox1.Controls.Add(Me.txtParentName)
        Me.GroupBox1.Controls.Add(Me.txtStuID)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNationalid)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLNameEN)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLNameKH)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFNameEN)
        Me.GroupBox1.Controls.Add(Me.txtFNameKh)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(9, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(851, 448)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "(A) ជីវប្រវត្ត​សិស្ស"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(340, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 24)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "មធ្យោបាយធ្វើដំណើរ"
        '
        'txtPob
        '
        Me.txtPob.ForeColor = System.Drawing.Color.Black
        Me.txtPob.Location = New System.Drawing.Point(149, 259)
        Me.txtPob.Name = "txtPob"
        Me.txtPob.Size = New System.Drawing.Size(690, 32)
        Me.txtPob.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 259)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 24)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "ទីលំនៅអចិន្ត្រៃយ៍" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'txtDob
        '
        Me.txtDob.ForeColor = System.Drawing.Color.Black
        Me.txtDob.Location = New System.Drawing.Point(149, 221)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(690, 32)
        Me.txtDob.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 224)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 24)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "ទីកន្លែងកំណើត"
        '
        'txtTravelDistance
        '
        Me.txtTravelDistance.ForeColor = System.Drawing.Color.Black
        Me.txtTravelDistance.Location = New System.Drawing.Point(149, 183)
        Me.txtTravelDistance.Name = "txtTravelDistance"
        Me.txtTravelDistance.Size = New System.Drawing.Size(110, 32)
        Me.txtTravelDistance.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 24)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "ចម្ងាយផ្លូវធ្វើដំណើរ"
        '
        'cboTransportMethod
        '
        Me.cboTransportMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransportMethod.FormattingEnabled = True
        Me.cboTransportMethod.Location = New System.Drawing.Point(462, 180)
        Me.cboTransportMethod.Name = "cboTransportMethod"
        Me.cboTransportMethod.Size = New System.Drawing.Size(377, 32)
        Me.cboTransportMethod.TabIndex = 32
        '
        'cboCommune
        '
        Me.cboCommune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommune.FormattingEnabled = True
        Me.cboCommune.Location = New System.Drawing.Point(670, 297)
        Me.cboCommune.Name = "cboCommune"
        Me.cboCommune.Size = New System.Drawing.Size(169, 32)
        Me.cboCommune.TabIndex = 32
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(570, 301)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 24)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = " ឃុំ / សង្កាត់ :"
        '
        'cboDistrict
        '
        Me.cboDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.Location = New System.Drawing.Point(393, 297)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(169, 32)
        Me.cboDistrict.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(315, 301)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 24)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "ស្រុក / ក្រុង :"
        '
        'cboProvice
        '
        Me.cboProvice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvice.FormattingEnabled = True
        Me.cboProvice.Items.AddRange(New Object() {"បន្ទាយមានជ័យ", "រតនគីរី", "កណ្ដាល", "ព្រះសីហនុ", "ក្រចះ", "ឧត្តមានជ័យ", "សៀមរាប", "កំពង់ចាម", "ស្វាយរៀង", "មណ្ឌល់គីរី", "កំពង់ឆ្នាំង", "តាកែវ", "កែប", "កំពង់ធំ", "ប៉ៃលិន", "កោះកុង", "ស្ទឹងត្រែង", "បាត់ដំបង", "កំពត", "ព្រះវិហា", "ភ្នំពេញ", "កំពង់ស្ពឺ", "ត្បូងឃ្មុំ", "ពោធិ៍សាត់", "ព្រៃវែង"})
        Me.cboProvice.Location = New System.Drawing.Point(149, 297)
        Me.cboProvice.Name = "cboProvice"
        Me.cboProvice.Size = New System.Drawing.Size(157, 32)
        Me.cboProvice.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(25, 301)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 24)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "ខេត្ត :"
        '
        'cboMaritalStatus
        '
        Me.cboMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaritalStatus.FormattingEnabled = True
        Me.cboMaritalStatus.Location = New System.Drawing.Point(660, 145)
        Me.cboMaritalStatus.Name = "cboMaritalStatus"
        Me.cboMaritalStatus.Size = New System.Drawing.Size(179, 32)
        Me.cboMaritalStatus.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(560, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 24)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "ស្ថានភាពគ្រួសារ"
        '
        'txtNumOfDependants
        '
        Me.txtNumOfDependants.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumOfDependants.ForeColor = System.Drawing.Color.Black
        Me.txtNumOfDependants.Location = New System.Drawing.Point(433, 145)
        Me.txtNumOfDependants.Name = "txtNumOfDependants"
        Me.txtNumOfDependants.Size = New System.Drawing.Size(74, 32)
        Me.txtNumOfDependants.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(266, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 24)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "ចំនួនសមាជិកគ្រួសារក្នុងបន្ទុក"
        '
        'txtParentPhone
        '
        Me.txtParentPhone.ForeColor = System.Drawing.Color.Black
        Me.txtParentPhone.Location = New System.Drawing.Point(574, 336)
        Me.txtParentPhone.Name = "txtParentPhone"
        Me.txtParentPhone.Size = New System.Drawing.Size(265, 32)
        Me.txtParentPhone.TabIndex = 28
        '
        'txtParentAdress
        '
        Me.txtParentAdress.ForeColor = System.Drawing.Color.Black
        Me.txtParentAdress.Location = New System.Drawing.Point(149, 411)
        Me.txtParentAdress.Name = "txtParentAdress"
        Me.txtParentAdress.Size = New System.Drawing.Size(690, 32)
        Me.txtParentAdress.TabIndex = 28
        '
        'txtParentMail
        '
        Me.txtParentMail.ForeColor = System.Drawing.Color.Black
        Me.txtParentMail.Location = New System.Drawing.Point(149, 373)
        Me.txtParentMail.Name = "txtParentMail"
        Me.txtParentMail.Size = New System.Drawing.Size(244, 32)
        Me.txtParentMail.TabIndex = 28
        '
        'txtParentName
        '
        Me.txtParentName.ForeColor = System.Drawing.Color.Black
        Me.txtParentName.Location = New System.Drawing.Point(149, 335)
        Me.txtParentName.Name = "txtParentName"
        Me.txtParentName.Size = New System.Drawing.Size(244, 32)
        Me.txtParentName.TabIndex = 28
        '
        'txtStuID
        '
        Me.txtStuID.ForeColor = System.Drawing.Color.Black
        Me.txtStuID.Location = New System.Drawing.Point(149, 145)
        Me.txtStuID.Name = "txtStuID"
        Me.txtStuID.Size = New System.Drawing.Size(110, 32)
        Me.txtStuID.TabIndex = 28
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(6, 410)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(130, 24)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "ទីលំនៅអាណាព្យាបាល"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(441, 339)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(125, 24)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "ទូរស័ព្ទអាណាព្យាបាល"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(7, 377)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 24)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "អ៊ីម៉ែលអាណាព្យាបាល"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(262, 183)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(4)
        Me.Label14.Size = New System.Drawing.Size(62, 32)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "គីឡូម៉ែត"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 339)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(122, 24)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "ឈ្មោះអាណាព្យាបាល"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(508, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(4)
        Me.Label11.Size = New System.Drawing.Size(40, 32)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "នាក់"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 24)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "អត្តលេខសិស្ស"
        '
        'txtNationalid
        '
        Me.txtNationalid.ForeColor = System.Drawing.Color.Black
        Me.txtNationalid.Location = New System.Drawing.Point(660, 107)
        Me.txtNationalid.Name = "txtNationalid"
        Me.txtNationalid.Size = New System.Drawing.Size(179, 32)
        Me.txtNationalid.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(523, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "លេខអត្តសញ្ញាណប័ណ្ណ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-mm-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(377, 107)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 32)
        Me.DateTimePicker1.TabIndex = 24
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(149, 107)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(111, 32)
        Me.cboGender.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(266, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ឆ្នាំ-ខែ-ថ្ងៃ(កំណើត)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ភេទ"
        '
        'txtLNameEN
        '
        Me.txtLNameEN.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtLNameEN.ForeColor = System.Drawing.Color.Black
        Me.txtLNameEN.Location = New System.Drawing.Point(553, 68)
        Me.txtLNameEN.Name = "txtLNameEN"
        Me.txtLNameEN.Size = New System.Drawing.Size(286, 32)
        Me.txtLNameEN.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(467, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "នាម(ឡាតាំង)"
        '
        'txtLNameKH
        '
        Me.txtLNameKH.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLNameKH.ForeColor = System.Drawing.Color.Black
        Me.txtLNameKH.Location = New System.Drawing.Point(149, 68)
        Me.txtLNameKH.Name = "txtLNameKH"
        Me.txtLNameKH.Size = New System.Drawing.Size(274, 32)
        Me.txtLNameKH.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "នាម(ខ្មែរ)"
        '
        'txtFNameEN
        '
        Me.txtFNameEN.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtFNameEN.ForeColor = System.Drawing.Color.Black
        Me.txtFNameEN.Location = New System.Drawing.Point(553, 30)
        Me.txtFNameEN.Name = "txtFNameEN"
        Me.txtFNameEN.Size = New System.Drawing.Size(286, 32)
        Me.txtFNameEN.TabIndex = 13
        '
        'txtFNameKh
        '
        Me.txtFNameKh.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtFNameKh.ForeColor = System.Drawing.Color.Black
        Me.txtFNameKh.Location = New System.Drawing.Point(149, 31)
        Me.txtFNameKh.Name = "txtFNameKh"
        Me.txtFNameKh.Size = New System.Drawing.Size(274, 32)
        Me.txtFNameKh.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(441, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "គោត្តនាម​(ឡាតាំង)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "គោត្តនាម​(ខ្មែរ)"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnEdit, Me.btnDelete, Me.btnSearch, Me.btnPrint, Me.btnExport, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 532)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1057, 39)
        Me.ToolStrip1.TabIndex = 17
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
        'Pic1
        '
        Me.Pic1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic1.InitialImage = CType(resources.GetObject("Pic1.InitialImage"), System.Drawing.Image)
        Me.Pic1.Location = New System.Drawing.Point(870, 13)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(175, 187)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 21
        Me.Pic1.TabStop = False
        '
        'btnCamera
        '
        Me.btnCamera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCamera.BackColor = System.Drawing.Color.Transparent
        Me.btnCamera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCamera.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamera.Image = Global.Institute_Management.My.Resources.Resources.if_webcam_49730
        Me.btnCamera.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCamera.Location = New System.Drawing.Point(968, 206)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(77, 68)
        Me.btnCamera.TabIndex = 20
        Me.btnCamera.Text = "ថតផ្ទាល់"
        Me.btnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCamera.UseVisualStyleBackColor = False
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
        Me.btnChooseImage.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChooseImage.Location = New System.Drawing.Point(872, 206)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(89, 68)
        Me.btnChooseImage.TabIndex = 19
        Me.btnChooseImage.Text = "ជ្រើសរូបថត"
        Me.btnChooseImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChooseImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnChooseImage.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Navy
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(248, 6)
        Me.Label25.Name = "Label25"
        Me.Label25.Padding = New System.Windows.Forms.Padding(10)
        Me.Label25.Size = New System.Drawing.Size(80, 44)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "( T1 )"
        '
        'frmStudentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 571)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Pic1)
        Me.Controls.Add(Me.btnCamera)
        Me.Controls.Add(Me.btnChooseImage)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStudentRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudentRegistration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbmageFile As System.Windows.Forms.ImageList
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPob As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDob As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTravelDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboTransportMethod As System.Windows.Forms.ComboBox
    Friend WithEvents cboCommune As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboProvice As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboMaritalStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumOfDependants As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtParentPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtParentAdress As System.Windows.Forms.TextBox
    Friend WithEvents txtParentMail As System.Windows.Forms.TextBox
    Friend WithEvents txtParentName As System.Windows.Forms.TextBox
    Friend WithEvents txtStuID As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNationalid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLNameEN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLNameKH As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFNameEN As System.Windows.Forms.TextBox
    Friend WithEvents txtFNameKh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExport As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCamera As System.Windows.Forms.Button
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
