Public Class UserUpdate
    Private user As User
    Public Sub New(u As User)
        InitializeComponent()
        user = u
    End Sub
    Private Sub UserUpdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = user.Get_用户名()
        TextBox1.Text = user.Get_用户密码()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("请输入用户名！")
        Else
            user.Set_用户密码(TextBox1.Text)
            userupdatapassworld(user)
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class