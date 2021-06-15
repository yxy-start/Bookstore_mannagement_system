Public Class Book

    Private bookName As String
    Private bookGenres As String
    Private bookAuthor As String
    Private bookPrice As Integer
    Private table As String

    Public Sub Set_bookName(bookName As String)
        Me.bookName = bookName
    End Sub
    Public Function Get_bookName()
        Return bookName
    End Function

    Public Function Get_bookGenres()
        Return bookGenres
    End Function
    Public Sub Set_bookGenres(bookGenres As String)
        Me.bookGenres = bookGenres
    End Sub

    Public Function Get_bookAuthor()
        Return bookAuthor
    End Function
    Public Sub Set_bookAuthor(bookAuthor As String)
        Me.bookAuthor = bookAuthor
    End Sub

    Public Function Get_bookPrice()
        Return bookPrice
    End Function
    Public Sub Set_bookPrice(bookPrice As Integer)
        Me.bookPrice = bookPrice
    End Sub

    Public Function Get_table()
        Return table
    End Function
    Public Sub Set_table(t As String)
        Me.table = t
    End Sub
End Class
