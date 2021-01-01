Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlBanner
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
        Me.CtrlTransClose = New WEMULauncher.myButton()
        Me.CtrlTransMaxmize = New WEMULauncher.myButton()
        Me.CtrlTransMinimize = New WEMULauncher.myButton()
        Me.CtrlTransNews = New WEMULauncher.myButton()
        Me.CtrlTransShop = New WEMULauncher.myButton()
        Me.CtrlTransFriend = New WEMULauncher.myButton()
        Me.CtrlTransMain = New WEMULauncher.myButton()
        Me.MyButtonLogo = New WEMULauncher.myButton()
        Me.CtrlTransPictture7 = New WEMULauncher.CtrlTransPicture()
        CType(Me.CtrlTransPictture7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CtrlTransClose
        '
        Me.CtrlTransClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTransClose.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransClose.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransClose.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.CtrlTransClose.Image = Global.WEMULauncher.My.Resources.Resources.btn_win_close_normal
        Me.CtrlTransClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransClose.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_win_close_hover
        Me.CtrlTransClose.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_win_close_normal
        Me.CtrlTransClose.Location = New System.Drawing.Point(996, 3)
        Me.CtrlTransClose.Name = "CtrlTransClose"
        Me.CtrlTransClose.Size = New System.Drawing.Size(25, 28)
        Me.CtrlTransClose.TabIndex = 32
        Me.CtrlTransClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransClose.UseVisualStyleBackColor = True
        '
        'CtrlTransMaxmize
        '
        Me.CtrlTransMaxmize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTransMaxmize.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransMaxmize.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransMaxmize.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.CtrlTransMaxmize.Image = Global.WEMULauncher.My.Resources.Resources.btn_win_maximize_normal
        Me.CtrlTransMaxmize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransMaxmize.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_win_maximize_hover
        Me.CtrlTransMaxmize.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_win_maximize_normal
        Me.CtrlTransMaxmize.Location = New System.Drawing.Point(965, 3)
        Me.CtrlTransMaxmize.Name = "CtrlTransMaxmize"
        Me.CtrlTransMaxmize.Size = New System.Drawing.Size(25, 28)
        Me.CtrlTransMaxmize.TabIndex = 31
        Me.CtrlTransMaxmize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransMaxmize.UseVisualStyleBackColor = True
        '
        'CtrlTransMinimize
        '
        Me.CtrlTransMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTransMinimize.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransMinimize.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransMinimize.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.CtrlTransMinimize.Image = Global.WEMULauncher.My.Resources.Resources.btn_win_minimize_normal
        Me.CtrlTransMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransMinimize.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_win_minimize_hover
        Me.CtrlTransMinimize.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_win_minimize_normal
        Me.CtrlTransMinimize.Location = New System.Drawing.Point(934, 3)
        Me.CtrlTransMinimize.Name = "CtrlTransMinimize"
        Me.CtrlTransMinimize.Size = New System.Drawing.Size(25, 28)
        Me.CtrlTransMinimize.TabIndex = 30
        Me.CtrlTransMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransMinimize.UseVisualStyleBackColor = True
        '
        'CtrlTransNews
        '
        Me.CtrlTransNews.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransNews.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransNews.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.CtrlTransNews.Image = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.CtrlTransNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransNews.ImageHover = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_hovered_release
        Me.CtrlTransNews.ImageNormal = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.CtrlTransNews.Location = New System.Drawing.Point(517, 31)
        Me.CtrlTransNews.Name = "CtrlTransNews"
        Me.CtrlTransNews.Size = New System.Drawing.Size(98, 50)
        Me.CtrlTransNews.TabIndex = 29
        Me.CtrlTransNews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransNews.UseVisualStyleBackColor = True
        '
        'CtrlTransShop
        '
        Me.CtrlTransShop.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransShop.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransShop.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.CtrlTransShop.Image = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.CtrlTransShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransShop.ImageHover = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_hovered_release
        Me.CtrlTransShop.ImageNormal = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.CtrlTransShop.Location = New System.Drawing.Point(413, 31)
        Me.CtrlTransShop.Name = "CtrlTransShop"
        Me.CtrlTransShop.Size = New System.Drawing.Size(98, 50)
        Me.CtrlTransShop.TabIndex = 28
        Me.CtrlTransShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransShop.UseVisualStyleBackColor = True
        '
        'CtrlTransFriend
        '
        Me.CtrlTransFriend.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransFriend.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransFriend.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.CtrlTransFriend.Image = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.CtrlTransFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransFriend.ImageHover = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_hovered_release
        Me.CtrlTransFriend.ImageNormal = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.CtrlTransFriend.Location = New System.Drawing.Point(309, 31)
        Me.CtrlTransFriend.Name = "CtrlTransFriend"
        Me.CtrlTransFriend.Size = New System.Drawing.Size(98, 50)
        Me.CtrlTransFriend.TabIndex = 27
        Me.CtrlTransFriend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransFriend.UseVisualStyleBackColor = True
        '
        'CtrlTransMain
        '
        Me.CtrlTransMain.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransMain.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransMain.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.CtrlTransMain.Image = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.CtrlTransMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransMain.ImageHover = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_hovered_release
        Me.CtrlTransMain.ImageNormal = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.CtrlTransMain.Location = New System.Drawing.Point(205, 30)
        Me.CtrlTransMain.Name = "CtrlTransMain"
        Me.CtrlTransMain.Size = New System.Drawing.Size(98, 50)
        Me.CtrlTransMain.TabIndex = 26
        Me.CtrlTransMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransMain.UseVisualStyleBackColor = True
        '
        'MyButtonLogo
        '
        Me.MyButtonLogo.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonLogo.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonLogo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.MyButtonLogo.Image = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.MyButtonLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonLogo.ImageHover = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_hovered_release
        Me.MyButtonLogo.ImageNormal = Global.WEMULauncher.My.Resources.Resources.img_blizzButton_normal_release
        Me.MyButtonLogo.Location = New System.Drawing.Point(18, 19)
        Me.MyButtonLogo.Name = "MyButtonLogo"
        Me.MyButtonLogo.Size = New System.Drawing.Size(136, 61)
        Me.MyButtonLogo.TabIndex = 25
        Me.MyButtonLogo.Text = "V"
        Me.MyButtonLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonLogo.UseVisualStyleBackColor = True
        '
        'CtrlTransPictture7
        '
        Me.CtrlTransPictture7.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransPictture7.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.border_topbar_inactive
        Me.CtrlTransPictture7.Image = Global.WEMULauncher.My.Resources.Resources.top1
        Me.CtrlTransPictture7.Location = New System.Drawing.Point(98, 0)
        Me.CtrlTransPictture7.Name = "CtrlTransPictture7"
        Me.CtrlTransPictture7.Opacity = 1
        Me.CtrlTransPictture7.Size = New System.Drawing.Size(825, 13)
        Me.CtrlTransPictture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CtrlTransPictture7.TabIndex = 18
        Me.CtrlTransPictture7.TabStop = False
        '
        'CtrlBanner
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CtrlTransClose)
        Me.Controls.Add(Me.CtrlTransMaxmize)
        Me.Controls.Add(Me.CtrlTransMinimize)
        Me.Controls.Add(Me.CtrlTransNews)
        Me.Controls.Add(Me.CtrlTransShop)
        Me.Controls.Add(Me.CtrlTransFriend)
        Me.Controls.Add(Me.CtrlTransMain)
        Me.Controls.Add(Me.MyButtonLogo)
        Me.Controls.Add(Me.CtrlTransPictture7)
        Me.Name = "CtrlBanner"
        Me.Size = New System.Drawing.Size(1024, 84)
        CType(Me.CtrlTransPictture7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#Region "transparency"

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.Opaque, True)
        ''transparency
        'SetStyle(ControlStyles.Opaque, True)
        'SetStyle(ControlStyles.OptimizedDoubleBuffer, False)
        'SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Public Sub New(con As IContainer)

        con.Add(Me)
        InitializeComponent()
    End Sub

    Private Const WS_EX_TRANSPARENT As Integer = &H20
    Protected Overrides ReadOnly Property CreateParams() _
            As CreateParams

        Get
            Dim cpar As CreateParams = MyBase.CreateParams

            cpar.ExStyle = cpar.ExStyle Or WS_EX_TRANSPARENT

            Return cpar

        End Get

    End Property
    Private iopacity As Integer = 50

    <DefaultValue(50)>
    Public Property Opacity() As Integer

        Get

            Return Me.iopacity

        End Get

        Set

            If Value < 0 OrElse Value > 100 Then

                Throw New ArgumentException("value must be between _
                  0 and 100")

            End If

            Me.iopacity = Value

        End Set

    End Property
#End Region


    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        Using brush = New SolidBrush(Color.FromArgb(Me.Opacity _
               * 255 / 100, Me.BackColor))

            e.Graphics.FillRectangle(brush, Me.ClientRectangle)

        End Using

        MyBase.OnPaint(e)

    End Sub
    Friend WithEvents CtrlTransPictture7 As CtrlTransPicture
    Friend WithEvents MyButtonLogo As myButton
    Friend WithEvents CtrlTransMain As myButton
    Friend WithEvents CtrlTransFriend As myButton
    Friend WithEvents CtrlTransShop As myButton
    Friend WithEvents CtrlTransNews As myButton
    Friend WithEvents CtrlTransMinimize As myButton
    Friend WithEvents CtrlTransMaxmize As myButton
    Friend WithEvents CtrlTransClose As myButton
End Class
