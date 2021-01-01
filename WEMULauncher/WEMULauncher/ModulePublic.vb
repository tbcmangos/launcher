Imports System.IO
Imports System.Text
Imports WEMULauncher.WEMUTool

Module ModulePublic

    Public ProcessMgr As New ProcessHandler()

    ''' <summary>
    ''' check if one file contains specific string
    ''' </summary>
    ''' <param name="checkstring"></param>
    ''' <returns></returns>
    Public Function FileContainString(ByVal originalpath As String, ByVal tempfileExt As String, ByVal checkstring As String)
        If Not File.Exists(originalpath) Then
            Return False
        Else
            'some file is in use so need to copy
            File.Copy(originalpath, originalpath & tempfileExt)

            Dim strContent As String = ""
            Dim sr As StreamReader = New StreamReader(originalpath & tempfileExt, System.Text.Encoding.UTF8)

            strContent = sr.ReadToEnd()
            'Dim line As String
            'Do While sr.Peek() > 0
            '    line = sr.ReadLine()
            'Loop
            sr.Close()
            sr = Nothing

            'delete temp file
            If File.Exists(originalpath & tempfileExt) Then
                File.Delete(originalpath & tempfileExt)
            End If
            Return strContent.Contains(checkstring)
        End If

    End Function


#Region "WebServer"


    Public Function StartWoWProcess()
        Dim clientpath As String = CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOWFOLDER_PATH)
        'delete cache
        If Directory.Exists(clientpath & "\Cache") Then
            Directory.Delete(clientpath & "\Cache", True)
        End If
        If Directory.Exists(clientpath & "\WDB") Then
            Directory.Delete(clientpath & "\WDB", True)
        End If

        'write realmlist for lower version
        WriteRealmlistWTF(clientpath)
        'write portal&realm for higher version
        WriteConfigWTF(clientpath)

        Dim clientexe As String = Path.Combine(CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOWFOLDER_PATH), CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.WOWEXE_NAME))

        If File.Exists(clientexe) Then
            Dim prsinfo As New ProcessStartInfo With {
          .FileName = clientexe,
          .UseShellExecute = False,
          .CreateNoWindow = False,
          .LoadUserProfile = False
          }
            Dim pr As New Process() With {
                     .StartInfo = prsinfo
                }
            pr.Start()
        Else
            form_alert.Show("wow文件不存在请检查设置是否正确", form_alert.AlertType.info)
        End If

        Return True
    End Function
    ''' <summary>
    '''低版本检测各个local的realmlist.wtf
    ''' </summary>
    ''' <param name="clientpath"></param>
    Public Sub WriteRealmlistWTF(ByVal clientpath As String)
        Dim realmpath As String = clientpath & "\realmlist.wtf"
        Dim realmline As String = "SET realmlist """ & CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_IPADDRESS) & """"

        If Directory.Exists(clientpath & "\Data\zhCN") Then
            realmpath = clientpath & "\Data\zhCN\realmlist.wtf"
        ElseIf Directory.Exists(clientpath & "\Data\zhTW") Then
            realmpath = clientpath & "\Data\zhTW\realmlist.wtf"
        ElseIf Directory.Exists(clientpath & "\Data\enUS") Then
            realmpath = clientpath & "\Data\enUS\realmlist.wtf"
        ElseIf Directory.Exists(clientpath & "\Data\enCN") Then
            realmpath = clientpath & "\Data\enCN\realmlist.wtf"
        End If
        WriteToFile(realmpath, realmline)
    End Sub
    ''' <summary>
    ''' 高版本检测WTF文件夹Config.wtf 以及 Config2.wtf
    ''' </summary>
    ''' <param name="clientpath"></param>
    ''' <returns></returns>
    Public Function WriteConfigWTF(ByVal clientpath As String)
        Dim configpath As String = clientpath & "\WTF\Config.wtf"
        Dim config2path As String = clientpath & "\WTF\Config2.wtf"

        If File.Exists(configpath) Then
            UpdateConfigWTF(configpath)
        End If
        If File.Exists(configpath) Then
            UpdateConfigWTF(configpath)
        End If

    End Function
    Private Sub UpdateConfigWTF(ByVal configpath As String)
        Dim portalstring As String = "SET portal """ & CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_IPADDRESS) & ":" & CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_PORT) & """"
        Dim realmstring As String = "SET realmlist """ & CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_IPADDRESS) & """"

        Dim strcontent As String = ""
        Dim foundPortal As Boolean = False
        Dim foundRealm As Boolean = False
        'Dim foundLocal As Boolean = False
        'loop and replace
        Dim line As String
        Dim sr As StreamReader = New StreamReader(configpath, System.Text.Encoding.UTF8)
        Do While sr.Peek() > 0
            line = sr.ReadLine()
            If line.ToUpper.Contains("SET portal".ToUpper) Then
                'replace portal
                strcontent = strcontent & portalstring & vbCrLf
                foundPortal = True
            ElseIf line.ToUpper.Contains("SET realmlist".ToUpper) Then
                'replace portal
                strcontent = strcontent & realmstring & vbCrLf
                foundRealm = True
            Else
                strcontent = strcontent & line & vbCrLf
            End If
        Loop
        sr.Close()
        sr = Nothing
        '如果没有realmlist信息则插入到最上方
        If Not foundRealm Then
            strcontent = realmstring & vbCrLf & strcontent
        End If
        '如果没有portal信息则插入到最上方
        If Not foundPortal Then
            strcontent = portalstring & vbCrLf & strcontent
        End If
        '写新文件
        WriteToFile(configpath, strcontent)
    End Sub
    Public Function WriteToFile(ByVal path As String, ByVal content As String)
        Dim sw As StreamWriter = New StreamWriter(path, False, System.Text.Encoding.UTF8) 'true is append method
        sw.Write(content)
        sw.Close()
        sw = Nothing


        'Dim fileStream As New FileStream(path, FileMode.Create)
        'fileStream.Seek(0L, SeekOrigin.Begin)
        'Dim bytes As Byte() = Encoding.UTF8.GetBytes("SET realmlist """ & CONFIG_FULL_DICT(CONFIG_MAPPING_ENUM.AUTHSERVER_IPADDRESS) & """")
        'fileStream.Write(bytes, 0, bytes.Length)
        'fileStream.Flush()
        'fileStream.Close()
        'fileStream = Nothing
    End Function

#End Region
End Module
