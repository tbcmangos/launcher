Imports System.Environment




Public Class myTextBox

    Private _DescriptionString As String = "Input Here"



    Public Property DescriptionString As String
        Get
            Return _DescriptionString
        End Get
        Set(value As String)
            _DescriptionString = value
        End Set
    End Property








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

