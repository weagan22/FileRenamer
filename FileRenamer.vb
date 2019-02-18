Module Module1

    Sub Main()

        Dim Arguments() As String = Environment.GetCommandLineArgs()
        If Arguments.Length > 1 Then

            Dim inFilePath As String = Arguments(1)

            If Arguments.Length > 2 Then
                For i = 2 To UBound(Arguments)
                    inFilePath = inFilePath & " " & Arguments(i)
                Next
            End If

            Dim fileExtension As String = System.IO.Path.GetExtension(inFilePath)
            Dim fileName As String = System.IO.Path.GetFileNameWithoutExtension(inFilePath)

            fileName = Replace(fileName, ".", " ")
            If Text.RegularExpressions.Regex.IsMatch(fileName, "(19|20)[0-9][0-9]") Then
                fileName = Left(fileName, InStr(fileName, Text.RegularExpressions.Regex.Match(fileName, "(19|20)[0-9][0-9]").ToString) - 2)
            End If

            fileName = fileName & fileExtension

            My.Computer.FileSystem.RenameFile(inFilePath, fileName)
        End If
    End Sub

End Module
