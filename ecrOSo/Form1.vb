Imports System.Runtime.InteropServices
Imports System.IO
Public Class Form1
    Dim OskProcess As Process
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        OskProcess = New Process()
        OskProcess.StartInfo.UseShellExecute = True
        OskProcess.StartInfo.CreateNoWindow = True
        OskProcess.StartInfo.FileName = "C:\Windows\explorer.exe"
        OskProcess.StartInfo.WorkingDirectory = Application.StartupPath
        OskProcess.Start()
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each ObjPro As Process In Process.GetProcessesByName("EXPLORER")
            TerminateProcess(ObjPro.Handle, 1)
            Do Until ObjPro.HasExited = True
                Application.DoEvents()
            Loop
        Next
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Size.Width, MenuStrip1.Height + 1)
        Me.BringToFront()
        Me.TopMost = True
        Me.Location = New Point(0, Screen.PrimaryScreen.Bounds.Height - Me.Height)
        STUFF()
    End Sub
    Sub GetInfo(ByVal File As String)
        Using S As New StreamReader(File)
            Dim Result As String = ""
            Do While (S.Peek <> -1)
                Dim Line As String = S.ReadLine
                If Line.StartsWith("FC:") Then
                    Result = Line.Substring(3)
                    Settings.SetC(1, Color.FromArgb(Result), "")
                ElseIf Line.StartsWith("BC:") Then
                    Result = Line.Substring(3)
                    Settings.SetC(0, Color.FromArgb(Result), "")
                ElseIf Line.StartsWith("BG:") Then
                    Result = Line.Substring(3)
                    Settings.SetC(2, Color.White, Result)
                End If
            Loop
        End Using
    End Sub
    Sub STUFF()
        If IO.Directory.Exists("C:\Program Files\EcrosoGames\ecrOSoV3") = False Then
            IO.Directory.CreateDirectory("C:\Program Files\EcrosoGames\ecrOSoV3")
            IO.File.Create("C:\Program Files\EcrosoGames\ecrOSoV3\Settings.txt").Dispose()
            IO.File.WriteAllText("C:\Program Files\EcrosoGames\ecrOSoV3\Settings.txt", "BG:" & "C:\Windows\System32\backgroundDefault.jpg" & vbCrLf & "BC:" & Color.PaleTurquoise.ToArgb & vbCrLf & "FC:" & Color.Black.ToArgb)
        End If
        GetInfo("C:\Program Files\EcrosoGames\ecrOSoV3\Settings.txt")
        StartMenu.Show()
        StartMenu.Location = New Point(0, Screen.PrimaryScreen.Bounds.Height - StartMenu.Height - Me.Height)
        StartMenu.Visible = False
        For q As Integer = 0 To IO.Directory.GetFiles("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar").Length - 2
            MenuStrip1.Items.Add(IO.Directory.EnumerateFiles("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar").ElementAt(q))
            MenuStrip1.Items.Item(q + 2).Tag = "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar\" & IO.Directory.EnumerateFiles("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar").ElementAt(q).ToString.Remove(0, ("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar\").ToString.Length)
            MenuStrip1.Items.Item(q + 2).Text = IO.Directory.EnumerateFiles("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar").ElementAt(q).ToString.Remove(0, ("C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar\").ToString.Length)
            If MenuStrip1.Items.Item(q + 2).Text = "desktop.ini" Then
                MenuStrip1.Items.Item(q + 2).Visible = False
            Else
                MenuStrip1.Items.Item(q + 2).Text = MenuStrip1.Items.Item(q + 2).Text.Substring(0, (MenuStrip1.Items.Item(q + 2).Text.Length - 4))
            End If
        Next
        Do
            Application.DoEvents()
            TIMEToolStripMenuItem.Text = DateAndTime.Now
        Loop
    End Sub
    Public Declare Function TerminateProcess Lib "kernel32" (ByVal hProcess As IntPtr, ByVal uExitCode As UInteger) As Integer
    Public Sub Fuckyou()
        IO.File.Create("C:\Program Files\EcrosoGames\ecrOSoV3\Settings.txt").Dispose()
        If IO.File.Exists("C:\Program Files\EcrosoGames\ecrOSoV3\BG.jpg") Then
            IO.File.WriteAllText("C:\Program Files\EcrosoGames\ecrOSoV3\Settings.txt", "BG:" & "C:\Program Files\EcrosoGames\ecrOSoV3\BG.jpg" & vbCrLf & "BC:" & MenuStrip1.BackColor.ToArgb & vbCrLf & "FC:" & MenuStrip1.ForeColor.ToArgb)
        Else
            IO.File.WriteAllText("C:\Program Files\EcrosoGames\ecrOSoV3\Settings.txt", "BG:" & "C:\Windows\System32\backgroundDefault.jpg" & vbCrLf & "BC:" & MenuStrip1.BackColor.ToArgb & vbCrLf & "FC:" & MenuStrip1.ForeColor.ToArgb)
        End If
       OskProcess = New Process()
        OskProcess.StartInfo.UseShellExecute = True
        OskProcess.StartInfo.CreateNoWindow = True
        OskProcess.StartInfo.FileName = "C:\Windows\explorer.exe"
        OskProcess.StartInfo.WorkingDirectory = Application.StartupPath
        OskProcess.Start()
        End
    End Sub
    Private Sub ChromeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe")
    End Sub
    Public Shared SPI_SETDESKTOPWALLPAPER As Integer = 20
    Public Shared SPIF_UPDATEINIFILE As Integer = 1
    Public Shared SPIF_SENDWININICHANGE As Integer = 2
    Public Shared Sub Main(ByVal args As String)
        SystemParametersInfo(SPI_SETDESKTOPWALLPAPER, 0, args, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
    End Sub
    Private Declare Auto Function SystemParametersInfo Lib "User32.dll" (ByVal action As Integer, ByVal iparam As Integer, ByVal vparam As String, ByVal ouption As Integer) As Integer
    Private Sub StartToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StartToolStripMenuItem.Click
        If StartMenu.Visible Then
            StartMenu.Visible = False
        Else
            StartMenu.Visible = True
        End If
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        If e.ClickedItem.Tag <> Nothing And e.ClickedItem.Text <> "Windows Explorer.lnk" Then
            Process.Start(e.ClickedItem.Tag)
        End If
    End Sub
End Class