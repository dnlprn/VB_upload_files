Private Sub MoveToServer(src As String, dst As String)

        Dim fileEntries As String() = Directory.GetFiles(src)
        ' Process the list of files found in the directory.
        Dim srcPath As String
        Dim dstPath As String

        For Each srcPath In fileEntries

            dstPath = Path.Combine(dst, Path.GetFileName(srcPath))
            File.Move(srcPath, dstPath)

        Next

End Sub