Imports System.Drawing.Drawing2D

Public Class myFormSlide



#Region "Drag window"
    Private mPoint As Point = New Point()
    Private bMouseDown As Boolean = False
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader.MouseDown
        bMouseDown = True
        mPoint.X = e.X
        mPoint.Y = e.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader.MouseMove
        If e.Button = MouseButtons.Left And bMouseDown Then
            Dim myPosittion As Point = Me.Location 'MousePosition
            myPosittion.Offset(-mPoint.X + e.X, -mPoint.Y + e.Y)
            Location = myPosittion
        End If
    End Sub

    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseUp
        bMouseDown = False
    End Sub
#End Region




    Dim panelWidth As Integer
    Dim Hidden As Boolean


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Hidden Then
            PanelSlide.Width = PanelSlide.Width + 20
            If PanelSlide.Width >= panelWidth Then
                Timer1.Stop()
                Hidden = False
                Me.Refresh()
            End If
        Else
            PanelSlide.Width = PanelSlide.Width - 20
            If PanelSlide.Width <= 10 Then
                Timer1.Stop()
                Hidden = True
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub frmSlide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelWidth = PanelSlide.Width
        Hidden = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub

    Private Sub PanelContent_Paint(sender As Object, e As PaintEventArgs) Handles PanelContent.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
        '立即启动重绘
        'Me.Invalidate()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub myFormSlide_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        '立即启动重绘
        Me.Invalidate()
    End Sub
End Class