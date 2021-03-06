Module ManageBookService

    Dim objdataSet As New DataSet
    Public Function manageBook_Select(book As Book)
        If (book.Get_bookName() <> "" And book.Get_bookId() = "" And book.Get_bookGenres() = "" And book.Get_bookAuthor() = "") Then
            If (SelectBookname(book) = 1) Then
                MsgBox("按书名查询，如下表")
                objdataSet = SelectBooknameTable(book)
                Return objdataSet
            Else
                MsgBox("抱歉，此书店没有该书信息！")
            End If
        ElseIf (book.Get_bookGenres() <> "" And book.Get_bookId() = "" And book.Get_bookName() = "" And book.Get_bookAuthor() = "") Then
            If (SelectBookgenres(book)) Then
                MsgBox("按书类型查询，如下表")
                objdataSet = SelectBookgenresTable(book)
                Return objdataSet
            End If
        ElseIf (book.Get_bookAuthor() <> "" And book.Get_bookId() = "" And book.Get_bookName() = "" And book.Get_bookGenres() = "") Then
            If (SelectBookauthor(book)) Then
                MsgBox("按作者查询，如下表")
                objdataSet = SelectBookauthorTable(book)
                Return objdataSet
            Else
                MsgBox("抱歉，此书店没有该作者的书的信息！")
            End If
        ElseIf (book.Get_bookId() <> "" And book.Get_bookName() = "" And book.Get_bookGenres() = "" And book.Get_bookAuthor() = "") Then
            If (SelectBookid(book)) Then
                MsgBox("按编号查询，如下表")
                objdataSet = SelectBookidTable(book)
                Return objdataSet
            Else
                MsgBox("抱歉，此书店没有该编号的书！")
            End If
        Else
            MsgBox("请只输入一个条件查询！")
        End If
        Return 0
    End Function

    Public Function manageBookAll_Select(book As Book)
        If (book.Get_bookId() <> "") Then
            If (book.Get_bookName() <> "") Then
                If (book.Get_bookGenres() <> "") Then
                    If (book.Get_bookAuthor() <> "") Then
                        objdataSet = SelectBookAllTable(book)
                        Return objdataSet
                    ElseIf (book.Get_bookAuthor() = "") Then
                        objdataSet = SelectBookTable1(book)
                        Return objdataSet
                    End If
                ElseIf (book.Get_bookGenres() = "") Then
                    If (book.Get_bookAuthor() <> "") Then
                        objdataSet = SelectBookTable2(book)
                        Return objdataSet
                    ElseIf (book.Get_bookAuthor() = "") Then
                        objdataSet = SelectBookTable3(book)
                        Return objdataSet
                    End If
                End If
            ElseIf (book.Get_bookName() = "") Then
                If (book.Get_bookGenres() <> "") Then
                    If (book.Get_bookAuthor() <> "") Then
                        objdataSet = SelectBookTable4(book)
                        Return objdataSet
                    ElseIf (book.Get_bookAuthor() = "") Then
                        objdataSet = SelectBookTable5(book)
                        Return objdataSet
                    End If
                ElseIf (book.Get_bookGenres() = "") Then
                    If (book.Get_bookAuthor() <> "") Then
                        objdataSet = SelectBookTable6(book)
                        Return objdataSet
                    ElseIf (book.Get_bookAuthor() = "") Then
                        objdataSet = SelectBookTable7(book)
                        Return objdataSet
                    End If
                End If
            End If
        ElseIf (book.Get_bookId() = "") Then
            If (book.Get_bookName() <> "") Then
                If (book.Get_bookGenres() <> "") Then
                    If (book.Get_bookAuthor() <> "") Then
                        objdataSet = SelectBookTable8(book)
                        Return objdataSet
                    ElseIf (book.Get_bookAuthor() = "") Then
                        objdataSet = SelectBookTable9(book)
                        Return objdataSet
                    End If
                ElseIf (book.Get_bookGenres() = "") Then
                    If (book.Get_bookAuthor() <> "") Then
                        objdataSet = SelectBookTable10(book)
                        Return objdataSet
                    ElseIf (book.Get_bookAuthor() = "") Then
                        objdataSet = SelectBookTable11(book)
                        Return objdataSet
                    End If
                End If
            ElseIf (book.Get_bookName() = "") Then
                If (book.Get_bookGenres() <> "") Then
                    If (book.Get_bookAuthor() <> "") Then
                        objdataSet = SelectBookTable12(book)
                        Return objdataSet
                    ElseIf (book.Get_bookAuthor() = "") Then
                        objdataSet = SelectBookTable13(book)
                        Return objdataSet
                    End If
                ElseIf (book.Get_bookGenres() = "") Then
                    If (book.Get_bookAuthor() <> "") Then
                        objdataSet = SelectBookTable14(book)
                        Return objdataSet
                    ElseIf (book.Get_bookAuthor() = "") Then
                        objdataSet = SelectBookTable15(book)
                        Return objdataSet
                    End If
                End If
            Else
                MsgBox("输入的查询格式错误，请重新输入！")
            End If
        End If
        
        Return 0
    End Function

    Public Sub book_Delete(book As Book)
        If (SelectBookid(book) = 1) Then
            DeleteBookid(book)
        Else
            MsgBox("没有此书信息，无法删除，请点击添加！")
        End If

    End Sub

    Public Sub book_Insert(book As Book)
        If (SelectBookid(book)) Then
            MsgBox("书编号已存在，不能重复插入！", 64, "提示")
        Else
            InsertBook(book)

        End If

    End Sub

    Public Sub book_Update(book As Book)
        If (book.Get_bookId() <> "") Then
            If (SelectBookid(book) = 1) Then
                UpdateBook(book)
            Else
                MsgBox("没有此书信息，无法更新，请点击添加！")
            End If
        End If
    End Sub

    Public Function bookTable_Select(book As Book)
        objdataSet = SelectBookTable(book)
        Return objdataSet
    End Function

    Public Function Statistics_Book(book As Book)
        objdataSet = SelectBookTable7(book)
        Return objdataSet
    End Function

End Module
