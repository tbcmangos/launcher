<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myFolderSelection
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myFolderSelection))
        Me.txtSelected = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FBD_Output = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblWaterMark = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSelected
        '
        Me.txtSelected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelected.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelected.Location = New System.Drawing.Point(0, 3)
        Me.txtSelected.Name = "txtSelected"
        Me.txtSelected.Size = New System.Drawing.Size(251, 38)
        Me.txtSelected.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Add Folder_40px.png")
        Me.ImageList1.Images.SetKeyName(1, "Open_40px.png")
        '
        'lblWaterMark
        '
        Me.lblWaterMark.AutoSize = True
        Me.lblWaterMark.Location = New System.Drawing.Point(18, 5)
        Me.lblWaterMark.Name = "lblWaterMark"
        Me.lblWaterMark.Size = New System.Drawing.Size(51, 17)
        Me.lblWaterMark.TabIndex = 2
        Me.lblWaterMark.Text = "Label1"
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.ImageIndex = 0
        Me.btnSelect.ImageList = Me.ImageList1
        Me.btnSelect.Location = New System.Drawing.Point(257, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(49, 38)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'myFolderSelection
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblWaterMark)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtSelected)
        Me.Name = "myFolderSelection"
        Me.Size = New System.Drawing.Size(306, 38)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSelected As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FBD_Output As FolderBrowserDialog
    Friend WithEvents lblWaterMark As Label
End Class
