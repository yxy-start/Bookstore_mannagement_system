Module BookService
    Public Sub bookSelect(bookname As String)
        If (SelectBookname(bookname) = 1) Then
            MsgBox("如下表")
        Else
            MsgBox("该书店没有此书，望见谅！")
        End If

    End Sub
End Module
