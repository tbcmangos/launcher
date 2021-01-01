<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlMainPage
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CtrlTransPanelCenter = New WEMULauncher.CtrlTransPanel()
        Me.CtrlTransPanelTop = New WEMULauncher.CtrlTransPanel()
        Me.CtrlTransPanelLeft = New WEMULauncher.CtrlTransPanel()
        Me.MyButtonSlide = New WEMULauncher.myButton()
        Me.MyButton1 = New WEMULauncher.myButton()
        Me.CtrlTransPanelCenter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'CtrlTransPanelCenter
        '
        Me.CtrlTransPanelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtrlTransPanelCenter.Controls.Add(Me.MyButtonSlide)
        Me.CtrlTransPanelCenter.Controls.Add(Me.MyButton1)
        Me.CtrlTransPanelCenter.Location = New System.Drawing.Point(176, 82)
        Me.CtrlTransPanelCenter.Name = "CtrlTransPanelCenter"
        Me.CtrlTransPanelCenter.Size = New System.Drawing.Size(862, 695)
        Me.CtrlTransPanelCenter.TabIndex = 2
        '
        'CtrlTransPanelTop
        '
        Me.CtrlTransPanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtrlTransPanelTop.Location = New System.Drawing.Point(192, 0)
        Me.CtrlTransPanelTop.Name = "CtrlTransPanelTop"
        Me.CtrlTransPanelTop.Size = New System.Drawing.Size(832, 76)
        Me.CtrlTransPanelTop.TabIndex = 2
        '
        'CtrlTransPanelLeft
        '
        Me.CtrlTransPanelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CtrlTransPanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrlTransPanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.CtrlTransPanelLeft.Name = "CtrlTransPanelLeft"
        Me.CtrlTransPanelLeft.Size = New System.Drawing.Size(192, 768)
        Me.CtrlTransPanelLeft.TabIndex = 1
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
        Me.MyButtonSlide.Location = New System.Drawing.Point(222, 445)
        Me.MyButtonSlide.Name = "MyButtonSlide"
        Me.MyButtonSlide.Size = New System.Drawing.Size(43, 41)
        Me.MyButtonSlide.TabIndex = 1
        Me.MyButtonSlide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonSlide.UseVisualStyleBackColor = True
        '
        'MyButton1
        '
        Me.MyButton1.BackColor = System.Drawing.Color.Transparent
        Me.MyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButton1.Image = Global.WEMULauncher.My.Resources.Resources.btn_win_close_normal
        Me.MyButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButton1.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_win_close_hover
        Me.MyButton1.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_win_close_normal
        Me.MyButton1.Location = New System.Drawing.Point(155, 191)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(210, 46)
        Me.MyButton1.TabIndex = 0
        Me.MyButton1.Text = "MyButton1"
        Me.MyButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'CtrlMainPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.background_blizzcon
        Me.Controls.Add(Me.CtrlTransPanelTop)
        Me.Controls.Add(Me.CtrlTransPanelCenter)
        Me.Controls.Add(Me.CtrlTransPanelLeft)
        Me.Name = "CtrlMainPage"
        Me.Size = New System.Drawing.Size(1024, 768)
        Me.CtrlTransPanelCenter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyButton1 As myButton
    Friend WithEvents CtrlTransPanelLeft As CtrlTransPanel
    Friend WithEvents CtrlTransPanelTop As CtrlTransPanel
    Friend WithEvents CtrlTransPanelCenter As CtrlTransPanel
    Friend WithEvents MyButtonSlide As myButton
    Friend WithEvents Timer1 As Timer
End Class
