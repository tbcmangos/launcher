Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class MainForm2
    Private CRASH_RESTART As Boolean = False
#Region "Drag window"
    Private mPoint As Point = New Point()
    Private bMouseDown As Boolean = False
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader.MouseDown
        bMouseDown = True
        mPoint.X = e.X
        mPoint.Y = e.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader.MouseMove
        If e.Button = MouseButtons.Left And bMouseDown Then
            Dim myPosittion As Point = Me.Location 'MousePosition
            myPosittion.Offset(-mPoint.X + e.X, -mPoint.Y + e.Y)
            Location = myPosittion
        End If
    End Sub

    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseUp
        bMouseDown = False
    End Sub
#End Region

#Region "slide"
    '221,46
    '68,46
    Dim CONST_WIDER As Integer = 210
    Dim CONST_NARROW As Integer = 50
    Dim CONST_STEP As Integer = 10

    Dim panelWidth As Integer
    Dim Hidden As Boolean

    'Protected Overrides Sub Finalize()
    '    MyBase.Finalize()

    '    panelWidth = PanelMenu.Width
    '    Hidden = False
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerExpand.Tick
        If Hidden Then
            PanelMenu.Width = PanelMenu.Width + CONST_STEP
            If PanelMenu.Width >= CONST_WIDER Then
                TimerExpand.Stop()
                Hidden = False
                'Me.Refresh()
            End If
        Else
            PanelMenu.Width = PanelMenu.Width - CONST_STEP
            If PanelMenu.Width <= CONST_NARROW Then
                TimerExpand.Stop()
                Hidden = True
                'Me.Refresh()
            End If
        End If
    End Sub



    Private Sub MyButtonSlide_Click(sender As Object, e As EventArgs) Handles MyButtonSlide.Click
        TimerExpand.Start()
    End Sub

    Sub MoveIndicator(sender As Button)
        pnlSelection.Height = sender.Height
        pnlSelection.Top = sender.Top
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButtonWOW.Click, MyButtonD3.Click, MyButtonSC2.Click, MyButtonHS.Click, MyButtonHeroes.Click, MyButtonOverwatch.Click, MyButtonWar3.Click
        Dim btn As Button = sender
        MoveIndicator(btn)
        ' MsgBox(sender.text)
        Select Case btn.Name
            Case "MyButton1"

            Case "MyButton2"


            Case Else

        End Select

    End Sub




    '

    Private Sub myFormSlide_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        '立即启动重绘
        Me.Invalidate()
    End Sub

    Private Sub CtrlTransMinimize_Click(sender As Object, e As EventArgs) Handles CtrlTransMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CtrlTransMaxmize_Click(sender As Object, e As EventArgs) Handles CtrlTransMaxmize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
        '立即启动重绘
        'Me.Invalidate()
    End Sub

    Private Sub CtrlTransClose_Click(sender As Object, e As EventArgs) Handles CtrlTransClose.Click
        Application.Exit()
    End Sub

    Private Sub PanelSlide_MouseHover(sender As Object, e As EventArgs) Handles PanelSlideContent.MouseHover, btnSlideLeft.MouseHover,
                                                                                btnSlideRight.MouseHover, btnSlideHeader.MouseHover, btnSlideContent.MouseHover
        ShowSlider(True)
    End Sub
    Private Sub PanelSlide_MouseLeave(sender As Object, e As EventArgs) Handles PanelContent.MouseHover '如果使用PanelSlideContent的leave事件，悬停在btnSlideLeft上的时候会闪烁
        ShowSlider(False)
    End Sub

    Private Sub ShowSlider(ByVal TrueShowFalseHide As Boolean)
        If TrueShowFalseHide Then
            btnSlideContent.Height = 60
            btnSlideLeft.Visible = True
            btnSlideRight.Visible = True
        Else
            btnSlideContent.Height = 2
            btnSlideLeft.Visible = False
            btnSlideRight.Visible = False
        End If

    End Sub

    Public CYCLE_COUNTER As Integer = 0
    Private Sub TimerSlide_Tick(sender As Object, e As EventArgs) Handles TimerSlide.Tick
        SwitchSlideFurther()
    End Sub

    Private Sub SwitchSlideFurther()
        If CYCLE_COUNTER > 2 Then
            CYCLE_COUNTER = 0
        End If

        Select Case CYCLE_COUNTER
            Case 0 'bwl
                PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaBWL
                btnSlideContent.Text = "The ominous depths of Blackwing Lair are waiting for those brave enough to face its dangers. Gather your staunchest allies and prepare to undertake a treacherous journey into the heart of the mountain to reap the treasures within."
                btnSlideHeader.Text = "WoW Classic: Descend Into the Depths of Blackwing Lair"
                btnSlideNews.Text = "In the dark recesses of Blackrock Mountain’s peak, Nefarian, the eldest son of Deathwing, conducts some of his most awful experimentation, controlling mighty beings like puppets and combining the eggs of different dragonflights with horrific results. Should he prove successful, even darker pursuits rest on the horizon."
            Case 1 'warsong
                PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaWARSONG
                btnSlideContent.Text = "The gates into Arathi Basin are now open in this 15 vs.15 resource battle. Players will need to hone their team coordination to a keen edge in order to capture and hold five different bases throughout the map and accrue resources. Alliance will start close to the Stables at Trollbane Hall while Horde begin near the farm in the Defiler’s Den. The first team to collect 2000 resources wins."
                btnSlideHeader.Text = "Arathi Basin Now Available!"
                btnSlideNews.Text = "There are two reputations associated with this battleground: The Defilers (Horde), and the League of Arathor (Alliance). Gaining reputation with either faction will unlock additional rewards for purchase from common resources such as potions and bandages at Friendly to epic pieces of armor and weapons at Exalted."
            Case 2
                PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaBFA
                btnSlideContent.Text = "Steel yourself for Battleground combat!"
                btnSlideHeader.Text = "Weekly Bonus Event: Battlegrounds"
                btnSlideNews.Text = "All this week, heading to the Battlegrounds will net you some extra Honor along with bonus loot for completing this week’s quest. To enter the fray, open Group Finder and then select the Player vs. Player tab."
            Case Else
                PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaBWL
                btnSlideContent.Text = "The ominous depths of Blackwing Lair are waiting for those brave enough to face its dangers. Gather your staunchest allies and prepare to undertake a treacherous journey into the heart of the mountain to reap the treasures within."
                btnSlideHeader.Text = "WoW Classic: Descend Into the Depths of Blackwing Lair"
                btnSlideNews.Text = "In the dark recesses of Blackrock Mountain’s peak, Nefarian, the eldest son of Deathwing, conducts some of his most awful experimentation, controlling mighty beings like puppets and combining the eggs of different dragonflights with horrific results. Should he prove successful, even darker pursuits rest on the horizon."
        End Select

        CYCLE_COUNTER += 1
    End Sub
    Private Sub SwitchSlideBack()
        If CYCLE_COUNTER <= 0 Then
            CYCLE_COUNTER = 2
        End If

        Select Case CYCLE_COUNTER
            Case 0 'bwl
                PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaBWL
                btnSlideContent.Text = "The ominous depths of Blackwing Lair are waiting for those brave enough to face its dangers. Gather your staunchest allies and prepare to undertake a treacherous journey into the heart of the mountain to reap the treasures within."
                btnSlideHeader.Text = "WoW Classic: Descend Into the Depths of Blackwing Lair"
                btnSlideNews.Text = "In the dark recesses of Blackrock Mountain’s peak, Nefarian, the eldest son of Deathwing, conducts some of his most awful experimentation, controlling mighty beings like puppets and combining the eggs of different dragonflights with horrific results. Should he prove successful, even darker pursuits rest on the horizon."
            Case 1 'warsong
                PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaWARSONG
                btnSlideContent.Text = "The gates into Arathi Basin are now open in this 15 vs.15 resource battle. Players will need to hone their team coordination to a keen edge in order to capture and hold five different bases throughout the map and accrue resources. Alliance will start close to the Stables at Trollbane Hall while Horde begin near the farm in the Defiler’s Den. The first team to collect 2000 resources wins."
                btnSlideHeader.Text = "Arathi Basin Now Available!"
                btnSlideNews.Text = "There are two reputations associated with this battleground: The Defilers (Horde), and the League of Arathor (Alliance). Gaining reputation with either faction will unlock additional rewards for purchase from common resources such as potions and bandages at Friendly to epic pieces of armor and weapons at Exalted."
            Case 2
                PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaBFA
                btnSlideContent.Text = "Steel yourself for Battleground combat!"
                btnSlideHeader.Text = "Weekly Bonus Event: Battlegrounds"
                btnSlideNews.Text = "All this week, heading to the Battlegrounds will net you some extra Honor along with bonus loot for completing this week’s quest. To enter the fray, open Group Finder and then select the Player vs. Player tab."
            Case Else
                PanelSlide.BackgroundImage = Global.WEMULauncher.My.Resources.Resources.aaBWL
                btnSlideContent.Text = "The ominous depths of Blackwing Lair are waiting for those brave enough to face its dangers. Gather your staunchest allies and prepare to undertake a treacherous journey into the heart of the mountain to reap the treasures within."
                btnSlideHeader.Text = "WoW Classic: Descend Into the Depths of Blackwing Lair"
                btnSlideNews.Text = "In the dark recesses of Blackrock Mountain’s peak, Nefarian, the eldest son of Deathwing, conducts some of his most awful experimentation, controlling mighty beings like puppets and combining the eggs of different dragonflights with horrific results. Should he prove successful, even darker pursuits rest on the horizon."
        End Select
        CYCLE_COUNTER -= 1
    End Sub
