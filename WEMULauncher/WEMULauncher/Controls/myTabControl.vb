Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class myTabControl
    Public Sub New()
        SetStyles()
    End Sub

    Private Sub SetStyles()
        MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)
        MyBase.UpdateStyles()
    End Sub

    Private _backColor As Color = Color.FromArgb(23, 169, 254)

    <Browsable(True)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <DefaultValue(GetType(Color), "23, 169, 254")>
    Public Overrides Property BackColor As Color
        Get
            Return _backColor
        End Get

        Set(ByVal value As Color)
            _backColor = value
            MyBase.Invalidate(True)
        End Set
    End Property

    Private _borderColor As Color = Color.FromArgb(23, 169, 254)

    <DefaultValue(GetType(Color), "23, 169, 254")>
    <Description("TabContorl边框色")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get

        Set(ByVal value As Color)
            _borderColor = value
            MyBase.Invalidate(True)
        End Set
    End Property

    Private _headSelectedBackColor As Color = Color.FromArgb(23, 169, 254)

    <DefaultValue(GetType(Color), "23, 169, 254")>
    <Description("TabPage头部选中后的背景颜色")>
    Public Property HeadSelectedBackColor As Color
        Get
            Return _headSelectedBackColor
        End Get

        Set(ByVal value As Color)
            _headSelectedBackColor = value
        End Set
    End Property

    Private _headSelectedBorderColor As Color = Color.FromArgb(23, 169, 254)

    <DefaultValue(GetType(Color), "23, 169, 254")>
    <Description("TabPage头部选中后的边框颜色")>
    Public Property HeadSelectedBorderColor As Color
        Get
            Return _headSelectedBorderColor
        End Get

        Set(ByVal value As Color)
            _headSelectedBorderColor = value
        End Set
    End Property

    Private _headerBackColor As Color = Color.FromArgb(23, 169, 254)

    <DefaultValue(GetType(Color), "23, 169, 254")>
    <Description("TabPage头部默认边框颜色")>
    Public Property HeaderBackColor As Color
        Get
            Return _headerBackColor
        End Get

        Set(ByVal value As Color)
            _headerBackColor = value
        End Set
    End Property

    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        If Me.DesignMode = True Then
            Dim backBrush As LinearGradientBrush = New LinearGradientBrush(Me.Bounds, SystemColors.ControlLightLight, SystemColors.ControlLight, LinearGradientMode.Vertical)
            pevent.Graphics.FillRectangle(backBrush, Me.Bounds)
            backBrush.Dispose()
        Else
            Me.PaintTransparentBackground(pevent.Graphics, Me.ClientRectangle)
        End If
    End Sub

    Protected Sub PaintTransparentBackground(ByVal g As Graphics, ByVal clipRect As Rectangle)
        If (Me.Parent IsNot Nothing) Then
            clipRect.Offset(Me.Location)
            Dim e As PaintEventArgs = New PaintEventArgs(g, clipRect)
            Dim state As GraphicsState = g.Save()
            g.SmoothingMode = SmoothingMode.HighSpeed
            Try
                g.TranslateTransform(CSng(-Me.Location.X), CSng(-Me.Location.Y))
                Me.InvokePaintBackground(Me.Parent, e)
                Me.InvokePaint(Me.Parent, e)
            Finally
                g.Restore(state)
                clipRect.Offset(-Me.Location.X, -Me.Location.Y)
                Using brush As SolidBrush = New SolidBrush(_backColor)
                    clipRect.Inflate(1, 1)
                    g.FillRectangle(brush, clipRect)
                End Using
            End Try
        Else
            Dim backBrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(Me.Bounds, SystemColors.ControlLightLight, SystemColors.ControlLight, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
            g.FillRectangle(backBrush, Me.Bounds)
            backBrush.Dispose()
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Me.PaintTransparentBackground(e.Graphics, Me.ClientRectangle)
        Me.PaintAllTheTabs(e)
        Me.PaintTheTabPageBorder(e)
        Me.PaintTheSelectedTab(e)
    End Sub

    Private Sub PaintAllTheTabs(ByVal e As System.Windows.Forms.PaintEventArgs)
        If Me.TabCount > 0 Then
            For index As Integer = 0 To Me.TabCount - 1
                Me.PaintTab(e, index)
            Next
        End If
    End Sub

    Private Sub PaintTab(ByVal e As System.Windows.Forms.PaintEventArgs, ByVal index As Integer)
        Dim path As GraphicsPath = Me.GetPath(index)
        Me.PaintTabBackground(e.Graphics, index, path)
        Me.PaintTabBorder(e.Graphics, index, path)
        Me.PaintTabText(e.Graphics, index)
        Me.PaintTabImage(e.Graphics, index)
    End Sub

    Private Sub PaintTabBackground(ByVal graph As System.Drawing.Graphics, ByVal index As Integer, ByVal path As System.Drawing.Drawing2D.GraphicsPath)
        Dim rect As Rectangle = Me.GetTabRect(index)
        Dim buttonBrush As System.Drawing.Brush = New System.Drawing.Drawing2D.LinearGradientBrush(rect, SystemColors.ControlLightLight, SystemColors.ControlLight, LinearGradientMode.Vertical)
        If index = Me.SelectedIndex Then
            buttonBrush = New System.Drawing.SolidBrush(_headSelectedBackColor)
        End If

        graph.FillPath(buttonBrush, path)
        buttonBrush.Dispose()
    End Sub

    Private Sub PaintTabBorder(ByVal graph As System.Drawing.Graphics, ByVal index As Integer, ByVal path As System.Drawing.Drawing2D.GraphicsPath)
        Dim borderPen As Pen = New Pen(_borderColor)
        If index = Me.SelectedIndex Then
            borderPen = New Pen(_headSelectedBorderColor)
        End If

        graph.DrawPath(borderPen, path)
        borderPen.Dispose()
    End Sub

    Private Sub PaintTabImage(ByVal g As System.Drawing.Graphics, ByVal index As Integer)
        Dim tabImage As Image = Nothing
        If Me.TabPages(index).ImageIndex > -1 AndAlso Me.ImageList IsNot Nothing Then
            tabImage = Me.ImageList.Images(Me.TabPages(index).ImageIndex)
        ElseIf Me.TabPages(index).ImageKey.Trim().Length > 0 AndAlso Me.ImageList IsNot Nothing Then
            tabImage = Me.ImageList.Images(Me.TabPages(index).ImageKey)
        End If

        If tabImage IsNot Nothing Then
            Dim rect As Rectangle = Me.GetTabRect(index)
            g.DrawImage(tabImage, rect.Right - rect.Height - 4, 4, rect.Height - 2, rect.Height - 2)
        End If
    End Sub

    Private Sub PaintTabText(ByVal graph As System.Drawing.Graphics, ByVal index As Integer)
        Dim rect As Rectangle = Me.GetTabRect(index)
        Dim rect2 As Rectangle = New Rectangle(rect.Left, rect.Top, rect.Width, rect.Height)
        Dim tabtext As String = Me.TabPages(index).Text
        Dim format As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        format.Alignment = StringAlignment.Near
        format.LineAlignment = StringAlignment.Center
        format.Trimming = StringTrimming.EllipsisCharacter
        Dim forebrush As Brush = Nothing
        If Me.TabPages(index).Enabled = False Then
            forebrush = SystemBrushes.ControlDark
        Else
            forebrush = SystemBrushes.ControlText
        End If

        Dim tabFont As Font = Me.Font
        If index = Me.SelectedIndex Then
            tabFont = New Font(Me.Font, FontStyle.Bold)
        End If

        graph.DrawString(tabtext, tabFont, forebrush, rect2, format)
    End Sub

    Private Sub PaintTheTabPageBorder(ByVal e As System.Windows.Forms.PaintEventArgs)
        If Me.TabCount > 0 Then
            Dim borderRect As Rectangle = Me.TabPages(0).Bounds
            borderRect.Inflate(1, 1)
            ControlPaint.DrawBorder(e.Graphics, borderRect, Me.BorderColor, ButtonBorderStyle.Solid)
        End If
    End Sub

    Private Sub PaintTheSelectedTab(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim selrect As Rectangle
        Dim selrectRight As Integer = 0
        Select Case Me.SelectedIndex
            Case -1
            Case 0
                selrect = Me.GetTabRect(Me.SelectedIndex)
                selrectRight = selrect.Right
                e.Graphics.DrawLine(SystemPens.ControlLightLight, selrect.Left + 2, selrect.Bottom + 1, selrectRight - 2, selrect.Bottom + 1)
            Case Else
                selrect = Me.GetTabRect(Me.SelectedIndex)
                selrectRight = selrect.Right
                e.Graphics.DrawLine(SystemPens.ControlLightLight, selrect.Left + 6 - selrect.Height, selrect.Bottom + 2, selrectRight - 2, selrect.Bottom + 2)
        End Select
    End Sub

    Private Function GetPath(ByVal index As Integer) As GraphicsPath
        Dim path As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
        path.Reset()
        Dim rect As Rectangle = Me.GetTabRect(index)
        Select Case Alignment
            Case TabAlignment.Top
            Case TabAlignment.Bottom
            Case TabAlignment.Left
            Case TabAlignment.Right
        End Select

        If index = 0 Then
            path.AddLine(rect.Left - 1, rect.Top + 1, rect.Left - 1, rect.Top + 1)
            path.AddLine(rect.Left - 1, rect.Top + 1, rect.Right, rect.Top + 1)
            path.AddLine(rect.Right, rect.Top + 1, rect.Right, rect.Bottom)
            path.AddLine(rect.Right, rect.Bottom, rect.Left - 1, rect.Bottom)
        Else
            If index = Me.SelectedIndex Then
                path.AddLine(rect.Left - 1, rect.Top, rect.Left - 1, rect.Top)
                path.AddLine(rect.Left - 1, rect.Top, rect.Right, rect.Top)
                path.AddLine(rect.Right, rect.Top, rect.Right, rect.Bottom)
                path.AddLine(rect.Right, rect.Bottom + 1, rect.Left - 1, rect.Bottom + 1)
            Else
                path.AddLine(rect.Left - 1, rect.Top, rect.Left - 1, rect.Top)
                path.AddLine(rect.Left - 1, rect.Top, rect.Right, rect.Top)
                path.AddLine(rect.Right, rect.Top, rect.Right, rect.Bottom)
                path.AddLine(rect.Right, rect.Bottom + 1, rect.Left - 1, rect.Bottom + 1)
            End If
        End If

        Return path
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Const WM_SETFONT As Integer = 48

    Private Const WM_FONTCHANGE As Integer = 29

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.OnFontChanged(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
        MyBase.OnFontChanged(e)
        Dim hFont As IntPtr = Me.Font.ToHfont()
        SendMessage(Me.Handle, WM_SETFONT, hFont, CType((-1), IntPtr))
        SendMessage(Me.Handle, WM_FONTCHANGE, IntPtr.Zero, IntPtr.Zero)
        Me.UpdateStyles()
    End Sub
End Class
