<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myControlNewsFeeds
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myControlNewsFeeds))
        Me.PictureBoxPost = New System.Windows.Forms.PictureBox()
        Me.PictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        CType(Me.PictureBoxPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxPost
        '
        Me.PictureBoxPost.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBoxPost.Image = CType(resources.GetObject("PictureBoxPost.Image"), System.Drawing.Image)
        Me.PictureBoxPost.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxPost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxPost.Name = "PictureBoxPost"
        Me.PictureBoxPost.Size = New System.Drawing.Size(201, 218)
        Me.PictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPost.TabIndex = 0
        Me.PictureBoxPost.TabStop = False
        '
        'PictureBoxProfile
        '
        Me.PictureBoxProfile.Image = CType(resources.GetObject("PictureBoxProfile.Image"), System.Drawing.Image)
        Me.PictureBoxProfile.Location = New System.Drawing.Point(2, 223)
        Me.PictureBoxProfile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxProfile.Name = "PictureBoxProfile"
        Me.PictureBoxProfile.Size = New System.Drawing.Size(30, 32)
        Me.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProfile.TabIndex = 1
        Me.PictureBoxProfile.TabStop = False
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserName.ForeColor = System.Drawing.Color.Gray
        Me.LabelUserName.Location = New System.Drawing.Point(46, 223)
        Me.LabelUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(68, 19)
        Me.LabelUserName.TabIndex = 2
        Me.LabelUserName.Text = "First Last"
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.Silver
        Me.LabelTime.Location = New System.Drawing.Point(64, 240)
        Me.LabelTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(77, 16)
        Me.LabelTime.TabIndex = 3
        Me.LabelTime.Text = "3 Hours ago"
        '
        'myControlNewsFeeds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelUserName)
        Me.Controls.Add(Me.PictureBoxProfile)
        Me.Controls.Add(Me.PictureBoxPost)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "myControlNewsFeeds"
        Me.Size = New System.Drawing.Size(201, 267)
        CType(Me.PictureBoxPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxPost As PictureBox
    Friend WithEvents PictureBoxProfile As PictureBox
    Friend WithEvents LabelUserName As Label
    Friend WithEvents LabelTime As Label
End Class
