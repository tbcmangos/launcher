<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlMainPage2
    Inherits System.Windows.Forms.UserControl

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
        Me.components = New System.ComponentModel.Container()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.MyButton2 = New WEMULauncher.myButton()
        Me.MyButtonSlide = New WEMULauncher.myButton()
        Me.MyButton1 = New WEMULauncher.myButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.CtrlBanner1 = New WEMULauncher.CtrlBanner(Me.components)
        Me.PanelHeader.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.CtrlBanner1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1024, 84)
        Me.PanelHeader.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.MyButton2)
        Me.PanelMenu.Controls.Add(Me.MyButtonSlide)
        Me.PanelMenu.Controls.Add(Me.MyButton1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 84)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(230, 684)
        Me.PanelMenu.TabIndex = 3
        '
        'MyButton2
        '
        Me.MyButton2.BackColor = System.Drawing.Color.Transparent
        Me.MyButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButton2.Image = Global.WEMULauncher.My.Resources.Resources.wotlk
        Me.MyButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButton2.ImageHover = Global.WEMULauncher.My.Resources.Resources.wotlk
        Me.MyButton2.ImageNormal = Global.WEMULauncher.My.Resources.Resources.wotlk
        Me.MyButton2.Location = New System.Drawing.Point(16, 61)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(210, 61)
        Me.MyButton2.TabIndex = 9
        Me.MyButton2.Text = "    巫妖王之怒"
        Me.MyButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButton2.UseVisualStyleBackColor = True
        '
        'MyButtonSlide
        '
        Me.MyButtonSlide.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonSlide.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonSlide.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonSlide.Image = Global.WEMULauncher.My.Resources.Resources.expand_normal
        Me.MyButtonSlide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonSlide.ImageHover = Global.WEMULauncher.My.Resources.Resources.collapse_normal
        Me.MyButtonSlide.ImageNormal = Global.WEMULauncher.My.Resources.Resources.expand_normal
        Me.MyButtonSlide.Location = New System.Drawing.Point(16, 626)
        Me.MyButtonSlide.Name = "MyButtonSlide"
        Me.MyButtonSlide.Size = New System.Drawing.Size(43, 41)
        Me.MyButtonSlide.TabIndex = 8
        Me.MyButtonSlide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonSlide.UseVisualStyleBackColor = True
        '
        'MyButton1
        '
        Me.MyButton1.BackColor = System.Drawing.Color.Transparent
        Me.MyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButton1.Image = Global.WEMULauncher.My.Resources.Resources.cata
        Me.MyButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButton1.ImageHover = Global.WEMULauncher.My.Resources.Resources.cata
        Me.MyButton1.ImageNormal = Global.WEMULauncher.My.Resources.Resources.cata
        Me.MyButton1.Location = New System.Drawing.Point(16, 6)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(210, 61)
        Me.MyButton1.TabIndex = 7
        Me.MyButton1.Text = "    经典旧世"
        Me.MyButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'PanelContent
        '
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(230, 84)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(794, 684)
        Me.PanelContent.TabIndex = 7
        '
        'CtrlBanner1
        '
        Me.CtrlBanner1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlBanner1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlBanner1.Name = "CtrlBanner1"
        Me.CtrlBanner1.Opacity = 0
        Me.CtrlBanner1.Size = New System.Drawing.Size(1024, 84)
        Me.CtrlBanner1.TabIndex = 0
        '
        'CtrlMainPage2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.background_blizzcon
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelHeader)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CtrlMainPage2"
        Me.Size = New System.Drawing.Size(1024, 768)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelContent As Panel
    Friend WithEvents MyButton1 As myButton
    Friend WithEvents MyButtonSlide As myButton
    Friend WithEvents MyButton2 As myButton
    Friend WithEvents CtrlBanner1 As CtrlBanner
End Class
