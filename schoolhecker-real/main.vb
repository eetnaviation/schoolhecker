Imports System.IO
Imports System.Reflection

Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub minecraft_Click(sender As Object, e As EventArgs) Handles minecraft.Click
        Dim resourceName As String = "schoolhecker_real.minecraft.exe"
        Dim tempFilePath As String = Path.GetTempFileName()
        Using stream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
            Using fileStream As New FileStream(tempFilePath, FileMode.Create)
                stream.CopyTo(fileStream)
            End Using
        End Using
        Process.Start(tempFilePath)
    End Sub

    Private Sub schoolbatcher_Click(sender As Object, e As EventArgs) Handles schoolbatcher.Click
        Dim resourceName As String = "schoolhecker_real.schoolbatcher.bat"
        Dim tempFilePath As String = Path.GetTempFileName()
        Using stream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
            Using fileStream As New FileStream(tempFilePath, FileMode.Create)
                stream.CopyTo(fileStream)
            End Using
        End Using
        Process.Start(tempFilePath)
    End Sub
End Class