Public Class Form1
    Dim cost As Double

    'Lable equles 5
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cost = 5
        Label1.Text = cost
    End Sub

    'Cheese setting
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox1.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox1.Visible = False
        End If
    End Sub

    'Large
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        cost = cost + 10
        cost = cost - 5
        Label1.Text = cost
    End Sub

    'Small
    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        cost = cost - 10
        cost = cost + 5
        Label1.Text = cost
    End Sub

    'Pepperoni setting
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox2.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox2.Visible = False
        End If
    End Sub

    'Olive setting 
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox3.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox3.Visible = False
        End If
    End Sub

    'Jalapeno setting
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox4.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox4.Visible = False
        End If
    End Sub

    'Bacon seeting
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox4.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox5.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox5.Visible = False
        End If
    End Sub

    'Pineapple setting
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox4.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox6.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox6.Visible = False
        End If
    End Sub

    'Meatball setting
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox4.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox7.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox7.Visible = False
        End If
    End Sub

    'Mushroom setting
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox4.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox8.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox8.Visible = False
        End If
    End Sub

    'Onion setting
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox4.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox9.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox9.Visible = False
        End If
    End Sub

    'Beef setting
    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox4.Checked = True Then
            cost = cost + 2
            Label1.Text = cost
            PictureBox10.Visible = True
        Else
            cost = cost - 2
            Label1.Text = cost
            PictureBox10.Visible = False
        End If
    End Sub

    'Order button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = True
        Label3.Text = Label1.Text
    End Sub

    'Exit program
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
