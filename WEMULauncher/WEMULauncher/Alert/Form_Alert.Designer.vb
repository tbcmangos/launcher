Imports System.Windows.Forms

Partial Class form_alert
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_alert))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label_message = New System.Windows.Forms.Label()
        Me.timeout = New System.Windows.Forms.Timer(Me.components)
        Me.timershow = New System.Windows.Forms.Timer(Me.components)
        Me.closealert = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.img_icon = New System.Windows.Forms.PictureBox()
        CType(Me.img_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "ok_96px.png")
        Me.imageList1.Images.SetKeyName(1, "attention_96px.png")
        Me.imageList1.Images.SetKeyName(2, "error.png")
        '
        'Label_message
        '
        Me.Label_message.AutoSize = True
        Me.Label_message.BackColor = System.Drawing.Color.Transparent
        Me.Label_message.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_message.ForeColor = System.Drawing.Color.White
        Me.Label_message.Location = New System.Drawing.Point(120, 42)
        Me.Label_message.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_message.Name = "Label_message"
        Me.Label_message.Size = New System.Drawing.Size(230, 30)
        Me.Label_message.TabIndex = 1
        Me.Label_message.Text = "Success message "
        '
        'timeout
        '
        Me.timeout.Enabled = True
        Me.timeout.Interval = 5000
        '
        'timershow
        '
        Me.timershow.Interval = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(507, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'img_icon
        '
        Me.img_icon.BackColor = System.Drawing.Color.Transparent
        Me.img_icon.Image = CType(resources.GetObject("img_icon.Image"), System.Drawing.Image)
        Me.img_icon.Location = New System.Drawing.Point(19, 14)
        Me.img_icon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.img_icon.Name = "img_icon"
        Me.img_icon.Size = New System.Drawing.Size(77, 81)
        Me.img_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_icon.TabIndex = 0
        Me.img_icon.TabStop = False
        '
        'form_alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(548, 108)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label_message)
        Me.Controls.Add(Me.img_icon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "form_alert"
        Me.Opacity = 0.95R
        Me.Text = "alert"
        Me.TopMost = True
        CType(Me.img_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Friend WithEvents Button1 As Button
    Friend WithEvents Label_message As System.Windows.Forms.Label
    Friend WithEvents img_icon As System.Windows.Forms.PictureBox
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList

    Friend WithEvents timeout As System.Windows.Forms.Timer
    Friend WithEvents timershow As System.Windows.Forms.Timer
    Friend WithEvents closealert As System.Windows.Forms.Timer
End Class
