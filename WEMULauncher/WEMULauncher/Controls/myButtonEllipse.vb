Imports System.Drawing.Drawing2D

Public Class myButtonEllipse

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        '如果修改边距的话无法去毛边


        Dim oPath As GraphicsPath = New GraphicsPath()
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim w As Integer = Width
        Dim h As Integer = Height
        Dim a As Integer = 10 ' 40 'angle
        Dim g As Graphics = CreateGraphics()
        oPath.AddArc(x, y, a, a, 180, 90)
        oPath.AddArc(w - a, y, a, a, 270, 90)
        oPath.AddArc(CSng(w - a), CSng(h - a), a, a, 0, 90)
        'oPath.AddArc(CSng(w - a / 2), CSng(h - a / 2), CSng(a / 2), CSng(a / 2), 0, 90)
        oPath.AddArc(x, CSng(h - a), a, a, 90, 90)
        oPath.CloseAllFigures()
        Region = New Region(oPath)

        'Me.Region = New System.Drawing.Region(oPath)
        oPath.Dispose()



        'you can't anti-alias the region, so you have to use graphic's FillPath method in order for the drawing to be anti-aliased
        'https://stackoverflow.com/questions/33878184/c-sharp-how-to-make-smooth-arc-region-using-graphics-path
        'pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear
        'pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality
        'pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        'pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'Dim brush As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, Color.Aqua, Color.Blue, 90)
        'Using gp As GraphicsPath = New GraphicsPath()
        '    gp.AddArc(New Rectangle(New Point(0, 0), New Size(Me.Height, Me.Height)), 90, 180)
        '    gp.AddLine(New Point(Me.Height / 2, 0), New Point(Me.Width - (Me.Height / 2), 0))
        '    gp.AddArc(New Rectangle(New Point(Me.Width - Me.Height, 0), New Size(Me.Height, Me.Height)), -90, 180)
        '    gp.CloseFigure()
        '    pevent.Graphics.FillPath(brush, gp)

        'End Using


        MyBase.OnPaint(pevent)
    End Sub

End Class
