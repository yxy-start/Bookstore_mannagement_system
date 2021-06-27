Public Class Consumer_Book

    Dim book As New Book()
    Dim objdataSet As New DataSet
    Dim linenum As Integer
    Dim dr As DataRow

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        linenum = 0
        Try
            Dim bookid As String = TextBox3.Text
            Dim bookname As String = TextBox1.Text
            Dim bookgenres As String = ComboBox1.Text
            Dim bookauthor As String = TextBox2.Text
            book.Set_bookId(bookid)
            book.Set_bookGenres(bookgenres)
            book.Set_bookName(bookname)
            book.Set_bookAuthor(bookauthor)

            objdataSet = consumerbookSelect(book)
            DataGridView1.DataSource = objdataSet.Tables("book")
            DataGridView1.AllowUserToAddRows = False                        'DataGridView不显示最后空白的行
            linenum = DataGridView1.CurrentRow.Index
            DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)    '移动游标
            DataGridView1.Rows(linenum).Selected = True                         '设置选中行

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        linenum = 0
        Try
            Dim bookid As String = TextBox3.Text
            Dim bookname As String = TextBox1.Text
            Dim bookgenres As String = ComboBox1.Text
            Dim bookauthor As String = TextBox2.Text
            Dim bookpress As String = TextBox4.Text
            book.Set_bookId(bookid)
            book.Set_bookGenres(bookgenres)
            book.Set_bookName(bookname)
            book.Set_bookAuthor(bookauthor)
            book.Set_bookPrice(bookpress)

            objdataSet = consumerbookAllSelect(book)
            DataGridView1.DataSource = objdataSet.Tables("book")
            DataGridView1.AllowUserToAddRows = False                        'DataGridView不显示最后空白的行
            linenum = DataGridView1.CurrentRow.Index
            DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)    '移动游标
            DataGridView1.Rows(linenum).Selected = True                         '设置选中行

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim systembook As String = ""
    Public Sub book1()
        If Not dr.IsNull("bookId") Then
            TextBox3.Text = dr.Item("bookId")
            systembook = TextBox3.Text
        Else
            TextBox3.Text = ""
            systembook = ""
        End If
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
        If Not dr.IsNull("bookPress") Then
            TextBox4.Text = dr.Item("bookPress")
        Else
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        linenum = DataGridView1.CurrentRow.Index
        DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)  '移动游标
        DataGridView1.Rows(linenum).Selected = True '设置选中行
        dr = objdataSet.Tables(0).Rows(linenum)
        Call book1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
    End Sub
End Class