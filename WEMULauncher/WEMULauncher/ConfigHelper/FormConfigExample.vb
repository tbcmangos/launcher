Public Class FormConfigExample
    Private configHelper As ConfigHelper
    Private dictConfig As Dictionary(Of String, ConfigLine)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadConfig()
        'MsgBox(dictConfig(mapKey1).ConfigVALUE)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'write
        configHelper.SaveConfigFromDictToFile()

        'refresh
        ReadConfig()
    End Sub


End Class
