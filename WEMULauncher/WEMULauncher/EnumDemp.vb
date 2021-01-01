Namespace EnumDemo
    Public Enum Color
        red = 0
        orange = 1
        yellow = 2
        green = 4
        blue = 5
        cyan = 6
        purple = 7
    End Enum

    Class Program
        Private Shared Sub Main(ByVal args As String())
            Console.WriteLine("------Enume.GetValues获得枚举项的数组(基类)-----")
            Dim ary As Array = [Enum].GetValues(GetType(Color))

            For Each i As Integer In ary
                Console.WriteLine(i.ToString())
            Next

            Console.WriteLine("------------------------------------------------")

            For Each c As Color In ary
                Console.WriteLine(c.ToString())
            Next

            Console.WriteLine("------ary.GetValue获得枚举项-----")

            For i As Integer = 0 To ary.Length - 1
                Console.WriteLine(ary.GetValue(i).ToString())
            Next

            Console.WriteLine("------Enume.GetName获得枚举项的字符串数组-----")
            Dim strary As String() = [Enum].GetNames(GetType(Color))

            For Each s As String In strary
                Console.WriteLine(s)
            Next

            Console.WriteLine("------num.Parse获得枚举项-----")

            For i As Integer = 0 To strary.Length - 1
                Console.WriteLine([Enum].Parse(GetType(Color), strary(i)).ToString())
            Next
        End Sub

        Public Enum ConcertCode
            BEIJING
            SHANGHAI
            GUANGZHOU
        End Enum

        'convert to enum
        Private Sub ConvertTest()
            Dim c As ConcertCode = CType([Enum].Parse(GetType(ConcertCode), "BEIJING", True), ConcertCode)
        End Sub

    End Class
End Namespace

