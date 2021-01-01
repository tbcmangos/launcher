
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing.Imaging

Namespace ZBobb

    Public Class AlphaBlendTextBox
        Inherits System.Windows.Forms.TextBox

        Private myPictureBox As uPictureBox

        Private myUpToDate As Boolean = False

        Private myCaretUpToDate As Boolean = False

        Private myBitmap As Bitmap

        Private myAlphaBitmap As Bitmap

        Private myFontHeight As Integer = 10

        Private myTimer1 As System.Windows.Forms.Timer

        Private myCaretState As Boolean = True

        Private myPaintedFirstTime As Boolean = False

        Private myBackColor As Color = Color.White

        Private myBackAlpha As Integer = 10

        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            InitializeComponent()
            Me.BackColor = myBackColor
            Me.SetStyle(ControlStyles.UserPaint, False)
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.DoubleBuffer, True)
            myPictureBox = New uPictureBox()
            Me.Controls.Add(myPictureBox)
            myPictureBox.Dock = DockStyle.Fill
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Me.myBitmap = New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
            Me.myAlphaBitmap = New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
            myUpToDate = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            MyBase.OnKeyDown(e)
            myUpToDate = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnKeyUp(ByVal e As KeyEventArgs)
            MyBase.OnKeyUp(e)
            myUpToDate = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
            MyBase.OnKeyPress(e)
            myUpToDate = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnGiveFeedback(ByVal gfbevent As GiveFeedbackEventArgs)
            MyBase.OnGiveFeedback(gfbevent)
            myUpToDate = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            Dim ptCursor As Point = Cursor.Position
            Dim f As Form = Me.FindForm()
            ptCursor = f.PointToClient(ptCursor)
            If Not Me.Bounds.Contains(ptCursor) Then MyBase.OnMouseLeave(e)
        End Sub

        Protected Overrides Sub OnChangeUICues(ByVal e As UICuesEventArgs)
            MyBase.OnChangeUICues(e)
            myUpToDate = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnGotFocus(ByVal e As EventArgs)
            MyBase.OnGotFocus(e)
            myCaretUpToDate = False
            myUpToDate = False
            Me.Invalidate()
            myTimer1 = New System.Windows.Forms.Timer(Me.components)
            myTimer1.Interval = CInt(win32.GetCaretBlinkTime())
            AddHandler myTimer1.Tick, AddressOf myTimer1_Tick
            myTimer1.Enabled = True
        End Sub

        Protected Overrides Sub OnLostFocus(ByVal e As EventArgs)
            MyBase.OnLostFocus(e)
            myCaretUpToDate = False
            myUpToDate = False
            Me.Invalidate()
            myTimer1.Dispose()
        End Sub

        Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
            If Me.myPaintedFirstTime Then Me.SetStyle(ControlStyles.UserPaint, False)
            MyBase.OnFontChanged(e)
            If Me.myPaintedFirstTime Then Me.SetStyle(ControlStyles.UserPaint, True)
            myFontHeight = GetFontHeight()
            myUpToDate = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
            MyBase.OnTextChanged(e)
            myUpToDate = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)
            If m.Msg = win32.WM_PAINT Then
                myPaintedFirstTime = True
                If Not myUpToDate OrElse Not myCaretUpToDate Then GetBitmaps()
                myUpToDate = True
                myCaretUpToDate = True
                If myPictureBox.Image IsNot Nothing Then myPictureBox.Image.Dispose()
                myPictureBox.Image = CType(myAlphaBitmap.Clone(), Image)
            ElseIf m.Msg = win32.WM_HSCROLL OrElse m.Msg = win32.WM_VSCROLL Then
                myUpToDate = False
                Me.Invalidate()
            ElseIf m.Msg = win32.WM_LBUTTONDOWN OrElse m.Msg = win32.WM_RBUTTONDOWN OrElse m.Msg = win32.WM_LBUTTONDBLCLK Then
                myUpToDate = False
                Me.Invalidate()
            ElseIf m.Msg = win32.WM_MOUSEMOVE Then
                If m.WParam.ToInt32() <> 0 Then
                    myUpToDate = False
                    Me.Invalidate()
                End If
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Public Shadows Property BorderStyle As BorderStyle
            Get
                Return MyBase.BorderStyle
            End Get

            Set(ByVal value As BorderStyle)
                If Me.myPaintedFirstTime Then Me.SetStyle(ControlStyles.UserPaint, False)
                MyBase.BorderStyle = value
                If Me.myPaintedFirstTime Then Me.SetStyle(ControlStyles.UserPaint, True)
                Me.myBitmap = Nothing
                Me.myAlphaBitmap = Nothing
                myUpToDate = False
                Me.Invalidate()
            End Set
        End Property

        Public Shadows Property BackColor As Color
            Get
                Return Color.FromArgb(MyBase.BackColor.R, MyBase.BackColor.G, MyBase.BackColor.B)
            End Get

            Set(ByVal value As Color)
                myBackColor = value
                MyBase.BackColor = value
                myUpToDate = False
            End Set
        End Property

        Public Overrides Property Multiline As Boolean
            Get
                Return MyBase.Multiline
            End Get

            Set(ByVal value As Boolean)
                If Me.myPaintedFirstTime Then Me.SetStyle(ControlStyles.UserPaint, False)
                MyBase.Multiline = value
                If Me.myPaintedFirstTime Then Me.SetStyle(ControlStyles.UserPaint, True)
                Me.myBitmap = Nothing
                Me.myAlphaBitmap = Nothing
                myUpToDate = False
                Me.Invalidate()
            End Set
        End Property

        Private Function GetFontHeight() As Integer
            Dim g As Graphics = Me.CreateGraphics()
            Dim sf_font As SizeF = g.MeasureString("X", Me.Font)
            g.Dispose()
            Return CInt(sf_font.Height)
        End Function

        Private Sub GetBitmaps()
            If myBitmap Is Nothing OrElse myAlphaBitmap Is Nothing OrElse myBitmap.Width <> Width OrElse myBitmap.Height <> Height OrElse myAlphaBitmap.Width <> Width OrElse myAlphaBitmap.Height <> Height Then
                myBitmap = Nothing
                myAlphaBitmap = Nothing
            End If

            If myBitmap Is Nothing Then
                myBitmap = New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
                myUpToDate = False
            End If

            If Not myUpToDate Then
                Me.SetStyle(ControlStyles.UserPaint, False)
                win32.CaptureWindow(Me, myBitmap)
                Me.SetStyle(ControlStyles.UserPaint, True)
                Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
                Me.BackColor = Color.FromArgb(myBackAlpha, myBackColor)
            End If

            Dim r2 As Rectangle = New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height)
            Dim tempImageAttr As ImageAttributes = New ImageAttributes()
            Dim tempColorMap As ColorMap() = New ColorMap(0) {}
            tempColorMap(0) = New ColorMap()
            tempColorMap(0).OldColor = Color.FromArgb(255, myBackColor)
            tempColorMap(0).NewColor = Color.FromArgb(myBackAlpha, myBackColor)
            tempImageAttr.SetRemapTable(tempColorMap)
            If myAlphaBitmap IsNot Nothing Then myAlphaBitmap.Dispose()
            myAlphaBitmap = New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
            Dim tempGraphics1 As Graphics = Graphics.FromImage(myAlphaBitmap)
            tempGraphics1.DrawImage(myBitmap, r2, 0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height, GraphicsUnit.Pixel, tempImageAttr)
            tempGraphics1.Dispose()
            If Me.Focused AndAlso (Me.SelectionLength = 0) Then
                Dim tempGraphics2 As Graphics = Graphics.FromImage(myAlphaBitmap)
                If myCaretState Then
                    Dim caret As Point = Me.findCaret()
                    Dim p As Pen = New Pen(Me.ForeColor, 3)
                    tempGraphics2.DrawLine(p, caret.X, caret.Y + 0, caret.X, caret.Y + myFontHeight)
                    tempGraphics2.Dispose()
                End If
            End If
        End Sub

        Private Function findCaret() As Point
            Dim pointCaret As Point = New Point(0)
            Dim i_char_loc As Integer = Me.SelectionStart
            Dim pi_char_loc As IntPtr = New IntPtr(i_char_loc)
            Dim i_point As Integer = win32.SendMessage(Me.Handle, win32.EM_POSFROMCHAR, pi_char_loc, IntPtr.Zero)
            pointCaret = New Point(i_point)
            If i_char_loc = 0 Then
                pointCaret = New Point(0)
            ElseIf i_char_loc >= Me.Text.Length Then
                pi_char_loc = New IntPtr(i_char_loc - 1)
                i_point = win32.SendMessage(Me.Handle, win32.EM_POSFROMCHAR, pi_char_loc, IntPtr.Zero)
                pointCaret = New Point(i_point)
                Dim g As Graphics = Me.CreateGraphics()
                Dim t1 As String = Me.Text.Substring(Me.Text.Length - 1, 1) & "X"
                Dim sizet1 As SizeF = g.MeasureString(t1, Me.Font)
                Dim sizex As SizeF = g.MeasureString("X", Me.Font)
                g.Dispose()
                Dim xoffset As Integer = CInt((sizet1.Width - sizex.Width))
                pointCaret.X = pointCaret.X + xoffset
                If i_char_loc = Me.Text.Length Then
                    Dim slast As String = Me.Text.Substring(Text.Length - 1, 1)
                    If slast = vbLf Then
                        pointCaret.X = 1
                        pointCaret.Y = pointCaret.Y + myFontHeight
                    End If
                End If
            End If

            Return pointCaret
        End Function

        Private Sub myTimer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            myCaretState = Not myCaretState
            myCaretUpToDate = False
            Me.Invalidate()
        End Sub

        Private Class uPictureBox
            Inherits PictureBox

            Public Sub New()
                Me.SetStyle(ControlStyles.Selectable, False)
                Me.SetStyle(ControlStyles.UserPaint, True)
                Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
                Me.SetStyle(ControlStyles.DoubleBuffer, True)
                Me.Cursor = Nothing
                Me.Enabled = True
                Me.SizeMode = PictureBoxSizeMode.Normal
            End Sub

            Protected Overrides Sub WndProc(ByRef m As Message)
                If m.Msg = win32.WM_LBUTTONDOWN OrElse m.Msg = win32.WM_RBUTTONDOWN OrElse m.Msg = win32.WM_LBUTTONDBLCLK OrElse m.Msg = win32.WM_MOUSELEAVE OrElse m.Msg = win32.WM_MOUSEMOVE Then
                    win32.PostMessage(Me.Parent.Handle, CUInt(m.Msg), m.WParam, m.LParam)
                ElseIf m.Msg = win32.WM_LBUTTONUP Then
                    Me.Parent.Invalidate()
                End If

                MyBase.WndProc(m)
            End Sub
        End Class

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
        End Sub

        <Category("Appearance"), Description("The alpha value used to blend the control's background. Valid values are 0 through 255."), Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property BackAlpha As Integer
            Get
                Return myBackAlpha
            End Get

            Set(ByVal value As Integer)
                Dim v As Integer = value
                If v > 255 Then v = 255
                myBackAlpha = v
                myUpToDate = False
                Invalidate()
            End Set
        End Property
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
