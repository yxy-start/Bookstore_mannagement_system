Module User_BookService
    Public Sub consumerbookSelect(book As Book)
        If (book.Get_bookName() <> "") Then
            If (SelectBookname(book) = 1) Then
                MsgBox("按书名查询，如下表")
                If (book.Get_bookGenres() <> "" Or book.Get_bookAuthor() <> "") Then
                    MsgBox("请只按书名查询！")
                End If
            Else
                MsgBox("抱歉，此书店没有该书信息！")
            End If

        ElseIf (book.Get_bookGenres() <> "") Then
            If (SelectBookgenres(book)) Then
                MsgBox("按书类型查询，如下表")
                If (book.Get_bookName() <> "" Or book.Get_bookAuthor() <> "") Then
                    MsgBox("请只按类型查询！")
                End If
            End If
        ElseIf (book.Get_bookAuthor() <> "") Then
            If (SelectBookauthor(book)) Then
                MsgBox("按作者查询，如下表")
                If (book.Get_bookName() <> "" Or book.Get_bookGenres() <> "") Then
                    MsgBox("请只按作者查询！")
                End If
            Else
                MsgBox("抱歉，此书店没有该作者的书的信息！")
            End If
        ElseIf (book.Get_bookName() = "" And book.Get_bookGenres() <> "" And book.Get_bookAuthor() = "") Then
            MsgBox("查询格式错误！请输入信息！")
        End If

    End Sub

    Public Sub consumerbookSelect1(book As Book)
        If (SelectBookname(book)) Then
            If (SelectBookgenres(book)) Then
                MsgBox("如下表")
            End If
        End If

    End Sub
End Module
