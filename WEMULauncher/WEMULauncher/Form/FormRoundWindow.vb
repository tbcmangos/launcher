Public Class FormRoundWindow
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hwnd1 As Integer, ByVal hWnd2 As Integer, ByVal lpsz1 As String, ByVal lpsz2 As String) As Integer
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As VariantType) As Integer
    Private Declare Function GetDlgItem Lib "user32" (ByVal hDlg As Integer, ByVal nIDDlgItem As Integer) As Integer
    Private Const WM_SETTEXT = &HC
    Private Const BM_CLICK = &HF5

    Private Const BM_GETCHECK = &HF0      ' 取得复选框状态

    Private Const BM_SETCHECK = &HF1      '  设置复选框状态
    Private Const BST_UNCHECKED = &H0      '设置复选框为未选中状态
    Private Const BST_CHECKED = &H1           '设置复选框为选中状态

    Private Const WM_APPCOMMAND = &H319
    Private Const APPCOMMAND_VOLUME_MUTE = &H8
    Private Sub SimulateLogin()
        Dim mhwnd As Integer
        Dim hwndUser As Integer
        ' mhwnd = FindWindow("GxWindowClassD3d", vbNullString) '通过类名获取
        If mhwnd = 0 Then
            mhwnd = FindWindow(vbNullString, "World of Warcraft") '通过窗体名获取
        End If
        If mhwnd <> 0 Then
            hwndUser = FindWindowEx(mhwnd, 0&, "Button", vbNullString)
            MsgBox(hwndUser)
        End If



        '''音量控制
        'Dim hwnd0 As Long      ' 用于记录“音量控制”程序的句柄
        ''Shell "c:\windows\system32\sndvol32.exe"        '  启动“音量控制”程序

        'hwnd0 = FindWindow(vbNullString, "音量控制")
        'Dim hwnd1 As Long     '  用于记录“全部静音”复选框句柄

        'hwnd1 = FindWindowEx(hwnd0, 0&, "Button", "全部静音(&M)")   '  复选框的类名是"Button"
        'Dim state As Long       '  用于记录复选框状态

        'state = SendMessage(hwnd1, BM_GETCHECK, 0&, 0&)
        ''  如果复选框处于未选中状态，则返回0，选中状态返回1
        'If state = 0 Then
        '    SendMessage（Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000）

        '    '  如果系统没有静音，则使系统静音

        '    ' 注：如果再使用一次同样的代码则恢复系统声音

        '    'SendMessage（hwnd0, WM_CLOSE, 0, 0）     '关闭音量控制程序
        'End If
        ''API函数声明不同

        ''声明类型中的Long类型一律改为Interger

        ''窗体句柄不同

        '由Me.hwnd改成Me.Handle


        ''''QQ登录
        'Dim mhwnd As Long
        'mhwnd = FindWindow("#32770", vbNullString)
        'If mhwnd <> 0 Then
        '    Dim usernamehwnd As Long
        '    Dim passwordhwnd As Long
        '    Dim buttonhwnd As Long
        '    buttonhwnd = GetDlgItem(mhwnd, &H1) '&H1为按纽的id，用spy++获得，不同版本的qq，可能不尽相同，你最好还是自己查看一下以下
        '    usernamehwnd = GetDlgItem(mhwnd, &H8A)
        '    passwordhwnd = GetDlgItem(mhwnd, &HB4)
        '    If passwordhwnd And usernamehwnd Then
        '        '输入QQ号码
        '        SendMessage(usernamehwnd, WM_SETTEXT, 0&, "admin")
        '        '输入密码
        '        SendMessage(passwordhwnd, WM_SETTEXT, 0&, "admin")
        '        '点击登陆按钮
        '        SendMessage(buttonhwnd, BM_CLICK, 0&, 0&)
        '    End If
        'End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SimulateLogin()
    End Sub
End Class