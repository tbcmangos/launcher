Imports System.Environment




Public Class myFileSelection
    Private _DescriptionString As String = "Select File"
    Private _FileNameString As String = "Select a File"
    Private _FileFilter As String = "CSV Files (*.csv)|*.csv"
    Private _BaseFolder As SpecialFolder = Environment.SpecialFolder.Desktop

    '注册事件
    Public Event UserControlFileSelected(ByVal txt As String)


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
    Public Property FileFilter As String
        Get
            Return _FileFilter
        End Get
        Set(value As String)
            _FileFilter = value
        End Set
    End Property
    Public Property FileNameString As String
        Get
            Return _FileNameString
        End Get
        Set(value As String)
            _FileNameString = value
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

            OpenDialog(_FileFilter, _DescriptionString)


            If IO.File.Exists(OFD_Input.FileName.ToString) Then

                txtSelected.Text = OFD_Input.FileName.ToString
                txtSelected.BackColor = Color.LawnGreen
                btnSelect.BackColor = Color.LawnGreen
                RaiseEvent UserControlFileSelected(txtSelected.Text)
            Else
                MsgBox("Wrong file")
                txtSelected.Text = ""
                txtSelected.BackColor = Color.OrangeRed
                btnSelect.BackColor = Color.OrangeRed
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OpenDialog(ByVal strFileExt As String, ByVal strHeader As String)
        Try
            OFD_Input.InitialDirectory = _BaseFolder
            OFD_Input.Filter = strFileExt
            OFD_Input.FileName = _FileNameString 'name shown in the file browser dialog
            OFD_Input.Title = strHeader 'title of the file browser 
            OFD_Input.ShowDialog()
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

