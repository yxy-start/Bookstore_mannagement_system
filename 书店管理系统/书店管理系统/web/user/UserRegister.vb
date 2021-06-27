Public Class UserRegister

    Private Sub UserRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New User()
        Dim userid As String = TextBox5.Text.Trim
        Dim username As String = TextBox1.Text.Trim
        Dim passworld As String = TextBox2.Text.Trim
        Dim userFrom As String = TextBox3.Text.Trim
        'Dim sex As String = GroupBox1.Text.Trim
        Dim iphone As String = TextBox4.Text.Trim

        If (userid = "") Then
            MsgBox("用户编号不能为空！")
        Else
            If (username = "") Then
                MsgBox("用户名不能为空！")
            Else
                If (passworld = "") Then
                    MsgBox("密码不能为空！")
                Else
                    If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                        MsgBox("请选择性别！")
                    Else
                        If (iphone = "") Then
                            MsgBox("电话号码不能为空！")
                        Else
                            If (userFrom = "") Then
                                MsgBox("籍贯不能为空！")
                            Else
                                If (RadioButton1.Checked = True) Then
                                    user.Set_性别("男")
                                End If
                                If (RadioButton2.Checked = True) Then
                                    user.Set_性别("女")
                                End If
                                user.Set_用户编号(userid)
                                user.Set_用户名(username)
                                user.Set_用户密码(passworld)
                                user.Set_性别(user.Get_性别())
                                user.Set_电话号码(iphone)
                                user.Set_籍贯(userFrom)
                                user.Set_table("普通用户表")
                                userLoginindex(user)
                                Me.Close()
                            End If

                        End If
                    End If
                End If
            End If
        End If
        

    End Sub
   
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class