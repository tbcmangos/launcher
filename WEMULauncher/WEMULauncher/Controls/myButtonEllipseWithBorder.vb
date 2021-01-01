Imports System.Drawing.Drawing2D

Public Class myButtonEllipseWithBorder

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

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        '如果修改边距的话无法去毛边
        '必须先draw base，在draw添加的内容
        MyBase.OnPaint(pevent)
        _R = CInt(ClientRectangle.Height * 0.8) 'CInt(ClientRectangle.Height / 2)

        ''you can't anti-alias the region, so you have to use graphic's FillPath method in order for the drawing to be anti-aliased
        ''https://stackoverflow.com/questions/33878184/c-sharp-how-to-make-smooth-arc-region-using-graphics-path
        pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear
        pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality
        pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim oPath As GraphicsPath = New GraphicsPath()
        Dim x As Integer = ClientRectangle.X
        Dim y As Integer = ClientRectangle.Y
        Dim w As Integer = ClientRectangle.Width
        Dim h As Integer = ClientRectangle.Height
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
        Dim rect As Rectangle = ClientRectangle
        Dim intInflat As Integer = 2
        rect.Inflate(-intInflat, -intInflat)
        Dim x2 As Integer = rect.X + intInflat 'add the inflat offset
        Dim y2 As Integer = rect.Y + intInflat 'add the inflat offset
        Dim w2 As Integer = rect.Width
        Dim h2 As Integer = rect.Height
        Dim g2 As Graphics = CreateGraphics()
        oPath2.AddArc(x2, y2, _R, _R, 180, 90)
        oPath2.AddArc(w2 - _R, y2, _R, _R, 270, 90)
        oPath2.AddArc(CSng(w2 - _R), CSng(h2 - _R), _R, _R, 0, 90)
        oPath2.AddArc(x2, CSng(h2 - _R), _R, _R, 90, 90)
        oPath2.CloseAllFigures()



        pevent.Graphics.DrawPath(shadowPen, oPath2)
        Region = New Region(oPath)





        'Draw(ClientRectangle, pevent.Graphics, 16)

    End Sub




    Private Sub Draw(ByVal rectangle As Rectangle, ByVal g As Graphics, ByVal _radius As Integer)
        Dim shadowPen As Pen = New Pen(Color.Blue)
        shadowPen.Width = 1
        Dim gp As GraphicsPath = DrawRoundRect(rectangle.X + 1, rectangle.Y + 1, rectangle.Width - 6, rectangle.Height - 6, _radius)

        Region = New Region(gp)
        g.DrawPath(shadowPen, gp)
    End Sub

    Public Shared Function DrawRoundRect(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal radius As Integer) As GraphicsPath
        Dim gp As GraphicsPath = New GraphicsPath()
        gp.AddArc(x, y, radius, radius, 180, 90)
        gp.AddArc(width - radius, y, radius, radius, 270, 90)
        gp.AddArc(width - radius, height - radius, radius, radius, 0, 90)
        gp.AddArc(x, height - radius, radius, radius, 90, 90)
        gp.CloseAllFigures()
        Return gp
    End Function

End Class
