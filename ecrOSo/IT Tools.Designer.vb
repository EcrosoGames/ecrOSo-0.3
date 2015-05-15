<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IT_Tools
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
        Me.btnCMD = New System.Windows.Forms.Button()
        Me.btnDXDIAG = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSHUTDOWN = New System.Windows.Forms.Button()
        Me.btnRESTART = New System.Windows.Forms.Button()
        Me.btnLOGOFF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCMD
        '
        Me.btnCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCMD.Location = New System.Drawing.Point(12, 12)
        Me.btnCMD.Name = "btnCMD"
        Me.btnCMD.Size = New System.Drawing.Size(231, 37)
        Me.btnCMD.TabIndex = 0
        Me.btnCMD.Text = "Command Prompt"
        Me.btnCMD.UseVisualStyleBackColor = True
        '
        'btnDXDIAG
        '
        Me.btnDXDIAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDXDIAG.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDXDIAG.Location = New System.Drawing.Point(12, 55)
        Me.btnDXDIAG.Name = "btnDXDIAG"
        Me.btnDXDIAG.Size = New System.Drawing.Size(231, 37)
        Me.btnDXDIAG.TabIndex = 1
        Me.btnDXDIAG.Text = "DirectX Diagnostics"
        Me.btnDXDIAG.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 65)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Basic CMD help:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C: - goes to C:\" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cd - changes directory to a sub folder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<name>" & _
    ".exe - runs the exe specified in the current directory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dir - gets files in dire" & _
    "ctory"
        '
        'btnSHUTDOWN
        '
        Me.btnSHUTDOWN.BackColor = System.Drawing.Color.Red
        Me.btnSHUTDOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSHUTDOWN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSHUTDOWN.ForeColor = System.Drawing.Color.Black
        Me.btnSHUTDOWN.Location = New System.Drawing.Point(12, 163)
        Me.btnSHUTDOWN.Name = "btnSHUTDOWN"
        Me.btnSHUTDOWN.Size = New System.Drawing.Size(87, 30)
        Me.btnSHUTDOWN.TabIndex = 3
        Me.btnSHUTDOWN.Text = "Shutdown"
        Me.btnSHUTDOWN.UseVisualStyleBackColor = False
        '
        'btnRESTART
        '
        Me.btnRESTART.BackColor = System.Drawing.Color.LimeGreen
        Me.btnRESTART.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRESTART.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRESTART.ForeColor = System.Drawing.Color.Black
        Me.btnRESTART.Location = New System.Drawing.Point(12, 199)
        Me.btnRESTART.Name = "btnRESTART"
        Me.btnRESTART.Size = New System.Drawing.Size(87, 30)
        Me.btnRESTART.TabIndex = 4
        Me.btnRESTART.Text = "Restart"
        Me.btnRESTART.UseVisualStyleBackColor = False
        '
        'btnLOGOFF
        '
        Me.btnLOGOFF.BackColor = System.Drawing.Color.Gold
        Me.btnLOGOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLOGOFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLOGOFF.ForeColor = System.Drawing.Color.Black
        Me.btnLOGOFF.Location = New System.Drawing.Point(12, 235)
        Me.btnLOGOFF.Name = "btnLOGOFF"
        Me.btnLOGOFF.Size = New System.Drawing.Size(87, 30)
        Me.btnLOGOFF.TabIndex = 5
        Me.btnLOGOFF.Text = "Log off"
        Me.btnLOGOFF.UseVisualStyleBackColor = False
        '
        'IT_Tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 276)
        Me.Controls.Add(Me.btnLOGOFF)
        Me.Controls.Add(Me.btnRESTART)
        Me.Controls.Add(Me.btnSHUTDOWN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDXDIAG)
        Me.Controls.Add(Me.btnCMD)
        Me.Name = "IT_Tools"
        Me.Text = "IT_Tools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCMD As System.Windows.Forms.Button
    Friend WithEvents btnDXDIAG As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSHUTDOWN As System.Windows.Forms.Button
    Friend WithEvents btnRESTART As System.Windows.Forms.Button
    Friend WithEvents btnLOGOFF As System.Windows.Forms.Button
End Class
