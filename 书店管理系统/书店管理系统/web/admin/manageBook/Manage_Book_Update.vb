Public Class Manage_Book_Update

    Private book As Book
    Public Sub New(b As Book)
        InitializeComponent()
        book = b
    End Sub

    Private Sub Manage_Book_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = book.Get_bookId()
        TextBox1.Text = book.Get_bookName()
        ComboBox1.Text = book.Get_bookGenres()
        TextBox2.Text = book.Get_bookAuthor()
        TextBox3.Text = book.Get_bookPrice()
        TextBox4.Text = book.Get_bookPress()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bookname As String = TextBox1.Text
        Dim bookGenres As String = ComboBox1.Text
        Dim bookAuthor As String = TextBox2.Text
        Dim bookPrice As String = TextBox3.Text
        Dim bookPress As String = TextBox4.Text

        If (bookname = "") Then
            MsgBox("书名不能为空！")
        Else
            If (bookGenres = "") Then
                MsgBox("书籍类别不能为空！")
            Else
                If (bookAuthor = "") Then
                    MsgBox("书籍作者不能为空！")
                Else
                    If (bookPrice = "") Then
                        MsgBox("价格不能为空！")
                    Else
                        If (bookPress = "") Then
                            MsgBox("出版社不能为空！")
                        Else
                            book.Set_bookName(bookname)
                            book.Set_bookGenres(bookGenres)
                            book.Set_bookAuthor(bookAuthor)
                            book.Set_bookPrice(bookPrice)
                            book.Set_bookPress(bookPress)
                            book.Set_table("Book")
                            book_Update(book)
                            MsgBox("更新成功，请重新进入！", 64, "提示")
                            Me.Close()
                        End If

                    End If

                End If
            End If
        End If
       

    End Sub

   
End Class