
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm2
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm2))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.pnlSelection = New System.Windows.Forms.Panel()
        Me.TimerExpand = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.lblRAM = New System.Windows.Forms.Label()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.prgRAM = New System.Windows.Forms.ProgressBar()
        Me.prgCPU = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.FlowLayoutPanelStatus = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelMainSlide = New System.Windows.Forms.Panel()
        Me.PanelSlide = New System.Windows.Forms.Panel()
        Me.PanelSlideContent = New System.Windows.Forms.Panel()
        Me.SlidePanelNews = New System.Windows.Forms.Panel()
        Me.ImageListBG = New System.Windows.Forms.ImageList(Me.components)
        Me.TimerSlide = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.TimerNotice = New System.Windows.Forms.Timer(Me.components)
        Me.WaitServer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDBandWEBProcess = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAuthAndWorld = New System.Windows.Forms.Timer(Me.components)
        Me.pRAM = New System.Diagnostics.PerformanceCounter()
        Me.pCPU = New System.Diagnostics.PerformanceCounter()
        Me.TimerPerformance = New System.Windows.Forms.Timer(Me.components)
        Me.btnStatusDB = New WEMULauncher.myButton()
        Me.btnStatusWeb = New WEMULauncher.myButton()
        Me.btnStatusAuth = New WEMULauncher.myButton()
        Me.btnStatusWorld = New WEMULauncher.myButton()
        Me.btnSlideRight = New WEMULauncher.myButton()
        Me.btnSlideLeft = New WEMULauncher.myButton()
        Me.btnSlideHeader = New WEMULauncher.myButtonHover()
        Me.btnSlideContent = New WEMULauncher.myButtonHover()
        Me.PanelButtonLegal = New WEMULauncher.myButtonHover()
        Me.btnSlideNews = New WEMULauncher.myButtonHover()
        Me.MyButtonTrans1 = New WEMULauncher.myButtonTrans(Me.components)
        Me.MyButtonHover3 = New WEMULauncher.myButtonHover()
        Me.MyButtonHover2 = New WEMULauncher.myButtonHover()
        Me.MyButtonHover1 = New WEMULauncher.myButtonHover()
        Me.MyButton6 = New WEMULauncher.myButton()
        Me.MyButton5 = New WEMULauncher.myButton()
        Me.btnWOWPatch = New WEMULauncher.myButtonHover()
        Me.btnWOWVersion = New WEMULauncher.myButton()
        Me.MyButtonRun = New WEMULauncher.myButtonEllipse()
        Me.MyButtonWar3 = New WEMULauncher.myButtonHover()
        Me.MyButtonOverwatch = New WEMULauncher.myButtonHover()
        Me.MyButtonHeroes = New WEMULauncher.myButtonHover()
        Me.MyButtonHS = New WEMULauncher.myButtonHover()
        Me.MyButtonSC2 = New WEMULauncher.myButtonHover()
        Me.MyButtonD3 = New WEMULauncher.myButtonHover()
        Me.MyButtonSlide = New WEMULauncher.myButton()
        Me.MyButtonWOW = New WEMULauncher.myButtonHover()
        Me.MyButton8 = New WEMULauncher.myButton()
        Me.MyButtonHover9 = New WEMULauncher.myButtonHover()
        Me.MyButtonHover8 = New WEMULauncher.myButtonHover()
        Me.MyButtonHover7 = New WEMULauncher.myButtonHover()
        Me.MyButtonHover6 = New WEMULauncher.myButtonHover()
        Me.MyButton7 = New WEMULauncher.myButton()
        Me.CtrlTransClose = New WEMULauncher.myButton()
        Me.CtrlTransMaxmize = New WEMULauncher.myButton()
        Me.CtrlTransMinimize = New WEMULauncher.myButton()
        Me.CtrlTransNews = New WEMULauncher.myButtonFontChange()
        Me.CtrlTransShop = New WEMULauncher.myButtonFontChange()
        Me.CtrlTransFriend = New WEMULauncher.myButtonFontChange()
        Me.CtrlTransMain = New WEMULauncher.myButtonFontChange()
        Me.MyButtonLogo = New WEMULauncher.myButton()
        Me.CtrlTransPictture7 = New WEMULauncher.CtrlTransPicture()
        Me.MyButtonBottomNotice = New WEMULauncher.myButtonTrans(Me.components)
        Me.MyControlEllipse1 = New WEMULauncher.myControlEllipse()
        Me.PanelHeader.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanelStatus.SuspendLayout()
        Me.PanelMainSlide.SuspendLayout()
        Me.PanelSlide.SuspendLayout()
        Me.PanelSlideContent.SuspendLayout()
        Me.SlidePanelNews.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        CType(Me.pRAM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrlTransPictture7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Transparent
        Me.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.MyButton8)
        Me.PanelHeader.Controls.Add(Me.MyButtonHover9)
        Me.PanelHeader.Controls.Add(Me.MyButtonHover8)
        Me.PanelHeader.Controls.Add(Me.MyButtonHover7)
        Me.PanelHeader.Controls.Add(Me.MyButtonHover6)
        Me.PanelHeader.Controls.Add(Me.MyButton7)
        Me.PanelHeader.Controls.Add(Me.CtrlTransClose)
        Me.PanelHeader.Controls.Add(Me.CtrlTransMaxmize)
        Me.PanelHeader.Controls.Add(Me.CtrlTransMinimize)
        Me.PanelHeader.Controls.Add(Me.CtrlTransNews)
        Me.PanelHeader.Controls.Add(Me.CtrlTransShop)
        Me.PanelHeader.Controls.Add(Me.CtrlTransFriend)
        Me.PanelHeader.Controls.Add(Me.CtrlTransMain)
        Me.PanelHeader.Controls.Add(Me.MyButtonLogo)
        Me.PanelHeader.Controls.Add(Me.CtrlTransPictture7)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1200, 84)
        Me.PanelHeader.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.MyButtonWar3)
        Me.PanelMenu.Controls.Add(Me.MyButtonOverwatch)
        Me.PanelMenu.Controls.Add(Me.MyButtonHeroes)
        Me.PanelMenu.Controls.Add(Me.MyButtonHS)
        Me.PanelMenu.Controls.Add(Me.MyButtonSC2)
        Me.PanelMenu.Controls.Add(Me.MyButtonD3)
        Me.PanelMenu.Controls.Add(Me.MyButtonSlide)
        Me.PanelMenu.Controls.Add(Me.MyButtonWOW)
        Me.PanelMenu.Controls.Add(Me.pnlSelection)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 84)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(210, 676)
        Me.PanelMenu.TabIndex = 3
        '
        'pnlSelection
        '
        Me.pnlSelection.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlSelection.Location = New System.Drawing.Point(0, 5)
        Me.pnlSelection.Name = "pnlSelection"
        Me.pnlSelection.Size = New System.Drawing.Size(10, 60)
        Me.pnlSelection.TabIndex = 12
        '
        'TimerExpand
        '
        Me.TimerExpand.Interval = 1
        Me.TimerExpand.Tag = "左边栏展开动画"
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.Transparent
        Me.PanelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContent.Controls.Add(Me.lblRAM)
        Me.PanelContent.Controls.Add(Me.lblCPU)
        Me.PanelContent.Controls.Add(Me.prgRAM)
        Me.PanelContent.Controls.Add(Me.prgCPU)
        Me.PanelContent.Controls.Add(Me.Label1)
        Me.PanelContent.Controls.Add(Me.Label2)
        Me.PanelContent.Controls.Add(Me.Chart1)
        Me.PanelContent.Controls.Add(Me.FlowLayoutPanelStatus)
        Me.PanelContent.Controls.Add(Me.PanelMainSlide)
        Me.PanelContent.Controls.Add(Me.MyButtonHover3)
        Me.PanelContent.Controls.Add(Me.MyButtonHover2)
        Me.PanelContent.Controls.Add(Me.MyButtonHover1)
        Me.PanelContent.Controls.Add(Me.MyButton6)
        Me.PanelContent.Controls.Add(Me.MyButton5)
        Me.PanelContent.Controls.Add(Me.btnWOWPatch)
        Me.PanelContent.Controls.Add(Me.btnWOWVersion)
        Me.PanelContent.Controls.Add(Me.MyButtonRun)
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(210, 84)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(990, 676)
        Me.PanelContent.TabIndex = 7
        '
        'lblRAM
        '
        Me.lblRAM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRAM.AutoSize = True
        Me.lblRAM.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRAM.Location = New System.Drawing.Point(931, 604)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(32, 19)
        Me.lblRAM.TabIndex = 58
        Me.lblRAM.Text = "0 %"
        '
        'lblCPU
        '
        Me.lblCPU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCPU.AutoSize = True
        Me.lblCPU.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblCPU.Location = New System.Drawing.Point(776, 604)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(32, 19)
        Me.lblCPU.TabIndex = 57
        Me.lblCPU.Text = "0 %"
        '
        'prgRAM
        '
        Me.prgRAM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prgRAM.Location = New System.Drawing.Point(870, 604)
        Me.prgRAM.Name = "prgRAM"
        Me.prgRAM.Size = New System.Drawing.Size(58, 16)
        Me.prgRAM.TabIndex = 56
        '
        'prgCPU
        '
        Me.prgCPU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prgCPU.Location = New System.Drawing.Point(715, 604)
        Me.prgCPU.Name = "prgCPU"
        Me.prgCPU.Size = New System.Drawing.Size(58, 16)
        Me.prgCPU.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(674, 604)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "CPU:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(828, 604)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "RAM:"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.BlueViolet
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.Maximum = 100.0R
        ChartArea2.AxisY.Minimum = 0R
        ChartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea2.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.DockedToChartArea = "ChartArea1"
        Legend2.Enabled = False
        Legend2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.ForeColor = System.Drawing.Color.White
        Legend2.IsTextAutoFit = False
        Legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row
        Legend2.Name = "Legend1"
        Legend2.TitleBackColor = System.Drawing.Color.Transparent
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(674, 519)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "CPU"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Legend = "Legend1"
        Series4.Name = "RAM"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(305, 101)
        Me.Chart1.TabIndex = 59
        Me.Chart1.Text = "Chart1"
        '
        'FlowLayoutPanelStatus
        '
        Me.FlowLayoutPanelStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanelStatus.Controls.Add(Me.btnStatusDB)
        Me.FlowLayoutPanelStatus.Controls.Add(Me.btnStatusWeb)
        Me.FlowLayoutPanelStatus.Controls.Add(Me.btnStatusAuth)
        Me.FlowLayoutPanelStatus.Controls.Add(Me.btnStatusWorld)
        Me.FlowLayoutPanelStatus.Location = New System.Drawing.Point(674, 623)
        Me.FlowLayoutPanelStatus.Name = "FlowLayoutPanelStatus"
        Me.FlowLayoutPanelStatus.Size = New System.Drawing.Size(311, 46)
        Me.FlowLayoutPanelStatus.TabIndex = 52
        '
        'PanelMainSlide
        '
        Me.PanelMainSlide.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMainSlide.Controls.Add(Me.PanelSlide)
        Me.PanelMainSlide.Controls.Add(Me.PanelButtonLegal)
        Me.PanelMainSlide.Controls.Add(Me.SlidePanelNews)
        Me.PanelMainSlide.Location = New System.Drawing.Point(44, 201)
        Me.PanelMainSlide.Name = "PanelMainSlide"
        Me.PanelMainSlide.Size = New System.Drawing.Size(945, 267)
        Me.PanelMainSlide.TabIndex = 45
        '
        'PanelSlide
        '
        Me.PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaBWL
        Me.PanelSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelSlide.Controls.Add(Me.PanelSlideContent)
        Me.PanelSlide.Controls.Add(Me.btnSlideHeader)
        Me.PanelSlide.Controls.Add(Me.btnSlideContent)
        Me.PanelSlide.Location = New System.Drawing.Point(3, 3)
        Me.PanelSlide.Name = "PanelSlide"
        Me.PanelSlide.Size = New System.Drawing.Size(445, 264)
        Me.PanelSlide.TabIndex = 0
        '
        'PanelSlideContent
        '
        Me.PanelSlideContent.Controls.Add(Me.btnSlideRight)
        Me.PanelSlideContent.Controls.Add(Me.btnSlideLeft)
        Me.PanelSlideContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSlideContent.Location = New System.Drawing.Point(0, 0)
        Me.PanelSlideContent.Name = "PanelSlideContent"
        Me.PanelSlideContent.Size = New System.Drawing.Size(445, 150)
        Me.PanelSlideContent.TabIndex = 39
        '
        'SlidePanelNews
        '
        Me.SlidePanelNews.Controls.Add(Me.btnSlideNews)
        Me.SlidePanelNews.Controls.Add(Me.MyButtonTrans1)
        Me.SlidePanelNews.Location = New System.Drawing.Point(698, 3)
        Me.SlidePanelNews.Name = "SlidePanelNews"
        Me.SlidePanelNews.Size = New System.Drawing.Size(200, 264)
        Me.SlidePanelNews.TabIndex = 37
        '
        'ImageListBG
        '
        Me.ImageListBG.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListBG.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBG.TransparentColor = System.Drawing.Color.Transparent
        '
        'TimerSlide
        '
        Me.TimerSlide.Enabled = True
        Me.TimerSlide.Interval = 3000
        Me.TimerSlide.Tag = "展示轮播动画效果"
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Transparent
        Me.PanelBottom.Controls.Add(Me.MyButtonBottomNotice)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 760)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1200, 40)
        Me.PanelBottom.TabIndex = 8
        '
        'TimerNotice
        '
        Me.TimerNotice.Interval = 3000
        Me.TimerNotice.Tag = "启动时下方提示栏时间"
        '
        'WaitServer
        '
        Me.WaitServer.Interval = 1000
        Me.WaitServer.Tag = "等待Auth和World服务启动代码"
        '
        'TimerDBandWEBProcess
        '
        Me.TimerDBandWEBProcess.Interval = 1000
        Me.TimerDBandWEBProcess.Tag = "进程侦测计时"
        '
        'TimerAuthAndWorld
        '
        Me.TimerAuthAndWorld.Interval = 1000
        Me.TimerAuthAndWorld.Tag = "Auth和World进程侦测"
        '
        'pRAM
        '
        Me.pRAM.CategoryName = "Memory"
        Me.pRAM.CounterName = "% Committed bytes in use"
        '
        'pCPU
        '
        Me.pCPU.CategoryName = "Processor"
        Me.pCPU.CounterName = "% Processor time"
        Me.pCPU.InstanceName = "_Total"
        '
        'TimerPerformance
        '
        Me.TimerPerformance.Enabled = True
        Me.TimerPerformance.Interval = 1000
        '
        'btnStatusDB
        '
        Me.btnStatusDB.BackColor = System.Drawing.Color.Transparent
        Me.btnStatusDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusDB.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStatusDB.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnStatusDB.Image = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatusDB.ImageHover = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusDB.ImageNormal = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusDB.Location = New System.Drawing.Point(3, 3)
        Me.btnStatusDB.Name = "btnStatusDB"
        Me.btnStatusDB.Size = New System.Drawing.Size(71, 39)
        Me.btnStatusDB.TabIndex = 48
        Me.btnStatusDB.Text = "db"
        Me.btnStatusDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatusDB.UseVisualStyleBackColor = True
        '
        'btnStatusWeb
        '
        Me.btnStatusWeb.BackColor = System.Drawing.Color.Transparent
        Me.btnStatusWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusWeb.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStatusWeb.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnStatusWeb.Image = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatusWeb.ImageHover = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusWeb.ImageNormal = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusWeb.Location = New System.Drawing.Point(80, 3)
        Me.btnStatusWeb.Name = "btnStatusWeb"
        Me.btnStatusWeb.Size = New System.Drawing.Size(71, 39)
        Me.btnStatusWeb.TabIndex = 49
        Me.btnStatusWeb.Text = "web"
        Me.btnStatusWeb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatusWeb.UseVisualStyleBackColor = True
        '
        'btnStatusAuth
        '
        Me.btnStatusAuth.BackColor = System.Drawing.Color.Transparent
        Me.btnStatusAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusAuth.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStatusAuth.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnStatusAuth.Image = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusAuth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatusAuth.ImageHover = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusAuth.ImageNormal = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusAuth.Location = New System.Drawing.Point(157, 3)
        Me.btnStatusAuth.Name = "btnStatusAuth"
        Me.btnStatusAuth.Size = New System.Drawing.Size(71, 39)
        Me.btnStatusAuth.TabIndex = 50
        Me.btnStatusAuth.Text = "auth"
        Me.btnStatusAuth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatusAuth.UseVisualStyleBackColor = True
        '
        'btnStatusWorld
        '
        Me.btnStatusWorld.BackColor = System.Drawing.Color.Transparent
        Me.btnStatusWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusWorld.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStatusWorld.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnStatusWorld.Image = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusWorld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatusWorld.ImageHover = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusWorld.ImageNormal = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.btnStatusWorld.Location = New System.Drawing.Point(234, 3)
        Me.btnStatusWorld.Name = "btnStatusWorld"
        Me.btnStatusWorld.Size = New System.Drawing.Size(71, 39)
        Me.btnStatusWorld.TabIndex = 51
        Me.btnStatusWorld.Text = "world"
        Me.btnStatusWorld.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatusWorld.UseVisualStyleBackColor = True
        '
        'btnSlideRight
        '
        Me.btnSlideRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSlideRight.BackColor = System.Drawing.Color.Transparent
        Me.btnSlideRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSlideRight.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlideRight.ForeColor = System.Drawing.Color.Transparent
        Me.btnSlideRight.Image = Global.WEMULauncher.My.Resources.Resources.btn_secondary_disabled
        Me.btnSlideRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideRight.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_primary_hover
        Me.btnSlideRight.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_secondary_disabled
        Me.btnSlideRight.Location = New System.Drawing.Point(410, 25)
        Me.btnSlideRight.Name = "btnSlideRight"
        Me.btnSlideRight.Size = New System.Drawing.Size(32, 66)
        Me.btnSlideRight.TabIndex = 37
        Me.btnSlideRight.Text = ">"
        Me.btnSlideRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSlideRight.UseVisualStyleBackColor = True
        '
        'btnSlideLeft
        '
        Me.btnSlideLeft.BackColor = System.Drawing.Color.Transparent
        Me.btnSlideLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSlideLeft.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlideLeft.ForeColor = System.Drawing.Color.Transparent
        Me.btnSlideLeft.Image = Global.WEMULauncher.My.Resources.Resources.btn_secondary_disabled
        Me.btnSlideLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideLeft.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_primary_hover
        Me.btnSlideLeft.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_secondary_disabled
        Me.btnSlideLeft.Location = New System.Drawing.Point(3, 25)
        Me.btnSlideLeft.Name = "btnSlideLeft"
        Me.btnSlideLeft.Size = New System.Drawing.Size(32, 66)
        Me.btnSlideLeft.TabIndex = 38
        Me.btnSlideLeft.Text = "<"
        Me.btnSlideLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSlideLeft.UseVisualStyleBackColor = True
        '
        'btnSlideHeader
        '
        Me.btnSlideHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnSlideHeader.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSlideHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSlideHeader.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSlideHeader.ForeColor = System.Drawing.Color.White
        Me.btnSlideHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideHeader.ImageHover = Nothing
        Me.btnSlideHeader.ImageNormal = Nothing
        Me.btnSlideHeader.Location = New System.Drawing.Point(0, 150)
        Me.btnSlideHeader.Name = "btnSlideHeader"
        Me.btnSlideHeader.Size = New System.Drawing.Size(445, 54)
        Me.btnSlideHeader.TabIndex = 17
        Me.btnSlideHeader.Text = "WOW Classic : The Spoils of War"
        Me.btnSlideHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideHeader.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSlideHeader.UseVisualStyleBackColor = True
        '
        'btnSlideContent
        '
        Me.btnSlideContent.BackColor = System.Drawing.Color.Transparent
        Me.btnSlideContent.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSlideContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSlideContent.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlideContent.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnSlideContent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideContent.ImageHover = Nothing
        Me.btnSlideContent.ImageNormal = Nothing
        Me.btnSlideContent.Location = New System.Drawing.Point(0, 204)
        Me.btnSlideContent.Name = "btnSlideContent"
        Me.btnSlideContent.Size = New System.Drawing.Size(445, 60)
        Me.btnSlideContent.TabIndex = 16
        Me.btnSlideContent.Text = resources.GetString("btnSlideContent.Text")
        Me.btnSlideContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideContent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSlideContent.UseVisualStyleBackColor = True
        '
        'PanelButtonLegal
        '
        Me.PanelButtonLegal.BackColor = System.Drawing.Color.Transparent
        Me.PanelButtonLegal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PanelButtonLegal.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelButtonLegal.ForeColor = System.Drawing.Color.Transparent
        Me.PanelButtonLegal.Image = Global.WEMULauncher.My.Resources.Resources.wow
        Me.PanelButtonLegal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PanelButtonLegal.ImageHover = Global.WEMULauncher.My.Resources.Resources.wow
        Me.PanelButtonLegal.ImageNormal = Global.WEMULauncher.My.Resources.Resources.wow
        Me.PanelButtonLegal.Location = New System.Drawing.Point(454, 3)
        Me.PanelButtonLegal.Name = "PanelButtonLegal"
        Me.PanelButtonLegal.Size = New System.Drawing.Size(238, 264)
        Me.PanelButtonLegal.TabIndex = 36
        Me.PanelButtonLegal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PanelButtonLegal.UseVisualStyleBackColor = True
        '
        'btnSlideNews
        '
        Me.btnSlideNews.BackColor = System.Drawing.Color.Transparent
        Me.btnSlideNews.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSlideNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSlideNews.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlideNews.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnSlideNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSlideNews.ImageHover = Nothing
        Me.btnSlideNews.ImageNormal = Nothing
        Me.btnSlideNews.Location = New System.Drawing.Point(0, 53)
        Me.btnSlideNews.Name = "btnSlideNews"
        Me.btnSlideNews.Size = New System.Drawing.Size(200, 211)
        Me.btnSlideNews.TabIndex = 17
        Me.btnSlideNews.Text = resources.GetString("btnSlideNews.Text")
        Me.btnSlideNews.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSlideNews.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSlideNews.UseVisualStyleBackColor = True
        '
        'MyButtonTrans1
        '
        Me.MyButtonTrans1.BackColor = System.Drawing.Color.Sienna
        Me.MyButtonTrans1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyButtonTrans1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonTrans1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonTrans1.ForeColor = System.Drawing.Color.White
        Me.MyButtonTrans1.Image = Global.WEMULauncher.My.Resources.Resources.icon_breaking_news_header
        Me.MyButtonTrans1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonTrans1.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_breaking_news_header
        Me.MyButtonTrans1.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_breaking_news_header
        Me.MyButtonTrans1.Location = New System.Drawing.Point(0, 0)
        Me.MyButtonTrans1.Name = "MyButtonTrans1"
        Me.MyButtonTrans1.Size = New System.Drawing.Size(200, 53)
        Me.MyButtonTrans1.TabIndex = 0
        Me.MyButtonTrans1.Text = "News"
        Me.MyButtonTrans1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonTrans1.UseVisualStyleBackColor = False
        '
        'MyButtonHover3
        '
        Me.MyButtonHover3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.MyButtonHover3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHover3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButtonHover3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonHover3.Image = Global.WEMULauncher.My.Resources.Resources.arrow_down
        Me.MyButtonHover3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHover3.ImageHover = Global.WEMULauncher.My.Resources.Resources.arrow_down
        Me.MyButtonHover3.ImageNormal = Global.WEMULauncher.My.Resources.Resources.arrow_down
        Me.MyButtonHover3.Location = New System.Drawing.Point(141, 161)
        Me.MyButtonHover3.Name = "MyButtonHover3"
        Me.MyButtonHover3.Size = New System.Drawing.Size(26, 34)
        Me.MyButtonHover3.TabIndex = 44
        Me.MyButtonHover3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHover3.UseVisualStyleBackColor = False
        '
        'MyButtonHover2
        '
        Me.MyButtonHover2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.MyButtonHover2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHover2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButtonHover2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonHover2.Image = Global.WEMULauncher.My.Resources.Resources.contextMenu_redeemcode_on
        Me.MyButtonHover2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHover2.ImageHover = Global.WEMULauncher.My.Resources.Resources.contextMenu_redeemcode_on
        Me.MyButtonHover2.ImageNormal = Global.WEMULauncher.My.Resources.Resources.contextMenu_redeemcode_on
        Me.MyButtonHover2.Location = New System.Drawing.Point(167, 161)
        Me.MyButtonHover2.Name = "MyButtonHover2"
        Me.MyButtonHover2.Size = New System.Drawing.Size(146, 34)
        Me.MyButtonHover2.TabIndex = 43
        Me.MyButtonHover2.Text = "Use coupon"
        Me.MyButtonHover2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHover2.UseVisualStyleBackColor = False
        '
        'MyButtonHover1
        '
        Me.MyButtonHover1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.MyButtonHover1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHover1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButtonHover1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonHover1.Image = Global.WEMULauncher.My.Resources.Resources.icon_menuSettings_on
        Me.MyButtonHover1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHover1.ImageHover = Global.WEMULauncher.My.Resources.Resources.contextMenu_gamesetting_on
        Me.MyButtonHover1.ImageNormal = Global.WEMULauncher.My.Resources.Resources.contextMenu_gamesetting_on
        Me.MyButtonHover1.Location = New System.Drawing.Point(44, 161)
        Me.MyButtonHover1.Name = "MyButtonHover1"
        Me.MyButtonHover1.Size = New System.Drawing.Size(97, 34)
        Me.MyButtonHover1.TabIndex = 13
        Me.MyButtonHover1.Text = "Option"
        Me.MyButtonHover1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHover1.UseVisualStyleBackColor = False
        '
        'MyButton6
        '
        Me.MyButton6.BackColor = System.Drawing.Color.Transparent
        Me.MyButton6.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.oregoncore_small
        Me.MyButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MyButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton6.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton6.ForeColor = System.Drawing.Color.Transparent
        Me.MyButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButton6.ImageHover = Nothing
        Me.MyButton6.ImageNormal = Nothing
        Me.MyButton6.Location = New System.Drawing.Point(5, -11)
        Me.MyButton6.Name = "MyButton6"
        Me.MyButton6.Size = New System.Drawing.Size(335, 190)
        Me.MyButton6.TabIndex = 42
        Me.MyButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButton6.UseVisualStyleBackColor = True
        '
        'MyButton5
        '
        Me.MyButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MyButton5.BackColor = System.Drawing.Color.Transparent
        Me.MyButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.MyButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButton5.ImageHover = Nothing
        Me.MyButton5.ImageNormal = Nothing
        Me.MyButton5.Location = New System.Drawing.Point(44, 483)
        Me.MyButton5.Name = "MyButton5"
        Me.MyButton5.Size = New System.Drawing.Size(87, 30)
        Me.MyButton5.TabIndex = 15
        Me.MyButton5.Text = "Version"
        Me.MyButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.MyButton5.UseVisualStyleBackColor = True
        '
        'btnWOWPatch
        '
        Me.btnWOWPatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWOWPatch.BackColor = System.Drawing.Color.Transparent
        Me.btnWOWPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWOWPatch.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWOWPatch.ForeColor = System.Drawing.Color.White
        Me.btnWOWPatch.Image = Global.WEMULauncher.My.Resources.Resources.icon_combo_selector2
        Me.btnWOWPatch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWOWPatch.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_combo_selector
        Me.btnWOWPatch.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_combo_selector
        Me.btnWOWPatch.Location = New System.Drawing.Point(44, 519)
        Me.btnWOWPatch.Name = "btnWOWPatch"
        Me.btnWOWPatch.Size = New System.Drawing.Size(271, 38)
        Me.btnWOWPatch.TabIndex = 14
        Me.btnWOWPatch.Text = "The Burning Crusade"
        Me.btnWOWPatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWOWPatch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnWOWPatch.UseVisualStyleBackColor = True
        '
        'btnWOWVersion
        '
        Me.btnWOWVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWOWVersion.BackColor = System.Drawing.Color.Transparent
        Me.btnWOWVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWOWVersion.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWOWVersion.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnWOWVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWOWVersion.ImageHover = Nothing
        Me.btnWOWVersion.ImageNormal = Nothing
        Me.btnWOWVersion.Location = New System.Drawing.Point(321, 623)
        Me.btnWOWVersion.Name = "btnWOWVersion"
        Me.btnWOWVersion.Size = New System.Drawing.Size(224, 30)
        Me.btnWOWVersion.TabIndex = 13
        Me.btnWOWVersion.Text = "Ver 2.4.3, 23 July 2020"
        Me.btnWOWVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWOWVersion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnWOWVersion.UseVisualStyleBackColor = True
        '
        'MyButtonRun
        '
        Me.MyButtonRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MyButtonRun.BackColor = System.Drawing.Color.DimGray
        Me.MyButtonRun.FlatAppearance.BorderSize = 0
        Me.MyButtonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonRun.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonRun.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MyButtonRun.Location = New System.Drawing.Point(44, 563)
        Me.MyButtonRun.Name = "MyButtonRun"
        Me.MyButtonRun.Size = New System.Drawing.Size(271, 90)
        Me.MyButtonRun.TabIndex = 11
        Me.MyButtonRun.Text = "Launch"
        Me.MyButtonRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MyButtonRun.UseVisualStyleBackColor = False
        '
        'MyButtonWar3
        '
        Me.MyButtonWar3.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonWar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonWar3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonWar3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonWar3.Image = Global.WEMULauncher.My.Resources.Resources.icon_game_war3_small
        Me.MyButtonWar3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonWar3.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_game_war3_medium
        Me.MyButtonWar3.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_game_war3_small
        Me.MyButtonWar3.Location = New System.Drawing.Point(5, 347)
        Me.MyButtonWar3.Name = "MyButtonWar3"
        Me.MyButtonWar3.Size = New System.Drawing.Size(210, 60)
        Me.MyButtonWar3.TabIndex = 17
        Me.MyButtonWar3.Text = "    WarCraft III"
        Me.MyButtonWar3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonWar3.UseVisualStyleBackColor = True
        '
        'MyButtonOverwatch
        '
        Me.MyButtonOverwatch.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonOverwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonOverwatch.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonOverwatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonOverwatch.Image = Global.WEMULauncher.My.Resources.Resources.icon_game_overwatch_small
        Me.MyButtonOverwatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonOverwatch.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_game_overwatch_medium
        Me.MyButtonOverwatch.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_game_overwatch_small
        Me.MyButtonOverwatch.Location = New System.Drawing.Point(5, 288)
        Me.MyButtonOverwatch.Name = "MyButtonOverwatch"
        Me.MyButtonOverwatch.Size = New System.Drawing.Size(210, 60)
        Me.MyButtonOverwatch.TabIndex = 16
        Me.MyButtonOverwatch.Text = "    Overwatch"
        Me.MyButtonOverwatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonOverwatch.UseVisualStyleBackColor = True
        '
        'MyButtonHeroes
        '
        Me.MyButtonHeroes.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonHeroes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHeroes.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonHeroes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonHeroes.Image = Global.WEMULauncher.My.Resources.Resources.icon_game_heroes_small
        Me.MyButtonHeroes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHeroes.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_game_heroes_medium
        Me.MyButtonHeroes.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_game_heroes_small
        Me.MyButtonHeroes.Location = New System.Drawing.Point(5, 231)
        Me.MyButtonHeroes.Name = "MyButtonHeroes"
        Me.MyButtonHeroes.Size = New System.Drawing.Size(210, 60)
        Me.MyButtonHeroes.TabIndex = 15
        Me.MyButtonHeroes.Text = "    Heroes of the Storm"
        Me.MyButtonHeroes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHeroes.UseVisualStyleBackColor = True
        '
        'MyButtonHS
        '
        Me.MyButtonHS.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHS.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonHS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonHS.Image = Global.WEMULauncher.My.Resources.Resources.icon_game_hs_small
        Me.MyButtonHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHS.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_game_hs_medium
        Me.MyButtonHS.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_game_hs_small
        Me.MyButtonHS.Location = New System.Drawing.Point(5, 175)
        Me.MyButtonHS.Name = "MyButtonHS"
        Me.MyButtonHS.Size = New System.Drawing.Size(210, 60)
        Me.MyButtonHS.TabIndex = 14
        Me.MyButtonHS.Text = "    Hearthstone"
        Me.MyButtonHS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHS.UseVisualStyleBackColor = True
        '
        'MyButtonSC2
        '
        Me.MyButtonSC2.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonSC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonSC2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonSC2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonSC2.Image = Global.WEMULauncher.My.Resources.Resources.icon_game_sc2_small
        Me.MyButtonSC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonSC2.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_game_sc2_medium
        Me.MyButtonSC2.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_game_sc2_small
        Me.MyButtonSC2.Location = New System.Drawing.Point(5, 119)
        Me.MyButtonSC2.Name = "MyButtonSC2"
        Me.MyButtonSC2.Size = New System.Drawing.Size(210, 60)
        Me.MyButtonSC2.TabIndex = 13
        Me.MyButtonSC2.Text = "    StarCraft II"
        Me.MyButtonSC2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonSC2.UseVisualStyleBackColor = True
        '
        'MyButtonD3
        '
        Me.MyButtonD3.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonD3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonD3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonD3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonD3.Image = Global.WEMULauncher.My.Resources.Resources.icon_game_d3_small
        Me.MyButtonD3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonD3.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_game_d3_medium
        Me.MyButtonD3.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_game_d3_small
        Me.MyButtonD3.Location = New System.Drawing.Point(5, 62)
        Me.MyButtonD3.Name = "MyButtonD3"
        Me.MyButtonD3.Size = New System.Drawing.Size(210, 60)
        Me.MyButtonD3.TabIndex = 9
        Me.MyButtonD3.Text = "    Diablo III"
        Me.MyButtonD3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonD3.UseVisualStyleBackColor = True
        '
        'MyButtonSlide
        '
        Me.MyButtonSlide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MyButtonSlide.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonSlide.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonSlide.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonSlide.Image = Global.WEMULauncher.My.Resources.Resources.expand_normal
        Me.MyButtonSlide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonSlide.ImageHover = Global.WEMULauncher.My.Resources.Resources.collapse_normal
        Me.MyButtonSlide.ImageNormal = Global.WEMULauncher.My.Resources.Resources.expand_normal
        Me.MyButtonSlide.Location = New System.Drawing.Point(5, 622)
        Me.MyButtonSlide.Name = "MyButtonSlide"
        Me.MyButtonSlide.Size = New System.Drawing.Size(43, 41)
        Me.MyButtonSlide.TabIndex = 8
        Me.MyButtonSlide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonSlide.UseVisualStyleBackColor = True
        '
        'MyButtonWOW
        '
        Me.MyButtonWOW.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonWOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonWOW.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButtonWOW.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonWOW.Image = Global.WEMULauncher.My.Resources.Resources.icon_game_wow_small
        Me.MyButtonWOW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonWOW.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_game_wow_medium
        Me.MyButtonWOW.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_game_wow_small
        Me.MyButtonWOW.Location = New System.Drawing.Point(5, 5)
        Me.MyButtonWOW.Name = "MyButtonWOW"
        Me.MyButtonWOW.Size = New System.Drawing.Size(210, 60)
        Me.MyButtonWOW.TabIndex = 7
        Me.MyButtonWOW.Text = "    World of warcraft"
        Me.MyButtonWOW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonWOW.UseVisualStyleBackColor = True
        '
        'MyButton8
        '
        Me.MyButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyButton8.BackColor = System.Drawing.Color.Transparent
        Me.MyButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton8.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton8.ForeColor = System.Drawing.Color.Transparent
        Me.MyButton8.Image = Global.WEMULauncher.My.Resources.Resources.friendButton_normal
        Me.MyButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButton8.ImageHover = Global.WEMULauncher.My.Resources.Resources.friendButton_hovered
        Me.MyButton8.ImageNormal = Global.WEMULauncher.My.Resources.Resources.friendButton_normal
        Me.MyButton8.Location = New System.Drawing.Point(938, 36)
        Me.MyButton8.Name = "MyButton8"
        Me.MyButton8.Size = New System.Drawing.Size(37, 39)
        Me.MyButton8.TabIndex = 47
        Me.MyButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButton8.UseVisualStyleBackColor = True
        '
        'MyButtonHover9
        '
        Me.MyButtonHover9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyButtonHover9.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonHover9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHover9.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButtonHover9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.MyButtonHover9.Image = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.MyButtonHover9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHover9.ImageHover = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.MyButtonHover9.ImageNormal = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Me.MyButtonHover9.Location = New System.Drawing.Point(972, 36)
        Me.MyButtonHover9.Name = "MyButtonHover9"
        Me.MyButtonHover9.Size = New System.Drawing.Size(104, 39)
        Me.MyButtonHover9.TabIndex = 46
        Me.MyButtonHover9.Text = "wowemu"
        Me.MyButtonHover9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHover9.UseVisualStyleBackColor = True
        '
        'MyButtonHover8
        '
        Me.MyButtonHover8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyButtonHover8.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonHover8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHover8.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButtonHover8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonHover8.Image = Global.WEMULauncher.My.Resources.Resources.arrow_down
        Me.MyButtonHover8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHover8.ImageHover = Global.WEMULauncher.My.Resources.Resources.arrow_down
        Me.MyButtonHover8.ImageNormal = Global.WEMULauncher.My.Resources.Resources.arrow_down
        Me.MyButtonHover8.Location = New System.Drawing.Point(1073, 36)
        Me.MyButtonHover8.Name = "MyButtonHover8"
        Me.MyButtonHover8.Size = New System.Drawing.Size(33, 39)
        Me.MyButtonHover8.TabIndex = 45
        Me.MyButtonHover8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHover8.UseVisualStyleBackColor = True
        '
        'MyButtonHover7
        '
        Me.MyButtonHover7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyButtonHover7.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonHover7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHover7.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButtonHover7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonHover7.Image = Global.WEMULauncher.My.Resources.Resources.bell_icon
        Me.MyButtonHover7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHover7.ImageHover = Global.WEMULauncher.My.Resources.Resources.bell_icon
        Me.MyButtonHover7.ImageNormal = Global.WEMULauncher.My.Resources.Resources.bell_icon
        Me.MyButtonHover7.Location = New System.Drawing.Point(1102, 36)
        Me.MyButtonHover7.Name = "MyButtonHover7"
        Me.MyButtonHover7.Size = New System.Drawing.Size(33, 39)
        Me.MyButtonHover7.TabIndex = 44
        Me.MyButtonHover7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHover7.UseVisualStyleBackColor = True
        '
        'MyButtonHover6
        '
        Me.MyButtonHover6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyButtonHover6.BackColor = System.Drawing.Color.Transparent
        Me.MyButtonHover6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonHover6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MyButtonHover6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyButtonHover6.Image = Global.WEMULauncher.My.Resources.Resources.menu_friends_normal
        Me.MyButtonHover6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonHover6.ImageHover = Global.WEMULauncher.My.Resources.Resources.menu_friends_normal
        Me.MyButtonHover6.ImageNormal = Global.WEMULauncher.My.Resources.Resources.menu_friends_normal
        Me.MyButtonHover6.Location = New System.Drawing.Point(1133, 36)
        Me.MyButtonHover6.Name = "MyButtonHover6"
        Me.MyButtonHover6.Size = New System.Drawing.Size(56, 39)
        Me.MyButtonHover6.TabIndex = 43
        Me.MyButtonHover6.Text = "0"
        Me.MyButtonHover6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonHover6.UseVisualStyleBackColor = True
        '
        'MyButton7
        '
        Me.MyButton7.BackColor = System.Drawing.Color.Transparent
        Me.MyButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton7.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.MyButton7.Image = Global.WEMULauncher.My.Resources.Resources.arrow_down_blue
        Me.MyButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButton7.ImageHover = Global.WEMULauncher.My.Resources.Resources.arrow_down_blue
        Me.MyButton7.ImageNormal = Global.WEMULauncher.My.Resources.Resources.arrow_down_blue
        Me.MyButton7.Location = New System.Drawing.Point(98, 20)
        Me.MyButton7.Name = "MyButton7"
        Me.MyButton7.Size = New System.Drawing.Size(20, 61)
        Me.MyButton7.TabIndex = 42
        Me.MyButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButton7.UseVisualStyleBackColor = True
        '
        'CtrlTransClose
        '
        Me.CtrlTransClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTransClose.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransClose.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransClose.ForeColor = System.Drawing.Color.Transparent
        Me.CtrlTransClose.Image = Global.WEMULauncher.My.Resources.Resources.btn_win_close_normal
        Me.CtrlTransClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransClose.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_win_close_hover
        Me.CtrlTransClose.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_win_close_normal
        Me.CtrlTransClose.Location = New System.Drawing.Point(1164, 4)
        Me.CtrlTransClose.Name = "CtrlTransClose"
        Me.CtrlTransClose.Size = New System.Drawing.Size(25, 28)
        Me.CtrlTransClose.TabIndex = 41
        Me.CtrlTransClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransClose.UseVisualStyleBackColor = True
        '
        'CtrlTransMaxmize
        '
        Me.CtrlTransMaxmize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTransMaxmize.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransMaxmize.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransMaxmize.ForeColor = System.Drawing.Color.Transparent
        Me.CtrlTransMaxmize.Image = Global.WEMULauncher.My.Resources.Resources.btn_win_maximize_normal
        Me.CtrlTransMaxmize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransMaxmize.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_win_maximize_hover
        Me.CtrlTransMaxmize.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_win_maximize_normal
        Me.CtrlTransMaxmize.Location = New System.Drawing.Point(1133, 4)
        Me.CtrlTransMaxmize.Name = "CtrlTransMaxmize"
        Me.CtrlTransMaxmize.Size = New System.Drawing.Size(25, 28)
        Me.CtrlTransMaxmize.TabIndex = 40
        Me.CtrlTransMaxmize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransMaxmize.UseVisualStyleBackColor = True
        '
        'CtrlTransMinimize
        '
        Me.CtrlTransMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTransMinimize.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransMinimize.Font = New System.Drawing.Font("Century Gothic", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransMinimize.ForeColor = System.Drawing.Color.Transparent
        Me.CtrlTransMinimize.Image = Global.WEMULauncher.My.Resources.Resources.btn_win_minimize_normal
        Me.CtrlTransMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransMinimize.ImageHover = Global.WEMULauncher.My.Resources.Resources.btn_win_minimize_hover
        Me.CtrlTransMinimize.ImageNormal = Global.WEMULauncher.My.Resources.Resources.btn_win_minimize_normal
        Me.CtrlTransMinimize.Location = New System.Drawing.Point(1102, 4)
        Me.CtrlTransMinimize.Name = "CtrlTransMinimize"
        Me.CtrlTransMinimize.Size = New System.Drawing.Size(25, 28)
        Me.CtrlTransMinimize.TabIndex = 39
        Me.CtrlTransMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransMinimize.UseVisualStyleBackColor = True
        '
        'CtrlTransNews
        '
        Me.CtrlTransNews.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransNews.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransNews.FontHover = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CtrlTransNews.FontNormal = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.CtrlTransNews.ForeColor = System.Drawing.Color.Transparent
        Me.CtrlTransNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransNews.ImageHover = Nothing
        Me.CtrlTransNews.ImageNormal = Nothing
        Me.CtrlTransNews.Location = New System.Drawing.Point(509, 32)
        Me.CtrlTransNews.Name = "CtrlTransNews"
        Me.CtrlTransNews.Size = New System.Drawing.Size(98, 50)
        Me.CtrlTransNews.TabIndex = 38
        Me.CtrlTransNews.Text = "News"
        Me.CtrlTransNews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransNews.UseVisualStyleBackColor = True
        '
        'CtrlTransShop
        '
        Me.CtrlTransShop.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransShop.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransShop.FontHover = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CtrlTransShop.FontNormal = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.CtrlTransShop.ForeColor = System.Drawing.Color.Transparent
        Me.CtrlTransShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransShop.ImageHover = Nothing
        Me.CtrlTransShop.ImageNormal = Nothing
        Me.CtrlTransShop.Location = New System.Drawing.Point(405, 32)
        Me.CtrlTransShop.Name = "CtrlTransShop"
        Me.CtrlTransShop.Size = New System.Drawing.Size(98, 50)
        Me.CtrlTransShop.TabIndex = 37
        Me.CtrlTransShop.Text = "Shop"
        Me.CtrlTransShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransShop.UseVisualStyleBackColor = True
        '
        'CtrlTransFriend
        '
        Me.CtrlTransFriend.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransFriend.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransFriend.FontHover = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CtrlTransFriend.FontNormal = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.CtrlTransFriend.ForeColor = System.Drawing.Color.Transparent
        Me.CtrlTransFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransFriend.ImageHover = Nothing
        Me.CtrlTransFriend.ImageNormal = Nothing
        Me.CtrlTransFriend.Location = New System.Drawing.Point(301, 32)
        Me.CtrlTransFriend.Name = "CtrlTransFriend"
        Me.CtrlTransFriend.Size = New System.Drawing.Size(98, 50)
        Me.CtrlTransFriend.TabIndex = 36
        Me.CtrlTransFriend.Text = "Social"
        Me.CtrlTransFriend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CtrlTransFriend.UseVisualStyleBackColor = True
        '
        'CtrlTransMain
        '
        Me.CtrlTransMain.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CtrlTransMain.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtrlTransMain.FontHover = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CtrlTransMain.FontNormal = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.CtrlTransMain.ForeColor = System.Drawing.Color.Transparent
        Me.CtrlTransMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CtrlTransMain.ImageHover = Nothing
        Me.CtrlTransMain.ImageNormal = Nothing
        Me.CtrlTransMain.Location = New System.Drawing.Point(197, 31)
        Me.CtrlTransMain.Name = "CtrlTransMain"
        Me.CtrlTransMain.Size = New System.Drawing.Size(98, 50)
        Me.CtrlTransMain.TabIndex = 35
        Me.CtrlTransMain.Text = "Games"
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
        Me.MyButtonLogo.Location = New System.Drawing.Point(10, 20)
        Me.MyButtonLogo.Name = "MyButtonLogo"
        Me.MyButtonLogo.Size = New System.Drawing.Size(89, 61)
        Me.MyButtonLogo.TabIndex = 34
        Me.MyButtonLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonLogo.UseVisualStyleBackColor = True
        '
        'CtrlTransPictture7
        '
        Me.CtrlTransPictture7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlTransPictture7.BackColor = System.Drawing.Color.Transparent
        Me.CtrlTransPictture7.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.border_topbar_inactive
        Me.CtrlTransPictture7.Image = Global.WEMULauncher.My.Resources.Resources.top1
        Me.CtrlTransPictture7.Location = New System.Drawing.Point(90, 1)
        Me.CtrlTransPictture7.Name = "CtrlTransPictture7"
        Me.CtrlTransPictture7.Opacity = 1
        Me.CtrlTransPictture7.Size = New System.Drawing.Size(1001, 13)
        Me.CtrlTransPictture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CtrlTransPictture7.TabIndex = 33
        Me.CtrlTransPictture7.TabStop = False
        '
        'MyButtonBottomNotice
        '
        Me.MyButtonBottomNotice.BackColor = System.Drawing.Color.Sienna
        Me.MyButtonBottomNotice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyButtonBottomNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButtonBottomNotice.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButtonBottomNotice.ForeColor = System.Drawing.Color.Gainsboro
        Me.MyButtonBottomNotice.Image = Global.WEMULauncher.My.Resources.Resources.icon_warning_normal
        Me.MyButtonBottomNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyButtonBottomNotice.ImageHover = Global.WEMULauncher.My.Resources.Resources.icon_warning_hover
        Me.MyButtonBottomNotice.ImageNormal = Global.WEMULauncher.My.Resources.Resources.icon_warning_normal
        Me.MyButtonBottomNotice.Location = New System.Drawing.Point(0, 0)
        Me.MyButtonBottomNotice.Name = "MyButtonBottomNotice"
        Me.MyButtonBottomNotice.Size = New System.Drawing.Size(1200, 40)
        Me.MyButtonBottomNotice.TabIndex = 1
        Me.MyButtonBottomNotice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyButtonBottomNotice.UseVisualStyleBackColor = False
        '
        'MyControlEllipse1
        '
        Me.MyControlEllipse1.BoardThickness = 1
        Me.MyControlEllipse1.BorderColor = System.Drawing.Color.Black
        Me.MyControlEllipse1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MyControlEllipse1.Name = "MyControlEllipse1"
        Me.MyControlEllipse1.R = 40
        Me.MyControlEllipse1.Size = New System.Drawing.Size(61, 4)
        '
        'MainForm2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.background_wow2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.PanelBottom)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "暴雪战网"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContent.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanelStatus.ResumeLayout(False)
        Me.PanelMainSlide.ResumeLayout(False)
        Me.PanelSlide.ResumeLayout(False)
        Me.PanelSlideContent.ResumeLayout(False)
        Me.SlidePanelNews.ResumeLayout(False)
        Me.PanelBottom.ResumeLayout(False)
        CType(Me.pRAM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrlTransPictture7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents TimerExpand As System.Windows.Forms.Timer
    Friend WithEvents PanelContent As Panel
    Friend WithEvents MyButtonWOW As myButtonHover
    Friend WithEvents MyButtonSlide As myButton
    Friend WithEvents MyButtonD3 As myButtonHover
    Friend WithEvents ImageListBG As ImageList
    Friend WithEvents MyButtonRun As myButtonEllipse
    Friend WithEvents MyControlEllipse1 As myControlEllipse
    Friend WithEvents pnlSelection As Panel
    Friend WithEvents btnWOWVersion As myButton
    Friend WithEvents btnWOWPatch As myButtonHover
    Friend WithEvents MyButton5 As myButton
    Friend WithEvents CtrlTransClose As myButton
    Friend WithEvents CtrlTransMaxmize As myButton
    Friend WithEvents CtrlTransMinimize As myButton
    Friend WithEvents CtrlTransNews As myButtonFontChange
    Friend WithEvents CtrlTransShop As myButtonFontChange
    Friend WithEvents CtrlTransFriend As myButtonFontChange
    Friend WithEvents CtrlTransMain As myButtonFontChange
    Friend WithEvents MyButtonLogo As myButton
    Friend WithEvents CtrlTransPictture7 As CtrlTransPicture
    Friend WithEvents MyButton6 As myButton
    Friend WithEvents MyButtonHover1 As myButtonHover
    Friend WithEvents MyButtonHover2 As myButtonHover
    Friend WithEvents MyButtonHover3 As myButtonHover
    Friend WithEvents MyButtonSC2 As myButtonHover
    Friend WithEvents PanelMainSlide As Panel
    Friend WithEvents PanelSlide As Panel
    Friend WithEvents PanelButtonLegal As myButtonHover
    Friend WithEvents btnSlideContent As myButtonHover
    Friend WithEvents btnSlideHeader As myButtonHover
    Friend WithEvents btnSlideRight As myButton
    Friend WithEvents btnSlideLeft As myButton
    Friend WithEvents PanelSlideContent As Panel
    Friend WithEvents SlidePanelNews As Panel
    Friend WithEvents MyButtonTrans1 As myButtonTrans
    Friend WithEvents btnSlideNews As myButtonHover
    Friend WithEvents MyButton7 As myButton
    Friend WithEvents MyButtonHover6 As myButtonHover
    Friend WithEvents MyButtonHover7 As myButtonHover
    Friend WithEvents MyButtonHover9 As myButtonHover
    Friend WithEvents MyButtonHover8 As myButtonHover
    Friend WithEvents MyButton8 As myButton
    Friend WithEvents MyButtonHS As myButtonHover
    Friend WithEvents MyButtonHeroes As myButtonHover
    Friend WithEvents MyButtonWar3 As myButtonHover
    Friend WithEvents MyButtonOverwatch As myButtonHover
    Friend WithEvents TimerSlide As System.Windows.Forms.Timer
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents MyButtonBottomNotice As myButtonTrans
    Friend WithEvents TimerNotice As System.Windows.Forms.Timer
    Friend WithEvents btnStatusWorld As myButton
    Friend WithEvents btnStatusAuth As myButton
    Friend WithEvents btnStatusWeb As myButton
    Friend WithEvents btnStatusDB As myButton
    Friend WithEvents FlowLayoutPanelStatus As FlowLayoutPanel
    Friend WithEvents WaitServer As System.Windows.Forms.Timer
    Friend WithEvents TimerDBandWEBProcess As System.Windows.Forms.Timer
    Friend WithEvents TimerAuthAndWorld As Timer
    Friend WithEvents pRAM As PerformanceCounter
    Private WithEvents pCPU As PerformanceCounter
    Friend WithEvents TimerPerformance As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents prgRAM As ProgressBar
    Friend WithEvents prgCPU As ProgressBar
    Friend WithEvents lblRAM As Label
    Friend WithEvents lblCPU As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
