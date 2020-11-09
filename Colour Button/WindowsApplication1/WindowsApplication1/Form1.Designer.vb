<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.BtnExti = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(78, 145)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "DJ DELF"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'BtnExti
        '
        Me.BtnExti.Location = New System.Drawing.Point(78, 174)
        Me.BtnExti.Name = "BtnExti"
        Me.BtnExti.Size = New System.Drawing.Size(75, 23)
        Me.BtnExti.TabIndex = 1
        Me.BtnExti.Text = "E&xit"
        Me.BtnExti.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BtnExti)
        Me.Controls.Add(Me.Btn1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FrmMain"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents BtnExti As Button
End Class
