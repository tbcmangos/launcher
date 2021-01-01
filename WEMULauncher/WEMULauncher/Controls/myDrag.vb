Public Class myDrag
    'WithEvents _Control As New Control
    'Public Property myControl As Control
    '    Get
    '        Return _Control
    '    End Get
    '    Set(value As Control)
    '        _Control = value
    '    End Set
    'End Property

    'WithEvents _Form As New Form
    'Public Property Form As Form
    '    Get
    '        Return _Form
    '    End Get
    '    Set(value As Form)
    '        _Form = value
    '    End Set
    'End Property
    WithEvents _Panel As New Panel
    Public Property Panel As Panel
        Get
            Return _Panel
        End Get
        Set(value As Panel)
            _Panel = value
        End Set
    End Property

    Private mPoint As Point = New Point()
    Private bMouseDown As Boolean = False
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _Panel.MouseDown ' _Control.MouseDown, _Form.MouseDown, _Panel.MouseDown
        bMouseDown = True
        mPoint.X = e.X
        mPoint.Y = e.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _Panel.MouseMove '_Control.MouseMove, _Form.MouseMove, _Panel.MouseMove
        If e.Button = MouseButtons.Left And bMouseDown Then
            Dim myPosittion As Point = sender.parent.Location 'MousePosition
            myPosittion.Offset(-mPoint.X + e.X, -mPoint.Y + e.Y)
            sender.parent.Location = myPosittion
        End If
    End Sub

    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs) Handles _Panel.MouseUp '_Control.MouseUp, _Form.MouseUp, _Panel.MouseUp
        bMouseDown = False
    End Sub
End Class
