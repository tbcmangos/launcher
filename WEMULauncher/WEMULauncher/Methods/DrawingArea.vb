Public MustInherit Class DrawingArea
    Inherits Panel

    Protected graphics As Graphics

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 32
            Return cp
        End Get
    End Property

    Public Sub New()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Me.graphics = e.Graphics
        Me.graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        Me.graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        OnDraw()
    End Sub

    Protected MustOverride Sub OnDraw()

    Protected Sub DrawText(ByVal text As String, ByVal position As Point)
        DrawingArea.DrawText(Me.graphics, text, "Microsoft Sans Serif", 8.25F, FontStyle.Regular, Brushes.Black, position)
    End Sub

    Protected Sub DrawText(ByVal text As String, ByVal color As Brush, ByVal position As Point)
        DrawingArea.DrawText(Me.graphics, text, "Microsoft Sans Serif", 8.25F, FontStyle.Regular, color, position)
    End Sub

    Protected Sub DrawText(ByVal text As String, ByVal style As FontStyle, ByVal position As Point)
        DrawingArea.DrawText(Me.graphics, text, "Microsoft Sans Serif", 8.25F, style, Brushes.Black, position)
    End Sub

    Protected Sub DrawText(ByVal text As String, ByVal style As FontStyle, ByVal color As Brush, ByVal position As Point)
        DrawingArea.DrawText(Me.graphics, text, "Microsoft Sans Serif", 8.25F, style, color, position)
    End Sub

    Protected Sub DrawText(ByVal text As String, ByVal fontSize As Single, ByVal style As FontStyle, ByVal color As Brush, ByVal position As Point)
        DrawingArea.DrawText(Me.graphics, text, "Microsoft Sans Serif", fontSize, style, color, position)
    End Sub

    Protected Sub DrawText(ByVal text As String, ByVal fontFamily As String, ByVal fontSize As Single, ByVal style As FontStyle, ByVal color As Brush, ByVal position As Point)
        DrawingArea.DrawText(Me.graphics, text, fontFamily, fontSize, style, color, position)
    End Sub

    Public Shared Sub DrawText(ByVal graphics As Graphics, ByVal text As String, ByVal fontFamily As String, ByVal fontSize As Single, ByVal style As FontStyle, ByVal color As Brush, ByVal position As Point)
        Dim font As Font = New Font(fontFamily, fontSize, style)
        Dim textSizeF As SizeF = graphics.MeasureString(text, font)
        Dim width As Integer = CInt(Math.Ceiling(textSizeF.Width))
        Dim height As Integer = CInt(Math.Ceiling(textSizeF.Height))
        Dim textSize As Size = New Size(width, height)
        Dim rectangle As Rectangle = New Rectangle(position, textSize)
        graphics.DrawString(text, font, color, rectangle)
    End Sub
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
