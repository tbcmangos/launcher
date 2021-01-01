Public Class myHBLogo

    Dim xOrg As Integer = 288


    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        'xOrg = PictureBox2.Left
    End Sub
    Private Function getColor() As Color

        Dim x As Integer, y As Integer, z As Integer
        x = Int(Rnd() * (255))
        y = Int(Rnd() * (255))
        z = Int(Rnd() * (255))

        Return Color.FromArgb(x, y, z)

    End Function




    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MyButtonCircluar1.Visible = True
        MyButtonCircluar3.Visible = True
        MyButtonCircluar5.Visible = True
        MyButtonCircluar7.Visible = True
        MyButtonCircluar1.BackColor = getColor()
        MyButtonCircluar2.BackColor = getColor()
        MyButtonCircluar3.BackColor = getColor()
        MyButtonCircluar4.BackColor = getColor()
        MyButtonCircluar5.BackColor = getColor()
        MyButtonCircluar6.BackColor = getColor()
        MyButtonCircluar7.BackColor = getColor()
        MyButtonCircluar8.BackColor = getColor()
        MyButtonCircluar9.BackColor = getColor()
        MyButtonCircluar10.BackColor = getColor()
        MyButtonCircluar11.BackColor = getColor()
        MyButtonCircluar12.BackColor = getColor()
        MyButtonCircluar13.BackColor = getColor()
        MyButtonCircluar14.BackColor = getColor()
        MyButtonCircluar15.BackColor = getColor()
        MyButtonCircluar16.BackColor = getColor()
        'Timer1.Enabled = False
        'Timer2.Enabled = True


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Panel2.Left -= 1


        If Panel2.Left < 200 Then
            Panel2.Left = xOrg
        End If


        Panel3.Left += 1


        If Panel3.Left > Me.Width + 100 Then
            Panel3.Left = xOrg
        End If
    End Sub



#Region "Transpancy PictureBox(working, but not what i want)"
    'Protected Overrides Sub OnPaint(e As PaintEventArgs)
    '    MyBase.OnPaint(e)
    '    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
    '    e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
    '    e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
    '    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality

    '    Dim Image1 As Image = PictureBox1.Image
    '    Dim Image2 As Image = PictureBox2.Image
    '    Dim width1 As Integer = Image1.Size.Width
    '    Dim height1 As Integer = Image1.Size.Height
    '    Dim big As Rectangle = New Rectangle(0, 0, width1, height1)

    '    Dim width2 As Integer = Image2.Size.Width
    '    Dim height2 As Integer = Image2.Size.Height
    '    Dim small As Rectangle = New Rectangle(0, 0, width2, height2)

    '    e.Graphics.DrawImage(Image1, big)
    '    e.Graphics.DrawImage(Image2, small)
    '    ' e.Graphics.DrawImage(broculoImage, small)
    '    'Dim fontSize As Single = 8.25F
    '    'Dim textPosition As Point = New Point(50, 100)
    '    'DrawText(e.Graphics, "http://www.broculos.net", "Microsoft Sans Serif", fontSize, FontStyle.Underline, Brushes.Blue, textPosition)






    'End Sub


    Public Shared Sub DrawText(ByVal graphics As Graphics, ByVal text As String, ByVal fontFamily As String, ByVal fontSize As Single, ByVal style As FontStyle, ByVal color As Brush, ByVal position As Point)
        Dim font As Font = New Font(fontFamily, fontSize, style)
        Dim textSizeF As SizeF = graphics.MeasureString(text, font)
        Dim width As Integer = CInt(Math.Ceiling(textSizeF.Width))
        Dim height As Integer = CInt(Math.Ceiling(textSizeF.Height))
        Dim textSize As Size = New Size(width, height)
        Dim rectangle As Rectangle = New Rectangle(position, textSize)
        graphics.DrawString(text, font, color, rectangle)
    End Sub



    Private Sub Panel2_Paint(sender As Object, e As EventArgs) Handles Panel2.Paint
        'Panel2.BackColor = Color.FromArgb(0, 0, 0, 0)'或者属性设置为透明
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
#End Region
End Class
