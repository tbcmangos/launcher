Imports System.Drawing.Drawing2D

Public Class myGradianpanel
    Inherits Panel
    Public Property ColorTop() As Color


    Public Property ColorBottom() As Color

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim lgb As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, Me.ColorTop, Me.ColorBottom, 90.0F)
        Dim g As Graphics = e.Graphics
        g.FillRectangle(lgb, Me.ClientRectangle)
        MyBase.OnPaint(e)
    End Sub
End Class
