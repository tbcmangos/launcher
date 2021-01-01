Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Partial Class form_alert
	Inherits Form
	Public Sub New(_message As String, type As AlertType)
		InitializeComponent()
		Label_message.Text = _message
		Select Case type
			Case AlertType.success
				Me.BackColor = Color.SeaGreen
				img_icon.Image = imageList1.Images(0)
				Exit Select
			Case AlertType.info
				Me.BackColor = Color.Gray
				img_icon.Image = imageList1.Images(1)
				Exit Select
			Case AlertType.warnig
				Me.BackColor = Color.Crimson
				img_icon.Image = imageList1.Images(1)
				Exit Select
			Case AlertType.[error]
				Me.BackColor = Color.FromArgb(255, 128, 0)
				img_icon.Image = imageList1.Images(2)
				Exit Select

		End Select
	End Sub


    ''' <summary>
    ''' Alerts the specified message.
    ''' </summary>
    ''' <param name="_message">The message.</param>
    ''' <param name="type">The type.</param>
    Public Overloads Shared Sub Show(message As String, type As AlertType)
        Dim al As New form_alert(message, type)
        al.Show()


    End Sub

    Private Sub alert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set position to top left...
        Me.Top = -1 * (Me.Height)
        Me.Left = Screen.PrimaryScreen.Bounds.Width - Me.Width - 60

        timershow.Start()
    End Sub




    Public Enum AlertType
        success
        info
        warnig
        [error]
    End Enum

    Private Sub bunifuImageButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        closealert.Start()
    End Sub

    Private Sub timeout_Tick(sender As Object, e As EventArgs) Handles timeout.Tick
        closealert.Start()
    End Sub


    Private interval As Integer = 0

    'timershow transition
    Private Sub show_Tick(sender As Object, e As EventArgs) Handles timershow.Tick
        If Me.Top < 60 Then
            Me.Top += interval
            ' drop the alert
            ' double the speed
            interval += 2
        Else
            timershow.[Stop]()
        End If
    End Sub

    Private Sub close_Tick(sender As Object, e As EventArgs) Handles closealert.Tick
        If Me.Opacity > 0 Then
            'reduce opacity to zero
            Me.Opacity -= 0.2
        Else
            'then close
            Me.Close()
        End If

    End Sub

End Class




