Public Class Consumer

    Private user As User
    Public Sub New(u As User)
        InitializeComponent()
        user = u
    End Sub

    Private Sub Consumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = user.Get_用户编号()
        Label2.Text = user.Get_用户名()
        Label5.Text = user.Get_性别()
        Label6.Text = user.Get_电话号码()
        Label10.Text = user.Get_籍贯()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consumerUpdate As New Consumer_Update(user)
        consumerUpdate.ShowDialog()
        Me.Close()
    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Cancel As Integer
        Dim iAnswer As Integer
        iAnswer = MsgBox("真的要注销吗?", vbYesNo)
        If iAnswer = vbNo Then
            Cancel = True
        Else
            user.Set_用户编号(Label7.Text)
            consumerDelete(user)
            MsgBox("注销成功，即将退出此程序！")
            End
        End If

        
    End Sub
End Class