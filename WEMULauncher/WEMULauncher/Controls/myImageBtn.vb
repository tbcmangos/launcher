Public Class myImageBtn


    Private NormalImage As Image
    Private HoverImage As Image

    Public Property ImageNormal() As Image
        Get
            Return NormalImage

        End Get
        Set(value As Image)
            NormalImage = Nothing
            NormalImage = value
        End Set
    End Property
    Public Property ImageHover() As Image
        Get
            Return HoverImage

        End Get
        Set(value As Image)
            HoverImage = Nothing
            HoverImage = value
        End Set
    End Property



    Private Sub myImageBtn_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Me.Image = Nothing
        Me.Image = HoverImage

    End Sub
    'Protected Overrides Sub OnPaint(pe As PaintEventArgs)
    '    'MyBase.OnPaint(pe)
    '    Dim textRect = ClientRectangle
    '    Dim myRND As New Random
    '    myRND.Next(0, 8)
    '    'textRect.Width = 20
    '    'textRect.X += 8 + 24 + 4
    '    If i > 100 Then i = 0
    '    If i <= 100 Then i = 255
    '    Dim ripplePri = New SolidBrush(Color.FromArgb(i, Color.Black))

    '    If TextString = Nothing Then TextString = "BUTTON"
    '    If ButtonFont Is Nothing Then ButtonFont = New System.Drawing.Font("宋体", 10)
    '    If TextColor Is Nothing Then TextColor = ripplePri
    '    If FontFormat Is Nothing Then FontFormat = New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}


    '    pe.Graphics.DrawString(TextString, ButtonFont, TextColor, textRect, FontFormat)

    '    'e.Graphics.DrawString(Text, New System.Drawing.Font("宋体", 10), ripplePri, textRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})

    'End Sub




    Private Sub myImageBtn_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.Image = Nothing
        Me.Image = NormalImage

    End Sub



    Private ButtonText As String
    Private ButtonFont As Font
    Private ButtonTextColor As SolidBrush
    Private ButtonTextFormat As StringFormat
    Public Property TextString() As String
        Get
            Return ButtonText

        End Get
        Set(value As String)
            ButtonText = value
        End Set
    End Property

    Public Property TextFont() As Font
        Get
            Return ButtonFont

        End Get
        Set(value As Font)
            ButtonFont = value
        End Set
    End Property

    Public Property TextColor() As SolidBrush
        Get
            Return ButtonTextColor

        End Get
        Set(value As SolidBrush)
            ButtonTextColor = value
        End Set
    End Property

    Public Property FontFormat() As StringFormat
        Get
            Return ButtonTextFormat

        End Get
        Set(value As StringFormat)
            ButtonTextFormat = value
        End Set
    End Property

    Dim i As Integer

    Private Sub myImageBtn_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim textRect = ClientRectangle
        Dim myRND As New Random
        myRND.Next(0, 8)
        'textRect.Width = 20
        'textRect.X += 8 + 24 + 4
        If i > 100 Then i = 0
        If i <= 100 Then i = 255
        Dim ripplePri = New SolidBrush(Color.FromArgb(i, Color.Black))

        'If TextString = Nothing Then TextString = "BUTTON"
        If ButtonFont Is Nothing Then ButtonFont = New System.Drawing.Font("宋体", 10)
        If TextColor Is Nothing Then TextColor = ripplePri
        If FontFormat Is Nothing Then FontFormat = New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}


        e.Graphics.DrawString(TextString, ButtonFont, TextColor, textRect, FontFormat)

        'e.Graphics.DrawString(Text, New System.Drawing.Font("宋体", 10), ripplePri, textRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
    End Sub


End Class
