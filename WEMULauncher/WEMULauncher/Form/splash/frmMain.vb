Imports System.Threading

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        '类干涉方式
        Dim sp As New splash
        sp.Show()
        sp.Status = "状态:载入初始化模块..."
        System.Threading.Thread.Sleep(1000)

        sp.Status = "状态:载入管理模块..."
        System.Threading.Thread.Sleep(1000)

        sp.Status = "状态:载入打印模块..."
        System.Threading.Thread.Sleep(1000)

        sp.Status = "状态:载入插件模块..."
        System.Threading.Thread.Sleep(1000)

        sp.Status = "状态:连接数据库..."
        System.Threading.Thread.Sleep(1000)

        sp.Close()


        '自己内部函数方式


        'splashShow()

        'System.Threading.Thread.Sleep(1300)
        'MySplashForm.StatusInfo = "状态:载入初始化模块..."
        'System.Threading.Thread.Sleep(1000)
        'MySplashForm.Invoke(New MethodInvoker(AddressOf MySplashForm.ChangeStatusText))


        'MySplashForm.StatusInfo = "状态:载入管理模块..."
        'System.Threading.Thread.Sleep(1000)
        'MySplashForm.Invoke(New MethodInvoker(AddressOf MySplashForm.ChangeStatusText))

        'MySplashForm.StatusInfo = "状态:载入打印模块..."
        'System.Threading.Thread.Sleep(1000)
        'MySplashForm.Invoke(New MethodInvoker(AddressOf MySplashForm.ChangeStatusText))

        'MySplashForm.StatusInfo = "状态:载入插件模块..."
        'System.Threading.Thread.Sleep(1000)
        'MySplashForm.Invoke(New MethodInvoker(AddressOf MySplashForm.ChangeStatusText))

        'MySplashForm.StatusInfo = "状态:连接数据库..."
        'System.Threading.Thread.Sleep(1000)
        'MySplashForm.Invoke(New MethodInvoker(AddressOf MySplashForm.ChangeStatusText))

        'splashClose()
    End Sub





    'Private MySplashForm As frmSplash = Nothing

    'Private MySplashThread As Thread = Nothing

    'Private Sub ShowThread()
    '    MySplashForm = New frmSplash()
    '    Application.Run(MySplashForm)
    'End Sub

    'Private Sub splashShow()
    '    If MySplashThread IsNot Nothing Then Return
    '    MySplashThread = New Thread(New ThreadStart(AddressOf ShowThread))
    '    MySplashThread.IsBackground = True
    '    MySplashThread.SetApartmentState(ApartmentState.STA)
    '    MySplashThread.Start()
    'End Sub

    'Private Sub splashClose()
    '    If MySplashThread Is Nothing Then Return
    '    If MySplashForm Is Nothing Then Return
    '    Try
    '        MySplashForm.Invoke(New MethodInvoker(AddressOf MySplashForm.Close))
    '    Catch __unusedException1__ As Exception
    '    End Try

    '    MySplashThread = Nothing
    '    MySplashForm = Nothing
    'End Sub


End Class