Public Class Book

<<<<<<< HEAD
    Private bookId As String
    Private bookName As String
    Private bookGenres As String
    Private bookAuthor As String
    Private bookPrice As String
    Private bookPress As String
    Private table As String

    Public Function Get_bookId()
        Return bookId
    End Function
    Public Sub Set_bookId(bookId As String)
        Me.bookId = bookId
=======
    Private bookName As String
    Private bookGenres As String
    Private bookAuthor As String
    Private bookPrice As Integer
    Private table As String

    Public Sub Set_bookName(bookName As String)
        Me.bookName = bookName
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
    End Sub
    Public Function Get_bookName()
        Return bookName
    End Function
<<<<<<< HEAD
    Public Sub Set_bookName(bookName As String)
        Me.bookName = bookName
    End Sub
   
=======

>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
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
<<<<<<< HEAD
    Public Sub Set_bookPrice(bookPrice As String)
        Me.bookPrice = bookPrice
    End Sub
    Public Function Get_bookPress()
        Return bookPress
    End Function
    Public Sub Set_bookPress(bookPress As String)
        Me.bookPress = bookPress
    End Sub
=======
    Public Sub Set_bookPrice(bookPrice As Integer)
        Me.bookPrice = bookPrice
    End Sub
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1

    Public Function Get_table()
        Return table
    End Function
    Public Sub Set_table(t As String)
        Me.table = t
    End Sub
End Class
