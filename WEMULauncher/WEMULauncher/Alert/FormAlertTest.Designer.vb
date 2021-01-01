Imports System.Windows.Forms

Partial Class FormAlertTest
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.bunifuCustomLabel1 = New System.Windows.Forms.Label()
        Me.bunifuFlatButton1 = New System.Windows.Forms.Button()
        Me.bunifuFlatButton2 = New System.Windows.Forms.Button()
        Me.bunifuFlatButton3 = New System.Windows.Forms.Button()
        Me.bunifuFlatButton4 = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.MediumVioletRed
        Me.panel1.Controls.Add(Me.bunifuCustomLabel1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(939, 75)
        Me.panel1.TabIndex = 0
        '
        'bunifuCustomLabel1
        '
        Me.bunifuCustomLabel1.AutoSize = True
        Me.bunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.bunifuCustomLabel1.Location = New System.Drawing.Point(37, 21)
        Me.bunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bunifuCustomLabel1.Name = "bunifuCustomLabel1"
        Me.bunifuCustomLabel1.Size = New System.Drawing.Size(357, 31)
        Me.bunifuCustomLabel1.TabIndex = 0
        Me.bunifuCustomLabel1.Text = "Custom Alerts / Notifications"
        '
        'bunifuFlatButton1
        '
        Me.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuFlatButton1.Location = New System.Drawing.Point(136, 150)
        Me.bunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bunifuFlatButton1.Name = "bunifuFlatButton1"
        Me.bunifuFlatButton1.Size = New System.Drawing.Size(268, 55)
        Me.bunifuFlatButton1.TabIndex = 1
        Me.bunifuFlatButton1.Text = "SUCCESS"
        Me.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton1.UseVisualStyleBackColor = False
        '
        'bunifuFlatButton2
        '
        Me.bunifuFlatButton2.BackColor = System.Drawing.Color.Crimson
        Me.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuFlatButton2.Location = New System.Drawing.Point(491, 150)
        Me.bunifuFlatButton2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bunifuFlatButton2.Name = "bunifuFlatButton2"
        Me.bunifuFlatButton2.Size = New System.Drawing.Size(268, 55)
        Me.bunifuFlatButton2.TabIndex = 2
        Me.bunifuFlatButton2.Text = "ERROR"
        Me.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton2.UseVisualStyleBackColor = False
        '
        'bunifuFlatButton3
        '
        Me.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuFlatButton3.Location = New System.Drawing.Point(491, 276)
        Me.bunifuFlatButton3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bunifuFlatButton3.Name = "bunifuFlatButton3"
        Me.bunifuFlatButton3.Size = New System.Drawing.Size(268, 55)
        Me.bunifuFlatButton3.TabIndex = 4
        Me.bunifuFlatButton3.Text = "WARNING"
        Me.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton3.UseVisualStyleBackColor = False
        '
        'bunifuFlatButton4
        '
        Me.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuFlatButton4.Location = New System.Drawing.Point(136, 276)
        Me.bunifuFlatButton4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bunifuFlatButton4.Name = "bunifuFlatButton4"
        Me.bunifuFlatButton4.Size = New System.Drawing.Size(268, 55)
        Me.bunifuFlatButton4.TabIndex = 3
        Me.bunifuFlatButton4.Text = "INFO"
        Me.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton4.UseVisualStyleBackColor = False
        '
        'FormAlertTest
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(939, 417)
        Me.Controls.Add(Me.bunifuFlatButton3)
        Me.Controls.Add(Me.bunifuFlatButton4)
        Me.Controls.Add(Me.bunifuFlatButton2)
        Me.Controls.Add(Me.bunifuFlatButton1)
        Me.Controls.Add(Me.panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormAlertTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private panel1 As System.Windows.Forms.Panel
    Friend WithEvents bunifuCustomLabel1 As Label
    Friend WithEvents bunifuFlatButton1 As Button
    Friend WithEvents bunifuFlatButton2 As Button
    Friend WithEvents bunifuFlatButton3 As Button
    Friend WithEvents bunifuFlatButton4 As Button
End Class

