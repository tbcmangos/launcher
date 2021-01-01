Public Class MainForm
#Region "Drag window"
    Private mPoint As Point = New Point()
    Private bMouseDown As Boolean = False
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        bMouseDown = True
        mPoint.X = e.X
        mPoint.Y = e.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left And bMouseDown Then
            Dim myPosittion As Point = Me.Location 'MousePosition
            myPosittion.Offset(-mPoint.X + e.X, -mPoint.Y + e.Y)
            Location = myPosittion
        End If
    End Sub

    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs)
        bMouseDown = False
    End Sub
#End Region

    Private Sub CtrlBanner1_MainButtonClick(name As String)
        'PanelPage1.CtrlMainPage1.Visible = True
        PanelPage1.CtrlFriendPage1.Visible = False
        PanelPage1.CtrlShopPage1.Visible = False
        PanelPage1.CtrlNewsPage1.Visible = False
    End Sub

    Private Sub CtrlBanner1_FriendButtonClick(name As String)
        'PanelPage1.CtrlMainPage1.Visible = False
        PanelPage1.CtrlFriendPage1.Visible = True
        PanelPage1.CtrlShopPage1.Visible = False
        PanelPage1.CtrlNewsPage1.Visible = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '半透明效果，需要在panel之上并设置dock
        'CtrlBanner1.BackColor = Color.FromArgb(15, 1, 1, 1) '前面数值越低，越透明
    End Sub
End Class
