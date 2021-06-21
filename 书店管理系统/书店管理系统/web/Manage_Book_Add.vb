Public Class Manage_Book_Add

    Private book As Book
    Public Sub New(b As Book)
        InitializeComponent()
        book = b
    End Sub

    Private Sub Manage_Book_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
End Class