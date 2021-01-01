<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class myRadio
    Inherits System.Windows.Forms.RadioButton


    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'myRadio
        '
        Me.FlatAppearance.BorderSize = 0
        Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ResumeLayout(False)

    End Sub


    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        Dim g As Graphics = pevent.Graphics
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        g.Clear(BackColor)
        Dim diameter As Integer = ClientRectangle.Height - 1
        Dim innerRect As RectangleF = New RectangleF(1.0F, 1.0F, diameter - 2, diameter - 2)
        g.FillEllipse(New SolidBrush(Color.White), innerRect)
        g.DrawEllipse(New Pen(SystemBrushes.Control), innerRect)
        Dim outerRect As Rectangle = New Rectangle(0, 0, diameter, diameter)
        g.DrawArc(New Pen(Color.White), outerRect, -45, 180)
        outerRect.Inflate(-1, -1)
        g.DrawArc(New Pen(SystemColors.ControlDarkDark, 2.0F), outerRect, 135, 180)
        g.DrawArc(New Pen(SystemColors.Control, 2.0F), outerRect, -45, 180)
        If Checked Then
            innerRect.Inflate(-3, -3)
            g.FillEllipse(New SolidBrush(Color.BlueViolet), innerRect)
        End If

        g.DrawString(Text, Font, New SolidBrush(ForeColor), diameter + 5, 1)
    End Sub

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by Refactoring Essentials.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================


End Class
