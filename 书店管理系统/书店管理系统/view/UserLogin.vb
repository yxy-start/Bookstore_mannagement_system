Public Class UserLogin

    Private 用户名 As String
    Private 用户密码 As String
    Private 角色 As String
    Private table As String

    Private Sub f()
        Dim s1, s2, s3, s4 As Integer
        s1 = Int(Rnd() * (9 - 0 + 1))
        s2 = Int(Rnd() * (9 - 0 + 1))
        s3 = Int(Rnd() * (9 - 0 + 1))
        s4 = Int(Rnd() * (9 - 0 + 1))
        Label5.Text = s1 & s2 & s3 & s4
    End Sub

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

    Public Function Get_table()
        Return table
    End Function
    Public Sub Set_table(t As String)
        table = t
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim user As New UserLogin
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        user.Set_用户名(username)
        user.Set_用户密码(password)
        If TextBox3.Text = Label5.Text Then

            If RadioButton1.Checked = True Then
                user.Set_table("系统用户表")
                UserSystemIndex(user)
            ElseIf RadioButton2.Checked = True Then
                user.Set_table("普通用户表")
                UserIndex(user)
            Else
                MsgBox("请选择角色！")
                Call f()
                TextBox3.Text = ""
            End If
        Else
            MsgBox("验证码输入错误，请重新输入！")
        End If

    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox2.PasswordChar = "*"
        Call f()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim zc As New UserRegister
        zc.ShowDialog()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Call f()
    End Sub

End Class