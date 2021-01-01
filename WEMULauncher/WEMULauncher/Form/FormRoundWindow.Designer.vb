<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRoundWindow
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyControlEllipse1 = New WEMULauncher.myControlEllipse()
        Me.MyDrag1 = New WEMULauncher.myDrag()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MyFormEllipse1 = New WEMULauncher.myFormEllipse()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(189, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(271, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MyControlEllipse1
        '
        Me.MyControlEllipse1.BoardThickness = 5
        Me.MyControlEllipse1.BorderColor = System.Drawing.Color.Maroon
        Me.MyControlEllipse1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MyControlEllipse1.myControl = Me.Button1
        Me.MyControlEllipse1.Name = "MyControlEllipse2"
        Me.MyControlEllipse1.R = 36
        Me.MyControlEllipse1.Size = New System.Drawing.Size(61, 4)
        '
        'MyDrag1
        '
        Me.MyDrag1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MyDrag1.Name = "MyDrag1"
        Me.MyDrag1.Panel = Me.Panel1
        Me.MyDrag1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(96, 417)
        Me.Panel1.TabIndex = 3
        '
        'MyFormEllipse1
        '
        Me.MyFormEllipse1.BoardThickness = 1
        Me.MyFormEllipse1.BorderColor = System.Drawing.Color.Black
        Me.MyFormEllipse1.Form = Me
        Me.MyFormEllipse1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MyFormEllipse1.Name = "MyFormEllipse1"
        Me.MyFormEllipse1.R = 40
        Me.MyFormEllipse1.Size = New System.Drawing.Size(61, 4)
        '
        'FormRoundWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(642, 609)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRoundWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents MyControlEllipse1 As myControlEllipse
    Friend WithEvents MyDrag1 As myDrag
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MyFormEllipse1 As myFormEllipse
End Class
