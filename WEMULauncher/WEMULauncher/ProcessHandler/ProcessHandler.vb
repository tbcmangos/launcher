
'ProcessHandler
'Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
' MVID: 89D8A743-96E1-468B-9DFF-49BD4C5C28BB


Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms

Namespace WEMUTool
    Friend Class ProcessHandler

        Private authProcess As Process
        Private worldProcess As Process
        Private mysqlProcess As Process
        Private mysqladmin As Process
        Private siteProcess As Process

        Public Function PortIsInUse(port As Integer) As Boolean
            For Each activeTcpListener As IPEndPoint In IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners()
                If activeTcpListener.Port = port Then
                    Return True
                End If
            Next
            Return False
        End Function

#Region "WebServerConfig"

        Private Function UpdateSitePHP() As Boolean
            Dim strROOT As String = Environment.CurrentDirectory & "\website"

            '////////////////CONFIG php.ini inside php5 folder
            If Not File.Exists(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHP5TEMPLATE)) Then
                MessageBox.Show(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHP5TEMPLATE) & "文件不存在，无法启动Website", "WebSite站点启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return False
            Else

                'read from file
                Dim srPHP5 As StreamReader = New StreamReader(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHP5TEMPLATE), System.Text.Encoding.UTF8)
                Dim strContentPHP5 As String = srPHP5.ReadToEnd
                srPHP5.Close()
                srPHP5 = Nothing

                Dim strPhp5Template As String = strContentPHP5.Replace("{$PORTABLEROOT}", strROOT)

                'save to
                Dim strFilePathPHP5ini As String = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHP5TEMPLATE_COYPTO)
                Dim swPHP5ini As StreamWriter = New StreamWriter(strFilePathPHP5ini, False, System.Text.Encoding.UTF8) 'true is append method
                swPHP5ini.WriteLine(strPhp5Template)
                swPHP5ini.Close()
                swPHP5ini = Nothing
            End If

            '////////////////CONFIG php.ini inside php7 folder
            If Not File.Exists(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHP7TEMPLATE)) Then
                MessageBox.Show(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHP7TEMPLATE) & "文件不存在，无法启动Website", "WebSite站点启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return False
            Else
                'read from file
                Dim srPHP7 As StreamReader = New StreamReader(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHP7TEMPLATE), System.Text.Encoding.UTF8)
                Dim strContentPHP7 As String = srPHP7.ReadToEnd
                srPHP7.Close()
                srPHP7 = Nothing

                Dim strPhp7Template As String = strContentPHP7.Replace("{$PORTABLEROOT}", strROOT)

                'save to
                Dim strFilePathPHP7ini As String = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHP7TEMPLATE_COYPTO)
                Dim swPHP7ini As StreamWriter = New StreamWriter(strFilePathPHP7ini, False, System.Text.Encoding.UTF8) 'true is append method
                swPHP7ini.WriteLine(strPhp7Template)
                swPHP7ini.Close()
                swPHP7ini = Nothing
            End If

            Return True
        End Function
        Private Function UpdateSiteConf(targetPort As Integer) As Boolean

            '////////////////CONFIG httpd.conf
            If Not File.Exists(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHETEMPLATE)) Then
                MessageBox.Show(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHETEMPLATE) & "文件不存在，无法启动Website", "WebSite站点启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return False
            Else
                Dim strROOT As String = String.Copy(Environment.CurrentDirectory).Replace("\", "/")
                If strROOT(strROOT.Length - 1) <> "/"c Then
                    strROOT += "/website"
                Else
                    strROOT += "website"
                End If

                'read from file
                Dim sr As StreamReader = New StreamReader(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHETEMPLATE), System.Text.Encoding.UTF8)
                Dim strContent As String = sr.ReadToEnd
                sr.Close()
                sr = Nothing

                'replace loadmodule first
                '# LoadModule {$LOADMODULE}
                '# LoadModule php7_module "{$PORTABLEROOT}/php7/php7apache2_4.dll"
                '# LoadModule php5_module "{$PORTABLEROOT}/php5/php5apache2_4.dll"
                Dim strApacheTemplate As String = strContent.Replace("{$LOADMODULE}", CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHEPHPMODULE))
                strApacheTemplate = strApacheTemplate.Replace("{$PORTABLEROOT}", strROOT)
                strApacheTemplate = strApacheTemplate.Replace("{$PORT}", targetPort)
                strApacheTemplate = strApacheTemplate.Replace("{$PHPVERSION}", CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHPVERSION))
                'save to
                Dim strFilePath As String = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHETEMPLATE_COYPTO)
                Dim sw As StreamWriter = New StreamWriter(strFilePath, False, System.Text.Encoding.UTF8) 'true is append method
                sw.WriteLine(strApacheTemplate)
                sw.Close()
                sw = Nothing

            End If

            '////////////////CONFIG php.ini inside apache bin folder 
            If Not File.Exists(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHEPHPTEMPLATE)) Then
                MessageBox.Show(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHEPHPTEMPLATE) & "文件不存在，无法启动Website", "WebSite站点启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return False
            Else
                Dim strROOT As String = Environment.CurrentDirectory & "\website"
                'read from file
                Dim sr2 As StreamReader = New StreamReader(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHEPHPTEMPLATE), System.Text.Encoding.UTF8)
                Dim strContent2 As String = sr2.ReadToEnd
                sr2.Close()
                sr2 = Nothing

                Dim strApachePhpTemplate As String = strContent2.Replace("{$PORTABLEROOT}", strROOT)
                strApachePhpTemplate = strApachePhpTemplate.Replace("{$PHPVERSION}", CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PHPVERSION))
                'save to
                Dim strFilePath2 As String = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_APACHEPHPTEMPLATE_COYPTO)
                Dim sw2 As StreamWriter = New StreamWriter(strFilePath2, False, System.Text.Encoding.UTF8) 'true is append method
                sw2.WriteLine(strApachePhpTemplate)
                sw2.Close()
                sw2 = Nothing
            End If
            Return True
        End Function

