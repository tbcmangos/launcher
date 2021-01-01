Public Class frmSplash
    Private _StatusInfo As String = ""
    Public Property StatusInfo() As String
        Get
            Return _StatusInfo
        End Get
        Set(value As String)
            _StatusInfo = value
        End Set
    End Property

    Public Sub ChangeStatusText()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf Me.ChangeStatusText))
                Return
            End If

            labStatus.Text = _StatusInfo
        Catch e As Exception
        End Try
    End Sub
End Class