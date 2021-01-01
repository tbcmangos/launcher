Imports System.Threading

Public Class splash
    Shared MySplashForm As myTransSplashWinow2 = Nothing 'frmSplash 显示最简单的代码

    Shared MySplashThread As Thread = Nothing

    Private Sub ShowThread()
        MySplashForm = New myTransSplashWinow2()
        Application.Run(MySplashForm)
    End Sub

    Public Sub Show()
        If MySplashThread IsNot Nothing Then Return
        MySplashThread = New Thread(New ThreadStart(AddressOf ShowThread))
        MySplashThread.IsBackground = True
        MySplashThread.SetApartmentState(ApartmentState.STA)
        MySplashThread.Start()
    End Sub

    Public Sub Close()
        If MySplashThread Is Nothing Then Return
        If MySplashForm Is Nothing Then Return
        Try
            MySplashForm.Invoke(New MethodInvoker(AddressOf MySplashForm.Close))
        Catch __unusedException1__ As Exception
        End Try

        MySplashThread = Nothing
        MySplashForm = Nothing
    End Sub

    Public Property Status As String
        Set(ByVal value As String)
            If MySplashForm Is Nothing Then
                Return
            End If

            MySplashForm.StatusInfo = value
            MySplashForm.Invoke(New MethodInvoker(AddressOf MySplashForm.ChangeStatusText))
        End Set

        Get
            If MySplashForm Is Nothing Then
                Throw New InvalidOperationException("Splash Form not on screen")
            End If

            Return MySplashForm.StatusInfo
        End Get
    End Property
End Class
