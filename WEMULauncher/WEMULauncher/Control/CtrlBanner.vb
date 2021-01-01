Public Class CtrlBanner
    Public Event CtrlTransMainClick(ByVal name As String)
    Public Event CtrlTransFriendClick(ByVal name As String)
    Public Event CtrlTransShopClick(ByVal name As String)
    Public Event CtrlTransNewsClick(ByVal name As String)
    Public Event CtrlTransMinimizeClick(ByVal name As String)
    Public Event CtrlTransMaxmizeClick(ByVal name As String)
    Public Event CtrlTransCloseClick(ByVal name As String)

    Private Sub CtrlTransMain_Click(sender As Object, e As EventArgs) Handles CtrlTransMain.Click
        RaiseEvent CtrlTransMainClick(sender.name)
    End Sub

    Private Sub FriendButton_Click(sender As Object, e As EventArgs) Handles CtrlTransFriend.Click
        RaiseEvent CtrlTransFriendClick(sender.name)
    End Sub

    Private Sub ShopButton_Click(sender As Object, e As EventArgs) Handles CtrlTransShop.Click
        RaiseEvent CtrlTransShopClick(sender.name)
    End Sub

    Private Sub NewsButton_Click(sender As Object, e As EventArgs) Handles CtrlTransNews.Click
        RaiseEvent CtrlTransNewsClick(sender.name)
    End Sub

    Private Sub CtrlTransMinimize_Click(sender As Object, e As EventArgs) Handles CtrlTransMinimize.Click
        RaiseEvent CtrlTransMinimizeClick(sender.name)
    End Sub

    Private Sub CtrlTransMaxmize_Click(sender As Object, e As EventArgs) Handles CtrlTransMaxmize.Click
        RaiseEvent CtrlTransMaxmizeClick(sender.name)
    End Sub

    Private Sub CtrlTransClose_Click(sender As Object, e As EventArgs) Handles CtrlTransClose.Click
        RaiseEvent CtrlTransCloseClick(sender.name)
    End Sub
End Class
