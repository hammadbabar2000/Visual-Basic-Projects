Public Class Form1
    Dim x As Integer
    Dim y As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)

        If x >= 3 Or x <= 6 And y <= 4 Then
            Label3.Text = "TroyMartian"
            Label4.Text = ""

        ElseIf x <= 2 And y <= 3 Then
            Label3.Text = "GraemeMercurian"
            Label4.Text = "VladSaturnian"

        ElseIf x <= 6 And y >= 2 Then
            Label3.Text = "VladSaturnian"
            Label4.Text = ""

        ElseIf x > 6 And y > 4 Then
            Label3.Text = ""
            Label4.Text = "No Aliens"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
    End Sub
End Class
