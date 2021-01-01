Imports System.Drawing.Drawing2D

Public Class myButtonCircluar

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        '如果修改边距的话无法去毛边
        Dim grPath As GraphicsPath = New GraphicsPath()

        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New System.Drawing.Region(grPath)
        grPath.Dispose()



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
