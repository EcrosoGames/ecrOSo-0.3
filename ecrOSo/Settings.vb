Public Class Settings

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Form1.Main(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Form1.BackColor = ColorDialog1.Color
            StartMenu.BackColor = ColorDialog1.Color
            Me.BackColor = ColorDialog1.Color
            Form1.MenuStrip1.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class