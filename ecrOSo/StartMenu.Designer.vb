<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnComputer = New System.Windows.Forms.Button()
        Me.btnDocuments = New System.Windows.Forms.Button()
        Me.btnITTools = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(215, 37)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(12, 141)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(215, 37)
        Me.btnSettings.TabIndex = 1
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnComputer
        '
        Me.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputer.Location = New System.Drawing.Point(12, 98)
        Me.btnComputer.Name = "btnComputer"
        Me.btnComputer.Size = New System.Drawing.Size(215, 37)
        Me.btnComputer.TabIndex = 2
        Me.btnComputer.Text = "Computer"
        Me.btnComputer.UseVisualStyleBackColor = True
        '
        'btnDocuments
        '
        Me.btnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocuments.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocuments.Location = New System.Drawing.Point(12, 55)
        Me.btnDocuments.Name = "btnDocuments"
        Me.btnDocuments.Size = New System.Drawing.Size(215, 37)
        Me.btnDocuments.TabIndex = 3
        Me.btnDocuments.Text = "Documents"
        Me.btnDocuments.UseVisualStyleBackColor = True
        '
        'btnITTools
        '
        Me.btnITTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnITTools.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnITTools.Location = New System.Drawing.Point(12, 12)
        Me.btnITTools.Name = "btnITTools"
        Me.btnITTools.Size = New System.Drawing.Size(215, 37)
        Me.btnITTools.TabIndex = 4
        Me.btnITTools.Text = "IT (Tech) Tools"
        Me.btnITTools.UseVisualStyleBackColor = True
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(239, 231)
        Me.Controls.Add(Me.btnITTools)
        Me.Controls.Add(Me.btnDocuments)
        Me.Controls.Add(Me.btnComputer)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartMenu"
        Me.Text = "StartMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnComputer As System.Windows.Forms.Button
    Friend WithEvents btnDocuments As System.Windows.Forms.Button
    Friend WithEvents btnITTools As System.Windows.Forms.Button
End Class
