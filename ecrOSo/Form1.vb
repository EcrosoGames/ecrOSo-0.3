Imports System.Runtime.InteropServices
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
    Sub STUFF()
        Main("L:\Desktop\Desktop Shit\DisplayStuff\north_american_nebula_wall01_by_maul555-d5q58t8.jpg")
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