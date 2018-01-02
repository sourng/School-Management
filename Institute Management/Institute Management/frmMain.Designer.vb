<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnTransport = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.btnAcademy = New System.Windows.Forms.Button()
        Me.btnStudentEnroll = New System.Windows.Forms.Button()
        Me.btnCurriculumEndorsement = New System.Windows.Forms.Button()
        Me.btnClassRoom = New System.Windows.Forms.Button()
        Me.btnDeptandOffice = New System.Windows.Forms.Button()
        Me.btnTimeTable = New System.Windows.Forms.Button()
        Me.btnOverallFund = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 129)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(214, 54)
        Me.btnUsers.TabIndex = 0
        Me.btnUsers.Text = "គ្រប់​គ្រង​អ្នក​ប្រើ"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "user.png")
        Me.ImageList1.Images.SetKeyName(1, "classes.png")
        Me.ImageList1.Images.SetKeyName(2, "user_group.png")
        Me.ImageList1.Images.SetKeyName(3, "student_info.png")
        Me.ImageList1.Images.SetKeyName(4, "transport.png")
        '
        'btnTransport
        '
        Me.btnTransport.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnTransport.FlatAppearance.BorderSize = 0
        Me.btnTransport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransport.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransport.Image = Global.Institute_Management.My.Resources.Resources.transport
        Me.btnTransport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransport.Location = New System.Drawing.Point(0, 183)
        Me.btnTransport.Name = "btnTransport"
        Me.btnTransport.Size = New System.Drawing.Size(214, 54)
        Me.btnTransport.TabIndex = 1
        Me.btnTransport.Text = "មធ្យោបាយ​ធ្វើ​ដំណើត​"
        Me.btnTransport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransport.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStrip1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1068, 66)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "File"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = Global.Institute_Management.My.Resources.Resources.human_resource
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(101, 63)
        Me.ToolStripButton1.Text = "ធនធានមនុស្ស​"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton2.Image = Global.Institute_Management.My.Resources.Resources.new_students1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(101, 63)
        Me.ToolStripButton2.Text = "គ្រប់​គ្រង​សិស្ស"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton3.Image = Global.Institute_Management.My.Resources.Resources.user_group
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(106, 63)
        Me.ToolStripButton3.Text = "គ្រប់​គ្រង​អ្នក​ប្រើ"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.Institute_Management.My.Resources.Resources.courses
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(56, 63)
        Me.ToolStripButton4.Text = "មុខ​វិជ្ជា"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.Institute_Management.My.Resources.Resources.timetable
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(76, 63)
        Me.ToolStripButton5.Text = "កាលវិភាគ"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.Institute_Management.My.Resources.Resources.finance
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(113, 63)
        Me.ToolStripButton6.Text = "ចំណូល​ចំណាយ"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Institute_Management.My.Resources.Resources.transport
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "មធ្យោបាយ​ធ្វើ​ដំណើត​"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "គ្រប់​គ្រង​អ្នក​ប្រើ"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Institute_Management.My.Resources.Resources.transport
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 399)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(214, 54)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "មធ្យោបាយ​ធ្វើ​ដំណើត​"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 345)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(214, 54)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "គ្រប់​គ្រង​អ្នក​ប្រើ"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.Label1.Size = New System.Drawing.Size(239, 41)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "បញ្ជីរ​ | Menu"
        '
        'btnCourses
        '
        Me.btnCourses.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCourses.FlatAppearance.BorderSize = 0
        Me.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourses.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourses.Image = Global.Institute_Management.My.Resources.Resources.library
        Me.btnCourses.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCourses.Location = New System.Drawing.Point(630, 236)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(133, 95)
        Me.btnCourses.TabIndex = 13
        Me.btnCourses.Text = "គ្រប់​គ្រងវគ្គ"
        Me.btnCourses.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCourses.UseVisualStyleBackColor = False
        '
        'btnAcademy
        '
        Me.btnAcademy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAcademy.FlatAppearance.BorderSize = 0
        Me.btnAcademy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAcademy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcademy.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcademy.Image = CType(resources.GetObject("btnAcademy.Image"), System.Drawing.Image)
        Me.btnAcademy.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAcademy.Location = New System.Drawing.Point(467, 236)
        Me.btnAcademy.Name = "btnAcademy"
        Me.btnAcademy.Size = New System.Drawing.Size(148, 95)
        Me.btnAcademy.TabIndex = 12
        Me.btnAcademy.Text = "គ្រប់​គ្រង​ជំនាញ"
        Me.btnAcademy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAcademy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAcademy.UseVisualStyleBackColor = False
        '
        'btnStudentEnroll
        '
        Me.btnStudentEnroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentEnroll.FlatAppearance.BorderSize = 0
        Me.btnStudentEnroll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnStudentEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentEnroll.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentEnroll.Image = CType(resources.GetObject("btnStudentEnroll.Image"), System.Drawing.Image)
        Me.btnStudentEnroll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStudentEnroll.Location = New System.Drawing.Point(259, 236)
        Me.btnStudentEnroll.Name = "btnStudentEnroll"
        Me.btnStudentEnroll.Size = New System.Drawing.Size(192, 95)
        Me.btnStudentEnroll.TabIndex = 11
        Me.btnStudentEnroll.Text = "ដាក់​ពាក្យ​ចូល​រៀន​"
        Me.btnStudentEnroll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStudentEnroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStudentEnroll.UseVisualStyleBackColor = False
        '
        'btnCurriculumEndorsement
        '
        Me.btnCurriculumEndorsement.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCurriculumEndorsement.FlatAppearance.BorderSize = 0
        Me.btnCurriculumEndorsement.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCurriculumEndorsement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCurriculumEndorsement.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurriculumEndorsement.Image = CType(resources.GetObject("btnCurriculumEndorsement.Image"), System.Drawing.Image)
        Me.btnCurriculumEndorsement.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCurriculumEndorsement.Location = New System.Drawing.Point(588, 129)
        Me.btnCurriculumEndorsement.Name = "btnCurriculumEndorsement"
        Me.btnCurriculumEndorsement.Size = New System.Drawing.Size(175, 91)
        Me.btnCurriculumEndorsement.TabIndex = 10
        Me.btnCurriculumEndorsement.Text = "កម្មវិធី​សិក្សា"
        Me.btnCurriculumEndorsement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCurriculumEndorsement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCurriculumEndorsement.UseVisualStyleBackColor = False
        '
        'btnClassRoom
        '
        Me.btnClassRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClassRoom.FlatAppearance.BorderSize = 0
        Me.btnClassRoom.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClassRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClassRoom.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassRoom.Image = CType(resources.GetObject("btnClassRoom.Image"), System.Drawing.Image)
        Me.btnClassRoom.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClassRoom.Location = New System.Drawing.Point(447, 129)
        Me.btnClassRoom.Name = "btnClassRoom"
        Me.btnClassRoom.Size = New System.Drawing.Size(126, 91)
        Me.btnClassRoom.TabIndex = 9
        Me.btnClassRoom.Text = "បន្ទប់​សិក្សា"
        Me.btnClassRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClassRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClassRoom.UseVisualStyleBackColor = False
        '
        'btnDeptandOffice
        '
        Me.btnDeptandOffice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeptandOffice.FlatAppearance.BorderSize = 0
        Me.btnDeptandOffice.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDeptandOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeptandOffice.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeptandOffice.Image = CType(resources.GetObject("btnDeptandOffice.Image"), System.Drawing.Image)
        Me.btnDeptandOffice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeptandOffice.Location = New System.Drawing.Point(259, 129)
        Me.btnDeptandOffice.Name = "btnDeptandOffice"
        Me.btnDeptandOffice.Size = New System.Drawing.Size(170, 91)
        Me.btnDeptandOffice.TabIndex = 8
        Me.btnDeptandOffice.Text = "ដេប៉ាតឺម៉ង់/ការិយាល័យ"
        Me.btnDeptandOffice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeptandOffice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeptandOffice.UseVisualStyleBackColor = False
        '
        'btnTimeTable
        '
        Me.btnTimeTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTimeTable.FlatAppearance.BorderSize = 0
        Me.btnTimeTable.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeTable.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeTable.Image = Global.Institute_Management.My.Resources.Resources.timetable
        Me.btnTimeTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTimeTable.Location = New System.Drawing.Point(779, 129)
        Me.btnTimeTable.Name = "btnTimeTable"
        Me.btnTimeTable.Size = New System.Drawing.Size(175, 91)
        Me.btnTimeTable.TabIndex = 14
        Me.btnTimeTable.Text = "កាលវិភាគ"
        Me.btnTimeTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTimeTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTimeTable.UseVisualStyleBackColor = False
        '
        'btnOverallFund
        '
        Me.btnOverallFund.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOverallFund.FlatAppearance.BorderSize = 0
        Me.btnOverallFund.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnOverallFund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverallFund.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverallFund.Image = Global.Institute_Management.My.Resources.Resources.finance1
        Me.btnOverallFund.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOverallFund.Location = New System.Drawing.Point(779, 236)
        Me.btnOverallFund.Name = "btnOverallFund"
        Me.btnOverallFund.Size = New System.Drawing.Size(175, 95)
        Me.btnOverallFund.TabIndex = 15
        Me.btnOverallFund.Text = "មូលនិធិជារួម"
        Me.btnOverallFund.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOverallFund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOverallFund.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Image = Global.Institute_Management.My.Resources.Resources.transport
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button13.Location = New System.Drawing.Point(259, 346)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(157, 89)
        Me.Button13.TabIndex = 16
        Me.Button13.Text = "បរិញ្ញាបត្រ​រង​"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Image = Global.Institute_Management.My.Resources.Resources.transport
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button14.Location = New System.Drawing.Point(435, 346)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(180, 89)
        Me.Button14.TabIndex = 17
        Me.Button14.Text = "បរិញ្ញាបត្រ​"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Image = Global.Institute_Management.My.Resources.Resources.transport
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button15.Location = New System.Drawing.Point(630, 346)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(166, 89)
        Me.Button15.TabIndex = 18
        Me.Button15.Text = "វិញ្ញាប័ណ្ណបត្រ​វិជ្ជា​ជីវ"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Image = Global.Institute_Management.My.Resources.Resources.transport
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button16.Location = New System.Drawing.Point(812, 346)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(142, 89)
        Me.Button16.TabIndex = 19
        Me.Button16.Text = "វិញ្ញាប័ណ្ណបត្រ​វិជ្ជា​ជីវ"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.Label2.Size = New System.Drawing.Size(828, 41)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ផ្ទាំងគ្រប់គ្រង | Dashboard"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = Global.Institute_Management.My.Resources.Resources.teacher_m
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(710, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.Label3.Size = New System.Drawing.Size(244, 74)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "អ្នក​កំពុង​ប្រើ : សេង​ ស៊ង់​"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(954, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.Label4.Size = New System.Drawing.Size(96, 41)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "4:90 PM"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 507)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.btnOverallFund)
        Me.Controls.Add(Me.btnTimeTable)
        Me.Controls.Add(Me.btnCourses)
        Me.Controls.Add(Me.btnAcademy)
        Me.Controls.Add(Me.btnStudentEnroll)
        Me.Controls.Add(Me.btnCurriculumEndorsement)
        Me.Controls.Add(Me.btnClassRoom)
        Me.Controls.Add(Me.btnDeptandOffice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnTransport)
        Me.Controls.Add(Me.btnUsers)
        Me.Name = "frmMain"
        Me.Text = "Institute Management V.1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnTransport As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCourses As System.Windows.Forms.Button
    Friend WithEvents btnAcademy As System.Windows.Forms.Button
    Friend WithEvents btnStudentEnroll As System.Windows.Forms.Button
    Friend WithEvents btnCurriculumEndorsement As System.Windows.Forms.Button
    Friend WithEvents btnClassRoom As System.Windows.Forms.Button
    Friend WithEvents btnDeptandOffice As System.Windows.Forms.Button
    Friend WithEvents btnTimeTable As System.Windows.Forms.Button
    Friend WithEvents btnOverallFund As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
