
Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing

Namespace ZBobb
    ''' <summary>
    ''' Win32 support code.
    ''' (C) 2003 Bob Bradley / ZBobb@hotmail.com
    ''' https://www.codeproject.com/Articles/4390/AlphaBlendTextBox-A-transparent-translucent-textbo
    '''</summary>
    Public Class win32

        Public Const WM_MOUSEMOVE As Integer = 512

        Public Const WM_LBUTTONDOWN As Integer = 513

        Public Const WM_LBUTTONUP As Integer = 514

        Public Const WM_RBUTTONDOWN As Integer = 516

        Public Const WM_LBUTTONDBLCLK As Integer = 515

        Public Const WM_MOUSELEAVE As Integer = 675

        Public Const WM_PAINT As Integer = 15

        Public Const WM_ERASEBKGND As Integer = 20

        Public Const WM_PRINT As Integer = 791

        Public Const WM_HSCROLL As Integer = 276

        Public Const WM_VSCROLL As Integer = 277

        Public Const EM_GETSEL As Integer = 176

        Public Const EM_LINEINDEX As Integer = 187

        Public Const EM_LINEFROMCHAR As Integer = 201

        Public Const EM_POSFROMCHAR As Integer = 214

        <DllImport("USER32.DLL", EntryPoint:="PostMessage")>
        Public Shared Function PostMessage(ByVal hwnd As IntPtr, ByVal msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
        End Function

        <DllImport("USER32.DLL", EntryPoint:="SendMessage")>
        Public Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        End Function

        <DllImport("USER32.DLL", EntryPoint:="GetCaretBlinkTime")>
        Public Shared Function GetCaretBlinkTime() As UInteger
        End Function

        Const WM_PRINTCLIENT As Integer = 792

        Const PRF_CHECKVISIBLE As Long = 1L

        Const PRF_NONCLIENT As Long = 2L

        Const PRF_CLIENT As Long = 4L

        Const PRF_ERASEBKGND As Long = 8L

        Const PRF_CHILDREN As Long = 16L

        Const PRF_OWNED As Long = 32L

        Public Shared Function CaptureWindow(ByVal control As System.Windows.Forms.Control, ByRef bitmap As System.Drawing.Bitmap) As Boolean
            Dim g2 As Graphics = Graphics.FromImage(bitmap)
            Dim meint As Integer = CInt((PRF_CLIENT Or PRF_ERASEBKGND))
            Dim meptr As System.IntPtr = New System.IntPtr(meint)
            Dim hdc As System.IntPtr = g2.GetHdc()
            win32.SendMessage(control.Handle, win32.WM_PRINT, hdc, meptr)
            g2.ReleaseHdc(hdc)
            g2.Dispose()
            Return True
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
