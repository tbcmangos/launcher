Imports System.Threading

Module Program
    Public Sub Main()
        Dim isNotRunning As Boolean
        Dim mutex As New Mutex(True, "NameOfMutex", isNotRunning)
        If isNotRunning Then
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainForm2())
            mutex.ReleaseMutex()
        Else
            Dim num2 As Integer = CInt(MessageBox.Show("进程已经存在，无法再次启动", "WEMULauncher", MessageBoxButtons.OK, MessageBoxIcon.Hand))
        End If
    End Sub
End Module
