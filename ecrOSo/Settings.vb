Public Class Settings
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetC(2, Color.White, OpenFileDialog1.FileName)
            IO.File.Copy(OpenFileDialog1.FileName, "C:\Program Files\EcrosoGames\ecrOSoV3\BG.jpg")
        End If
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetC(0, ColorDialog1.Color, "")
        End If
    End Sub
    Public Sub SetC(ByVal w As Integer, ByVal C As Color, ByVal L As String)
        If w = 0 Then
            Form1.BackColor = C
            StartMenu.BackColor = C
            Me.BackColor = C
            Form1.MenuStrip1.BackColor = C
            IT_Tools.BackColor = C
        ElseIf w = 1 Then
            Form1.MenuStrip1.ForeColor = C
            StartMenu.ForeColor = C
            IT_Tools.ForeColor = C
            Me.ForeColor = C
        ElseIf w = 2 Then
            Form1.Main(L)
        End If
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetC(1, ColorDialog1.Color, "")
        End If
    End Sub
End Class