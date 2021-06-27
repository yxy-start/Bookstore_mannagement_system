Public Class Consumer_Update

    Private user As User
    Public Sub New(u As User)
        InitializeComponent()
        user = u

    End Sub

    Private Sub Consumer_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD
        Label6.Text = user.Get_用户编号()
        TextBox1.Text = user.Get_用户名()
        TextBox2.Text = user.Get_电话号码()
        TextBox3.Text = user.Get_籍贯()
        RadioButton1.Checked = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim username As String = TextBox1.Text
        Dim iphone As String = TextBox2.Text
        Dim userfrom As String = TextBox3.Text
        If (username = "") Then
            MsgBox("用户名不能为空！")
        Else
            If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                MsgBox("请选择性别！")
            Else
                If (iphone = "") Then
                    MsgBox("电话号码不能为空！")
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
                    user.Set_籍贯(userfrom)
                    user.Set_table("普通用户表")
                    consumerUpdate(user)
                    Me.Close()
                End If
            End If
        End If
        
=======
        Label5.Text = user.Get_用户名()
        TextBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iphone As String = TextBox1.Text
        If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
            MsgBox("请选择性别！")
        Else
            If (iphone = "") Then
                MsgBox("电话号码不能为空！")
            Else
                If (RadioButton1.Checked = True) Then
                    user.Set_性别("男")
                End If
                If (RadioButton2.Checked = True) Then
                    user.Set_性别("女")
                End If
                user.Set_性别(user.Get_性别())
                user.Set_电话号码(iphone)
                user.Set_table("普通用户表")
                consumerUpdate(user)
                Me.Close()
            End If
        End If
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

<<<<<<< HEAD
    
=======
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
End Class