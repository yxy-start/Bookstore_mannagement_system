Public Class Book_System

    Dim book As New Book()
   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bookname As String = TextBox1.Text
        Dim bookgenres As String = ComboBox1.Text
        Dim bookauthor As String = TextBox2.Text
        Dim bookprice As String = TextBox3.Text
        book.Set_bookGenres(bookgenres)
        book.Set_bookName(bookname)
        book.Set_bookAuthor(bookauthor)
        'book.Set_bookPrice(bookprice)
        book_Select(book)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bookname As String = TextBox1.Text
        Dim bookgenres As String = ComboBox1.Text
        Dim bookauthor As String = TextBox2.Text
        Dim bookprice As String = TextBox3.Text
        book.Set_bookGenres(bookgenres)
        book.Set_bookName(bookname)
        book.Set_bookAuthor(bookauthor)
        book_Delete(book)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bookname As String = TextBox1.Text
        Dim bookgenres As String = ComboBox1.Text
        Dim bookauthor As String = TextBox2.Text
        Dim bookprice As String = TextBox3.Text
        If (bookname = "") Then
            MsgBox("书名不能为空！")
        Else
            If (bookgenres = "") Then
                MsgBox("书的类别不能为空！")
            Else
                If (bookauthor = "") Then
                    MsgBox("书的作者不能为空！")
                Else
                    If (bookprice = "" Or Val(bookprice) < 0) Then
                        MsgBox("请输入价格或者价格格式不对")
                    Else
                        book.Set_bookName(bookname)
                        book.Set_bookGenres(bookgenres)
                        book.Set_bookAuthor(bookauthor)
                        book.Set_bookPrice(Int(bookprice))
                        book_Insert(book)
                        Me.Close()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bookname As String = TextBox1.Text
        Dim bookgenres As String = ComboBox1.Text
        Dim bookauthor As String = TextBox2.Text
        Dim bookprice As String = TextBox3.Text
        If (bookname = "") Then
            MsgBox("书名不能为空，请输入书名点击更新！")
        Else
            If (bookgenres = "") Then
                MsgBox("书的类别不能为空！")
            Else
                If (bookauthor = "") Then
                    MsgBox("书的作者不能为空！")
                Else
                    If (bookprice = "" Or Val(bookprice) < 0) Then
                        MsgBox("请输入价格或者价格格式不对")
                    Else
                        book.Set_bookName(bookname)
                        book.Set_bookGenres(bookgenres)
                        book.Set_bookAuthor(bookauthor)
                        book.Set_bookPrice(Int(bookprice))
                        book_Update(book)
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub
End Class