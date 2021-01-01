<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelPage
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelPage))
        Me.CtrlMainPage21 = New WEMULauncher.CtrlMainPage2()
        Me.CtrlNewsPage1 = New WEMULauncher.CtrlNewsPage()
        Me.CtrlShopPage1 = New WEMULauncher.CtrlShopPage()
        Me.CtrlFriendPage1 = New WEMULauncher.CtrlFriendPage()
        Me.SuspendLayout()
        '
        'CtrlMainPage21
        '
        Me.CtrlMainPage21.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMainPage21.BackgroundImage = CType(resources.GetObject("CtrlMainPage21.BackgroundImage"), System.Drawing.Image)
        Me.CtrlMainPage21.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlMainPage21.Location = New System.Drawing.Point(0, 0)
        Me.CtrlMainPage21.Name = "CtrlMainPage21"
        Me.CtrlMainPage21.Size = New System.Drawing.Size(1024, 768)
        Me.CtrlMainPage21.TabIndex = 4
        '
        'CtrlNewsPage1
        '
        Me.CtrlNewsPage1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlNewsPage1.BackgroundImage = CType(resources.GetObject("CtrlNewsPage1.BackgroundImage"), System.Drawing.Image)
        Me.CtrlNewsPage1.Location = New System.Drawing.Point(3072, 0)
        Me.CtrlNewsPage1.Name = "CtrlNewsPage1"
        Me.CtrlNewsPage1.Size = New System.Drawing.Size(1024, 768)
        Me.CtrlNewsPage1.TabIndex = 3
        '
        'CtrlShopPage1
        '
        Me.CtrlShopPage1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlShopPage1.BackgroundImage = CType(resources.GetObject("CtrlShopPage1.BackgroundImage"), System.Drawing.Image)
        Me.CtrlShopPage1.Location = New System.Drawing.Point(2048, 0)
        Me.CtrlShopPage1.Name = "CtrlShopPage1"
        Me.CtrlShopPage1.Size = New System.Drawing.Size(1024, 768)
        Me.CtrlShopPage1.TabIndex = 2
        '
        'CtrlFriendPage1
        '
        Me.CtrlFriendPage1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlFriendPage1.BackgroundImage = CType(resources.GetObject("CtrlFriendPage1.BackgroundImage"), System.Drawing.Image)
        Me.CtrlFriendPage1.Location = New System.Drawing.Point(1024, 0)
        Me.CtrlFriendPage1.Name = "CtrlFriendPage1"
        Me.CtrlFriendPage1.Size = New System.Drawing.Size(1024, 768)
        Me.CtrlFriendPage1.TabIndex = 1
        '
        'PanelPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CtrlMainPage21)
        Me.Controls.Add(Me.CtrlNewsPage1)
        Me.Controls.Add(Me.CtrlShopPage1)
        Me.Controls.Add(Me.CtrlFriendPage1)
        Me.Name = "PanelPage"
        Me.Size = New System.Drawing.Size(4120, 768)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlFriendPage1 As CtrlFriendPage
    Friend WithEvents CtrlShopPage1 As CtrlShopPage
    Friend WithEvents CtrlNewsPage1 As CtrlNewsPage
    Friend WithEvents CtrlMainPage21 As CtrlMainPage2
End Class
