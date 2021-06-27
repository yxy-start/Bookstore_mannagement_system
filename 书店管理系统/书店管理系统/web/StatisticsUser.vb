Public Class StatisticsUser
    Dim objdataSet As New DataSet
    Dim user As User
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objdataSet = Statistics_User(user)
        DataGridView1.DataSource = objdataSet.Tables("user")
        DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class