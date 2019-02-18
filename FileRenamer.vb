Module Module1

    Sub Main()
        Dim Arguments() As String = Environment.GetCommandLineArgs()
        If Arguments.Length > 1 Then

            Dim inFilePath As String = Arguments(1)
            MsgBox(inFilePath)
            'Dim extension As String = System.IO.Path.GetExtension(inFilePath)
            'Dim fileName As String = System.IO.Path.GetFileName(inFilePath)

            'fileName = Left(fileName, InStrRev(fileName, ".") - 1)
            'fileName = Replace(fileName, ".", " ")
            'fileName = fileName & extension

            'My.Computer.FileSystem.RenameFile(inFilePath, fileName)
        End If
    End Sub

End Module
