Public Class Form1
    Dim h As String 'String for textbox one
    'End program
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.FileSystem.CreateDirectory("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut")
        h = TextBox1.Text 'String for textbox one

        'Save first person
        If h = 1 Then
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD1.txt", TextBox2.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD1.txt", TextBox3.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD1.txt", TextBox4.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD1.txt", TextBox5.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD1.txt", TextBox6.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD1.txt", TextBox7.Text & vbCrLf, True)
        End If

        'Save sceond person
        If h = 2 Then
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD2.txt", TextBox2.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD2.txt", TextBox3.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD2.txt", TextBox4.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD2.txt", TextBox5.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD2.txt", TextBox6.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD2.txt", TextBox7.Text & vbCrLf, True)
        End If

        'Save third person
        If h = 3 Then
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD3.txt", TextBox2.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD3.txt", TextBox3.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD3.txt", TextBox4.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD3.txt", TextBox5.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD3.txt", TextBox6.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD3.txt", TextBox7.Text & vbCrLf, True)
        End If

        'Save forth person
        If h = 4 Then
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD4.txt", TextBox2.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD4.txt", TextBox3.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD4.txt", TextBox4.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD4.txt", TextBox5.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD4.txt", TextBox6.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD4.txt", TextBox7.Text & vbCrLf, True)
        End If

        'save fifth person
        If h = 5 Then
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD5.txt", TextBox2.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD5.txt", TextBox3.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD5.txt", TextBox4.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD5.txt", TextBox5.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD5.txt", TextBox6.Text & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD5.txt", TextBox7.Text & vbCrLf, True)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        h = TextBox1.Text 'String for textbox one

        'retrive first person
        If h = 1 Then
            Dim fst As String() = IO.File.ReadAllLines("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD1.txt")
            TextBox2.Text = fst(0)
            TextBox3.Text = fst(1)
            TextBox4.Text = fst(2)
            TextBox5.Text = fst(3)
            TextBox6.Text = fst(4)
            TextBox7.Text = fst(5)
        End If

        'retrive sceond person
        If h = 2 Then
            Dim Sed As String() = IO.File.ReadAllLines("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD2.txt")
            TextBox2.Text = Sed(0)
            TextBox3.Text = Sed(1)
            TextBox4.Text = Sed(2)
            TextBox5.Text = Sed(3)
            TextBox6.Text = Sed(4)
            TextBox7.Text = Sed(5)
        End If

        'retrive third person
        If h = 3 Then
            Dim trd As String() = IO.File.ReadAllLines("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD3.txt")
            TextBox2.Text = trd(0)
            TextBox3.Text = trd(1)
            TextBox4.Text = trd(2)
            TextBox5.Text = trd(3)
            TextBox6.Text = trd(4)
            TextBox7.Text = trd(5)
        End If

        'retrive forth person
        If h = 4 Then
            Dim fur As String() = IO.File.ReadAllLines("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD4.txt")
            TextBox2.Text = fur(0)
            TextBox3.Text = fur(1)
            TextBox4.Text = fur(2)
            TextBox5.Text = fur(3)
            TextBox6.Text = fur(4)
            TextBox7.Text = fur(5)
        End If

        'retrive forth person
        If h = 5 Then
            Dim fiv As String() = IO.File.ReadAllLines("C:\Users\Hammad Babar\Desktop\BeautySchoolDropOut\BSD5.txt")
            TextBox2.Text = fiv(0)
            TextBox3.Text = fiv(1)
            TextBox4.Text = fiv(2)
            TextBox5.Text = fiv(3)
            TextBox6.Text = fiv(4)
            TextBox7.Text = fiv(5)
        End If
    End Sub
    'Clear button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub
End Class
