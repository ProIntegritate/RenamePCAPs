Module Module1

    Public rx As System.Text.RegularExpressions.Regex

    Sub Main(ByVal args As String())

        Dim sFiles() As String = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory & "\", "*_*.pcap")
        For n = 0 To UBound(sFiles)
            Try
                System.IO.File.Move(sFiles(n), rx.Replace(sFiles(n), "[0-9]{5}_", ""))
            Catch ex As Exception
            End Try
        Next
    End Sub

End Module
