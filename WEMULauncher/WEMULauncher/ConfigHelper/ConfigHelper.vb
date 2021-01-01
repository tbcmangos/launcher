Imports System.IO

Public Class ConfigHelper

#Region "vars"

    ''' <summary>
    ''' langguage 
    ''' 首选语言
    ''' </summary>
    Public CONST_LANG As CONST_LANG_ENUM '= CONST_LANG_ENUM.LANG_ZHCN

    ''' <summary>
    ''' dictionary to contain the final result, key is keyword, value is the detail contains key,value,description
    ''' 包含所有最终结果的字典，key是关键字，值是一个包含key，value和描述
    ''' </summary>
    Public dictConfigKeyWordAsKeyDetailAsValue As Dictionary(Of String, ConfigLine)

    ''' <summary>
    ''' after process the file it will also be converted into a table for easy review
    ''' 处理完成后也会有datatable来暂存数据，可以用datagridview显示
    ''' </summary>
    Public ResultTable As System.Data.DataTable

    ''' <summary>
    ''' result table name
    ''' 存储结果的datatable名
    ''' </summary>
    Public ResultTableName As String

    ''' <summary>
    ''' it may have error so it will be saved to log
    ''' 存储处理日志
    ''' </summary>
    Public ExecutionLog As String

    ''' <summary>
    ''' Separator for the key and value
    ''' 分隔符, 请保证前后都有空格
    ''' </summary>
    Private ReadOnly CONST_VALUE_SEPARATOR As String = "=="

    ''' <summary>
    ''' line start with this will be consider as comment
    ''' 备注符号
    ''' </summary>
    Private ReadOnly CONST_COMMENT_SYMBOL As String = "#"

    ''' <summary>
    ''' KEYWORD LENGTH
    ''' 关键字的长度
    ''' </summary>
    Private ReadOnly CONST_KEYWORD_LENGTH As Integer = 36
    ''' <summary>
    ''' what to fill if the keyword is not in specific length
    ''' 填充关键字长度的字符
    ''' </summary>
    Private ReadOnly CONST_KEYWORD_FILLER As String = " "

    Private _filePath As String
    ''' <summary>
    ''' the file path
    ''' 文件路径
    ''' </summary>
    ''' <returns></returns>
    Public Property ConfigFilePath As String
        Get
            Return _filePath
        End Get
        Set(value As String)
            _filePath = value
            subProcessprt()
            convertTodt()
        End Set
    End Property
#End Region

#Region "processor"
    Private Sub subProcessprt()
        '##########################
        '# comment 1
        '##########################
        'Key1 = Value 1              - comments above write to Key1 pair
        'Key2 = Value 2
        '                            - always add a space before comments
        '##########################
        '# comment 2
        '##########################
        '
        '
        dictConfigKeyWordAsKeyDetailAsValue = New Dictionary(Of String, ConfigLine)
        ExecutionLog = ""
        'these two no need at here, it will be parsed per line
        '这两个不需要， 会在每行暂存
        'Dim ConfigKeyWord As String = ""
        'Dim ConfigVALUE As String = ""

        'it need to contain several lines
        '需要多行存储
        Dim ConfigDesc As String = ""

        Dim line As String
        Dim sr As StreamReader = New StreamReader(_filePath, System.Text.Encoding.UTF8)
        Dim intpointer As Integer = 1
        Do While sr.Peek() > 0
            System.Windows.Forms.Application.DoEvents()
            line = sr.ReadLine().Trim
            'check if it is comments 查看是否是备注
            If Not (Left(line, 1) = CONST_COMMENT_SYMBOL) Then
                'if contains separator like "="
                If line.Contains(CONST_VALUE_SEPARATOR) Then
                    Dim arr As String()
                    arr = Split(line, CONST_VALUE_SEPARATOR)
                    'check if there is only 2 parameter after separate
                    '确认分割后是否只有两个元素
                    If arr.Count = 2 Then
                        Dim tempKeyword As String = arr(0).Trim
                        Dim tempValue As String = arr(1).Trim
                        If tempKeyword <> "" And tempValue <> "" Then

                            If dictConfigKeyWordAsKeyDetailAsValue.ContainsKey(tempKeyword) Then
                                'already added to dictionary
                                '已被添加入字典
                                Select Case CONST_LANG
                                    Case CONST_LANG_ENUM.LANG_ZHCN
                                        ExecutionLog = ExecutionLog & String.Format("[错误] 第 {0} 行的关键字 [ {1} ] 已被加进字典，将会被忽略 {2}"， intpointer, tempKeyword, vbCrLf)
                                    Case Else
                                        ExecutionLog = ExecutionLog & String.Format("[Error] line {0} keyword [ {1} ] has already added to the dictionary and will be ignore {2}"， intpointer, tempKeyword, vbCrLf)
                                End Select

                            Else
                                Dim tempConfigline As New ConfigLine With {
                                .ConfigKeyWord = tempKeyword,
                                .ConfigVALUE = tempValue,
                                .ConfigDesc = ConfigDesc ' add by default, ether empty or has content，默认添加，可能为空或有值
                                }
                                'clear ConfigDesc for next parameter 添加后便清空
                                If ConfigDesc <> "" Then
                                    ConfigDesc = ""
                                End If

                                dictConfigKeyWordAsKeyDetailAsValue.Add(tempKeyword, tempConfigline)
                            End If
                        Else
                            'ether key is empty or value is empty 关键字和值为空
                            If tempKeyword = "" Then
                                Select Case CONST_LANG
                                    Case CONST_LANG_ENUM.LANG_ZHCN
                                        ExecutionLog = ExecutionLog & String.Format("[错误] 第 {0} 行 [ {1} ] 的关键字是空的将会被忽略 {2}"， intpointer, line, vbCrLf)
                                    Case Else
                                        ExecutionLog = ExecutionLog & String.Format("[Error] line {0} [ {1} ] keyword is empty and will be ignore {2}"， intpointer, line, vbCrLf)
                                End Select
                            End If
                            If tempValue = "" Then
                                Select Case CONST_LANG
                                    Case CONST_LANG_ENUM.LANG_ZHCN
                                        ExecutionLog = ExecutionLog & String.Format("[错误] 第 {0} 行 [ {1} ] 的值是空的将会被忽略 {2}"， intpointer, line, vbCrLf)
                                    Case Else
                                        ExecutionLog = ExecutionLog & String.Format("[Error] line {0} [ {1} ] value is empty and will be ignore {2}"， intpointer, line, vbCrLf)
                                End Select
                            End If
                        End If
                    Else
                        'it has more than 2 elements, so probably having more than one separator "="
                        '分割后有多于两个元素，可能存在多个分隔符
                        Select Case CONST_LANG
                            Case CONST_LANG_ENUM.LANG_ZHCN
                                ExecutionLog = ExecutionLog & String.Format("[错误] 第 {0} 行 [ {1} ] 有多个分隔符 [ {2} ] 将会被忽略 {3}"， intpointer， line， CONST_VALUE_SEPARATOR, vbCrLf)
                            Case Else
                                ExecutionLog = ExecutionLog & String.Format("[Error] line {0}  [ {1} ] has more than one separator [ {2} ] and will be ignore {3}"， intpointer， line， CONST_VALUE_SEPARATOR, vbCrLf)
                        End Select
                    End If
                Else
                    If line = "" Then
                        'do nothing for empty line 空行不处理
                        'ExecutionLog = ExecutionLog & String.Format("line {0} has no separator {1} and will be ignore {2}"， intpointer， CONST_VALUE_SEPARATOR, vbCrLf)
                    Else
                        'it is not comment line nor has separator "=" in this line, so is wrong line
                        '非空行，既不包含备注符号也不包含分隔符
                        Select Case CONST_LANG
                            Case CONST_LANG_ENUM.LANG_ZHCN
                                ExecutionLog = ExecutionLog & String.Format("[错误] 第 {0} 行  [ {1} ]  没有分隔符 [ {2} ]  将会被忽略 {3}"， intpointer， line， CONST_VALUE_SEPARATOR, vbCrLf)
                            Case Else
                                ExecutionLog = ExecutionLog & String.Format("[Error] line {0}  [ {1} ] has no separator [ {2} ]  and will be ignore {3}"， intpointer， line， CONST_VALUE_SEPARATOR, vbCrLf)
                        End Select
                    End If

                End If
            Else
                'this is comment portion
                '暂存备注
                ConfigDesc = ConfigDesc & line & vbCrLf
            End If
            intpointer += 1
        Loop
        sr.Close()
        sr = Nothing

        '
        If ExecutionLog.Trim = "" Then
            Select Case CONST_LANG
                Case CONST_LANG_ENUM.LANG_ZHCN
                    ExecutionLog = "成功读取无错误" & vbCrLf
                Case Else
                    ExecutionLog = "Config load succss" & vbCrLf
            End Select
        End If

    End Sub


#End Region

#Region "private functions"
    Private Sub convertTodt()
        'DIM table
        ResultTable = New System.Data.DataTable
        ResultTable.TableName = ResultTableName
        ResultTable.Columns.Add("ConfigKeyWord")
        ResultTable.Columns.Add("ConfigVALUE")
        ResultTable.Columns.Add("ConfigDesc")

        For Each subDict In dictConfigKeyWordAsKeyDetailAsValue
            ResultTable.Rows.Add(subDict.Value.ConfigKeyWord, subDict.Value.ConfigVALUE, subDict.Value.ConfigDesc)
        Next
    End Sub


    'writeback
    Public Sub SaveConfigFromDictToFile()
        'Method1, replace parameter, 方法1,只替换找到的内容
        ''to contain the temperory config content
        'Dim tempContent As String = ""

        ''read line by line and replace the original value
        'Dim line As String
        'Dim sr As StreamReader = New StreamReader(_filePath, System.Text.Encoding.UTF8)
        'Dim intpointer As Integer = 1
        'Do While sr.Peek() > 0
        '    System.Windows.Forms.Application.DoEvents()
        '    line = sr.ReadLine().Trim

        'Loop

        'method2, rewrite entire file. 方法2， 重写所有文件
        Dim temp
        Dim sw As StreamWriter = New StreamWriter(_filePath, False, System.Text.Encoding.UTF8) 'true is append method

        For Each subKey In dictConfigKeyWordAsKeyDetailAsValue
            If subKey.Value.ConfigDesc <> "" Then
                sw.WriteLine("") 'always add empty line before description 描述前始终添加空行
                sw.WriteLine(subKey.Value.ConfigDesc) '描述写在前面
            End If
            sw.WriteLine(String.Format("{0} {1} {2}", ExtendStringLength(subKey.Value.ConfigKeyWord), CONST_VALUE_SEPARATOR, subKey.Value.ConfigVALUE))
        Next
        sw.Close()
        sw = Nothing
    End Sub

    Private Function ExtendStringLength(ByVal strInput As String) As String
        Dim strNew As String = strInput

        If strNew.Length >= CONST_KEYWORD_LENGTH Then
        Else
            For i = strNew.Length To CONST_KEYWORD_LENGTH
                strNew = strNew & CONST_KEYWORD_FILLER
            Next
        End If
        Return strNew
    End Function

    Private Function convertDictToArray(ByVal dict As Dictionary(Of String, Integer)) As String
        Dim str As String = ""
        For Each subDict In dict
            If str = "" Then
                str = subDict.Key
            Else
                str = str & ", " & subDict.Key
            End If
        Next
        Return str
    End Function
    Private Sub addArrayToDict(ByRef dict As Dictionary(Of String, Integer), ByVal arr As String())
        For Each sSub In arr
            If dict.ContainsKey(sSub) = False Then
                dict.Add(sSub, 1)
            Else
                dict(sSub) += 1
            End If
        Next

    End Sub

    Private Sub appendDictToDict(ByRef dictDest As Dictionary(Of String, Integer), ByRef dictSource As Dictionary(Of String, Integer))
        For Each sSub In dictSource
            If dictDest.ContainsKey(sSub.Key) = False Then
                dictDest.Add(sSub.Key, sSub.Value)
            Else
                dictDest(sSub.Key) += sSub.Value
            End If
        Next
    End Sub
#End Region
    Private Sub subTXTWrite()
        Dim strFilePath As String = "D:\test.txt"
        Dim temp
        Dim sw As StreamWriter = New StreamWriter(strFilePath, True, System.Text.Encoding.UTF8) 'true is append method
        For i = 0 To 10
            temp = i.ToString
            sw.WriteLine(temp)
            sw.Flush()
        Next
        sw.Close()
        sw = Nothing
    End Sub

    Private Sub subTXTRead()
        Dim line As String
        Dim sr As StreamReader = New StreamReader("D:\test.txt", System.Text.Encoding.UTF8)
        Do While sr.Peek() > 0
            line = sr.ReadLine()
        Loop
        sr.Close()
        sr = Nothing
    End Sub

End Class

Public Enum CONST_LANG_ENUM
    LANG_ENUS = 1
    LANG_ZHCN = 2
End Enum
