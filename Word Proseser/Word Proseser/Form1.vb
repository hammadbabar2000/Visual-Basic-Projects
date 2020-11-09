Public Class Form1
    Public Property SelectionFont As Font

    'Close the program
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Font size
    'Font size 10
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim f As String
        f = RichTextBox2.SelectionFont.Style
        RichTextBox2.SelectionFont = New Font(f, 10, RichTextBox2.SelectionFont.Style)
    End Sub
    'Font size 12 
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim f As String
        f = RichTextBox2.SelectionFont.Style
        RichTextBox2.SelectionFont = New Font(f, 12, RichTextBox2.SelectionFont.Style)
    End Sub
    'Font size 16
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim f As String
        f = RichTextBox2.SelectionFont.Style
        RichTextBox2.SelectionFont = New Font(f, 16, RichTextBox2.SelectionFont.Style)
    End Sub
    'Font size 18
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim f As String
        f = RichTextBox2.SelectionFont.Style
        RichTextBox2.SelectionFont = New Font(f, 18, RichTextBox2.SelectionFont.Style)
    End Sub
    'Font  size 20
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim f As String
        f = RichTextBox2.SelectionFont.Style
        RichTextBox2.SelectionFont = New Font(f, 20, RichTextBox2.SelectionFont.Style)
    End Sub
    'Font  size 22
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Dim f As String
        f = RichTextBox2.SelectionFont.Style
        RichTextBox2.SelectionFont = New Font(f, 22, RichTextBox2.SelectionFont.Style)
    End Sub
    'Font  size 24
    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs)
        Dim f As String
        f = RichTextBox2.SelectionFont.Style
        RichTextBox2.SelectionFont = New Font(f, 24, RichTextBox2.SelectionFont.Style)
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Color change
    'Color change red
    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        RichTextBox2.ForeColor = Color.Red
    End Sub
    'Color change blue
    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        RichTextBox2.ForeColor = Color.Blue
    End Sub
    'Color change green
    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        RichTextBox2.ForeColor = Color.Green
    End Sub
    'Color change purple
    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        RichTextBox2.ForeColor = Color.Purple
    End Sub
    'Color change black
    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        RichTextBox2.ForeColor = Color.Black
    End Sub
    'Color chaneg  yelow
    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        RichTextBox2.ForeColor = Color.Yellow
    End Sub
    'Color change brown
    Private Sub BrownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrownToolStripMenuItem.Click
        RichTextBox2.ForeColor = Color.Brown
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Enable Bold
    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        RichTextBox2.SelectionFont = New Font(RichTextBox2.SelectionFont, FontStyle.Bold)
    End Sub
    'Enable Italic
    Private Sub ItaliszedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItaliszedToolStripMenuItem.Click
        RichTextBox2.SelectionFont = New Font(RichTextBox2.SelectionFont, FontStyle.Italic)
    End Sub
    'Enable Underline
    Private Sub UnderlindedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlindedToolStripMenuItem.Click
        RichTextBox2.SelectionFont = New Font(RichTextBox2.SelectionFont, FontStyle.Underline)
    End Sub
    'Normal
    Private Sub RegularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularToolStripMenuItem.Click
        RichTextBox2.SelectionFont = New Font(RichTextBox2.SelectionFont, FontStyle.Regular)
    End Sub
End Class
