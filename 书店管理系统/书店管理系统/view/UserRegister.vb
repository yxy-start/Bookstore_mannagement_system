Public Class UserRegister

    Private Sub UserRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New UserLogin
        Dim username As String = TextBox1.Text
        Dim passworld As String = TextBox2.Text
        Dim sex As String = GroupBox1.Text
        Dim iphone As Long = TextBox4.Text

        user.Set_用户名(username)
        user.Set_用户密码(passworld)
        user.Set_性别(sex)
        user.Set_电话号码(iphone)

        user.Set_table("普通用户表")
        UserIndex(user)

    End Sub

    
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class