#End Region

        Public Function Initialize() As Boolean

            Try
                'close process
                If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_ENABLE)) > 0 Then
                    ProcessMgr.ShutDownMysqlProcess()
                End If

                'CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_FILE_NAME)) 'mysqld.exe
                CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_FILE_NAME)) '"apache.exe"
                CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_FILE_NAME)) '"realmd.exe"
                CloseAllProcessByName(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_FILE_NAME)) '"mangosd.exe"

                'check website settings
                Dim mysqlport As Integer = Convert.ToInt32(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_PORT))
                Dim webport As Integer = Convert.ToInt32(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_PORT))
                Dim authport As Integer = Convert.ToInt32(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_PORT))
                Dim worldport As Integer = Convert.ToInt32(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_PORT))

                'check mysql port
                If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_ENABLE)) > 0 Then
                    If ProcessMgr.PortIsInUse(mysqlport) Then
                        MessageBox.Show("指定mysql端口已经被占用，无法启动mysql", "mysql启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    End If
                End If

                'check apache port and config
                If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_ENABLE)) > 0 Then
                    If ProcessMgr.PortIsInUse(webport) Then
                        MessageBox.Show("指定Website端口已经被占用，无法启动Website", "WebSite站点启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    End If
                    If Not System.IO.File.Exists(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_FILE_PATH)) Then
                        MessageBox.Show("Website站点核心启动程序不存在，无法启动Website", "WebSite站点启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    Else
                        If Not UpdateSiteConf(webport) Or Not UpdateSitePHP() Then
                            Return False
                        End If
                    End If
                End If

                'check auth port
                If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_ENABLE)) > 0 Then
                    If ProcessMgr.PortIsInUse(authport) Then
                        MessageBox.Show("指定authserver端口已经被占用，无法启动authserver", "authserver启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    End If
                End If

                'check world port
                If Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_ENABLE)) > 0 Then
                    If ProcessMgr.PortIsInUse(worldport) Then
                        MessageBox.Show("指定worldserver端口已经被占用，无法启动worldserver", "worldserver启动", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    End If
                End If

            Catch
                Me.mysqlProcess = DirectCast(Nothing, Process)
                Return False
            End Try
            Return True
        End Function
        ''' <summary>
        ''' StartMysql process
        ''' </summary>
        ''' <returns></returns>
        Public Function StartMysqlProcess() As Boolean
            Try
                Me.mysqlProcess = New Process()
                Me.mysqlProcess.StartInfo.FileName = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_FILE_PATH)
                Me.mysqlProcess.StartInfo.Arguments = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_ARGUMENTS) '"--console --max_allowed_packet=128M"
                Me.mysqlProcess.StartInfo.UseShellExecute = False
                Me.mysqlProcess.StartInfo.CreateNoWindow = Not (Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_SHOWWINDOW)) > 0)
                Me.mysqlProcess.StartInfo.LoadUserProfile = False
                Me.mysqlProcess.Start()
            Catch
                Me.mysqlProcess = DirectCast(Nothing, Process)
                Return False
            End Try
            Return True
        End Function

        Function CMD(ByVal Data As String) As String
            Try
                Dim p As New Process()
                p.StartInfo.FileName = "cmd.exe"
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardInput = True
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.RedirectStandardError = True
                p.StartInfo.CreateNoWindow = True
                p.Start()
                Application.DoEvents()
                p.StandardInput.WriteLine(Data)
                Thread.Sleep(3000)
                p.StandardInput.WriteLine("Exit")
                'p.WaitForExit()
                Dim strRst As String = p.StandardOutput.ReadToEnd()
                p.Close()
                Return strRst
            Catch ex As Exception
                Return ""
            End Try
        End Function

        ''' <summary>
        ''' ShutDownMysqlProcess use mysql admin
        ''' </summary>
        ''' <returns></returns>
        Public Function ShutDownMysqlProcess() As Boolean
            Try
                'MsgBox(CMD("ipconfig /all"))
                'MsgBox(CMD("H:\WOWServer\Source\WEMULauncher\netsrc\WEMULauncher\WEMULauncher\WEMULauncher\bin\Debug\mysql5\bin\mysqladmin.exe -u root -proot2 shutdown"))
                Me.mysqladmin = New Process()
                Me.mysqladmin.StartInfo.FileName = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLADMIN_FILE_PATH)
                Dim strArgument As String = String.Format(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLADMIN_ARGUMENTS),'-u {0} -p{1} shutdown
                                                         CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_USERNAME),
                                                         CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_PASSWORD))
                Me.mysqladmin.StartInfo.Arguments = strArgument
                Me.mysqladmin.StartInfo.UseShellExecute = False
                Me.mysqladmin.StartInfo.RedirectStandardOutput = True
                Me.mysqladmin.StartInfo.CreateNoWindow = Not (Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLSERVER_SHOWWINDOW)) > 0)
                Me.mysqladmin.StartInfo.LoadUserProfile = False
                Me.mysqladmin.Start()
                Me.mysqladmin.WaitForExit()
                'Dim strRst As String = mysqladmin.StandardOutput.ReadToEnd()
                'MsgBox(strRst)
                ''简单暴力的循环判断
                'Do While ProcessMgr.TargetProcessIsRuning(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.MYSQLADMIN_FILE_NAME))
                '    Thread.Sleep(1000)
                'Loop
            Catch
                Me.mysqladmin = DirectCast(Nothing, Process)
                Return False
            End Try
            Return True
        End Function

        Public Function StartWebsiteProcess()
            If Me.siteProcess IsNot Nothing Then
                Return False
            End If
            Try
                Me.siteProcess = New Process()
                Me.siteProcess.StartInfo.FileName = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_FILE_PATH)
                Me.siteProcess.StartInfo.UseShellExecute = False
                Me.siteProcess.StartInfo.CreateNoWindow = Not (Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WEBSERVER_SHOWWINDOW)) > 0)
                Me.siteProcess.StartInfo.LoadUserProfile = False
                Me.siteProcess.Start()
            Catch
                Me.siteProcess = DirectCast(Nothing, Process)
                Return False
            End Try
            Return True
        End Function

        Public Function StartAuthProcess(opcode As String)

            Try
                Me.authProcess = New Process()
                Me.authProcess.StartInfo.FileName = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_FILE_PATH)
                Me.authProcess.StartInfo.UseShellExecute = False
                Me.authProcess.StartInfo.CreateNoWindow = Not (Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_SHOWWINDOW)) > 0)
                Me.authProcess.StartInfo.LoadUserProfile = False
                Me.authProcess.Start()
            Catch
                Me.authProcess = DirectCast(Nothing, Process)
                Return False
            End Try
            Return True
        End Function

        Public Function StartWorldProcess(opcode As String)

            Try
                Me.worldProcess = New Process()
                Me.worldProcess.StartInfo.FileName = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_FILE_PATCH)
                Me.worldProcess.StartInfo.UseShellExecute = False
                Me.worldProcess.StartInfo.CreateNoWindow = Not (Val(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WORLDSERVER_SHOWWINDOW)) > 0)
                Me.worldProcess.StartInfo.LoadUserProfile = False
                Me.worldProcess.Start()
            Catch
                Me.worldProcess = DirectCast(Nothing, Process)
                Return False
            End Try
            Return True
        End Function
        Public Function TargetProcessIsRuning(name As String) As Boolean
            name = name.ToLower()
            For Each process__1 As Process In Process.GetProcesses(".")
                Dim lower As String = String.Copy(process__1.ProcessName).ToLower()
                If name.StartsWith(lower) Then
                    Return True
                End If
            Next
            Return False
        End Function

        Public Sub CloseAllProcessByName(name As String)
            name = name.ToLower()
            For Each process__1 As Process In Process.GetProcesses(".")
                Dim lower As String = String.Copy(process__1.ProcessName).ToLower()
                If name.StartsWith(lower) Then
                    process__1.Kill()
                    process__1.WaitForExit()
                End If
            Next
        End Sub




    End Class
End Namespace
