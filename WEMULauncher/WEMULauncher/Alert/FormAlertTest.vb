Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Partial Class FormAlertTest
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub bunifuFlatButton1_Click(sender As Object, e As EventArgs)
		form_alert.Show("Hello World", form_alert.AlertType.success)
	End Sub

	Private Sub bunifuFlatButton2_Click(sender As Object, e As EventArgs)
		form_alert.Show("Hello World", form_alert.AlertType.[error])
	End Sub

	Private Sub bunifuFlatButton4_Click(sender As Object, e As EventArgs)
		form_alert.Show("Hello World", form_alert.AlertType.info)
	End Sub

	Private Sub bunifuFlatButton3_Click(sender As Object, e As EventArgs)
		form_alert.Show("Hello World", form_alert.AlertType.warnig)
	End Sub


End Class
