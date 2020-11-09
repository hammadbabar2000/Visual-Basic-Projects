Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim filepath As String
            filepath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "text.txt")
            My.Computer.FileSystem.WriteAllText(filepath, "some text", False)
        Catch fileexception As Exception
            Throw fileexception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim filepath As String
            filepath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "text.txt")
            My.Computer.FileSystem.WriteAllText(filepath, "some text", False)
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(filepath)
        Catch fileException As Exception
            Throw fileException
        End Try
    End Sub
End Class
