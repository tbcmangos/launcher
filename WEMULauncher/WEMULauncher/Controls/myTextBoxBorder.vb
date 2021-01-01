Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class myTextBoxBorder
    Private ReadOnly lblwaterText As Label = New Label()
    '--------------------
    Private Const EM_SETRECT As Integer = 179

    Private Const EM_GETRECT As Integer = 178

    Private Const WM_PASTE As Integer = 770

    Private _borderColor As Color = Color.Black

    Private _leftBorderSize As Single = 1

    Private _rightBorderSize As Single = 1

    Private _topBorderSize As Single = 1

    Private _bottomBorderSize As Single = 1

    Private _textPadding As Padding = New Padding(1)

    Private _allowReturn As Boolean = False

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="SendMessageA")>
    Private Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As String) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="SendMessageA")>
    Private Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByRef lParam As Rectangle) As Integer
    End Function


    Public Sub New()
        InitializeComponent()
        lblwaterText.BorderStyle = BorderStyle.None
        lblwaterText.Enabled = False
        lblwaterText.BackColor = Color.White
        lblwaterText.AutoSize = True
        lblwaterText.Top = 1
        lblwaterText.Left = 2
        lblwaterText.FlatStyle = FlatStyle.System
        Controls.Add(lblwaterText)
    End Sub

    Private Sub DrawBorder(ByVal hDC As IntPtr)
        Dim g As Graphics = Graphics.FromHdc(hDC)
        If _leftBorderSize > 0 Then
            Dim penLeft As Pen = New Pen(_borderColor, _leftBorderSize)
            Dim pointLeft As Point() = New Point(1) {}
            pointLeft(0) = New Point(0, 0)
            pointLeft(1) = New Point(0, Me.Width - 1)
            g.DrawLine(penLeft, pointLeft(0), pointLeft(1))
        End If

        If _rightBorderSize > 0 Then
            Dim penRight As Pen = New Pen(_borderColor, _rightBorderSize)
            Dim pointRight As Point() = New Point(1) {}
            pointRight(0) = New Point(Me.Width - 1, 0)
            pointRight(1) = New Point(Me.Width - 1, Me.Height - 1)
            g.DrawLine(penRight, pointRight(0), pointRight(1))
        End If

        If _topBorderSize > 0 Then
            Dim penTop As Pen = New Pen(_borderColor, _topBorderSize)
            Dim pointTop As Point() = New Point(1) {}
            pointTop(0) = New Point(0, 0)
            pointTop(1) = New Point(Me.Width - 1, 0)
            g.DrawLine(penTop, pointTop(0), pointTop(1))
        End If

        If _bottomBorderSize > 0 Then
            Dim penBottom As Pen = New Pen(_borderColor, _bottomBorderSize)
            Dim pointBottom As Point() = New Point(1) {}
            pointBottom(0) = New Point(0, Me.Height - 1)
            pointBottom(1) = New Point(Me.Width - 1, Me.Height - 1)
            g.DrawLine(penBottom, pointBottom(0), pointBottom(1))
        End If
    End Sub

    Public Sub SetTextDispLayout()
        If Text = "" Then Return
        If Me.Multiline AndAlso (Not Me.WordWrap) Then
            Dim rect As Rectangle = New Rectangle()
            SendMessage(Me.Handle, EM_GETRECT, CType(0, IntPtr), rect)
            rect.Y = _textPadding.Top
            rect.X = _textPadding.Left
            rect.Height = Height
            rect.Width = Width - _textPadding.Right - _textPadding.Left
            SendMessage(Me.Handle, EM_SETRECT, IntPtr.Zero, rect)
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        'Dim brush As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, Color.Aqua, Color.Blue, 90)
        'Using gp As GraphicsPath = New GraphicsPath()
        '    gp.AddArc(New Rectangle(New Point(0, 0), New Size(Me.Height, Me.Height)), 90, 180)
        '    gp.AddLine(New Point(Me.Height / 2, 0), New Point(Me.Width - (Me.Height / 2), 0))
        '    gp.AddArc(New Rectangle(New Point(Me.Width - Me.Height, 0), New Size(Me.Height, Me.Height)), -90, 180)
        '    gp.CloseFigure()
        '    pe.Graphics.FillPath(Brush, gp)
        '    Me.Region = New System.Drawing.Region(gp)
        'End Using


        MyBase.OnPaint(pe)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = 15 OrElse m.Msg = 307 Then
            Dim hDC As IntPtr = GetWindowDC(m.HWnd)
            If hDC.ToInt32() = 0 Then Return
            DrawBorder(hDC)
            m.Result = IntPtr.Zero
            ReleaseDC(m.HWnd, hDC)
        End If
    End Sub

    <Description("边框颜色"), Category("自定义属性")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get

        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Description("左边框宽度"), Category("自定义属性")>
    Public Property LeftBorderSize As Single
        Get
            Return _leftBorderSize
        End Get

        Set(ByVal value As Single)
            _leftBorderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Description("右边框宽度"), Category("自定义属性")>
    Public Property RightBorderSize As Single
        Get
            Return _rightBorderSize
        End Get

        Set(ByVal value As Single)
            _rightBorderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Description("上边框宽度"), Category("自定义属性")>
    Public Property TopBorderSize As Single
        Get
            Return _topBorderSize
        End Get

        Set(ByVal value As Single)
            _topBorderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Description("下边框宽度"), Category("自定义属性")>
    Public Property BottomBorderSize As Single
        Get
            Return _bottomBorderSize
        End Get

        Set(ByVal value As Single)
            _bottomBorderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Description("文本内边距，当允许多行和禁止回车时有效"), Category("自定义属性")>
    Public Property TextPadding As Padding
        Get
            Return _textPadding
        End Get

        Set(ByVal value As Padding)
            _textPadding = value
            SetTextDispLayout()
        End Set
    End Property

    <Description("是否允许回车"), Category("自定义属性")>
    Public Property AllowReturn As Boolean
        Get
            Return _allowReturn
        End Get

        Set(ByVal value As Boolean)
            _allowReturn = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        If Not _allowReturn AndAlso (Convert.ToInt16(e.KeyChar) = CInt(Keys.[Return]) OrElse Convert.ToInt16(e.KeyChar) = CInt(Keys.LineFeed)) Then
            e.Handled = True
        End If

        MyBase.OnKeyPress(e)
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        lblwaterText.Visible = MyBase.Text = String.Empty
        MyBase.OnTextChanged(e)
        SetTextDispLayout()
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

    'Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
    '    lblwaterText.Visible = MyBase.Text = String.Empty
    '    Testing(Me.ControlType, Me.Text)
    '    MyBase.OnTextChanged(e)
    'End Sub

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
End Class
