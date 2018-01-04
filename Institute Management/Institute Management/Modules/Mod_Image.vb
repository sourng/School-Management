Module Mod_Image
    Public Function getImage(ByVal ImagePath As String, ByVal ImageName As String) As String
        Dim path As String
        path = My.Application.Info.DirectoryPath
        'Dim path1 As String = path.Replace("\bin\Debug", "\")
        Dim path1 As String = path.Replace("\Debug", "\")

        path1 = path1 & ImagePath & "\" & ImageName

        'Me.PictureBox2.Image = Image.FromFile(path1)

        Return (path1)

    End Function
End Module
