Public Class Manage_Book_Add

    Private book As Book
    Public Sub New(b As Book)
        InitializeComponent()
        book = b
    End Sub

    Private Sub Manage_Book_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
<<<<<<< HEAD
        Dim bookid As String = TextBox5.Text
=======
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
        Dim bookname As String = TextBox1.Text
        Dim bookgenres As String = ComboBox1.Text
        Dim bookauthor As String = TextBox2.Text
        Dim bookprice As String = TextBox3.Text
<<<<<<< HEAD
        Dim bookpress As String = TextBox4.Text

        If (bookid = "") Then
            MsgBox("书编号不能为空！")
        Else
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
                            If (bookpress = "") Then
                                MsgBox("出版社不能为空！")
                            Else
                                book.Set_bookId(bookid)
                                book.Set_bookName(bookname)
                                book.Set_bookGenres(bookgenres)
                                book.Set_bookAuthor(bookauthor)
                                book.Set_bookPrice(bookprice)
                                book.Set_bookPress(bookpress)
                                book_Insert(book)

                            End If
                            
                        End If
=======
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
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
                    End If
                End If
            End If
        End If
<<<<<<< HEAD
        
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

=======
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
    End Sub
End Class