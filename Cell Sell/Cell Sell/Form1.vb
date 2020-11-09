Public Class Form1
    Dim x As Single 'amount of daytime minutes 
    Dim y As Single 'amount of evening minutes 
    Dim z As Single 'amount of weekend minutes 
    Dim aa As Single
    Dim ab As Single
    Dim ac As Single
    Dim ba As Single
    Dim bb As Single
    Dim bc As Single
    Dim a As Single
    Dim b As Single
    Dim final As Single



    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""

        x = InputBox("amount of daytime minutes")
        y = InputBox("amount of evening minutes")
        z = InputBox("amount of weekend minutes")

        'plan A
        If x <= 100 Then aa = 0 Else aa = ((x - 100) * (0.25))
        ab = (y * 0.15)
        ac = (z * 0.2)
        Label1.Text = aa
        Label2.Text = ab
        Label3.Text = ac
        a = aa + ab + ac
        Label9.Text = a

        'plan B
        If x <= 250 Then ba = 0 Else ba = ((x - 250) * 0.45)
        bb = (y * 0.35)
        bc = (z * 0.25)
        Label4.Text = ba
        Label5.Text = bb
        Label6.Text = bc
        b = ba + bb + bc
        Label10.Text = b



        If b > a Then
            Label11.Text = "Plan A Is Cheapest"
        ElseIf b < a Then
            Label11.Text = "Plan B Is Cheapest"
        End If
        If a = b Then
            Label11.Text = "The Price Is The Same"
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
