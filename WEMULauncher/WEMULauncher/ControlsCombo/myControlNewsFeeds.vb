Public Class myControlNewsFeeds


    Public Property PostImage() As Image
        Get
            Return PictureBoxPost.Image
        End Get
        Set(value As Image)
            PictureBoxPost.Image = value
        End Set
    End Property


    Public Property ProfileImage() As Image
        Get
            Return PictureBoxProfile.Image
        End Get
        Set(value As Image)
            PictureBoxProfile.Image = value
        End Set
    End Property

    Public Property UserName As String
        Get
            Return LabelUserName.Text
        End Get
        Set(value As String)
            LabelUserName.Text = value
        End Set

    End Property
    Public Property PostTime As String
        Get
            Return LabelTime.Text
        End Get
        Set(value As String)
            LabelTime.Text = value
        End Set
    End Property

End Class
