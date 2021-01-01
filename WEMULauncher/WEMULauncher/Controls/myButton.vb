


Public Class myButton


    Private NormalImage As Image
    Private HoverImage As Image

    Public Property ImageNormal() As Image
        Get
            Return NormalImage

        End Get
        Set(value As Image)
            NormalImage = value
        End Set
    End Property
    Public Property ImageHover() As Image
        Get
            Return HoverImage

        End Get
        Set(value As Image)
            HoverImage = value
        End Set
    End Property



    Private Sub myImageBtn_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Me.Image = HoverImage

    End Sub
    Private Sub myImageBtn_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.Image = NormalImage

    End Sub

    Private Sub myButton_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'NormalImage = Me.Image

    End Sub
End Class
