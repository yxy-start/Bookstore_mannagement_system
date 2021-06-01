Public Class UserRegister
    Private 用户名 As String
    Private 用户密码 As String
    Private 性别 As String
    Private 电话号码 As String
    Private table As String

    Public Function Get_用户名()
        Return 用户名
    End Function

    Public Sub Set_用户名(username As String)
        用户名 = username
    End Sub

    Public Function Get_用户密码()
        Return 用户密码
    End Function

    Public Sub Set_用户密码(passworld As String)
        用户密码 = passworld
    End Sub

    Public Function Get_性别()
        Return 性别
    End Function

    Public Sub Set_性别(sex As String)
        性别 = sex
    End Sub

    Public Function Get_电话号码()
        Return 电话号码
    End Function

    Public Sub Set_电话号码(iPhone As String)
        电话号码 = iPhone
    End Sub

    Public Function Get_table()
        Return table
    End Function
    Public Sub Set_table(t As String)
        table = t
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New UserRegister
        Dim userlogin As New UserLogin
        Dim username As String = TextBox1.Text.Trim
        Dim passworld As String = TextBox2.Text.Trim
        Dim sex As String = GroupBox1.Text.Trim
        Dim iphone As String = TextBox4.Text.Trim

        user.Set_用户名(username)
        user.Set_用户密码(passworld)
        user.Set_性别(sex)
        user.Set_电话号码(iphone)
        user.Set_table("普通用户表")
        userLoginindex(user)

    End Sub


End Class