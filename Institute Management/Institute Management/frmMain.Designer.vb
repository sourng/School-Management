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
        Me.SuspendLayout()
        '
        'btnUsers
        '
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsers.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.ImageIndex = 0
        Me.btnUsers.ImageList = Me.ImageList1
        Me.btnUsers.Location = New System.Drawing.Point(44, 126)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(220, 67)
        Me.btnUsers.TabIndex = 0
        Me.btnUsers.Text = "គ្រប់​គ្រង​អ្នក​ប្រើ"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsers.UseVisualStyleBackColor = True
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
        Me.btnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransport.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransport.ImageIndex = 4
        Me.btnTransport.ImageList = Me.ImageList1
        Me.btnTransport.Location = New System.Drawing.Point(44, 199)
        Me.btnTransport.Name = "btnTransport"
        Me.btnTransport.Size = New System.Drawing.Size(220, 67)
        Me.btnTransport.TabIndex = 1
        Me.btnTransport.Text = "មធ្យោបាយ​ធ្វើ​ដំណើត​"
        Me.btnTransport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransport.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 507)
        Me.Controls.Add(Me.btnTransport)
        Me.Controls.Add(Me.btnUsers)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnTransport As System.Windows.Forms.Button
End Class
