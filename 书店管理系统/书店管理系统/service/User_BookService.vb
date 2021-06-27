Module User_BookService
<<<<<<< HEAD
    Dim objdataSet As New DataSet
    Public Function consumerbookSelect(book As Book)
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
                MsgBox("按书编号查询，如下表")
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

    Public Function consumerbookAllSelect(book As Book)
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

=======
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
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
End Module
