Imports System.Data.SqlClient
Imports System.Data.OleDb

Module BookDao

    Dim conn As String = sqlconn()
    Dim conn2 As String = sqlconn2()

    Public Function SelectBookid(book As Book)
        Dim f As Integer
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from Book where bookId = '" & book.Get_bookId() & "'"
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

    Public Function SelectBookname(book As Book)
        Dim f As Integer
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
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from Book where bookAuthor = '" & book.Get_bookAuthor() & "'"
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

    Public Sub DeleteBookid(book As Book)
        Try
            Dim strsql As String = "delete from Book where bookid ='" & book.Get_bookId() & "'"
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
            Dim strsql As String = "insert into Book(bookId ,bookName ,bookGenres ,bookAuthor ,bookPrice,bookPress ) values('" & book.Get_bookId() & "','" & book.Get_bookName() & "','" & book.Get_bookGenres() & "','" & book.Get_bookAuthor() & "','" & book.Get_bookPrice() & "','" & book.Get_bookPress() & "')"
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
            Dim strsql As String = "update Book set bookName = '" & book.Get_bookName() & "', bookGenres = '" & book.Get_bookGenres() & "',bookAuthor = '" & book.Get_bookAuthor() & "',bookPrice = '" & book.Get_bookPrice() & "',bookPress = '" & book.Get_bookPress() & "' where bookId ='" & book.Get_bookId() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            objconn.Close()
        Catch ex As Exception
            MsgBox("UpdateBook:" + ex.Message)
        End Try
    End Sub

    Public Function SelectBookTable(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookGenres = '" & book.Get_bookGenres() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function SelectBookidTable(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookId = '" & book.Get_bookId() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookidTable" + ex.Message)
        End Try
        Return 0
    End Function
    Public Function SelectBooknameTable(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBooknameTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookgenresTable(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookGenres = '" & book.Get_bookGenres() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookgenresTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookauthorTable(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookauthorTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookAllTable(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where  bookId = '" & book.Get_bookId() & "'and  bookName = '" & book.Get_bookName() & "' and bookGenres = '" & book.Get_bookGenres() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookAllTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable1(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where  bookId = '" & book.Get_bookId() & "'and  bookName = '" & book.Get_bookName() & "' and bookGenres = '" & book.Get_bookGenres() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable1" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable2(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookId = '" & book.Get_bookId() & "'and bookName = '" & book.Get_bookName() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable2" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable3(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookId = '" & book.Get_bookId() & "'and bookName = '" & book.Get_bookName() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable3" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable4(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookId = '" & book.Get_bookId() & "'and bookGenres = '" & book.Get_bookGenres() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable4" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable5(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookId = '" & book.Get_bookId() & "'and bookGenres = '" & book.Get_bookGenres() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable5" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable6(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookId = '" & book.Get_bookId() & "'and bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable6" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable7(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookId = '" & book.Get_bookId() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable7" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable8(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "' and bookGenres = '" & book.Get_bookGenres() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable8" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable9(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where  bookName = '" & book.Get_bookName() & "' and bookGenres = '" & book.Get_bookGenres() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable9" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable10(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable10" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable11(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable11" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable12(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookGenres = '" & book.Get_bookGenres() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable12" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable13(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookGenres = '" & book.Get_bookGenres() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable13" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable14(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book where bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable14" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectBookTable15(book As Book)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select * from Book "
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "book")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectBookTable15" + ex.Message)
        End Try
        Return 0
    End Function



End Module
