<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PanelPage1 = New WEMULauncher.PanelPage()
        Me.MyDrag1 = New WEMULauncher.myDrag()
        Me.SuspendLayout()
        '
        'PanelPage1
        '
        Me.PanelPage1.BackColor = System.Drawing.Color.Transparent
        Me.PanelPage1.Location = New System.Drawing.Point(0, 0)
        Me.PanelPage1.Name = "PanelPage1"
        Me.PanelPage1.Size = New System.Drawing.Size(4120, 768)
        Me.PanelPage1.TabIndex = 1
        '
        'MyDrag1
        '
        Me.MyDrag1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MyDrag1.Name = "MyDrag1"
        Me.MyDrag1.Size = New System.Drawing.Size(61, 4)
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PanelPage1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelPage1 As PanelPage
    Friend WithEvents MyDrag1 As myDrag
End Class
