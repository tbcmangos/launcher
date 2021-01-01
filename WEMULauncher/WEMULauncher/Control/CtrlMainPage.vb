Public Class CtrlMainPage

#Region "slide"
    '221,46
    '68,46
    Dim CONST_WIDER As Integer = 220
    Dim CONST_NARROW As Integer = 70
    Dim CONST_STEP As Integer = 10

    Dim panelWidth As Integer
    Dim Hidden As Boolean

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        panelWidth = CtrlTransPanelLeft.Width
        Hidden = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Hidden Then
            CtrlTransPanelLeft.Width = CtrlTransPanelLeft.Width + CONST_STEP
            If CtrlTransPanelLeft.Width >= CONST_WIDER Then
                Timer1.Stop()
                Hidden = False
                'Me.Refresh()
            End If
        Else
            CtrlTransPanelLeft.Width = CtrlTransPanelLeft.Width - CONST_STEP
            If CtrlTransPanelLeft.Width <= CONST_NARROW Then
                Timer1.Stop()
                Hidden = True
                'Me.Refresh()
            End If
        End If
    End Sub

    Private Sub MyButtonSlide_Click(sender As Object, e As EventArgs) Handles MyButtonSlide.Click
        Timer1.Start()
    End Sub
#End Region

End Class
