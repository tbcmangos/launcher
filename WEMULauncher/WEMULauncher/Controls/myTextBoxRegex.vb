Imports System.Drawing.Drawing2D

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions

'<ToolboxBitmapAttribute(GetType(zzControlLib.myTextBoxRegex), "myCtrl.bmp"), DefaultEvent("TextChanged")>
<System.Drawing.ToolboxBitmap(GetType(TextBox))>
Public Class myTextBoxRegex

    Private ReadOnly lblwaterText As Label = New Label()

    Public Sub New()
        InitializeComponent()
        lblwaterText.BorderStyle = BorderStyle.None
        lblwaterText.Enabled = False
        lblwaterText.BackColor = Color.White
        lblwaterText.AutoSize = False
        lblwaterText.Top = 1
        lblwaterText.Left = 2
        lblwaterText.FlatStyle = FlatStyle.System
        Controls.Add(lblwaterText)
    End Sub

    Public Enum _RegexType
        Custom
        Number
        CNString
        Zip
        Email
        Phone
        zInteger
        NInteger
        Float
        ENChar
        NumChar
        NumLineChar
        Url
        QQ
        DCard
        IP
        DateTime
        zDate
        Year
        Month
        Day
        Time
        Password
        JobNum
        Account
        engineCoefficient
        environmentCoefficient
        indeterminacyCoefficient
    End Enum

    Private _controlType As _RegexType

    Private _controlTypeText As String = "默认"

    Private _isNULL As Boolean = True

    Private _isPass As Boolean = False

    <DefaultValue(_RegexType.Custom), Description("文本框类型")>
    Public Property ControlType As _RegexType
        Get
            Return _controlType
        End Get

        Set(ByVal value As _RegexType)
            _controlType = value
            Me.ShowDescription(value)
            MyBase.Invalidate()
        End Set
    End Property

    <DefaultValue("默认"), Description("控件验证描述")>
    Public ReadOnly Property ControlTypeText As String
        Get
            Return _controlTypeText
        End Get
    End Property

    <DefaultValue(GetType(Boolean), "True"), Description("内容是否可空")>
    Public Property IsNULL As Boolean
        Get
            Return _isNULL
        End Get

        Set(ByVal value As Boolean)
            _isNULL = value
            MyBase.Invalidate()
        End Set
    End Property

    <DefaultValue(GetType(Boolean), "False"), Description("填写的内容格式是否正确，只读")>
    Public ReadOnly Property IsPass As Boolean
        Get
            Return _isPass
        End Get
    End Property

    Private Sub Testing(ByVal value As _RegexType, ByVal text As String)
        If _isNULL AndAlso String.IsNullOrEmpty(text.Trim()) Then
            _isPass = True
            Return
        End If

        If Not _isNULL AndAlso String.IsNullOrEmpty(text) Then
            _isPass = False
            Return
        End If

        Select Case value
            Case _RegexType.Custom
                _isPass = True
            Case _RegexType.Account
                _isPass = Proving(text, "^[\u4e00-\u9fa5A-Za-z0-9-_]*$")
            Case _RegexType.Password
                _isPass = Proving(text, "^\w{6,18}$")
            Case _RegexType.JobNum
                _isPass = Proving(text, "^[A-Za-z0-9]{10,15}$")
            Case _RegexType.engineCoefficient
                _isPass = Proving(text, "^([1-2]{1})(\.\d+)|(0\.{1}[1-9]+)|(3(\.0)?)$")
            Case _RegexType.environmentCoefficient
                _isPass = Proving(text, "^(1{1})(\.[0-4]\d*)+|(0\.[5-9]\d*)+|(1\.5)?$")
            Case _RegexType.indeterminacyCoefficient
                _isPass = Proving(text, "^^(1{1})(\.[0-4]\d*)+|(0\.{1}[1-9]\d*)+|(1\.5)?$")
            Case _RegexType.Number
                _isPass = Proving(text, "^-?[0-9]+\.{0,1}[0-9]*$")
            Case _RegexType.CNString
                _isPass = Proving(text, "^[\u4e00-\u9fa5]*$")
            Case _RegexType.Zip
                _isPass = Proving(text, "^[1-9]\d{5}$")
            Case _RegexType.Email
                _isPass = Proving(text, "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
            Case _RegexType.Phone
                _isPass = Proving(text, "^1[2-8]{2}\d{8}$")
            Case _RegexType.NInteger
                _isPass = Proving(text, "^-?[1-9]\d*$")
            Case _RegexType.zInteger
                _isPass = Proving(text, "^-[1-9]\d*$")
            Case _RegexType.Float
                _isPass = Proving(text, "^(-?\d+)(\.\d+)?$")
            Case _RegexType.ENChar
                _isPass = Proving(text, "^[A-Za-z]+$")
            Case _RegexType.NumChar
                _isPass = Proving(text, "^[A-Za-z0-9]+$")
            Case _RegexType.NumLineChar
                _isPass = Proving(text, "^[A-Za-z0-9_]+$")
            Case _RegexType.Url
                _isPass = Proving(text, "^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")
            Case _RegexType.QQ
                _isPass = Proving(text, "^[1-9][0-9]{4,}$")
            Case _RegexType.DCard
                _isPass = Proving(text, "^((1[1-5])|(2[1-3])|(3[1-7])|(4[1-6])|(5[0-4])|(6[1-5])|71|(8[12])|91)\d{4}((19\d{2}(0[13-9]|1[012])(0[1-9]|[12]\d|30))|(19\d{2}(0[13578]|1[02])31)|(19\d{2}02(0[1-9]|1\d|2[0-8]))|(19([13579][26]|[2468][048]|0[48])0229))\d{3}(\d|X|x)?$")
            Case _RegexType.IP
                _isPass = Proving(text, "^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$")
            Case _RegexType.DateTime
                _isPass = Proving(text, "^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d$")
            Case _RegexType.zDate
                _isPass = Proving(text, "^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$")
            Case _RegexType.Year
                _isPass = Proving(text, "^[1-9]\d{3}$")
            Case _RegexType.Month
                _isPass = Proving(text, "^(0?[123456789]|1[012])$")
            Case _RegexType.Day
                _isPass = Proving(text, "^(0?[1-9]|[12]\d|3[01])$")
            Case _RegexType.Time
                _isPass = Proving(text, "^(20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d$")
            Case Else
        End Select
    End Sub

    Private Function Proving(ByVal str As String, ByVal regexStr As String) As Boolean
        Dim result As Boolean
        Dim regex As Regex
        Try
            regex = New Regex(regexStr)
        Catch
            Return False
        End Try

        Return __InlineAssignHelper(result, regex.IsMatch(str))
    End Function

    Private Sub ShowDescription(ByVal value As _RegexType)
        Select Case value
            Case _RegexType.Custom
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "默认")
            Case _RegexType.Account
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "中英文，数字，下划线和减号")
            Case _RegexType.Password
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "6-18位的数字、字母或下划线")
            Case _RegexType.JobNum
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "10-15位的数字或字母")
            Case _RegexType.engineCoefficient
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "取值0.1~3之间的小数")
            Case _RegexType.environmentCoefficient
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "取值0.5~1.5之间的小数")
            Case _RegexType.indeterminacyCoefficient
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "取值0.1~1.5之间的小数")
            Case _RegexType.Number
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "数字")
            Case _RegexType.CNString
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "汉字")
            Case _RegexType.Zip
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "邮政编码")
            Case _RegexType.Email
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "电子邮件")
            Case _RegexType.Phone
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "手机号")
            Case _RegexType.NInteger
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "整数")
            Case _RegexType.zInteger
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "负整数")
            Case _RegexType.Float
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "小数")
            Case _RegexType.ENChar
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "英文字符")
            Case _RegexType.NumChar
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "数字和英文字母")
            Case _RegexType.NumLineChar
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "数字、英文字母或下划线")
            Case _RegexType.Url
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "URL")
            Case _RegexType.QQ
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "QQ")
            Case _RegexType.DCard
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "身份证")
            Case _RegexType.IP
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "IP")
            Case _RegexType.DateTime
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "年-月-日 时:分:秒")
            Case _RegexType.zDate
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "年-月-日")
            Case _RegexType.Year
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "年份")
            Case _RegexType.Month
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "月份")
            Case _RegexType.Day
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "日期")
            Case _RegexType.Time
                Me._controlTypeText = __InlineAssignHelper(lblwaterText.Text, "时:分:秒")
        End Select
    End Sub

    <Category("扩展属性"), Description("显示的提示信息")>
    Public Property WaterText As String
        Get
            Return lblwaterText.Text
        End Get

        Set(ByVal value As String)
            lblwaterText.Text = value
        End Set
    End Property

    Public Overrides Property Text As String
        Set(ByVal value As String)
            lblwaterText.Visible = value = String.Empty
            MyBase.Text = value
        End Set

        Get
            Return MyBase.Text
        End Get
    End Property

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        lblwaterText.Visible = MyBase.Text = String.Empty
        Testing(Me.ControlType, Me.Text)
        MyBase.OnTextChanged(e)
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        If Multiline AndAlso (ScrollBars = ScrollBars.Vertical OrElse ScrollBars = ScrollBars.Both) Then lblwaterText.Width = Width - 20 Else lblwaterText.Width = Width
        lblwaterText.Height = Height - 2
        MyBase.OnSizeChanged(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        lblwaterText.Visible = False
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        lblwaterText.Visible = MyBase.Text = String.Empty
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnLeave(ByVal e As EventArgs)
        If IsPass = False Then
            MessageBox.Show("输入有误", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Focus()
        End If

        MyBase.OnLeave(e)
    End Sub

    <Obsolete("Please refactor code that uses this function, it is a simple work-around to simulate inline assignment in VB!")>
    Private Shared Function __InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function


    'Private Const OCM_COMMAND As Integer = 8465

    'Private Const WM_PAINT As Integer = 15

    'Private drawPrompt As Boolean

    'Private promptText As String = "Input here"

    '<Browsable(True)>
    '<EditorBrowsable(EditorBrowsableState.Always)>
    '<DefaultValue("")>
    'Public Property WaterMark As String
    '    Get
    '        Return promptText
    '    End Get

    '    Set(ByVal value As String)
    '        promptText = value.Trim()
    '        Invalidate()
    '    End Set
    'End Property

    'Private _waterMarkColor As Color = Color.Silver

    'Public Property WaterMarkColor As Color
    '    Get
    '        Return _waterMarkColor
    '    End Get

    '    Set(ByVal value As Color)
    '        _waterMarkColor = value
    '        Invalidate()
    '    End Set
    'End Property

    'Private _waterMarkFont As Font = New System.Drawing.Font("Calibri", 10)

    'Public Property WaterMarkFont As Font
    '    Get
    '        Return _waterMarkFont
    '    End Get

    '    Set(ByVal value As Font)
    '        _waterMarkFont = value
    '    End Set
    'End Property


    'Private Sub DrawTextPrompt()
    '    Using graphics As Graphics = CreateGraphics()
    '        DrawTextPrompt(graphics)
    '    End Using
    'End Sub

    'Private Sub DrawTextPrompt(ByVal g As Graphics)
    '    Dim flags As TextFormatFlags = TextFormatFlags.NoPadding Or TextFormatFlags.EndEllipsis
    '    Dim clientRectangle As Rectangle = clientRectangle
    '    Select Case TextAlign
    '        Case HorizontalAlignment.Left
    '            clientRectangle.Offset(1, 0)
    '        Case HorizontalAlignment.Right
    '            flags = flags Or TextFormatFlags.Right
    '            clientRectangle.Offset(-2, 0)
    '        Case HorizontalAlignment.Center
    '            flags = flags Or TextFormatFlags.HorizontalCenter
    '            clientRectangle.Offset(1, 0)
    '    End Select

    '    Dim drawBrush As SolidBrush = New SolidBrush(WaterMarkColor)
    '    TextRenderer.DrawText(g, promptText, _waterMarkFont, clientRectangle, _waterMarkColor, BackColor, flags)
    'End Sub

    ''Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    ''    If drawPrompt Then
    ''        DrawTextPrompt(e.Graphics)
    ''    End If
    ''    MyBase.OnPaint(e)

    ''End Sub

    'Protected Overrides Sub OnCreateControl()
    '    MyBase.OnCreateControl()
    'End Sub

    'Protected Overrides Sub OnTextAlignChanged(ByVal e As EventArgs)
    '    MyBase.OnTextAlignChanged(e)
    '    Invalidate()
    'End Sub

    ''Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
    ''    MyBase.OnTextChanged(e)
    ''    drawPrompt = (Text.Trim().Length = 0)
    ''    Invalidate()
    ''End Sub

    ''Protected Overrides Sub WndProc(ByRef m As Message)
    ''    MyBase.WndProc(m)
    ''    If ((m.Msg = WM_PAINT) OrElse (m.Msg = OCM_COMMAND)) AndAlso (drawPrompt AndAlso Not GetStyle(ControlStyles.UserPaint)) Then
    ''        DrawTextPrompt()
    ''    End If
    ''End Sub

    ''Protected Overrides Sub OnLostFocus(ByVal e As EventArgs)
    ''    MyBase.OnLostFocus(e)
    ''End Sub



End Class