#End Region

#Region "anti flash"
    '启用双缓冲
    Public Sub EnableDoubleBuffering()
        '   ' Set the value of the double-buffering style bits to true.
        '   Me.SetStyle(ControlStyles.DoubleBuffer _
        '               Or ControlStyles.UserPaint _
        '               Or ControlStyles.AllPaintingInWmPaint _
        '               Or ControlStyles.OptimizedDoubleBuffer _
        '               Or ControlStyles.ResizeRedraw _
        '               Or ControlStyles.SupportsTransparentBackColor,
        'True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.UserPaint, True)

        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.UpdateStyles()
    End Sub
    '禁掉清除背景消息     
    Const WM_SYSCOMMAND As Integer = &H112
    Const SC_CLOSE As Integer = &HF060
    Const SC_MINIMIZE As Integer = &HF020
    Const SC_MAXIMIZE As Integer = &HF030

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_SYSCOMMAND Then

            If m.WParam.ToInt32() = SC_MINIMIZE Then
                Me.SuspendLayout()
                Me.WindowState = FormWindowState.Minimized
                Me.ResumeLayout(False)
            End If

            If m.WParam.ToInt32() = SC_MAXIMIZE Then
                Me.SuspendLayout()
                Me.WindowState = FormWindowState.Maximized
                Me.ResumeLayout(False)
            End If

            If m.WParam.ToInt32() = SC_CLOSE Then
            End If
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub TimerNotice_Tick(sender As Object, e As EventArgs) Handles TimerNotice.Tick
        PanelBottom.Height = 0
        TimerNotice.Start()
        TimerNotice.Enabled = False
    End Sub



