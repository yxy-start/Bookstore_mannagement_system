Public Class Manage_Consumer_Add

    Private user As User
    Public Sub New(u As User)
        InitializeComponent()
        user = u
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim user As New User()
        CountUserid(user)
        Dim userid As String = "PT" & user.Get_count + 1
        Dim username As String = TextBox2.Text.Trim
        Dim userpassworld As String = TextBox3.Text.Trim
        Dim iphone As String = TextBox4.Text.Trim
        Dim userfrom As String = TextBox5.Text.Trim


        If (username = "") Then
            MsgBox("用户名不能为空！")
        Else
            If (userpassworld = "") Then
                MsgBox("密码不能为空！")
            Else
                If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                    MsgBox("请选择性别！")
                Else
                    If (iphone = "") Then
                        MsgBox("电话号码不能为空！")
                    Else
                        If (userfrom = "") Then
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
                            user.Set_用户密码(userpassworld)
                            user.Set_性别(user.Get_性别())
                            user.Set_电话号码(iphone)
                            user.Set_籍贯(userfrom)
                            user.Set_table("普通用户表")
                            manageConsumer_Insert(user)

                        End If

                    End If
                End If
            End If
        End If


    End Sub

   
End Class