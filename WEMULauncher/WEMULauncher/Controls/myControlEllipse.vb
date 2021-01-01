Imports System.Drawing.Drawing2D

Public Class myControlEllipse


    WithEvents _Control As New Control
    Public Property myControl As Control
        Get
            Return _Control
        End Get
        Set(value As Control)
            _Control = value
        End Set
    End Property

    'WithEvents _Form As New Form
    'Public Property Form As Form
    '    Get
    '        Return _Form
    '    End Get
    '    Set(value As Form)
    '        _Form = value
    '    End Set
    'End Property

    Private _R As Integer = 40 ' CInt(ClientRectangle.Height / 2)
    Private _BoardThickness As Integer = 1
    Private _BorderColor As Color = Color.Black

    Public Property R As Integer
        Get
            Return _R
        End Get
        Set(value As Integer)
            _R = value
        End Set
    End Property

    Public Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(value As Color)
            _BorderColor = value
        End Set
    End Property

    Public Property BoardThickness As Integer
        Get
            Return _BoardThickness
        End Get
        Set(value As Integer)
            _BoardThickness = value
        End Set
    End Property


    Private Sub Control_Paint(sender As Object, e As PaintEventArgs) Handles _Control.Paint ', _Form.Paint


        ''you can't anti-alias the region, so you have to use graphic's FillPath method in order for the drawing to be anti-aliased
        ''https://stackoverflow.com/questions/33878184/c-sharp-how-to-make-smooth-arc-region-using-graphics-path
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim oPath As GraphicsPath = New GraphicsPath()
        Dim x As Integer = 0 'Sender.left
        Dim y As Integer = 0 'Sender.top
        Dim w As Integer = sender.Width
        Dim h As Integer = sender.Height
        Dim g As Graphics = CreateGraphics()
        oPath.AddArc(x, y, _R, _R, 180, 90)
        oPath.AddArc(w - _R, y, _R, _R, 270, 90)
        oPath.AddArc(CSng(w - _R), CSng(h - _R), _R, _R, 0, 90)
        oPath.AddArc(x, CSng(h - _R), _R, _R, 90, 90)
        oPath.CloseAllFigures()




        'circle
        Dim shadowPen As Pen = New Pen(_BorderColor)
        shadowPen.Width = _BoardThickness
        Dim oPath2 As GraphicsPath = New GraphicsPath()

        Dim intInflat As Integer = 2

        Dim x2 As Integer = x + intInflat 'add the inflat offset
        Dim y2 As Integer = x + intInflat 'add the inflat offset
        Dim w2 As Integer = w - intInflat
        Dim h2 As Integer = h - intInflat
        Dim g2 As Graphics = CreateGraphics()
        oPath2.AddArc(x2, y2, _R, _R, 180, 90)
        oPath2.AddArc(w2 - _R, y2, _R, _R, 270, 90)
        oPath2.AddArc(CSng(w2 - _R), CSng(h2 - _R), _R, _R, 0, 90)
        oPath2.AddArc(x2, CSng(h2 - _R), _R, _R, 90, 90)
        oPath2.CloseAllFigures()


        If _BoardThickness > 0 Then
            e.Graphics.DrawPath(shadowPen, oPath2)
        End If

        sender.Region = New Region(oPath)


        'Dim oPath As GraphicsPath = New GraphicsPath()

        'Dim x As Integer = 0
        'Dim y As Integer = 0
        'Dim w As Integer = sender.Width
        'Dim h As Integer = sender.Height
        'Dim R As Integer = _arc ' 40 'angle 半径

        'oPath.AddArc(x, y, R, R, 180, 90)
        'oPath.AddArc(w - R, y, R, R, 270, 90)
        'oPath.AddArc(CSng(w - R), CSng(h - R), R, R, 0, 90)
        ''oPath.AddArc(CSng(w - a / 2), CSng(h - a / 2), CSng(a / 2), CSng(a / 2), 0, 90)
        'oPath.AddArc(x, CSng(h - R), R, R, 90, 90)
        'oPath.CloseAllFigures()

        'Dim shadowPen As Pen = New Pen(Color.Blue)
        'e.Graphics.DrawPath(shadowPen, oPath)

        'sender.Region = New Region(oPath)


        '如果修改边距的话无法去毛边
        '必须先draw base，在draw添加的内容
        ' _R = CInt(ClientRectangle.Height * 0.8) 'CInt(ClientRectangle.Height / 2)

    End Sub


End Class
