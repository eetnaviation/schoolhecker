Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim keyInput As String
        Dim keyHash As String
        username = txtUser.Text
        keyInput = txtKey.Text
        keyHash = Md5FromString(username)
        If (keyInput.Equals(keyHash)) Then
            main.Show()
        Else
            MessageBox.Show("Incorrect username or key!", "schoolhecker v1.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function Md5FromString(ByVal Source As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()

        'Check for empty string.
        If String.IsNullOrEmpty(Source) Then
            Throw New ArgumentNullException
        End If

        'Get bytes from string.
        Bytes = Encoding.Default.GetBytes(Source)

        'Get md5 hash
        Bytes = MD5.Create().ComputeHash(Bytes)

        'Loop though the byte array and convert each byte to hex.
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next

        'Return md5 hash.
        Return sb.ToString()

    End Function

End Class
