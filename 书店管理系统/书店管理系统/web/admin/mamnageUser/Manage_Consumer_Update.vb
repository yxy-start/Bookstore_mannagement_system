Public Class Manage_Consumer_Update

    Private user As User
    Public Sub New(u As User)
        InitializeComponent()
        user = u
    End Sub
    Private Sub Manage_Consumer_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = user.Get_用户编号()
        TextBox1.Text = user.Get_用户名()
        TextBox2.Text = user.Get_电话号码()
        TextBox3.Text = user.Get_籍贯()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim username As String = TextBox1.Text
        Dim iphone As String = TextBox2.Text
        Dim brithFrom As String = TextBox3.Text

        If (username = "") Then
            MsgBox("用户名不能为空！")
        Else
            If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                MsgBox("请选择性别！")
            Else
                If (iphone = "") Then
                    MsgBox("电话号码不能为空！")
                Else
                    If (brithFrom = "") Then
                        MsgBox("籍贯不能为空！")
                    Else
                        If (RadioButton1.Checked = True) Then
                            user.Set_性别("男")
                        End If
                        If (RadioButton2.Checked = True) Then
                            user.Set_性别("女")
                        End If
                        user.Set_用户名(username)
                        user.Set_性别(user.Get_性别())
                        user.Set_电话号码(iphone)
                        user.Set_籍贯(brithFrom)
                        user.Set_table("普通用户表")
                        UpdateManageConsumer(user)
                        MsgBox("更新成功，请重新进入！", 64, "提示")
                        Me.Close()
                    End If
                End If
            End If
        End If
        
    End Sub

   
    
End Class