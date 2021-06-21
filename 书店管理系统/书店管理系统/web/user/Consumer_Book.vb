Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Consumer_Book

    Dim book As New Book()
    Dim conn As String = sqlconn()
    Dim conn2 As String = sqlconn2()
    Dim linenum As Integer
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        linenum = 0
        Dim bookname As String = TextBox1.Text
        Dim bookgenres As String = ComboBox1.Text
        Dim bookauthor As String = TextBox2.Text
        book.Set_bookGenres(bookgenres)
        book.Set_bookName(bookname)
        book.Set_bookAuthor(bookauthor)
        consumerbookSelect(book)
        Dim sqlConnection As New SqlConnection(conn2)
        sqlConnection.Open()
        Dim objdataSet As New DataSet
        If (bookname <> "") Then
            Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            da.Fill(objdataSet, "book")
            DataGridView1.DataSource = objdataSet.Tables("book")
            DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

        ElseIf (bookgenres <> "") Then
            Dim strsql As String = "select * from Book where bookGenres = '" & book.Get_bookGenres() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            da.Fill(objdataSet, "book")
            DataGridView1.DataSource = objdataSet.Tables("book")
            DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

        ElseIf (bookauthor <> "") Then
            Dim strsql As String = "select * from Book where bookAuthor = '" & book.Get_bookAuthor() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            da.Fill(objdataSet, "book")
            DataGridView1.DataSource = objdataSet.Tables("book")
            DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        linenum = 0
        Dim bookname As String = TextBox1.Text
        Dim bookgenres As String = ComboBox1.Text
        Dim bookauthor As String = TextBox2.Text
        book.Set_bookGenres(bookgenres)
        book.Set_bookName(bookname)
        book.Set_bookAuthor(bookauthor)
        consumerbookSelect1(book)
        Dim sqlConnection As New SqlConnection(conn2)
        sqlConnection.Open()
        Dim objdataSet As New DataSet
        If (bookname <> "") Then
            If (bookgenres <> "") Then
                If (bookauthor <> "") Then
                    Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "' and bookGenres = '" & book.Get_bookGenres() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
                    Dim da As New SqlDataAdapter(strsql, sqlConnection)
                    sqlConnection.Close()
                    da.Fill(objdataSet, "book")
                    DataGridView1.DataSource = objdataSet.Tables("book")
                    DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行
                ElseIf (bookauthor = "") Then
                    Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "' and bookGenres = '" & book.Get_bookGenres() & "'"
                    Dim da As New SqlDataAdapter(strsql, sqlConnection)
                    sqlConnection.Close()
                    da.Fill(objdataSet, "book")
                    DataGridView1.DataSource = objdataSet.Tables("book")
                    DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行
                End If
            ElseIf (bookgenres = "") Then
                If (bookauthor <> "") Then
                    Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
                    Dim da As New SqlDataAdapter(strsql, sqlConnection)
                    sqlConnection.Close()
                    da.Fill(objdataSet, "book")
                    DataGridView1.DataSource = objdataSet.Tables("book")
                    DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

                ElseIf (bookauthor = "") Then
                    Dim strsql As String = "select * from Book where bookName = '" & book.Get_bookName() & "' "
                    Dim da As New SqlDataAdapter(strsql, sqlConnection)
                    sqlConnection.Close()
                    da.Fill(objdataSet, "book")
                    DataGridView1.DataSource = objdataSet.Tables("book")
                    DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行
                End If
            End If
        ElseIf (bookname = "") Then
            If (bookgenres <> "") Then
                If (bookauthor <> "") Then
                    Dim strsql As String = "select * from Book where bookGenres = '" & book.Get_bookGenres() & "' and bookAuthor = '" & book.Get_bookAuthor() & "'"
                    Dim da As New SqlDataAdapter(strsql, sqlConnection)
                    sqlConnection.Close()
                    da.Fill(objdataSet, "book")
                    DataGridView1.DataSource = objdataSet.Tables("book")
                    DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

                ElseIf (bookauthor = "") Then
                    Dim strsql As String = "select * from Book where bookGenres = '" & book.Get_bookGenres() & "'"
                    Dim da As New SqlDataAdapter(strsql, sqlConnection)
                    sqlConnection.Close()
                    da.Fill(objdataSet, "book")
                    DataGridView1.DataSource = objdataSet.Tables("book")
                    DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

                End If
            ElseIf (bookgenres = "") Then
                If (bookauthor <> "") Then
                    Dim strsql As String = "select * from Book where bookAuthor = '" & book.Get_bookAuthor() & "'"
                    Dim da As New SqlDataAdapter(strsql, sqlConnection)
                    sqlConnection.Close()
                    da.Fill(objdataSet, "book")
                    DataGridView1.DataSource = objdataSet.Tables("book")
                    DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

                ElseIf (bookauthor = "") Then
                    Dim strsql As String = "select * from Book "
                    Dim da As New SqlDataAdapter(strsql, sqlConnection)
                    sqlConnection.Close()
                    da.Fill(objdataSet, "book")
                    DataGridView1.DataSource = objdataSet.Tables("book")
                    DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

                End If
            End If
        Else
            MsgBox("格式错误！")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class