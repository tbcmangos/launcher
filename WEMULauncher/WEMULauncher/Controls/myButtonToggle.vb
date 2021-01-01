


Public Class myButtonToggle


    Private rs As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myButtonToggle))
    Private _OnOff As Boolean = False
    Public Property OnOff() As Boolean
        Get
            Return _OnOff
        End Get
        Set(ByVal value As Boolean)
            _OnOff = value
            If _OnOff = True Then
                Me.Image = CType(rs.GetObject("Toggle_On_48px"), System.Drawing.Image)
            Else
                Me.Image = CType(rs.GetObject("Toggle_Off_48px"), System.Drawing.Image)
            End If
            Me.Invalidate()
        End Set
    End Property





End Class
