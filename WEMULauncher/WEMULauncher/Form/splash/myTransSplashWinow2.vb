Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Management
Imports System.Runtime.InteropServices

Public Class myTransSplashWinow2


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


    Private Sub myTransSplashWinow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '方法1，设置背景透明图片，form的backcolor和transparent key设置为同样颜色，这时会有锯齿。
        '方法2， 截图如下
        refreshMe(1) '1.25 这里需要根据系统显示设置更改系统缩放比例，从而保证图片一致
        'Panel1.BackColor = Color.FromArgb(0, 0, 0, 0)
        'panel2.BackColor = Color.FromArgb(0, 0, 0, 0)
        Timer1.Start()

    End Sub

    Private Function getColor() As Color

        Dim x As Integer, y As Integer, z As Integer
        x = Int(Rnd() * (255))
        y = Int(Rnd() * (255))
        z = Int(Rnd() * (255))

        Return Color.FromArgb(x, y, z)

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            'Me.Hide()
            'Dim frmMain As Form = New FormTest
            'frmMain.Show()
        End If

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
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        'Dim gp As GraphicsPath = New GraphicsPath
        'gp.AddEllipse(Me.ClientRectangle)
        'Me.Region = New Region(gp)


        MyBase.OnPaint(e)
    End Sub
#Region "Get DPI settings"
    'Private Sub getDPI()

    '    Try
    '        Dim searcher As New ManagementObjectSearcher(
    '            "root\CIMV2",
    '             "SELECT * FROM Win32_DisplayConfiguration")
    '        '    "SELECT * FROM Win32_DisplayConfiguration")
    '        '"SELECT * FROM Win32_DisplayControllerConfiguration") 
    '        ' "SELECT * FROM Win32_VideoController") 
    '        Dim st As String = ""
    '        For Each queryObj As ManagementObject In searcher.Get()

    '            st &= ("-----------------------------------") & vbCrLf
    '            st &= ("Win32_DisplayConfiguration instance") & vbCrLf
    '            st &= ("-----------------------------------") & vbCrLf
    '            st &= ($"LogPixels: { queryObj("LogPixels")}") & vbCrLf
    '        Next
    '        MsgBox(st)
    '    Catch err As ManagementException
    '        MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
    '    End Try
    'End Sub
#End Region





    Private Sub refreshMe(ByVal zoom As Single)
        Try
            '这个方式是复制当前窗体所占据的界面，包括当前窗体显示的其他内容到内存
            '然后将该图片设置为背景
            'getDPI()

            MyBase.Hide()
            Dim bitmap As Bitmap = New Bitmap(MyBase.Width * zoom, MyBase.Height * zoom, PixelFormat.Format32bppArgb)
            Dim graphics As Graphics = Graphics.FromImage(bitmap)

            Dim mySize As Size = New Size(MyBase.Size.Width * zoom, MyBase.Size.Height * zoom)
            graphics.CopyFromScreen(MyBase.Location.X * zoom, MyBase.Location.Y * zoom, 0, 0, mySize, CopyPixelOperation.SourceCopy)
            'graphics.CopyFromScreen(MyBase.Location.X, MyBase.Location.Y , 0, 0, MyBase.Size, CopyPixelOperation.SourceCopy)

            'bitmap.Save("spls.bin", ImageFormat.Png) ’no need to save

            MyBase.BackgroundImage = bitmap
            MyBase.BackgroundImageLayout = ImageLayout.Stretch
            'Me.PictureBox1.Image = bitmap
            MyBase.Show()

        Catch ex As Exception

        End Try

    End Sub
End Class