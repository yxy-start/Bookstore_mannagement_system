Public Class BookTable
    'Dim bookDao As BookDao()
    Dim objdataSet As New DataSet
    Private book As Book
    Public Sub New(b As Book)
        InitializeComponent()
        book = b
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(book.Get_bookGenres())
        '显示单个书的类型
        objdataSet = bookTable_Select(book)
        DataGridView1.DataSource = objdataSet.Tables("book")
        DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class