Imports System.Runtime.InteropServices

Public Class TextOnGlass
#Region " Structures "
    Public Structure RECT
        Public Sub New(ByVal tLeft As Integer, ByVal tTop As Integer, ByVal tRight As Integer, ByVal tBottom As Integer)
            Left = tLeft
            Top = tTop
            Right = tRight
            Bottom = tBottom
        End Sub
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
    Public Structure BITMAPINFOHEADER
        Dim biSize As Integer
        Dim biWidth As Integer
        Dim biHeight As Integer
        Dim biPlanes As Short
        Dim biBitCount As Short
        Dim biCompression As Integer
        Dim biSizeImage As Integer
        Dim biXPelsPerMeter As Integer
        Dim biYPelsPerMeter As Integer
        Dim biClrUsed As Integer
        Dim biClrImportant As Integer
    End Structure
    Public Structure RGBQUAD
        Dim rgbBlue As Byte
        Dim rgbGreen As Byte
        Dim rgbRed As Byte
        Dim rgbReserved As Byte
    End Structure
    Public Structure BITMAPINFO
        Dim bmiHeader As BITMAPINFOHEADER
        Dim bmiColors As RGBQUAD
    End Structure
    Public Structure S_DTTOPTS
        Dim dwSize As Integer
        Dim dwFlags As Integer
        Dim crText As Integer
        Dim crBorder As Integer
        Dim crShadow As Integer
        Dim iTextShadowType As Integer
        Dim ptShadowOffset As Point
        Dim iBorderSize As Integer
        Dim iFontPropId As Integer
        Dim iColorPropId As Integer
        Dim iStateId As Integer
        Dim fApplyOverlay As Boolean
        Dim iGlowSize As Integer
        Dim pfnDrawTextCallback As Integer
        Dim lParam As IntPtr
    End Structure
#End Region

#Region " Constants "
    Private Const DTT_COMPOSITED As Integer = 8192
    Private Const DTT_GLOWSIZE As Integer = 2048
    Private Const DTT_TEXTCOLOR As Integer = 1
#End Region

#Region " Declares "

    Public Declare Function CreateDIBSection Lib "gdi32.dll" (ByVal hdc As IntPtr, ByRef pbmi As BITMAPINFO, ByVal iUsage As UInt32, ByVal ppvBits As Integer, ByVal hSection As IntPtr, ByVal dwOffset As UInt32) As IntPtr
    Public Declare Function BitBlt Lib "gdi32.dll" (ByVal hdc As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Int32) As Boolean

    Public Declare Function SelectObject Lib "gdi32.dll" (ByVal hDC As IntPtr, ByVal hObject As IntPtr) As IntPtr
    Public Declare Function DeleteObject Lib "gdi32.dll" (ByVal hObject As IntPtr) As Boolean
    Public Declare Function CreateCompatibleDC Lib "gdi32.dll" (ByVal hDC As IntPtr) As IntPtr
    Public Declare Function DeleteDC Lib "gdi32.dll" (ByVal hdc As IntPtr) As Boolean

    Public Shared Function GetDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    Public Declare Unicode Function DrawThemeTextEx Lib "UxTheme.dll" (ByVal hTheme As IntPtr, ByVal hdc As IntPtr, ByVal iPartId As Integer, ByVal iStateId As Integer, ByVal text As String, ByVal iCharCount As Integer, ByVal dwFlags As Integer, ByRef pRect As RECT, ByRef pOptions As S_DTTOPTS) As Integer

#End Region


    Public Shared Sub DrawGlowingText(ByVal Graphics As Graphics, ByVal text As String, ByVal fnt As Font, ByVal bounds As Rectangle, ByVal Clr As Color, ByVal GlowSize As Integer, ByVal flags As TextFormatFlags)
        Dim primaryHdc As IntPtr = Graphics.GetHdc


        Dim bitmapOld As IntPtr = IntPtr.Zero
        Dim hfontOld As IntPtr = IntPtr.Zero

        '' Create a memory DC so we can work offscreen
        Dim memoryHdc As IntPtr = CreateCompatibleDC(primaryHdc)



        Dim textBounds As RECT
        Dim screenBounds As RECT

        screenBounds = New RECT()
        screenBounds.Top = bounds.Top - GlowSize
        screenBounds.Left = bounds.Left - GlowSize
        screenBounds.Right = bounds.Right + GlowSize
        screenBounds.Bottom = bounds.Bottom + GlowSize


        textBounds = New RECT(GlowSize, GlowSize, screenBounds.Right - screenBounds.Left - GlowSize, screenBounds.Bottom - screenBounds.Top - GlowSize)

        '' Create a device-independent bitmap and select it into our DC
        Dim info As BITMAPINFO = New BITMAPINFO
        info.bmiHeader.biSize = Marshal.SizeOf(info.bmiHeader)
        info.bmiHeader.biWidth = screenBounds.Right - screenBounds.Left 'bounds.Width '+ 30
        info.bmiHeader.biHeight = -screenBounds.Bottom - screenBounds.Top '- bounds.Height '- 30
        info.bmiHeader.biPlanes = 1
        info.bmiHeader.biBitCount = 32
        info.bmiHeader.biCompression = 0 '' BI_RGB
        Dim dib As IntPtr = CreateDIBSection(primaryHdc, info, 0, 0, IntPtr.Zero, 0)
        bitmapOld = SelectObject(memoryHdc, dib)
        Dim fontHandle As IntPtr = fnt.ToHfont
        hfontOld = SelectObject(memoryHdc, fontHandle)
        Dim renderer As System.Windows.Forms.VisualStyles.VisualStyleRenderer = New System.Windows.Forms.VisualStyles.VisualStyleRenderer(System.Windows.Forms.VisualStyles.VisualStyleElement.Window.Caption.Active)

        Dim dttOpts As S_DTTOPTS = New S_DTTOPTS
        dttOpts.dwSize = Marshal.SizeOf(dttOpts)
        dttOpts.dwFlags = DTT_COMPOSITED Or DTT_GLOWSIZE Or DTT_TEXTCOLOR
        dttOpts.crText = ColorTranslator.ToWin32(Clr)
        dttOpts.iGlowSize = GlowSize '' Microsoft Word 2007 uses 15
        DrawThemeTextEx(renderer.Handle, memoryHdc, 0, 0, text, -1, flags, textBounds, dttOpts)
        Dim SRCCOPY As Integer = &HCC0020 ' old C# Value was: 0x00CC0020
        BitBlt(primaryHdc, screenBounds.Left, screenBounds.Top, screenBounds.Right - screenBounds.Left, screenBounds.Bottom - screenBounds.Top, memoryHdc, 0, 0, SRCCOPY)
        SelectObject(memoryHdc, bitmapOld)
        SelectObject(memoryHdc, hfontOld)
        DeleteObject(fontHandle)
        DeleteObject(dib)
        DeleteDC(memoryHdc)

        Graphics.ReleaseHdc(primaryHdc)
    End Sub

End Class
