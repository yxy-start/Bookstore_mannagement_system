Imports System.Data.SqlClient
Imports System.Data.OleDb

Module BookDao

    Dim conn As String = sqlconn()
    Dim conn2 As String = sqlconn2()


    Public Function SelectBookname(book As Book)
        Dim f As Integer
        Dim book1 As New Book_System
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from Book where bookName = '" & book.Get_bookName() & "'"
            objconn.Open()
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()
        Catch ex As Exception

        End Try
        If (f > 0) Then
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            da.Dispose()
            book1.DataGridView1.DataSource = objdataSet.Tables("book")

            'objconn.Open()
            'objAdap = New OleDbDataAdapter(strsql1, objconn)
            'objdataSet.Reset()                                  '清除数据集
            'objAdap.Fill(objdataSet, "book")                    '第二个参数就是给这个虚拟表起个名字
            'book.DataGridView1.DataSource = objset1.Tables("book")
            'book.DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行
            'book.DataGridView1.CurrentCell = book.DataGridView1.Rows(linenum).Cells(0)  '移动游标
            'dr = objset1.Tables(0).Rows(linenum)

            Return 1
        Else
            Return 0
        End If

    End Function

    
    Public Function SelectBookgenres(book As Book)
        Dim f As Integer
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from Book where bookGenres = '" & book.Get_bookGenres() & "'"
            objconn.Open()
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()
        Catch ex As Exception

        End Try
        If (f > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function SelectBookauthor(book As Book)
        Dim f As Integer
        Dim book1 As New Book_System

        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from Book where bookName = '" & book.Get_bookAuthor() & "'"
            objconn.Open()
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()
        Catch ex As Exception

        End Try
        If (f > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Sub DeleteBookname(book As Book)
        Try
            Dim strsql As String = "delete from Book where bookName ='" & book.Get_bookName() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            MsgBox("删除书籍成功！")
            objconn.Close()
        Catch ex As Exception
            MsgBox("DeleteBookname:" + ex.Message)
        End Try
    End Sub

    Public Sub InsertBook(book As Book)
        Try
            Dim strsql As String = "insert into Book(bookName ,bookGenres ,bookAuthor ,bookPrice ) values('" & book.Get_bookName() & "','" & book.Get_bookGenres() & "','" & book.Get_bookAuthor() & "','" & book.Get_bookPrice() & "')"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            MsgBox("添加书籍成功！")
            objconn.Close()
        Catch ex As Exception
            MsgBox("InsertBook:" + ex.Message)
        End Try
    End Sub

    Public Sub UpdateBook(book As Book)
        Try
            Dim strsql As String = "update Book set bookGenres = '" & book.Get_bookGenres() & "',bookAuthor = '" & book.Get_bookAuthor() & "',bookPrice = '" & book.Get_bookPrice() & "' where bookName ='" & book.Get_bookName() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            MsgBox("更新书籍成功！")
            objconn.Close()
        Catch ex As Exception
            MsgBox("UpdateBook:" + ex.Message)
        End Try

    End Sub

End Module
