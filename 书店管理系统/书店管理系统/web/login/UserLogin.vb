Public Class UserLogin

    Dim user As New User()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        user.Set_用户名(username)
        user.Set_用户密码(password)
        If RadioButton1.Checked = True Then
            user.Set_table("系统用户表")
            UserSystemIndex(user)

        ElseIf RadioButton2.Checked = True Then
            user.Set_table("普通用户表")
            UserIndex(user)


        Else
            MsgBox("请选择角色！")
        End If
    End Sub
   
    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        If username = "" Then
            MsgBox("请输入用户名！")
        Else
            user.Set_用户名(username)
            user.Set_用户密码(password)
            Dim update As New UserUpdate(user)
            update.ShowDialog()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim zc As New UserRegister
        zc.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class