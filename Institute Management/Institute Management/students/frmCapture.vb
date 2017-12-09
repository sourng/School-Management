Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class frmCapture
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    Private Sub btnStartCamera_Click(sender As Object, e As EventArgs) Handles btnStartCamera.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            CAMERA.Start()

        End If

    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        PictureBox2.Image = PictureBox1.Image
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      
            Me.Close()
    End Sub

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click

    End Sub
End Class