#End Region


    Private Sub frmSlide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'clear chart
        Chart1.Series("CPU").Points.Clear()
        Chart1.Series("RAM").Points.Clear()

        'disable run button
        MyButtonRun.Enabled = False
        MyButtonRun.BackColor = Color.DimGray

        EnableDoubleBuffering()

        panelWidth = PanelMenu.Width
        Hidden = False

        ShowSlider(False)

        '15 second timer for notice 提示信息只显示15秒
        MyButtonBottomNotice.Text = String.Format("[ac-web.com]This tool is just a simulator for entertainment purpose made by haeart. author：{0} , coolzoom , Discord：{1}", "talamortis", "https://discord.gg/Nyc3fTy")
        TimerNotice.Interval = 15000
        TimerNotice.Enabled = True
        TimerNotice.Start()

        '设置状态按钮
        'SetStatusVisible(False)
        SetStatusButton(btnStatusDB, False)
        SetStatusButton(btnStatusWeb, False)
        SetStatusButton(btnStatusAuth, False)
        SetStatusButton(btnStatusWorld, False)
        'form_alert.Show("Hello World", form_alert.AlertType.info)


        'Load config from conf
        If ReadConfig() Then
            If Regex.IsMatch(Directory.GetCurrentDirectory(), "[\u4e00-\u9fa5]") Then
                Dim num As Integer = CInt(MessageBox.Show("application path contains non-utf charactor, closing", "Start Crash", MessageBoxButtons.OK, MessageBoxIcon.Hand))
                Environment.[Exit](0)
            Else

                '关闭已有进程，初始化配置文件
                If Not ProcessMgr.Initialize() Then
                    Environment.[Exit](0)
                Else
                    'mysql server 启动
                    If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_ENABLE)) > 0 Then
                        If Not ProcessMgr.StartMysqlProcess() Then
                            Environment.[Exit](0)
                        End If
                    End If

                    'WEBSERVER启动
                    If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_ENABLE)) > 0 Then
                        If Not ProcessMgr.StartWebsiteProcess() Then
                            Environment.[Exit](0)
                        End If
                    End If
                    '
                    TimerDBandWEBProcess.Enabled = True
                    TimerDBandWEBProcess.Start()

                End If
            End If

            '更新文字
            btnWOWPatch.Text = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOW_PATCH)
            btnWOWVersion.Text = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOW_VERSION_STRING)
        End If


    End Sub

    Private Sub PanelHeader_DoubleClick(sender As Object, e As EventArgs) Handles PanelHeader.DoubleClick
        Dim boolVisible As Boolean = btnStatusDB.Visible
        boolVisible = Not boolVisible
        SetStatusVisible(boolVisible)

    End Sub
    Private Sub SetStatusVisible(ByVal boolVisible As Boolean)
        btnStatusDB.Visible = boolVisible
        btnStatusWeb.Visible = boolVisible
        btnStatusAuth.Visible = boolVisible
        btnStatusWorld.Visible = boolVisible
    End Sub
    Private Sub SetStatusButton(ByRef myButton As myButton, ByVal boolOn As Boolean)
        If boolOn Then
            myButton.Image = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
            myButton.ImageHover = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
            myButton.ImageNormal = Global.WEMULauncher.My.Resources.Resources.presence_icon_online_10x10
        Else
            myButton.Image = Global.WEMULauncher.My.Resources.Resources.presence_icon_appearoffline_10x10
            myButton.ImageHover = Global.WEMULauncher.My.Resources.Resources.presence_icon_appearoffline_10x10
            myButton.ImageNormal = Global.WEMULauncher.My.Resources.Resources.presence_icon_appearoffline_10x10
        End If
    End Sub

    Private Sub MyButtonEllipse1_Click(sender As Object, e As EventArgs) Handles MyButtonRun.Click
        RunAuthAndWorld()
    End Sub
    Private Sub RunAuthAndWorld()
        '暂时禁用守护
        TimerAuthAndWorld.Stop()
        TimerAuthAndWorld.Enabled = False

        '如果已经运行则不运行只启动wow.exe
        If Not ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_FILE_NAME)) And Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_ENABLE)) > 0 Then
            'delete logs because we neec to check the string
            If File.Exists(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHLOG_PATH)) Then
                File.Delete(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHLOG_PATH))
            End If
            ProcessMgr.StartAuthProcess("")
        End If
        If Not ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_FILE_NAME)) And Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_ENABLE)) > 0 Then
            'delete logs because we neec to check the string
            If File.Exists(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDLOG_PATH)) Then
                File.Delete(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDLOG_PATH))
            End If
            ProcessMgr.StartWorldProcess("")
        End If


        'disable run button
        MyButtonRun.Enabled = False
        MyButtonRun.BackColor = Color.DimGray
        If Not CRASH_RESTART Then
            MyButtonRun.Text = "Launching"
        Else
            MyButtonRun.Text = "Crash Restarting"
        End If

        '启动成功检测
        WaitServer.Enabled = True
        WaitServer.Start()
    End Sub

    Private Sub Heartbeat_Tick(sender As Object, e As EventArgs) Handles TimerDBandWEBProcess.Tick
        If CONFIG_FULL_DICT.Count > 0 Then
            Dim boolDB As Boolean = False
            Dim boolWeb As Boolean = False
            'check mysql server
            If ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_FILE_NAME)) And Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_ENABLE)) > 0 Then
                If ProcessMgr.PortIsInUse(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_PORT)) Then
                    '设置mysqlserver按钮亮灯
                    SetStatusButton(btnStatusDB, True)
                    boolDB = True
                Else
                    SetStatusButton(btnStatusDB, False)
                    boolDB = False
                End If
            Else
                SetStatusButton(btnStatusDB, False)
                boolDB = False
                'restart server
                If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_AUTORESTART)) > 0 Then
                    ProcessMgr.StartMysqlProcess()
                End If
            End If

            'check web server
            If ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_FILE_NAME)) And Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_ENABLE)) > 0 Then
                If ProcessMgr.PortIsInUse(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PORT)) Then
                    '设置authserver按钮亮灯
                    SetStatusButton(btnStatusWeb, True)
                    boolWeb = True
                Else
                    SetStatusButton(btnStatusWeb, False)
                    boolWeb = False
                End If
            Else
                SetStatusButton(btnStatusWeb, False)
                boolWeb = False
                'restart server
                If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_AUTORESTART)) > 0 Then
                    ProcessMgr.StartWebsiteProcess()
                End If
            End If

            'if both process is running 
            If boolDB And boolWeb Then
                'enable run button
                MyButtonRun.Enabled = True
                MyButtonRun.BackColor = Color.DeepSkyBlue
            Else
                'disable run button
                MyButtonRun.Enabled = False
                MyButtonRun.BackColor = Color.DimGray
            End If

        End If
    End Sub

    Private Sub WaitServer_Tick(sender As Object, e As EventArgs) Handles WaitServer.Tick
        Dim OKToStartWOW As Boolean = True
        'check auth server
        If ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_FILE_NAME)) And Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_ENABLE)) > 0 Then
            If FileContainString(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHLOG_PATH), ".tmp0", CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTH_SUCCESS_STRING)) Then
                '设置authserver按钮亮灯
                SetStatusButton(btnStatusAuth, True)
            Else
                SetStatusButton(btnStatusAuth, False)
                OKToStartWOW = False
            End If
        Else
            SetStatusButton(btnStatusAuth, False)
            OKToStartWOW = False
        End If

        'check world server
        If ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_FILE_NAME)) And Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_ENABLE)) > 0 Then
            If FileContainString(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDLOG_PATH), ".tmp0", CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLD_SUCCESS_STRING)) Then
                '设置webserver按钮亮灯
                SetStatusButton(btnStatusWorld, True)
            Else
                SetStatusButton(btnStatusWorld, False)
                OKToStartWOW = False
            End If
        Else
            SetStatusButton(btnStatusWorld, False)
            OKToStartWOW = False
        End If


        If OKToStartWOW Then

            '停用启动检测计时
            WaitServer.Stop()
            WaitServer.Enabled = False

            '启用按钮让用户可以开多个wow.exe
            MyButtonRun.Enabled = True
            MyButtonRun.BackColor = Color.DeepSkyBlue
            MyButtonRun.Text = "Launch"

            '启动守护进程
            TimerAuthAndWorld.Enabled = True
            TimerAuthAndWorld.Start()

            '如果是崩溃重启的话，不需要重启wow.exe
            If Not CRASH_RESTART And Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOWEXE_ENABLE)) > 0 Then
                StartWoWProcess()

                '是否自动登录
                If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOW_AUTOLOGIN)) > 0 Then
                    '等待启动成功
                    Thread.Sleep(3000)

                    SendKeys.SendWait(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOW_USERNAME))
                    SendKeys.SendWait("+") '中文输入法的时候，点shift可以将内容输入,+代表shift
                    SendKeys.SendWait("{Tab}")
                    SendKeys.SendWait(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOW_PASSWORD))
                    SendKeys.SendWait("+") '中文输入法的时候，点shift可以将内容输入
                    SendKeys.SendWait("{enter}")
                End If
            End If

            '重置崩溃状态为0
            CRASH_RESTART = False
        Else
            'disable run button
            MyButtonRun.Enabled = False
            MyButtonRun.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub CloseProcesses()
        'close process
        If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_ENABLE)) > 0 Then
            ProcessMgr.ShutDownMysqlProcess()
        End If
        'ProcessMgr.CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_FILE_NAME)) 'mysqld.exe
        ProcessMgr.CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_FILE_NAME)) '"apache.exe"
        ProcessMgr.CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_FILE_NAME)) '"realmd.exe"
        ProcessMgr.CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_FILE_NAME)) '"mangosd.exe"
    End Sub

    Private Sub MainForm2_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        CloseProcesses()
    End Sub

    Private Sub TimerAuthAndWorld_Tick(sender As Object, e As EventArgs) Handles TimerAuthAndWorld.Tick
        '关闭 werfault.exe， werfault.exe是一个windows系统自带的错误处理程序。
        If ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WINDOWSERROR_FILE_NAME)) Then
            ProcessMgr.CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WINDOWSERROR_FILE_NAME))
        End If

        '运行中侦测只做简单检查，看是否存在进程，不做文件检查
        If ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_FILE_NAME)) And Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_ENABLE)) > 0 Then
            SetStatusButton(btnStatusAuth, True)
        Else
            SetStatusButton(btnStatusAuth, False)
            '设置崩溃状态为1
            CRASH_RESTART = 1
            '检测log并重启
            RunAuthAndWorld()
        End If

        '运行中侦测只做简单检查，看是否存在进程，不做文件检查
        If ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_FILE_NAME)) And
            Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_ENABLE)) > 0 And
            Not ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WINDOWSERROR_FILE_NAME)) Then
            SetStatusButton(btnStatusWorld, True)
        Else
            SetStatusButton(btnStatusWorld, False)

            '设置崩溃状态为1
            CRASH_RESTART = 1
            '检测log并重启
            RunAuthAndWorld()
        End If

    End Sub

    Private Sub MyButtonHover9_Click(sender As Object, e As EventArgs) Handles MyButtonHover9.Click
        'If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_ENABLE)) > 0 Then
        '    ProcessMgr.ShutDownMysqlProcess()
        'End If
    End Sub

