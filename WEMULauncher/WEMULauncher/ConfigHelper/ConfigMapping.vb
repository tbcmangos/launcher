
Imports System.IO

Module ConfigMapping
    Public THIS_CONFIG_FILE_PATCH As String = Path.Combine(Application.StartupPath, "WEMULauncher.conf")
    Public THIS_CONFIG_TABLENAME As String = "WEMULauncher"
    Public THIS_CONFIG_LANG As CONST_LANG_ENUM = CONST_LANG_ENUM.LANG_ENUS

    ''' <summary>
    ''' private ConfigDictionary read from config file
    ''' </summary>
    Private ConfigDictionary As Dictionary(Of String, ConfigLine)

    ''' <summary>
    ''' Processed full parameter dictionary
    ''' 指派的时候，循环enum，判断ConfigDictionary key是否存在，如存在则添加，不存在则报错终止
    ''' 如果是folder和file进行判断是否文件和文件夹实际存在，不存在则报错终止。
    ''' 这样处理完成后的CONFIG_FULL_DICT数据肯定包含所有设置参赛
    ''' </summary>
    Public CONFIG_FULL_DICT As Dictionary(Of CONFIG_MAPPING_ENUM, String)

#Region "ConfigMapping"
    Public Enum CONFIG_MAPPING_ENUM
        MYSQLSERVER_ENABLE
        MYSQLSERVER_FILE_PATH
        MYSQLSERVER_FILE_NAME
        MYSQLSERVER_ARGUMENTS
        MYSQLSERVER_SHOWWINDOW
        MYSQLSERVER_AUTORESTART
        MYSQLSERVER_IPADDRESS
        MYSQLSERVER_PORT
        SQLLIBFILE_NAME
        MYSQLSERVER_USERNAME '== root
        MYSQLSERVER_PASSWORD '== root
        MYSQLADMIN_FILE_PATH '== .\ mysql5 \ bin \ mysqladmin.exe
        MYSQLADMIN_FILE_NAME '== mysqladmin.exe
        MYSQLADMIN_ARGUMENTS '== -u {0} -p{1} shutdown

        WEBSERVER_ENABLE
        WEBSERVER_FILE_PATH
        WEBSERVER_FILE_NAME
        WEBSERVER_SHOWWINDOW
        WEBSERVER_AUTORESTART
        WEBSERVER_IPADDRESS
        WEBSERVER_PORT
        WEBSERVER_PHPVERSION '5 or 7
        WEBSERVER_APACHEPHPMODULE
        WEBSERVER_APACHETEMPLATE
        WEBSERVER_APACHETEMPLATE_COYPTO
        WEBSERVER_APACHEPHPTEMPLATE
        WEBSERVER_APACHEPHPTEMPLATE_COYPTO
        WEBSERVER_PHP5TEMPLATE
        WEBSERVER_PHP5TEMPLATE_COYPTO
        WEBSERVER_PHP7TEMPLATE
        WEBSERVER_PHP7TEMPLATE_COYPTO


        ACEFILE_NAME

        WOWEXE_ENABLE
        WOWFOLDER_PATH
        WOWEXE_NAME
        WOW_PATCH
        WOW_VERSION_STRING
        WOW_USERNAME
        WOW_PASSWORD
        WOW_AUTOLOGIN

        AUTHSERVER_ENABLE
        AUTHSERVER_FILE_PATH
        AUTHSERVER_FILE_NAME
        AUTHSERVER_SHOWWINDOW
        AUTHSERVER_AUTORESTART
        AUTHSERVER_IPADDRESS
        AUTHSERVER_PORT
        AUTHCONF_PATH
        AUTHLOG_PATH
        AUTH_SUCCESS_STRING

        WORLDSERVER_ENABLE
        WORLDSERVER_FILE_PATCH
        WORLDSERVER_FILE_NAME
        WORLDSERVER_SHOWWINDOW
        WORLDSERVER_AUTORESTART
        WORLDSERVER_IPADDRESS
        WORLDSERVER_PORT
        WORLDCONF_PATH
        WORLDLOG_PATH
        WORLD_SUCCESS_STRING

        WINDOWSERROR_FILE_NAME
    End Enum

#End Region

#Region "LoadConfig"
    Private _configHelper As ConfigHelper
    ''' <summary>
    ''' Public sub to read config via config helper
    ''' </summary>
    Public Function ReadConfig() As Boolean
        'load config
        ConfigDictionary = New Dictionary(Of String, ConfigLine)
        CONFIG_FULL_DICT = New Dictionary(Of CONFIG_MAPPING_ENUM, String)

        _configHelper = New ConfigHelper
        _configHelper.CONST_LANG = THIS_CONFIG_LANG
        _configHelper.ResultTableName = THIS_CONFIG_TABLENAME
        _configHelper.ConfigFilePath = THIS_CONFIG_FILE_PATCH

        ConfigDictionary = _configHelper.dictConfigKeyWordAsKeyDetailAsValue
        'MsgBox(ConfigDictionary(mapKey1).ConfigVALUE)

        'validate and assign value
        Dim strary As String() = [Enum].GetNames(GetType(CONFIG_MAPPING_ENUM))
        For Each s As String In strary
            If s = "MYSQLSERVER_FILE_PATH" Or
                s = "WEBSERVER_FILE_PATH" Or
                s = "AUTHSERVER_FILE_PATH" Or
                s = "WORLDSERVER_FILE_PATCH" Then 'file
                If Not ValidateFileConfig(s, CONFIG_FULL_DICT) Then
                    Return False
                End If
            ElseIf s = "WOWFOLDER_PATH" Then 'FOLDER
                If Not ValidateFolderConfig(s, CONFIG_FULL_DICT) Then
                    Return False
                End If
            Else 'string
                If Not ValidateStringConfig(s, CONFIG_FULL_DICT) Then
                    Return False
                End If
            End If
        Next
        '确认所有项目都被正当添加，如果未添加则报错
        For Each Subkey In CONFIG_FULL_DICT
            If Subkey.Value = "" Then
                form_alert.Show(String.Format("{0} didnt set, please check", Subkey.Key.ToString), form_alert.AlertType.error)
                Return False
            End If
        Next


        Return True
    End Function
    ''' <summary>
    ''' check folder setting，检测文件夹设置
    ''' </summary>
    ''' <returns></returns>
    Public Function ValidateFolderConfig(ByVal confmap As String, ByRef assignto As Dictionary(Of CONFIG_MAPPING_ENUM, String)) As Boolean
        If ConfigDictionary.ContainsKey(confmap) Then
            If Directory.Exists(ConfigDictionary(confmap).ConfigVALUE) Then
                Dim a As CONFIG_MAPPING_ENUM = [Enum].Parse(GetType(CONFIG_MAPPING_ENUM), confmap)
                If Not assignto.ContainsKey(a) Then
                    assignto.Add(a, ConfigDictionary(confmap).ConfigVALUE)
                End If
                Return True
            Else
                form_alert.Show(String.Format("Please set {0} folder", confmap), form_alert.AlertType.error)
                Return False
            End If
        Else
            form_alert.Show(String.Format("{0} didnt set, please check", confmap), form_alert.AlertType.error)
            Return False
        End If
    End Function
    ''' <summary>
    ''' check file setting，检测文件设置
    ''' </summary>
    ''' <returns></returns>
    Public Function ValidateFileConfig(ByVal confmap As String, ByRef assignto As Dictionary(Of CONFIG_MAPPING_ENUM, String)) As Boolean
        If ConfigDictionary.ContainsKey(confmap) Then
            If File.Exists(ConfigDictionary(confmap).ConfigVALUE) Then
                Dim a As CONFIG_MAPPING_ENUM = [Enum].Parse(GetType(CONFIG_MAPPING_ENUM), confmap)
                If Not assignto.ContainsKey(a) Then
                    assignto.Add(a, ConfigDictionary(confmap).ConfigVALUE)
                End If
                Return True
            Else
                form_alert.Show(String.Format("{0} file not found, please check", confmap), form_alert.AlertType.error)
                Return False
            End If
        Else
            form_alert.Show(String.Format("{0} didnt set, please check", confmap), form_alert.AlertType.error)
            Return False
        End If
    End Function

    ''' <summary>
    ''' check string setting，检测字符串设置
    ''' </summary>
    ''' <returns></returns>
    Public Function ValidateStringConfig(ByVal confmap As String, ByRef assignto As Dictionary(Of CONFIG_MAPPING_ENUM, String)) As Boolean
        If ConfigDictionary.ContainsKey(confmap) Then
            If ConfigDictionary(confmap).ConfigVALUE.Trim <> "" Then
                Dim a As CONFIG_MAPPING_ENUM = [Enum].Parse(GetType(CONFIG_MAPPING_ENUM), confmap)
                If Not assignto.ContainsKey(a) Then
                    assignto.Add(a, ConfigDictionary(confmap).ConfigVALUE)
                End If
                Return True
            Else
                form_alert.Show(String.Format("{0}is empty, please set", confmap), form_alert.AlertType.error)
                Return False
            End If
        Else
            form_alert.Show(String.Format("{0} didnt set, please check", confmap), form_alert.AlertType.error)
            Return False
        End If
    End Function
#End Region

End Module
