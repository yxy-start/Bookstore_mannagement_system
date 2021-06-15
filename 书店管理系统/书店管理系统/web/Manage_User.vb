Public Class Manage_User

    Dim manageUser As New ManageUser()

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim managename As String = TextBox1.Text
        Dim managepassworld As String = TextBox2.Text
        Dim manageiphone As String = TextBox3.Text
        If (managename = "") Then
            MsgBox("管理员名字不能为空！")
        Else
            If (managepassworld = "") Then
                MsgBox("管理员密码不能为空！")
            Else
                If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                    MsgBox("请选择性别！")
                Else
                    If (manageiphone = "") Then
                        MsgBox("电话号码不能为空！")
                    Else
                        If (RadioButton1.Checked = True) Then
                            manageUser.Set_manageSex("男")
                        End If
                        If (RadioButton2.Checked = True) Then
                            manageUser.Set_manageSex("女")
                        End If
                        manageUser.Set_manageName(managename)
                        manageUser.Set_managePassworld(managepassworld)
                        manageUser.Set_manageIphone(manageiphone)
                        manageUser_Insert(manageUser)
                        Me.Close()
                    End If
                    
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim managename As String = TextBox1.Text

        If (managename = "") Then
            MsgBox("管理员名字不能为空！请输入管理员名字进行删除！")
        Else
            manageUser.Set_manageName(managename)
            manageUser_delete(manageUser)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim managename As String = TextBox1.Text
        If (managename = "") Then
            MsgBox("管理员名字不能为空！请输入管理员名字进行查询！")
        Else
            manageUser.Set_manageName(managename)
            manageUser_Select(manageUser)
        End If
    End Sub

    'Private Sub Manage_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: 这行代码将数据加载到表“BookstoreDataSet.系统用户表”中。您可以根据需要移动或删除它。
    '    Me.系统用户表TableAdapter.Fill(Me.BookstoreDataSet.系统用户表)

    'End Sub

    Private Sub Manage_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

   
End Class