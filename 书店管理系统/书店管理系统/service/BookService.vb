Module BookService
    
    Public Sub book_Select(book As Book)
        If (book.Get_bookName() <> "") Then
            If (SelectBookname(book) = 1) Then
                MsgBox("按书名查询，如下表")
                If (book.Get_bookGenres() <> "" Or book.Get_bookAuthor() <> "") Then
                    MsgBox("请只按书名查询！")
                End If
            Else
                MsgBox("没有此书信息，请点击添加")
            End If
        End If
        
        If (book.Get_bookGenres() <> "") Then
            If (SelectBookgenres(book)) Then
                MsgBox("按书类型查询")
                If (book.Get_bookName() <> "" Or book.Get_bookAuthor() <> "") Then
                    MsgBox("请只按类型查询！")
                End If
            End If
        End If

        If (book.Get_bookAuthor() <> "") Then
            If (SelectBookauthor(book)) Then
                MsgBox("按作者查询")
                If (book.Get_bookName() <> "" Or book.Get_bookGenres() <> "") Then
                    MsgBox("请只按作者查询！")
                End If
            Else
                MsgBox("没有此作者的书，请点击添加该书籍")
            End If
        End If
        'If (book.Get_bookPrice() <> "") Then
        '    MsgBox("抱歉，不能使用价格查询书籍！")
        'End If
    End Sub

    Public Sub book_Delete(book As Book)
        If (book.Get_bookName() <> "") Then
            If (SelectBookname(book) = 1) Then
                DeleteBookname(book)
                If (book.Get_bookGenres() <> "" Or book.Get_bookAuthor() <> "") Then
                    MsgBox("请只按书名删除！")
                End If
            Else
                MsgBox("没有此书信息，无法删除，请点击添加！")
            End If
        End If
    End Sub

    Public Sub book_Insert(book As Book)
        
        InsertBook(book)
    End Sub

    Public Sub book_Update(book As Book)
        If (book.Get_bookName() <> "") Then
            If (SelectBookname(book) = 1) Then
                UpdateBook(book) 
            Else
                MsgBox("没有此书信息，无法更新，请点击添加！")
            End If
        End If
    End Sub

End Module
