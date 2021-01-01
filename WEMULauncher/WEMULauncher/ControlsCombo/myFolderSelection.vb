Imports System.Environment

Public Class myFolderSelection
    Private _DescriptionString As String = "Select Folder"
    Private _BaseFolder As SpecialFolder = Environment.SpecialFolder.Desktop
    '注册事件
    Public Event UserControlFolderSelected(ByVal txt As String)


    Public Property DescriptionString As String
        Get
            Return _DescriptionString
        End Get
        Set(value As String)
            _DescriptionString = value
        End Set
    End Property

    Public Property BaseFolder As SpecialFolder
        Get
            Return _BaseFolder
        End Get
        Set(value As SpecialFolder)
            _BaseFolder = value
        End Set
    End Property

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnSelect.MouseHover
        btnSelect.ImageIndex = 1
    End Sub

    Private Sub btnSelect_MouseLeave(sender As Object, e As EventArgs) Handles btnSelect.MouseLeave
        btnSelect.ImageIndex = 0
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            FBD_Output.RootFolder = _BaseFolder

            ' set the initial path for the directory, if the user puts something in the text box 
            If Len(txtSelected.Text.ToString) > 3 And IO.Directory.Exists(txtSelected.Text.ToString) Then
                FBD_Output.SelectedPath = System.IO.Path.GetDirectoryName(txtSelected.Text.ToString & "\")
            Else
                FBD_Output.SelectedPath = System.IO.Path.GetDirectoryName(Environment.SpecialFolder.Desktop)
            End If
            'launch the browser window
            FBD_Output.Description = _DescriptionString
            If FBD_Output.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtSelected.Text = FBD_Output.SelectedPath.ToString
                txtSelected.BackColor = Color.LawnGreen
                btnSelect.BackColor = Color.LawnGreen
                RaiseEvent UserControlFolderSelected(txtSelected.Text)
            Else
                MsgBox("Wrong folder")
                txtSelected.Text = ""
                txtSelected.BackColor = Color.OrangeRed
                btnSelect.BackColor = Color.OrangeRed
            End If
            'end of updated section

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub myFolderSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWaterMark.Font = txtSelected.Font
        lblWaterMark.BackColor = txtSelected.BackColor
        lblWaterMark.Text = _DescriptionString
        lblWaterMark.Enabled = False
    End Sub


    Private Sub txtSelected_MouseHover(sender As Object, e As EventArgs) Handles txtSelected.MouseHover
        lblWaterMark.Visible = False

    End Sub

    Private Sub txtSelected_MouseLeave(sender As Object, e As EventArgs) Handles txtSelected.MouseLeave
        If txtSelected.Text <> "" Then
            lblWaterMark.Visible = False
        Else
            lblWaterMark.Visible = True
        End If
    End Sub

    '当文本改变时启动事件
    Private Sub txtSelected_TextChanged(sender As Object, e As EventArgs) Handles txtSelected.TextChanged
        If txtSelected.Text <> "" Then
            lblWaterMark.Visible = False
        Else
            lblWaterMark.Visible = True
        End If

    End Sub

End Class
