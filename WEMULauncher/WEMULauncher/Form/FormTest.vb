Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Public Class FormTest
    <StructLayout(LayoutKind.Sequential)> Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyButtomheight As Integer
    End Structure

    Public fontfamily As New FontFamily("黑体")
    Public myfont As New Font(fontfamily, 50, FontStyle.Bold, GraphicsUnit.Pixel)
    Public oFormPath As GraphicsPath
    Private oOriginalRegion As Region = Nothing
    Private bFormDragging As Boolean = False
    Private oPointClicked As Point
    <DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function

    Private Sub form1_paint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackColor = Color.Black
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = -1
        margins.cxRightWidth = -1
        margins.cyTopHeight = -1
        margins.cyButtomheight = -1
        Dim hwnd As IntPtr = Me.Handle
        DwmExtendFrameIntoClientArea(hwnd, margins)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextOnGlass.DrawGlowingText(Me.CreateGraphics, CStr(TimeOfDay), myfont, New Rectangle(5, 5, 300, 100), Color.Black, 20, TextFormatFlags.Default)
    End Sub
    Private Sub Form1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Me.Close()
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.bFormDragging = True
        Me.oPointClicked = New Point(e.X, e.Y)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Me.bFormDragging Then
            Dim oMoveToPoint As Point
            oMoveToPoint = Me.PointToScreen(New Point(e.X, e.Y))
            oMoveToPoint.Offset(Me.oPointClicked.X * -1,
            (Me.oPointClicked.Y +
            SystemInformation.CaptionHeight +
            SystemInformation.BorderSize.Height) * -1)
            Me.Location = oMoveToPoint
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.bFormDragging = False

    End Sub

End Class