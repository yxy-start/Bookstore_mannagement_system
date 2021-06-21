Public Class Manage_Book

    Dim book As New Book()
    Dim objdataSet As New DataSet
    Dim linenum As Integer
    Dim dr As DataRow

    '单条件查询
    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        linenum = 0
        Try
            Dim bookname As String = TextBox1.Text
            Dim bookgenres As String = ComboBox1.Text
            Dim bookauthor As String = TextBox2.Text
            Dim bookprice As String = TextBox3.Text
            book.Set_bookGenres(bookgenres)
            book.Set_bookName(bookname)
            book.Set_bookAuthor(bookauthor)
            'book.Set_bookPrice(bookprice)

            objdataSet = manageBook_Select(book)
            DataGridView1.DataSource = objdataSet.Tables("book")
            DataGridView1.AllowUserToAddRows = False                        'DataGridView不显示最后空白的行
            linenum = DataGridView1.CurrentRow.Index
            DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)    '移动游标
            DataGridView1.Rows(linenum).Selected = True                         '设置选中行

        Catch ex As Exception
        End Try

    End Sub

    '多条件查询
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        linenum = 0
        Try
            Dim bookname As String = TextBox1.Text
            Dim bookgenres As String = ComboBox1.Text
            Dim bookauthor As String = TextBox2.Text
            Dim bookprice As String = TextBox3.Text
            book.Set_bookGenres(bookgenres)
            book.Set_bookName(bookname)
            book.Set_bookAuthor(bookauthor)
            'book.Set_bookPrice(bookprice)
            objdataSet = manageBookAll_Select(book)
            DataGridView1.DataSource = objdataSet.Tables("book")
            DataGridView1.AllowUserToAddRows = False                        'DataGridView不显示最后空白的行
            linenum = DataGridView1.CurrentRow.Index
            DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)    '移动游标
            DataGridView1.Rows(linenum).Selected = True                         '设置选中行

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bookname As String = TextBox1.Text
        book.Set_bookName(bookname)
        If TextBox1.Text = "" Then
            MsgBox("没有选择记录不能删除！", 64, "提示")
        Else
            Dim delet As Integer
            delet = MsgBox("真的要删除吗?", 16 + 4, "提示")
            If delet = 6 Then
                book_Delete(book)
                Call book2()
                MsgBox("删除成功，请重新进入！", 64, "提示")
                Me.Close()
            End If

        End If
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim manageAddBook As New Manage_Book_Add(book)
        manageAddBook.ShowDialog()

    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim bookname As String = TextBox1.Text
        book.Set_bookName(bookname)

        If TextBox1.Text = "" Then
            MsgBox("没有选择记录不能修改！", 64, "提示")
        Else
            Dim manageUpBook As New Manage_Book_Update(book)
            manageUpBook.ShowDialog()
            Me.Close()
        End If
    End Sub

    Public Sub book2()
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Dim systembook As String = ""
    Public Sub book1()
        If Not dr.IsNull("bookName") Then
            TextBox1.Text = dr.Item("bookName")
            systembook = TextBox1.Text
        Else
            TextBox1.Text = ""
            systembook = ""
        End If
        If Not dr.IsNull("bookGenres") Then
            ComboBox1.Text = dr.Item("bookGenres")
        Else
            ComboBox1.Text = ""
        End If
        If Not dr.IsNull("bookAuthor") Then
            TextBox2.Text = dr.Item("bookAuthor")
        Else
            TextBox2.Text = ""
        End If
        If Not dr.IsNull("bookPrice") Then
            TextBox3.Text = dr.Item("bookPrice")
        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        linenum = DataGridView1.CurrentRow.Index
        DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)  '移动游标
        DataGridView1.Rows(linenum).Selected = True '设置选中行
        dr = objdataSet.Tables(0).Rows(linenum)
        Call book1()
    End Sub
End Class