#Region "性能指示"
    Private Sub TimerPerformance_Tick(sender As Object, e As EventArgs) Handles TimerPerformance.Tick
        'Dim cpup As PerformanceCounter = New PerformanceCounter("Processor", "% Processor Time", "_Total")

        Dim fcpu As Single = pCPU.NextValue
        Dim fram As Single = pRAM.NextValue
        prgCPU.Value = CInt(fcpu)
        prgRAM.Value = CInt(fram)
        lblCPU.Text = String.Format("{0:0.00}%", fcpu)
        lblRAM.Text = String.Format("{0:0.00}%", fram)
        Dim DT As DataVisualization.Charting.DataPoint = New DataVisualization.Charting.DataPoint With {.XValue = 1}
        If Chart1.Series("CPU").Points.Count > 10 Then
            Chart1.Series("CPU").Points.RemoveAt(0)
        End If
        If Chart1.Series("RAM").Points.Count > 10 Then
            Chart1.Series("RAM").Points.RemoveAt(0)
        End If
        Chart1.Series("CPU").Points.AddY(fcpu)
        Chart1.Series("RAM").Points.AddY(fram)
    End Sub

    Private Sub Chart1_MouseHover(sender As Object, e As EventArgs) Handles Chart1.MouseHover
        Chart1.Legends("Legend1").Enabled = True
    End Sub

    Private Sub Chart1_MouseLeave(sender As Object, e As EventArgs) Handles Chart1.MouseLeave
        Chart1.Legends("Legend1").Enabled = False
    End Sub
#End Region

End Class