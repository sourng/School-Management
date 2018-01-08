<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport_province
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.rptProvince = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 270)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.ReportViewer1.Size = New System.Drawing.Size(822, 185)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(426, 38)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(141, 38)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View Report"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(200, 48)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(160, 20)
        Me.txtID.TabIndex = 2
        '
        'rptProvince
        '
        Me.rptProvince.Location = New System.Drawing.Point(12, 113)
        Me.rptProvince.Name = "rptProvince"
        Me.rptProvince.Size = New System.Drawing.Size(647, 151)
        Me.rptProvince.TabIndex = 3
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(686, 113)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(113, 37)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmReport_province
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 467)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.rptProvince)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReport_province"
        Me.Text = "frmReport_province"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents rptProvince As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
