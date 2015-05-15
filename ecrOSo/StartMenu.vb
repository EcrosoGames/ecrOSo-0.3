Public Class StartMenu
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Form1.Fuckyou() 'LOL if you find this I'm so sorry.
    End Sub
    Private Sub btnSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnSettings.Click
        Settings.Show()
    End Sub
    Private Sub btnComputer_Click(sender As System.Object, e As System.EventArgs) Handles btnComputer.Click
        Process.Start("control", "system")
    End Sub
    Private Sub btnDocuments_Click(sender As System.Object, e As System.EventArgs) Handles btnDocuments.Click
        Process.Start("explorer")
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnITTools.Click
        IT_Tools.Show()
    End Sub
End Class