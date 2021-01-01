Public Class myControlContacts
    Private Sub myControlContacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Property ProfilePic As Image
        Get
            Return PictureBox1.Image

        End Get
        Set(value As Image)
            PictureBox1.Image = value

        End Set
    End Property
    Public Property txtName As String
        Get
            Return Label1.Text

        End Get
        Set(value As String)
            Label1.Text = value

        End Set
    End Property
    Public Property txtStatus As String
        Get
            Return Label2.Text

        End Get
        Set(value As String)
            Label2.Text = value

        End Set
    End Property
End Class
