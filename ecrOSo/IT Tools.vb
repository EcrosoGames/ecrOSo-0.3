Imports System.Runtime.InteropServices
Public Class IT_Tools
    Private Sub btnCMD_Click(sender As System.Object, e As System.EventArgs) Handles btnCMD.Click
        Process.Start("cmd.exe")
    End Sub
    Private Sub btnDXDIAG_Click(sender As System.Object, e As System.EventArgs) Handles btnDXDIAG.Click
        Process.Start("dxdiag.exe")
    End Sub
    Private Sub btnSHUTDOWN_Click(sender As System.Object, e As System.EventArgs) Handles btnSHUTDOWN.Click
        System.Diagnostics.Process.Start("shutdown", "-s -t 00")
    End Sub
    Private Sub btnRESTART_Click(sender As System.Object, e As System.EventArgs) Handles btnRESTART.Click
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
    End Sub
    Private Sub btnLOGOFF_Click(sender As System.Object, e As System.EventArgs) Handles btnLOGOFF.Click
        System.Diagnostics.Process.Start("shutdown", "-l -t 00")
    End Sub
End Class